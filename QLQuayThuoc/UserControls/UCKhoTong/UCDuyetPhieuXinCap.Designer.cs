namespace QLQuayThuoc
{
    partial class UCDuyetPhieuXinCap
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelContent = new Panel();
            grpChiTietDuyet = new GroupBox();
            btnDuyetXuat = new Button();
            btnInPhieu = new Button();
            btnTuChoi = new Button();
            dgvChiTiet = new DataGridView();
            colMaThuoc = new DataGridViewTextBoxColumn();
            colTenThuoc = new DataGridViewTextBoxColumn();
            colSoLuongYeuCau = new DataGridViewTextBoxColumn();
            colTonKho = new DataGridViewTextBoxColumn();
            colSoLuongDuyet = new DataGridViewTextBoxColumn();
            txtGhiChuDuyet = new TextBox();
            grpPhieuChoXuLy = new GroupBox();
            dtpTuNgay = new DateTimePicker();
            cboTrangThai = new ComboBox();
            dgvPhieu = new DataGridView();
            colMaPhieu = new DataGridViewTextBoxColumn();
            colNguoiLap = new DataGridViewTextBoxColumn();
            colNgayLap = new DataGridViewTextBoxColumn();
            colLyDo = new DataGridViewTextBoxColumn();
            btnLoc = new Button();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            panelContent.SuspendLayout();
            grpChiTietDuyet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvChiTiet).BeginInit();
            grpPhieuChoXuLy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPhieu).BeginInit();
            SuspendLayout();
            // 
            // panelContent
            // 
            panelContent.BackColor = SystemColors.Window;
            panelContent.Controls.Add(grpChiTietDuyet);
            panelContent.Controls.Add(grpPhieuChoXuLy);
            panelContent.Controls.Add(label5);
            panelContent.Controls.Add(label4);
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(0, 0);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(1240, 503);
            panelContent.TabIndex = 6;
            // 
            // grpChiTietDuyet
            // 
            grpChiTietDuyet.BackColor = SystemColors.MenuBar;
            grpChiTietDuyet.Controls.Add(btnDuyetXuat);
            grpChiTietDuyet.Controls.Add(btnInPhieu);
            grpChiTietDuyet.Controls.Add(btnTuChoi);
            grpChiTietDuyet.Controls.Add(dgvChiTiet);
            grpChiTietDuyet.Controls.Add(txtGhiChuDuyet);
            grpChiTietDuyet.Location = new Point(532, 50);
            grpChiTietDuyet.Name = "grpChiTietDuyet";
            grpChiTietDuyet.Size = new Size(517, 308);
            grpChiTietDuyet.TabIndex = 5;
            grpChiTietDuyet.TabStop = false;
            grpChiTietDuyet.Text = "Chi tiết và số lượng duyệt";
            // 
            // btnDuyetXuat
            // 
            btnDuyetXuat.Location = new Point(372, 270);
            btnDuyetXuat.Name = "btnDuyetXuat";
            btnDuyetXuat.Size = new Size(133, 29);
            btnDuyetXuat.TabIndex = 4;
            btnDuyetXuat.Text = "Duyệt && Xuất";
            btnDuyetXuat.UseVisualStyleBackColor = true;
            btnDuyetXuat.Click += btnDuyetXuat_Click;
            // 
            // btnInPhieu
            // 
            btnInPhieu.Location = new Point(260, 269);
            btnInPhieu.Name = "btnInPhieu";
            btnInPhieu.Size = new Size(94, 29);
            btnInPhieu.TabIndex = 3;
            btnInPhieu.Text = "In phiếu";
            btnInPhieu.UseVisualStyleBackColor = true;
            btnInPhieu.Click += btnInPhieu_Click;
            // 
            // btnTuChoi
            // 
            btnTuChoi.Location = new Point(144, 270);
            btnTuChoi.Name = "btnTuChoi";
            btnTuChoi.Size = new Size(94, 29);
            btnTuChoi.TabIndex = 2;
            btnTuChoi.Text = "Từ chối";
            btnTuChoi.UseVisualStyleBackColor = true;
            btnTuChoi.Click += btnTuChoi_Click;
            // 
            // dgvChiTiet
            // 
            dgvChiTiet.BackgroundColor = SystemColors.Control;
            dgvChiTiet.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvChiTiet.Columns.AddRange(new DataGridViewColumn[] { colMaThuoc, colTenThuoc, colSoLuongYeuCau, colTonKho, colSoLuongDuyet });
            dgvChiTiet.Location = new Point(6, 61);
            dgvChiTiet.Name = "dgvChiTiet";
            dgvChiTiet.RowHeadersVisible = false;
            dgvChiTiet.RowHeadersWidth = 51;
            dgvChiTiet.RowTemplate.Height = 29;
            dgvChiTiet.Size = new Size(505, 188);
            dgvChiTiet.TabIndex = 1;
            // 
            // colMaThuoc
            // 
            colMaThuoc.DataPropertyName = "MaThuoc";
            colMaThuoc.HeaderText = "Mã";
            colMaThuoc.MinimumWidth = 9;
            colMaThuoc.Name = "colMaThuoc";
            colMaThuoc.Visible = false;
            colMaThuoc.Width = 175;
            // 
            // colTenThuoc
            // 
            colTenThuoc.DataPropertyName = "TenThuoc";
            colTenThuoc.HeaderText = "Thuốc";
            colTenThuoc.MinimumWidth = 6;
            colTenThuoc.Name = "colTenThuoc";
            colTenThuoc.ReadOnly = true;
            colTenThuoc.Width = 300;
            // 
            // colSoLuongYeuCau
            // 
            colSoLuongYeuCau.DataPropertyName = "SoLuongYeuCau";
            colSoLuongYeuCau.HeaderText = "Yêu cầu";
            colSoLuongYeuCau.MinimumWidth = 6;
            colSoLuongYeuCau.Name = "colSoLuongYeuCau";
            colSoLuongYeuCau.ReadOnly = true;
            colSoLuongYeuCau.Width = 200;
            // 
            // colTonKho
            // 
            colTonKho.DataPropertyName = "TonKho";
            colTonKho.HeaderText = "Tồn kho";
            colTonKho.MinimumWidth = 6;
            colTonKho.Name = "colTonKho";
            colTonKho.ReadOnly = true;
            colTonKho.Width = 140;
            // 
            // colSoLuongDuyet
            // 
            colSoLuongDuyet.DataPropertyName = "SoLuongDuyet";
            colSoLuongDuyet.HeaderText = "Số lượng duyệt";
            colSoLuongDuyet.MinimumWidth = 6;
            colSoLuongDuyet.Name = "colSoLuongDuyet";
            colSoLuongDuyet.Width = 200;
            // 
            // txtGhiChuDuyet
            // 
            txtGhiChuDuyet.Location = new Point(6, 24);
            txtGhiChuDuyet.Multiline = true;
            txtGhiChuDuyet.Name = "txtGhiChuDuyet";
            txtGhiChuDuyet.Size = new Size(499, 33);
            txtGhiChuDuyet.TabIndex = 0;
            // 
            // grpPhieuChoXuLy
            // 
            grpPhieuChoXuLy.BackColor = SystemColors.Menu;
            grpPhieuChoXuLy.Controls.Add(dtpTuNgay);
            grpPhieuChoXuLy.Controls.Add(cboTrangThai);
            grpPhieuChoXuLy.Controls.Add(dgvPhieu);
            grpPhieuChoXuLy.Controls.Add(btnLoc);
            grpPhieuChoXuLy.Controls.Add(label7);
            grpPhieuChoXuLy.Controls.Add(label6);
            grpPhieuChoXuLy.Location = new Point(6, 49);
            grpPhieuChoXuLy.Name = "grpPhieuChoXuLy";
            grpPhieuChoXuLy.Size = new Size(523, 308);
            grpPhieuChoXuLy.TabIndex = 4;
            grpPhieuChoXuLy.TabStop = false;
            grpPhieuChoXuLy.Text = "Phiếu chờ xử lý";
            // 
            // dtpTuNgay
            // 
            dtpTuNgay.Format = DateTimePickerFormat.Short;
            dtpTuNgay.Location = new Point(177, 52);
            dtpTuNgay.Margin = new Padding(2, 2, 2, 2);
            dtpTuNgay.Name = "dtpTuNgay";
            dtpTuNgay.Size = new Size(161, 27);
            dtpTuNgay.TabIndex = 6;
            // 
            // cboTrangThai
            // 
            cboTrangThai.FormattingEnabled = true;
            cboTrangThai.Location = new Point(6, 51);
            cboTrangThai.Name = "cboTrangThai";
            cboTrangThai.Size = new Size(151, 28);
            cboTrangThai.TabIndex = 5;
            // 
            // dgvPhieu
            // 
            dgvPhieu.AllowUserToAddRows = false;
            dgvPhieu.BackgroundColor = SystemColors.Control;
            dgvPhieu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPhieu.Columns.AddRange(new DataGridViewColumn[] { colMaPhieu, colNguoiLap, colNgayLap, colLyDo });
            dgvPhieu.Location = new Point(6, 85);
            dgvPhieu.MultiSelect = false;
            dgvPhieu.Name = "dgvPhieu";
            dgvPhieu.ReadOnly = true;
            dgvPhieu.RowHeadersVisible = false;
            dgvPhieu.RowHeadersWidth = 51;
            dgvPhieu.RowTemplate.Height = 29;
            dgvPhieu.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPhieu.Size = new Size(514, 214);
            dgvPhieu.TabIndex = 3;
            dgvPhieu.SelectionChanged += dgvPhieu_SelectionChanged;
            // 
            // colMaPhieu
            // 
            colMaPhieu.HeaderText = "Mã phiếu";
            colMaPhieu.MinimumWidth = 6;
            colMaPhieu.Name = "colMaPhieu";
            colMaPhieu.ReadOnly = true;
            colMaPhieu.Width = 140;
            // 
            // colNguoiLap
            // 
            colNguoiLap.HeaderText = "Người lập";
            colNguoiLap.MinimumWidth = 6;
            colNguoiLap.Name = "colNguoiLap";
            colNguoiLap.ReadOnly = true;
            colNguoiLap.Width = 200;
            // 
            // colNgayLap
            // 
            colNgayLap.HeaderText = "Ngày lập";
            colNgayLap.MinimumWidth = 6;
            colNgayLap.Name = "colNgayLap";
            colNgayLap.ReadOnly = true;
            colNgayLap.Width = 200;
            // 
            // colLyDo
            // 
            colLyDo.HeaderText = "Lý do";
            colLyDo.MinimumWidth = 6;
            colLyDo.Name = "colLyDo";
            colLyDo.ReadOnly = true;
            colLyDo.Width = 250;
            // 
            // btnLoc
            // 
            btnLoc.Location = new Point(385, 50);
            btnLoc.Name = "btnLoc";
            btnLoc.Size = new Size(94, 29);
            btnLoc.TabIndex = 2;
            btnLoc.Text = "Lọc";
            btnLoc.UseVisualStyleBackColor = true;
            btnLoc.Click += btnLoc_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(177, 28);
            label7.Name = "label7";
            label7.Size = new Size(62, 20);
            label7.TabIndex = 1;
            label7.Text = "Từ ngày";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 28);
            label6.Name = "label6";
            label6.Size = new Size(75, 20);
            label6.TabIndex = 0;
            label6.Text = "Trạng thái";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(6, 31);
            label5.Name = "label5";
            label5.Size = new Size(248, 15);
            label5.TabIndex = 3;
            label5.Text = "Kiểm tra tồn kho tổng và tổng số lượng duyệt";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(3, 3);
            label4.Name = "label4";
            label4.Size = new Size(206, 28);
            label4.TabIndex = 2;
            label4.Text = "Duyệt Phiếu Xin Cấp";
            // 
            // UCDuyetPhieuXinCap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelContent);
            Name = "UCDuyetPhieuXinCap";
            Size = new Size(1240, 503);
            Load += UCDuyetPhieuXinCap_Load;
            panelContent.ResumeLayout(false);
            panelContent.PerformLayout();
            grpChiTietDuyet.ResumeLayout(false);
            grpChiTietDuyet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvChiTiet).EndInit();
            grpPhieuChoXuLy.ResumeLayout(false);
            grpPhieuChoXuLy.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPhieu).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelContent;
        private GroupBox grpChiTietDuyet;
        private Button btnDuyetXuat;
        private Button btnInPhieu;
        private Button btnTuChoi;
        private DataGridView dgvChiTiet;
        private TextBox txtGhiChuDuyet;
        private GroupBox grpPhieuChoXuLy;
        private ComboBox cboTrangThai;
        private DataGridView dgvPhieu;
        private Button btnLoc;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private DataGridViewTextBoxColumn colMaPhieu;
        private DataGridViewTextBoxColumn colNguoiLap;
        private DataGridViewTextBoxColumn colNgayLap;
        private DataGridViewTextBoxColumn colLyDo;
        private DateTimePicker dtpTuNgay;
        private DataGridViewTextBoxColumn colMaThuoc;
        private DataGridViewTextBoxColumn colTenThuoc;
        private DataGridViewTextBoxColumn colSoLuongYeuCau;
        private DataGridViewTextBoxColumn colTonKho;
        private DataGridViewTextBoxColumn colSoLuongDuyet;
    }
}
