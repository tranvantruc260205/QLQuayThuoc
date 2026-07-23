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

namespace QLQuayThuoc
{

    public partial class UserControlThongKeDoanhThu : UserControl
    {
        private readonly AppDbContext db = new AppDbContext();
        public UserControlThongKeDoanhThu()
        {
            InitializeComponent();
            cboHinhThuc.Items.Add("Tất cả");
            cboHinhThuc.Items.Add("Tiền mặt");
            cboHinhThuc.Items.Add("QR");

            cboHinhThuc.SelectedIndex = 0;

        }
       
    }
}
