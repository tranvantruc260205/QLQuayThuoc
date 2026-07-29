using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLQuayThuoc.Data;
namespace QLQuayThuoc
{
    public partial class UCQuanLyLoThuoc : UserControl
    {
        public UCQuanLyLoThuoc()
        {
            InitializeComponent();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            TaiDanhSachLoThuoc();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtTimKiem.Clear();

            cboHanSuDung.SelectedIndex = 0;
            cboTrangThaiTon.SelectedIndex = 0;

            TaiDanhSachLoThuoc();
        }

        private void UCQuanLyLoThuoc_Load(object sender, EventArgs e)
        {
            cboHanSuDung.Items.Clear();
            cboHanSuDung.Items.Add("Tất cả");
            cboHanSuDung.Items.Add("Còn hạn");
            cboHanSuDung.Items.Add("Sắp hết hạn");
            cboHanSuDung.Items.Add("Hết hạn");
            cboHanSuDung.SelectedIndex = 0;

            cboTrangThaiTon.Items.Clear();
            cboTrangThaiTon.Items.Add("Tất cả");
            cboTrangThaiTon.Items.Add("Còn hàng");
            cboTrangThaiTon.Items.Add("Hết hàng");
            cboTrangThaiTon.SelectedIndex = 0;
            TaiDanhSachLoThuoc();
        }
        private void TaiDanhSachLoThuoc()
        {
            using (AppDbContext db = new AppDbContext())
            {
                var duLieuGoc = db.LoThuocs
                    .Select(lo => new
                    {
                        MaLo = lo.MaLo,
                        TenThuoc = lo.Thuoc.TenThuoc,
                        SoLo = lo.SoLo,
                        NgaySanXuat = lo.NgaySanXuat,
                        NgayHetHan = lo.NgayHetHan,

                        SoLuongTon = db.TonKhos
                            .Where(t => t.MaKho == 1 && t.MaLo == lo.MaLo)
                            .Sum(t => (int?)t.SoLuongTon) ?? 0
                    })
                    .ToList();

                var danhSach = duLieuGoc
                    .Select(lo => new
                    {
                        lo.MaLo,
                        lo.TenThuoc,
                        lo.SoLo,
                        lo.NgaySanXuat,
                        lo.NgayHetHan,
                        lo.SoLuongTon,

                        TrangThai =
                            lo.NgayHetHan.Date < DateTime.Today
                                ? "Hết hạn"
                                : lo.SoLuongTon <= 0
                                    ? "Hết hàng"
                                    : lo.NgayHetHan.Date <= DateTime.Today.AddDays(90)
                                        ? "Sắp hết hạn"
                                        : "Còn hạn"
                    })
                    .ToList();

                string tuKhoa = txtTimKiem.Text.Trim().ToLower();
                string hanSuDung = cboHanSuDung.Text;
                string trangThaiTon = cboTrangThaiTon.Text;

                var ketQua = danhSach
                    .Where(lo =>
                        string.IsNullOrEmpty(tuKhoa)
                        || lo.TenThuoc.ToLower().Contains(tuKhoa)
                        || lo.SoLo.ToLower().Contains(tuKhoa));

                if (hanSuDung == "Còn hạn")
                {
                    ketQua = ketQua.Where(lo =>
                        lo.NgayHetHan.Date > DateTime.Today.AddDays(90));
                }
                else if (hanSuDung == "Sắp hết hạn")
                {
                    ketQua = ketQua.Where(lo =>
                        lo.NgayHetHan.Date >= DateTime.Today
                        && lo.NgayHetHan.Date <= DateTime.Today.AddDays(90));
                }
                else if (hanSuDung == "Hết hạn")
                {
                    ketQua = ketQua.Where(lo =>
                        lo.NgayHetHan.Date < DateTime.Today);
                }

                if (trangThaiTon == "Còn hàng")
                {
                    ketQua = ketQua.Where(lo => lo.SoLuongTon > 0);
                }
                else if (trangThaiTon == "Hết hàng")
                {
                    ketQua = ketQua.Where(lo => lo.SoLuongTon <= 0);
                }

                dgvLoThuoc.DataSource = ketQua.ToList();
            }
        }

        private void dgvLoThuoc_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex != 6)
                return;

            string trangThai = e.Value?.ToString() ?? "";

            if (trangThai == "Hết hạn")
            {
                e.CellStyle.BackColor = Color.MistyRose;
                e.CellStyle.ForeColor = Color.DarkRed;
            }
            else if (trangThai == "Sắp hết hạn")
            {
                e.CellStyle.BackColor = Color.LemonChiffon;
                e.CellStyle.ForeColor = Color.DarkOrange;
            }
            else if (trangThai == "Hết hàng")
            {
                e.CellStyle.BackColor = Color.LightGray;
                e.CellStyle.ForeColor = Color.DimGray;
            }
            else if (trangThai == "Còn hạn")
            {
                e.CellStyle.BackColor = Color.Honeydew;
                e.CellStyle.ForeColor = Color.DarkGreen;
            }
        }
    }
}
