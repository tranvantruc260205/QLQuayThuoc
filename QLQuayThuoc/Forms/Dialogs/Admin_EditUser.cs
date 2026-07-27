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

namespace QLQuayThuoc.Forms.Dialogs
{
    public partial class Admin_EditUser : Form
    {
        private int userId;
        public Admin_EditUser()
        {
            InitializeComponent();

            AcceptButton = btnXacNhan;

            LoadVaiTro();
        }

        public Admin_EditUser(int userId) : this()
        {
            this.userId = userId;

            LoadUser();
        }

        private void LoadVaiTro()
        {
            cbRole.Items.Clear();

            cbRole.Items.Add("Admin");
            cbRole.Items.Add("Bác sĩ");
            cbRole.Items.Add("Dược sĩ");
            cbRole.Items.Add("Kế toán");
            cbRole.Items.Add("Kho tổng");

            cbRole.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void LoadUser()
        {
            using (AppDbContext db = new AppDbContext())
            {
                var user = db.Users.FirstOrDefault(x =>
                    x.UserId == userId);

                if (user == null)
                {
                    MessageBox.Show(
                        "Không tìm thấy tài khoản!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    DialogResult = DialogResult.Cancel;
                    Close();
                    return;
                }

                txtHoTen.Text = user.FullName;
                txtSdt.Text = user.PhoneNumber;
                txtEmail.Text = user.Email;

                if (user.Role == "ADMIN")
                {
                    cbRole.Text = "Admin";
                }
                else if (user.Role == "BAC_SI")
                {
                    cbRole.Text = "Bác sĩ";
                }
                else if (user.Role == "DUOC_SI")
                {
                    cbRole.Text = "Dược sĩ";
                }
                else if (user.Role == "KE_TOAN")
                {
                    cbRole.Text = "Kế toán";
                }
                else if (user.Role == "KHO_TONG")
                {
                    cbRole.Text = "Kho tổng";
                }

                rdoHoatDong.Checked = user.IsActive;
                rdoKhoa.Checked = !user.IsActive;
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            string fullName = txtHoTen.Text.Trim();
            string phoneNumber = txtSdt.Text.Trim();
            string email = txtEmail.Text.Trim();

            if (fullName == "" || phoneNumber == "" || email == "")
            {
                MessageBox.Show(
                    "Vui lòng nhập đầy đủ thông tin!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            string role = "";

            if (cbRole.Text == "Admin")
            {
                role = "ADMIN";
            }
            else if (cbRole.Text == "Bác sĩ")
            {
                role = "BAC_SI";
            }
            else if (cbRole.Text == "Dược sĩ")
            {
                role = "DUOC_SI";
            }
            else if (cbRole.Text == "Kế toán")
            {
                role = "KE_TOAN";
            }
            else if (cbRole.Text == "Kho tổng")
            {
                role = "KHO_TONG";
            }

            if (role == "")
            {
                MessageBox.Show(
                    "Vui lòng chọn vai trò!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (!rdoHoatDong.Checked && !rdoKhoa.Checked)
            {
                MessageBox.Show(
                    "Vui lòng chọn trạng thái!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            using (AppDbContext db = new AppDbContext())
            {
                var user = db.Users.FirstOrDefault(x =>
                    x.UserId == userId);

                if (user == null)
                {
                    MessageBox.Show("Không tìm thấy tài khoản!");
                    return;
                }

                bool trungEmail = db.Users.Any(x =>
                    x.Email == email &&
                    x.UserId != userId);

                if (trungEmail)
                {
                    MessageBox.Show(
                        "Email này đã được sử dụng!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                bool trungSoDienThoai = db.Users.Any(x =>
                    x.PhoneNumber == phoneNumber &&
                    x.UserId != userId);

                if (trungSoDienThoai)
                {
                    MessageBox.Show(
                        "Số điện thoại này đã được sử dụng!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                // Không cho tự khóa tài khoản đang đăng nhập
                if (user.UserId == UserSession.UserId &&
                    rdoKhoa.Checked)
                {
                    MessageBox.Show(
                        "Bạn không thể khóa tài khoản đang đăng nhập!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                user.FullName = fullName;
                user.PhoneNumber = phoneNumber;
                user.Email = email;
                user.Role = role;
                user.IsActive = rdoHoatDong.Checked;

                db.SaveChanges();
            }

            MessageBox.Show(
                "Sửa thông tin người dùng thành công!",
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
