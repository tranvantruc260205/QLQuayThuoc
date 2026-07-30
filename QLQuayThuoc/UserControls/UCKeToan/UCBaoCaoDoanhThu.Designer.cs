namespace QLQuayThuoc.UserControls.UCKeToan
{
    partial class UCBaoCaoDoanhThu
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
            groupBox1 = new GroupBox();
            btnXuatExcel = new Button();
            btnThongKe = new Button();
            cboNhomTheo = new ComboBox();
            label5 = new Label();
            dtpDenNgay = new DateTimePicker();
            dtpTuNgay = new DateTimePicker();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            lblTongSoHoaDon = new Label();
            label2 = new Label();
            panel2 = new Panel();
            lblTongTienThuoc = new Label();
            label8 = new Label();
            panel3 = new Panel();
            lblTongBHYT = new Label();
            label10 = new Label();
            panel4 = new Panel();
            lblTongBenhNhanTra = new Label();
            label12 = new Label();
            dgvBaoCao = new DataGridView();
            colSoLuongHoaDon = new DataGridViewTextBoxColumn();
            colThoiGian = new DataGridViewTextBoxColumn();
            colTienThuoc = new DataGridViewTextBoxColumn();
            colBHYTChiTra = new DataGridViewTextBoxColumn();
            colBenhNhanTra = new DataGridViewTextBoxColumn();
            btnXemHoaDon = new Button();
            btnInBaoCao = new Button();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBaoCao).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnXuatExcel);
            groupBox1.Controls.Add(btnThongKe);
            groupBox1.Controls.Add(cboNhomTheo);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(dtpDenNgay);
            groupBox1.Controls.Add(dtpTuNgay);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(12, 43);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1006, 114);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tìm kiếm và lọc";
            // 
            // btnXuatExcel
            // 
            btnXuatExcel.Location = new Point(873, 51);
            btnXuatExcel.Name = "btnXuatExcel";
            btnXuatExcel.Size = new Size(94, 29);
            btnXuatExcel.TabIndex = 9;
            btnXuatExcel.Text = "Xuất Excel";
            btnXuatExcel.UseVisualStyleBackColor = true;
            btnXuatExcel.Click += btnXuatExcel_Click;
            // 
            // btnThongKe
            // 
            btnThongKe.Location = new Point(734, 51);
            btnThongKe.Name = "btnThongKe";
            btnThongKe.Size = new Size(98, 29);
            btnThongKe.TabIndex = 8;
            btnThongKe.Text = "Thống kê";
            btnThongKe.UseVisualStyleBackColor = true;
            btnThongKe.Click += btnThongKe_Click;
            // 
            // cboNhomTheo
            // 
            cboNhomTheo.FormattingEnabled = true;
            cboNhomTheo.Location = new Point(460, 50);
            cboNhomTheo.Name = "cboNhomTheo";
            cboNhomTheo.Size = new Size(220, 28);
            cboNhomTheo.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(460, 27);
            label5.Name = "label5";
            label5.Size = new Size(84, 20);
            label5.TabIndex = 6;
            label5.Text = "Nhóm theo";
            // 
            // dtpDenNgay
            // 
            dtpDenNgay.Location = new Point(227, 50);
            dtpDenNgay.Name = "dtpDenNgay";
            dtpDenNgay.Size = new Size(188, 27);
            dtpDenNgay.TabIndex = 5;
            // 
            // dtpTuNgay
            // 
            dtpTuNgay.Location = new Point(15, 50);
            dtpTuNgay.Name = "dtpTuNgay";
            dtpTuNgay.Size = new Size(188, 27);
            dtpTuNgay.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(227, 27);
            label4.Name = "label4";
            label4.Size = new Size(72, 20);
            label4.TabIndex = 3;
            label4.Text = "Đến ngày";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 27);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 2;
            label3.Text = "Từ ngày";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(261, 31);
            label1.TabIndex = 2;
            label1.Text = "BÁO CÁO DOANH THU";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(lblTongSoHoaDon);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(12, 177);
            panel1.Name = "panel1";
            panel1.Size = new Size(203, 96);
            panel1.TabIndex = 4;
            // 
            // lblTongSoHoaDon
            // 
            lblTongSoHoaDon.AutoSize = true;
            lblTongSoHoaDon.ForeColor = Color.Red;
            lblTongSoHoaDon.Location = new Point(80, 57);
            lblTongSoHoaDon.Name = "lblTongSoHoaDon";
            lblTongSoHoaDon.Size = new Size(50, 20);
            lblTongSoHoaDon.TabIndex = 5;
            lblTongSoHoaDon.Text = "label6";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(25, 13);
            label2.Name = "label2";
            label2.Size = new Size(152, 25);
            label2.TabIndex = 5;
            label2.Text = "Tổng số hóa đơn";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Control;
            panel2.Controls.Add(lblTongTienThuoc);
            panel2.Controls.Add(label8);
            panel2.Location = new Point(280, 177);
            panel2.Name = "panel2";
            panel2.Size = new Size(196, 96);
            panel2.TabIndex = 5;
            // 
            // lblTongTienThuoc
            // 
            lblTongTienThuoc.AutoSize = true;
            lblTongTienThuoc.ForeColor = Color.Red;
            lblTongTienThuoc.Location = new Point(42, 57);
            lblTongTienThuoc.Name = "lblTongTienThuoc";
            lblTongTienThuoc.Size = new Size(50, 20);
            lblTongTienThuoc.TabIndex = 5;
            lblTongTienThuoc.Text = "label7";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(25, 13);
            label8.Name = "label8";
            label8.Size = new Size(145, 25);
            label8.TabIndex = 5;
            label8.Text = "Tổng tiền thuốc";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.Control;
            panel3.Controls.Add(lblTongBHYT);
            panel3.Controls.Add(label10);
            panel3.Location = new Point(547, 177);
            panel3.Name = "panel3";
            panel3.Size = new Size(195, 96);
            panel3.TabIndex = 6;
            // 
            // lblTongBHYT
            // 
            lblTongBHYT.AutoSize = true;
            lblTongBHYT.ForeColor = Color.Red;
            lblTongBHYT.Location = new Point(47, 57);
            lblTongBHYT.Name = "lblTongBHYT";
            lblTongBHYT.Size = new Size(50, 20);
            lblTongBHYT.TabIndex = 5;
            lblTongBHYT.Text = "label9";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(38, 13);
            label10.Name = "label10";
            label10.Size = new Size(112, 25);
            label10.TabIndex = 5;
            label10.Text = "BHYT chi trả";
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.Control;
            panel4.Controls.Add(lblTongBenhNhanTra);
            panel4.Controls.Add(label12);
            panel4.Location = new Point(817, 177);
            panel4.Name = "panel4";
            panel4.Size = new Size(201, 96);
            panel4.TabIndex = 7;
            // 
            // lblTongBenhNhanTra
            // 
            lblTongBenhNhanTra.AutoSize = true;
            lblTongBenhNhanTra.ForeColor = Color.Red;
            lblTongBenhNhanTra.Location = new Point(54, 57);
            lblTongBenhNhanTra.Name = "lblTongBenhNhanTra";
            lblTongBenhNhanTra.Size = new Size(58, 20);
            lblTongBenhNhanTra.TabIndex = 5;
            lblTongBenhNhanTra.Text = "label11";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(41, 13);
            label12.Name = "label12";
            label12.Size = new Size(128, 25);
            label12.TabIndex = 5;
            label12.Text = "Bệnh nhân trả";
            // 
            // dgvBaoCao
            // 
            dgvBaoCao.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBaoCao.BackgroundColor = SystemColors.Control;
            dgvBaoCao.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBaoCao.Columns.AddRange(new DataGridViewColumn[] { colSoLuongHoaDon, colThoiGian, colTienThuoc, colBHYTChiTra, colBenhNhanTra });
            dgvBaoCao.Location = new Point(12, 291);
            dgvBaoCao.Name = "dgvBaoCao";
            dgvBaoCao.RowHeadersVisible = false;
            dgvBaoCao.RowHeadersWidth = 51;
            dgvBaoCao.RowTemplate.Height = 29;
            dgvBaoCao.Size = new Size(1006, 336);
            dgvBaoCao.TabIndex = 8;
            dgvBaoCao.CellDoubleClick += dgvBaoCao_CellDoubleClick;
            // 
            // colSoLuongHoaDon
            // 
            colSoLuongHoaDon.HeaderText = "Số lượng hóa đơn";
            colSoLuongHoaDon.MinimumWidth = 6;
            colSoLuongHoaDon.Name = "colSoLuongHoaDon";
            colSoLuongHoaDon.ReadOnly = true;
            // 
            // colThoiGian
            // 
            colThoiGian.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colThoiGian.HeaderText = "Thời gian";
            colThoiGian.MinimumWidth = 6;
            colThoiGian.Name = "colThoiGian";
            colThoiGian.ReadOnly = true;
            // 
            // colTienThuoc
            // 
            colTienThuoc.HeaderText = "Tiền thuốc";
            colTienThuoc.MinimumWidth = 6;
            colTienThuoc.Name = "colTienThuoc";
            colTienThuoc.ReadOnly = true;
            // 
            // colBHYTChiTra
            // 
            colBHYTChiTra.HeaderText = "BHYT chi trả";
            colBHYTChiTra.MinimumWidth = 6;
            colBHYTChiTra.Name = "colBHYTChiTra";
            colBHYTChiTra.ReadOnly = true;
            // 
            // colBenhNhanTra
            // 
            colBenhNhanTra.HeaderText = "Bệnh nhân trả";
            colBenhNhanTra.MinimumWidth = 6;
            colBenhNhanTra.Name = "colBenhNhanTra";
            colBenhNhanTra.ReadOnly = true;
            // 
            // btnXemHoaDon
            // 
            btnXemHoaDon.Location = new Point(656, 653);
            btnXemHoaDon.Name = "btnXemHoaDon";
            btnXemHoaDon.Size = new Size(199, 40);
            btnXemHoaDon.TabIndex = 9;
            btnXemHoaDon.Text = "Xem thông tin hóa đơn";
            btnXemHoaDon.UseVisualStyleBackColor = true;
            // 
            // btnInBaoCao
            // 
            btnInBaoCao.Location = new Point(881, 653);
            btnInBaoCao.Name = "btnInBaoCao";
            btnInBaoCao.Size = new Size(123, 40);
            btnInBaoCao.TabIndex = 10;
            btnInBaoCao.Text = "In báo cáo";
            btnInBaoCao.UseVisualStyleBackColor = true;
            btnInBaoCao.Click += btnInBaoCao_Click;
            // 
            // UCBaoCaoDoanhThu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnInBaoCao);
            Controls.Add(btnXemHoaDon);
            Controls.Add(dgvBaoCao);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "UCBaoCaoDoanhThu";
            Size = new Size(1204, 715);
            Load += UCBaoCaoDoanhThu_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBaoCao).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnXuatExcel;
        private Button btnThongKe;
        private ComboBox cboNhomTheo;
        private Label label5;
        private DateTimePicker dtpDenNgay;
        private DateTimePicker dtpTuNgay;
        private Label label4;
        private Label label3;
        private Label label1;
        private Panel panel1;
        private Label label2;
        private Label lblTongSoHoaDon;
        private Panel panel2;
        private Label lblTongTienThuoc;
        private Label label8;
        private Panel panel3;
        private Label lblTongBHYT;
        private Label label10;
        private Panel panel4;
        private Label lblTongBenhNhanTra;
        private Label label12;
        private DataGridView dgvBaoCao;
        private Button btnXemHoaDon;
        private Button btnInBaoCao;
        private DataGridViewTextBoxColumn colSoLuongHoaDon;
        private DataGridViewTextBoxColumn colThoiGian;
        private DataGridViewTextBoxColumn colTienThuoc;
        private DataGridViewTextBoxColumn colBHYTChiTra;
        private DataGridViewTextBoxColumn colBenhNhanTra;
    }
}
