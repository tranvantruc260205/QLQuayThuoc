namespace QLQuayThuoc.UserControls.UCKeToan
{
    partial class UCDanhSachHoaDon
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
            label1 = new Label();
            groupBox1 = new GroupBox();
            btnLamMoi = new Button();
            btnLoc = new Button();
            cboPhuongThuc = new ComboBox();
            label5 = new Label();
            dtpDenNgay = new DateTimePicker();
            dtpTuNgay = new DateTimePicker();
            label4 = new Label();
            label3 = new Label();
            txtTimKiem = new TextBox();
            label2 = new Label();
            dgvHoaDon = new DataGridView();
            btnXemChiTiet = new Button();
            btnInHoaDon = new Button();
            colMaHD = new DataGridViewTextBoxColumn();
            colMaDonThuoc = new DataGridViewTextBoxColumn();
            colBenhNhan = new DataGridViewTextBoxColumn();
            colDuocSi = new DataGridViewTextBoxColumn();
            colNgayThanhToan = new DataGridViewTextBoxColumn();
            colTienThuoc = new DataGridViewTextBoxColumn();
            colBHYT = new DataGridViewTextBoxColumn();
            colBHYTChiTra = new DataGridViewTextBoxColumn();
            colBenhNhanTra = new DataGridViewTextBoxColumn();
            colPhuongThuc = new DataGridViewTextBoxColumn();
            colMaGiaoDich = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHoaDon).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(13, 10);
            label1.Name = "label1";
            label1.Size = new Size(266, 31);
            label1.TabIndex = 0;
            label1.Text = "DANH SÁCH HÓA ĐƠN";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnLamMoi);
            groupBox1.Controls.Add(btnLoc);
            groupBox1.Controls.Add(cboPhuongThuc);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(dtpDenNgay);
            groupBox1.Controls.Add(dtpTuNgay);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtTimKiem);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(3, 44);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1068, 114);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tìm kiếm và lọc";
            // 
            // btnLamMoi
            // 
            btnLamMoi.Location = new Point(964, 51);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(94, 29);
            btnLamMoi.TabIndex = 9;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnLoc
            // 
            btnLoc.Location = new Point(881, 51);
            btnLoc.Name = "btnLoc";
            btnLoc.Size = new Size(61, 29);
            btnLoc.TabIndex = 8;
            btnLoc.Text = "Lọc";
            btnLoc.UseVisualStyleBackColor = true;
            btnLoc.Click += btnLoc_Click;
            // 
            // cboPhuongThuc
            // 
            cboPhuongThuc.FormattingEnabled = true;
            cboPhuongThuc.Location = new Point(653, 50);
            cboPhuongThuc.Name = "cboPhuongThuc";
            cboPhuongThuc.Size = new Size(168, 28);
            cboPhuongThuc.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(653, 27);
            label5.Name = "label5";
            label5.Size = new Size(93, 20);
            label5.TabIndex = 6;
            label5.Text = "Phương thức";
            // 
            // dtpDenNgay
            // 
            dtpDenNgay.Location = new Point(444, 50);
            dtpDenNgay.Name = "dtpDenNgay";
            dtpDenNgay.Size = new Size(188, 27);
            dtpDenNgay.TabIndex = 5;
            // 
            // dtpTuNgay
            // 
            dtpTuNgay.Location = new Point(232, 50);
            dtpTuNgay.Name = "dtpTuNgay";
            dtpTuNgay.Size = new Size(188, 27);
            dtpTuNgay.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(444, 27);
            label4.Name = "label4";
            label4.Size = new Size(72, 20);
            label4.TabIndex = 3;
            label4.Text = "Đến ngày";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(232, 27);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 2;
            label3.Text = "Từ ngày";
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(6, 50);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(198, 27);
            txtTimKiem.TabIndex = 1;
            txtTimKiem.KeyDown += txtTimKiem_KeyDown;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 27);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 0;
            label2.Text = "Tìm kiếm";
            // 
            // dgvHoaDon
            // 
            dgvHoaDon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHoaDon.Columns.AddRange(new DataGridViewColumn[] { colMaHD, colMaDonThuoc, colBenhNhan, colDuocSi, colNgayThanhToan, colTienThuoc, colBHYT, colBHYTChiTra, colBenhNhanTra, colPhuongThuc, colMaGiaoDich });
            dgvHoaDon.Location = new Point(3, 164);
            dgvHoaDon.Name = "dgvHoaDon";
            dgvHoaDon.RowHeadersVisible = false;
            dgvHoaDon.RowHeadersWidth = 51;
            dgvHoaDon.RowTemplate.Height = 29;
            dgvHoaDon.Size = new Size(1068, 471);
            dgvHoaDon.TabIndex = 2;
            dgvHoaDon.CellDoubleClick += dgvHoaDon_CellDoubleClick;
            // 
            // btnXemChiTiet
            // 
            btnXemChiTiet.Location = new Point(806, 662);
            btnXemChiTiet.Name = "btnXemChiTiet";
            btnXemChiTiet.Size = new Size(112, 29);
            btnXemChiTiet.TabIndex = 10;
            btnXemChiTiet.Text = "Xem chi tiết";
            btnXemChiTiet.UseVisualStyleBackColor = true;
            btnXemChiTiet.Click += btnXemChiTiet_Click;
            // 
            // btnInHoaDon
            // 
            btnInHoaDon.Location = new Point(952, 662);
            btnInHoaDon.Name = "btnInHoaDon";
            btnInHoaDon.Size = new Size(119, 29);
            btnInHoaDon.TabIndex = 11;
            btnInHoaDon.Text = "In lại hóa đơn";
            btnInHoaDon.UseVisualStyleBackColor = true;
            btnInHoaDon.Click += btnInHoaDon_Click;
            // 
            // colMaHD
            // 
            colMaHD.HeaderText = "Mã HD";
            colMaHD.MinimumWidth = 6;
            colMaHD.Name = "colMaHD";
            colMaHD.Width = 50;
            // 
            // colMaDonThuoc
            // 
            colMaDonThuoc.HeaderText = "Mã phiếu xuất";
            colMaDonThuoc.MinimumWidth = 6;
            colMaDonThuoc.Name = "colMaDonThuoc";
            colMaDonThuoc.Width = 50;
            // 
            // colBenhNhan
            // 
            colBenhNhan.HeaderText = "Bệnh nhân";
            colBenhNhan.MinimumWidth = 6;
            colBenhNhan.Name = "colBenhNhan";
            colBenhNhan.Width = 125;
            // 
            // colDuocSi
            // 
            colDuocSi.HeaderText = "Dược sĩ";
            colDuocSi.MinimumWidth = 6;
            colDuocSi.Name = "colDuocSi";
            colDuocSi.Width = 125;
            // 
            // colNgayThanhToan
            // 
            colNgayThanhToan.HeaderText = "Ngày thanh toán";
            colNgayThanhToan.MinimumWidth = 6;
            colNgayThanhToan.Name = "colNgayThanhToan";
            colNgayThanhToan.Width = 125;
            // 
            // colTienThuoc
            // 
            colTienThuoc.HeaderText = "Tiền thuốc";
            colTienThuoc.MinimumWidth = 6;
            colTienThuoc.Name = "colTienThuoc";
            colTienThuoc.Width = 105;
            // 
            // colBHYT
            // 
            colBHYT.HeaderText = "BHYT";
            colBHYT.MinimumWidth = 6;
            colBHYT.Name = "colBHYT";
            colBHYT.Width = 50;
            // 
            // colBHYTChiTra
            // 
            colBHYTChiTra.HeaderText = "BHYT chi trả";
            colBHYTChiTra.MinimumWidth = 6;
            colBHYTChiTra.Name = "colBHYTChiTra";
            colBHYTChiTra.Width = 105;
            // 
            // colBenhNhanTra
            // 
            colBenhNhanTra.HeaderText = "Bệnh nhân trả";
            colBenhNhanTra.MinimumWidth = 6;
            colBenhNhanTra.Name = "colBenhNhanTra";
            colBenhNhanTra.Width = 110;
            // 
            // colPhuongThuc
            // 
            colPhuongThuc.HeaderText = "Phương thức";
            colPhuongThuc.MinimumWidth = 6;
            colPhuongThuc.Name = "colPhuongThuc";
            colPhuongThuc.Width = 110;
            // 
            // colMaGiaoDich
            // 
            colMaGiaoDich.HeaderText = "Mã giao dịch";
            colMaGiaoDich.MinimumWidth = 6;
            colMaGiaoDich.Name = "colMaGiaoDich";
            colMaGiaoDich.Width = 110;
            // 
            // UCDanhSachHoaDon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnInHoaDon);
            Controls.Add(btnXemChiTiet);
            Controls.Add(dgvHoaDon);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "UCDanhSachHoaDon";
            Size = new Size(1341, 715);
            Load += UCDanhSachHoaDon_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHoaDon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private TextBox txtTimKiem;
        private Label label2;
        private ComboBox cboPhuongThuc;
        private Label label5;
        private DateTimePicker dtpDenNgay;
        private DateTimePicker dtpTuNgay;
        private Label label4;
        private Label label3;
        private Button btnLamMoi;
        private Button btnLoc;
        private DataGridView dgvHoaDon;
        private Button btnXemChiTiet;
        private Button btnInHoaDon;
        private DataGridViewTextBoxColumn colMaHD;
        private DataGridViewTextBoxColumn colMaDonThuoc;
        private DataGridViewTextBoxColumn colBenhNhan;
        private DataGridViewTextBoxColumn colDuocSi;
        private DataGridViewTextBoxColumn colNgayThanhToan;
        private DataGridViewTextBoxColumn colTienThuoc;
        private DataGridViewTextBoxColumn colBHYT;
        private DataGridViewTextBoxColumn colBHYTChiTra;
        private DataGridViewTextBoxColumn colBenhNhanTra;
        private DataGridViewTextBoxColumn colPhuongThuc;
        private DataGridViewTextBoxColumn colMaGiaoDich;
    }
}
