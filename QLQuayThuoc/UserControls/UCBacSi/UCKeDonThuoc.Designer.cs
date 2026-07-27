namespace QLQuayThuoc
{
    partial class UCKeDonThuoc
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panelContent = new Panel();
            txtGhiChu = new RichTextBox();
            label2 = new Label();
            txtChanDoan = new TextBox();
            label1 = new Label();
            btnLuuVaIn = new Button();
            btnXoaDong = new Button();
            btnSuaDong = new Button();
            btnThemThuoc = new Button();
            groupBox1 = new GroupBox();
            lblBHYT = new Label();
            lblGioiTinh = new Label();
            lblNgaySinh = new Label();
            lblHoTen = new Label();
            lblMaBN = new Label();
            btnChonBN = new Button();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            dgv = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            label5 = new Label();
            label4 = new Label();
            panelContent.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            SuspendLayout();
            // 
            // panelContent
            // 
            panelContent.BackColor = SystemColors.Window;
            panelContent.Controls.Add(txtGhiChu);
            panelContent.Controls.Add(label2);
            panelContent.Controls.Add(txtChanDoan);
            panelContent.Controls.Add(label1);
            panelContent.Controls.Add(btnLuuVaIn);
            panelContent.Controls.Add(btnXoaDong);
            panelContent.Controls.Add(btnSuaDong);
            panelContent.Controls.Add(btnThemThuoc);
            panelContent.Controls.Add(groupBox1);
            panelContent.Controls.Add(dgv);
            panelContent.Controls.Add(label5);
            panelContent.Controls.Add(label4);
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(0, 0);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(1049, 491);
            panelContent.TabIndex = 4;
            // 
            // txtGhiChu
            // 
            txtGhiChu.Location = new Point(92, 375);
            txtGhiChu.Name = "txtGhiChu";
            txtGhiChu.Size = new Size(510, 68);
            txtGhiChu.TabIndex = 27;
            txtGhiChu.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 378);
            label2.Name = "label2";
            label2.Size = new Size(58, 20);
            label2.TabIndex = 26;
            label2.Text = "Ghi chú";
            // 
            // txtChanDoan
            // 
            txtChanDoan.Location = new Point(92, 144);
            txtChanDoan.Name = "txtChanDoan";
            txtChanDoan.Size = new Size(510, 27);
            txtChanDoan.TabIndex = 25;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 148);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 24;
            label1.Text = "Chẩn đoán";
            // 
            // btnLuuVaIn
            // 
            btnLuuVaIn.Location = new Point(908, 446);
            btnLuuVaIn.Name = "btnLuuVaIn";
            btnLuuVaIn.Size = new Size(114, 29);
            btnLuuVaIn.TabIndex = 23;
            btnLuuVaIn.Text = "Lưu và in đơn";
            btnLuuVaIn.UseVisualStyleBackColor = true;
            btnLuuVaIn.Click += btnLuuVaIn_Click;
            // 
            // btnXoaDong
            // 
            btnXoaDong.Location = new Point(945, 144);
            btnXoaDong.Name = "btnXoaDong";
            btnXoaDong.Size = new Size(94, 29);
            btnXoaDong.TabIndex = 21;
            btnXoaDong.Text = "Xóa dòng";
            btnXoaDong.UseVisualStyleBackColor = true;
            btnXoaDong.Click += btnXoaDong_Click;
            // 
            // btnSuaDong
            // 
            btnSuaDong.Location = new Point(830, 144);
            btnSuaDong.Name = "btnSuaDong";
            btnSuaDong.Size = new Size(94, 29);
            btnSuaDong.TabIndex = 20;
            btnSuaDong.Text = "Sửa dòng";
            btnSuaDong.UseVisualStyleBackColor = true;
            btnSuaDong.Click += btnSuaDong_Click;
            // 
            // btnThemThuoc
            // 
            btnThemThuoc.Location = new Point(691, 144);
            btnThemThuoc.Name = "btnThemThuoc";
            btnThemThuoc.Size = new Size(112, 29);
            btnThemThuoc.TabIndex = 19;
            btnThemThuoc.Text = "Thêm thuốc";
            btnThemThuoc.UseVisualStyleBackColor = true;
            btnThemThuoc.Click += btnThemThuoc_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.Menu;
            groupBox1.Controls.Add(lblBHYT);
            groupBox1.Controls.Add(lblGioiTinh);
            groupBox1.Controls.Add(lblNgaySinh);
            groupBox1.Controls.Add(lblHoTen);
            groupBox1.Controls.Add(lblMaBN);
            groupBox1.Controls.Add(btnChonBN);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Location = new Point(6, 46);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1033, 85);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin bệnh nhân";
            // 
            // lblBHYT
            // 
            lblBHYT.AutoSize = true;
            lblBHYT.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblBHYT.Location = new Point(661, 43);
            lblBHYT.Name = "lblBHYT";
            lblBHYT.Size = new Size(0, 20);
            lblBHYT.TabIndex = 10;
            // 
            // lblGioiTinh
            // 
            lblGioiTinh.AutoSize = true;
            lblGioiTinh.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblGioiTinh.Location = new Point(486, 43);
            lblGioiTinh.Name = "lblGioiTinh";
            lblGioiTinh.Size = new Size(0, 20);
            lblGioiTinh.TabIndex = 9;
            // 
            // lblNgaySinh
            // 
            lblNgaySinh.AutoSize = true;
            lblNgaySinh.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblNgaySinh.Location = new Point(299, 43);
            lblNgaySinh.Name = "lblNgaySinh";
            lblNgaySinh.Size = new Size(0, 20);
            lblNgaySinh.TabIndex = 8;
            // 
            // lblHoTen
            // 
            lblHoTen.AutoSize = true;
            lblHoTen.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblHoTen.Location = new Point(155, 43);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(0, 20);
            lblHoTen.TabIndex = 7;
            // 
            // lblMaBN
            // 
            lblMaBN.AutoSize = true;
            lblMaBN.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblMaBN.Location = new Point(15, 43);
            lblMaBN.Name = "lblMaBN";
            lblMaBN.Size = new Size(0, 20);
            lblMaBN.TabIndex = 6;
            // 
            // btnChonBN
            // 
            btnChonBN.Location = new Point(842, 34);
            btnChonBN.Name = "btnChonBN";
            btnChonBN.Size = new Size(136, 29);
            btnChonBN.TabIndex = 5;
            btnChonBN.Text = "Chọn bệnh nhân";
            btnChonBN.UseVisualStyleBackColor = true;
            btnChonBN.Click += btnChonBN_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(661, 23);
            label10.Name = "label10";
            label10.Size = new Size(70, 20);
            label10.TabIndex = 4;
            label10.Text = "Mã BHYT";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(486, 23);
            label9.Name = "label9";
            label9.Size = new Size(65, 20);
            label9.TabIndex = 3;
            label9.Text = "Giới tính";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(299, 23);
            label8.Name = "label8";
            label8.Size = new Size(74, 20);
            label8.TabIndex = 2;
            label8.Text = "Ngày sinh";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(155, 23);
            label7.Name = "label7";
            label7.Size = new Size(56, 20);
            label7.TabIndex = 1;
            label7.Text = "Họ Tên";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(15, 23);
            label6.Name = "label6";
            label6.Size = new Size(54, 20);
            label6.TabIndex = 0;
            label6.Text = "Mã BN";
            // 
            // dgv
            // 
            dgv.BackgroundColor = SystemColors.Control;
            dgv.BorderStyle = BorderStyle.None;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6 });
            dgv.EnableHeadersVisualStyles = false;
            dgv.GridColor = SystemColors.ControlDarkDark;
            dgv.Location = new Point(0, 179);
            dgv.Name = "dgv";
            dgv.RightToLeft = RightToLeft.No;
            dgv.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgv.RowHeadersVisible = false;
            dgv.RowHeadersWidth = 51;
            dgv.RowTemplate.Height = 29;
            dgv.Size = new Size(1051, 179);
            dgv.TabIndex = 16;
            // 
            // Column1
            // 
            Column1.HeaderText = "Thuốc";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.Width = 300;
            // 
            // Column2
            // 
            Column2.HeaderText = "Số lượng";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "Liều dùng";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 155;
            // 
            // Column4
            // 
            Column4.HeaderText = "Tần suất";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 155;
            // 
            // Column5
            // 
            Column5.HeaderText = "Số ngày";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 125;
            // 
            // Column6
            // 
            Column6.HeaderText = "Ghi chú";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.Width = 150;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(6, 28);
            label5.Name = "label5";
            label5.Size = new Size(196, 15);
            label5.TabIndex = 3;
            label5.Text = "Tạo đơn thuốc và chi tiết đơn thuốc";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(3, 0);
            label4.Name = "label4";
            label4.Size = new Size(140, 28);
            label4.TabIndex = 2;
            label4.Text = "Kê đơn thuốc";
            // 
            // UCKeDonThuoc
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelContent);
            Name = "UCKeDonThuoc";
            Size = new Size(1049, 491);
            panelContent.ResumeLayout(false);
            panelContent.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelContent;
        private Button btnLuuVaIn;
        private Button btnXoaDong;
        private Button btnSuaDong;
        private Button btnThemThuoc;
        private GroupBox groupBox1;
        private Label lblBHYT;
        private Label lblGioiTinh;
        private Label lblNgaySinh;
        private Label lblHoTen;
        private Label lblMaBN;
        private Button btnChonBN;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private DataGridView dgv;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private Label label5;
        private Label label4;
        private Label label1;
        private TextBox txtChanDoan;
        private Label label2;
        private RichTextBox txtGhiChu;
    }
}
