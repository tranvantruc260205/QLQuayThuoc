using QLQuayThuoc.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;

namespace QLQuayThuoc
{
    public partial class frmThongKeDoanhThu : Form
    {

        public frmThongKeDoanhThu()
        {
            InitializeComponent();
        }

        private void OpenUserControl(UserControl userControl)
        {
            pnContent.Controls.Clear();

            userControl.Dock = DockStyle.Fill;

            pnContent.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void btnTongQuan_Click(object sender, EventArgs e)
        {
            OpenUserControl(new UserControlThongKeDoanhThu());
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            OpenUserControl(new UserControlHoaDon());
        }

        private void frmThongKeDoanhThu_Load(object sender, EventArgs e)
        {
            OpenUserControl(new UserControlThongKeDoanhThu());
        }
    }
}
