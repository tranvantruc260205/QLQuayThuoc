using Microsoft.EntityFrameworkCore;
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

namespace QLQuayThuoc.Forms.Dialogs
{
    public partial class Admin_SuaThuoc : Form
    {
        private readonly int maThuoc;
        public Admin_SuaThuoc(int maThuoc)
        {
            InitializeComponent();

            this.maThuoc = maThuoc;

            cbDonViTinh.DropDownStyle =
                ComboBoxStyle.DropDownList;

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

            nudDonGia.Minimum = 0;
            nudDonGia.Maximum = 1000000000;
            nudDonGia.DecimalPlaces = 0;
            nudDonGia.ThousandsSeparator = true;

            AcceptButton = btnXacNhan;
            CancelButton = btnHuy;
        }

        private void LoadThongTinThuoc()
        {
            using (AppDbContext db = new AppDbContext())
            {
                var thuoc = db.Thuocs
                    .AsNoTracking()
                    .FirstOrDefault(x =>
                        x.MaThuoc == maThuoc);

                if (thuoc == null)
                {
                    MessageBox.Show(
                        "Không tìm thấy thuốc!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    DialogResult = DialogResult.Cancel;
                    Close();
                    return;
                }

                txtTenThuoc.Text = thuoc.TenThuoc;
                txtHoatChat.Text = thuoc.HoatChat;
                txtHamLuong.Text = thuoc.HamLuong;
                nudDonGia.Value = thuoc.DonGiaBan;

                // Nếu đơn vị trong database chưa có trong ComboBox
                if (!cbDonViTinh.Items.Contains(thuoc.DonViTinh))
                {
                    cbDonViTinh.Items.Add(thuoc.DonViTinh);
                }

                cbDonViTinh.SelectedItem = thuoc.DonViTinh;

                cbBHYT.SelectedItem = thuoc.DuocBHYTChiTra ? "Có" : "Không";
            }
        }

        private void SuaThuoc_Load(object sender, EventArgs e)
        {
            LoadThongTinThuoc();
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

            if (cbBHYT.Text != "Có" &&
                cbBHYT.Text != "Không")
            {
                MessageBox.Show(
                    "Vui lòng chọn thuốc có được BHYT chi trả hay không!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                cbBHYT.Focus();
                return;
            }

            bool duocBHYTChiTra = cbBHYT.Text == "Có";

            using (AppDbContext db = new AppDbContext())
            {
                var thuoc = db.Thuocs.FirstOrDefault(x =>
                    x.MaThuoc == maThuoc);

                if (thuoc == null)
                {
                    MessageBox.Show(
                        "Không tìm thấy thuốc!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                bool thuocDaTonTai = db.Thuocs.Any(x =>
                    x.MaThuoc != maThuoc &&
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

                thuoc.TenThuoc = tenThuoc;
                thuoc.DonViTinh = donViTinh;
                thuoc.HoatChat = hoatChat;
                thuoc.HamLuong = hamLuong;
                thuoc.DonGiaBan = donGiaBan;
                thuoc.DuocBHYTChiTra = duocBHYTChiTra;

                // Không gán thuoc.TrangThai
                // nên trạng thái hiện tại được giữ nguyên.

                db.SaveChanges();
            }

            MessageBox.Show(
                "Cập nhật thuốc thành công!",
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
