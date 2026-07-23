using QLQuayThuoc.UserControls.UCKeToan;
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
    }
}
