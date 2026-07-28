using Microsoft.EntityFrameworkCore;
using QLQuayThuoc.Data;
using QLQuayThuoc.Models;
using QLQuayThuoc.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace QLQuayThuoc
{
    public partial class DuocSi_ThanhToan : Form
    {

        private static readonly CultureInfo VanHoaVietNam =
            CultureInfo.GetCultureInfo("vi-VN");

        private static readonly HttpClient httpClient = new HttpClient
        {
            Timeout = TimeSpan.FromSeconds(15)
        };

        private static readonly JsonSerializerOptions tuyChonJson =
            new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

        private readonly int maDonThuoc;
        private readonly int maKhoQuay;

        private CauHinhThanhToan? cauHinhThanhToan;

        // MaThuoc -> MaLo -> SoLuongXuat.
        private readonly Dictionary<int, Dictionary<int, int>>
            phanBoLoTheoThuoc =
                new Dictionary<int, Dictionary<int, int>>();

        private readonly Dictionary<int, decimal>
            donGiaDaHienThiTheoThuoc =
                new Dictionary<int, decimal>();

        private decimal tongTienThuocDaHienThi;
        private decimal tienThuocDuocBHYTDaHienThi;
        private int tyLeBHYTDaHienThi;
        private decimal tienBHYTThanhToanDaHienThi;
        private decimal tienBenhNhanTraDaHienThi;

        // Timer 1 giây dùng để hiển thị đếm ngược.
        private readonly System.Windows.Forms.Timer timerDemNguocQR =
            new System.Windows.Forms.Timer();

        // Timer 5 giây dùng để polling API.
        private readonly System.Windows.Forms.Timer timerPollingQR =
            new System.Windows.Forms.Timer();

        private CancellationTokenSource? cancellationTokenSourceQR;
        private DateTime thoiGianHetHanQR;
        private string noiDungChuyenKhoanQR = string.Empty;

        private bool dangXuLy;
        private bool duLieuHopLe;
        private bool qrDangHoatDong;
        private bool dangPolling;

        public DuocSi_ThanhToan()
        {
            InitializeComponent();
            CauHinhGiaoDien();

            Load += DuocSi_ThanhToan_Load;
            FormClosed += DuocSi_ThanhToan_FormClosed;

            rdoTienMat.CheckedChanged +=
                rdoPhuongThuc_CheckedChanged;

            rdoQuetMa.CheckedChanged +=
                rdoPhuongThuc_CheckedChanged;

            btnHuy.Click += btnHuy_Click;
            btnXacNhan.Click += btnXacNhan_Click;

            timerDemNguocQR.Interval = 1000;
            timerDemNguocQR.Tick += timerDemNguocQR_Tick;

            timerPollingQR.Interval = 5000;
            timerPollingQR.Tick += timerPollingQR_Tick;
        }

        public DuocSi_ThanhToan(
            int maDonThuoc,
            int maKhoQuay,
            Dictionary<int, Dictionary<int, int>>
                phanBoLoTheoThuoc)
            : this()
        {
            this.maDonThuoc = maDonThuoc;
            this.maKhoQuay = maKhoQuay;

            // Tạo bản sao để dialog không sửa dữ liệu
            // của UCTiepNhanDon.
            this.phanBoLoTheoThuoc =
                phanBoLoTheoThuoc.ToDictionary(
                    thuoc => thuoc.Key,
                    thuoc => thuoc.Value.ToDictionary(
                        lo => lo.Key,
                        lo => lo.Value));
        }

        private void CauHinhGiaoDien()
        {
            StartPosition =
                FormStartPosition.CenterParent;

            dgv.AutoGenerateColumns = false;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.ReadOnly = true;
            dgv.MultiSelect = false;

            dgv.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgv.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            Column1.FillWeight = 40;
            Column2.FillWeight = 15;
            Column3.FillWeight = 20;
            Column4.FillWeight = 25;

            imgQR.SizeMode =
                PictureBoxSizeMode.Zoom;

            btnHuy.DialogResult =
                DialogResult.Cancel;

            CancelButton = btnHuy;
            AcceptButton = btnXacNhan;

            lblSoTien.Text = "0 đ";
            lblNoiDung.Text = "Chưa tạo";
            lblTrangThai.Text = "Chưa tạo QR";

            rdoTienMat.Checked = true;
            rdoQuetMa.Checked = false;

            CapNhatPhuongThucThanhToan();
        }

        private void DuocSi_ThanhToan_Load(
            object? sender,
            EventArgs e)
        {
            TaiCauHinhThanhToan();
            TaiThongTinDonThuoc();
        }

        private void TaiCauHinhThanhToan()
        {
            try
            {
                using AppDbContext db =
                    new AppDbContext();

                cauHinhThanhToan =
                    db.CauHinhThanhToans
                        .AsNoTracking()
                        .SingleOrDefault(x =>
                            x.MaCauHinh == 1);
                lblChuTK.Text = cauHinhThanhToan?.TenChuTaiKhoan ?? "Chưa cấu hình";
            }
            catch (Exception ex)
            {
                cauHinhThanhToan = null;
                lblChuTK.Text = "Không tải được";

                MessageBox.Show(
                    "Không thể tải cấu hình thanh toán QR.\n" +
                    "Chức năng QR sẽ bị khóa.\n" +
                    LayNoiDungLoi(ex),
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void TaiThongTinDonThuoc()
        {
            try
            {
                using AppDbContext db =
                    new AppDbContext();

                DonThuoc? donThuoc =
                    db.DonThuocs
                        .AsNoTracking()
                        .Include(x => x.BenhNhan)
                        .Include(x => x.BacSi)
                        .Include(x => x.ChiTietDonThuocs)
                            .ThenInclude(x => x.Thuoc)
                        .FirstOrDefault(x =>
                            x.MaDonThuoc == maDonThuoc);

                if (donThuoc == null)
                {
                    KhoaThanhToan(
                        "Không tìm thấy đơn thuốc!");

                    return;
                }

                if (donThuoc.TrangThai !=
                    "CHO_XUAT_THUOC")
                {
                    KhoaThanhToan(
                        "Đơn thuốc không còn ở trạng thái " +
                        "chờ xuất thuốc.");

                    return;
                }

                if (donThuoc.ChiTietDonThuocs.Count == 0)
                {
                    KhoaThanhToan(
                        "Đơn thuốc chưa có thuốc!");

                    return;
                }

                HienThiThongTinDonThuoc(
                    donThuoc);

                duLieuHopLe = true;

                CapNhatPhuongThucThanhToan();
            }
            catch (Exception ex)
            {
                KhoaThanhToan(
                    "Không thể tải thông tin thanh toán!\n" +
                    LayNoiDungLoi(ex));
            }
        }

        private void HienThiThongTinDonThuoc(
            DonThuoc donThuoc)
        {
            lblMaDonThuoc.Text =
                donThuoc.MaDonThuoc.ToString();

            lblBenhNhan.Text =
                donThuoc.BenhNhan.HoTen;

            lblNgaySinh.Text =
                donThuoc.BenhNhan.NgaySinh.ToString(
                    "dd/MM/yyyy");

            lblBacSiKeDon.Text =
                donThuoc.BacSi.FullName;

            lblNgayKeDon.Text =
                donThuoc.NgayKeDon.ToString(
                    "dd/MM/yyyy HH:mm");

            lblMaBHYT.Text =
                string.IsNullOrWhiteSpace(
                    donThuoc.BenhNhan.MaBHYT)
                    ? "Không có"
                    : donThuoc.BenhNhan.MaBHYT;

            dgv.Rows.Clear();
            donGiaDaHienThiTheoThuoc.Clear();

            foreach (ChiTietDonThuoc chiTiet
                in donThuoc.ChiTietDonThuocs
                    .OrderBy(x =>
                        x.Thuoc.TenThuoc))
            {
                decimal thanhTien =
                    chiTiet.SoLuong *
                    chiTiet.Thuoc.DonGiaBan;

                dgv.Rows.Add(
                    chiTiet.Thuoc.TenThuoc,
                    chiTiet.SoLuong,
                    DinhDangTien(
                        chiTiet.Thuoc.DonGiaBan),
                    DinhDangTien(thanhTien));

                donGiaDaHienThiTheoThuoc[
                    chiTiet.MaThuoc] =
                    chiTiet.Thuoc.DonGiaBan;
            }

            TinhTienThanhToan(
                donThuoc,
                DateTime.Today,
                out tongTienThuocDaHienThi,
                out tienThuocDuocBHYTDaHienThi,
                out tyLeBHYTDaHienThi,
                out tienBHYTThanhToanDaHienThi,
                out tienBenhNhanTraDaHienThi);

            lblTongTienThuoc.Text =
                DinhDangTien(
                    tongTienThuocDaHienThi);

            lblMucBHYT.Text =
                tyLeBHYTDaHienThi + "%";

            lblBHYTtt.Text =
                DinhDangTien(
                    tienBHYTThanhToanDaHienThi);

            lblTienBNTra.Text =
                DinhDangTien(
                    tienBenhNhanTraDaHienThi);

            lblSoTien.Text =
                DinhDangTien(
                    tienBenhNhanTraDaHienThi);

            lblNoiDung.Text = "Chưa tạo";
            lblTrangThai.Text = "Chưa tạo QR";
        }

        private static void TinhTienThanhToan(
            DonThuoc donThuoc,
            DateTime ngayThanhToan,
            out decimal tongTienThuoc,
            out decimal tienThuocDuocBHYT,
            out int tyLeBHYT,
            out decimal tienBHYTThanhToan,
            out decimal tienBenhNhanTra)
        {
            tongTienThuoc =
                donThuoc.ChiTietDonThuocs
                    .Sum(x =>
                        x.SoLuong *
                        x.Thuoc.DonGiaBan);

            tienThuocDuocBHYT =
                donThuoc.ChiTietDonThuocs
                    .Where(x =>
                        x.Thuoc.DuocBHYTChiTra)
                    .Sum(x =>
                        x.SoLuong *
                        x.Thuoc.DonGiaBan);

            bool theBHYTConHan =
                !string.IsNullOrWhiteSpace(
                    donThuoc.BenhNhan.MaBHYT) &&

                donThuoc.BenhNhan
                    .NgayHetHanBHYT
                    .HasValue &&

                donThuoc.BenhNhan
                    .NgayHetHanBHYT
                    .Value.Date >=
                    ngayThanhToan.Date;

            tyLeBHYT =
                theBHYTConHan
                    ? donThuoc.BenhNhan.MucHuongBHYT
                    : 0;

            tienBHYTThanhToan =
                decimal.Round(
                    tienThuocDuocBHYT *
                    tyLeBHYT /
                    100m,
                    2,
                    MidpointRounding.AwayFromZero);

            tienBenhNhanTra =
                tongTienThuoc -
                tienBHYTThanhToan;
        }

        private void rdoPhuongThuc_CheckedChanged(
            object? sender,
            EventArgs e)
        {
            // Hai RadioButton cùng phát sự kiện
            // khi thay đổi lựa chọn.
            if (sender is System.Windows.Forms.RadioButton radioButton &&
                !radioButton.Checked)
            {
                return;
            }

            if (rdoQuetMa.Checked)
            {
                CapNhatPhuongThucThanhToan();
                BatDauThanhToanQR();
                return;
            }

            HuyPhienThanhToanQR();
            CapNhatPhuongThucThanhToan();
        }

        private void CapNhatPhuongThucThanhToan()
        {
            grbQRCode.Visible =
                rdoQuetMa.Checked;

            // QR tự xác nhận khi tìm thấy giao dịch.
            btnXacNhan.Enabled =
                !dangXuLy &&
                duLieuHopLe &&
                rdoTienMat.Checked;

            btnHuy.Enabled =
                !dangXuLy;

            rdoTienMat.Enabled =
                !dangXuLy &&
                duLieuHopLe;

            rdoQuetMa.Enabled =
                !dangXuLy &&
                duLieuHopLe &&
                DaCauHinhApiNganHang();
        }

        private void btnHuy_Click(
            object? sender,
            EventArgs e)
        {
            if (dangXuLy)
            {
                return;
            }

            DialogResult =
                DialogResult.Cancel;

            Close();
        }

        private void btnXacNhan_Click(
            object? sender,
            EventArgs e)
        {
            if (dangXuLy ||
                !duLieuHopLe ||
                !rdoTienMat.Checked)
            {
                return;
            }

            dangXuLy = true;
            Cursor = Cursors.WaitCursor;

            CapNhatPhuongThucThanhToan();

            try
            {
                HoanTatThanhToan(
                    "TIEN_MAT",
                    null,
                    null);

                MessageBox.Show(
                    "Thanh toán và xuất thuốc thành công!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                DialogResult =
                    DialogResult.OK;

                Close();
            }
            catch (Exception ex)
            {
                if (ex is
                    ThongTinThanhToanDaThayDoiException)
                {
                    TaiThongTinDonThuoc();
                }

                MessageBox.Show(
                    "Thanh toán không thành công!\n" +
                    LayNoiDungLoi(ex),
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                dangXuLy = false;
                Cursor = Cursors.Default;

                if (!IsDisposed)
                {
                    CapNhatPhuongThucThanhToan();
                }
            }
        }

        // =====================================================
        // QR: TẠO ẢNH, ĐẾM NGƯỢC VÀ POLLING
        // =====================================================

        private void BatDauThanhToanQR()
        {
            if (!duLieuHopLe ||
                dangXuLy ||
                qrDangHoatDong)
            {
                return;
            }

            if (!DaCauHinhApiNganHang())
            {
                MessageBox.Show(
                    "Cấu hình thanh toán QR chưa hợp lệ " +
                    "hoặc đang bị tắt.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                rdoTienMat.Checked = true;
                return;
            }

            if (tienBenhNhanTraDaHienThi <= 0)
            {
                MessageBox.Show(
                    "Số tiền bệnh nhân phải trả " +
                    "không lớn hơn 0.\n" +
                    "Hãy dùng nút Xác nhận để hoàn tất đơn.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                rdoTienMat.Checked = true;
                return;
            }

            CauHinhThanhToan cauHinh = cauHinhThanhToan!;

            string maNgauNhien =
                Guid.NewGuid()
                    .ToString("N")
                    .Substring(0, 6)
                    .ToUpperInvariant();

            // Chỉ dùng chữ và số để ngân hàng
            // giữ nguyên nội dung.
            noiDungChuyenKhoanQR =
                cauHinh.TienToNoiDungChuyenKhoan.Trim() +
                maDonThuoc +
                maNgauNhien;

            thoiGianHetHanQR =
                DateTime.Now.AddMinutes(15);

            cancellationTokenSourceQR =
                new CancellationTokenSource();

            qrDangHoatDong = true;

            lblSoTien.Text =
                DinhDangTien(
                    tienBenhNhanTraDaHienThi);

            lblNoiDung.Text =
                noiDungChuyenKhoanQR;

            TaoAnhQR();
            CapNhatThoiGianConLaiQR();

            timerDemNguocQR.Start();
            timerPollingQR.Start();
        }

        private bool DaCauHinhApiNganHang()
        {
            if (cauHinhThanhToan == null || !cauHinhThanhToan.DangHoatDong)
            {
                return false;
            }

            CauHinhThanhToan cauHinh = cauHinhThanhToan;

            bool duLieuDayDu =
                !string.IsNullOrWhiteSpace(
                    cauHinh.MatKhauApi) &&

                !string.IsNullOrWhiteSpace(
                    cauHinh.TokenApi) &&

                !string.IsNullOrWhiteSpace(
                    cauHinh.DuongDanApiGiaoDich) &&

                !string.IsNullOrWhiteSpace(
                    cauHinh.MaNganHang) &&

                !string.IsNullOrWhiteSpace(
                    cauHinh.SoTaiKhoan) &&

                !string.IsNullOrWhiteSpace(
                    cauHinh.TenChuTaiKhoan) &&

                !string.IsNullOrWhiteSpace(
                    cauHinh.DuongDanTaoQR) &&

                !string.IsNullOrWhiteSpace(
                    cauHinh.MaDinhDanhQR) &&

                !string.IsNullOrWhiteSpace(
                    cauHinh.TienToNoiDungChuyenKhoan);

            if (!duLieuDayDu)
            {
                return false;
            }

            bool laDuLieuTest =
                cauHinh.MatKhauApi.StartsWith(
                    "TEST_",
                    StringComparison.OrdinalIgnoreCase) ||

                cauHinh.TokenApi.StartsWith(
                    "TEST_",
                    StringComparison.OrdinalIgnoreCase);

            bool duongDanHopLe =
                Uri.TryCreate(
                    cauHinh.DuongDanApiGiaoDich,
                    UriKind.Absolute,
                    out _) &&

                Uri.TryCreate(
                    cauHinh.DuongDanTaoQR,
                    UriKind.Absolute,
                    out _);

            return !laDuLieuTest && duongDanHopLe;
        }

        private void TaoAnhQR()
        {
            CauHinhThanhToan cauHinh =
                cauHinhThanhToan ??
                throw new InvalidOperationException(
                    "Không tìm thấy cấu hình thanh toán QR.");

            string soTien =
                tienBenhNhanTraDaHienThi.ToString(
                    "0.##",
                    CultureInfo.InvariantCulture);

            string duongDanQR =
                cauHinh.DuongDanTaoQR.TrimEnd('/') +
                "/" +
                Uri.EscapeDataString(
                    cauHinh.MaNganHang) +
                "-" +
                Uri.EscapeDataString(
                    cauHinh.SoTaiKhoan) +
                "-" +
                Uri.EscapeDataString(
                    cauHinh.MaDinhDanhQR) +
                ".jpg" +
                "?accountName=" +
                Uri.EscapeDataString(
                    cauHinh.TenChuTaiKhoan) +
                "&amount=" +
                Uri.EscapeDataString(
                    soTien) +
                "&addInfo=" +
                Uri.EscapeDataString(
                    noiDungChuyenKhoanQR);

            imgQR.LoadAsync(duongDanQR);
        }

        private void timerDemNguocQR_Tick(
            object? sender,
            EventArgs e)
        {
            CapNhatThoiGianConLaiQR();
        }

        private void CapNhatThoiGianConLaiQR()
        {
            if (!qrDangHoatDong)
            {
                return;
            }

            int tongGiayConLai =
                (int)Math.Ceiling(
                    (thoiGianHetHanQR -
                     DateTime.Now).TotalSeconds);

            if (tongGiayConLai <= 0)
            {
                HuyPhienThanhToanQR();

                rdoTienMat.Checked = true;

                MessageBox.Show(
                    "Mã QR đã hết hạn sau 15 phút.\n" +
                    "Hãy chọn lại QRCode để tạo mã mới.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return;
            }

            int soPhut =
                tongGiayConLai / 60;

            int soGiay =
                tongGiayConLai % 60;

            lblTrangThai.Text =
                "Đang chờ thanh toán - còn " +
                soPhut.ToString("00") +
                ":" +
                soGiay.ToString("00");
        }

        private void DungBoDemVaPollingQR()
        {
            timerDemNguocQR.Stop();
            timerPollingQR.Stop();

            qrDangHoatDong = false;

            if (cancellationTokenSourceQR != null)
            {
                cancellationTokenSourceQR.Cancel();
                cancellationTokenSourceQR.Dispose();
                cancellationTokenSourceQR = null;
            }
        }

        private void HuyPhienThanhToanQR()
        {
            DungBoDemVaPollingQR();

            noiDungChuyenKhoanQR =
                string.Empty;

            imgQR.CancelAsync();
            imgQR.ImageLocation = null;

            Image? anhCu = imgQR.Image;

            imgQR.Image = null;
            anhCu?.Dispose();

            lblNoiDung.Text =
                "Chưa tạo";

            lblTrangThai.Text =
                "Chưa tạo QR";
        }

        private async void timerPollingQR_Tick(
            object? sender,
            EventArgs e)
        {
            await KiemTraGiaoDichQRAsync();
        }

        private async Task KiemTraGiaoDichQRAsync()
        {
            if (!qrDangHoatDong ||
                dangPolling ||
                dangXuLy ||
                !rdoQuetMa.Checked ||
                cancellationTokenSourceQR == null)
            {
                return;
            }

            CancellationToken cancellationToken =
                cancellationTokenSourceQR.Token;

            dangPolling = true;

            try
            {
                GiaoDichNganHang? giaoDich =
                    await TimGiaoDichPhuHopAsync(
                        cancellationToken);

                if (giaoDich == null ||
                    cancellationToken.IsCancellationRequested ||
                    !qrDangHoatDong)
                {
                    return;
                }

                string noiDungDaThanhToan =
                    noiDungChuyenKhoanQR;

                DungBoDemVaPollingQR();

                dangXuLy = true;
                Cursor = Cursors.WaitCursor;

                CapNhatPhuongThucThanhToan();

                lblTrangThai.Text =
                    "Đã nhận tiền, đang hoàn tất...";

                try
                {
                    HoanTatThanhToan(
                        "CHUYEN_KHOAN",
                        noiDungChuyenKhoanQR,
                        giaoDich.TransactionID);

                    DungBoDemVaPollingQR();

                    MessageBox.Show(
                        "Thanh toán QR thành công.\n\n" +
                        "Số tiền: " +
                        DinhDangTien(
                            tienBenhNhanTraDaHienThi) +
                        "\nMã giao dịch: " +
                        giaoDich.TransactionID +
                        "\n\nĐã xuất thuốc và lưu hóa đơn.",
                        "Thanh toán thành công",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    DialogResult = DialogResult.OK;
                    Close();
                }
                catch (Exception ex)
                {
                    dangXuLy = false;
                    duLieuHopLe = false;
                    Cursor = Cursors.Default;

                    if (!IsDisposed)
                    {
                        lblTrangThai.Text =
                            "Đã nhận tiền nhưng không thể lưu.";

                        CapNhatPhuongThucThanhToan();

                        MessageBox.Show(
                            "Đã tìm thấy giao dịch " +
                            giaoDich.TransactionID +
                            " nhưng không thể hoàn tất " +
                            "xuất thuốc!\n" +
                            LayNoiDungLoi(ex) +
                            "\nKhông yêu cầu bệnh nhân " +
                            "thanh toán lại.",
                            "Lỗi",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
            }
            catch (OperationCanceledException)
            {
                // Người dùng đổi sang tiền mặt
                // hoặc đóng Form.
            }
            catch (Exception ex)
            {
                if (!IsDisposed &&
                    qrDangHoatDong)
                {
                    lblTrangThai.Text =
                        "Lỗi kiểm tra giao dịch: " +
                        LayNoiDungLoi(ex);
                }
            }
            finally
            {
                dangPolling = false;
            }
        }

        private async Task<GiaoDichNganHang?>
            TimGiaoDichPhuHopAsync(
                CancellationToken cancellationToken)
        {
            CauHinhThanhToan cauHinh =
                cauHinhThanhToan ??
                throw new InvalidOperationException(
                    "Không tìm thấy cấu hình API ngân hàng.");

            string duongDanApi =
                cauHinh.DuongDanApiGiaoDich.TrimEnd('/') +
                "/" +
                Uri.EscapeDataString(
                    cauHinh.MatKhauApi) +
                "/" +
                Uri.EscapeDataString(
                    cauHinh.SoTaiKhoan) +
                "/" +
                Uri.EscapeDataString(
                    cauHinh.TokenApi);

            using HttpResponseMessage response =
                await httpClient.GetAsync(
                    duongDanApi,
                    cancellationToken);

            response.EnsureSuccessStatusCode();

            string json =
                await response.Content
                    .ReadAsStringAsync(
                        cancellationToken);

            KetQuaLichSuGiaoDich? ketQua =
                JsonSerializer.Deserialize<
                    KetQuaLichSuGiaoDich>(
                        json,
                        tuyChonJson);

            if (ketQua == null)
            {
                throw new InvalidOperationException(
                    "API không trả về dữ liệu.");
            }

            if (!string.Equals(
                ketQua.Status,
                "success",
                StringComparison.OrdinalIgnoreCase))
            {
                throw new InvalidOperationException(
                    string.IsNullOrWhiteSpace(
                        ketQua.Message)
                        ? "API trả về trạng thái thất bại."
                        : ketQua.Message);
            }

            List<GiaoDichNganHang>
                cacGiaoDichPhuHop =
                    (ketQua.Transactions ??
                     new List<GiaoDichNganHang>())
                    .Where(x =>
                        string.Equals(
                            x.Type,
                            "IN",
                            StringComparison
                                .OrdinalIgnoreCase) &&

                        x.Amount ==
                            tienBenhNhanTraDaHienThi &&

                        !string.IsNullOrWhiteSpace(
                            x.TransactionID) &&

                        !string.IsNullOrWhiteSpace(
                            x.Description) &&

                        x.Description.Contains(
                            noiDungChuyenKhoanQR,
                            StringComparison
                                .OrdinalIgnoreCase))
                    .ToList();

            if (cacGiaoDichPhuHop.Count == 0)
            {
                return null;
            }

            using AppDbContext db =
                new AppDbContext();

            foreach (GiaoDichNganHang giaoDich
                in cacGiaoDichPhuHop)
            {
                bool daSuDung =
                    db.HoaDons
                        .AsNoTracking()
                        .Any(x =>
                            x.MaGiaoDich ==
                            giaoDich.TransactionID);

                if (!daSuDung)
                {
                    return giaoDich;
                }
            }

            return null;
        }

        private void DuocSi_ThanhToan_FormClosed(
            object? sender,
            FormClosedEventArgs e)
        {
            DungBoDemVaPollingQR();

            timerDemNguocQR.Dispose();
            timerPollingQR.Dispose();
        }

        // =====================================================
        // GHI PHIẾU XUẤT, HÓA ĐƠN VÀ TRỪ TỒN KHO
        // =====================================================

        private void HoanTatThanhToan(
            string phuongThucThanhToan,
            string? noiDungChuyenKhoan,
            string? maGiaoDich)
        {
            using AppDbContext db =
                new AppDbContext();

            using var transaction =
                db.Database.BeginTransaction(
                    IsolationLevel.Serializable);

            bool laTienMat =
                phuongThucThanhToan ==
                "TIEN_MAT";

            bool laChuyenKhoan =
                phuongThucThanhToan ==
                "CHUYEN_KHOAN";

            if (!laTienMat &&
                !laChuyenKhoan)
            {
                throw new InvalidOperationException(
                    "Phương thức thanh toán không hợp lệ.");
            }

            if (laChuyenKhoan &&
                (string.IsNullOrWhiteSpace(
                    noiDungChuyenKhoan) ||
                 string.IsNullOrWhiteSpace(
                    maGiaoDich)))
            {
                throw new InvalidOperationException(
                    "Thông tin giao dịch QR không hợp lệ.");
            }

            // Chống dùng lại giao dịch.
            if (laChuyenKhoan &&
                db.HoaDons.Any(x =>
                    x.MaGiaoDich ==
                    maGiaoDich))
            {
                throw new InvalidOperationException(
                    "Giao dịch này đã được sử dụng.");
            }

            DateTime thoiGianThanhToan =
                DateTime.Now;

            DonThuoc? donThuoc =
                db.DonThuocs
                    .Include(x => x.BenhNhan)
                    .Include(x =>
                        x.ChiTietDonThuocs)
                        .ThenInclude(x =>
                            x.Thuoc)
                    .Include(x =>
                        x.PhieuXuatThuoc)
                    .FirstOrDefault(x =>
                        x.MaDonThuoc ==
                        maDonThuoc);

            if (donThuoc == null)
            {
                throw new InvalidOperationException(
                    "Không tìm thấy đơn thuốc.");
            }

            if (donThuoc.TrangThai !=
                "CHO_XUAT_THUOC")
            {
                throw new InvalidOperationException(
                    "Đơn thuốc đã được xử lý hoặc " +
                    "không còn chờ xuất thuốc.");
            }

            if (donThuoc.PhieuXuatThuoc != null ||
                db.PhieuXuatThuocs.Any(x =>
                    x.MaDonThuoc ==
                    maDonThuoc))
            {
                throw new InvalidOperationException(
                    "Đơn thuốc đã có phiếu xuất.");
            }

            User? duocSi =
                db.Users.FirstOrDefault(x =>
                    x.UserId ==
                    UserSession.UserId);

            if (duocSi == null ||
                !duocSi.IsActive ||
                duocSi.Role != "DUOC_SI" ||
                UserSession.Role != "DUOC_SI")
            {
                throw new InvalidOperationException(
                    "Tài khoản hiện tại không phải " +
                    "dược sĩ hợp lệ.");
            }

            bool laKhoQuay =
                db.Khos.Any(x =>
                    x.MaKho == maKhoQuay &&
                    x.LoaiKho == "KHO_QUAY");

            if (!laKhoQuay)
            {
                throw new InvalidOperationException(
                    "Kho xuất không phải kho quầy.");
            }

            if (donThuoc.ChiTietDonThuocs.Count == 0)
            {
                throw new InvalidOperationException(
                    "Đơn thuốc chưa có thuốc.");
            }

            Dictionary<int, ChiTietDonThuoc>
                chiTietTheoThuoc =
                    donThuoc.ChiTietDonThuocs
                        .ToDictionary(x =>
                            x.MaThuoc);

            HashSet<int> maThuocTrongDon =
                chiTietTheoThuoc.Keys
                    .ToHashSet();

            HashSet<int> maThuocDaPhanBo =
                phanBoLoTheoThuoc.Keys
                    .ToHashSet();

            if (!maThuocTrongDon.SetEquals(
                maThuocDaPhanBo))
            {
                throw new InvalidOperationException(
                    "Danh sách thuốc phân bổ " +
                    "không khớp với đơn thuốc.");
            }

            var cacDongXuat =
                phanBoLoTheoThuoc
                    .SelectMany(thuoc =>
                        thuoc.Value.Select(lo =>
                            new
                            {
                                MaThuoc = thuoc.Key,
                                MaLo = lo.Key,
                                SoLuong = lo.Value
                            }))
                    .ToList();

            if (cacDongXuat.Count == 0 ||
                cacDongXuat.Any(x =>
                    x.SoLuong <= 0))
            {
                throw new InvalidOperationException(
                    "Số lượng xuất theo lô không hợp lệ.");
            }

            bool loBiDungNhieuLan =
                cacDongXuat
                    .GroupBy(x => x.MaLo)
                    .Any(nhom =>
                        nhom.Count() > 1);

            if (loBiDungNhieuLan)
            {
                throw new InvalidOperationException(
                    "Một lô thuốc đang được " +
                    "phân bổ nhiều lần.");
            }

            List<int> maLoDaChon =
                cacDongXuat
                    .Select(x => x.MaLo)
                    .Distinct()
                    .ToList();

            List<TonKho> danhSachTonKho =
                db.TonKhos
                    .Include(x => x.LoThuoc)
                    .Where(x =>
                        x.MaKho == maKhoQuay &&
                        maLoDaChon.Contains(
                            x.MaLo))
                    .ToList();

            if (danhSachTonKho.Count !=
                maLoDaChon.Count)
            {
                throw new InvalidOperationException(
                    "Có lô thuốc không còn tồn tại " +
                    "tại kho quầy.");
            }

            Dictionary<int, TonKho>
                tonKhoTheoLo =
                    danhSachTonKho
                        .ToDictionary(x =>
                            x.MaLo);

            foreach (
                KeyValuePair<
                    int,
                    Dictionary<int, int>>
                phanBoThuoc
                in phanBoLoTheoThuoc)
            {
                ChiTietDonThuoc chiTietDon =
                    chiTietTheoThuoc[
                        phanBoThuoc.Key];

                long tongSoLuongPhanBo =
                    phanBoThuoc.Value.Values
                        .Sum(x => (long)x);

                if (tongSoLuongPhanBo !=
                    chiTietDon.SoLuong)
                {
                    throw new InvalidOperationException(
                        "Thuốc " +
                        chiTietDon.Thuoc.TenThuoc +
                        " chưa được phân bổ đúng số lượng.");
                }

                foreach (
                    KeyValuePair<int, int>
                    phanBoLo
                    in phanBoThuoc.Value)
                {
                    if (!tonKhoTheoLo.TryGetValue(
                        phanBoLo.Key,
                        out TonKho? tonKho))
                    {
                        throw new InvalidOperationException(
                            "Không tìm thấy tồn kho " +
                            "của lô đã chọn.");
                    }

                    if (tonKho.LoThuoc.MaThuoc !=
                        phanBoThuoc.Key)
                    {
                        throw new InvalidOperationException(
                            "Lô đã chọn không thuộc đúng " +
                            "thuốc trong đơn.");
                    }

                    if (tonKho.LoThuoc.NgayHetHan.Date <
                        thoiGianThanhToan.Date)
                    {
                        throw new InvalidOperationException(
                            "Lô " +
                            tonKho.LoThuoc.SoLo +
                            " đã hết hạn.");
                    }

                    if (tonKho.SoLuongTon <
                        phanBoLo.Value)
                    {
                        throw new InvalidOperationException(
                            "Lô " +
                            tonKho.LoThuoc.SoLo +
                            " không còn đủ tồn kho.");
                    }
                }
            }

            TinhTienThanhToan(
                donThuoc,
                thoiGianThanhToan.Date,
                out decimal tongTienThuoc,
                out decimal tienThuocDuocBHYT,
                out int tyLeBHYT,
                out decimal tienBHYTThanhToan,
                out decimal tienBenhNhanTra);

            bool donGiaDaThayDoi =
                donThuoc.ChiTietDonThuocs
                    .Any(x =>
                        !donGiaDaHienThiTheoThuoc
                            .TryGetValue(
                                x.MaThuoc,
                                out decimal
                                    donGiaDaHienThi) ||
                        donGiaDaHienThi !=
                            x.Thuoc.DonGiaBan);

            bool soTienDaThayDoi =
                tongTienThuoc !=
                    tongTienThuocDaHienThi ||

                tienThuocDuocBHYT !=
                    tienThuocDuocBHYTDaHienThi ||

                tyLeBHYT !=
                    tyLeBHYTDaHienThi ||

                tienBHYTThanhToan !=
                    tienBHYTThanhToanDaHienThi ||

                tienBenhNhanTra !=
                    tienBenhNhanTraDaHienThi;

            if (donGiaDaThayDoi ||
                soTienDaThayDoi)
            {
                throw new
                    ThongTinThanhToanDaThayDoiException();
            }

            PhieuXuatThuoc phieuXuat =
                new PhieuXuatThuoc
                {
                    MaDonThuoc =
                        donThuoc.MaDonThuoc,

                    MaKho =
                        maKhoQuay,

                    DuocSiId =
                        duocSi.UserId,

                    NgayXuat =
                        thoiGianThanhToan
                };

            foreach (var dongXuat
                in cacDongXuat
                    .OrderBy(x => x.MaThuoc)
                    .ThenBy(x => x.MaLo))
            {
                ChiTietDonThuoc chiTietDon =
                    chiTietTheoThuoc[
                        dongXuat.MaThuoc];

                decimal donGiaBan =
                    chiTietDon.Thuoc.DonGiaBan;

                phieuXuat.ChiTietPhieuXuats.Add(
                    new ChiTietPhieuXuat
                    {
                        MaLo =
                            dongXuat.MaLo,

                        SoLuong =
                            dongXuat.SoLuong,

                        DonGiaBan =
                            donGiaBan,

                        ThanhTien =
                            donGiaBan *
                            dongXuat.SoLuong
                    });

                tonKhoTheoLo[dongXuat.MaLo]
                    .SoLuongTon -=
                    dongXuat.SoLuong;
            }

            HoaDon hoaDon =
                new HoaDon
                {
                    PhieuXuatThuoc =
                        phieuXuat,

                    TongTienThuoc =
                        tongTienThuoc,

                    TienThuocDuocBHYT =
                        tienThuocDuocBHYT,

                    TyLeBHYTApDung =
                        tyLeBHYT,

                    TienBHYTThanhToan =
                        tienBHYTThanhToan,

                    TienBenhNhanTra =
                        tienBenhNhanTra,

                    PhuongThucThanhToan =
                        phuongThucThanhToan,

                    NoiDungChuyenKhoan =
                        noiDungChuyenKhoan,

                    MaGiaoDich =
                        maGiaoDich,

                    ThoiGianThanhToan =
                        thoiGianThanhToan
                };

            db.PhieuXuatThuocs.Add(
                phieuXuat);

            db.HoaDons.Add(
                hoaDon);

            donThuoc.TrangThai =
                "DA_XUAT_THUOC";

            db.SaveChanges();
            transaction.Commit();
        }

        private void KhoaThanhToan(
            string noiDung)
        {
            duLieuHopLe = false;

            CapNhatPhuongThucThanhToan();

            MessageBox.Show(
                noiDung,
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
        }

        private static string DinhDangTien(
            decimal soTien)
        {
            return soTien.ToString(
                "N0",
                VanHoaVietNam) +
                " đ";
        }

        private static string LayNoiDungLoi(
            Exception ex)
        {
            Exception loiCuoi = ex;

            while (loiCuoi.InnerException != null)
            {
                loiCuoi =
                    loiCuoi.InnerException;
            }

            return loiCuoi.Message;
        }

        private sealed class KetQuaLichSuGiaoDich
        {
            public string Status { get; set; } =
                string.Empty;

            public string Message { get; set; } =
                string.Empty;

            public List<GiaoDichNganHang>?
                Transactions
            {
                get;
                set;
            }
        }

        private sealed class GiaoDichNganHang
        {
            public string TransactionID { get; set; } =
                string.Empty;

            public decimal Amount { get; set; }

            public string Description { get; set; } =
                string.Empty;

            public string TransactionDate { get; set; } =
                string.Empty;

            public string Type { get; set; } =
                string.Empty;
        }

        private sealed class
            ThongTinThanhToanDaThayDoiException
            : Exception
        {
            public ThongTinThanhToanDaThayDoiException()
                : base(
                    "Giá thuốc hoặc quyền lợi BHYT " +
                    "đã thay đổi.\n" +
                    "Số tiền đã được cập nhật, " +
                    "vui lòng kiểm tra và xác nhận lại.")
            {
            }
        }
    }
}