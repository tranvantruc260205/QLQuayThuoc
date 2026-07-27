namespace QLQuayThuoc
{
    partial class FormDuocSi
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            lblDuocSi = new Label();
            panel3 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            panel4 = new Panel();
            btnDangXuat = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label3 = new Label();
            panel5 = new Panel();
            panel6 = new Panel();
            groupBox1 = new GroupBox();
            dgv = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            panel9 = new Panel();
            lblPhieuChoDuyet = new Label();
            label8 = new Label();
            panel8 = new Panel();
            lblThuocSapHetHan = new Label();
            label7 = new Label();
            panel7 = new Panel();
            lblThuocSapHet = new Label();
            label6 = new Label();
            label4 = new Label();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            panel9.SuspendLayout();
            panel8.SuspendLayout();
            panel7.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Silver;
            panel1.Controls.Add(lblDuocSi);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(2, 2);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1138, 46);
            panel1.TabIndex = 0;
            // 
            // lblDuocSi
            // 
            lblDuocSi.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblDuocSi.AutoSize = true;
            lblDuocSi.Location = new Point(907, 14);
            lblDuocSi.Margin = new Padding(2, 0, 2, 0);
            lblDuocSi.Name = "lblDuocSi";
            lblDuocSi.Size = new Size(196, 20);
            lblDuocSi.TabIndex = 3;
            lblDuocSi.Text = "DS. Trần Minh Anh | Dược sĩ ";
            // 
            // panel3
            // 
            panel3.Location = new Point(201, 48);
            panel3.Margin = new Padding(2);
            panel3.Name = "panel3";
            panel3.Size = new Size(932, 521);
            panel3.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(10, 10);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(456, 28);
            label1.TabIndex = 2;
            label1.Text = "HỆ THỐNG QUẢN LÝ QUẦY THUỐC BỆNH VIỆN";
            // 
            // panel2
            // 
            panel2.Location = new Point(2, 48);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(234, 534);
            panel2.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.BackColor = Color.LightGray;
            panel4.Controls.Add(btnDangXuat);
            panel4.Controls.Add(button3);
            panel4.Controls.Add(button2);
            panel4.Controls.Add(button1);
            panel4.Controls.Add(label3);
            panel4.Location = new Point(2, 50);
            panel4.Margin = new Padding(2);
            panel4.Name = "panel4";
            panel4.Size = new Size(197, 521);
            panel4.TabIndex = 2;
            // 
            // btnDangXuat
            // 
            btnDangXuat.Location = new Point(22, 474);
            btnDangXuat.Margin = new Padding(2);
            btnDangXuat.Name = "btnDangXuat";
            btnDangXuat.Size = new Size(146, 30);
            btnDangXuat.TabIndex = 4;
            btnDangXuat.Text = "Đăng xuất";
            btnDangXuat.UseVisualStyleBackColor = true;
            btnDangXuat.Click += btnDangXuat_Click;
            // 
            // button3
            // 
            button3.Location = new Point(22, 140);
            button3.Margin = new Padding(2);
            button3.Name = "button3";
            button3.Size = new Size(146, 30);
            button3.TabIndex = 3;
            button3.Text = "Phiếu xin cấp";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(22, 91);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(146, 30);
            button2.TabIndex = 2;
            button2.Text = "Tồn kho quầy";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.Location = new Point(22, 42);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(146, 30);
            button1.TabIndex = 1;
            button1.Text = "Tiếp nhận đơn";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.LightGray;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(10, 10);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(83, 20);
            label3.TabIndex = 0;
            label3.Text = "Chức năng";
            // 
            // panel5
            // 
            panel5.Controls.Add(panel6);
            panel5.Location = new Point(198, 50);
            panel5.Margin = new Padding(2);
            panel5.Name = "panel5";
            panel5.Size = new Size(937, 521);
            panel5.TabIndex = 5;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Transparent;
            panel6.Controls.Add(groupBox1);
            panel6.Controls.Add(panel9);
            panel6.Controls.Add(panel8);
            panel6.Controls.Add(panel7);
            panel6.Controls.Add(label4);
            panel6.Location = new Point(6, 0);
            panel6.Margin = new Padding(2);
            panel6.Name = "panel6";
            panel6.Size = new Size(937, 526);
            panel6.TabIndex = 5;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgv);
            groupBox1.Location = new Point(21, 146);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(898, 326);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Công việc gần đây ";
            // 
            // dgv
            // 
            dgv.BackgroundColor = Color.LightGray;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dgv.GridColor = SystemColors.ButtonShadow;
            dgv.Location = new Point(26, 31);
            dgv.Margin = new Padding(2);
            dgv.Name = "dgv";
            dgv.RowHeadersVisible = false;
            dgv.RowHeadersWidth = 72;
            dgv.RowTemplate.Height = 37;
            dgv.Size = new Size(850, 273);
            dgv.TabIndex = 6;
            // 
            // Column1
            // 
            Column1.HeaderText = "Mã đơn";
            Column1.MinimumWidth = 9;
            Column1.Name = "Column1";
            Column1.Width = 190;
            // 
            // Column2
            // 
            Column2.HeaderText = "Bệnh nhân ";
            Column2.MinimumWidth = 9;
            Column2.Name = "Column2";
            Column2.Width = 330;
            // 
            // Column3
            // 
            Column3.HeaderText = "Ngày kê";
            Column3.MinimumWidth = 9;
            Column3.Name = "Column3";
            Column3.Width = 280;
            // 
            // Column4
            // 
            Column4.HeaderText = "Trạng thái ";
            Column4.MinimumWidth = 9;
            Column4.Name = "Column4";
            Column4.Width = 280;
            // 
            // Column5
            // 
            Column5.HeaderText = "Thao tác";
            Column5.MinimumWidth = 9;
            Column5.Name = "Column5";
            Column5.Width = 190;
            // 
            // panel9
            // 
            panel9.BackColor = Color.Silver;
            panel9.Controls.Add(lblPhieuChoDuyet);
            panel9.Controls.Add(label8);
            panel9.Location = new Point(618, 50);
            panel9.Margin = new Padding(2);
            panel9.Name = "panel9";
            panel9.Size = new Size(250, 75);
            panel9.TabIndex = 4;
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
            panel8.Location = new Point(329, 50);
            panel8.Margin = new Padding(2);
            panel8.Name = "panel8";
            panel8.Size = new Size(241, 75);
            panel8.TabIndex = 3;
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
            panel7.Location = new Point(47, 50);
            panel7.Margin = new Padding(2);
            panel7.Name = "panel7";
            panel7.Size = new Size(238, 75);
            panel7.TabIndex = 2;
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
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.1428576F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(18, 10);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(154, 25);
            label4.TabIndex = 0;
            label4.Text = "Màn hình chính ";
            // 
            // FormDuocSi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1147, 575);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel1);
            Margin = new Padding(2);
            Name = "FormDuocSi";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý quầy thuốc bệnh viện";
            Load += FormDuocSi_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Label lblDuocSi;
        private Button btnDangXuat;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label label3;
        private Panel panel5;
        private Panel panel6;
        private GroupBox groupBox1;
        private DataGridView dgv;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private Panel panel9;
        private Label lblPhieuChoDuyet;
        private Label label8;
        private Panel panel8;
        private Label lblThuocSapHetHan;
        private Label label7;
        private Panel panel7;
        private Label lblThuocSapHet;
        private Label label6;
        private Label label4;
    }
}