using Microsoft.EntityFrameworkCore;
using QLQuayThuoc.Data;
using QLQuayThuoc.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLQuayThuoc.Forms.Dialogs
{
    public partial class ThemSuaThuocDonThuoc : Form
    {
        private readonly Dictionary<int, ChiTietDonThuoc> danhSachThuocTam = new();

        private Thuoc? thuocDangChon;
        private bool dangXuLyDoiDong;
        private int? maThuocChonBanDau;

        public List<ChiTietDonThuoc> DanhSachThuocDaChon { get; private set; } = new();

        public ThemSuaThuocDonThuoc()
        {
            InitializeComponent();

            StartPosition = FormStartPosition.CenterParent;

            CauHinhDataGridView();

            txtLieuDung.MaxLength = 255;
            txtTanSuat.MaxLength = 100;
            txtGhiChu.MaxLength = 255;
        }

        private void CauHinhDataGridView()
        {
            dgv.AutoGenerateColumns = false;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.ReadOnly = true;
            dgv.MultiSelect = false;
            dgv.RowHeadersVisible = false;

            dgv.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgv.Columns.Clear();

            dgv.Columns.Add(
                "colMaThuoc",
                "Mã thuốc");

            dgv.Columns.Add(
                "colTenThuoc",
                "Tên thuốc");

            dgv.Columns.Add(
                "colHoatChat",
                "Hoạt chất");

            dgv.Columns.Add(
                "colHamLuong",
                "Hàm lượng");

            dgv.Columns.Add(
                "colDonViTinh",
                "Đơn vị");

            dgv.Columns.Add(
                "colDaNhap",
                "Đã nhập");

            dgv.Columns["colMaThuoc"].Width = 75;
            dgv.Columns["colTenThuoc"].Width = 160;
            dgv.Columns["colHoatChat"].Width = 150;
            dgv.Columns["colHamLuong"].Width = 90;
            dgv.Columns["colDonViTinh"].Width = 80;

            dgv.Columns["colDaNhap"].AutoSizeMode =
                DataGridViewAutoSizeColumnMode.Fill;
        }

        public ThemSuaThuocDonThuoc(
            IEnumerable<ChiTietDonThuoc> danhSachHienTai,
            int? maThuocChonBanDau = null) : this()
        {
            foreach (ChiTietDonThuoc chiTiet
                in danhSachHienTai)
            {
                danhSachThuocTam[chiTiet.MaThuoc] =
                    SaoChepChiTiet(chiTiet);
            }

            this.maThuocChonBanDau =
                maThuocChonBanDau;
        }

        private static ChiTietDonThuoc SaoChepChiTiet(
            ChiTietDonThuoc chiTiet)
        {
            return new ChiTietDonThuoc
            {
                MaDonThuoc = chiTiet.MaDonThuoc,
                MaThuoc = chiTiet.MaThuoc,
                SoLuong = chiTiet.SoLuong,
                LieuDung = chiTiet.LieuDung,
                TanSuat = chiTiet.TanSuat,
                SoNgayDung = chiTiet.SoNgayDung,
                GhiChu = chiTiet.GhiChu,
                Thuoc = chiTiet.Thuoc
            };
        }

        private void HienThiThongTinDaNhap(
            int maThuoc)
        {
            if (danhSachThuocTam.TryGetValue(
                maThuoc,
                out ChiTietDonThuoc? chiTiet))
            {
                txtSoLuong.Text =
                    chiTiet.SoLuong.ToString();

                txtLieuDung.Text =
                    chiTiet.LieuDung;

                txtTanSuat.Text =
                    chiTiet.TanSuat;

                txtSoNgay.Text =
                    chiTiet.SoNgayDung.ToString();

                txtGhiChu.Text =
                    chiTiet.GhiChu ?? "";
            }
            else
            {
                XoaTrangThongTin();
            }

            txtSoLuong.Focus();
        }

        private void ChonDongTheoMaThuoc(
            int maThuoc,
            bool napLaiThongTin)
        {
            foreach (DataGridViewRow dong
                in dgv.Rows)
            {
                if (Convert.ToInt32(
                        dong.Cells["colMaThuoc"].Value)
                    != maThuoc)
                {
                    continue;
                }

                dangXuLyDoiDong = true;

                try
                {
                    dgv.ClearSelection();
                    dong.Selected = true;

                    dgv.CurrentCell =
                        dong.Cells["colMaThuoc"];
                }
                finally
                {
                    dangXuLyDoiDong = false;
                }

                if (napLaiThongTin &&
                    dong.Tag is Thuoc thuoc)
                {
                    thuocDangChon = thuoc;

                    HienThiThongTinDaNhap(
                        thuoc.MaThuoc);
                }

                break;
            }
        }

        private void XoaTrangThongTin()
        {
            txtSoLuong.Clear();
            txtLieuDung.Clear();
            txtTanSuat.Clear();
            txtSoNgay.Clear();
            txtGhiChu.Clear();
        }

        private void LoadDanhSachThuoc(
            string tuKhoa = "",
            int? maThuocCanChon = null)
        {
            try
            {
                using (AppDbContext db =
                    new AppDbContext())
                {
                    var truyVan = db.Thuocs
                        .AsNoTracking()
                        .Where(x =>
                            x.TrangThai ==
                            "DANG_KINH_DOANH");

                    tuKhoa = tuKhoa.Trim();

                    if (!string.IsNullOrWhiteSpace(tuKhoa))
                    {
                        if (int.TryParse(
                            tuKhoa,
                            out int maThuoc))
                        {
                            truyVan = truyVan.Where(x =>
                                x.MaThuoc == maThuoc ||
                                x.TenThuoc.Contains(tuKhoa) ||
                                x.HoatChat.Contains(tuKhoa) ||
                                x.HamLuong.Contains(tuKhoa));
                        }
                        else
                        {
                            truyVan = truyVan.Where(x =>
                                x.TenThuoc.Contains(tuKhoa) ||
                                x.HoatChat.Contains(tuKhoa) ||
                                x.HamLuong.Contains(tuKhoa));
                        }
                    }

                    var danhSachThuoc = truyVan
                        .OrderBy(x => x.TenThuoc)
                        .ToList();

                    dangXuLyDoiDong = true;

                    try
                    {
                        dgv.Rows.Clear();
                        thuocDangChon = null;
                        XoaTrangThongTin();

                        foreach (Thuoc thuoc
                            in danhSachThuoc)
                        {
                            int dong = dgv.Rows.Add(
                                thuoc.MaThuoc,
                                thuoc.TenThuoc,
                                thuoc.HoatChat,
                                thuoc.HamLuong,
                                thuoc.DonViTinh,
                                danhSachThuocTam.ContainsKey(
                                    thuoc.MaThuoc)
                                    ? "Đã nhập"
                                    : "");

                            dgv.Rows[dong].Tag = thuoc;
                        }

                        dgv.ClearSelection();
                        dgv.CurrentCell = null;
                    }
                    finally
                    {
                        dangXuLyDoiDong = false;
                    }

                    if (maThuocCanChon.HasValue)
                    {
                        ChonDongTheoMaThuoc(
                            maThuocCanChon.Value,
                            true);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Không thể tải danh sách thuốc!\n" +
                    ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private bool LuuThongTinThuocDangChon()
        {
            if (thuocDangChon == null)
            {
                return true;
            }

            bool coNhapThongTin =
                !string.IsNullOrWhiteSpace(txtSoLuong.Text) ||
                !string.IsNullOrWhiteSpace(txtLieuDung.Text) ||
                !string.IsNullOrWhiteSpace(txtTanSuat.Text) ||
                !string.IsNullOrWhiteSpace(txtSoNgay.Text) ||
                !string.IsNullOrWhiteSpace(txtGhiChu.Text);

            bool daCoTrongDanhSach =
                danhSachThuocTam.ContainsKey(
                    thuocDangChon.MaThuoc);

            // Thuốc mới và chưa nhập gì thì được bỏ qua.
            if (!coNhapThongTin && !daCoTrongDanhSach)
            {
                return true;
            }

            // Không cho xóa trắng thuốc đã nhập.
            if (!coNhapThongTin && daCoTrongDanhSach)
            {
                return BaoLoi(
                    "Thuốc này đã có thông tin. " +
                    "Không được xóa trắng toàn bộ các ô. " +
                    "Nếu muốn bỏ thuốc, hãy dùng nút Xóa dòng.",
                    txtSoLuong);
            }

            if (!int.TryParse(
                    txtSoLuong.Text.Trim(),
                    out int soLuong) ||
                soLuong <= 0)
            {
                return BaoLoi(
                    "Số lượng phải là số nguyên lớn hơn 0!",
                    txtSoLuong);
            }

            string lieuDung =
                txtLieuDung.Text.Trim();

            if (string.IsNullOrWhiteSpace(lieuDung))
            {
                return BaoLoi(
                    "Vui lòng nhập liều dùng!",
                    txtLieuDung);
            }

            string tanSuat =
                txtTanSuat.Text.Trim();

            if (string.IsNullOrWhiteSpace(tanSuat))
            {
                return BaoLoi(
                    "Vui lòng nhập tần suất!",
                    txtTanSuat);
            }

            if (!int.TryParse(
                    txtSoNgay.Text.Trim(),
                    out int soNgayDung) ||
                soNgayDung <= 0)
            {
                return BaoLoi(
                    "Số ngày dùng phải là số nguyên lớn hơn 0!",
                    txtSoNgay);
            }

            danhSachThuocTam[thuocDangChon.MaThuoc] =
                new ChiTietDonThuoc
                {
                    MaThuoc =
                        thuocDangChon.MaThuoc,

                    Thuoc =
                        thuocDangChon,

                    SoLuong =
                        soLuong,

                    LieuDung =
                        lieuDung,

                    TanSuat =
                        tanSuat,

                    SoNgayDung =
                        soNgayDung,

                    GhiChu =
                        string.IsNullOrWhiteSpace(
                            txtGhiChu.Text)
                            ? null
                            : txtGhiChu.Text.Trim()
                };

            CapNhatCotDaNhap(
                thuocDangChon.MaThuoc);

            return true;
        }

        private bool BaoLoi(
            string noiDung,
            Control controlCanFocus)
        {
            MessageBox.Show(
                noiDung,
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);

            controlCanFocus.Focus();
            return false;
        }

        private void CapNhatCotDaNhap(
            int maThuoc)
        {
            foreach (DataGridViewRow dong
                in dgv.Rows)
            {
                if (Convert.ToInt32(
                        dong.Cells["colMaThuoc"].Value)
                    == maThuoc)
                {
                    dong.Cells["colDaNhap"].Value =
                        "Đã nhập";

                    break;
                }
            }
        }

        private void ThemSuaThuocDonThuoc_Load(object sender, EventArgs e)
        {
            LoadDanhSachThuoc("", maThuocChonBanDau);
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (!LuuThongTinThuocDangChon())
            {
                return;
            }

            LoadDanhSachThuoc(txtTimKiem.Text.Trim());
        }

        private void txtTimKiem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnTimKiem.PerformClick();
                e.SuppressKeyPress = true;
            }
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (!LuuThongTinThuocDangChon())
            {
                return;
            }

            if (danhSachThuocTam.Count == 0)
            {
                MessageBox.Show(
                    "Vui lòng nhập ít nhất một thuốc!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            DanhSachThuocDaChon =
                danhSachThuocTam.Values
                    .OrderBy(x => x.Thuoc.TenThuoc)
                    .Select(SaoChepChiTiet)
                    .ToList();

            DialogResult = DialogResult.OK;
            Close();
        }

        private void dgv_SelectionChanged(object sender, EventArgs e)
        {
            if (dangXuLyDoiDong ||
                dgv.CurrentRow?.Tag
                    is not Thuoc thuocMoi)
            {
                return;
            }

            if (thuocDangChon != null &&
                thuocDangChon.MaThuoc ==
                thuocMoi.MaThuoc)
            {
                return;
            }

            if (thuocDangChon != null &&
                !LuuThongTinThuocDangChon())
            {
                ChonDongTheoMaThuoc(
                    thuocDangChon.MaThuoc,
                    false);

                return;
            }

            thuocDangChon = thuocMoi;

            HienThiThongTinDaNhap(
                thuocMoi.MaThuoc);
        }
    }
}
