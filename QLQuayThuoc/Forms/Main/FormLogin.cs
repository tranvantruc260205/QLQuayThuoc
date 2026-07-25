using Microsoft.AspNetCore.Identity;
using QLQuayThuoc.Data;
using QLQuayThuoc.Forms.Main;
using QLQuayThuoc.Models;
using QLQuayThuoc.Utils;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QLQuayThuoc
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();

            AcceptButton = btnLogin;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string taiKhoan = txtLoginInfo.Text;
            string matKhau = txtPassword.Text;

            if (taiKhoan.Equals("") || matKhau.Equals(""))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin đăng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            User? user;

            using (AppDbContext db = new AppDbContext())
            {
                user = db.Users.FirstOrDefault(x =>
                    x.Email == taiKhoan ||
                    x.PhoneNumber == taiKhoan);
            }

            if (user == null)
            {
                MessageBox.Show("Tài khoản không tồn tại.");
                return;
            }

            if (!user.IsActive)
            {
                MessageBox.Show("Tài khoản đã bị khóa.");
                return;
            }

            PasswordHasher<User> hasher = new PasswordHasher<User>();

            PasswordVerificationResult ketQua =
                hasher.VerifyHashedPassword(
                    user,
                    user.PasswordHash,
                    matKhau);

            if (ketQua == PasswordVerificationResult.Failed)
            {
                MessageBox.Show("Mật khẩu không chính xác.");
                return;
            }

            UserSession.SetUser(user.UserId, user.FullName, user.Role);

            Form? formCanMo = null;

            if (user.Role == "ADMIN")
            {
                formCanMo = new FormAdmin();
            }
            else if (user.Role == "BAC_SI")
            {
                formCanMo = new FormBacSi();
            }
            else if (user.Role == "DUOC_SI")
            {
                formCanMo = new FormDuocSi();
            }
            else if (user.Role == "KHO_TONG")
            {
                formCanMo = new FormKhoTong();
            }
            else if (user.Role == "KE_TOAN")
            {
                formCanMo = new FormKeToan();
            }

            this.Hide();

            formCanMo.FormClosed += (s, args) =>
            {
                txtPassword.Clear();
                this.Show();
                this.Activate();
            };

            formCanMo.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !chkShowPassword.Checked;
        }

    }
}