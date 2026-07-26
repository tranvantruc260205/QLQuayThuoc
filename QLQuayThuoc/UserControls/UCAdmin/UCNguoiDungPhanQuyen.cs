using Microsoft.EntityFrameworkCore;
using QLQuayThuoc.Data;
using QLQuayThuoc.Forms.Dialogs;
using QLQuayThuoc.Models;
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

namespace QLQuayThuoc
{
    public partial class UCNguoiDungPhanQuyen : UserControl
    {
        public UCNguoiDungPhanQuyen()
        {
            InitializeComponent();

            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.MultiSelect = false;

            cbRole.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTrangThai.DropDownStyle = ComboBoxStyle.DropDownList;

            cbRole.SelectedIndex = 0;
            cbTrangThai.SelectedIndex = 0;
        }

        public void LoadUser()
        {
            using (AppDbContext db = new AppDbContext())
            {
                dgv.DataSource = db.Users
                    .Select(x => new
                    {
                        x.UserId,
                        x.FullName,
                        x.PhoneNumber,
                        x.Email,
                        x.Role,
                        TrangThai = x.IsActive ? "Hoạt động" : "Khóa"
                    })
                    .ToList();
            }
        }


        private void UCNguoiDungPhanQuyen_Load(object sender, EventArgs e)
        {
            LoadUser();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            using (AddUser dialog = new AddUser())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    LoadUser();
                }
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtTimKiem.Clear();
            cbRole.SelectedIndex = 0;
            cbTrangThai.SelectedIndex = 0;
            LoadUser();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string tuKhoa = txtTimKiem.Text.Trim();
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
            else if (cbRole.Text == "Admin")
            {
                role = "ADMIN";
            }

            bool? trangThai = null;

            if (cbTrangThai.Text == "Hoạt động")
            {
                trangThai = true;
            }
            else if (cbTrangThai.Text == "Khóa")
            {
                trangThai = false;
            }

            using (AppDbContext db = new AppDbContext())
            {
                var query = db.Users
                    .AsNoTracking()
                    .AsQueryable();

                if (tuKhoa != "")
                {
                    query = query.Where(x =>
                        x.FullName.Contains(tuKhoa) ||
                        x.PhoneNumber.Contains(tuKhoa) ||
                        x.Email.Contains(tuKhoa));
                }

                if (role != "")
                {
                    query = query.Where(x => x.Role == role);
                }

                if (trangThai.HasValue)
                {
                    query = query.Where(x =>
                        x.IsActive == trangThai.Value);
                }

                dgv.DataSource = query
                    .Select(x => new
                    {
                        x.UserId,
                        x.FullName,
                        x.PhoneNumber,
                        x.Email,
                        x.Role,
                        TrangThai = x.IsActive
                            ? "Hoạt động"
                            : "Khóa"
                    })
                    .ToList();
            }
        }

        private void btnKhoaMo_Click(object sender, EventArgs e)
        {
            if (dgv.CurrentRow == null)
            {
                MessageBox.Show(
                    "Vui lòng chọn tài khoản cần khóa hoặc mở khóa!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            // Giả sử cột UserId nằm ở vị trí đầu tiên
            int userId = Convert.ToInt32(
                dgv.CurrentRow.Cells[0].Value);

            using (AppDbContext db = new AppDbContext())
            {
                User user = db.Users.FirstOrDefault(x =>
                    x.UserId == userId);

                if (user == null)
                {
                    MessageBox.Show("Không tìm thấy tài khoản!");
                    return;
                }

                // Không cho khóa chính tài khoản đang đăng nhập
                if (user.UserId == UserSession.UserId)
                {
                    MessageBox.Show(
                        "Bạn không thể khóa tài khoản đang đăng nhập!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                string hanhDong = user.IsActive
                    ? "khóa"
                    : "mở khóa";

                DialogResult result = MessageBox.Show(
                    $"Bạn có chắc muốn {hanhDong} tài khoản \"{user.FullName}\" không?",
                    "Xác nhận",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result != DialogResult.Yes)
                {
                    return;
                }

                // Đang hoạt động thì khóa, đang khóa thì mở
                user.IsActive = !user.IsActive;

                db.SaveChanges();

                MessageBox.Show(
                    user.IsActive
                        ? "Mở khóa tài khoản thành công!"
                        : "Khóa tài khoản thành công!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }

            LoadUser();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgv.CurrentRow == null)
            {
                MessageBox.Show(
                    "Vui lòng chọn tài khoản cần xóa!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            // Giả sử cột UserId nằm ở vị trí đầu tiên
            int userId = Convert.ToInt32(
                dgv.CurrentRow.Cells[0].Value);

            // Không cho xóa chính tài khoản đang đăng nhập
            if (userId == UserSession.UserId)
            {
                MessageBox.Show(
                    "Bạn không thể xóa tài khoản đang đăng nhập!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

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
                    $"Bạn có chắc muốn xóa tài khoản \"{user.FullName}\" không?",
                    "Xác nhận xóa",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result != DialogResult.Yes)
                {
                    return;
                }

                try
                {
                    db.Users.Remove(user);
                    db.SaveChanges();

                    MessageBox.Show(
                        "Xóa tài khoản thành công!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                catch (DbUpdateException)
                {
                    MessageBox.Show(
                        "Không thể xóa tài khoản này vì đã phát sinh dữ liệu nghiệp vụ.\n" +
                        "Bạn nên khóa tài khoản thay vì xóa.",
                        "Không thể xóa",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }
            }

            LoadUser();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgv.CurrentRow == null || dgv.CurrentRow.Cells[0].Value == null)
            {
                MessageBox.Show(
                    "Vui lòng chọn tài khoản cần sửa!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            int userId = Convert.ToInt32(
                dgv.CurrentRow.Cells[0].Value);

            using (EditUser dialog = new EditUser(userId))
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    LoadUser();
                }
            }
        }

        private void btnRsPassword_Click(object sender, EventArgs e)
        {
            if (dgv.CurrentRow == null || dgv.CurrentRow.Cells[0].Value == null)
            {
                MessageBox.Show(
                    "Vui lòng chọn tài khoản cần đặt lại mật khẩu!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            int userId = Convert.ToInt32(
                dgv.CurrentRow.Cells[0].Value);

            using (ResetPassword dialog = new ResetPassword(userId))
            {
                dialog.ShowDialog();
            }
        }
    }
}
