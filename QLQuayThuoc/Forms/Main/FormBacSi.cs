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
    public partial class FormBacSi : Form
    {
        private void OpenUserControl(UserControl userControl)
        {
            panelContent.Controls.Clear();

            userControl.Dock = DockStyle.Fill;

            panelContent.Controls.Add(userControl);
            userControl.BringToFront();
        }
        public FormBacSi()
        {
            InitializeComponent();

            lblBacSi.Text = UserSession.UserId + " | " + UserSession.FullName + " | Bác sĩ";
        }


        private void btn_DonThuoc_Click(object sender, EventArgs e)
        {
            OpenUserControl(new UCDanhSachDonThuoc());
        }

        private void btn_KeDonMoi_Click(object sender, EventArgs e)
        {
            OpenUserControl(new UCKeDonThuoc());
        }

        private void DanhSachDonThuoc_Load(object sender, EventArgs e)
        {
            OpenUserControl(new UCDanhSachDonThuoc());
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            UserSession.Clear();
            this.Close();
        }
    }
}
