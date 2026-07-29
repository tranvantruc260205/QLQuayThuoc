using Microsoft.AspNetCore.Identity;
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
    public partial class Admin_ResetPassword : Form
    {
        private int userId;
        public Admin_ResetPassword()
        {
            InitializeComponent();

            AcceptButton = btnXacNhan;
        }

        public Admin_ResetPassword(int userId) : this()
        {
            this.userId = userId;

            LoadUser();
        }

        private void LoadUser()
        {
            using (AppDbContext db = new AppDbContext())
            {
                User user = db.Users.FirstOrDefault(x =>
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

                lblUserId.Text = user.UserId.ToString();
                lblFullName.Text = user.FullName;
            }
        }

        private void chkShow_CheckedChanged(object sender, EventArgs e)
        {
            txtNewPassword.UseSystemPasswordChar = !chkShow.Checked;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            string matKhauMoi = txtNewPassword.Text;

            if (string.IsNullOrWhiteSpace(matKhauMoi))
            {
                MessageBox.Show(
                    "Vui lòng nhập mật khẩu mới!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtNewPassword.Focus();
                return;
            }

            using (AppDbContext db = new AppDbContext())
            {
                User user = db.Users.FirstOrDefault(x =>
                    x.UserId == userId);

                if (user == null)
                {
                    MessageBox.Show(
                        "Không tìm thấy tài khoản!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                DialogResult result = MessageBox.Show(
                    $"Bạn có chắc muốn đặt lại mật khẩu cho tài khoản \"{user.FullName}\" không?",
                    "Xác nhận",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result != DialogResult.Yes)
                {
                    return;
                }

                PasswordHasher<User> passwordHasher =
                    new PasswordHasher<User>();

                user.PasswordHash = passwordHasher.HashPassword(
                    user,
                    matKhauMoi);

                db.SaveChanges();
            }

            MessageBox.Show(
                "Đặt lại mật khẩu thành công!",
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
