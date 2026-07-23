namespace QLQuayThuoc
{
    partial class UserControlHoaDon
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
            lblTitle = new Label();
            lblMoTa = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtTimKiem = new TextBox();
            dtpTuNgay = new DateTimePicker();
            dtpDenNgay = new DateTimePicker();
            cboHinhThuc = new ComboBox();
            cboTrangThai = new ComboBox();
            btnTim = new Button();
            dataGridView1 = new DataGridView();
            MaHD = new DataGridViewTextBoxColumn();
            Ngay = new DataGridViewTextBoxColumn();
            BenhNhan = new DataGridViewTextBoxColumn();
            TongTien = new DataGridViewTextBoxColumn();
            BHYT = new DataGridViewTextBoxColumn();
            BNTra = new DataGridViewTextBoxColumn();
            HinhThuc = new DataGridViewTextBoxColumn();
            TrangThai = new DataGridViewTextBoxColumn();
            btnChiTiet = new Button();
            btnInLai = new Button();
            btnHuy = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.Location = new Point(12, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(200, 32);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Tra cứu hóa đơn";
            // 
            // lblMoTa
            // 
            lblMoTa.AutoSize = true;
            lblMoTa.Location = new Point(12, 52);
            lblMoTa.Name = "lblMoTa";
            lblMoTa.Size = new Size(330, 15);
            lblMoTa.TabIndex = 1;
            lblMoTa.Text = "Tìm theo mã hóa đơn, mã đơn, bệnh nhân hoặc nội dung QR";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 105);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 2;
            label1.Text = "Tìm kiếm";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(156, 105);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 3;
            label2.Text = "Từ ngày";
            // 
            // label3
            // 
            label3.Location = new Point(403, 105);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 4;
            label3.Text = "Đến ngày";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(652, 105);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 5;
            label4.Text = "Hình thức";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(818, 105);
            label5.Name = "label5";
            label5.Size = new Size(59, 15);
            label5.TabIndex = 6;
            label5.Text = "Trạng thái";
            label5.Click += label5_Click;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(9, 123);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(100, 23);
            txtTimKiem.TabIndex = 7;
            // 
            // dtpTuNgay
            // 
            dtpTuNgay.Location = new Point(156, 123);
            dtpTuNgay.Name = "dtpTuNgay";
            dtpTuNgay.Size = new Size(200, 23);
            dtpTuNgay.TabIndex = 8;
            // 
            // dtpDenNgay
            // 
            dtpDenNgay.Location = new Point(403, 123);
            dtpDenNgay.Name = "dtpDenNgay";
            dtpDenNgay.Size = new Size(200, 23);
            dtpDenNgay.TabIndex = 9;
            // 
            // cboHinhThuc
            // 
            cboHinhThuc.FormattingEnabled = true;
            cboHinhThuc.Location = new Point(650, 123);
            cboHinhThuc.Name = "cboHinhThuc";
            cboHinhThuc.Size = new Size(121, 23);
            cboHinhThuc.TabIndex = 10;
            // 
            // cboTrangThai
            // 
            cboTrangThai.FormattingEnabled = true;
            cboTrangThai.Location = new Point(818, 123);
            cboTrangThai.Name = "cboTrangThai";
            cboTrangThai.Size = new Size(140, 23);
            cboTrangThai.TabIndex = 11;
            // 
            // btnTim
            // 
            btnTim.Location = new Point(1005, 121);
            btnTim.Name = "btnTim";
            btnTim.Size = new Size(70, 32);
            btnTim.TabIndex = 12;
            btnTim.Text = "Tìm";
            btnTim.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { MaHD, Ngay, BenhNhan, TongTien, BHYT, BNTra, HinhThuc, TrangThai });
            dataGridView1.Location = new Point(10, 180);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1098, 360);
            dataGridView1.TabIndex = 13;
            // 
            // MaHD
            // 
            MaHD.HeaderText = "Mã HD";
            MaHD.Name = "MaHD";
            // 
            // Ngay
            // 
            Ngay.HeaderText = "Ngày";
            Ngay.Name = "Ngay";
            // 
            // BenhNhan
            // 
            BenhNhan.HeaderText = "Bệnh nhân";
            BenhNhan.Name = "BenhNhan";
            // 
            // TongTien
            // 
            TongTien.HeaderText = "Tổng tiền";
            TongTien.Name = "TongTien";
            // 
            // BHYT
            // 
            BHYT.HeaderText = "BHYT";
            BHYT.Name = "BHYT";
            // 
            // BNTra
            // 
            BNTra.HeaderText = "BN trả";
            BNTra.Name = "BNTra";
            // 
            // HinhThuc
            // 
            HinhThuc.HeaderText = "Hình Thức";
            HinhThuc.Name = "HinhThuc";
            // 
            // TrangThai
            // 
            TrangThai.HeaderText = "Trạng Thái";
            TrangThai.Name = "TrangThai";
            // 
            // btnChiTiet
            // 
            btnChiTiet.Location = new Point(751, 558);
            btnChiTiet.Name = "btnChiTiet";
            btnChiTiet.Size = new Size(95, 23);
            btnChiTiet.TabIndex = 14;
            btnChiTiet.Text = "Xem chi tiết...";
            btnChiTiet.UseVisualStyleBackColor = true;
            // 
            // btnInLai
            // 
            btnInLai.Location = new Point(883, 558);
            btnInLai.Name = "btnInLai";
            btnInLai.Size = new Size(75, 23);
            btnInLai.TabIndex = 15;
            btnInLai.Text = "In lại";
            btnInLai.UseVisualStyleBackColor = true;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(986, 558);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(99, 23);
            btnHuy.TabIndex = 16;
            btnHuy.Text = "Hủy hóa đơn";
            btnHuy.UseVisualStyleBackColor = true;
            // 
            // UserControlHoaDon
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnHuy);
            Controls.Add(btnInLai);
            Controls.Add(btnChiTiet);
            Controls.Add(dataGridView1);
            Controls.Add(btnTim);
            Controls.Add(cboTrangThai);
            Controls.Add(cboHinhThuc);
            Controls.Add(dtpDenNgay);
            Controls.Add(dtpTuNgay);
            Controls.Add(txtTimKiem);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblMoTa);
            Controls.Add(lblTitle);
            Name = "UserControlHoaDon";
            Size = new Size(1118, 620);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblMoTa;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtTimKiem;
        private DateTimePicker dtpTuNgay;
        private DateTimePicker dtpDenNgay;
        private ComboBox cboHinhThuc;
        private ComboBox cboTrangThai;
        private Button btnTim;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn MaHD;
        private DataGridViewTextBoxColumn Ngay;
        private DataGridViewTextBoxColumn BenhNhan;
        private DataGridViewTextBoxColumn TongTien;
        private DataGridViewTextBoxColumn BHYT;
        private DataGridViewTextBoxColumn BNTra;
        private DataGridViewTextBoxColumn HinhThuc;
        private DataGridViewTextBoxColumn TrangThai;
        private Button btnChiTiet;
        private Button btnInLai;
        private Button btnHuy;
    }
}
