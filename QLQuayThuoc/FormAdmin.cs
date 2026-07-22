namespace _13_QuanLyNguoiDung
{
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
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
    }
}
