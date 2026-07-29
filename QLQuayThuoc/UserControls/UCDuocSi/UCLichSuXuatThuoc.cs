using Microsoft.EntityFrameworkCore;
using QLQuayThuoc.Data;
using QLQuayThuoc.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLQuayThuoc.UserControls.UCDuocSi
{
    public partial class UCLichSuXuatThuoc : UserControl
    {
        private const int MucTonSapHet = 20;
        private const int SoNgaySapHetHan = 60;
        public UCLichSuXuatThuoc()
        {
            InitializeComponent();


            CauHinhBangCongViecGanDay();
        }

        private void CauHinhBangCongViecGanDay()
        {
            dgv.AutoGenerateColumns =
                false;

            dgv.AllowUserToAddRows =
                false;

            dgv.ReadOnly = true;
            dgv.MultiSelect = false;

            dgv.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgv.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            Column1.FillWeight = 15;
            Column2.FillWeight = 28;
            Column3.FillWeight = 21;
            Column4.FillWeight = 18;
            Column5.FillWeight = 21;

            Column5.HeaderText = "Ngày xuất";
        }

        private void LoadManHinhChinh()
        {
            lblThuocSapHet.Text = "0";
            lblThuocSapHetHan.Text = "0";
            lblPhieuChoDuyet.Text = "0";

            dgv.Rows.Clear();

            try
            {
                using (AppDbContext db =
                    new AppDbContext())
                {
                    int maKhoQuay = db.Khos
                        .AsNoTracking()
                        .Where(x =>
                            x.LoaiKho == "KHO_QUAY")
                        .Select(x => x.MaKho)
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




                    DateTime homNay = DateTime.Today;

                    // Bao gồm trọn ngày thứ 60.
                    DateTime sauThoiHanCanhBao =
                        homNay.AddDays(
                            SoNgaySapHetHan + 1);

                    // Đếm số thuốc có ít nhất một lô
                    // tại kho quầy tồn <= 20.
                    int soThuocSapHet =
                        db.TonKhos
                            .AsNoTracking()
                            .Where(x =>
                                x.MaKho == maKhoQuay &&
                                x.SoLuongTon <= MucTonSapHet)
                            .Select(x =>
                                x.LoThuoc.MaThuoc)
                            .Distinct()
                            .Count();

                    // Đếm số thuốc có lô hết hạn
                    // từ hôm nay đến hết 60 ngày tới.
                    int soThuocSapHetHan =
                        db.TonKhos
                            .AsNoTracking()
                            .Where(x =>
                                x.MaKho == maKhoQuay &&
                                x.LoThuoc.NgayHetHan >= homNay &&
                                x.LoThuoc.NgayHetHan <
                                    sauThoiHanCanhBao)
                            .Select(x =>
                                x.LoThuoc.MaThuoc)
                            .Distinct()
                            .Count();

                    // Đếm toàn bộ phiếu của kho quầy
                    // đang chờ kho tổng duyệt.
                    int soPhieuChoDuyet =
                        db.PhieuXinCapThuocs
                            .AsNoTracking()
                            .Count(x =>
                                x.KhoNhanId == maKhoQuay &&
                                x.TrangThai == "CHO_DUYET");

                    lblThuocSapHet.Text =
                        soThuocSapHet.ToString();

                    lblThuocSapHetHan.Text =
                        soThuocSapHetHan.ToString();

                    lblPhieuChoDuyet.Text =
                        soPhieuChoDuyet.ToString();


                    // Lấy 10 đơn dược sĩ hiện tại
                    // đã xuất gần nhất.
                    var congViecGanDay =
                        db.PhieuXuatThuocs
                            .AsNoTracking()
                            .Where(x =>
                                x.DuocSiId ==
                                    UserSession.UserId)
                            .OrderByDescending(x =>
                                x.NgayXuat)
                            .Select(x => new
                            {
                                x.MaDonThuoc,

                                HoTenBenhNhan =
                                    x.DonThuoc
                                        .BenhNhan
                                        .HoTen,

                                x.DonThuoc.NgayKeDon,
                                x.NgayXuat
                            })
                            .ToList();

                    foreach (var congViec
                        in congViecGanDay)
                    {
                        dgv.Rows.Add(
                            congViec.MaDonThuoc,

                            congViec.HoTenBenhNhan,

                            congViec.NgayKeDon.ToString(
                                "dd/MM/yyyy HH:mm"),

                            "Đã xuất thuốc",

                            congViec.NgayXuat.ToString(
                                "dd/MM/yyyy HH:mm"));
                    }

                    dgv.ClearSelection();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Không thể tải dữ liệu màn hình chính!\n" +
                    ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void UCLichSuXuatThuoc_Load(object sender, EventArgs e)
        {
            if (UserSession.UserId <= 0)
            {
                MessageBox.Show(
                    "Không xác định được dược sĩ đang đăng nhập!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                this.ParentForm.Close();
                return;
            }

            LoadManHinhChinh();
        }
    }
}
