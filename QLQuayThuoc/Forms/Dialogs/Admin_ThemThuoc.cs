using QLQuayThuoc.Data;
using QLQuayThuoc.Models;
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
    public partial class Admin_ThemThuoc : Form
    {
        public Admin_ThemThuoc()
        {
            InitializeComponent();

            nudDonGia.Minimum = 0;
            nudDonGia.Maximum = 1000000000;
            nudDonGia.DecimalPlaces = 0;
            nudDonGia.ThousandsSeparator = true;

            // Thuốc mới mặc định đang được sử dụng
            rdoDangKD.Checked = true;

            AcceptButton = btnXacNhan;
            CancelButton = btnHuy;

            cbDonViTinh.DropDownStyle = ComboBoxStyle.DropDownList;

            cbDonViTinh.Items.AddRange(new object[]
            {
                "Viên",
                "Vỉ",
                "Hộp",
                "Chai",
                "Lọ",
                "Ống",
                "Gói",
                "Tuýp"
            });

            cbBHYT.DropDownStyle = ComboBoxStyle.DropDownList;

            cbDonViTinh.SelectedIndex = -1;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            string tenThuoc = txtTenThuoc.Text.Trim();
            string donViTinh = cbDonViTinh.Text;
            string hoatChat = txtHoatChat.Text.Trim();
            string hamLuong = txtHamLuong.Text.Trim();
            decimal donGiaBan = nudDonGia.Value;

            if (tenThuoc == "" ||
                donViTinh == "" ||
                hoatChat == "" ||
                hamLuong == "")
            {
                MessageBox.Show(
                    "Vui lòng nhập đầy đủ thông tin thuốc!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (donGiaBan <= 0)
            {
                MessageBox.Show(
                    "Đơn giá bán phải lớn hơn 0!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                nudDonGia.Focus();
                return;
            }

            if (cbBHYT.Text != "Có" && cbBHYT.Text != "Không")
            {
                MessageBox.Show(
                    "Vui lòng chọn thuốc có được BHYT chi trả hay không!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                cbBHYT.Focus();
                return;
            }

            if (!rdoDangKD.Checked && !rdoTamNgung.Checked)
            {
                MessageBox.Show(
                    "Vui lòng chọn trạng thái thuốc!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            bool duocBHYTChiTra = cbBHYT.Text == "Có";

            string trangThai = rdoDangKD.Checked
                ? "DANG_KINH_DOANH"
                : "TAM_NGUNG";

            using (AppDbContext db = new AppDbContext())
            {
                bool thuocDaTonTai = db.Thuocs.Any(x =>
                    x.TenThuoc == tenThuoc &&
                    x.DonViTinh == donViTinh &&
                    x.HoatChat == hoatChat &&
                    x.HamLuong == hamLuong);

                if (thuocDaTonTai)
                {
                    MessageBox.Show(
                        "Thuốc này đã tồn tại trong danh mục!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                Thuoc thuoc = new Thuoc
                {
                    TenThuoc = tenThuoc,
                    DonViTinh = donViTinh,
                    HoatChat = hoatChat,
                    HamLuong = hamLuong,
                    DonGiaBan = donGiaBan,
                    DuocBHYTChiTra = duocBHYTChiTra,
                    TrangThai = trangThai
                };

                db.Thuocs.Add(thuoc);
                db.SaveChanges();
            }

            MessageBox.Show(
                "Thêm thuốc thành công!",
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
