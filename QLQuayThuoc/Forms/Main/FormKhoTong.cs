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
    public partial class FormKhoTong : Form
    {
        private void OpenUserControl(UserControl userControl)
        {
            panelContent.Controls.Clear();

            userControl.Dock = DockStyle.Fill;

            panelContent.Controls.Add(userControl);
            userControl.BringToFront();
        }
        public FormKhoTong()
        {
            InitializeComponent();
            lbKhoTong.Text = UserSession.UserId + " | " + UserSession.FullName + " | Kho Tổng";
        }

        private void DuyetPhieuXinCap_Load(object sender, EventArgs e)
        {
            OpenUserControl(new UCDuyetPhieuXinCap());
        }

        private void btn_PhieuXinCap_Click(object sender, EventArgs e)
        {
            OpenUserControl(new UCDuyetPhieuXinCap());
        }

        private void btn_KhoThuoc_Click(object sender, EventArgs e)
        {
            OpenUserControl(new UCQuanLyLoThuoc());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult ketQua = MessageBox.Show(
            "Bạn có chắc muốn đăng xuất?",
            "Xác nhận đăng xuất",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

            if (ketQua == DialogResult.Yes)
            {
                UserSession.Clear();
                this.Close();
            }
        }
    }
}
