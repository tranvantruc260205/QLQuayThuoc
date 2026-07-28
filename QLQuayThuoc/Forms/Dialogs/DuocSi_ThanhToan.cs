using Microsoft.EntityFrameworkCore;
using QLQuayThuoc.Data;
using QLQuayThuoc.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Net.Http;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;

namespace QLQuayThuoc
{
    public partial class DuocSi_ThanhToan : Form
    {

        private int maDonThuoc;
        private int maKhoQuay;

        private Dictionary<int, Dictionary<int, int>>
            danhSachLoDaChon =
                new Dictionary<int, Dictionary<int, int>>();

        private const string MatKhauApi = "NHAP_PASSWORD_API";

        private const string SoTaiKhoanApi = "7020801";

        private const string TokenApi = "NHAP_TOKEN_API";

        private static readonly HttpClient httpClient =
            new HttpClient
            {
                Timeout = TimeSpan.FromSeconds(15)
            };

        private static readonly JsonSerializerOptions tuyChonJson =
            new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

        // Timer này chỉ dùng để hiển thị đếm ngược.
        private readonly System.Windows.Forms.Timer
            timerDemNguocQR =
                new System.Windows.Forms.Timer();

        // Timer này chỉ dùng để polling API.
        private readonly System.Windows.Forms.Timer
            timerPollingQR =
                new System.Windows.Forms.Timer();

        private CancellationTokenSource?
            cancellationTokenSourceQR;

        private DateTime thoiGianHetHanQR;

        private string noiDungChuyenKhoanQR =
            string.Empty;

        private bool qrDangHoatDong;

        private bool dangPolling;

        private sealed class KetQuaLichSuGiaoDich
        {
            public string Status { get; set; } =
                string.Empty;

            public string Message { get; set; } =
                string.Empty;

            public List<GiaoDichNganHang>? Transactions
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
        public DuocSi_ThanhToan()
        {
            InitializeComponent();

            rdoQuetMa.CheckedChanged +=
        rdoPhuongThuc_CheckedChanged;

            timerDemNguocQR.Interval = 1000;
            timerDemNguocQR.Tick +=
                timerDemNguocQR_Tick;

            timerPollingQR.Interval = 5000;
            timerPollingQR.Tick +=
                timerPollingQR_Tick;

            FormClosed +=
                DuocSi_ThanhToan_FormClosed;

            imgQR.SizeMode =
                PictureBoxSizeMode.Zoom;
        }

        private void rdoPhuongThuc_CheckedChanged(
    object? sender,
    EventArgs e)
        {
            if (rdoQuetMa.Checked)
            {
                CapNhatPhuongThucThanhToan();
                BatDauThanhToanQR();
                return;
            }

            HuyPhienThanhToanQR();
            CapNhatPhuongThucThanhToan();
        }

        public DuocSi_ThanhToan(int maDonThuoc, int maKhoQuay, Dictionary<int, Dictionary<int, int>> danhSachLoDaChon) : this()
        {
            this.maDonThuoc =
                maDonThuoc;

            this.maKhoQuay =
                maKhoQuay;

            this.danhSachLoDaChon =
                danhSachLoDaChon;
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
                    MessageBox.Show(
                        "Không tìm thấy đơn thuốc!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    btnXacNhan.Enabled = false;
                    return;
                }

                // Hiển thị thông tin đơn thuốc.
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

                // Hiển thị danh sách thuốc.
                dgv.Rows.Clear();

                decimal tongTienThuoc = 0;
                decimal tienThuocDuocBHYT = 0;

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

                    tongTienThuoc +=
                        thanhTien;

                    if (chiTiet.Thuoc.DuocBHYTChiTra)
                    {
                        tienThuocDuocBHYT +=
                            thanhTien;
                    }
                }

                // Kiểm tra thẻ BHYT còn hạn.
                bool bhytConHan =
                    !string.IsNullOrWhiteSpace(
                        donThuoc.BenhNhan.MaBHYT) &&
                    donThuoc.BenhNhan.NgayHetHanBHYT.HasValue &&
                    donThuoc.BenhNhan
                        .NgayHetHanBHYT
                        .Value.Date >= DateTime.Today;

                int mucHuongBHYT =
                    bhytConHan
                        ? donThuoc.BenhNhan.MucHuongBHYT
                        : 0;

                decimal tienBHYTThanhToan =
                    decimal.Round(
                        tienThuocDuocBHYT *
                        mucHuongBHYT /
                        100m,
                        2,
                        MidpointRounding.AwayFromZero);

                decimal tienBenhNhanTra =
                    tongTienThuoc -
                    tienBHYTThanhToan;

                // Hiển thị tóm tắt thanh toán.
                lblTongTienThuoc.Text =
                    DinhDangTien(tongTienThuoc);

                lblMucBHYT.Text =
                    mucHuongBHYT + "%";

                lblBHYTtt.Text =
                    DinhDangTien(
                        tienBHYTThanhToan);

                lblTienBNTra.Text =
                    DinhDangTien(
                        tienBenhNhanTra);

                // Dữ liệu dành cho khu vực QR.
                lblSoTien.Text =
                    DinhDangTien(
                        tienBenhNhanTra);

                lblNoiDung.Text =
                    "THANH TOAN DON " +
                    donThuoc.MaDonThuoc;

                lblTrangThai.Text =
                    "Chưa tạo QR";
            }
            catch (Exception ex)
            {
                string noiDungLoi =
                    ex.InnerException?.Message ??
                    ex.Message;

                MessageBox.Show(
                    "Không thể tải thông tin thanh toán!\n" +
                    noiDungLoi,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                btnXacNhan.Enabled = false;
            }
        }

        private static string DinhDangTien(
            decimal soTien)
        {
            return soTien.ToString(
                "N0",
                CultureInfo.GetCultureInfo("vi-VN")) +
                " đ";
        }

        private void BatDauThanhToanQR()
        {
            if (!duLieuHopLe ||
                dangXuLy ||
                qrDangHoatDong)
            {
                return;
            }

            if (tienBenhNhanTraDaHienThi <= 0)
            {
                lblTrangThai.Text =
                    "Số tiền thanh toán không hợp lệ.";

                return;
            }

            string maNgauNhien =
                Guid.NewGuid()
                    .ToString("N")
                    .Substring(0, 6)
                    .ToUpperInvariant();

            // Nội dung chỉ gồm chữ và số để ngân hàng
            // giữ nguyên khi chuyển khoản.
            noiDungChuyenKhoanQR =
                "DT" +
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

        private void TaoAnhQR()
        {
            string soTien =
                tienBenhNhanTraDaHienThi.ToString(
                    "0.##",
                    CultureInfo.InvariantCulture);

            string duongDanQR =
                "https://api.vietqr.io/image/" +
                "970416-7020801-7oKN5WV.jpg" +
                "?accountName=" +
                Uri.EscapeDataString(
                    "TRAN VAN TRUC") +
                "&amount=" +
                Uri.EscapeDataString(
                    soTien) +
                "&addInfo=" +
                Uri.EscapeDataString(
                    noiDungChuyenKhoanQR);

            imgQR.LoadAsync(
                duongDanQR);
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

            System.Drawing.Image? anhCu =
                imgQR.Image;

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
                    cancellationToken
                        .IsCancellationRequested ||
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
                        noiDungDaThanhToan,
                        giaoDich.TransactionID);

                    // Không hiện MessageBox vì QR cần
                    // tự xác nhận và tự đóng.
                    DialogResult =
                        DialogResult.OK;

                    Close();
                }
                catch (Exception ex)
                {
                    dangXuLy = false;
                    Cursor = Cursors.Default;

                    if (!IsDisposed)
                    {
                        lblTrangThai.Text =
                            "Đã nhận tiền nhưng không thể lưu.";

                        CapNhatPhuongThucThanhToan();

                        MessageBox.Show(
                            "Đã tìm thấy giao dịch nhưng " +
                            "không thể hoàn tất xuất thuốc!\n" +
                            LayNoiDungLoi(ex),
                            "Lỗi",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
            }
            catch (OperationCanceledException)
            {
                // Người dùng đổi sang tiền mặt hoặc đóng Form.
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
            string duongDanApi =
                "https://api.sieuthicode.net/" +
                "historyapiacbv3/" +
                Uri.EscapeDataString(
                    MatKhauApi) +
                "/" +
                Uri.EscapeDataString(
                    SoTaiKhoanApi) +
                "/" +
                Uri.EscapeDataString(
                    TokenApi);

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

        private void DuocSi_ThanhToan_Load(object sender, EventArgs e)
        {
            TaiThongTinDonThuoc();
            if (rdoTienMat.Checked)
            {
                grbQRCode.Visible = false;
            }
            else
            {
                grbQRCode.Visible = true;
            }
        }

        private void rdoTienMat_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoTienMat.Checked)
            {
                grbQRCode.Visible = false;
            }
            else
            {
                grbQRCode.Visible = true;
            }
        }

        private void rdoQuetMa_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoTienMat.Checked)
            {
                grbQRCode.Visible = false;
            }
            else
            {
                grbQRCode.Visible = true;
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
