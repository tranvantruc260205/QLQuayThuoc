using QLQuayThuoc.Data;
using QLQuayThuoc.Forms.Dialogs;
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
            LoadUser();
        }
    }
}
