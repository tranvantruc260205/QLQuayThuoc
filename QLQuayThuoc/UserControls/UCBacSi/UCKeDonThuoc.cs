using System.Drawing.Printing;
using Microsoft.EntityFrameworkCore;
using QLQuayThuoc.Data;
using QLQuayThuoc.Forms.Dialogs;
using QLQuayThuoc.Models;
using QLQuayThuoc.Utils;

namespace QLQuayThuoc
{
    public partial class UCKeDonThuoc : UserControl
    {
        private BenhNhan? benhNhanDaChon;
        private List<ChiTietDonThuoc> danhSachThuocTam = new();

        private int maDonThuocCanIn;
        private DateTime ngayKeDonCanIn;
        private string tenBacSiCanIn = string.Empty;
        private BenhNhan? benhNhanCanIn;
        private string chanDoanCanIn = string.Empty;
        private string ghiChuDonCanIn = string.Empty;

        private List<ChiTietDonThuoc> danhSachThuocCanIn = new();

        private int viTriThuocDangIn;
        public UCKeDonThuoc()
        {
            InitializeComponent();

            dgv.AllowUserToAddRows = false;
            dgv.ReadOnly = true;
            dgv.MultiSelect = false;

            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            txtChanDoan.MaxLength = 255;
            txtGhiChu.MaxLength = 255;
        }

        private void MoDialogThemSuaThuoc(
    int? maThuocChonBanDau = null)
        {
            using (BacSi_ThemSuaThuocDonThuoc dialog =
                new BacSi_ThemSuaThuocDonThuoc(
                    danhSachThuocTam,
                    maThuocChonBanDau))
            {
                if (dialog.ShowDialog() != DialogResult.OK)
                {
                    return;
                }

                danhSachThuocTam =
                    dialog.DanhSachThuocDaChon;

                HienThiDanhSachThuoc();
            }
        }

        private void HienThiDanhSachThuoc()
        {
            dgv.Rows.Clear();

            foreach (ChiTietDonThuoc chiTiet
                in danhSachThuocTam)
            {
                string tenThuoc =
                    chiTiet.Thuoc.TenThuoc +
                    " - " +
                    chiTiet.Thuoc.HamLuong +
                    " (" +
                    chiTiet.Thuoc.DonViTinh +
                    ")";

                int dong = dgv.Rows.Add(
                    tenThuoc,
                    chiTiet.SoLuong,
                    chiTiet.LieuDung,
                    chiTiet.TanSuat,
                    chiTiet.SoNgayDung,
                    chiTiet.GhiChu ?? "");

                dgv.Rows[dong].Tag =
                    chiTiet.MaThuoc;
            }

            dgv.ClearSelection();
        }

        private bool KiemTraDuLieuTruocKhiLuu()
        {
            if (benhNhanDaChon == null)
            {
                MessageBox.Show(
                    "Vui lòng chọn bệnh nhân!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return false;
            }

            if (UserSession.UserId <= 0)
            {
                MessageBox.Show(
                    "Không xác định được bác sĩ đang đăng nhập!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return false;
            }

            if (string.IsNullOrWhiteSpace(txtChanDoan.Text))
            {
                MessageBox.Show(
                    "Vui lòng nhập chẩn đoán!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtChanDoan.Focus();
                return false;
            }

            if (txtChanDoan.Text.Trim().Length > 255)
            {
                MessageBox.Show(
                    "Chẩn đoán không được vượt quá 255 ký tự!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtChanDoan.Focus();
                return false;
            }

            if (txtGhiChu.Text.Trim().Length > 255)
            {
                MessageBox.Show(
                    "Ghi chú không được vượt quá 255 ký tự!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtGhiChu.Focus();
                return false;
            }

            if (danhSachThuocTam.Count == 0)
            {
                MessageBox.Show(
                    "Đơn thuốc phải có ít nhất một thuốc!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return false;
            }

            bool coChiTietKhongHopLe =
                danhSachThuocTam.Any(x =>
                    x.MaThuoc <= 0 ||
                    x.SoLuong <= 0 ||
                    x.SoNgayDung <= 0 ||
                    string.IsNullOrWhiteSpace(x.LieuDung) ||
                    string.IsNullOrWhiteSpace(x.TanSuat));

            if (coChiTietKhongHopLe)
            {
                MessageBox.Show(
                    "Danh sách thuốc có thông tin chưa hợp lệ. " +
                    "Vui lòng kiểm tra lại!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return false;
            }

            return true;
        }

        private void ChuanBiDuLieuIn(DonThuoc donThuoc)
        {
            maDonThuocCanIn =
                donThuoc.MaDonThuoc;

            ngayKeDonCanIn =
                donThuoc.NgayKeDon;

            tenBacSiCanIn =
                UserSession.FullName;

            benhNhanCanIn =
                benhNhanDaChon;

            chanDoanCanIn =
                donThuoc.ChanDoan;

            ghiChuDonCanIn =
                donThuoc.GhiChu ?? "";

            // Sao chép danh sách để bản in không bị ảnh hưởng
            // khi làm mới form.
            danhSachThuocCanIn =
                danhSachThuocTam
                    .Select(x => new ChiTietDonThuoc
                    {
                        MaThuoc = x.MaThuoc,
                        SoLuong = x.SoLuong,
                        LieuDung = x.LieuDung,
                        TanSuat = x.TanSuat,
                        SoNgayDung = x.SoNgayDung,
                        GhiChu = x.GhiChu,
                        Thuoc = x.Thuoc
                    })
                    .ToList();
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

                    Form? formCha = FindForm();

                    if (formCha != null)
                    {
                        xemTruoc.ShowDialog(formCha);
                    }
                    else
                    {
                        xemTruoc.ShowDialog();
                    }
                }
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

        private void LamMoiFormKeDon()
        {
            benhNhanDaChon = null;
            danhSachThuocTam.Clear();

            lblMaBN.Text = "";
            lblHoTen.Text = "";
            lblNgaySinh.Text = "";
            lblGioiTinh.Text = "";
            lblBHYT.Text = "";

            txtChanDoan.Clear();
            txtGhiChu.Clear();

            dgv.Rows.Clear();

            benhNhanCanIn = null;
            danhSachThuocCanIn.Clear();

            txtChanDoan.Focus();
        }

        private void btnChonBN_Click(object sender, EventArgs e)
        {
            using (BacSi_ChonBenhNhan dialog =
                new BacSi_ChonBenhNhan())
            {
                if (dialog.ShowDialog() !=
                        DialogResult.OK ||
                    dialog.BenhNhanDuocChon == null)
                {
                    return;
                }

                benhNhanDaChon =
                    dialog.BenhNhanDuocChon;

                lblMaBN.Text =
                    benhNhanDaChon.MaBN.ToString();

                lblHoTen.Text =
                    benhNhanDaChon.HoTen;

                lblNgaySinh.Text =
                    benhNhanDaChon.NgaySinh.ToString(
                        "dd/MM/yyyy");

                lblGioiTinh.Text =
                    benhNhanDaChon.GioiTinh
                        ? "Nam"
                        : "Nữ";

                lblBHYT.Text =
                    string.IsNullOrWhiteSpace(
                        benhNhanDaChon.MaBHYT)
                        ? "Không có"
                        : benhNhanDaChon.MaBHYT;
            }
        }

        private void btnThemThuoc_Click(object sender, EventArgs e)
        {
            MoDialogThemSuaThuoc();
        }

        private void btnSuaDong_Click(object sender, EventArgs e)
        {
            if (dgv.CurrentRow == null || dgv.CurrentRow.Tag is not int maThuoc)
            {
                MessageBox.Show(
                    "Vui lòng chọn thuốc cần sửa!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            MoDialogThemSuaThuoc(maThuoc);
        }

        private void btnXoaDong_Click(object sender, EventArgs e)
        {
            if (dgv.CurrentRow == null || dgv.CurrentRow.Tag is not int maThuoc)
            {
                MessageBox.Show(
                    "Vui lòng chọn thuốc cần xóa!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            ChiTietDonThuoc? chiTiet =
                danhSachThuocTam.FirstOrDefault(x =>
                    x.MaThuoc == maThuoc);

            if (chiTiet == null)
            {
                return;
            }

            DialogResult ketQua = MessageBox.Show(
                "Bạn có chắc muốn xóa thuốc \"" +
                chiTiet.Thuoc.TenThuoc +
                "\" khỏi đơn?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (ketQua != DialogResult.Yes)
            {
                return;
            }

            danhSachThuocTam.Remove(chiTiet);
            HienThiDanhSachThuoc();
        }

        private void btnLuuVaIn_Click(object sender, EventArgs e)
        {
            if (!KiemTraDuLieuTruocKhiLuu())
            {
                return;
            }

            btnLuuVaIn.Enabled = false;

            try
            {
                DonThuoc? donThuocDaLuu = null;

                // Chỉ lấy một lần để database và bản in
                // có cùng thời gian kê đơn.
                DateTime ngayKeDon = DateTime.Now;

                try
                {
                    using (AppDbContext db = new AppDbContext())
                    using (var giaoDich =
                        db.Database.BeginTransaction())
                    {
                        DonThuoc donThuoc = new DonThuoc
                        {
                            MaBN = benhNhanDaChon!.MaBN,
                            BacSiId = UserSession.UserId,
                            NgayKeDon = ngayKeDon,

                            ChanDoan =
                                txtChanDoan.Text.Trim(),

                            TrangThai = "CHO_XUAT_THUOC",

                            GhiChu =
                                string.IsNullOrWhiteSpace(
                                    txtGhiChu.Text)
                                    ? null
                                    : txtGhiChu.Text.Trim()
                        };

                        foreach (ChiTietDonThuoc chiTiet
                            in danhSachThuocTam)
                        {
                            donThuoc.ChiTietDonThuocs.Add(
                                new ChiTietDonThuoc
                                {
                                    MaThuoc = chiTiet.MaThuoc,
                                    SoLuong = chiTiet.SoLuong,
                                    LieuDung = chiTiet.LieuDung,
                                    TanSuat = chiTiet.TanSuat,
                                    SoNgayDung =
                                        chiTiet.SoNgayDung,
                                    GhiChu = chiTiet.GhiChu
                                });
                        }

                        db.DonThuocs.Add(donThuoc);
                        db.SaveChanges();

                        giaoDich.Commit();

                        donThuocDaLuu = donThuoc;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Không thể lưu đơn thuốc!\n" +
                        ex.Message,
                        "Lỗi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return;
                }

                ChuanBiDuLieuIn(donThuocDaLuu);

                try
                {
                    MoXemTruocDonThuoc();

                    MessageBox.Show(
                        "Đã lưu đơn thuốc thành công!\n" +
                        "Mã đơn thuốc: " +
                        donThuocDaLuu.MaDonThuoc,
                        "Thành công",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Đơn thuốc đã được lưu với mã " +
                        donThuocDaLuu.MaDonThuoc +
                        ", nhưng không thể mở bản xem trước!\n" +
                        ex.Message,
                        "Cảnh báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }

                LamMoiFormKeDon();
            }
            finally
            {
                btnLuuVaIn.Enabled = true;
            }
        }
    }
}
