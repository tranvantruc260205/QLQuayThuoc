using Microsoft.EntityFrameworkCore;
using QLQuayThuoc.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLQuayThuoc.UserControls.UCKeToan
{
    public partial class UCDanhSachHoaDon : UserControl
    {
        private List<HoaDonViewModel> danhSachGoc = new();

        private HoaDonViewModel? hoaDonDangIn;

        private readonly PrintDocument printDocument;
        private readonly PrintPreviewDialog printPreviewDialog;
        public UCDanhSachHoaDon()
        {
            InitializeComponent();
            printDocument = new PrintDocument();
            printPreviewDialog = new PrintPreviewDialog();

            CauHinhControls();
            GanSuKien();
        }
        private void CauHinhControls()
        {
            dgvHoaDon.AutoGenerateColumns = false;
            dgvHoaDon.AllowUserToAddRows = false;
            dgvHoaDon.AllowUserToDeleteRows = false;
            dgvHoaDon.ReadOnly = true;
            dgvHoaDon.MultiSelect = false;

            dgvHoaDon.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            cboPhuongThuc.DropDownStyle =
                ComboBoxStyle.DropDownList;

            cboPhuongThuc.Items.Clear();
            cboPhuongThuc.Items.Add("Tất cả");
            cboPhuongThuc.Items.Add("Tiền mặt");
            cboPhuongThuc.Items.Add("Chuyển khoản");
            cboPhuongThuc.SelectedIndex = 0;

   
            dtpTuNgay.Value =
                new DateTime(DateTime.Today.Year, 1, 1);

            dtpDenNgay.Value = DateTime.Today;

            GanCot(
                "colMaHD",
                nameof(HoaDonViewModel.MaHD));

            GanCot(
                "colMaDonThuoc",
                nameof(HoaDonViewModel.MaDonThuoc));

            GanCot(
                "colBenhNhan",
                nameof(HoaDonViewModel.BenhNhan));

            GanCot(
                "colDuocSi",
                nameof(HoaDonViewModel.DuocSi));

            GanCot(
                "colNgayThanhToan",
                nameof(HoaDonViewModel.NgayThanhToan),
                "dd/MM/yyyy HH:mm");

            GanCot(
                "colPhuongThuc",
                nameof(HoaDonViewModel.PhuongThucHienThi));

            GanCot(
                "colTienThuoc",
                nameof(HoaDonViewModel.TienThuoc),
                "N0");

            GanCot(
                "colBHYTChiTra",
                nameof(HoaDonViewModel.BHYTChiTra),
                "N0");

            GanCot(
                "colBenhNhanTra",
                nameof(HoaDonViewModel.BenhNhanTra),
                "N0");
            GanCot(
                "colMaGiaoDich",
                nameof(HoaDonViewModel.MaGiaoDich));
            GanCot(
               "colBHYT",
               nameof(HoaDonViewModel.TyLeBHYTApDung));

            CanPhaiCotTien("colTienThuoc");
            CanPhaiCotTien("colBHYTChiTra");
            CanPhaiCotTien("colBenhNhanTra");
        }

        private void GanCot(
            string tenCot,
            string dataPropertyName,
            string? format = null)
        {
            if (!dgvHoaDon.Columns.Contains(tenCot))
            {
                return;
            }

            DataGridViewColumn cot =
                dgvHoaDon.Columns[tenCot];

            cot.DataPropertyName = dataPropertyName;

            if (!string.IsNullOrWhiteSpace(format))
            {
                cot.DefaultCellStyle.Format = format;
            }
        }

        private void CanPhaiCotTien(string tenCot)
        {
            if (!dgvHoaDon.Columns.Contains(tenCot))
            {
                return;
            }

            dgvHoaDon.Columns[tenCot]
                .DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleRight;
        }
        private void GanSuKien()
        {
            Load += UCDanhSachHoaDon_Load;

            btnLoc.Click += btnLoc_Click;
            btnLamMoi.Click += btnLamMoi_Click;
            btnXemChiTiet.Click += btnXemChiTiet_Click;
            btnInHoaDon.Click += btnInHoaDon_Click;

            txtTimKiem.KeyDown += txtTimKiem_KeyDown;

            dgvHoaDon.CellDoubleClick +=
                dgvHoaDon_CellDoubleClick;

            printDocument.PrintPage +=
                printDocument_PrintPage;
        }

        private async void UCDanhSachHoaDon_Load(object sender, EventArgs e)
        {
            await TaiDanhSachHoaDon();
        }
        private async Task TaiDanhSachHoaDon()
        {
            try
            {
                UseWaitCursor = true;

                btnLoc.Enabled = false;
                btnLamMoi.Enabled = false;

                using AppDbContext db = new AppDbContext();

                var hoaDons = await db.HoaDons
                    .AsNoTracking()

                    .Include(x => x.PhieuXuatThuoc)
                        .ThenInclude(x => x.DonThuoc)
                            .ThenInclude(x => x.BenhNhan)

                    .Include(x => x.PhieuXuatThuoc)
                        .ThenInclude(x => x.DuocSi)

                    .OrderBy(
                        x => x.MaHD)
                    .ToListAsync();

                danhSachGoc = hoaDons
                    .Select(x => new HoaDonViewModel
                    {
                        MaHD = x.MaHD,

                        MaDonThuoc =
                            x.PhieuXuatThuoc?
                                .MaDonThuoc
                                .ToString()
                            ?? string.Empty,

                        BenhNhan =
                            x.PhieuXuatThuoc?
                                .DonThuoc?
                                .BenhNhan?
                                .HoTen
                            ?? string.Empty,

                        DuocSi =
                            x.PhieuXuatThuoc?
                                .DuocSi?
                                .FullName
                            ?? string.Empty,

                        NgayThanhToan =
                            x.ThoiGianThanhToan,

                        PhuongThuc =
                            x.PhuongThucThanhToan
                            ?? string.Empty,

                        TienThuoc =
                            x.TongTienThuoc,
                        TyLeBHYTApDung = 
                            x.TyLeBHYTApDung,

                        BHYTChiTra =
                            x.TienBHYTThanhToan,

                        BenhNhanTra =
                            x.TienBenhNhanTra,
                        MaGiaoDich  =
                        x.MaGiaoDich ?? string.Empty,

                    })
                    .ToList();

                ApDungBoLoc();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Không thể tải danh sách hóa đơn.\n\n" +
                    "Chi tiết lỗi:\n" +
                    ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                UseWaitCursor = false;

                btnLoc.Enabled = true;
                btnLamMoi.Enabled = true;
            }
        }
        private void ApDungBoLoc()
        {
            DateTime tuNgay = dtpTuNgay.Value.Date;
            DateTime denNgay = dtpDenNgay.Value.Date;

            if (tuNgay > denNgay)
            {
                MessageBox.Show(
                    "Từ ngày không được lớn hơn đến ngày.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                dtpTuNgay.Focus();
                return;
            }

            IEnumerable<HoaDonViewModel> ketQua =
                danhSachGoc;

            ketQua = ketQua.Where(x =>
                x.NgayThanhToan.HasValue &&
                x.NgayThanhToan.Value.Date >= tuNgay &&
                x.NgayThanhToan.Value.Date <= denNgay);

            string tuKhoa =
                txtTimKiem.Text.Trim();

            if (!string.IsNullOrWhiteSpace(tuKhoa))
            {
                ketQua = ketQua.Where(x =>
                    x.MaHD.ToString().Contains(
                        tuKhoa,
                        StringComparison.OrdinalIgnoreCase)

                    || x.MaDonThuoc.Contains(
                        tuKhoa,
                        StringComparison.OrdinalIgnoreCase)

                    || x.BenhNhan.Contains(
                        tuKhoa,
                        StringComparison.OrdinalIgnoreCase)

                    || x.DuocSi.Contains(
                        tuKhoa,
                        StringComparison.OrdinalIgnoreCase));
            }

            if (cboPhuongThuc.SelectedIndex == 1)
            {
                ketQua = ketQua.Where(x =>
                    x.PhuongThuc == "TIEN_MAT");
            }
            else if (cboPhuongThuc.SelectedIndex == 2)
            {
                ketQua = ketQua.Where(x =>
                    x.PhuongThuc == "CHUYEN_KHOAN");
            }

            dgvHoaDon.DataSource = null;

            dgvHoaDon.DataSource = ketQua
                .OrderBy(x => x.MaHD)
                .ToList();

            dgvHoaDon.ClearSelection();
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            ApDungBoLoc();
        }

        private void txtTimKiem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ApDungBoLoc();
                e.SuppressKeyPress = true;
            }
        }

        private async void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtTimKiem.Clear();

            cboPhuongThuc.SelectedIndex = 0;

            dtpTuNgay.Value =
                new DateTime(DateTime.Today.Year, 1, 1);

            dtpDenNgay.Value = DateTime.Today;

            await TaiDanhSachHoaDon();
        }
        private HoaDonViewModel? LayHoaDonDangChon()
        {
            if (dgvHoaDon.CurrentRow?.DataBoundItem
                is not HoaDonViewModel item)
            {
                MessageBox.Show(
                    "Vui lòng chọn một hóa đơn.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return null;
            }

            return item;
        }

        private void btnXemChiTiet_Click(object sender, EventArgs e)
        {
            XemChiTietHoaDon();
        }

        private void dgvHoaDon_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                XemChiTietHoaDon();
            }
        }
        private void XemChiTietHoaDon()
        {
            HoaDonViewModel? hoaDon =
                LayHoaDonDangChon();

            if (hoaDon == null)
            {
                return;
            }

            StringBuilder noiDung = new StringBuilder();

            noiDung.AppendLine(
                $"Mã hóa đơn: {hoaDon.MaHD}");

            noiDung.AppendLine(
                $"Mã phiếu xuất: {hoaDon.MaDonThuoc}");

            noiDung.AppendLine(
                $"Bệnh nhân: {hoaDon.BenhNhan}");

            noiDung.AppendLine(
                $"Dược sĩ: {hoaDon.DuocSi}");

            noiDung.AppendLine(
                "Ngày thanh toán: " +
                $"{hoaDon.NgayThanhToan:dd/MM/yyyy HH:mm}");

            noiDung.AppendLine(
                $"Phương thức: {hoaDon.PhuongThucHienThi}");

            noiDung.AppendLine();

            noiDung.AppendLine(
                $"Tổng tiền thuốc: {hoaDon.TienThuoc:N0} VNĐ");

            noiDung.AppendLine(
                $"Phần trăm hưởng BHYT: {hoaDon.TyLeBHYTApDung} %");

            noiDung.AppendLine(
                $"BHYT chi trả: {hoaDon.BHYTChiTra:N0} VNĐ");

            noiDung.AppendLine(
                $"Bệnh nhân trả: {hoaDon.BenhNhanTra:N0} VNĐ");

            MessageBox.Show(
                noiDung.ToString(),
                "Chi tiết hóa đơn",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            hoaDonDangIn = LayHoaDonDangChon();

            if (hoaDonDangIn == null)
            {
                return;
            }

            printPreviewDialog.Document =
                printDocument;

            printPreviewDialog.Width = 900;
            printPreviewDialog.Height = 700;

            printPreviewDialog.ShowDialog(this);
        }

        private void printDocument_PrintPage(
            object? sender,
            PrintPageEventArgs e)
        {
            if (hoaDonDangIn == null)
            {
                e.HasMorePages = false;
                return;
            }

            Graphics g = e.Graphics;

            int x = e.MarginBounds.Left;
            int y = e.MarginBounds.Top;

            using Font fontTieuDe =
                new Font("Arial", 18, FontStyle.Bold);

            using Font fontDam =
                new Font("Arial", 11, FontStyle.Bold);

            using Font fontThuong =
                new Font("Arial", 11);

            StringFormat canGiua =
                new StringFormat
                {
                    Alignment = StringAlignment.Center
                };

            g.DrawString(
                "HÓA ĐƠN THUỐC",
                fontTieuDe,
                Brushes.Black,
                new RectangleF(
                    x,
                    y,
                    e.MarginBounds.Width,
                    40),
                canGiua);

            y += 60;

            g.DrawString(
                $"Mã hóa đơn: {hoaDonDangIn.MaHD}",
                fontThuong,
                Brushes.Black,
                x,
                y);

            y += 30;

            g.DrawString(
                $"Mã phiếu xuất: {hoaDonDangIn.MaDonThuoc}",
                fontThuong,
                Brushes.Black,
                x,
                y);

            y += 30;

            g.DrawString(
                $"Bệnh nhân: {hoaDonDangIn.BenhNhan}",
                fontThuong,
                Brushes.Black,
                x,
                y);

            y += 30;

            g.DrawString(
                $"Dược sĩ: {hoaDonDangIn.DuocSi}",
                fontThuong,
                Brushes.Black,
                x,
                y);

            y += 30;

            g.DrawString(
                "Ngày thanh toán: " +
                $"{hoaDonDangIn.NgayThanhToan:dd/MM/yyyy HH:mm}",
                fontThuong,
                Brushes.Black,
                x,
                y);

            y += 30;

            g.DrawString(
                $"Phương thức: {hoaDonDangIn.PhuongThucHienThi}",
                fontThuong,
                Brushes.Black,
                x,
                y);

            y += 50;

            g.DrawString(
                $"Tổng tiền thuốc: {hoaDonDangIn.TienThuoc:N0} VNĐ",
                fontThuong,
                Brushes.Black,
                x,
                y);

            y += 30;

            g.DrawString(
                $"BHYT chi trả: {hoaDonDangIn.BHYTChiTra:N0} VNĐ",
                fontThuong,
                Brushes.Black,
                x,
                y);

            y += 30;

            g.DrawString(
                $"Bệnh nhân trả: {hoaDonDangIn.BenhNhanTra:N0} VNĐ",
                fontDam,
                Brushes.Black,
                x,
                y);

            y += 60;

            g.DrawString(
                "Cảm ơn quý khách!",
                fontDam,
                Brushes.Black,
                new RectangleF(
                    x,
                    y,
                    e.MarginBounds.Width,
                    30),
                canGiua);

            e.HasMorePages = false;
        }
        private sealed class HoaDonViewModel
        {
            public int MaHD { get; set; }

            public string MaGiaoDich { get; set; } =
                string.Empty;

            public string MaDonThuoc { get; set; } =
                string.Empty;

            public string BenhNhan { get; set; } =
                string.Empty;
            public int TyLeBHYTApDung { get; set; }

            public string DuocSi { get; set; } =
                string.Empty;

            public DateTime? NgayThanhToan { get; set; }

            public string PhuongThuc { get; set; } =
                string.Empty;

            public string PhuongThucHienThi =>
                PhuongThuc switch
                {
                    "TIEN_MAT" => "Tiền mặt",
                    "CHUYEN_KHOAN" => "Chuyển khoản",
                    _ => PhuongThuc
                };

            public decimal TienThuoc { get; set; }

            public decimal BHYTChiTra { get; set; }

            public decimal BenhNhanTra { get; set; }
        }
    }
}

