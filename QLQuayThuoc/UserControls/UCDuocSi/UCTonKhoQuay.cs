using Microsoft.EntityFrameworkCore;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace QLQuayThuoc
{
    public partial class UCTonKhoQuay : UserControl
    {
        private const int MaKhoQuay = 2;
        private const int MucTonSapHet = 20;
        private const int SoNgaySapHetHan = 60;
        public UCTonKhoQuay()
        {
            InitializeComponent();
            CauHinhManHinh();
        }

        private void CauHinhManHinh()
        {
            lblThuocSapHet.Text = "0";
            lblThuocSapHetHan.Text = "0";
            lblPhieuChoDuyet.Text = "0";

            dgv.AutoGenerateColumns = false;
            dgv.AllowUserToAddRows = false;
            dgv.ReadOnly = true;
            dgv.MultiSelect = false;

            dgv.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            //dgv.AutoSizeColumnsMode =
            //    DataGridViewAutoSizeColumnsMode.Fill;

            //Column1.FillWeight = 12;
            //Column2.FillWeight = 24;
            //Column3.FillWeight = 16;
            //Column4.FillWeight = 18;
            //Column5.FillWeight = 10;
            //Column6.FillWeight = 12;
            //Column7.FillWeight = 22;

            // Bộ lọc hạn dùng
            cbHanDung.DropDownStyle =
                ComboBoxStyle.DropDownList;

            cbHanDung.Items.Clear();

            cbHanDung.Items.AddRange(
                new object[]
                {
                    "Tất cả",
                    "Còn hạn",
                    "Sắp hết hạn",
                    "Đã hết hạn"
                });

            cbHanDung.SelectedIndex = 0;

            // Bộ lọc tồn kho
            cbTrangThai.DropDownStyle =
                ComboBoxStyle.DropDownList;

            cbTrangThai.Items.Clear();

            cbTrangThai.Items.AddRange(
                new object[]
                {
                    "Tất cả",
                    "Còn đủ",
                    "Sắp hết"
                });

            cbTrangThai.SelectedIndex = 0;
        }

        private void LoadDuLieu()
        {
            lblThuocSapHet.Text = "0";
            lblThuocSapHetHan.Text = "0";
            lblPhieuChoDuyet.Text = "0";

            dgv.Rows.Clear();

            try
            {
                using (AppDbContext db =
                    new AppDbContext())
                {
                    DateTime homNay =
                        DateTime.Today;

                    // Nhỏ hơn ngày thứ 61 nghĩa là
                    // bao gồm đủ từ hôm nay đến 60 ngày.
                    DateTime ngaySauMocCanhBao =
                        homNay.AddDays(
                            SoNgaySapHetHan + 1);

                    

                    // Thuốc có tổng tồn <= 20.
                    int soThuocSapHet = db.TonKhos
                        .AsNoTracking()
                        .Where(x =>
                            x.MaKho == MaKhoQuay &&
                            x.SoLuongTon <= MucTonSapHet)
                        .Select(x =>
                            x.LoThuoc.MaThuoc)
                        .Distinct()
                        .Count();

                    // Số lô còn tồn và hết hạn
                    // từ hôm nay đến 60 ngày.
                    int soThuocSapHetHan = db.TonKhos
                        .AsNoTracking()
                        .Where(x =>
                            x.MaKho == MaKhoQuay &&
                            x.LoThuoc.NgayHetHan >= homNay &&
                            x.LoThuoc.NgayHetHan <
                                ngaySauMocCanhBao)
                        .Select(x =>
                            x.LoThuoc.MaThuoc)
                        .Distinct()
                        .Count();

                    // Số phiếu của kho quầy
                    // đang chờ kho tổng duyệt.
                    int soPhieuChoDuyet =
                        db.PhieuXinCapThuocs
                            .AsNoTracking()
                            .Count(x =>
                                x.KhoNhanId ==
                                    MaKhoQuay &&
                                x.TrangThai ==
                                    "CHO_DUYET");

                    lblThuocSapHet.Text =
                        soThuocSapHet.ToString();

                    lblThuocSapHetHan.Text =
                        soThuocSapHetHan.ToString();

                    lblPhieuChoDuyet.Text =
                        soPhieuChoDuyet.ToString();

                    string tuKhoa =
                        txtTimKiem.Text.Trim();

                    string locHanDung =
                        cbHanDung.SelectedItem
                            ?.ToString() ??
                        "Tất cả";

                    string locTrangThai =
                        cbTrangThai.SelectedItem
                            ?.ToString() ??
                        "Tất cả";

                    var truyVan =
                        db.TonKhos
                            .AsNoTracking()
                            .Where(x =>
                                x.MaKho ==
                                    MaKhoQuay);

                    // Tìm theo mã thuốc, tên thuốc
                    // hoặc số lô.
                    if (!string.IsNullOrWhiteSpace(
                        tuKhoa))
                    {
                        if (int.TryParse(
                            tuKhoa,
                            out int maThuoc))
                        {
                            truyVan =
                                truyVan.Where(x =>
                                    x.LoThuoc.MaThuoc ==
                                        maThuoc ||
                                    x.LoThuoc.Thuoc
                                        .TenThuoc
                                        .Contains(tuKhoa) ||
                                    x.LoThuoc.SoLo
                                        .Contains(tuKhoa));
                        }
                        else
                        {
                            truyVan =
                                truyVan.Where(x =>
                                    x.LoThuoc.Thuoc
                                        .TenThuoc
                                        .Contains(tuKhoa) ||
                                    x.LoThuoc.SoLo
                                        .Contains(tuKhoa));
                        }
                    }

                    // Lọc theo hạn dùng.
                    if (locHanDung ==
                        "Còn hạn")
                    {
                        // Còn hạn trên 60 ngày.
                        truyVan =
                            truyVan.Where(x =>
                                x.LoThuoc.NgayHetHan >=
                                    ngaySauMocCanhBao);
                    }
                    else if (locHanDung ==
                        "Sắp hết hạn")
                    {
                        truyVan =
                            truyVan.Where(x =>
                                x.LoThuoc.NgayHetHan >=
                                    homNay &&
                                x.LoThuoc.NgayHetHan <
                                    ngaySauMocCanhBao);
                    }
                    else if (locHanDung ==
                        "Đã hết hạn")
                    {
                        truyVan =
                            truyVan.Where(x =>
                                x.LoThuoc.NgayHetHan <
                                    homNay);
                    }

                    var danhSachTonKho =
                        truyVan
                            .Select(x =>
                                new
                                {
                                    MaThuoc =
                                        x.LoThuoc.MaThuoc,

                                    TenThuoc =
                                        x.LoThuoc.Thuoc
                                            .TenThuoc,

                                    SoLo =
                                        x.LoThuoc.SoLo,

                                    NgayHetHan =
                                        x.LoThuoc.NgayHetHan,

                                    SoLuongTon =
                                        x.SoLuongTon,

                                    DonViTinh =
                                        x.LoThuoc.Thuoc
                                            .DonViTinh
                                })
                            .OrderBy(x =>
                                x.NgayHetHan)
                            .ThenBy(x =>
                                x.TenThuoc)
                            .ToList();

                    // Lọc theo tổng tồn của thuốc.
                    if (locTrangThai == "Sắp hết")
                    {
                        danhSachTonKho =
                            danhSachTonKho
                                .Where(x =>
                                    x.SoLuongTon <= MucTonSapHet)
                                .ToList();
                    }
                    else if (locTrangThai == "Còn đủ")
                    {
                        danhSachTonKho =
                            danhSachTonKho
                                .Where(x =>
                                    x.SoLuongTon > MucTonSapHet)
                                .ToList();
                    }

                    foreach (var tonKho
                        in danhSachTonKho)
                    {
                        string trangThai = LayTrangThai(
                            tonKho.SoLuongTon,
                            tonKho.NgayHetHan,
                            homNay,
                            ngaySauMocCanhBao);

                        dgv.Rows.Add(
                            tonKho.MaThuoc,
                            tonKho.TenThuoc,
                            tonKho.SoLo,
                            tonKho.NgayHetHan
                                .ToString(
                                    "dd/MM/yyyy"),
                            tonKho.SoLuongTon,
                            tonKho.DonViTinh,
                            trangThai);
                    }

                    dgv.ClearSelection();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Không thể tải dữ liệu tồn kho quầy!\n" +
                    ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private string LayTrangThai(
            int soLuongTon,
            DateTime ngayHetHan,
            DateTime homNay,
            DateTime ngaySauMocCanhBao)
        {
            bool sapHet = soLuongTon <= MucTonSapHet;

            if (ngayHetHan < homNay)
            {
                return sapHet
                    ? "Sắp hết - Đã hết hạn"
                    : "Đã hết hạn";
            }

            if (ngayHetHan <
                ngaySauMocCanhBao)
            {
                return sapHet
                    ? "Sắp hết - Sắp hết hạn - " + (ngayHetHan - homNay).Days + " ngày"
                    : "Sắp hết hạn";
            }

            return sapHet
                ? "Sắp hết"
                : "Bình thường";
        }

        private void UCTonKhoQuay_Load(object sender, EventArgs e)
        {
            LoadDuLieu();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            LoadDuLieu();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtTimKiem.Clear();
            cbHanDung.SelectedIndex = 0;
            cbTrangThai.SelectedIndex = 0;

            LoadDuLieu();
        }

        private void txtTimKiem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnTim.PerformClick();

                e.SuppressKeyPress = true;
            }
        }
    }
}
