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

        private sealed class LoOption
        {
            public int MaLo { get; set; }
            public string SoLo { get; set; } = string.Empty;
            public DateTime? NgayHetHan { get; set; }
            public int SoLuongTon { get; set; }

            public override string ToString()
            {
                if (MaLo == 0)
                    return "-- Tự động (theo hạn dùng) --";

                string hsd = NgayHetHan.HasValue ? NgayHetHan.Value.ToString("dd/MM/yyyy") : "?";
                return $"Lô {MaLo} - HSD {hsd} - Tồn: {SoLuongTon}";
            }
        }

        private readonly Dictionary<int, List<LoOption>> _loTheoMaThuoc = new Dictionary<int, List<LoOption>>();

        private readonly Dictionary<int, LoOption> _loDaChonTheoMaThuoc = new Dictionary<int, LoOption>();

        private ComboBox? _comboMaLoDangSua;

        public UCDuyetPhieuXinCap()
        {
            InitializeComponent();
            btnInPhieu.Click += btnInPhieu_Click;
            dgvPhieu.AutoGenerateColumns = false;

            dgvChiTiet.CellBeginEdit += dgvChiTiet_CellBeginEdit;
            dgvChiTiet.EditingControlShowing += dgvChiTiet_EditingControlShowing;

            dgvChiTiet.AutoGenerateColumns = false;

            colMaPhieu.DataPropertyName = "MaPhieu";
            colNguoiLap.DataPropertyName = "NguoiLap";
            colNgayLap.DataPropertyName = "NgayLap";
            colLyDo.DataPropertyName = "LyDo";

            dgvChiTiet.AllowUserToAddRows = false;

            dgvChiTiet.DataError += (s, ev) => { ev.ThrowException = false; };
        }

        private void UCDuyetPhieuXinCap_Load(object sender, EventArgs e)
        {
            cboTrangThai.Items.Clear();

            cboTrangThai.Items.Add("CHO_DUYET");
            cboTrangThai.Items.Add("DA_DUYET");
            cboTrangThai.Items.Add("DA_TU_CHOI");

            cboTrangThai.SelectedIndex = 0;

            dtpTuNgay.Value = DateTime.Today.AddYears(-1);
        }

        private void btnLoc_Click(object sender, EventArgs e) => TaiDanhSachPhieu();

        private void TaiDanhSachPhieu()
        {
            if (cboTrangThai.SelectedIndex < 0)
            {
                MessageBox.Show("Hãy chọn trạng thái cần lọc.");
                return;
            }

            DateTime tuNgay = dtpTuNgay.Value.Date;

            try
            {
                using AppDbContext db = new AppDbContext();

                var danhSach = db.PhieuXinCapThuocs
                    .Where(p => p.TrangThai == cboTrangThai.Text
                             && p.NgayLap >= tuNgay)
                    .OrderByDescending(p => p.NgayLap)
                    .Select(p => new
                    {
                        MaPhieu = p.MaPhieu,
                        NguoiLap = p.NguoiLap != null ? p.NguoiLap.FullName : "",
                        NgayLap = p.NgayLap,
                        LyDo = p.LyDo
                    })
                    .ToList();

                dgvPhieu.DataSource = danhSach;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Không thể tải danh sách phiếu: " + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
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
                dgvChiTiet.EndEdit();
                dgvChiTiet.CurrentCell = null;
                dgvChiTiet.DataSource = null;

                _loTheoMaThuoc.Clear();
                _loDaChonTheoMaThuoc.Clear();

                var chiTiet = db.ChiTietPhieuXinCaps
                    .Where(ct => ct.MaPhieu == maPhieu)
                    .Select(ct => new
                    {
                        MaThuoc = ct.MaThuoc,
                        TenThuoc = ct.Thuoc.TenThuoc,
                        SoLuongYeuCau = ct.SoLuongYeuCau,
                        TonKho = db.TonKhos
                    .Where(t => t.MaKho == 1
                             && t.LoThuoc.MaThuoc == ct.MaThuoc
                             && t.LoThuoc.NgayHetHan >= DateTime.Today)
                    .Sum(t => (int?)t.SoLuongTon) ?? 0,

                        SoLuongDuyet = ct.SoLuongDuyet ?? ct.SoLuongYeuCau
                    })
                    .ToList();

                dgvChiTiet.DataSource = chiTiet;
                NapDanhSachLoChoComboBox(db, chiTiet.Select(c => c.MaThuoc).Distinct().ToList());
            }

        }

        private void NapDanhSachLoChoComboBox(AppDbContext db, List<int> danhSachMaThuoc)
        {
            var loTheoThuoc = db.TonKhos
                .Include(t => t.LoThuoc)
                .Where(t => t.MaKho == 1
                         && danhSachMaThuoc.Contains(t.LoThuoc.MaThuoc)
                         && t.SoLuongTon > 0
                         && t.LoThuoc.NgayHetHan >= DateTime.Today)
                .OrderBy(t => t.LoThuoc.NgayHetHan)
                .Select(t => new
                {
                    t.LoThuoc.MaThuoc,
                    t.MaLo,
                    t.LoThuoc.SoLo,
                    t.LoThuoc.NgayHetHan,
                    t.SoLuongTon
                })
                .ToList()
                .GroupBy(x => x.MaThuoc)
                .ToDictionary(g => g.Key, g => g.ToList());

            foreach (DataGridViewRow row in dgvChiTiet.Rows)
            {
                if (row.IsNewRow)
                    continue;

                if (!int.TryParse(row.Cells[colMaThuoc.Name].Value?.ToString(), out int maThuoc))
                    continue;

                var danhSachOption = new List<LoOption> { new LoOption { MaLo = 0 } };

                if (loTheoThuoc.TryGetValue(maThuoc, out var danhSachLo))
                {
                    danhSachOption.AddRange(danhSachLo.Select(l => new LoOption
                    {
                        MaLo = l.MaLo,
                        SoLo = l.SoLo,
                        NgayHetHan = l.NgayHetHan,
                        SoLuongTon = l.SoLuongTon
                    }));
                }

                _loTheoMaThuoc[maThuoc] = danhSachOption;

                var cell = (DataGridViewComboBoxCell)row.Cells[colMaLo.Name];
                cell.DataSource = null;
                cell.Items.Clear();
                cell.Items.AddRange(danhSachOption.ToArray());
                cell.Value = danhSachOption[0]; 
            }
        }
        private void dgvChiTiet_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (dgvChiTiet.Columns[e.ColumnIndex].Name != colMaLo.Name)
                return;

            DataGridViewRow row = dgvChiTiet.Rows[e.RowIndex];

            if (!int.TryParse(row.Cells[colMaThuoc.Name].Value?.ToString(), out int maThuoc))
                return;

            if (!_loTheoMaThuoc.TryGetValue(maThuoc, out var danhSachOption))
                return;

            var cell = (DataGridViewComboBoxCell)row.Cells[colMaLo.Name];
            cell.Items.Clear();
            cell.Items.AddRange(danhSachOption.ToArray());

            if (_loDaChonTheoMaThuoc.TryGetValue(maThuoc, out var daChonTruoDo))
            {
                var khopLai = danhSachOption.FirstOrDefault(o => o.MaLo == daChonTruoDo.MaLo);
                if (khopLai != null)
                    cell.Value = khopLai;
            }
        }
        private void dgvChiTiet_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dgvChiTiet.CurrentCell == null
                || dgvChiTiet.Columns[dgvChiTiet.CurrentCell.ColumnIndex].Name != colMaLo.Name)
                return;

            if (_comboMaLoDangSua != null)
                _comboMaLoDangSua.SelectionChangeCommitted -= ComboMaLo_SelectionChangeCommitted;

            _comboMaLoDangSua = e.Control as ComboBox;

            if (_comboMaLoDangSua != null)
                _comboMaLoDangSua.SelectionChangeCommitted += ComboMaLo_SelectionChangeCommitted;
        }

        private void ComboMaLo_SelectionChangeCommitted(object? sender, EventArgs e)
        {
            if (dgvChiTiet.CurrentCell == null)
                return;

            DataGridViewRow row = dgvChiTiet.Rows[dgvChiTiet.CurrentCell.RowIndex];

            if (!int.TryParse(row.Cells[colMaThuoc.Name].Value?.ToString(), out int maThuoc))
                return;

            if (sender is ComboBox combo && combo.SelectedItem is LoOption loChon)
            {
                _loDaChonTheoMaThuoc[maThuoc] = loChon;
                row.Cells[colMaLo.Name].Value = loChon;
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

                bool coSoLuongYeuCau = int.TryParse(
                    row.Cells[colSoLuongYeuCau.Name].Value?.ToString(),
                    out int soLuongYeuCau);

                bool coTonKho = int.TryParse(
                    row.Cells[colTonKho.Name].Value?.ToString(),
                    out int tonKho);

                bool laSo = int.TryParse(
                    row.Cells[colSoLuongDuyet.Name].Value?.ToString(),
                    out int soLuongDuyet);

                if (!coSoLuongYeuCau || !coTonKho)
                {
                    MessageBox.Show("Dữ liệu số lượng yêu cầu / tồn kho không hợp lệ.");
                    return;
                }

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

        private void TrichXuatMotLo(AppDbContext db, TonKho tonKhoTong, int soLuongCap, int maThuoc)
        {
            tonKhoTong.SoLuongTon -= soLuongCap;

            TonKho? tonKhoQuay = db.TonKhos
                .SingleOrDefault(t => t.MaKho == 2 && t.MaLo == tonKhoTong.MaLo);

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

                        bool coMaThuoc = int.TryParse(
                            row.Cells[colMaThuoc.Name].Value?.ToString(),
                            out int maThuoc);

                        bool coSoLuongDuyet = int.TryParse(
                            row.Cells[colSoLuongDuyet.Name].Value?.ToString(),
                            out int soLuongDuyet);

                        if (!coMaThuoc || !coSoLuongDuyet || soLuongDuyet <= 0)
                        {
                            throw new Exception(
                                "Dữ liệu số lượng duyệt không hợp lệ, vui lòng kiểm tra lại.");
                        }

                        var chiTietPhieu = db.ChiTietPhieuXinCaps
                            .Single(ct => ct.MaPhieu == maPhieuDangChon
                                       && ct.MaThuoc == maThuoc);

                        chiTietPhieu.SoLuongDuyet = soLuongDuyet;

                        int maLoChiDinh = 0;
                        if (_loDaChonTheoMaThuoc.TryGetValue(maThuoc, out var loDaChon))
                        {
                            maLoChiDinh = loDaChon.MaLo;
                        }

                        int conLaiCanCap = soLuongDuyet;
                        // trừ thuốc 
                        if (maLoChiDinh != 0)
                        {
                            TonKho? tonKhoTong = db.TonKhos
                                .Include(t => t.LoThuoc)
                                .SingleOrDefault(t => t.MaKho == 1 && t.MaLo == maLoChiDinh);

                            if (tonKhoTong == null || tonKhoTong.LoThuoc.MaThuoc != maThuoc)
                            {
                                throw new Exception(
                                    $"Lô đã chọn không hợp lệ cho thuốc mã {maThuoc}.");
                            }

                            if (tonKhoTong.SoLuongTon < soLuongDuyet)
                            {
                                throw new Exception(
                                    $"Lô {tonKhoTong.LoThuoc.SoLo} chỉ còn {tonKhoTong.SoLuongTon}, " +
                                    $"không đủ để cấp {soLuongDuyet}. Vui lòng chọn lô khác hoặc giảm số lượng duyệt.");
                            }

                            TrichXuatMotLo(db, tonKhoTong, soLuongDuyet, maThuoc);
                            conLaiCanCap = 0;
                        }
                        else
                        {
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

                                TrichXuatMotLo(db, tonKhoTong, soLuongCap, maThuoc);

                                conLaiCanCap -= soLuongCap;
                            }
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
                    TaiDanhSachPhieu();
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

            try
            {
                using AppDbContext db = new AppDbContext();

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

                TaiDanhSachPhieu();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Từ chối phiếu thất bại: " + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

    }
}