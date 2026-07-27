namespace QLQuayThuoc
{
    partial class UCTonKhoQuay
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
            btnLamMoi = new Button();
            btnTim = new Button();
            cbTrangThai = new ComboBox();
            cbHanDung = new ComboBox();
            txtTimKiem = new TextBox();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            dgv = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            label4 = new Label();
            panel9 = new Panel();
            lblPhieuChoDuyet = new Label();
            label8 = new Label();
            panel8 = new Panel();
            lblThuocSapHetHan = new Label();
            label7 = new Label();
            panel7 = new Panel();
            lblThuocSapHet = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            panel9.SuspendLayout();
            panel8.SuspendLayout();
            panel7.SuspendLayout();
            SuspendLayout();
            // 
            // btnLamMoi
            // 
            btnLamMoi.Location = new Point(633, 150);
            btnLamMoi.Margin = new Padding(2);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(87, 34);
            btnLamMoi.TabIndex = 44;
            btnLamMoi.Text = "Làm mới ";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnTim
            // 
            btnTim.Location = new Point(553, 150);
            btnTim.Margin = new Padding(2);
            btnTim.Name = "btnTim";
            btnTim.Size = new Size(66, 34);
            btnTim.TabIndex = 43;
            btnTim.Text = "Tìm";
            btnTim.UseVisualStyleBackColor = true;
            btnTim.Click += btnTim_Click;
            // 
            // cbTrangThai
            // 
            cbTrangThai.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            cbTrangThai.FormattingEnabled = true;
            cbTrangThai.Location = new Point(394, 149);
            cbTrangThai.Margin = new Padding(2);
            cbTrangThai.Name = "cbTrangThai";
            cbTrangThai.Size = new Size(146, 38);
            cbTrangThai.TabIndex = 42;
            // 
            // cbHanDung
            // 
            cbHanDung.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            cbHanDung.FormattingEnabled = true;
            cbHanDung.Location = new Point(228, 149);
            cbHanDung.Margin = new Padding(2);
            cbHanDung.Name = "cbHanDung";
            cbHanDung.Size = new Size(154, 38);
            cbHanDung.TabIndex = 41;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(9, 149);
            txtTimKiem.Margin = new Padding(2);
            txtTimKiem.Multiline = true;
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(206, 38);
            txtTimKiem.TabIndex = 40;
            txtTimKiem.KeyDown += txtTimKiem_KeyDown;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(394, 126);
            label15.Margin = new Padding(2, 0, 2, 0);
            label15.Name = "label15";
            label15.Size = new Size(75, 20);
            label15.TabIndex = 39;
            label15.Text = "Trạng thái";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(228, 126);
            label14.Margin = new Padding(2, 0, 2, 0);
            label14.Name = "label14";
            label14.Size = new Size(78, 20);
            label14.TabIndex = 38;
            label14.Text = "Hạn dùng ";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(9, 126);
            label13.Margin = new Padding(2, 0, 2, 0);
            label13.Name = "label13";
            label13.Size = new Size(75, 20);
            label13.TabIndex = 37;
            label13.Text = "Tìm thuốc";
            // 
            // dgv
            // 
            dgv.BackgroundColor = SystemColors.ButtonFace;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7 });
            dgv.GridColor = SystemColors.ButtonShadow;
            dgv.Location = new Point(9, 191);
            dgv.Margin = new Padding(2);
            dgv.Name = "dgv";
            dgv.RowHeadersVisible = false;
            dgv.RowHeadersWidth = 72;
            dgv.RowTemplate.Height = 37;
            dgv.Size = new Size(925, 294);
            dgv.TabIndex = 36;
            // 
            // Column1
            // 
            Column1.HeaderText = "Mã thuốc";
            Column1.MinimumWidth = 9;
            Column1.Name = "Column1";
            Column1.Width = 150;
            // 
            // Column2
            // 
            Column2.HeaderText = "Tên thuốc";
            Column2.MinimumWidth = 9;
            Column2.Name = "Column2";
            Column2.Width = 300;
            // 
            // Column3
            // 
            Column3.HeaderText = "Số lô";
            Column3.MinimumWidth = 9;
            Column3.Name = "Column3";
            Column3.Width = 200;
            // 
            // Column4
            // 
            Column4.HeaderText = "Ngày hết hạn";
            Column4.MinimumWidth = 9;
            Column4.Name = "Column4";
            Column4.Width = 250;
            // 
            // Column5
            // 
            Column5.HeaderText = "Tồn quầy";
            Column5.MinimumWidth = 9;
            Column5.Name = "Column5";
            Column5.Width = 130;
            // 
            // Column6
            // 
            Column6.HeaderText = "Đơn vị";
            Column6.MinimumWidth = 9;
            Column6.Name = "Column6";
            Column6.Width = 150;
            // 
            // Column7
            // 
            Column7.HeaderText = "Trạng thái ";
            Column7.MinimumWidth = 9;
            Column7.Name = "Column7";
            Column7.Width = 205;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.1428576F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(9, 11);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(140, 25);
            label4.TabIndex = 31;
            label4.Text = "Tồn kho quầy ";
            // 
            // panel9
            // 
            panel9.BackColor = Color.Silver;
            panel9.Controls.Add(lblPhieuChoDuyet);
            panel9.Controls.Add(label8);
            panel9.Location = new Point(616, 39);
            panel9.Margin = new Padding(2);
            panel9.Name = "panel9";
            panel9.Size = new Size(250, 75);
            panel9.TabIndex = 48;
            // 
            // lblPhieuChoDuyet
            // 
            lblPhieuChoDuyet.AutoSize = true;
            lblPhieuChoDuyet.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblPhieuChoDuyet.ForeColor = Color.IndianRed;
            lblPhieuChoDuyet.Location = new Point(119, 41);
            lblPhieuChoDuyet.Margin = new Padding(2, 0, 2, 0);
            lblPhieuChoDuyet.Name = "lblPhieuChoDuyet";
            lblPhieuChoDuyet.Size = new Size(69, 23);
            lblPhieuChoDuyet.TabIndex = 1;
            lblPhieuChoDuyet.Text = "label12";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(71, 10);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(118, 20);
            label8.TabIndex = 0;
            label8.Text = "Phiếu chờ duyệt ";
            // 
            // panel8
            // 
            panel8.BackColor = Color.Silver;
            panel8.Controls.Add(lblThuocSapHetHan);
            panel8.Controls.Add(label7);
            panel8.Location = new Point(327, 39);
            panel8.Margin = new Padding(2);
            panel8.Name = "panel8";
            panel8.Size = new Size(241, 75);
            panel8.TabIndex = 47;
            // 
            // lblThuocSapHetHan
            // 
            lblThuocSapHetHan.AutoSize = true;
            lblThuocSapHetHan.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblThuocSapHetHan.ForeColor = Color.IndianRed;
            lblThuocSapHetHan.Location = new Point(117, 41);
            lblThuocSapHetHan.Margin = new Padding(2, 0, 2, 0);
            lblThuocSapHetHan.Name = "lblThuocSapHetHan";
            lblThuocSapHetHan.Size = new Size(69, 23);
            lblThuocSapHetHan.TabIndex = 1;
            lblThuocSapHetHan.Text = "label11";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(57, 10);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(129, 20);
            label7.TabIndex = 0;
            label7.Text = "Thuốc sắp hết hạn";
            // 
            // panel7
            // 
            panel7.BackColor = Color.Silver;
            panel7.Controls.Add(lblThuocSapHet);
            panel7.Controls.Add(label6);
            panel7.Location = new Point(45, 39);
            panel7.Margin = new Padding(2);
            panel7.Name = "panel7";
            panel7.Size = new Size(238, 75);
            panel7.TabIndex = 46;
            // 
            // lblThuocSapHet
            // 
            lblThuocSapHet.AutoSize = true;
            lblThuocSapHet.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblThuocSapHet.ForeColor = Color.IndianRed;
            lblThuocSapHet.Location = new Point(112, 41);
            lblThuocSapHet.Margin = new Padding(2, 0, 2, 0);
            lblThuocSapHet.Name = "lblThuocSapHet";
            lblThuocSapHet.Size = new Size(69, 23);
            lblThuocSapHet.TabIndex = 4;
            lblThuocSapHet.Text = "label10";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(67, 10);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(105, 20);
            label6.TabIndex = 0;
            label6.Text = "Thuốc sắp hết ";
            // 
            // UCTonKhoQuay
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel9);
            Controls.Add(panel8);
            Controls.Add(panel7);
            Controls.Add(btnLamMoi);
            Controls.Add(btnTim);
            Controls.Add(cbTrangThai);
            Controls.Add(cbHanDung);
            Controls.Add(txtTimKiem);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(dgv);
            Controls.Add(label4);
            Margin = new Padding(2);
            Name = "UCTonKhoQuay";
            Size = new Size(940, 594);
            Load += UCTonKhoQuay_Load;
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnLamMoi;
        private Button btnTim;
        private ComboBox cbTrangThai;
        private ComboBox cbHanDung;
        private TextBox txtTimKiem;
        private Label label15;
        private Label label14;
        private Label label13;
        private DataGridView dgv;
        private Label label4;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private Panel panel9;
        private Label lblPhieuChoDuyet;
        private Label label8;
        private Panel panel8;
        private Label lblThuocSapHetHan;
        private Label label7;
        private Panel panel7;
        private Label lblThuocSapHet;
        private Label label6;
    }
}
