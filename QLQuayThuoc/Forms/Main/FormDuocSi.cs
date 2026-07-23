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
    public partial class FormDuocSi : Form
    {
        public FormDuocSi()
        {
            InitializeComponent();
        }

        private void OpenUserControl(UserControl userControl)
        {
            panel5.Controls.Clear();

            userControl.Dock = DockStyle.Fill;

            panel5.Controls.Add(userControl);
            userControl.BringToFront();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            OpenUserControl(new UCTonKhoQuay());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenUserControl(new UCPhieuXinCap());
        }
    }
}