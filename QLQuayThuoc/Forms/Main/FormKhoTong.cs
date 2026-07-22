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
    }
}
