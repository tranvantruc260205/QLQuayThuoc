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

namespace QLQuayThuoc.UserControls.UCAdmin
{
    public partial class UCQuanLiThanhToanQRCode : UserControl
    {

        private bool dangHoatDong;
        public UCQuanLiThanhToanQRCode()
        {
            InitializeComponent();
        }

        private void TaiCauHinhThanhToan()
        {
            try
            {
                using AppDbContext db = new AppDbContext();

                var cauHinh =
                    db.CauHinhThanhToans
                        .SingleOrDefault(x => x.MaCauHinh == 1);

                if (cauHinh == null)
                {
                    lblTrangThai.Text = "Chưa có cấu hình";
                    lblTrangThai.ForeColor = Color.Red;

                    btnBatTat.Enabled = false;
                    btnLuu.Enabled = false;

                    MessageBox.Show(
                        "Không tìm thấy cấu hình thanh toán có mã 1.",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                txtUrlApi.Text =
                    cauHinh.DuongDanApiGiaoDich;

                txtTokenApi.Text =
                    cauHinh.TokenApi;

                txtSTK.Text =
                    cauHinh.SoTaiKhoan;

                txtPassword.Text =
                    cauHinh.MatKhauApi;

                txtChuTK.Text =
                    cauHinh.TenChuTaiKhoan;

                txtTienTo.Text =
                    cauHinh.TienToNoiDungChuyenKhoan;

                txtUrlTaoQR.Text =
                    cauHinh.DuongDanTaoQR;

                txtMaNganHang.Text =
                    cauHinh.MaNganHang;

                txtTemplateID.Text =
                    cauHinh.MaDinhDanhQR;

                dangHoatDong =
                    cauHinh.DangHoatDong;

                btnBatTat.Enabled = true;
                btnLuu.Enabled = true;

                CapNhatHienThiTrangThai();
            }
            catch (Exception ex)
            {
                dangHoatDong = false;

                lblTrangThai.Text = "Không tải được";
                lblTrangThai.ForeColor = Color.Red;

                btnBatTat.Enabled = false;
                btnLuu.Enabled = false;

                MessageBox.Show(
                    "Không thể tải cấu hình thanh toán.\n" +
                    (ex.InnerException?.Message ?? ex.Message),
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        private void CapNhatHienThiTrangThai()
        {
            if (dangHoatDong)
            {
                lblTrangThai.Text = "Đang hoạt động";
                lblTrangThai.ForeColor = Color.Green;

                btnBatTat.Text =
                    "Tạm ngừng thanh toán QRCode";
            }
            else
            {
                lblTrangThai.Text = "Tạm ngừng";
                lblTrangThai.ForeColor = Color.Red;

                btnBatTat.Text =
                    "Bật thanh toán QRCode";
            }
        }

        private void UCQuanLiThanhToanQRCode_Load(object sender, EventArgs e)
        {
            TaiCauHinhThanhToan();
        }

        private void btnBatTat_Click(object sender, EventArgs e)
        {
            string hanhDong =
        dangHoatDong ? "tạm ngừng" : "bật";

            DialogResult ketQua = MessageBox.Show(
                "Bạn có chắc muốn " +
                hanhDong +
                " thanh toán QRCode không?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (ketQua != DialogResult.Yes)
            {
                return;
            }

            try
            {
                using AppDbContext db = new AppDbContext();

                var cauHinh =
                    db.CauHinhThanhToans
                        .SingleOrDefault(x => x.MaCauHinh == 1);

                if (cauHinh == null)
                {
                    MessageBox.Show(
                        "Không tìm thấy cấu hình thanh toán.",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                cauHinh.DangHoatDong =
                    !cauHinh.DangHoatDong;

                db.SaveChanges();

                dangHoatDong =
                    cauHinh.DangHoatDong;

                CapNhatHienThiTrangThai();

                MessageBox.Show(
                    dangHoatDong
                        ? "Đã bật thanh toán QRCode."
                        : "Đã tạm ngừng thanh toán QRCode.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Không thể thay đổi trạng thái.\n" +
                    (ex.InnerException?.Message ?? ex.Message),
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private bool DuLieuHopLe()
        {
            if (string.IsNullOrWhiteSpace(txtUrlApi.Text) ||
                string.IsNullOrWhiteSpace(txtTokenApi.Text) ||
                string.IsNullOrWhiteSpace(txtSTK.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text) ||
                string.IsNullOrWhiteSpace(txtChuTK.Text) ||
                string.IsNullOrWhiteSpace(txtTienTo.Text) ||
                string.IsNullOrWhiteSpace(txtUrlTaoQR.Text) ||
                string.IsNullOrWhiteSpace(txtMaNganHang.Text) ||
                string.IsNullOrWhiteSpace(txtTemplateID.Text))
            {
                MessageBox.Show(
                    "Vui lòng nhập đầy đủ thông tin cấu hình.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return false;
            }

            if (!Uri.TryCreate(
                    txtUrlApi.Text.Trim(),
                    UriKind.Absolute,
                    out _))
            {
                MessageBox.Show(
                    "URL API giao dịch không hợp lệ.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtUrlApi.Focus();
                return false;
            }

            if (!Uri.TryCreate(
                    txtUrlTaoQR.Text.Trim(),
                    UriKind.Absolute,
                    out _))
            {
                MessageBox.Show(
                    "URL tạo QR không hợp lệ.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtUrlTaoQR.Focus();
                return false;
            }

            string maNganHang =
                txtMaNganHang.Text.Trim();

            if (maNganHang.Length != 6 ||
                !maNganHang.All(char.IsDigit))
            {
                MessageBox.Show(
                    "Mã ngân hàng phải gồm đúng 6 chữ số.\n" +
                    "Ví dụ ACB: 970416.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtMaNganHang.Focus();
                return false;
            }

            return true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (!DuLieuHopLe())
            {
                return;
            }

            try
            {
                using AppDbContext db = new AppDbContext();

                var cauHinh =
                    db.CauHinhThanhToans
                        .SingleOrDefault(x => x.MaCauHinh == 1);

                if (cauHinh == null)
                {
                    MessageBox.Show(
                        "Không tìm thấy cấu hình thanh toán.",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                cauHinh.DuongDanApiGiaoDich =
                    txtUrlApi.Text.Trim();

                cauHinh.TokenApi =
                    txtTokenApi.Text.Trim();

                cauHinh.SoTaiKhoan =
                    txtSTK.Text.Trim();

                cauHinh.MatKhauApi =
                    txtPassword.Text.Trim();

                cauHinh.TenChuTaiKhoan =
                    txtChuTK.Text.Trim();

                cauHinh.TienToNoiDungChuyenKhoan =
                    txtTienTo.Text.Trim();

                cauHinh.DuongDanTaoQR =
                    txtUrlTaoQR.Text.Trim();

                cauHinh.MaNganHang =
                    txtMaNganHang.Text.Trim();

                cauHinh.MaDinhDanhQR =
                    txtTemplateID.Text.Trim();

                db.SaveChanges();

                MessageBox.Show(
                    "Lưu cấu hình thanh toán thành công.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                TaiCauHinhThanhToan();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Không thể lưu cấu hình thanh toán.\n" +
                    (ex.InnerException?.Message ?? ex.Message),
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
