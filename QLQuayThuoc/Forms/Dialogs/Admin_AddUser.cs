using Microsoft.AspNetCore.Identity;
using QLQuayThuoc.Data;
using QLQuayThuoc.Models;


namespace QLQuayThuoc.Forms.Dialogs
{
    public partial class Admin_AddUser : Form
    {
        public Admin_AddUser()
        {
            InitializeComponent();

            AcceptButton = btnXacNhan;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            string hoTen = txtHoTen.Text.Trim();
            string soDienThoai = txtSdt.Text.Trim();
            string email = txtEmail.Text.Trim();
            string matKhau = txtMk.Text;

            if (hoTen == "" ||
                soDienThoai == "" ||
                email == "" ||
                matKhau == "")
            {
                MessageBox.Show(
                    "Vui lòng nhập đầy đủ thông tin!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (cbRole.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Vui lòng chọn vai trò!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            string role = "";

            if (cbRole.Text == "Bác sĩ")
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
                MessageBox.Show("Vai trò không hợp lệ!");
                return;
            }

            using (AppDbContext db = new AppDbContext())
            {
                bool trungEmail = db.Users.Any(x =>
                    x.Email == email);

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
                    x.PhoneNumber == soDienThoai);

                if (trungSoDienThoai)
                {
                    MessageBox.Show(
                        "Số điện thoại này đã được sử dụng!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                User user = new User
                {
                    FullName = hoTen,
                    PhoneNumber = soDienThoai,
                    Email = email,
                    Role = role,
                    IsActive = rdoHoatDong.Checked
                };

                PasswordHasher<User> hasher =
                    new PasswordHasher<User>();

                user.PasswordHash =
                    hasher.HashPassword(user, matKhau);

                db.Users.Add(user);
                db.SaveChanges();
            }

            MessageBox.Show(
                "Thêm người dùng thành công!",
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
