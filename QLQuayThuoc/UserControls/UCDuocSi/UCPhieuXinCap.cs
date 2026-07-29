using Microsoft.EntityFrameworkCore;
using QLQuayThuoc.Data;
using QLQuayThuoc.Forms.Dialogs;
using QLQuayThuoc.Models;
using QLQuayThuoc.Utils;
using System.Data;

namespace QLQuayThuoc
{
    public partial class UCPhieuXinCap : UserControl
    {
        private bool dangTaiDanhSachPhieu;

        //private readonly List<ThuocXinCapTam> danhSachThuocTam = new List<ThuocXinCapTam>();
        private readonly List<ChiTietPhieuXinCap> danhSachCTThuocTam = new();
        private const int MaKhoTong = 1;
        private const int MaKhoQuay = 2;

        //private class ThuocXinCapTam
        //{
        //    public int MaThuoc { get; set; }

        //    public string TenThuoc { get; set; } =
        //        string.Empty;

        //    public int SoLuongTonQuay { get; set; }

        //    public int SoLuongYeuCau { get; set; }
        //}

        public UCPhieuXinCap()
        {
            InitializeComponent();

            CauHinhBangDanhSach();
            CauHinhBangChiTiet();
            CauHinhBoLoc();

            dtpNgayLap.Format =
        DateTimePickerFormat.Custom;

            dtpNgayLap.CustomFormat =
                "dd/MM/yyyy HH:mm";

            txtLyDo.MaxLength = 255;
        }

        private void CauHinhBangDanhSach()
        {
            dgv1.AutoGenerateColumns = false;
            dgv1.AllowUserToAddRows = false;
            dgv1.AllowUserToDeleteRows = false;
            dgv1.ReadOnly = true;
            dgv1.MultiSelect = false;

            dgv1.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
        }

        private void CauHinhBangChiTiet()
        {
            dgv2.AutoGenerateColumns = false;
            dgv2.AllowUserToAddRows = false;
            dgv2.AllowUserToDeleteRows = false;
            dgv2.ReadOnly = true;
            dgv2.MultiSelect = false;

            dgv2.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            XoaChiTietPhieu();
        }

        private void CauHinhBoLoc()
        {
            cbTrangThai.DropDownStyle =
                ComboBoxStyle.DropDownList;

            cbTrangThai.Items.Clear();

            cbTrangThai.Items.AddRange(
                new object[]
                {
                    "Tất cả",
                    "Chờ duyệt",
                    "Đã duyệt",
                    "Đã từ chối"
                });

            cbTrangThai.SelectedIndex = 0;
        }

        private void LoadDanhSachPhieu()
        {
            if (UserSession.UserId <= 0)
            {
                MessageBox.Show(
                    "Không xác định được dược sĩ đang đăng nhập!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            string tuKhoa = txtTimKiem.Text.Trim();

            string trangThaiCanLoc = LayTrangThaiCanLoc();

            try
            {
                using (AppDbContext db =
                    new AppDbContext())
                {
                    var truyVan =
                        db.PhieuXinCapThuocs
                            .AsNoTracking()
                            .Where(x =>
                                x.NguoiLapId ==
                                UserSession.UserId);

                    // Nếu nhập số thì tìm chính xác theo mã phiếu.
                    // Nếu nhập chữ thì tìm trong lý do.
                    if (!string.IsNullOrWhiteSpace(
                        tuKhoa))
                    {
                        if (int.TryParse(
                            tuKhoa,
                            out int maPhieu))
                        {
                            truyVan =
                                truyVan.Where(x =>
                                    x.MaPhieu ==
                                    maPhieu);
                        }
                        else
                        {
                            truyVan =
                                truyVan.Where(x =>
                                    x.LyDo.Contains(
                                        tuKhoa));
                        }
                    }

                    if (!string.IsNullOrEmpty(
                        trangThaiCanLoc))
                    {
                        truyVan =
                            truyVan.Where(x =>
                                x.TrangThai ==
                                trangThaiCanLoc);
                    }

                    var danhSachPhieu =
                        truyVan
                            .OrderByDescending(x =>
                                x.NgayLap)
                            .Select(x => new
                            {
                                x.MaPhieu,
                                x.NgayLap,
                                x.LyDo,
                                x.TrangThai
                            })
                            .ToList();

                    dgv1.Rows.Clear();

                    foreach (var phieu
                        in danhSachPhieu)
                    {
                        dgv1.Rows.Add(
                            phieu.MaPhieu,

                            phieu.NgayLap.ToString(
                                "dd/MM/yyyy HH:mm"),

                            phieu.LyDo,

                            HienThiTrangThai(
                                phieu.TrangThai));
                    }

                    dgv1.ClearSelection();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Không thể tải danh sách phiếu!\n" +
                    ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private string LayTrangThaiCanLoc()
        {
            if (cbTrangThai.Text ==
                "Chờ duyệt")
            {
                return "CHO_DUYET";
            }

            if (cbTrangThai.Text ==
                "Đã duyệt")
            {
                return "DA_DUYET";
            }

            if (cbTrangThai.Text ==
                "Đã từ chối")
            {
                return "DA_TU_CHOI";
            }

            // Tất cả
            return string.Empty;
        }

        private string HienThiTrangThai(
            string trangThai)
        {
            if (trangThai ==
                "CHO_DUYET")
            {
                return "Chờ duyệt";
            }

            if (trangThai ==
                "DA_DUYET")
            {
                return "Đã duyệt";
            }

            if (trangThai ==
                "DA_TU_CHOI")
            {
                return "Đã từ chối";
            }

            return trangThai;
        }

        private void LoadChiTietPhieu(
            int maPhieu)
        {
            try
            {
                using (AppDbContext db =
                    new AppDbContext())
                {
                    var phieu =
                        db.PhieuXinCapThuocs
                            .AsNoTracking()
                            .Include(x =>
                                x.ChiTietPhieuXinCaps)
                            .ThenInclude(x =>
                                x.Thuoc)
                            .FirstOrDefault(x =>
                                x.MaPhieu == maPhieu &&
                                x.NguoiLapId ==
                                    UserSession.UserId);

                    if (phieu == null)
                    {
                        XoaChiTietPhieu();

                        MessageBox.Show(
                            "Không tìm thấy phiếu xin cấp!",
                            "Thông báo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);

                        return;
                    }

                    List<int> danhSachMaThuoc =
                        phieu.ChiTietPhieuXinCaps
                            .Select(x => x.MaThuoc)
                            .ToList();

                    Dictionary<int, int> tonKhoQuay =
                        new Dictionary<int, int>();

                    if (danhSachMaThuoc.Count > 0)
                    {
                        tonKhoQuay =
                            db.TonKhos
                                .AsNoTracking()
                                .Where(x =>
                                    x.Kho.LoaiKho ==
                                        "KHO_QUAY" &&
                                    danhSachMaThuoc.Contains(
                                        x.LoThuoc.MaThuoc))
                                .GroupBy(x =>
                                    x.LoThuoc.MaThuoc)
                                .Select(nhom => new
                                {
                                    MaThuoc = nhom.Key,

                                    SoLuongTon =
                                        nhom.Sum(x =>
                                            x.SoLuongTon)
                                })
                                .ToDictionary(
                                    x => x.MaThuoc,
                                    x => x.SoLuongTon);
                    }

                    dtpNgayLap.Value =
                        phieu.NgayLap;

                    txtLyDo.Text =
                        phieu.LyDo;

                    dgv2.Rows.Clear();

                    foreach (var chiTiet
                        in phieu.ChiTietPhieuXinCaps
                            .OrderBy(x =>
                                x.Thuoc.TenThuoc))
                    {
                        tonKhoQuay.TryGetValue(
                            chiTiet.MaThuoc,
                            out int soLuongTonQuay);

                        ThemDongChiTiet(
                            chiTiet.Thuoc.TenThuoc,
                            soLuongTonQuay,
                            chiTiet.SoLuongYeuCau,
                            chiTiet.SoLuongDuyet,
                            chiTiet.GhiChu ??
                                string.Empty);
                    }

                    dgv2.ClearSelection();

                    DatCheDoChiTiet(
                        laPhieuTam: false);
                }
            }
            catch (Exception ex)
            {
                XoaChiTietPhieu();

                MessageBox.Show(
                    "Không thể tải chi tiết phiếu!\n" +
                    ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void HienThiPhieuTam(
            DataGridViewRow dongPhieuTam)
        {
            string ngayLapText =
                Convert.ToString(
                    dongPhieuTam.Cells[1].Value
                ) ?? string.Empty;

            if (DateTime.TryParse(
                ngayLapText,
                out DateTime ngayLap))
            {
                dtpNgayLap.Value =
                    ngayLap;
            }
            else
            {
                dtpNgayLap.Value =
                    DateTime.Now;
            }

            txtLyDo.Text =
                Convert.ToString(
                    dongPhieuTam.Cells[2].Value
                ) ?? string.Empty;

            dgv2.Rows.Clear();

            //foreach (ThuocXinCapTam thuoc
            //    in danhSachThuocTam)
            //{
            //    ThemDongChiTiet(
            //        thuoc.TenThuoc,
            //        thuoc.SoLuongTonQuay,
            //        thuoc.SoLuongYeuCau,
            //        null,
            //        string.Empty);
            //}

            HienThiDanhSachThuocTam();


            dgv2.ClearSelection();

            DatCheDoChiTiet(
                laPhieuTam: true);
        }

        private void ThemDongChiTiet(
            string tenThuoc,
            int soLuongTonQuay,
            int soLuongYeuCau,
            int? soLuongDuyet,
            string ghiChu)
        {
            int viTriDong =
                dgv2.Rows.Add();

            DataGridViewRow dong =
                dgv2.Rows[viTriDong];

            GanGiaTriChoCot(
                dong,
                "Thuốc",
                tenThuoc);

            GanGiaTriChoCot(
                dong,
                "Tồn quầy",
                soLuongTonQuay);

            GanGiaTriChoCot(
                dong,
                "Tồn kho quầy",
                soLuongTonQuay);

            GanGiaTriChoCot(
                dong,
                "SL yêu cầu",
                soLuongYeuCau);

            GanGiaTriChoCot(
                dong,
                "SL duyệt",
                soLuongDuyet?.ToString() ??
                    string.Empty);

            GanGiaTriChoCot(
                dong,
                "Ghi chú",
                ghiChu);
        }

        private void GanGiaTriChoCot(
            DataGridViewRow dong,
            string tieuDeCot,
            object giaTri)
        {
            foreach (DataGridViewColumn cot
                in dgv2.Columns)
            {
                if (string.Equals(
                    cot.HeaderText.Trim(),
                    tieuDeCot,
                    StringComparison.OrdinalIgnoreCase))
                {
                    dong.Cells[cot.Index].Value =
                        giaTri;

                    return;
                }
            }
        }

        private void DatCheDoChiTiet(
            bool laPhieuTam)
        {
            dtpNgayLap.Enabled =
                laPhieuTam;

            txtLyDo.ReadOnly =
                !laPhieuTam;

            // Chỉ phiếu tạm mới được thao tác.
            btnGuiDuyet.Enabled = laPhieuTam;
            btnHuy.Enabled = laPhieuTam;
            btnThemThuoc.Enabled = laPhieuTam;
            btnXoaDong.Enabled = laPhieuTam;
        }

        private void XoaChiTietPhieu()
        {
            dtpNgayLap.Value =
                DateTime.Now;

            txtLyDo.Clear();
            dgv2.Rows.Clear();

            DatCheDoChiTiet(
                laPhieuTam: false);
        }

        private void UCPhieuXinCap_Load(object sender, EventArgs e)
        {
            LoadDanhSachPhieu();
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            LoadDanhSachPhieu();
        }

        private void dgv1_SelectionChanged(object sender, EventArgs e)
        {
            if (dangTaiDanhSachPhieu)
            {
                return;
            }

            if (dgv1.SelectedRows.Count == 0)
            {
                XoaChiTietPhieu();
                return;
            }

            DataGridViewRow dongDangChon =
                dgv1.SelectedRows[0];

            string maPhieuText =
                Convert.ToString(
                    dongDangChon.Cells[0].Value
                )?.Trim() ?? string.Empty;

            // Mã phiếu rỗng là phiếu tạm.
            if (string.IsNullOrEmpty(maPhieuText))
            {
                HienThiPhieuTam(dongDangChon);
                return;
            }

            if (!int.TryParse(
                maPhieuText,
                out int maPhieu))
            {
                XoaChiTietPhieu();
                return;
            }

            LoadChiTietPhieu(maPhieu);
        }

        private void btnTaoPhieuMoi_Click(object sender, EventArgs e)
        {
            // Kiểm tra đã có phiếu tạm hay chưa.
            foreach (DataGridViewRow dong
                in dgv1.Rows)
            {
                string maPhieu =
                    Convert.ToString(
                        dong.Cells[0].Value
                    )?.Trim() ?? string.Empty;

                if (string.IsNullOrEmpty(maPhieu))
                {
                    dangTaiDanhSachPhieu = true;

                    try
                    {
                        dgv1.ClearSelection();

                        dong.Selected = true;

                        dgv1.CurrentCell =
                            dong.Cells[0];

                        HienThiPhieuTam(dong);
                    }
                    finally
                    {
                        dangTaiDanhSachPhieu = false;
                    }

                    MessageBox.Show(
                        "Bạn đang có một phiếu chưa gửi duyệt!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    return;
                }
            }

            // Bắt đầu một phiếu tạm mới.
            danhSachCTThuocTam.Clear();

            DateTime ngayLap = DateTime.Now;

            dangTaiDanhSachPhieu = true;

            try
            {
                // Thêm phiếu tạm lên đầu bảng.
                dgv1.Rows.Insert(
                    0,
                    string.Empty,
                    ngayLap.ToString(
                        "dd/MM/yyyy HH:mm"),
                    string.Empty,
                    string.Empty);

                DataGridViewRow dongMoi =
                    dgv1.Rows[0];

                dgv1.ClearSelection();

                dongMoi.Selected = true;

                dgv1.CurrentCell =
                    dongMoi.Cells[0];

                HienThiPhieuTam(dongMoi);
            }
            finally
            {
                dangTaiDanhSachPhieu = false;
            }

            txtTimKiem.Focus();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            if (dgv1.SelectedRows.Count == 0)
            {
                MessageBox.Show(
                    "Vui lòng chọn phiếu cần hủy!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            DataGridViewRow dongDangChon =
                dgv1.SelectedRows[0];

            string maPhieu =
                Convert.ToString(
                    dongDangChon.Cells[0].Value
                )?.Trim() ?? string.Empty;

            string trangThai =
                Convert.ToString(
                    dongDangChon.Cells[3].Value
                )?.Trim() ?? string.Empty;

            // Chỉ được hủy phiếu tạm.
            if (!string.IsNullOrEmpty(maPhieu) ||
                !string.IsNullOrEmpty(trangThai))
            {
                MessageBox.Show(
                    "Chỉ có thể hủy phiếu chưa gửi duyệt!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            DialogResult ketQua =
                MessageBox.Show(
                    "Bạn có chắc muốn hủy phiếu này không?",
                    "Xác nhận hủy phiếu",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

            if (ketQua != DialogResult.Yes)
            {
                return;
            }

            dangTaiDanhSachPhieu = true;

            try
            {
                // Xóa thuốc tạm đang giữ trong bộ nhớ.
                danhSachCTThuocTam.Clear();

                // Xóa dòng phiếu tạm khỏi bảng.
                dgv1.Rows.Remove(
                    dongDangChon);

                dgv1.ClearSelection();

                // Xóa nội dung phần chi tiết.
                XoaChiTietPhieu();
            }
            finally
            {
                dangTaiDanhSachPhieu = false;
            }
        }

        private void HienThiDanhSachThuocTam()
        {
            dgv2.Rows.Clear();

            try
            {
                using (AppDbContext db =
                    new AppDbContext())
                {
                    Dictionary<int, int> tonQuayTheoThuoc =
                        db.TonKhos
                            .AsNoTracking()
                            .Where(x =>
                                x.MaKho == MaKhoQuay)
                            .GroupBy(x =>
                                x.LoThuoc.MaThuoc)
                            .Select(nhom => new
                            {
                                MaThuoc = nhom.Key,

                                TonQuay = nhom.Sum(x =>
                                    x.SoLuongTon)
                            })
                            .ToDictionary(
                                x => x.MaThuoc,
                                x => x.TonQuay);

                    foreach (ChiTietPhieuXinCap chiTiet
                        in danhSachCTThuocTam)
                    {
                        int tonQuay =
                            tonQuayTheoThuoc.TryGetValue(
                                chiTiet.MaThuoc,
                                out int soLuongTon)
                                ? soLuongTon
                                : 0;

                        int viTriDong =
                            dgv2.Rows.Add(
                                chiTiet.Thuoc.TenThuoc,
                                tonQuay,
                                chiTiet.SoLuongYeuCau,
                                chiTiet.SoLuongDuyet.HasValue
                                    ? chiTiet.SoLuongDuyet.Value
                                    : string.Empty,
                                chiTiet.GhiChu ??
                                    string.Empty);

                        dgv2.Rows[
                            viTriDong
                        ].Tag = chiTiet.MaThuoc;
                    }
                }

                dgv2.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Không thể hiển thị danh sách thuốc!\n" +
                    ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnThemThuoc_Click(object sender, EventArgs e)
        {
            //if (dgv1.SelectedRows.Count == 0)
            //{
            //    MessageBox.Show(
            //        "Vui lòng chọn phiếu cần thêm thuốc!",
            //        "Thông báo",
            //        MessageBoxButtons.OK,
            //        MessageBoxIcon.Warning);

            //    return;
            //}

            DataGridViewRow dongPhieu =
                dgv1.SelectedRows[0];

            string maPhieu =
                Convert.ToString(
                    dongPhieu.Cells[0].Value
                )?.Trim() ?? string.Empty;

            string trangThai =
                Convert.ToString(
                    dongPhieu.Cells[3].Value
                )?.Trim() ?? string.Empty;

            if (!string.IsNullOrEmpty(maPhieu) ||
                !string.IsNullOrEmpty(trangThai))
            {
                MessageBox.Show(
                    "Chỉ được thêm thuốc vào phiếu chưa gửi duyệt!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            using (DuocSi_ThemThuoc dialog =
                new DuocSi_ThemThuoc(
                    danhSachCTThuocTam))
            {
                if (dialog.ShowDialog(FindForm()) !=
                    DialogResult.OK)
                {
                    return;
                }

                danhSachCTThuocTam.Clear();

                danhSachCTThuocTam.AddRange(dialog.DanhSachThuocDaChon);

                HienThiDanhSachThuocTam();
            }
        }

        private void btnXoaDong_Click(object sender, EventArgs e)
        {
            //if (dgv1.SelectedRows.Count == 0)
            //{
            //    MessageBox.Show(
            //        "Vui lòng chọn phiếu!",
            //        "Thông báo",
            //        MessageBoxButtons.OK,
            //        MessageBoxIcon.Warning);

            //    return;
            //}

            DataGridViewRow dongPhieu =
                dgv1.SelectedRows[0];

            string maPhieu =
                Convert.ToString(
                    dongPhieu.Cells[0].Value
                )?.Trim() ?? string.Empty;

            string trangThai =
                Convert.ToString(
                    dongPhieu.Cells[3].Value
                )?.Trim() ?? string.Empty;

            if (!string.IsNullOrEmpty(maPhieu) ||
                !string.IsNullOrEmpty(trangThai))
            {
                MessageBox.Show(
                    "Chỉ được xóa thuốc khỏi phiếu chưa gửi duyệt!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (dgv2.SelectedRows.Count == 0)
            {
                MessageBox.Show(
                    "Vui lòng chọn thuốc cần xóa!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            DataGridViewRow dongThuoc =
                dgv2.SelectedRows[0];

            if (dongThuoc.Tag == null)
            {
                return;
            }

            int maThuoc =
                Convert.ToInt32(
                    dongThuoc.Tag);

            DialogResult ketQua =
                MessageBox.Show(
                    "Bạn có chắc muốn xóa thuốc này không?",
                    "Xác nhận",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

            if (ketQua != DialogResult.Yes)
            {
                return;
            }

            // Xóa khỏi nguồn dữ liệu chính.
            danhSachCTThuocTam.RemoveAll(x =>
                x.MaThuoc == maThuoc);

            // Vẽ lại dgv2 từ danh sách chính.
            HienThiDanhSachThuocTam();
        }

        private void btnGuiDuyet_Click(object sender, EventArgs e)
        {
            if (dgv1.SelectedRows.Count == 0)
            {
                MessageBox.Show(
                    "Vui lòng chọn phiếu cần gửi duyệt!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            DataGridViewRow dongPhieu =
                dgv1.SelectedRows[0];

            string maPhieu =
                Convert.ToString(
                    dongPhieu.Cells[0].Value
                )?.Trim() ?? string.Empty;

            string trangThai =
                Convert.ToString(
                    dongPhieu.Cells[3].Value
                )?.Trim() ?? string.Empty;

            // Chỉ được gửi phiếu tạm chưa lưu.
            if (!string.IsNullOrEmpty(maPhieu) ||
                !string.IsNullOrEmpty(trangThai))
            {
                MessageBox.Show(
                    "Phiếu này đã được gửi duyệt!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (UserSession.UserId <= 0)
            {
                MessageBox.Show(
                    "Không xác định được dược sĩ đang đăng nhập!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            string lyDo =
                txtLyDo.Text.Trim();

            if (string.IsNullOrWhiteSpace(lyDo))
            {
                MessageBox.Show(
                    "Vui lòng nhập lý do xin cấp thuốc!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtLyDo.Focus();
                return;
            }

            if (danhSachCTThuocTam.Count == 0)
            {
                MessageBox.Show(
                    "Vui lòng thêm ít nhất một thuốc vào phiếu!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (danhSachCTThuocTam.Any(x =>
                x.SoLuongYeuCau <= 0))
            {
                MessageBox.Show(
                    "Số lượng yêu cầu của thuốc phải lớn hơn 0!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            DialogResult xacNhan =
                MessageBox.Show(
                    "Bạn có chắc muốn gửi phiếu này để kho tổng duyệt không?\n" +
                    "Sau khi gửi, phiếu sẽ không thể chỉnh sửa.",
                    "Xác nhận gửi duyệt",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

            if (xacNhan != DialogResult.Yes)
            {
                return;
            }

            btnGuiDuyet.Enabled = false;

            try
            {
                int maPhieuMoi;

                using (AppDbContext db =
                    new AppDbContext())
                {
                    PhieuXinCapThuoc phieuMoi =
                        new PhieuXinCapThuoc
                        {
                            KhoCapId = MaKhoTong,
                            KhoNhanId = MaKhoQuay,

                            NguoiLapId =
                                UserSession.UserId,

                            NguoiDuyetId = null,

                            NgayLap =
                                dtpNgayLap.Value,

                            NgayDuyet = null,
                            LyDo = lyDo,
                            GhiChuDuyet = null,
                            TrangThai = "CHO_DUYET"
                        };

                    foreach (ChiTietPhieuXinCap chiTietTam
                        in danhSachCTThuocTam)
                    {
                        phieuMoi.ChiTietPhieuXinCaps.Add(
                            new ChiTietPhieuXinCap
                            {
                                MaThuoc =
                                    chiTietTam.MaThuoc,

                                SoLuongYeuCau =
                                    chiTietTam.SoLuongYeuCau,

                                SoLuongDuyet = null,

                                GhiChu =
                                    chiTietTam.GhiChu
                            });
                    }

                    // EF tự lưu phiếu và toàn bộ chi tiết
                    // trong cùng một lần SaveChanges.
                    db.PhieuXinCapThuocs.Add(
                        phieuMoi);

                    db.SaveChanges();

                    maPhieuMoi =
                        phieuMoi.MaPhieu;
                }

                // Xóa dữ liệu của phiếu tạm vừa gửi.
                danhSachCTThuocTam.Clear();

                dangTaiDanhSachPhieu = true;

                try
                {
                    LoadDanhSachPhieu();

                    dgv1.ClearSelection();

                    XoaChiTietPhieu();
                }
                finally
                {
                    dangTaiDanhSachPhieu = false;
                }

                MessageBox.Show(
                    "Đã gửi phiếu xin cấp thuốc thành công!\n" +
                    "Mã phiếu: " + maPhieuMoi,
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                btnGuiDuyet.Enabled = true;

                string noiDungLoi =
                    ex.InnerException?.Message ??
                    ex.Message;

                MessageBox.Show(
                    "Không thể gửi phiếu xin cấp thuốc!\n" +
                    noiDungLoi,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
