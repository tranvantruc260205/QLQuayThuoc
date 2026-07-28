namespace QLQuayThuoc.UserControls.UCDuocSi
{
    partial class UCLichSuXuatThuoc
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
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            panel9.SuspendLayout();
            panel8.SuspendLayout();
            panel7.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgv);
            groupBox1.Location = new Point(18, 152);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(898, 326);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Lịch sử xuất thuốc";
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
            panel9.Location = new Point(615, 56);
            panel9.Margin = new Padding(2);
            panel9.Name = "panel9";
            panel9.Size = new Size(250, 75);
            panel9.TabIndex = 11;
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
            panel8.Location = new Point(326, 56);
            panel8.Margin = new Padding(2);
            panel8.Name = "panel8";
            panel8.Size = new Size(241, 75);
            panel8.TabIndex = 10;
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
            panel7.Location = new Point(44, 56);
            panel7.Margin = new Padding(2);
            panel7.Name = "panel7";
            panel7.Size = new Size(238, 75);
            panel7.TabIndex = 9;
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
            label4.Location = new Point(15, 16);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(174, 25);
            label4.TabIndex = 8;
            label4.Text = "Lịch sử xuất thuốc";
            // 
            // UCLichSuXuatThuoc
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox1);
            Controls.Add(panel9);
            Controls.Add(panel8);
            Controls.Add(panel7);
            Controls.Add(label4);
            Name = "UCLichSuXuatThuoc";
            Size = new Size(937, 526);
            Load += UCLichSuXuatThuoc_Load;
            groupBox1.ResumeLayout(false);
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
