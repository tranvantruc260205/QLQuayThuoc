using Microsoft.EntityFrameworkCore;
using QLQuayThuoc.Data;
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

namespace QLQuayThuoc.Forms.Dialogs
{
    public partial class ChonBenhNhan : Form
    {
        public BenhNhan? BenhNhanDuocChon { get; private set; }
        public ChonBenhNhan()
        {
            InitializeComponent();

            StartPosition = FormStartPosition.CenterParent;

            CauHinhDataGridView();

            Load += ChonBenhNhan_Load;
            btnTimKiem.Click += btnTimKiem_Click;
            btnXacNhan.Click += btnXacNhan_Click;
            btnDong.Click += btnDong_Click;

            txtTimKiem.KeyDown += txtTimKiem_KeyDown;
        }

        private void CauHinhDataGridView()
        {
            dgv.AutoGenerateColumns = false;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.ReadOnly = true;
            dgv.MultiSelect = false;
            dgv.RowHeadersVisible = false;

            dgv.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            // Tạo cột bằng code
            dgv.Columns.Clear();

            dgv.Columns.Add(
                "colMaBN",
                "Mã BN");

            dgv.Columns.Add(
                "colHoTen",
                "Họ tên");

            dgv.Columns.Add(
                "colNgaySinh",
                "Ngày sinh");

            dgv.Columns.Add(
                "colGioiTinh",
                "Giới tính");

            dgv.Columns.Add(
                "colSoDienThoai",
                "Số điện thoại");

            dgv.Columns.Add(
                "colMaBHYT",
                "Mã BHYT");

            dgv.Columns[0].Width = 70;
            dgv.Columns[1].Width = 160;
            dgv.Columns[2].Width = 95;
            dgv.Columns[3].Width = 70;
            dgv.Columns[4].Width = 110;
            dgv.Columns[5].Width = 120;
        }

        private void LoadDanhSachBenhNhan(
            string tuKhoa = "")
        {
            dgv.Rows.Clear();

            try
            {
                using (AppDbContext db = new AppDbContext())
                {
                    var truyVan = db.BenhNhans
                        .AsNoTracking();

                    if (!string.IsNullOrWhiteSpace(tuKhoa))
                    {
                        tuKhoa = tuKhoa.Trim();

                        if (int.TryParse(
                            tuKhoa,
                            out int maBenhNhan))
                        {
                            truyVan = truyVan.Where(x =>
                                x.MaBN == maBenhNhan ||
                                x.HoTen.Contains(tuKhoa) ||
                                x.SoDienThoai.Contains(tuKhoa) ||
                                (x.MaBHYT != null &&
                                 x.MaBHYT.Contains(tuKhoa)));
                        }
                        else
                        {
                            truyVan = truyVan.Where(x =>
                                x.HoTen.Contains(tuKhoa) ||
                                x.SoDienThoai.Contains(tuKhoa) ||
                                (x.MaBHYT != null &&
                                 x.MaBHYT.Contains(tuKhoa)));
                        }
                    }

                    var danhSachBenhNhan = truyVan
                        .OrderBy(x => x.HoTen)
                        .ToList();

                    foreach (var benhNhan
                        in danhSachBenhNhan)
                    {
                        int dong = dgv.Rows.Add(
                            benhNhan.MaBN,
                            benhNhan.HoTen,
                            benhNhan.NgaySinh.ToString(
                                "dd/MM/yyyy"),
                            benhNhan.GioiTinh
                                ? "Nam"
                                : "Nữ",
                            benhNhan.SoDienThoai,
                            string.IsNullOrWhiteSpace(
                                benhNhan.MaBHYT)
                                ? "Không có"
                                : benhNhan.MaBHYT);

                        // Lưu đối tượng bệnh nhân vào dòng
                        dgv.Rows[dong].Tag =
                            benhNhan;
                    }

                    dgv.ClearSelection();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Không thể tải danh sách bệnh nhân!\n" +
                    ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void XacNhanBenhNhan()
        {
            if (dgv.CurrentRow == null ||
                dgv.CurrentRow.Tag
                    is not BenhNhan benhNhan)
            {
                MessageBox.Show(
                    "Vui lòng chọn một bệnh nhân!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            BenhNhanDuocChon = benhNhan;

            DialogResult = DialogResult.OK;
            Close();
        }

        private void ChonBenhNhan_Load(object sender, EventArgs e)
        {
            LoadDanhSachBenhNhan();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            LoadDanhSachBenhNhan(txtTimKiem.Text.Trim());
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            XacNhanBenhNhan();
        }

        private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            dgv.CurrentCell =
                dgv.Rows[e.RowIndex].Cells[0];

            XacNhanBenhNhan();
        }

        private void txtTimKiem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnTimKiem.PerformClick();
                e.SuppressKeyPress = true;
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
