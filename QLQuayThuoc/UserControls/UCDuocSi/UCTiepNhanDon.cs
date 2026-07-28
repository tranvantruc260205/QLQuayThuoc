using Microsoft.EntityFrameworkCore;
using QLQuayThuoc.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLQuayThuoc.UserControls
{
    public partial class UCTiepNhanDon : UserControl
    {
        private class ThongTinLo
        {
            public int MaLo { get; set; }

            public string SoLo { get; set; } =
                string.Empty;

            public DateTime NgayHetHan { get; set; }

            public int SoLuongTon { get; set; }
        }

        // Số lượng cần xuất của từng thuốc trong đơn.
        private readonly Dictionary<int, int>
            soLuongCanXuatTheoThuoc =
                new Dictionary<int, int>();

        // Danh sách lô còn hạn và còn tồn của từng thuốc.
        private readonly Dictionary<int, List<ThongTinLo>>
            danhSachLoTheoThuoc =
                new Dictionary<int, List<ThongTinLo>>();

        // Thuốc -> lô -> số lượng đã chọn để xuất.
        private readonly Dictionary<int, Dictionary<int, int>>
            soLuongXuatTheoThuoc =
                new Dictionary<int, Dictionary<int, int>>();

        private int maDonThuocDangTraCuu;
        private int maKhoQuay;
        private int? maThuocDangChon;
        private bool dangTaiBang;
        public UCTiepNhanDon()
        {
            InitializeComponent();

            CauHinhBang();
        }

        private void CauHinhBang()
        {
            dgv1.AutoGenerateColumns = false;
            dgv1.AllowUserToAddRows = false;
            dgv1.ReadOnly = true;
            dgv1.MultiSelect = false;

            dgv1.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgv2.AutoGenerateColumns = false;
            dgv2.AllowUserToAddRows = false;
            dgv2.ReadOnly = false;
            dgv2.MultiSelect = true;

            dgv2.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgv2.EditMode =
                DataGridViewEditMode.EditOnEnter;

            Column7.ReadOnly = true;
            Column8.ReadOnly = true;
            Column9.ReadOnly = true;
            Column10.ReadOnly = false;

            btnThanhToan.Enabled = false;
        }

        private void btnTraCuu_Click(
            object sender,
            EventArgs e)
        {
            TraCuuDonThuoc();
        }

        private void TraCuuDonThuoc()
        {
            XoaKetQuaTraCuu();

            if (!int.TryParse(
                txtMaDonThuoc.Text.Trim(),
                out int maDonThuoc))
            {
                MessageBox.Show(
                    "Mã đơn thuốc phải là số nguyên!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtMaDonThuoc.Focus();
                txtMaDonThuoc.SelectAll();

                return;
            }

            try
            {
                using (AppDbContext db =
                    new AppDbContext())
                {
                    var donThuoc =
                        db.DonThuocs
                            .AsNoTracking()
                            .Include(x =>
                                x.BenhNhan)
                            .Include(x =>
                                x.BacSi)
                            .Include(x =>
                                x.ChiTietDonThuocs)
                            .ThenInclude(x =>
                                x.Thuoc)
                            .FirstOrDefault(x =>
                                x.MaDonThuoc ==
                                    maDonThuoc);

                    if (donThuoc == null)
                    {
                        MessageBox.Show(
                            "Không tìm thấy đơn thuốc có mã " +
                            maDonThuoc + "!",
                            "Thông báo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);

                        return;
                    }

                    if (donThuoc.TrangThai !=
                        "CHO_XUAT_THUOC")
                    {
                        MessageBox.Show(
                            "Chỉ có thể tiếp nhận đơn đang chờ xuất thuốc.\n" +
                            "Trạng thái hiện tại: " +
                            HienThiTrangThai(
                                donThuoc.TrangThai),
                            "Thông báo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);

                        return;
                    }

                    if (donThuoc.ChiTietDonThuocs.Count ==
                        0)
                    {
                        MessageBox.Show(
                            "Đơn thuốc chưa có thuốc!",
                            "Thông báo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);

                        return;
                    }

                    maKhoQuay =
                        db.Khos
                            .AsNoTracking()
                            .Where(x =>
                                x.LoaiKho ==
                                    "KHO_QUAY")
                            .Select(x =>
                                x.MaKho)
                            .FirstOrDefault();

                    if (maKhoQuay <= 0)
                    {
                        MessageBox.Show(
                            "Không tìm thấy kho quầy trong hệ thống!",
                            "Thông báo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);

                        return;
                    }

                    List<int> maThuocTrongDon =
                        donThuoc
                            .ChiTietDonThuocs
                            .Select(x =>
                                x.MaThuoc)
                            .ToList();

                    DateTime homNay =
                        DateTime.Today;

                    // Chỉ lấy lô còn hạn và còn hàng
                    // tại kho quầy.
                    var tonKhoTheoLo =
                        db.TonKhos
                            .AsNoTracking()
                            .Where(x =>
                                x.MaKho ==
                                    maKhoQuay &&
                                x.SoLuongTon > 0 &&
                                x.LoThuoc.NgayHetHan >=
                                    homNay &&
                                maThuocTrongDon.Contains(
                                    x.LoThuoc.MaThuoc))
                            .Select(x =>
                                new
                                {
                                    x.LoThuoc.MaThuoc,
                                    x.MaLo,
                                    x.LoThuoc.SoLo,
                                    x.LoThuoc.NgayHetHan,
                                    x.SoLuongTon
                                })
                            .OrderBy(x =>
                                x.NgayHetHan)
                            .ThenBy(x =>
                                x.MaLo)
                            .ToList();

                    txtBenhNhan.Text =
                        donThuoc.BenhNhan.HoTen;

                    txtBacSi.Text =
                        donThuoc.BacSi.FullName;

                    txtBHYT.Text =
                        string.IsNullOrWhiteSpace(
                            donThuoc.BenhNhan.MaBHYT)
                            ? "Không có"
                            : donThuoc.BenhNhan.MaBHYT;

                    maDonThuocDangTraCuu =
                        donThuoc.MaDonThuoc;

                    List<string> danhSachThieu =
                        new List<string>();

                    dangTaiBang = true;

                    try
                    {
                        foreach (var chiTiet
                            in donThuoc
                                .ChiTietDonThuocs
                                .OrderBy(x =>
                                    x.Thuoc.TenThuoc))
                        {
                            int viTriDong =
                                dgv1.Rows.Add(
                                    chiTiet.Thuoc.TenThuoc,
                                    chiTiet.SoLuong,
                                    chiTiet.LieuDung,
                                    chiTiet.TanSuat,
                                    chiTiet.SoNgayDung,
                                    chiTiet.GhiChu ?? "");

                            dgv1.Rows[
                                viTriDong
                            ].Tag =
                                chiTiet.MaThuoc;

                            soLuongCanXuatTheoThuoc[
                                chiTiet.MaThuoc
                            ] =
                                chiTiet.SoLuong;

                            List<ThongTinLo>
                                danhSachLo =
                                    tonKhoTheoLo
                                        .Where(x =>
                                            x.MaThuoc ==
                                                chiTiet.MaThuoc)
                                        .Select(x =>
                                            new ThongTinLo
                                            {
                                                MaLo =
                                                    x.MaLo,

                                                SoLo =
                                                    x.SoLo,

                                                NgayHetHan =
                                                    x.NgayHetHan,

                                                SoLuongTon =
                                                    x.SoLuongTon
                                            })
                                        .ToList();

                            danhSachLoTheoThuoc[
                                chiTiet.MaThuoc
                            ] =
                                danhSachLo;

                            Dictionary<int, int>
                                phanBoTuDong =
                                    PhanBoTuDong(
                                        chiTiet.SoLuong,
                                        danhSachLo);

                            soLuongXuatTheoThuoc[
                                chiTiet.MaThuoc
                            ] =
                                phanBoTuDong;

                            int tongCoTheXuat =
                                phanBoTuDong
                                    .Values
                                    .Sum();

                            if (tongCoTheXuat <
                                chiTiet.SoLuong)
                            {
                                danhSachThieu.Add(
                                    "- " +
                                    chiTiet.Thuoc.TenThuoc +
                                    ": cần " +
                                    chiTiet.SoLuong +
                                    ", hiện có " +
                                    tongCoTheXuat);
                            }
                        }

                        dgv1.ClearSelection();

                        if (dgv1.Rows.Count > 0)
                        {
                            dgv1.CurrentCell =
                                dgv1.Rows[0].Cells[0];

                            dgv1.Rows[0].Selected =
                                true;

                            maThuocDangChon =
                                (int)dgv1.Rows[0].Tag;
                        }
                    }
                    finally
                    {
                        dangTaiBang = false;
                    }

                    if (maThuocDangChon.HasValue)
                    {
                        HienThiLoCuaThuoc(
                            maThuocDangChon.Value);
                    }

                    CapNhatTrangThaiThanhToan();

                    if (danhSachThieu.Count > 0)
                    {
                        MessageBox.Show(
                            "Kho quầy không đủ số lượng cho một số thuốc:\n" +
                            string.Join(
                                "\n",
                                danhSachThieu),
                            "Cảnh báo tồn kho",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                XoaKetQuaTraCuu();

                string noiDungLoi =
                    ex.InnerException?.Message ??
                    ex.Message;

                MessageBox.Show(
                    "Không thể tra cứu đơn thuốc!\n" +
                    noiDungLoi,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private Dictionary<int, int>
            PhanBoTuDong(
                int soLuongCanXuat,
                List<ThongTinLo> danhSachLo)
        {
            Dictionary<int, int> ketQua =
                new Dictionary<int, int>();

            int soLuongConLai =
                soLuongCanXuat;

            // FEFO: ưu tiên lô hết hạn gần nhất.
            foreach (ThongTinLo lo
                in danhSachLo
                    .OrderBy(x =>
                        x.NgayHetHan)
                    .ThenBy(x =>
                        x.MaLo))
            {
                if (soLuongConLai <= 0)
                {
                    break;
                }

                int soLuongXuat =
                    Math.Min(
                        soLuongConLai,
                        lo.SoLuongTon);

                if (soLuongXuat <= 0)
                {
                    continue;
                }

                ketQua[lo.MaLo] =
                    soLuongXuat;

                soLuongConLai -=
                    soLuongXuat;
            }

            return ketQua;
        }

        private void HienThiLoCuaThuoc(
            int maThuoc)
        {
            dangTaiBang = true;

            try
            {
                dgv2.Rows.Clear();

                if (!danhSachLoTheoThuoc
                    .TryGetValue(
                        maThuoc,
                        out List<ThongTinLo>?
                            danhSachLo))
                {
                    return;
                }

                soLuongXuatTheoThuoc
                    .TryGetValue(
                        maThuoc,
                        out Dictionary<int, int>?
                            phanBoDaChon);

                foreach (ThongTinLo lo
                    in danhSachLo)
                {
                    int soLuongXuat = 0;

                    if (phanBoDaChon != null)
                    {
                        phanBoDaChon.TryGetValue(
                            lo.MaLo,
                            out soLuongXuat);
                    }

                    int viTriDong =
                        dgv2.Rows.Add(
                            lo.SoLo,
                            lo.NgayHetHan.ToString(
                                "dd/MM/yyyy"),
                            lo.SoLuongTon,
                            soLuongXuat);

                    dgv2.Rows[
                        viTriDong
                    ].Tag =
                        lo.MaLo;
                }

                ChonCacLoDaPhanBo();
            }
            finally
            {
                dangTaiBang = false;
            }
        }

        private void LuuLuaChonLoDangHienThi()
        {
            if (!maThuocDangChon.HasValue)
            {
                return;
            }

            dgv2.EndEdit();

            Dictionary<int, int>
                phanBoMoi =
                    new Dictionary<int, int>();

            foreach (DataGridViewRow dong
                in dgv2.Rows)
            {
                if (dong.Tag == null)
                {
                    continue;
                }

                int maLo =
                    (int)dong.Tag;

                int.TryParse(
                    Convert.ToString(
                        dong.Cells[
                            Column10.Index
                        ].Value),
                    out int soLuongXuat);

                if (soLuongXuat > 0)
                {
                    phanBoMoi[maLo] =
                        soLuongXuat;
                }
            }

            soLuongXuatTheoThuoc[
                maThuocDangChon.Value
            ] =
                phanBoMoi;
        }

        private void ChonCacLoDaPhanBo()
        {
            dgv2.ClearSelection();

            foreach (DataGridViewRow dong
                in dgv2.Rows)
            {
                int.TryParse(
                    Convert.ToString(
                        dong.Cells[
                            Column10.Index
                        ].Value),
                    out int soLuongXuat);

                if (soLuongXuat > 0)
                {
                    dong.Selected = true;
                }
            }
        }

        private void CapNhatTrangThaiThanhToan()
        {
            if (maDonThuocDangTraCuu <= 0 ||
                soLuongCanXuatTheoThuoc.Count ==
                    0)
            {
                btnThanhToan.Enabled = false;
                return;
            }

            bool daChonDu =
                soLuongCanXuatTheoThuoc
                    .All(x =>
                        soLuongXuatTheoThuoc
                            .TryGetValue(
                                x.Key,
                                out Dictionary<int, int>?
                                    phanBo) &&
                        phanBo.Values.Sum() ==
                            x.Value);

            btnThanhToan.Enabled =
                daChonDu;
        }

        private string HienThiTrangThai(
            string trangThai)
        {
            switch (trangThai)
            {
                case "NHAP":
                    return "Đang nhập";

                case "CHO_XUAT_THUOC":
                    return "Chờ xuất thuốc";

                case "DA_XUAT_THUOC":
                    return "Đã xuất thuốc";

                case "DA_HUY":
                    return "Đã hủy";

                default:
                    return trangThai;
            }
        }

        private void XoaKetQuaTraCuu()
        {
            dangTaiBang = true;

            try
            {
                txtBenhNhan.Clear();
                txtBacSi.Clear();
                txtBHYT.Clear();

                dgv1.Rows.Clear();
                dgv2.Rows.Clear();

                soLuongCanXuatTheoThuoc.Clear();
                danhSachLoTheoThuoc.Clear();
                soLuongXuatTheoThuoc.Clear();

                maDonThuocDangTraCuu = 0;
                maKhoQuay = 0;
                maThuocDangChon = null;

                btnThanhToan.Enabled = false;
            }
            finally
            {
                dangTaiBang = false;
            }
        }

        private void btnTraCuu_Click_1(object sender, EventArgs e)
        {
            TraCuuDonThuoc();
        }

        private void txtMaDonThuoc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter)
            {
                return;
            }

            btnTraCuu.PerformClick();
            e.SuppressKeyPress = true;
        }

        private void dgv1_SelectionChanged(object sender, EventArgs e)
        {
            if (dangTaiBang ||
                dgv1.CurrentRow == null ||
                dgv1.CurrentRow.Tag == null)
            {
                return;
            }

            int maThuocMoi =
                (int)dgv1.CurrentRow.Tag;

            if (maThuocDangChon ==
                maThuocMoi)
            {
                return;
            }

            LuuLuaChonLoDangHienThi();

            maThuocDangChon =
                maThuocMoi;

            HienThiLoCuaThuoc(
                maThuocMoi);
        }

        private void dgv2_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (dangTaiBang ||
                e.RowIndex < 0 ||
                e.ColumnIndex !=
                    Column10.Index)
            {
                return;
            }

            string giaTri =
                Convert.ToString(
                    e.FormattedValue
                )?.Trim() ?? "";

            // Cho phép xóa trắng, sau đó xem như 0.
            if (giaTri == "")
            {
                return;
            }

            if (!int.TryParse(
                giaTri,
                out int soLuongXuat) ||
                soLuongXuat < 0)
            {
                e.Cancel = true;

                MessageBox.Show(
                    "Số lượng xuất phải là số nguyên không âm!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            int soLuongTon =
                Convert.ToInt32(
                    dgv2.Rows[
                        e.RowIndex
                    ].Cells[
                        Column9.Index
                    ].Value);

            if (soLuongXuat >
                soLuongTon)
            {
                e.Cancel = true;

                MessageBox.Show(
                    "Số lượng xuất không được lớn hơn tồn quầy!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void dgv2_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (dangTaiBang ||
                e.RowIndex < 0 ||
                e.ColumnIndex !=
                    Column10.Index)
            {
                return;
            }

            DataGridViewCell oNhap =
                dgv2.Rows[
                    e.RowIndex
                ].Cells[
                    Column10.Index
                ];

            if (!int.TryParse(
                Convert.ToString(
                    oNhap.Value),
                out _))
            {
                oNhap.Value = 0;
            }

            LuuLuaChonLoDangHienThi();
            ChonCacLoDaPhanBo();
            CapNhatTrangThaiThanhToan();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            LuuLuaChonLoDangHienThi();
            CapNhatTrangThaiThanhToan();

            if (maDonThuocDangTraCuu <= 0 ||
                maKhoQuay <= 0)
            {
                MessageBox.Show(
                    "Vui lòng tra cứu đơn thuốc trước!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (!btnThanhToan.Enabled)
            {
                MessageBox.Show(
                    "Bạn phải chọn đúng và đủ số lượng thuốc cần xuất!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            Dictionary<int, Dictionary<int, int>>
                danhSachLoDaChon =
                    soLuongXuatTheoThuoc
                        .ToDictionary(
                            thuoc => thuoc.Key,
                            thuoc => thuoc.Value
                                .Where(lo =>
                                    lo.Value > 0)
                                .ToDictionary(
                                    lo => lo.Key,
                                    lo => lo.Value));

            using (QLQuayThuoc.DuocSi_ThanhToan
                frmThanhToan =
                    new QLQuayThuoc.DuocSi_ThanhToan(
                        maDonThuocDangTraCuu,
                        maKhoQuay,
                        danhSachLoDaChon))
            {
                DialogResult ketQua =
                    frmThanhToan.ShowDialog(
                        FindForm());

                if (ketQua != DialogResult.OK)
                {
                    return;
                }
            }

            XoaKetQuaTraCuu();
            txtMaDonThuoc.Clear();
            txtMaDonThuoc.Focus();
        }
    }
}
