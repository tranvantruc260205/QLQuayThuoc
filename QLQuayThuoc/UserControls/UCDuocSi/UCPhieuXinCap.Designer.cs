namespace QLQuayThuoc
{
    partial class UCPhieuXinCap
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
            groupBox2 = new GroupBox();
            txtLyDo = new RichTextBox();
            btnGuiDuyet = new Button();
            btnXoaDong = new Button();
            btnThemThuoc = new Button();
            dgv2 = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            c = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            label6 = new Label();
            label5 = new Label();
            dtpNgayLap = new DateTimePicker();
            groupBox1 = new GroupBox();
            dgv1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            btnTaoPhieuMoi = new Button();
            label13 = new Label();
            btnHuy = new Button();
            txtTimKiem = new TextBox();
            btnLoc = new Button();
            label15 = new Label();
            cbTrangThai = new ComboBox();
            label4 = new Label();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv2).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv1).BeginInit();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtLyDo);
            groupBox2.Controls.Add(btnGuiDuyet);
            groupBox2.Controls.Add(btnXoaDong);
            groupBox2.Controls.Add(btnThemThuoc);
            groupBox2.Controls.Add(dgv2);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(dtpNgayLap);
            groupBox2.Location = new Point(479, 26);
            groupBox2.Margin = new Padding(2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(2);
            groupBox2.Size = new Size(457, 515);
            groupBox2.TabIndex = 23;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chi tiết phiếu ";
            // 
            // txtLyDo
            // 
            txtLyDo.Location = new Point(169, 35);
            txtLyDo.Name = "txtLyDo";
            txtLyDo.Size = new Size(274, 56);
            txtLyDo.TabIndex = 16;
            txtLyDo.Text = "";
            // 
            // btnGuiDuyet
            // 
            btnGuiDuyet.Location = new Point(324, 415);
            btnGuiDuyet.Margin = new Padding(2);
            btnGuiDuyet.Name = "btnGuiDuyet";
            btnGuiDuyet.Size = new Size(119, 35);
            btnGuiDuyet.TabIndex = 15;
            btnGuiDuyet.Text = "Gửi duyệt";
            btnGuiDuyet.UseVisualStyleBackColor = true;
            btnGuiDuyet.Click += btnGuiDuyet_Click;
            // 
            // btnXoaDong
            // 
            btnXoaDong.Location = new Point(143, 96);
            btnXoaDong.Margin = new Padding(2);
            btnXoaDong.Name = "btnXoaDong";
            btnXoaDong.Size = new Size(102, 31);
            btnXoaDong.TabIndex = 9;
            btnXoaDong.Text = "Xóa dòng ";
            btnXoaDong.UseVisualStyleBackColor = true;
            btnXoaDong.Click += btnXoaDong_Click;
            // 
            // btnThemThuoc
            // 
            btnThemThuoc.Location = new Point(13, 96);
            btnThemThuoc.Margin = new Padding(2);
            btnThemThuoc.Name = "btnThemThuoc";
            btnThemThuoc.Size = new Size(102, 31);
            btnThemThuoc.TabIndex = 8;
            btnThemThuoc.Text = "Thêm thuốc";
            btnThemThuoc.UseVisualStyleBackColor = true;
            btnThemThuoc.Click += btnThemThuoc_Click;
            // 
            // dgv2
            // 
            dgv2.BackgroundColor = SystemColors.ButtonFace;
            dgv2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv2.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, Column5, c, Column2, Column3 });
            dgv2.GridColor = SystemColors.ButtonShadow;
            dgv2.Location = new Point(2, 140);
            dgv2.Margin = new Padding(2);
            dgv2.Name = "dgv2";
            dgv2.RowHeadersVisible = false;
            dgv2.RowHeadersWidth = 72;
            dgv2.RowTemplate.Height = 37;
            dgv2.Size = new Size(455, 259);
            dgv2.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Thuốc";
            dataGridViewTextBoxColumn1.MinimumWidth = 9;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Width = 200;
            // 
            // Column5
            // 
            Column5.HeaderText = "Tồn quầy";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 125;
            // 
            // c
            // 
            c.HeaderText = "SL yêu cầu";
            c.MinimumWidth = 9;
            c.Name = "c";
            c.Width = 155;
            // 
            // Column2
            // 
            Column2.HeaderText = "SL duyệt";
            Column2.MinimumWidth = 9;
            Column2.Name = "Column2";
            Column2.Width = 140;
            // 
            // Column3
            // 
            Column3.HeaderText = "Ghi chú";
            Column3.MinimumWidth = 9;
            Column3.Name = "Column3";
            Column3.Width = 190;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(169, 12);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(44, 20);
            label6.TabIndex = 2;
            label6.Text = "Lý do";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(13, 31);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(69, 20);
            label5.TabIndex = 1;
            label5.Text = "Ngày lập";
            // 
            // dtpNgayLap
            // 
            dtpNgayLap.CalendarFont = new Font("Segoe UI", 11.1428576F, FontStyle.Regular, GraphicsUnit.Point);
            dtpNgayLap.Format = DateTimePickerFormat.Short;
            dtpNgayLap.Location = new Point(13, 59);
            dtpNgayLap.Margin = new Padding(2);
            dtpNgayLap.Name = "dtpNgayLap";
            dtpNgayLap.Size = new Size(149, 27);
            dtpNgayLap.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgv1);
            groupBox1.Controls.Add(btnTaoPhieuMoi);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(btnHuy);
            groupBox1.Controls.Add(txtTimKiem);
            groupBox1.Controls.Add(btnLoc);
            groupBox1.Controls.Add(label15);
            groupBox1.Controls.Add(cbTrangThai);
            groupBox1.Location = new Point(4, 26);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(471, 518);
            groupBox1.TabIndex = 22;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh sách phiếu ";
            // 
            // dgv1
            // 
            dgv1.BackgroundColor = SystemColors.ButtonFace;
            dgv1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column4, Column6, Column7 });
            dgv1.GridColor = SystemColors.ButtonShadow;
            dgv1.Location = new Point(12, 105);
            dgv1.Margin = new Padding(2);
            dgv1.Name = "dgv1";
            dgv1.RowHeadersVisible = false;
            dgv1.RowHeadersWidth = 72;
            dgv1.RowTemplate.Height = 37;
            dgv1.Size = new Size(459, 294);
            dgv1.TabIndex = 6;
            dgv1.SelectionChanged += dgv1_SelectionChanged;
            // 
            // Column1
            // 
            Column1.HeaderText = "Mã phiếu";
            Column1.MinimumWidth = 9;
            Column1.Name = "Column1";
            Column1.Width = 140;
            // 
            // Column4
            // 
            Column4.HeaderText = "Ngày lập";
            Column4.MinimumWidth = 9;
            Column4.Name = "Column4";
            Column4.Width = 210;
            // 
            // Column6
            // 
            Column6.HeaderText = "Lý do";
            Column6.MinimumWidth = 9;
            Column6.Name = "Column6";
            Column6.Width = 150;
            // 
            // Column7
            // 
            Column7.HeaderText = "Trạng thái ";
            Column7.MinimumWidth = 9;
            Column7.Name = "Column7";
            Column7.Width = 190;
            // 
            // btnTaoPhieuMoi
            // 
            btnTaoPhieuMoi.Location = new Point(12, 415);
            btnTaoPhieuMoi.Margin = new Padding(2);
            btnTaoPhieuMoi.Name = "btnTaoPhieuMoi";
            btnTaoPhieuMoi.Size = new Size(135, 35);
            btnTaoPhieuMoi.TabIndex = 15;
            btnTaoPhieuMoi.Text = "Tạo phiếu mới ";
            btnTaoPhieuMoi.UseVisualStyleBackColor = true;
            btnTaoPhieuMoi.Click += btnTaoPhieuMoi_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(12, 31);
            label13.Margin = new Padding(2, 0, 2, 0);
            label13.Name = "label13";
            label13.Size = new Size(75, 20);
            label13.TabIndex = 7;
            label13.Text = "Tìm phiếu";
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(163, 415);
            btnHuy.Margin = new Padding(2);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(110, 35);
            btnHuy.TabIndex = 14;
            btnHuy.Text = "Hủy Phiếu";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(12, 53);
            txtTimKiem.Margin = new Padding(2);
            txtTimKiem.Multiline = true;
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(207, 35);
            txtTimKiem.TabIndex = 10;
            // 
            // btnLoc
            // 
            btnLoc.Location = new Point(399, 52);
            btnLoc.Margin = new Padding(2);
            btnLoc.Name = "btnLoc";
            btnLoc.Size = new Size(61, 35);
            btnLoc.TabIndex = 13;
            btnLoc.Text = "Lọc";
            btnLoc.UseVisualStyleBackColor = true;
            btnLoc.Click += btnLoc_Click;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(236, 31);
            label15.Margin = new Padding(2, 0, 2, 0);
            label15.Name = "label15";
            label15.Size = new Size(75, 20);
            label15.TabIndex = 9;
            label15.Text = "Trạng thái";
            // 
            // cbTrangThai
            // 
            cbTrangThai.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbTrangThai.FormattingEnabled = true;
            cbTrangThai.Location = new Point(236, 53);
            cbTrangThai.Margin = new Padding(2);
            cbTrangThai.Name = "cbTrangThai";
            cbTrangThai.Size = new Size(146, 36);
            cbTrangThai.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.1428576F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(4, 0);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(187, 25);
            label4.TabIndex = 21;
            label4.Text = "Phiếu xin cấp thuốc";
            // 
            // UCPhieuXinCap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label4);
            Margin = new Padding(2);
            Name = "UCPhieuXinCap";
            Size = new Size(940, 546);
            Load += UCPhieuXinCap_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv2).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox2;
        private Button btnXoaDong;
        private Button btnThemThuoc;
        private DataGridView dgv2;
        private Label label6;
        private Label label5;
        private DateTimePicker dtpNgayLap;
        private GroupBox groupBox1;
        private DataGridView dgv1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private Button btnTaoPhieuMoi;
        private Label label13;
        private Button btnHuy;
        private TextBox txtTimKiem;
        private Button btnLoc;
        private Label label15;
        private ComboBox cbTrangThai;
        private Label label4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn c;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private Button btnGuiDuyet;
        private RichTextBox txtLyDo;
    }
}
