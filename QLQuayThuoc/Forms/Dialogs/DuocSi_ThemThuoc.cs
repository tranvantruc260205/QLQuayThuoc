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
    public partial class DuocSi_ThemThuoc : Form
    {
        private readonly Dictionary<int, ChiTietPhieuXinCap>
            danhSachThuocTam = new();

        private Thuoc? thuocDangChon;
        private bool dangXuLyDoiDong;

        public List<ChiTietPhieuXinCap> DanhSachThuocDaChon { get; private set; } = new();

        private const int MaKhoQuay = 2;
        public DuocSi_ThemThuoc()
        {
            InitializeComponent();

            StartPosition = FormStartPosition.CenterParent;

            nudSoLuong.Minimum = 0;
            nudSoLuong.Maximum = int.MaxValue;
            nudSoLuong.DecimalPlaces = 0;
            nudSoLuong.Increment = 1;

            txtGhiChu.MaxLength = 255;

            CauHinhDataGridView();
        }

        public DuocSi_ThemThuoc(
            IEnumerable<ChiTietPhieuXinCap> danhSachHienTai)
            : this()
        {
            foreach (ChiTietPhieuXinCap chiTiet
                in danhSachHienTai)
            {
                // Số lượng 0 không được tính là đã chọn.
                if (chiTiet.SoLuongYeuCau > 0)
                {
                    danhSachThuocTam[chiTiet.MaThuoc] =
                        SaoChepChiTiet(chiTiet);
                }
            }
        }

        private static ChiTietPhieuXinCap SaoChepChiTiet(
            ChiTietPhieuXinCap chiTiet)
        {
            return new ChiTietPhieuXinCap
            {
                MaPhieu = chiTiet.MaPhieu,
                MaThuoc = chiTiet.MaThuoc,
                SoLuongYeuCau = chiTiet.SoLuongYeuCau,
                SoLuongDuyet = chiTiet.SoLuongDuyet,
                GhiChu = chiTiet.GhiChu,
                Thuoc = chiTiet.Thuoc
            };
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

            dgv.Columns.Add("colMaThuoc", "Mã thuốc");
            dgv.Columns.Add("colTenThuoc", "Tên thuốc");
            dgv.Columns.Add("colHoatChat", "Hoạt chất");
            dgv.Columns.Add("colHamLuong", "Hàm lượng");
            dgv.Columns.Add("colDonViTinh", "Đơn vị");
            dgv.Columns.Add("colTonQuay", "Tồn quầy");
            dgv.Columns.Add("colDaNhap", "Trạng thái");

            dgv.AutoSizeColumnsMode =
    DataGridViewAutoSizeColumnsMode.None;

            dgv.Columns["colMaThuoc"].Width = 60;
            dgv.Columns["colHamLuong"].Width = 90;
            dgv.Columns["colDonViTinh"].Width = 65;
            dgv.Columns["colTonQuay"].Width = 75;

            // Hai cột dài tự chia khoảng trống còn lại.
            dgv.Columns["colTenThuoc"].AutoSizeMode =
                DataGridViewAutoSizeColumnMode.Fill;

            dgv.Columns["colTenThuoc"].FillWeight = 55;

            dgv.Columns["colHoatChat"].AutoSizeMode =
                DataGridViewAutoSizeColumnMode.Fill;

            dgv.Columns["colHoatChat"].FillWeight = 45;

            // Cột Trạng thái luôn có độ rộng cố định.
            dgv.Columns["colDaNhap"].AutoSizeMode =
                DataGridViewAutoSizeColumnMode.None;

            dgv.Columns["colDaNhap"].Width = 85;
            dgv.Columns["colDaNhap"].Visible = true;
        }

        private void LoadDanhSachThuoc(
    string tuKhoa = "")
        {
            try
            {
                using (AppDbContext db =
                    new AppDbContext())
                {
                    var truyVan =
                        db.Thuocs
                            .AsNoTracking()
                            .AsQueryable();

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

                    List<Thuoc> danhSachThuoc =
                        truyVan
                            .OrderBy(x => x.TenThuoc)
                            .ToList();

                    // Cộng tồn của tất cả các lô
                    // theo từng thuốc tại kho quầy số 2.
                    Dictionary<int, int> tonQuayTheoThuoc =
                        db.TonKhos
                            .AsNoTracking()
                            .Where(x =>
                                x.MaKho == MaKhoQuay)
                            .GroupBy(x =>
                                x.LoThuoc.MaThuoc)
                            .Select(nhom => new
                            {
                                MaThuoc = nhom.Key,

                                TonQuay = nhom.Sum(x =>
                                    x.SoLuongTon)
                            })
                            .ToDictionary(
                                x => x.MaThuoc,
                                x => x.TonQuay);

                    dangXuLyDoiDong = true;

                    try
                    {
                        dgv.Rows.Clear();

                        thuocDangChon = null;
                        nudSoLuong.Value = 0;
                        txtGhiChu.Clear();

                        foreach (Thuoc thuoc
                            in danhSachThuoc)
                        {
                            bool daNhap =
                                danhSachThuocTam.ContainsKey(
                                    thuoc.MaThuoc);

                            if (daNhap)
                            {
                                danhSachThuocTam[
                                    thuoc.MaThuoc
                                ].Thuoc = thuoc;
                            }

                            int tonQuay =
                                tonQuayTheoThuoc.TryGetValue(
                                    thuoc.MaThuoc,
                                    out int soLuongTon)
                                    ? soLuongTon
                                    : 0;

                            int viTriDong =
                                dgv.Rows.Add(
                                    thuoc.MaThuoc,
                                    thuoc.TenThuoc,
                                    thuoc.HoatChat,
                                    thuoc.HamLuong,
                                    thuoc.DonViTinh,
                                    tonQuay,
                                    daNhap
                                        ? "Đã nhập"
                                        : string.Empty);

                            dgv.Rows[viTriDong].Tag =
                                thuoc;
                        }

                        dgv.ClearSelection();
                        dgv.CurrentCell = null;
                    }
                    finally
                    {
                        dangXuLyDoiDong = false;
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

        private void HienThiThongTinDaNhap(
            int maThuoc)
        {
            if (danhSachThuocTam.TryGetValue(
                maThuoc,
                out ChiTietPhieuXinCap? chiTiet))
            {
                nudSoLuong.Value =
                    chiTiet.SoLuongYeuCau;

                txtGhiChu.Text =
                    chiTiet.GhiChu ??
                    string.Empty;
            }
            else
            {
                nudSoLuong.Value = 0;
                txtGhiChu.Clear();
            }

            nudSoLuong.Focus();
        }

        private void LuuThuocDangChon()
        {
            if (thuocDangChon == null)
            {
                return;
            }

            int soLuong =
                (int)nudSoLuong.Value;

            // Số lượng 0 nghĩa là bỏ thuốc khỏi danh sách.
            if (soLuong == 0)
            {
                danhSachThuocTam.Remove(
                    thuocDangChon.MaThuoc);

                CapNhatCotDaNhap(
                    thuocDangChon.MaThuoc,
                    false);

                return;
            }

            danhSachThuocTam[
                thuocDangChon.MaThuoc
            ] = new ChiTietPhieuXinCap
            {
                MaThuoc =
                    thuocDangChon.MaThuoc,

                Thuoc =
                    thuocDangChon,

                SoLuongYeuCau =
                    soLuong,

                SoLuongDuyet =
                    null,

                GhiChu =
                    string.IsNullOrWhiteSpace(
                        txtGhiChu.Text)
                        ? null
                        : txtGhiChu.Text.Trim()
            };

            CapNhatCotDaNhap(
                thuocDangChon.MaThuoc,
                true);
        }

        private void CapNhatCotDaNhap(
            int maThuoc,
            bool daNhap)
        {
            foreach (DataGridViewRow dong
                in dgv.Rows)
            {
                if (dong.Tag is Thuoc thuoc &&
                    thuoc.MaThuoc == maThuoc)
                {
                    dong.Cells[
                        "colDaNhap"
                    ].Value =
                        daNhap
                            ? "Đã nhập"
                            : string.Empty;

                    break;
                }
            }
        }

        private void DuocSi_ThemThuoc_Load(object sender, EventArgs e)
        {
            LoadDanhSachThuoc();
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

            // Lưu thuốc cũ trước khi chuyển dòng.
            LuuThuocDangChon();

            thuocDangChon = thuocMoi;

            HienThiThongTinDaNhap(
                thuocMoi.MaThuoc);
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            LuuThuocDangChon();

            LoadDanhSachThuoc(
                txtTimKiem.Text);
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
            LuuThuocDangChon();

            if (danhSachThuocTam.Count == 0)
            {
                MessageBox.Show(
                    "Vui lòng nhập số lượng cho ít nhất một thuốc!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            DanhSachThuocDaChon =
                danhSachThuocTam.Values
                    .Where(x =>
                        x.SoLuongYeuCau > 0)
                    .OrderBy(x =>
                        x.Thuoc.TenThuoc)
                    .Select(SaoChepChiTiet)
                    .ToList();

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
