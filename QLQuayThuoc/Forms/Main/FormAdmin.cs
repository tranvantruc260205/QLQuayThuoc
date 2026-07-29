using QLQuayThuoc.UserControls.UCAdmin;
using QLQuayThuoc.Utils;

namespace QLQuayThuoc
{
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
            OpenUserControl(new UCNguoiDungPhanQuyen());

            lblAdmin.Text = UserSession.UserId + " | " + UserSession.FullName + " | Admin";
        }

        private void OpenUserControl(UserControl userControl)
        {
            panel2.Controls.Clear();

            userControl.Dock = DockStyle.Fill;

            panel2.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private void btnPhanQuyen_Click(object sender, EventArgs e)
        {
            OpenUserControl(new UCNguoiDungPhanQuyen());
        }

        private void btnDanhMuc_Click(object sender, EventArgs e)
        {
            OpenUserControl(new UCDanhMucThuoc());
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

        private void btnQuanLiThanhToanQRCode_Click(object sender, EventArgs e)
        {
            OpenUserControl(new UCQuanLiThanhToanQRCode());
        }
    }
}
