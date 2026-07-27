using Microsoft.EntityFrameworkCore;
using QLQuayThuoc.Data;
using QLQuayThuoc.Forms.Dialogs;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QLQuayThuoc
{
    public partial class UCDanhSachDonThuoc : UserControl
    {
        public UCDanhSachDonThuoc()
        {
            InitializeComponent();

            dgv.AutoGenerateColumns = false;
            dgv.AllowUserToAddRows = false;
            dgv.ReadOnly = true;
            dgv.MultiSelect = false;

            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dtpTuNgay.Format =
                DateTimePickerFormat.Custom;
            dtpTuNgay.CustomFormat =
                "dd/MM/yyyy";

            dtpDenNgay.Format =
                DateTimePickerFormat.Custom;
            dtpDenNgay.CustomFormat =
                "dd/MM/yyyy";

            // Khoảng ngày mặc định
            dtpTuNgay.Value =
                DateTime.Today.AddMonths(-1);

            dtpDenNgay.Value =
                DateTime.Today;

            Load += UCDanhSachDonThuoc_Load;
        }

        private void LoadDonThuoc(string tuKhoa = "", DateTime? tuNgay = null, DateTime? denNgay = null)
        {
            dgv.Rows.Clear();

            if (UserSession.UserId <= 0)
            {
                MessageBox.Show(
                    "Không xác định được bác sĩ đang đăng nhập!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            try
            {
                using (AppDbContext db = new AppDbContext())
                {
                    var truyVan = db.DonThuocs
                        .AsNoTracking()
                        .Where(x =>
                            x.BacSiId == UserSession.UserId &&
                            x.TrangThai == "DA_XUAT_DON");

                    // Tìm theo mã đơn hoặc tên bệnh nhân
                    if (!string.IsNullOrWhiteSpace(tuKhoa))
                    {
                        if (int.TryParse(
                            tuKhoa,
                            out int maDonThuoc))
                        {
                            truyVan = truyVan.Where(x =>
                                x.MaDonThuoc == maDonThuoc ||
                                x.BenhNhan.HoTen.Contains(tuKhoa));
                        }
                        else
                        {
                            truyVan = truyVan.Where(x =>
                                x.BenhNhan.HoTen.Contains(tuKhoa));
                        }
                    }

                    // Lọc từ đầu ngày
                    if (tuNgay.HasValue)
                    {
                        DateTime ngayBatDau =
                            tuNgay.Value.Date;

                        truyVan = truyVan.Where(x =>
                            x.NgayKeDon >= ngayBatDau);
                    }

                    // Lấy hết ngày kết thúc
                    if (denNgay.HasValue)
                    {
                        DateTime ngayKetThuc =
                            denNgay.Value.Date.AddDays(1);

                        truyVan = truyVan.Where(x =>
                            x.NgayKeDon < ngayKetThuc);
                    }

                    var danhSachDonThuoc = truyVan
                        .OrderByDescending(x => x.NgayKeDon)
                        .Select(x => new
                        {
                            x.MaDonThuoc,

                            TenBenhNhan =
                                x.BenhNhan.HoTen,

                            x.NgayKeDon,

                            SoThuoc =
                                x.ChiTietDonThuocs.Count(),

                            x.GhiChu
                        })
                        .ToList();

                    foreach (var donThuoc
                        in danhSachDonThuoc)
                    {
                        dgv.Rows.Add(
                            donThuoc.MaDonThuoc,
                            donThuoc.TenBenhNhan,
                            donThuoc.NgayKeDon.ToString(
                                "dd/MM/yyyy HH:mm"),
                            donThuoc.SoThuoc,
                            "Đã xuất đơn",
                            donThuoc.GhiChu ?? "",
                            "Xem");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Không thể tải danh sách đơn thuốc!\n" +
                    ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void UCDanhSachDonThuoc_Load(object sender, EventArgs e)
        {
            LoadDonThuoc();
        }

        // Button "Làm mới"
        private void button5_Click(object sender, EventArgs e)
        {
            txtTimKiem.Clear();

            dtpTuNgay.Value =
                DateTime.Today.AddMonths(-1);

            dtpDenNgay.Value =
                DateTime.Today;

            // Không truyền điều kiện để tải toàn bộ
            LoadDonThuoc();

        }

        //Button "Lọc"
        private void button4_Click(object sender, EventArgs e)
        {
            string tuKhoa = txtTimKiem.Text.Trim();

            DateTime tuNgay =
                dtpTuNgay.Value.Date;

            DateTime denNgay =
                dtpDenNgay.Value.Date;

            if (tuNgay > denNgay)
            {
                MessageBox.Show(
                    "Từ ngày không được lớn hơn đến ngày!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                dtpTuNgay.Focus();
                return;
            }

            LoadDonThuoc(tuKhoa, tuNgay, denNgay);
        }

        private void OpenUserControl(UserControl userControl)
        {
            panelContent.Controls.Clear();

            userControl.Dock = DockStyle.Fill;

            panelContent.Controls.Add(userControl);
            userControl.BringToFront();
        }

        //Button "Kê đơn mới"
        private void button7_Click(object sender, EventArgs e)
        {
            OpenUserControl(new UCKeDonThuoc());
        }

        //Button "Xem chi tiết"
        private void button1_Click(object sender, EventArgs e)
        {
            if (dgv.CurrentRow == null || dgv.CurrentRow.Cells[0].Value == null)
            {
                MessageBox.Show(
                    "Vui lòng chọn đơn thuốc cần xem!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            int maDonThuoc = Convert.ToInt32(
                dgv.CurrentRow.Cells[0].Value);

            using (XemChiTietDonThuoc dialog = new XemChiTietDonThuoc(maDonThuoc))
            {
                dialog.ShowDialog();
            }
        }
    }
}
