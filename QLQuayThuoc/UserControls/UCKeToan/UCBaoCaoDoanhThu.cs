using Microsoft.EntityFrameworkCore;
using QLQuayThuoc.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLQuayThuoc.Forms.Dialogs;

namespace QLQuayThuoc.UserControls.UCKeToan
{
    public partial class UCBaoCaoDoanhThu : UserControl
    {
        private List<BaoCaoDoanhThuViewModel> danhSachBaoCao = new();

        private readonly PrintDocument printDocument;
        private readonly PrintPreviewDialog printPreviewDialog;

        private int viTriDongDangIn = 0;
        public UCBaoCaoDoanhThu()
        {
            InitializeComponent();

            printDocument = new PrintDocument();
            printPreviewDialog = new PrintPreviewDialog();

            printPreviewDialog.Document = printDocument;
            printPreviewDialog.Width = 1000;
            printPreviewDialog.Height = 700;

            printDocument.DefaultPageSettings.Landscape = true;

            CauHinhControls();
            GanSuKien();
        }
        private void CauHinhControls()
        {
            dtpTuNgay.Format = DateTimePickerFormat.Custom;
            dtpTuNgay.CustomFormat = "dd/MM/yyyy";

            dtpDenNgay.Format = DateTimePickerFormat.Custom;
            dtpDenNgay.CustomFormat = "dd/MM/yyyy";


            dtpTuNgay.Value =
                new DateTime(DateTime.Today.Year, 1, 1);

            dtpDenNgay.Value = DateTime.Today;

            cboNhomTheo.DropDownStyle =
                ComboBoxStyle.DropDownList;

            cboNhomTheo.Items.Clear();
            cboNhomTheo.Items.Add("Ngày");
            cboNhomTheo.Items.Add("Tháng");
            cboNhomTheo.Items.Add("Năm");
            cboNhomTheo.SelectedIndex = 0;

            dgvBaoCao.AutoGenerateColumns = false;
            dgvBaoCao.AllowUserToAddRows = false;
            dgvBaoCao.AllowUserToDeleteRows = false;
            dgvBaoCao.ReadOnly = true;
            dgvBaoCao.MultiSelect = false;

            dgvBaoCao.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvBaoCao.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            GanCot(
                "colThoiGian",
                nameof(BaoCaoDoanhThuViewModel.ThoiGian));

            GanCot(
                "colSoLuongHoaDon",
                nameof(BaoCaoDoanhThuViewModel.SoLuongHoaDon));

            GanCot(
                "colTienThuoc",
                nameof(BaoCaoDoanhThuViewModel.TienThuoc),
                "N0");

            GanCot(
                "colBHYTChiTra",
                nameof(BaoCaoDoanhThuViewModel.BHYTChiTra),
                "N0");

            GanCot(
                "colBenhNhanTra",
                nameof(BaoCaoDoanhThuViewModel.BenhNhanTra),
                "N0");

            CanPhaiCotTien("colTienThuoc");
            CanPhaiCotTien("colBHYTChiTra");
            CanPhaiCotTien("colBenhNhanTra");

            lblTongSoHoaDon.Text = "0";
            lblTongTienThuoc.Text = "0 VNĐ";
            lblTongBHYT.Text = "0 VNĐ";
            lblTongBenhNhanTra.Text = "0 VNĐ";

            btnXemHoaDon.Text = "Xem thông tin hóa đơn";
        }

        private void GanCot(
            string tenCot,
            string dataPropertyName,
            string? format = null)
        {
            if (!dgvBaoCao.Columns.Contains(tenCot))
            {
                return;
            }

            DataGridViewColumn cot =
                dgvBaoCao.Columns[tenCot];

            cot.DataPropertyName = dataPropertyName;

            if (!string.IsNullOrWhiteSpace(format))
            {
                cot.DefaultCellStyle.Format = format;
            }
        }

        private void CanPhaiCotTien(string tenCot)
        {
            if (!dgvBaoCao.Columns.Contains(tenCot))
            {
                return;
            }

            dgvBaoCao.Columns[tenCot]
                .DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleRight;
        }

        private void GanSuKien()
        {
            Load += UCBaoCaoDoanhThu_Load;

            btnThongKe.Click += btnThongKe_Click;
            btnXuatExcel.Click += btnXuatExcel_Click;
            btnXemHoaDon.Click += btnXemHoaDon_Click;

            dgvBaoCao.CellDoubleClick +=
                dgvBaoCao_CellDoubleClick;

            printDocument.BeginPrint +=
                printDocument_BeginPrint;

            printDocument.PrintPage +=
                printDocument_PrintPage;
        }

        private async void UCBaoCaoDoanhThu_Load(object sender, EventArgs e)
        {
            await TaiBaoCao();
        }

        private async void btnThongKe_Click(object sender, EventArgs e)
        {
            await TaiBaoCao();
        }
        private async Task TaiBaoCao()
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
            DateTime denNgayDocQuyen = denNgay.AddDays(1);

            try
            {
                UseWaitCursor = true;
                btnThongKe.Enabled = false;

                using AppDbContext db = new AppDbContext();            

                List<HoaDonThongKeItem> hoaDons =
                    await db.HoaDons
                        .AsNoTracking()
                        .Where(x =>
                            x.ThoiGianThanhToan >= tuNgay &&
                            x.ThoiGianThanhToan < denNgayDocQuyen)
                        .Select(x => new HoaDonThongKeItem
                        {
                            MaHD = x.MaHD,

                            ThoiGianThanhToan =
                                x.ThoiGianThanhToan,

                            TongTienThuoc =
                                x.TongTienThuoc,

                            TienBHYTThanhToan =
                                x.TienBHYTThanhToan,

                            TienBenhNhanTra =
                                x.TienBenhNhanTra
                        })
                        .ToListAsync();

                CapNhatTongQuan(hoaDons);

                danhSachBaoCao =
                    TaoBaoCaoTheoNhom(hoaDons);

                dgvBaoCao.DataSource = null;
                dgvBaoCao.DataSource = danhSachBaoCao;

                CapNhatTieuDeCotThoiGian();

                dgvBaoCao.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Không thể tải báo cáo doanh thu.\n\n" +
                    "Chi tiết lỗi:\n" +
                    ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                UseWaitCursor = false;
                btnThongKe.Enabled = true;
            }
        }

        private void CapNhatTongQuan(
            List<HoaDonThongKeItem> hoaDons)
        {
            int tongSoHoaDon = hoaDons.Count;

            decimal tongTienThuoc =
                hoaDons.Sum(x => x.TongTienThuoc);

            decimal tongBHYT =
                hoaDons.Sum(x => x.TienBHYTThanhToan);

            decimal tongBenhNhanTra =
                hoaDons.Sum(x => x.TienBenhNhanTra);

            lblTongSoHoaDon.Text =
                tongSoHoaDon.ToString("N0");

            lblTongTienThuoc.Text =
                tongTienThuoc.ToString("N0") + " VNĐ";

            lblTongBHYT.Text =
                tongBHYT.ToString("N0") + " VNĐ";

            lblTongBenhNhanTra.Text =
                tongBenhNhanTra.ToString("N0") + " VNĐ";
        }

        private List<BaoCaoDoanhThuViewModel>
            TaoBaoCaoTheoNhom(
                List<HoaDonThongKeItem> hoaDons)
        {
            if (cboNhomTheo.SelectedIndex == 0)
            {
                return hoaDons
                    .GroupBy(x =>
                        x.ThoiGianThanhToan.Date)
                    .Select(nhom =>
                        new BaoCaoDoanhThuViewModel
                        {
                            ThoiGian =
                                nhom.Key.ToString("dd/MM/yyyy"),

                            TuNgay = nhom.Key,

                            DenNgayDocQuyen =
                                nhom.Key.AddDays(1),

                            SoLuongHoaDon =
                                nhom.Count(),

                            TienThuoc =
                                nhom.Sum(x =>
                                    x.TongTienThuoc),

                            BHYTChiTra =
                                nhom.Sum(x =>
                                    x.TienBHYTThanhToan),

                            BenhNhanTra =
                                nhom.Sum(x =>
                                    x.TienBenhNhanTra)
                        })
                    .OrderBy(x => x.TuNgay)
                    .ToList();
            }
            if (cboNhomTheo.SelectedIndex == 1)
            {
                return hoaDons
                    .GroupBy(x => new
                    {
                        x.ThoiGianThanhToan.Year,
                        x.ThoiGianThanhToan.Month
                    })
                    .Select(nhom =>
                    {
                        DateTime dauThang =
                            new DateTime(
                                nhom.Key.Year,
                                nhom.Key.Month,
                                1);

                        return new BaoCaoDoanhThuViewModel
                        {
                            ThoiGian =
                                dauThang.ToString("MM/yyyy"),

                            TuNgay = dauThang,

                            DenNgayDocQuyen =
                                dauThang.AddMonths(1),

                            SoLuongHoaDon =
                                nhom.Count(),

                            TienThuoc =
                                nhom.Sum(x =>
                                    x.TongTienThuoc),

                            BHYTChiTra =
                                nhom.Sum(x =>
                                    x.TienBHYTThanhToan),

                            BenhNhanTra =
                                nhom.Sum(x =>
                                    x.TienBenhNhanTra)
                        };
                    })
                    .OrderBy(x => x.TuNgay)
                    .ToList();
            }
            return hoaDons
                .GroupBy(x =>
                    x.ThoiGianThanhToan.Year)
                .Select(nhom =>
                {
                    DateTime dauNam =
                        new DateTime(nhom.Key, 1, 1);

                    return new BaoCaoDoanhThuViewModel
                    {
                        ThoiGian =
                            nhom.Key.ToString(),

                        TuNgay = dauNam,

                        DenNgayDocQuyen =
                            dauNam.AddYears(1),

                        SoLuongHoaDon =
                            nhom.Count(),

                        TienThuoc =
                            nhom.Sum(x =>
                                x.TongTienThuoc),

                        BHYTChiTra =
                            nhom.Sum(x =>
                                x.TienBHYTThanhToan),

                        BenhNhanTra =
                            nhom.Sum(x =>
                                x.TienBenhNhanTra)
                    };
                })
                .OrderBy(x => x.TuNgay)
                .ToList();
        }

        private void CapNhatTieuDeCotThoiGian()
        {
            if (!dgvBaoCao.Columns.Contains(
                    "colThoiGian"))
            {
                return;
            }

            dgvBaoCao.Columns["colThoiGian"]
                .HeaderText =
                cboNhomTheo.SelectedIndex switch
                {
                    0 => "Ngày",
                    1 => "Tháng",
                    2 => "Năm",
                    _ => "Thời gian"
                };
        }

        private BaoCaoDoanhThuViewModel?
            LayBaoCaoDangChon()
        {
            if (dgvBaoCao.CurrentRow?.DataBoundItem
                is not BaoCaoDoanhThuViewModel item)
            {
                MessageBox.Show(
                    "Vui lòng chọn một dòng báo cáo.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return null;
            }

            return item;
        }

        private async void btnXemHoaDon_Click(object sender, EventArgs e)
        {
            await XemThongTinHoaDon();
        }
        private async void dgvBaoCao_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            await XemThongTinHoaDon();
        }
        private async Task XemThongTinHoaDon()
        {
            BaoCaoDoanhThuViewModel? baoCao =
                LayBaoCaoDangChon();

            if (baoCao == null)
            {
                return;
            }

            try
            {
                using AppDbContext db = new AppDbContext();

                var hoaDons = await db.HoaDons
                    .AsNoTracking()

                    .Include(x => x.PhieuXuatThuoc)
                        .ThenInclude(x => x.DonThuoc)
                            .ThenInclude(x => x.BenhNhan)

                    .Include(x => x.PhieuXuatThuoc)
                        .ThenInclude(x => x.DuocSi)

                    .Where(x =>
                        x.ThoiGianThanhToan >=
                            baoCao.TuNgay

                        && x.ThoiGianThanhToan <
                            baoCao.DenNgayDocQuyen)

                    .OrderBy(x => x.MaHD)

                    .ToListAsync();

                List<ThongTinHoaDonViewModel> danhSach =
                    hoaDons
                        .Select(x =>
                            new ThongTinHoaDonViewModel
                            {
                                MaHD = x.MaHD,

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

                                ThoiGianThanhToan =
                                    x.ThoiGianThanhToan,

                                PhuongThuc =
                                    ChuyenPhuongThuc(
                                        x.PhuongThucThanhToan),

                                TongTienThuoc =
                                    x.TongTienThuoc,

                                TienBHYT =
                                    x.TienBHYTThanhToan,

                                TienBenhNhanTra =
                                    x.TienBenhNhanTra
                            })
                        .ToList();

                using KeToan_XemThongTinDonThuoc dialog = new KeToan_XemThongTinDonThuoc(baoCao.ThoiGian,danhSach);
                dialog.ShowDialog(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Không thể xem thông tin hóa đơn.\n\n" +
                    ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private static string ChuyenPhuongThuc(
            string? phuongThuc)
        {
            return phuongThuc switch
            {
                "TIEN_MAT" => "Tiền mặt",

                "CHUYEN_KHOAN" =>
                    "Chuyển khoản",

                _ => phuongThuc ?? string.Empty
            };
        }

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            if (danhSachBaoCao.Count == 0)
            {
                MessageBox.Show(
                    "Không có dữ liệu để xuất.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            using SaveFileDialog saveFileDialog =
                new SaveFileDialog();

            saveFileDialog.Filter =
                "Excel CSV (*.csv)|*.csv";

            saveFileDialog.FileName =
                "BaoCaoDoanhThu_" +
                DateTime.Now.ToString(
                    "yyyyMMdd_HHmmss") +
                ".csv";

            if (saveFileDialog.ShowDialog()
                != DialogResult.OK)
            {
                return;
            }

            try
            {
                using StreamWriter writer =
                    new StreamWriter(
                        saveFileDialog.FileName,
                        false,
                        new UTF8Encoding(true));

                writer.WriteLine(
                    "Thời gian;" +
                    "Số lượng hóa đơn;" +
                    "Tiền thuốc;" +
                    "BHYT chi trả;" +
                    "Bệnh nhân trả");

                foreach (
                    BaoCaoDoanhThuViewModel item
                    in danhSachBaoCao)
                {
                    writer.WriteLine(
                        Csv(item.ThoiGian) + ";" +

                        item.SoLuongHoaDon + ";" +

                        item.TienThuoc.ToString(
                            "0.##",
                            CultureInfo.InvariantCulture) + ";" +

                        item.BHYTChiTra.ToString(
                            "0.##",
                            CultureInfo.InvariantCulture) + ";" +

                        item.BenhNhanTra.ToString(
                            "0.##",
                            CultureInfo.InvariantCulture));
                }

                MessageBox.Show(
                    "Xuất file thành công.\n\n" +
                    saveFileDialog.FileName,
                    "Thành công",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Không thể xuất file.\n\n" +
                    ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private static string Csv(string noiDung)
        {
            return "\"" +
                noiDung.Replace("\"", "\"\"") +
                "\"";
        }

        private void btnInBaoCao_Click(object sender, EventArgs e)
        {
            if (danhSachBaoCao.Count == 0)
            {
                MessageBox.Show(
                    "Không có dữ liệu để in.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            printPreviewDialog.ShowDialog(this);
        }

        private void printDocument_BeginPrint(
            object? sender,
            PrintEventArgs e)
        {
            viTriDongDangIn = 0;
        }

        private void printDocument_PrintPage(
            object? sender,
            PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;

            int left = e.MarginBounds.Left;
            int right = e.MarginBounds.Right;
            int y = e.MarginBounds.Top;

            using Font fontTieuDe =
                new Font("Arial", 16, FontStyle.Bold);

            using Font fontDam =
                new Font("Arial", 10, FontStyle.Bold);

            using Font fontThuong =
                new Font("Arial", 10);

            using Pen pen =
                new Pen(Color.Black);

            StringFormat canGiua =
                new StringFormat
                {
                    Alignment =
                        StringAlignment.Center
                };

            StringFormat canPhai =
                new StringFormat
                {
                    Alignment =
                        StringAlignment.Far
                };

            g.DrawString(
                "BÁO CÁO DOANH THU QUẦY THUỐC",
                fontTieuDe,
                Brushes.Black,
                new RectangleF(
                    left,
                    y,
                    e.MarginBounds.Width,
                    30),
                canGiua);

            y += 40;

            g.DrawString(
                $"Từ ngày: {dtpTuNgay.Value:dd/MM/yyyy}  " +
                $"Đến ngày: {dtpDenNgay.Value:dd/MM/yyyy}",
                fontThuong,
                Brushes.Black,
                left,
                y);

            y += 25;

            g.DrawString(
                $"Nhóm theo: {cboNhomTheo.Text}",
                fontThuong,
                Brushes.Black,
                left,
                y);

            y += 25;

            g.DrawString(
                $"Tổng số hóa đơn: {lblTongSoHoaDon.Text}",
                fontThuong,
                Brushes.Black,
                left,
                y);

            g.DrawString(
                $"Tổng tiền thuốc: {lblTongTienThuoc.Text}",
                fontThuong,
                Brushes.Black,
                left + 250,
                y);

            y += 35;

            int xThoiGian = left;
            int xSoLuong = left + 180;
            int xTienThuoc = left + 340;
            int xBHYT = left + 540;
            int xBenhNhan = left + 730;

            g.DrawString(
                cboNhomTheo.Text,
                fontDam,
                Brushes.Black,
                xThoiGian,
                y);

            g.DrawString(
                "Số hóa đơn",
                fontDam,
                Brushes.Black,
                xSoLuong,
                y);

            g.DrawString(
                "Tiền thuốc",
                fontDam,
                Brushes.Black,
                xTienThuoc,
                y);

            g.DrawString(
                "BHYT chi trả",
                fontDam,
                Brushes.Black,
                xBHYT,
                y);

            g.DrawString(
                "Bệnh nhân trả",
                fontDam,
                Brushes.Black,
                xBenhNhan,
                y);

            y += 22;

            g.DrawLine(
                pen,
                left,
                y,
                right,
                y);

            y += 10;

            while (
                viTriDongDangIn <
                danhSachBaoCao.Count)
            {
                if (y >
                    e.MarginBounds.Bottom - 40)
                {
                    e.HasMorePages = true;
                    return;
                }

                BaoCaoDoanhThuViewModel item =
                    danhSachBaoCao[
                        viTriDongDangIn];

                g.DrawString(
                    item.ThoiGian,
                    fontThuong,
                    Brushes.Black,
                    xThoiGian,
                    y);

                g.DrawString(
                    item.SoLuongHoaDon.ToString(),
                    fontThuong,
                    Brushes.Black,
                    xSoLuong,
                    y);

                g.DrawString(
                    item.TienThuoc.ToString("N0"),
                    fontThuong,
                    Brushes.Black,
                    new RectangleF(
                        xTienThuoc - 20,
                        y,
                        150,
                        25),
                    canPhai);

                g.DrawString(
                    item.BHYTChiTra.ToString("N0"),
                    fontThuong,
                    Brushes.Black,
                    new RectangleF(
                        xBHYT - 20,
                        y,
                        150,
                        25),
                    canPhai);

                g.DrawString(
                    item.BenhNhanTra.ToString("N0"),
                    fontThuong,
                    Brushes.Black,
                    new RectangleF(
                        xBenhNhan - 20,
                        y,
                        150,
                        25),
                    canPhai);

                y += 28;
                viTriDongDangIn++;
            }

            e.HasMorePages = false;
        }



        private sealed class HoaDonThongKeItem
        {
            public int MaHD { get; set; }

            public DateTime ThoiGianThanhToan
            {
                get;
                set;
            }

            public decimal TongTienThuoc
            {
                get;
                set;
            }

            public decimal TienBHYTThanhToan
            {
                get;
                set;
            }

            public decimal TienBenhNhanTra
            {
                get;
                set;
            }
        }

        private sealed class BaoCaoDoanhThuViewModel
        {
            public string ThoiGian { get; set; } =
                string.Empty;

            public DateTime TuNgay { get; set; }

            public DateTime DenNgayDocQuyen
            {
                get;
                set;
            }

            public int SoLuongHoaDon { get; set; }

            public decimal TienThuoc { get; set; }

            public decimal BHYTChiTra { get; set; }

            public decimal BenhNhanTra { get; set; }
        }

        public sealed class ThongTinHoaDonViewModel
        {
            public int MaHD { get; set; }

            public string BenhNhan { get; set; } =
                string.Empty;

            public string DuocSi { get; set; } =
                string.Empty;

            public DateTime ThoiGianThanhToan
            {
                get;
                set;
            }

            public string PhuongThuc { get; set; } =
                string.Empty;

            public decimal TongTienThuoc
            {
                get;
                set;
            }

            public decimal TienBHYT { get; set; }

            public decimal TienBenhNhanTra
            {
                get;
                set;
            }
        }
    }
}

        
    



