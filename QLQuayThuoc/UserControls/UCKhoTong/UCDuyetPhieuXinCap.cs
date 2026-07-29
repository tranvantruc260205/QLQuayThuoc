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
using Microsoft.EntityFrameworkCore;
using QLQuayThuoc.Models;
using QLQuayThuoc.Utils;
using QLQuayThuoc.UserControls.UCKhoTong;
namespace QLQuayThuoc

{
    public partial class UCDuyetPhieuXinCap : UserControl
    {
        private int maPhieuDangChon = 0;
        public UCDuyetPhieuXinCap()
        {
            InitializeComponent();
            btnInPhieu.Click += btnInPhieu_Click;
            dgvPhieu.AutoGenerateColumns = false;

            colMaPhieu.DataPropertyName = "MaPhieu";
            colNguoiLap.DataPropertyName = "NguoiLap";
            colNgayLap.DataPropertyName = "NgayLap";
            colLyDo.DataPropertyName = "LyDo";
        }

        private void UCDuyetPhieuXinCap_Load(object sender, EventArgs e)
        {
            cboTrangThai.Items.Clear();

            cboTrangThai.Items.Add("CHO_DUYET");
            cboTrangThai.Items.Add("DA_DUYET");
            cboTrangThai.Items.Add("DA_TU_CHOI");

            cboTrangThai.SelectedIndex = 0;
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            DateTime tuNgay = dtpTuNgay.Value.Date;

            using (AppDbContext db = new AppDbContext())
            {
                var danhSach = db.PhieuXinCapThuocs
                    .Where(p => p.TrangThai == cboTrangThai.Text
                             && p.NgayLap >= tuNgay)
                    .Select(p => new
                    {
                        MaPhieu = p.MaPhieu,
                        NguoiLap = p.NguoiLap.FullName,
                        NgayLap = p.NgayLap,
                        LyDo = p.LyDo
                    })
                    .ToList();

                dgvPhieu.DataSource = danhSach;
            }
        }

        private void dgvPhieu_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPhieu.CurrentRow == null)
                return;

            object maPhieuValue = dgvPhieu.CurrentRow.Cells[0].Value;

            if (maPhieuValue == null)
                return;
            int maPhieu = Convert.ToInt32(maPhieuValue);
            maPhieuDangChon = maPhieu;

            using (AppDbContext db = new AppDbContext())
            {
                var chiTiet = db.ChiTietPhieuXinCaps
                    .Where(ct => ct.MaPhieu == maPhieu)
                    .Select(ct => new
                    {
                        MaThuoc = ct.MaThuoc,
                        TenThuoc = ct.Thuoc.TenThuoc,
                        SoLuongYeuCau = ct.SoLuongYeuCau,

                        TonKho = db.TonKhos
                    .Where(t => t.MaKho == 1
                             && t.LoThuoc.MaThuoc == ct.MaThuoc)
                    .Sum(t => (int?)t.SoLuongTon) ?? 0,

                        SoLuongDuyet = ct.SoLuongDuyet ?? ct.SoLuongYeuCau
                    })
                    .ToList();

                dgvChiTiet.DataSource = chiTiet;
            }

        }

        private void btnDuyetXuat_Click(object sender, EventArgs e)
        {
            if (maPhieuDangChon == 0)
            {
                MessageBox.Show("Hãy chọn một phiếu cần duyệt.");
                return;
            }

            dgvChiTiet.EndEdit();

            foreach (DataGridViewRow row in dgvChiTiet.Rows)
            {
                if (row.IsNewRow)
                    continue;

                int soLuongYeuCau = Convert.ToInt32(row.Cells[2].Value);
                int tonKho = Convert.ToInt32(row.Cells[3].Value);

                bool laSo = int.TryParse(
                    row.Cells[4].Value?.ToString(),
                    out int soLuongDuyet);

                if (!laSo || soLuongDuyet <= 0)
                {
                    MessageBox.Show("Số lượng duyệt phải là số nguyên lớn hơn 0.");
                    return;
                }

                if (soLuongDuyet > soLuongYeuCau)
                {
                    MessageBox.Show("Số lượng duyệt không được lớn hơn số lượng yêu cầu.");
                    return;
                }

                if (soLuongDuyet > tonKho)
                {
                    MessageBox.Show("Số lượng duyệt không được lớn hơn tồn kho tổng.");
                    return;
                }
            }

            DialogResult ketQua = MessageBox.Show(
                    "Bạn có chắc muốn duyệt và cấp thuốc?",
                    "Xác nhận",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

            if (ketQua == DialogResult.Yes)
            {
                LuuDuyetVaCapThuoc();
            }
        }
        private void btnInPhieu_Click(object? sender, EventArgs e)
        {
            if (maPhieuDangChon == 0)
            {
                MessageBox.Show(
                    "Hãy chọn một phiếu để xem trước.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            using FrmXemTruocPhieuXinCap form =
                new FrmXemTruocPhieuXinCap(maPhieuDangChon);

            form.ShowDialog(FindForm());
        }

        private void LuuDuyetVaCapThuoc()
        {
            using (AppDbContext db = new AppDbContext())
            using (var transaction = db.Database.BeginTransaction())
            {
                try
                {
                    var phieu = db.PhieuXinCapThuocs
                        .SingleOrDefault(p => p.MaPhieu == maPhieuDangChon);

                    if (phieu == null)
                    {
                        MessageBox.Show("Không tìm thấy phiếu.");
                        return;
                    }

                    if (phieu.TrangThai != "CHO_DUYET")
                    {
                        MessageBox.Show("Phiếu này đã được xử lý.");
                        return;
                    }

                    foreach (DataGridViewRow row in dgvChiTiet.Rows)
                    {
                        if (row.IsNewRow)
                            continue;

                        int maThuoc = Convert.ToInt32(row.Cells[0].Value);

                        int soLuongDuyet = Convert.ToInt32(row.Cells[4].Value);

                        var chiTietPhieu = db.ChiTietPhieuXinCaps
                            .Single(ct => ct.MaPhieu == maPhieuDangChon
                                       && ct.MaThuoc == maThuoc);

                        chiTietPhieu.SoLuongDuyet = soLuongDuyet;

                        int conLaiCanCap = soLuongDuyet;

                        var danhSachLo = db.TonKhos
                            .Include(t => t.LoThuoc)
                            .Where(t => t.MaKho == 1
                                     && t.LoThuoc.MaThuoc == maThuoc
                                     && t.SoLuongTon > 0
                                     && t.LoThuoc.NgayHetHan >= DateTime.Today)
                            .OrderBy(t => t.LoThuoc.NgayHetHan)
                            .ToList();

                        foreach (TonKho tonKhoTong in danhSachLo)
                        {
                            if (conLaiCanCap == 0)
                                break;

                            int soLuongCap = Math.Min(
                                conLaiCanCap,
                                tonKhoTong.SoLuongTon);

                            tonKhoTong.SoLuongTon -= soLuongCap;

                            TonKho? tonKhoQuay = db.TonKhos
                                .SingleOrDefault(t => t.MaKho == 2
                                                   && t.MaLo == tonKhoTong.MaLo);

                            if (tonKhoQuay == null)
                            {
                                tonKhoQuay = new TonKho
                                {
                                    MaKho = 2,
                                    MaLo = tonKhoTong.MaLo,
                                    SoLuongTon = 0
                                };

                                db.TonKhos.Add(tonKhoQuay);
                            }

                            tonKhoQuay.SoLuongTon += soLuongCap;

                            db.ChiTietCapTheoLos.Add(new ChiTietCapTheoLo
                            {
                                MaPhieu = maPhieuDangChon,
                                MaThuoc = maThuoc,
                                MaLo = tonKhoTong.MaLo,
                                SoLuongCap = soLuongCap
                            });

                            conLaiCanCap -= soLuongCap;
                        }

                        if (conLaiCanCap > 0)
                        {
                            throw new Exception("Tồn kho không đủ để cấp thuốc.");
                        }
                    }

                    phieu.TrangThai = "DA_DUYET";
                    phieu.NguoiDuyetId = UserSession.UserId;
                    phieu.NgayDuyet = DateTime.Now;
                    phieu.GhiChuDuyet = txtGhiChuDuyet.Text.Trim();

                    db.SaveChanges();
                    transaction.Commit();

                    MessageBox.Show("Đã duyệt phiếu và chuyển thuốc sang Kho Quầy.");

                    maPhieuDangChon = 0;
                    dgvChiTiet.DataSource = null;
                    btnLoc_Click(sender: null!, e: EventArgs.Empty);
                }
                catch (Exception ex)
                {
                    transaction.Rollback();

                    MessageBox.Show(
                        "Duyệt phiếu thất bại: " + ex.Message,
                        "Lỗi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }
        private void btnTuChoi_Click(object sender, EventArgs e)
        {
            if (maPhieuDangChon == 0)
            {
                MessageBox.Show("Hãy chọn phiếu cần từ chối.");
                return;
            }
            string ghiChu = txtGhiChuDuyet.Text.Trim();

            if (string.IsNullOrEmpty(ghiChu))
            {
                MessageBox.Show("Hãy nhập lý do từ chối vào ô Ghi chú.");
                txtGhiChuDuyet.Focus();
                return;
            }

            DialogResult ketQua = MessageBox.Show(
                "Bạn có chắc muốn từ chối phiếu này?",
                "Xác nhận từ chối",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (ketQua != DialogResult.Yes)
                return;

            using (AppDbContext db = new AppDbContext())
            {
                var phieu = db.PhieuXinCapThuocs
                    .SingleOrDefault(p => p.MaPhieu == maPhieuDangChon);

                if (phieu == null)
                {
                    MessageBox.Show("Không tìm thấy phiếu.");
                    return;
                }

                if (phieu.TrangThai != "CHO_DUYET")
                {
                    MessageBox.Show("Phiếu này đã được xử lý.");
                    return;
                }

                phieu.TrangThai = "DA_TU_CHOI";
                phieu.NguoiDuyetId = UserSession.UserId;
                phieu.NgayDuyet = DateTime.Now;
                phieu.GhiChuDuyet = ghiChu;

                db.SaveChanges();

                MessageBox.Show("Đã từ chối phiếu.");

                maPhieuDangChon = 0;
                dgvChiTiet.DataSource = null;
                txtGhiChuDuyet.Clear();

                btnLoc_Click(null!, EventArgs.Empty);
            }
        }

    }
}
