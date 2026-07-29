using QLQuayThuoc.UserControls.UCKeToan;
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

namespace QLQuayThuoc.Forms.Main
{
    public partial class FormKeToan : Form
    {
        public FormKeToan()
        {
            InitializeComponent();
           lbKeToan.Text = UserSession.UserId + " | " + UserSession.FullName + " | Kế Toán";
        }

        private void OpenUserControl(UserControl userControl)
        {
            panelContent.Controls.Clear();

            userControl.Dock = DockStyle.Fill;

            panelContent.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void btnDanhSachHoaDon_Click(object sender, EventArgs e)
        {
            OpenUserControl(new UCDanhSachHoaDon());
        }

        private void btnBaoCaoDoanhThu_Click(object sender, EventArgs e)
        {
            OpenUserControl(new UCBaoCaoDoanhThu());
        }

        private void FormKeToan_Load(object sender, EventArgs e)
        {
            OpenUserControl(new UCDanhSachHoaDon());
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {

            DialogResult ketQua =
             MessageBox.Show(
                "Bạn có chắc muốn đăng xuất không?",
                "Xác nhận đăng xuất",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

                    if (ketQua != DialogResult.Yes)
                    {
                        return;
                    }
                    UserSession.Clear();
                    this.Close();
        }
    }
}
