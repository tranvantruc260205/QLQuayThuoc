namespace QLQuayThuoc.UserControls
{
    partial class UCTiepNhanDon
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
            txtBHYT = new TextBox();
            label5 = new Label();
            txtBacSi = new TextBox();
            txtBenhNhan = new TextBox();
            label4 = new Label();
            label3 = new Label();
            btnTraCuu = new Button();
            txtMaDonThuoc = new TextBox();
            label2 = new Label();
            groupBox2 = new GroupBox();
            dgv1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            groupBox3 = new GroupBox();
            dgv2 = new DataGridView();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            Column10 = new DataGridViewTextBoxColumn();
            btnThanhToan = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv1).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(16, 14);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(236, 25);
            label1.TabIndex = 0;
            label1.Text = "Tiếp Nhận Và Xuất Thuốc";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ControlLight;
            groupBox1.Controls.Add(txtBHYT);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtBacSi);
            groupBox1.Controls.Add(txtBenhNhan);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(btnTraCuu);
            groupBox1.Controls.Add(txtMaDonThuoc);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(16, 50);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(961, 120);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tra Cứu Đơn Thuốc";
            // 
            // txtBHYT
            // 
            txtBHYT.Location = new Point(743, 64);
            txtBHYT.Name = "txtBHYT";
            txtBHYT.ReadOnly = true;
            txtBHYT.Size = new Size(167, 27);
            txtBHYT.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(743, 44);
            label5.Name = "label5";
            label5.Size = new Size(70, 20);
            label5.TabIndex = 9;
            label5.Text = "Mã BHYT";
            // 
            // txtBacSi
            // 
            txtBacSi.Location = new Point(559, 64);
            txtBacSi.Name = "txtBacSi";
            txtBacSi.ReadOnly = true;
            txtBacSi.Size = new Size(166, 27);
            txtBacSi.TabIndex = 8;
            // 
            // txtBenhNhan
            // 
            txtBenhNhan.Location = new Point(386, 64);
            txtBenhNhan.Name = "txtBenhNhan";
            txtBenhNhan.ReadOnly = true;
            txtBenhNhan.Size = new Size(154, 27);
            txtBenhNhan.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(559, 44);
            label4.Name = "label4";
            label4.Size = new Size(92, 20);
            label4.TabIndex = 6;
            label4.Text = "BS phụ trách";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(386, 42);
            label3.Name = "label3";
            label3.Size = new Size(78, 20);
            label3.TabIndex = 5;
            label3.Text = "Bệnh nhân";
            // 
            // btnTraCuu
            // 
            btnTraCuu.BackColor = Color.Aquamarine;
            btnTraCuu.Location = new Point(278, 63);
            btnTraCuu.Name = "btnTraCuu";
            btnTraCuu.Size = new Size(94, 29);
            btnTraCuu.TabIndex = 4;
            btnTraCuu.Text = "Tra cứu";
            btnTraCuu.UseVisualStyleBackColor = false;
            btnTraCuu.Click += btnTraCuu_Click_1;
            // 
            // txtMaDonThuoc
            // 
            txtMaDonThuoc.Location = new Point(30, 64);
            txtMaDonThuoc.Margin = new Padding(2);
            txtMaDonThuoc.Name = "txtMaDonThuoc";
            txtMaDonThuoc.Size = new Size(229, 27);
            txtMaDonThuoc.TabIndex = 3;
            txtMaDonThuoc.KeyDown += txtMaDonThuoc_KeyDown;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 42);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(101, 20);
            label2.TabIndex = 0;
            label2.Text = "Mã đơn thuốc";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.ControlLight;
            groupBox2.Controls.Add(dgv1);
            groupBox2.Location = new Point(16, 181);
            groupBox2.Margin = new Padding(2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(2);
            groupBox2.Size = new Size(496, 290);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thuốc trong đơn";
            // 
            // dgv1
            // 
            dgv1.BackgroundColor = SystemColors.Control;
            dgv1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6 });
            dgv1.Location = new Point(14, 41);
            dgv1.Margin = new Padding(2);
            dgv1.Name = "dgv1";
            dgv1.RowHeadersVisible = false;
            dgv1.RowHeadersWidth = 62;
            dgv1.RowTemplate.Height = 33;
            dgv1.Size = new Size(470, 228);
            dgv1.TabIndex = 3;
            dgv1.SelectionChanged += dgv1_SelectionChanged;
            // 
            // Column1
            // 
            Column1.HeaderText = "Thuốc";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.Width = 150;
            // 
            // Column2
            // 
            Column2.HeaderText = "Số lượng";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            Column2.Width = 150;
            // 
            // Column3
            // 
            Column3.HeaderText = "Liều dùng";
            Column3.MinimumWidth = 8;
            Column3.Name = "Column3";
            Column3.Width = 130;
            // 
            // Column4
            // 
            Column4.HeaderText = "Tần suất";
            Column4.MinimumWidth = 8;
            Column4.Name = "Column4";
            Column4.Width = 130;
            // 
            // Column5
            // 
            Column5.HeaderText = "Số ngày";
            Column5.MinimumWidth = 8;
            Column5.Name = "Column5";
            Column5.Width = 150;
            // 
            // Column6
            // 
            Column6.HeaderText = "Ghi chú";
            Column6.MinimumWidth = 8;
            Column6.Name = "Column6";
            Column6.Width = 130;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = SystemColors.ControlLight;
            groupBox3.Controls.Add(dgv2);
            groupBox3.Location = new Point(517, 181);
            groupBox3.Margin = new Padding(2);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(2);
            groupBox3.Size = new Size(465, 290);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Kiểm tra tồn và chọn lô";
            // 
            // dgv2
            // 
            dgv2.BackgroundColor = SystemColors.Control;
            dgv2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv2.Columns.AddRange(new DataGridViewColumn[] { Column7, Column8, Column9, Column10 });
            dgv2.Location = new Point(5, 41);
            dgv2.Margin = new Padding(2);
            dgv2.Name = "dgv2";
            dgv2.RowHeadersVisible = false;
            dgv2.RowHeadersWidth = 62;
            dgv2.RowTemplate.Height = 33;
            dgv2.Size = new Size(435, 228);
            dgv2.TabIndex = 0;
            dgv2.CellEndEdit += dgv2_CellEndEdit;
            dgv2.CellValidating += dgv2_CellValidating;
            // 
            // Column7
            // 
            Column7.HeaderText = "Mã lô";
            Column7.MinimumWidth = 8;
            Column7.Name = "Column7";
            Column7.Width = 150;
            // 
            // Column8
            // 
            Column8.HeaderText = "Hạn dùng";
            Column8.MinimumWidth = 8;
            Column8.Name = "Column8";
            Column8.Width = 150;
            // 
            // Column9
            // 
            Column9.HeaderText = "Tồn quầy";
            Column9.MinimumWidth = 8;
            Column9.Name = "Column9";
            Column9.Width = 150;
            // 
            // Column10
            // 
            Column10.HeaderText = "Số lượng xuất";
            Column10.MinimumWidth = 8;
            Column10.Name = "Column10";
            Column10.Width = 150;
            // 
            // btnThanhToan
            // 
            btnThanhToan.Location = new Point(815, 490);
            btnThanhToan.Margin = new Padding(2);
            btnThanhToan.Name = "btnThanhToan";
            btnThanhToan.Size = new Size(98, 27);
            btnThanhToan.TabIndex = 4;
            btnThanhToan.Text = "Thanh toán";
            btnThanhToan.UseVisualStyleBackColor = true;
            btnThanhToan.Click += btnThanhToan_Click;
            // 
            // UCTiepNhanDon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnThanhToan);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "UCTiepNhanDon";
            Size = new Size(980, 543);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv1).EndInit();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private TextBox txtMaDonThuoc;
        private Label label2;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private DataGridView dgv1;
        private DataGridView dgv2;
        private Button btnThanhToan;
        private Button btnTraCuu;
        private TextBox txtBacSi;
        private TextBox txtBenhNhan;
        private Label label4;
        private Label label3;
        private TextBox txtBHYT;
        private Label label5;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column10;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
    }
}
