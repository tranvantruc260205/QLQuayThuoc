using Microsoft.EntityFrameworkCore;
using QLQuayThuoc.Data;
using QLQuayThuoc.UserControls;
using QLQuayThuoc.UserControls.UCDuocSi;
using QLQuayThuoc.Utils;


namespace QLQuayThuoc
{
    public partial class FormDuocSi : Form
    {
        public FormDuocSi()
        {
            InitializeComponent();

            lblDuocSi.Text = UserSession.UserId + " | " + UserSession.FullName + " | Dược sĩ";
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

        private void button1_Click(object sender, EventArgs e)
        {
            OpenUserControl(new UCTiepNhanDon());
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
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

        private void FormDuocSi_Load(object sender, EventArgs e)
        {
            OpenUserControl(new UCTiepNhanDon());
        }

        private void btnLichSu_Click(object sender, EventArgs e)
        {
            OpenUserControl(new UCLichSuXuatThuoc());
        }
    }
}