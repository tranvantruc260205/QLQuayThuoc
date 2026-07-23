namespace QLQuayThuoc
{
    partial class UserControlThongKeDoanhThu
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
            pnContent = new Panel();
            grbHinhThuc = new GroupBox();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            colHinhThuc = new DataGridViewTextBoxColumn();
            colSoHD = new DataGridViewTextBoxColumn();
            colBNTra = new DataGridViewTextBoxColumn();
            colTongTien = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            panel5 = new Panel();
            lblsohoadon = new Label();
            lblSoHoaDonTitle = new Label();
            panel4 = new Panel();
            lblbenhnhan = new Label();
            lblBenhNhanTitle = new Label();
            panel3 = new Panel();
            panel2 = new Panel();
            lblbhyt = new Label();
            lblbhytTitle = new Label();
            panel10 = new Panel();
            lblTongTien = new Label();
            lblTongTienTitle = new Label();
            btnExcel = new Button();
            btnThongKe = new Button();
            cboHinhThuc = new ComboBox();
            dtpDenNgay = new DateTimePicker();
            dtpTuNgay = new DateTimePicker();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            lblMoTa = new Label();
            lblTitle = new Label();
            pnContent.SuspendLayout();
            grbHinhThuc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            panel10.SuspendLayout();
            SuspendLayout();
            // 
            // pnContent
            // 
            pnContent.Controls.Add(grbHinhThuc);
            pnContent.Controls.Add(groupBox1);
            pnContent.Controls.Add(panel5);
            pnContent.Controls.Add(panel4);
            pnContent.Controls.Add(panel3);
            pnContent.Controls.Add(panel2);
            pnContent.Controls.Add(panel10);
            pnContent.Controls.Add(btnExcel);
            pnContent.Controls.Add(btnThongKe);
            pnContent.Controls.Add(cboHinhThuc);
            pnContent.Controls.Add(dtpDenNgay);
            pnContent.Controls.Add(dtpTuNgay);
            pnContent.Controls.Add(label3);
            pnContent.Controls.Add(label2);
            pnContent.Controls.Add(label1);
            pnContent.Controls.Add(lblMoTa);
            pnContent.Controls.Add(lblTitle);
            pnContent.Dock = DockStyle.Fill;
            pnContent.Location = new Point(0, 0);
            pnContent.Name = "pnContent";
            pnContent.Size = new Size(659, 419);
            pnContent.TabIndex = 3;
            // 
            // grbHinhThuc
            // 
            grbHinhThuc.Controls.Add(button1);
            grbHinhThuc.Controls.Add(dataGridView1);
            grbHinhThuc.Location = new Point(333, 177);
            grbHinhThuc.Name = "grbHinhThuc";
            grbHinhThuc.Size = new Size(291, 178);
            grbHinhThuc.TabIndex = 16;
            grbHinhThuc.TabStop = false;
            grbHinhThuc.Text = "Theo hình thức";
            // 
            // button1
            // 
            button1.Location = new Point(131, 146);
            button1.Name = "button1";
            button1.Size = new Size(145, 25);
            button1.TabIndex = 1;
            button1.Text = "Xem danh sách hóa đơn";
            button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colHinhThuc, colSoHD, colBNTra, colTongTien });
            dataGridView1.Location = new Point(17, 22);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(259, 118);
            dataGridView1.TabIndex = 0;
            // 
            // colHinhThuc
            // 
            colHinhThuc.HeaderText = "Hình thức";
            colHinhThuc.Name = "colHinhThuc";
            colHinhThuc.ReadOnly = true;
            // 
            // colSoHD
            // 
            colSoHD.HeaderText = "Số HĐ";
            colSoHD.Name = "colSoHD";
            colSoHD.ReadOnly = true;
            // 
            // colBNTra
            // 
            colBNTra.HeaderText = "BN trả";
            colBNTra.Name = "colBNTra";
            colBNTra.ReadOnly = true;
            // 
            // colTongTien
            // 
            colTongTien.HeaderText = "Tổng tiền";
            colTongTien.Name = "colTongTien";
            colTongTien.ReadOnly = true;
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(12, 177);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(291, 178);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            groupBox1.Text = " Doanh thu theo ngày";
            // 
            // panel5
            // 
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(lblsohoadon);
            panel5.Controls.Add(lblSoHoaDonTitle);
            panel5.Location = new Point(489, 111);
            panel5.Name = "panel5";
            panel5.Size = new Size(150, 60);
            panel5.TabIndex = 14;
            // 
            // lblsohoadon
            // 
            lblsohoadon.AutoSize = true;
            lblsohoadon.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblsohoadon.Location = new Point(56, 26);
            lblsohoadon.Name = "lblsohoadon";
            lblsohoadon.Size = new Size(78, 30);
            lblsohoadon.TabIndex = 1;
            lblsohoadon.Text = "lable 6";
            // 
            // lblSoHoaDonTitle
            // 
            lblSoHoaDonTitle.AutoSize = true;
            lblSoHoaDonTitle.Location = new Point(14, 0);
            lblSoHoaDonTitle.Name = "lblSoHoaDonTitle";
            lblSoHoaDonTitle.Size = new Size(67, 15);
            lblSoHoaDonTitle.TabIndex = 0;
            lblSoHoaDonTitle.Text = "Số hóa đơn";
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(lblbenhnhan);
            panel4.Controls.Add(lblBenhNhanTitle);
            panel4.Location = new Point(327, 111);
            panel4.Name = "panel4";
            panel4.Size = new Size(150, 60);
            panel4.TabIndex = 13;
            // 
            // lblbenhnhan
            // 
            lblbenhnhan.AutoSize = true;
            lblbenhnhan.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblbenhnhan.Location = new Point(51, 26);
            lblbenhnhan.Name = "lblbenhnhan";
            lblbenhnhan.Size = new Size(78, 30);
            lblbenhnhan.TabIndex = 1;
            lblbenhnhan.Text = "lable 5";
            // 
            // lblBenhNhanTitle
            // 
            lblBenhNhanTitle.AutoSize = true;
            lblBenhNhanTitle.Location = new Point(5, 0);
            lblBenhNhanTitle.Name = "lblBenhNhanTitle";
            lblBenhNhanTitle.Size = new Size(81, 15);
            lblBenhNhanTitle.TabIndex = 0;
            lblBenhNhanTitle.Text = "Bệnh nhân trả";
            // 
            // panel3
            // 
            panel3.Location = new Point(706, 138);
            panel3.Name = "panel3";
            panel3.Size = new Size(109, 100);
            panel3.TabIndex = 12;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(lblbhyt);
            panel2.Controls.Add(lblbhytTitle);
            panel2.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            panel2.Location = new Point(165, 111);
            panel2.Name = "panel2";
            panel2.Size = new Size(150, 60);
            panel2.TabIndex = 11;
            // 
            // lblbhyt
            // 
            lblbhyt.AutoSize = true;
            lblbhyt.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblbhyt.Location = new Point(46, 23);
            lblbhyt.Name = "lblbhyt";
            lblbhyt.Size = new Size(78, 30);
            lblbhyt.TabIndex = 1;
            lblbhyt.Text = "label 4";
            // 
            // lblbhytTitle
            // 
            lblbhytTitle.AutoSize = true;
            lblbhytTitle.Location = new Point(8, 0);
            lblbhytTitle.Name = "lblbhytTitle";
            lblbhytTitle.Size = new Size(93, 13);
            lblbhytTitle.TabIndex = 0;
            lblbhytTitle.Text = "BHYT thanh toán";
            // 
            // panel10
            // 
            panel10.BorderStyle = BorderStyle.FixedSingle;
            panel10.Controls.Add(lblTongTien);
            panel10.Controls.Add(lblTongTienTitle);
            panel10.Location = new Point(3, 111);
            panel10.Name = "panel10";
            panel10.Size = new Size(150, 60);
            panel10.TabIndex = 10;
            // 
            // lblTongTien
            // 
            lblTongTien.AutoSize = true;
            lblTongTien.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblTongTien.Location = new Point(48, 21);
            lblTongTien.Name = "lblTongTien";
            lblTongTien.Size = new Size(72, 30);
            lblTongTien.TabIndex = 1;
            lblTongTien.Text = "label3";
            // 
            // lblTongTienTitle
            // 
            lblTongTienTitle.AutoSize = true;
            lblTongTienTitle.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblTongTienTitle.Location = new Point(2, 0);
            lblTongTienTitle.Name = "lblTongTienTitle";
            lblTongTienTitle.Size = new Size(90, 13);
            lblTongTienTitle.TabIndex = 0;
            lblTongTienTitle.Text = "Tổng tiền thuốc";
            // 
            // btnExcel
            // 
            btnExcel.Location = new Point(545, 80);
            btnExcel.Name = "btnExcel";
            btnExcel.Size = new Size(94, 25);
            btnExcel.TabIndex = 9;
            btnExcel.Text = "Xuất Excel";
            btnExcel.UseVisualStyleBackColor = true;
            // 
            // btnThongKe
            // 
            btnThongKe.Location = new Point(450, 80);
            btnThongKe.Name = "btnThongKe";
            btnThongKe.Size = new Size(89, 25);
            btnThongKe.TabIndex = 8;
            btnThongKe.Text = "Xem thống kê";
            btnThongKe.UseVisualStyleBackColor = true;
            // 
            // cboHinhThuc
            // 
            cboHinhThuc.FormattingEnabled = true;
            cboHinhThuc.Location = new Point(329, 82);
            cboHinhThuc.Name = "cboHinhThuc";
            cboHinhThuc.Size = new Size(115, 23);
            cboHinhThuc.TabIndex = 7;
            // 
            // dtpDenNgay
            // 
            dtpDenNgay.Location = new Point(166, 82);
            dtpDenNgay.Name = "dtpDenNgay";
            dtpDenNgay.Size = new Size(155, 23);
            dtpDenNgay.TabIndex = 6;
            // 
            // dtpTuNgay
            // 
            dtpTuNgay.CalendarFont = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dtpTuNgay.Location = new Point(3, 82);
            dtpTuNgay.Name = "dtpTuNgay";
            dtpTuNgay.Size = new Size(155, 23);
            dtpTuNgay.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(333, 64);
            label3.Name = "label3";
            label3.Size = new Size(62, 15);
            label3.TabIndex = 4;
            label3.Text = "Hình thức";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(172, 64);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 3;
            label2.Text = "Đến ngày";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(6, 64);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 2;
            label1.Text = "Từ ngày";
            // 
            // lblMoTa
            // 
            lblMoTa.AutoSize = true;
            lblMoTa.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblMoTa.ForeColor = SystemColors.GrayText;
            lblMoTa.Location = new Point(12, 33);
            lblMoTa.Name = "lblMoTa";
            lblMoTa.Size = new Size(255, 15);
            lblMoTa.TabIndex = 1;
            lblMoTa.Text = "Tổng hợp hóa đơn, BHYT và tiền bệnh nhân trả";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.Location = new Point(6, 3);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(215, 30);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Thống kê doanh thu";
            // 
            // UserControlThongKeDoanhThu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnContent);
            Name = "UserControlThongKeDoanhThu";
            Size = new Size(659, 419);
            pnContent.ResumeLayout(false);
            pnContent.PerformLayout();
            grbHinhThuc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnContent;
        private GroupBox grbHinhThuc;
        private Button button1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn colHinhThuc;
        private DataGridViewTextBoxColumn colSoHD;
        private DataGridViewTextBoxColumn colBNTra;
        private DataGridViewTextBoxColumn colTongTien;
        private GroupBox groupBox1;
        private Panel panel5;
        private Label lblsohoadon;
        private Label lblSoHoaDonTitle;
        private Panel panel4;
        private Label lblbenhnhan;
        private Label lblBenhNhanTitle;
        private Panel panel3;
        private Panel panel2;
        private Label lblbhyt;
        private Label lblbhytTitle;
        private Panel panel10;
        private Label lblTongTien;
        private Label lblTongTienTitle;
        private Button btnExcel;
        private Button btnThongKe;
        private ComboBox cboHinhThuc;
        private DateTimePicker dtpDenNgay;
        private DateTimePicker dtpTuNgay;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label lblMoTa;
        private Label lblTitle;
    }
}
