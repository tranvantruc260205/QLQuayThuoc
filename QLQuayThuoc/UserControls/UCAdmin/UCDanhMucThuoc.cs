using Microsoft.EntityFrameworkCore;
using QLQuayThuoc.Data;
using QLQuayThuoc.Forms.Dialogs;
using QLQuayThuoc.Models;
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
    public partial class UCDanhMucThuoc : UserControl
    {
        public UCDanhMucThuoc()
        {
            InitializeComponent();

            dgv.AutoGenerateColumns = false;
            dgv.AllowUserToAddRows = false;
            dgv.ReadOnly = true;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.MultiSelect = false;

            // Liên kết các cột đã tạo trong Designer
            Column1.DataPropertyName = "MaThuoc";
            Column2.DataPropertyName = "TenThuoc";
            Column3.DataPropertyName = "DonViTinh";
            Column4.DataPropertyName = "HoatChat";
            Column5.DataPropertyName = "HamLuong";
            Column6.DataPropertyName = "DonGiaBan";
            Column7.DataPropertyName = "DuocBHYTChiTra";
            Column8.DataPropertyName = "TrangThai";

            // Hiển thị đơn giá có dấu phân cách hàng nghìn
            Column6.DefaultCellStyle.Format = "N0";

            cbTrangThai.SelectedIndex = 0;
            cbTrangThai.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void LoadThuoc()
        {
            using (AppDbContext db = new AppDbContext())
            {
                dgv.DataSource = db.Thuocs
                    .AsNoTracking()
                    .OrderBy(x => x.MaThuoc)
                    .Select(x => new
                    {
                        x.MaThuoc,
                        x.TenThuoc,
                        x.DonViTinh,
                        x.HoatChat,
                        x.HamLuong,
                        x.DonGiaBan,
                        DuocBHYTChiTra = x.DuocBHYTChiTra ? "Có" : "Không",
                        TrangThai = x.TrangThai == "DANG_KINH_DOANH" ? "Đang kinh doanh" : "Tạm ngừng"
                    })
                    .ToList();
            }
        }

        private void UCDanhMucThuoc_Load(object sender, EventArgs e)
        {
            LoadThuoc();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtTimKiem.Clear();
            cbTrangThai.SelectedIndex = 0;
            LoadThuoc();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string tuKhoa = txtTimKiem.Text.Trim();

            string trangThai = "";

            if (cbTrangThai.Text == "Đang kinh doanh")
            {
                trangThai = "DANG_KINH_DOANH";
            }
            else if (cbTrangThai.Text == "Tạm ngừng")
            {
                trangThai = "TAM_NGUNG";
            }

            using (AppDbContext db = new AppDbContext())
            {
                var query = db.Thuocs
                    .AsNoTracking()
                    .AsQueryable();

                if (tuKhoa != "")
                {
                    if (int.TryParse(tuKhoa, out int maThuoc))
                    {
                        query = query.Where(x =>
                            x.MaThuoc == maThuoc ||
                            x.TenThuoc.Contains(tuKhoa) ||
                            x.DonViTinh.Contains(tuKhoa) ||
                            (x.HoatChat != null &&
                             x.HoatChat.Contains(tuKhoa)) ||
                            (x.HamLuong != null &&
                             x.HamLuong.Contains(tuKhoa)));
                    }
                    else
                    {
                        query = query.Where(x =>
                            x.TenThuoc.Contains(tuKhoa) ||
                            x.DonViTinh.Contains(tuKhoa) ||
                            (x.HoatChat != null &&
                             x.HoatChat.Contains(tuKhoa)) ||
                            (x.HamLuong != null &&
                             x.HamLuong.Contains(tuKhoa)));
                    }
                }

                if (trangThai != "")
                {
                    query = query.Where(x => x.TrangThai == trangThai);
                }

                dgv.DataSource = query
                    .OrderBy(x => x.MaThuoc)
                    .Select(x => new
                    {
                        x.MaThuoc,
                        x.TenThuoc,
                        x.DonViTinh,
                        x.HoatChat,
                        x.HamLuong,
                        x.DonGiaBan,
                        DuocBHYTChiTra = x.DuocBHYTChiTra ? "Có" : "Không",

                        TrangThai = x.TrangThai == "DANG_KINH_DOANH"
                            ? "Đang kinh doanh"
                            : "Tạm ngừng"
                    })
                    .ToList();
            }
        }

        private void btnThemThuoc_Click(object sender, EventArgs e)
        {
            using (Admin_ThemThuoc dialog = new Admin_ThemThuoc())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    LoadThuoc();
                }
            }
        }

        private void btnkdtn_Click(object sender, EventArgs e)
        {
            if (dgv.CurrentRow == null || dgv.CurrentRow.Cells[0].Value == null)
            {
                MessageBox.Show(
                    "Vui lòng chọn thuốc cần thay đổi trạng thái!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            int maThuoc = Convert.ToInt32(
                dgv.CurrentRow.Cells[0].Value);

            using (AppDbContext db = new AppDbContext())
            {
                var thuoc = db.Thuocs.FirstOrDefault(x =>
                    x.MaThuoc == maThuoc);

                if (thuoc == null)
                {
                    MessageBox.Show(
                        "Không tìm thấy thuốc!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                if (thuoc.TrangThai != "DANG_KINH_DOANH" &&
                    thuoc.TrangThai != "TAM_NGUNG")
                {
                    MessageBox.Show(
                        "Trạng thái thuốc không hợp lệ!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                bool dangKinhDoanh =
                    thuoc.TrangThai == "DANG_KINH_DOANH";

                string hanhDong = dangKinhDoanh
                    ? "tạm ngừng kinh doanh"
                    : "đưa vào kinh doanh lại";

                DialogResult result = MessageBox.Show(
                    $"Bạn có chắc muốn {hanhDong} thuốc " +
                    $"\"{thuoc.TenThuoc}\" không?",
                    "Xác nhận",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result != DialogResult.Yes)
                {
                    return;
                }

                thuoc.TrangThai = dangKinhDoanh
                    ? "TAM_NGUNG"
                    : "DANG_KINH_DOANH";

                db.SaveChanges();

                MessageBox.Show(
                    dangKinhDoanh
                        ? "Tạm ngừng kinh doanh thuốc thành công!"
                        : "Đưa thuốc vào kinh doanh lại thành công!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }

            LoadThuoc();
        }

        private void btnSuaThuoc_Click(object sender, EventArgs e)
        {
            if (dgv.CurrentRow == null || dgv.CurrentRow.Cells[0].Value == null)
            {
                MessageBox.Show(
                    "Vui lòng chọn thuốc cần sửa!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            int maThuoc = Convert.ToInt32(dgv.CurrentRow.Cells[0].Value);

            using (Admin_SuaThuoc dialog = new Admin_SuaThuoc(maThuoc))
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    LoadThuoc();
                }
            }
        }
    }
}
