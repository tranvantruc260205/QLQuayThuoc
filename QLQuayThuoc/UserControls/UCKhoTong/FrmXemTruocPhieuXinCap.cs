using System.Drawing;
using System.Drawing.Printing;
using Microsoft.EntityFrameworkCore;
using QLQuayThuoc.Data;
using QLQuayThuoc.Models;

namespace QLQuayThuoc.UserControls.UCKhoTong
{
    public partial class FrmXemTruocPhieuXinCap : Form
    {
        private int maPhieu;
        private bool coPhieuCanXem;
        private PhieuXinCapThuoc? phieuDangIn;
        private List<ChiTietPhieuXinCap> chiTietDangIn = new();
        private int viTriDongDangIn;

        public FrmXemTruocPhieuXinCap()
        {
            InitializeComponent();

            documentPhieu.DefaultPageSettings.Margins = new Margins(55, 55, 55, 55);
            documentPhieu.DefaultPageSettings.PaperSize = new PaperSize("A4", 827, 1169);

            previewPhieu.Document = documentPhieu;
            previewPhieu.AutoZoom = true;

            Load += FrmXemTruocPhieuXinCap_Load;
            documentPhieu.BeginPrint += documentPhieu_BeginPrint;
            documentPhieu.PrintPage += documentPhieu_PrintPage;
            btnInPhieu.Click += btnInPhieu_Click;
            btnDong.Click += btnDong_Click;
            tsbIn.Click += tsbIn_Click;
            tsbThuNho.Click += tsbThuNho_Click;
            tsbPhongTo.Click += tsbPhongTo_Click;
            tsbMotTrang.Click += tsbMotTrang_Click;
            tsbHaiTrang.Click += tsbHaiTrang_Click;
        }

        public FrmXemTruocPhieuXinCap(int maPhieu) : this()
        {
            this.maPhieu = maPhieu;
            coPhieuCanXem = true;
        }

        private void FrmXemTruocPhieuXinCap_Load(object? sender, EventArgs e)
        {
            if (!coPhieuCanXem)
                return;

            try
            {
                TaiDuLieuPhieu();

                if (phieuDangIn == null)
                {
                    MessageBox.Show("Không tìm thấy phiếu xin cấp thuốc.");
                    Close();
                    return;
                }

                previewPhieu.InvalidatePreview();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Không thể tải dữ liệu phiếu: " + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                Close();
            }
        }

        private void TaiDuLieuPhieu()
        {
            using AppDbContext db = new AppDbContext();

            phieuDangIn = db.PhieuXinCapThuocs
                .AsNoTracking()
                .Include(p => p.KhoCap)
                .Include(p => p.KhoNhan)
                .Include(p => p.NguoiLap)
                .Include(p => p.NguoiDuyet)
                .SingleOrDefault(p => p.MaPhieu == maPhieu);

            chiTietDangIn = db.ChiTietPhieuXinCaps
                .AsNoTracking()
                .Include(ct => ct.Thuoc)
                .Where(ct => ct.MaPhieu == maPhieu)
                .OrderBy(ct => ct.Thuoc.TenThuoc)
                .ToList();
        }

        private void documentPhieu_BeginPrint(object? sender, PrintEventArgs e)
        {
            viTriDongDangIn = 0;
        }

        private void btnInPhieu_Click(object? sender, EventArgs e) => MoChonMayIn();

        private void tsbIn_Click(object? sender, EventArgs e) => MoChonMayIn();

        private void MoChonMayIn()
        {
            if (phieuDangIn == null)
                return;

            printDialog1.Document = documentPhieu;

            if (printDialog1.ShowDialog(this) == DialogResult.OK)
                documentPhieu.Print();
        }

        private void btnDong_Click(object? sender, EventArgs e) => Close();

        private void tsbThuNho_Click(object? sender, EventArgs e)
        {
            previewPhieu.AutoZoom = false;
            previewPhieu.Zoom = Math.Max(0.2, previewPhieu.Zoom - 0.1);
        }

        private void tsbPhongTo_Click(object? sender, EventArgs e)
        {
            previewPhieu.AutoZoom = false;
            previewPhieu.Zoom = Math.Min(3.0, previewPhieu.Zoom + 0.1);
        }

        private void tsbMotTrang_Click(object? sender, EventArgs e)
        {
            previewPhieu.Rows = 1;
            previewPhieu.Columns = 1;
            previewPhieu.AutoZoom = true;
        }

        private void tsbHaiTrang_Click(object? sender, EventArgs e)
        {
            previewPhieu.Rows = 1;
            previewPhieu.Columns = 2;
            previewPhieu.AutoZoom = true;
        }

        private void documentPhieu_PrintPage(object? sender, PrintPageEventArgs e)
        {
            if (phieuDangIn == null)
            {
                e.HasMorePages = false;
                return;
            }

            Graphics? graphics = e.Graphics;

            if (graphics == null)
            {
                e.HasMorePages = false;
                return;
            }

            Graphics g = graphics;

            using Font fontThuong = new Font("Times New Roman", 11);
            using Font fontDam = new Font("Times New Roman", 11, FontStyle.Bold);
            using Font fontTieuDe = new Font("Times New Roman", 16, FontStyle.Bold);
            using Font fontNho = new Font("Times New Roman", 10);
            using StringFormat canGiua = new StringFormat
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };
            using StringFormat canTrai = new StringFormat
            {
                Alignment = StringAlignment.Near,
                LineAlignment = StringAlignment.Center
            };

            int x = e.MarginBounds.Left;
            int y = e.MarginBounds.Top;
            int rongTrang = e.MarginBounds.Width;
            int dayTrang = e.MarginBounds.Bottom;

            g.DrawString("NHÀ THUỐC ABC", fontDam, Brushes.Black, x, y);
            y += 30;
            g.DrawString(
                "PHIẾU XIN CẤP THUỐC",
                fontTieuDe,
                Brushes.Black,
                new Rectangle(x, y, rongTrang, 35),
                canGiua);
            y += 42;
            g.DrawString(
                $"Mã phiếu: PXC-{phieuDangIn.MaPhieu:D4}",
                fontDam,
                Brushes.Black,
                new Rectangle(x, y, rongTrang, 25),
                canGiua);
            y += 42;

            string[] thongTin =
            {
                $"Kho cấp     : {phieuDangIn.KhoCap?.TenKho ?? string.Empty}",
                $"Kho nhận   : {phieuDangIn.KhoNhan?.TenKho ?? string.Empty}",
                $"Người lập : {phieuDangIn.NguoiLap?.FullName ?? string.Empty}",
                $"Ngày lập    : {phieuDangIn.NgayLap:dd/MM/yyyy HH:mm}"
            };

            foreach (string dongThongTin in thongTin)
            {
                g.DrawString(dongThongTin, fontThuong, Brushes.Black, x, y);
                y += 25;
            }

            string lyDo = $"Lý do          : {phieuDangIn.LyDo}";
            SizeF caoLyDo = g.MeasureString(lyDo, fontThuong, rongTrang);
            g.DrawString(
                lyDo,
                fontThuong,
                Brushes.Black,
                new RectangleF(x, y, rongTrang, caoLyDo.Height + 5));
            y += (int)caoLyDo.Height + 20;

            int[] rongCot = { 55, rongTrang - 295, 120, 120 };
            string[] tieuDeCot = { "STT", "Tên thuốc", "SL yêu cầu", "SL duyệt" };
            int caoHeader = 34;
            int viTriX = x;

            for (int i = 0; i < tieuDeCot.Length; i++)
            {
                VeO(
                    g,
                    new Rectangle(viTriX, y, rongCot[i], caoHeader),
                    tieuDeCot[i],
                    fontDam,
                    canGiua);
                viTriX += rongCot[i];
            }

            y += caoHeader;

            while (viTriDongDangIn < chiTietDangIn.Count)
            {
                ChiTietPhieuXinCap chiTiet = chiTietDangIn[viTriDongDangIn];
                string tenThuoc = chiTiet.Thuoc?.TenThuoc ?? $"Thuốc #{chiTiet.MaThuoc}";
                int caoDong = Math.Max(
                    35,
                    (int)g.MeasureString(tenThuoc, fontNho, rongCot[1] - 10).Height + 10);

                if (y + caoDong > dayTrang - 170)
                {
                    e.HasMorePages = true;
                    return;
                }

                string[] duLieuDong =
                {
                    (viTriDongDangIn + 1).ToString(),
                    tenThuoc,
                    chiTiet.SoLuongYeuCau.ToString(),
                    chiTiet.SoLuongDuyet?.ToString() ?? "-"
                };

                viTriX = x;

                for (int i = 0; i < duLieuDong.Length; i++)
                {
                    VeO(
                        g,
                        new Rectangle(viTriX, y, rongCot[i], caoDong),
                        duLieuDong[i],
                        fontNho,
                        i == 1 ? canTrai : canGiua);
                    viTriX += rongCot[i];
                }

                y += caoDong;
                viTriDongDangIn++;
            }

            y += 40;
            int nuaTrang = rongTrang / 2;

            g.DrawString(
                "Người lập phiếu",
                fontDam,
                Brushes.Black,
                new Rectangle(x, y, nuaTrang, 25),
                canGiua);
            g.DrawString(
                "Người duyệt",
                fontDam,
                Brushes.Black,
                new Rectangle(x + nuaTrang, y, nuaTrang, 25),
                canGiua);
            y += 95;
            g.DrawString(
                "(Ký, ghi rõ họ tên)",
                fontNho,
                Brushes.Black,
                new Rectangle(x, y, nuaTrang, 25),
                canGiua);
            g.DrawString(
                "(Ký, ghi rõ họ tên)",
                fontNho,
                Brushes.Black,
                new Rectangle(x + nuaTrang, y, nuaTrang, 25),
                canGiua);

            e.HasMorePages = false;
        }

        private static void VeO(
            Graphics g,
            Rectangle khung,
            string noiDung,
            Font font,
            StringFormat canLe)
        {
            g.DrawRectangle(Pens.Black, khung);
            g.DrawString(
                noiDung,
                font,
                Brushes.Black,
                Rectangle.Inflate(khung, -4, -3),
                canLe);
        }
    }
}
