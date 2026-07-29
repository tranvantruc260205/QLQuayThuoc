using QLQuayThuoc.UserControls.UCKeToan;
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
    public partial class KeToan_XemThongTinDonThuoc : Form
    {
        private readonly string _thoiGian;

        private readonly List<UCBaoCaoDoanhThu.ThongTinHoaDonViewModel>_danhSach;

        public KeToan_XemThongTinDonThuoc(string thoiGian,List<UCBaoCaoDoanhThu.ThongTinHoaDonViewModel> danhSach)
        {
            InitializeComponent();

            _thoiGian = thoiGian;
            _danhSach = danhSach;

            Load += KeToan_XemThongTinDonThuoc_Load;
            btnDong.Click += btnDong_Click;

            CancelButton = btnDong;
        }

        private void KeToan_XemThongTinDonThuoc_Load(object sender, EventArgs e)
        {
            Text = $"Thông tin hóa đơn {_thoiGian}";

            lblTieuDe.Text =
                $"DANH SÁCH HÓA ĐƠN - {_thoiGian}";

            CauHinhBang();

            dgvHoaDon.DataSource = null;
            dgvHoaDon.DataSource = _danhSach;

            dgvHoaDon.ClearSelection();
        }
        private void CauHinhBang()
        {
            dgvHoaDon.AutoGenerateColumns = false;
            dgvHoaDon.AllowUserToAddRows = false;
            dgvHoaDon.AllowUserToDeleteRows = false;
            dgvHoaDon.ReadOnly = true;
            dgvHoaDon.MultiSelect = false;
            dgvHoaDon.RowHeadersVisible = false;

            dgvHoaDon.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvHoaDon.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            colMaHD.DataPropertyName =
                nameof(UCBaoCaoDoanhThu.ThongTinHoaDonViewModel.MaHD);

            colBenhNhan.DataPropertyName =
                nameof(UCBaoCaoDoanhThu.ThongTinHoaDonViewModel.BenhNhan);

            colDuocSi.DataPropertyName =
                nameof(UCBaoCaoDoanhThu.ThongTinHoaDonViewModel.DuocSi);

            colThoiGianThanhToan.DataPropertyName =
                nameof(UCBaoCaoDoanhThu.ThongTinHoaDonViewModel.ThoiGianThanhToan);

            colPhuongThuc.DataPropertyName =
                nameof(UCBaoCaoDoanhThu.ThongTinHoaDonViewModel.PhuongThuc);

            colTongTienThuoc.DataPropertyName =
                nameof(UCBaoCaoDoanhThu.ThongTinHoaDonViewModel.TongTienThuoc);

            colTienBHYT.DataPropertyName =
                nameof(UCBaoCaoDoanhThu.ThongTinHoaDonViewModel.TienBHYT);

            colTienBenhNhanTra.DataPropertyName =
                nameof(UCBaoCaoDoanhThu.ThongTinHoaDonViewModel.TienBenhNhanTra);

            colThoiGianThanhToan.DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";

            colTongTienThuoc.DefaultCellStyle.Format = "N0";
            colTienBHYT.DefaultCellStyle.Format = "N0";
            colTienBenhNhanTra.DefaultCellStyle.Format = "N0";

            colTongTienThuoc.DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleRight;

            colTienBHYT.DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleRight;

            colTienBenhNhanTra.DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleRight;
        }

        private void btnDong_Click(
            object? sender,
            EventArgs e)
        {
            Close();
        }
    }
}
