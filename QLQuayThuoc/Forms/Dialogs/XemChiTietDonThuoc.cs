using Microsoft.EntityFrameworkCore;
using QLQuayThuoc.Data;
using QLQuayThuoc.Utils;
using System.Data;
using QLQuayThuoc.Models;
using System.Drawing.Printing;

namespace QLQuayThuoc.Forms.Dialogs
{
    public partial class XemChiTietDonThuoc : Form
    {
        private int maDonThuoc;

        private int maDonThuocCanIn;
        private DateTime ngayKeDonCanIn;
        private string tenBacSiCanIn = string.Empty;
        private BenhNhan? benhNhanCanIn;
        private string chanDoanCanIn = string.Empty;
        private string ghiChuDonCanIn = string.Empty;

        private List<ChiTietDonThuoc> danhSachThuocCanIn =
            new List<ChiTietDonThuoc>();

        private int viTriThuocDangIn;
        public XemChiTietDonThuoc()
        {
            InitializeComponent();

            StartPosition = FormStartPosition.CenterParent;

            dgv.AutoGenerateColumns = false;
            dgv.AllowUserToAddRows = false;
            dgv.ReadOnly = true;
            dgv.MultiSelect = false;

            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        public XemChiTietDonThuoc(int maDonThuoc) : this()
        {
            this.maDonThuoc = maDonThuoc;
        }

        private void LoadChiTietDonThuoc()
        {
            if (UserSession.UserId <= 0)
            {
                MessageBox.Show(
                    "Không xác định được bác sĩ đang đăng nhập!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                Close();
                return;
            }

            try
            {
                using (AppDbContext db = new AppDbContext())
                {
                    // Lấy thông tin đơn và bệnh nhân
                    var donThuoc = db.DonThuocs
                        .AsNoTracking()
                        .Where(x =>
                            x.MaDonThuoc == maDonThuoc &&
                            x.BacSiId == UserSession.UserId)
                        .Select(x => new
                        {
                            x.MaDonThuoc,
                            x.NgayKeDon,
                            x.ChanDoan,
                            x.TrangThai,
                            x.GhiChu,

                            MaBenhNhan =
                                x.BenhNhan.MaBN,

                            HoTenBenhNhan =
                                x.BenhNhan.HoTen,

                            x.BenhNhan.NgaySinh,
                            x.BenhNhan.GioiTinh,
                            x.BenhNhan.DiaChi
                        })
                        .FirstOrDefault();

                    if (donThuoc == null)
                    {
                        MessageBox.Show(
                            "Không tìm thấy đơn thuốc hoặc đơn này không thuộc bác sĩ đang đăng nhập!",
                            "Thông báo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);

                        DialogResult = DialogResult.Cancel;
                        Close();
                        return;
                    }

                    // Hiển thị thông tin đơn thuốc
                    lblMaDonThuoc.Text =
                        donThuoc.MaDonThuoc.ToString();

                    lblNgayKe.Text =
                        donThuoc.NgayKeDon.ToString(
                            "dd/MM/yyyy HH:mm");

                    lblChanDoan.Text =
                        donThuoc.ChanDoan;

                    lblTrangThai.Text =
                        donThuoc.TrangThai == "DA_XUAT_DON"
                            ? "Đã xuất đơn"
                            : donThuoc.TrangThai;

                    lblGhiChu.Text =
                        string.IsNullOrWhiteSpace(
                            donThuoc.GhiChu)
                            ? "Không có"
                            : donThuoc.GhiChu;

                    // Hiển thị thông tin bệnh nhân
                    lblMaBN.Text =
                        donThuoc.MaBenhNhan.ToString();

                    lblHoTenBN.Text =
                        donThuoc.HoTenBenhNhan;

                    lblNgaySinh.Text =
                        donThuoc.NgaySinh.ToString(
                            "dd/MM/yyyy");

                    lblGioiTinh.Text =
                        donThuoc.GioiTinh
                            ? "Nam"
                            : "Nữ";

                    lblDiaChi.Text =
                        donThuoc.DiaChi;

                    // Lấy danh sách thuốc trong đơn
                    var danhSachThuoc =
                        db.ChiTietDonThuocs
                            .AsNoTracking()
                            .Where(x =>
                                x.MaDonThuoc == maDonThuoc)
                            .OrderBy(x => x.MaThuoc)
                            .Select(x => new
                            {
                                x.MaThuoc,
                                TenThuoc =
                                    x.Thuoc.TenThuoc,
                                x.SoLuong,
                                x.LieuDung,
                                x.TanSuat,
                                x.SoNgayDung,
                                x.GhiChu
                            })
                            .ToList();

                    dgv.Rows.Clear();

                    foreach (var thuoc in danhSachThuoc)
                    {
                        dgv.Rows.Add(
                            thuoc.MaThuoc,
                            thuoc.TenThuoc,
                            thuoc.SoLuong,
                            thuoc.LieuDung,
                            thuoc.TanSuat,
                            thuoc.SoNgayDung,
                            thuoc.GhiChu ?? "");
                    }

                    dgv.ClearSelection();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Không thể tải chi tiết đơn thuốc!\n" +
                    ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private bool TaiDuLieuInLai()
        {
            benhNhanCanIn = null;
            danhSachThuocCanIn.Clear();

            if (UserSession.UserId <= 0)
            {
                MessageBox.Show(
                    "Không xác định được bác sĩ đang đăng nhập!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return false;
            }

            using (AppDbContext db = new AppDbContext())
            {
                DonThuoc? donThuoc = db.DonThuocs
                    .AsNoTracking()
                    .Include(x => x.BenhNhan)
                    .Include(x => x.BacSi)
                    .Include(x => x.ChiTietDonThuocs)
                        .ThenInclude(x => x.Thuoc)
                    .FirstOrDefault(x =>
                        x.MaDonThuoc == maDonThuoc &&
                        x.BacSiId == UserSession.UserId);

                if (donThuoc == null)
                {
                    MessageBox.Show(
                        "Không tìm thấy đơn thuốc hoặc đơn này " +
                        "không thuộc bác sĩ đang đăng nhập!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return false;
                }

                List<ChiTietDonThuoc> danhSachThuoc =
                    donThuoc.ChiTietDonThuocs
                        .OrderBy(x => x.MaThuoc)
                        .ToList();

                if (danhSachThuoc.Count == 0)
                {
                    MessageBox.Show(
                        "Đơn thuốc không có thuốc để in!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return false;
                }

                maDonThuocCanIn =
                    donThuoc.MaDonThuoc;

                ngayKeDonCanIn =
                    donThuoc.NgayKeDon;

                tenBacSiCanIn =
                    donThuoc.BacSi.FullName;

                benhNhanCanIn =
                    donThuoc.BenhNhan;

                chanDoanCanIn =
                    donThuoc.ChanDoan;

                ghiChuDonCanIn =
                    donThuoc.GhiChu ?? "";

                danhSachThuocCanIn =
                    danhSachThuoc;

                return true;
            }
        }

        private void TaiLieuIn_PrintPage(
    object sender,
    PrintPageEventArgs e)
        {
            if (benhNhanCanIn == null)
            {
                e.HasMorePages = false;
                return;
            }

            Graphics g = e.Graphics;

            float x = e.MarginBounds.Left;
            float y = e.MarginBounds.Top;
            float chieuRong = e.MarginBounds.Width;

            using Font fontTieuDe =
                new Font("Segoe UI", 18, FontStyle.Bold);

            using Font fontDam =
                new Font("Segoe UI", 10, FontStyle.Bold);

            using Font fontThuong =
                new Font("Segoe UI", 10, FontStyle.Regular);

            using Font fontNho =
                new Font("Segoe UI", 9, FontStyle.Italic);

            using StringFormat canGiua =
                new StringFormat
                {
                    Alignment =
                        StringAlignment.Center,
                    LineAlignment =
                        StringAlignment.Center
                };

            string tieuDe =
                viTriThuocDangIn == 0
                    ? "ĐƠN THUỐC"
                    : "ĐƠN THUỐC (TIẾP)";

            g.DrawString(
                tieuDe,
                fontTieuDe,
                Brushes.Black,
                new RectangleF(
                    x,
                    y,
                    chieuRong,
                    36),
                canGiua);

            y += 42;

            y = VeHaiCot(
                g,
                fontThuong,
                x,
                y,
                chieuRong,
                "Mã đơn: " + maDonThuocCanIn,
                "Ngày kê: " +
                ngayKeDonCanIn.ToString(
                    "dd/MM/yyyy HH:mm"));

            y = VeHaiCot(
                g,
                fontThuong,
                x,
                y,
                chieuRong,
                "Mã bệnh nhân: " +
                benhNhanCanIn.MaBN,
                "Họ tên: " +
                benhNhanCanIn.HoTen);

            y = VeHaiCot(
                g,
                fontThuong,
                x,
                y,
                chieuRong,
                "Ngày sinh: " +
                benhNhanCanIn.NgaySinh.ToString(
                    "dd/MM/yyyy"),
                "Giới tính: " +
                (benhNhanCanIn.GioiTinh
                    ? "Nam"
                    : "Nữ"));

            y = VeHaiCot(
                g,
                fontThuong,
                x,
                y,
                chieuRong,
                "Số điện thoại: " +
                benhNhanCanIn.SoDienThoai,
                "Mã BHYT: " +
                (string.IsNullOrWhiteSpace(
                    benhNhanCanIn.MaBHYT)
                    ? "Không có"
                    : benhNhanCanIn.MaBHYT));

            y = VeMotDong(
                g,
                fontThuong,
                x,
                y,
                chieuRong,
                "Địa chỉ: " +
                benhNhanCanIn.DiaChi);

            y = VeMotDong(
                g,
                fontDam,
                x,
                y,
                chieuRong,
                "Chẩn đoán: " +
                chanDoanCanIn);

            if (!string.IsNullOrWhiteSpace(
                ghiChuDonCanIn))
            {
                y = VeMotDong(
                    g,
                    fontThuong,
                    x,
                    y,
                    chieuRong,
                    "Ghi chú đơn: " +
                    ghiChuDonCanIn);
            }

            y += 5;

            g.DrawLine(
                Pens.Black,
                x,
                y,
                x + chieuRong,
                y);

            y += 8;

            float[] doRongCot =
            {
        chieuRong * 0.05f,
        chieuRong * 0.24f,
        chieuRong * 0.07f,
        chieuRong * 0.19f,
        chieuRong * 0.15f,
        chieuRong * 0.09f,
        chieuRong * 0.21f
    };

            string[] tieuDeCot =
            {
        "STT",
        "Thuốc",
        "SL",
        "Liều dùng",
        "Tần suất",
        "Số ngày",
        "Ghi chú"
    };

            VeHangBang(
                g,
                fontDam,
                x,
                y,
                doRongCot,
                34,
                tieuDeCot,
                true);

            y += 34;

            bool daVeDongTrenTrang = false;

            while (viTriThuocDangIn <
                danhSachThuocCanIn.Count)
            {
                ChiTietDonThuoc chiTiet =
                    danhSachThuocCanIn[
                        viTriThuocDangIn];

                string thongTinThuoc =
                    chiTiet.Thuoc.TenThuoc +
                    " - " +
                    chiTiet.Thuoc.HamLuong +
                    "\nĐVT: " +
                    chiTiet.Thuoc.DonViTinh;

                string[] noiDungDong =
                {
            (viTriThuocDangIn + 1)
                .ToString(),

            thongTinThuoc,

            chiTiet.SoLuong.ToString(),

            chiTiet.LieuDung,

            chiTiet.TanSuat,

            chiTiet.SoNgayDung.ToString(),

            chiTiet.GhiChu ?? ""
        };

                float chieuCaoDong =
                    TinhChieuCaoDong(
                        g,
                        fontThuong,
                        doRongCot,
                        noiDungDong);

                // Chừa phần cuối trang cho chữ ký.
                if (y + chieuCaoDong >
                        e.MarginBounds.Bottom - 135 &&
                    daVeDongTrenTrang)
                {
                    e.HasMorePages = true;
                    return;
                }

                VeHangBang(
                    g,
                    fontThuong,
                    x,
                    y,
                    doRongCot,
                    chieuCaoDong,
                    noiDungDong,
                    false);

                y += chieuCaoDong;

                viTriThuocDangIn++;
                daVeDongTrenTrang = true;
            }

            float yChuKy = Math.Max(
                y + 15,
                e.MarginBounds.Bottom - 115);

            float nuaTrang = chieuRong / 2;

            g.DrawString(
                "Ngày " +
                ngayKeDonCanIn.ToString("dd") +
                " tháng " +
                ngayKeDonCanIn.ToString("MM") +
                " năm " +
                ngayKeDonCanIn.ToString("yyyy"),
                fontThuong,
                Brushes.Black,
                new RectangleF(
                    x + nuaTrang,
                    yChuKy,
                    nuaTrang,
                    25),
                canGiua);

            g.DrawString(
                "BÁC SĨ KÊ ĐƠN",
                fontDam,
                Brushes.Black,
                new RectangleF(
                    x + nuaTrang,
                    yChuKy + 24,
                    nuaTrang,
                    25),
                canGiua);

            g.DrawString(
                "(Ký và ghi rõ họ tên)",
                fontNho,
                Brushes.Black,
                new RectangleF(
                    x + nuaTrang,
                    yChuKy + 47,
                    nuaTrang,
                    22),
                canGiua);

            g.DrawString(
                string.IsNullOrWhiteSpace(
                    tenBacSiCanIn)
                    ? "Bác sĩ"
                    : tenBacSiCanIn,
                fontDam,
                Brushes.Black,
                new RectangleF(
                    x + nuaTrang,
                    yChuKy + 85,
                    nuaTrang,
                    25),
                canGiua);

            e.HasMorePages = false;
        }

        private void MoXemTruocDonThuoc()
        {
            using (PrintDocument taiLieuIn =
                new PrintDocument())
            {
                taiLieuIn.DocumentName =
                    "DonThuoc_" + maDonThuocCanIn;

                taiLieuIn.DefaultPageSettings.PaperSize =
                    new PaperSize("A4", 827, 1169);

                taiLieuIn.DefaultPageSettings.Margins =
                    new Margins(45, 45, 45, 45);

                taiLieuIn.BeginPrint += (sender, e) =>
                {
                    viTriThuocDangIn = 0;
                };

                taiLieuIn.PrintPage +=
                    TaiLieuIn_PrintPage;

                using (PrintPreviewDialog xemTruoc =
                    new PrintPreviewDialog())
                {
                    xemTruoc.Document = taiLieuIn;
                    xemTruoc.WindowState =
                        FormWindowState.Maximized;
                    xemTruoc.UseAntiAlias = true;

                    xemTruoc.ShowDialog(this);
                }
            }
        }

        private float VeHaiCot(
    Graphics g,
    Font font,
    float x,
    float y,
    float chieuRong,
    string cotTrai,
    string cotPhai)
        {
            float khoangCach = 12;
            float nuaTrang =
                (chieuRong - khoangCach) / 2;

            float caoTrai = g.MeasureString(
                cotTrai,
                font,
                new SizeF(nuaTrang, 500)).Height;

            float caoPhai = g.MeasureString(
                cotPhai,
                font,
                new SizeF(nuaTrang, 500)).Height;

            float chieuCao =
                Math.Max(caoTrai, caoPhai) + 4;

            g.DrawString(
                cotTrai,
                font,
                Brushes.Black,
                new RectangleF(
                    x,
                    y,
                    nuaTrang,
                    chieuCao));

            g.DrawString(
                cotPhai,
                font,
                Brushes.Black,
                new RectangleF(
                    x + nuaTrang + khoangCach,
                    y,
                    nuaTrang,
                    chieuCao));

            return y + chieuCao;
        }

        private float VeMotDong(
            Graphics g,
            Font font,
            float x,
            float y,
            float chieuRong,
            string noiDung)
        {
            float chieuCao = g.MeasureString(
                noiDung,
                font,
                new SizeF(chieuRong, 500)).Height + 4;

            g.DrawString(
                noiDung,
                font,
                Brushes.Black,
                new RectangleF(
                    x,
                    y,
                    chieuRong,
                    chieuCao));

            return y + chieuCao;
        }

        private float TinhChieuCaoDong(
            Graphics g,
            Font font,
            float[] doRongCot,
            string[] noiDung)
        {
            float chieuCao = 30;

            for (int i = 0;
                i < noiDung.Length;
                i++)
            {
                float caoNoiDung = g.MeasureString(
                    noiDung[i],
                    font,
                    new SizeF(
                        Math.Max(
                            1,
                            doRongCot[i] - 8),
                        1000)).Height + 8;

                chieuCao = Math.Max(
                    chieuCao,
                    caoNoiDung);
            }

            return chieuCao;
        }

        private void VeHangBang(
            Graphics g,
            Font font,
            float x,
            float y,
            float[] doRongCot,
            float chieuCao,
            string[] noiDung,
            bool laTieuDe)
        {
            float viTriX = x;

            for (int i = 0;
                i < noiDung.Length;
                i++)
            {
                RectangleF o = new RectangleF(
                    viTriX,
                    y,
                    doRongCot[i],
                    chieuCao);

                if (laTieuDe)
                {
                    g.FillRectangle(
                        Brushes.Gainsboro,
                        o);
                }

                g.DrawRectangle(
                    Pens.Black,
                    o.X,
                    o.Y,
                    o.Width,
                    o.Height);

                using StringFormat dinhDang =
                    new StringFormat
                    {
                        Alignment =
                            laTieuDe ||
                            i == 0 ||
                            i == 2 ||
                            i == 5
                                ? StringAlignment.Center
                                : StringAlignment.Near,

                        LineAlignment =
                            StringAlignment.Center,

                        Trimming =
                            StringTrimming.EllipsisCharacter,

                        FormatFlags =
                            StringFormatFlags.LineLimit
                    };

                g.DrawString(
                    noiDung[i],
                    font,
                    Brushes.Black,
                    new RectangleF(
                        o.X + 4,
                        o.Y + 3,
                        o.Width - 8,
                        o.Height - 6),
                    dinhDang);

                viTriX += doRongCot[i];
            }
        }

        private void XemChiTietDonThuoc_Load(object sender, EventArgs e)
        {
            LoadChiTietDonThuoc();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnInLaiDon_Click(object sender, EventArgs e)
        {
            btnInLaiDon.Enabled = false;

            try
            {
                if (!TaiDuLieuInLai())
                {
                    return;
                }

                MoXemTruocDonThuoc();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Không thể mở bản xem trước đơn thuốc!\n" +
                    ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                btnInLaiDon.Enabled = true;
            }
        }
    }
}
