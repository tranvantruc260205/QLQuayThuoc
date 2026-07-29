namespace QLQuayThuoc
{
    partial class UCQuanLyLoThuoc
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
            cboHanSuDung = new ComboBox();
            dgvLoThuoc = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            cboTrangThaiTon = new ComboBox();
            txtTimKiem = new TextBox();
            button6 = new Button();
            btnLamMoi = new Button();
            btnTim = new Button();
            label9 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            panelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLoThuoc).BeginInit();
            SuspendLayout();
            // 
            // panelContent
            // 
            panelContent.BackColor = SystemColors.Window;
            panelContent.Controls.Add(cboHanSuDung);
            panelContent.Controls.Add(dgvLoThuoc);
            panelContent.Controls.Add(cboTrangThaiTon);
            panelContent.Controls.Add(txtTimKiem);
            panelContent.Controls.Add(button6);
            panelContent.Controls.Add(btnLamMoi);
            panelContent.Controls.Add(btnTim);
            panelContent.Controls.Add(label9);
            panelContent.Controls.Add(label7);
            panelContent.Controls.Add(label6);
            panelContent.Controls.Add(label5);
            panelContent.Controls.Add(label4);
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(0, 0);
            panelContent.Margin = new Padding(4);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(1564, 789);
            panelContent.TabIndex = 6;
            // 
            // cboHanSuDung
            // 
            cboHanSuDung.FormattingEnabled = true;
            cboHanSuDung.Location = new Point(237, 116);
            cboHanSuDung.Margin = new Padding(4);
            cboHanSuDung.Name = "cboHanSuDung";
            cboHanSuDung.Size = new Size(224, 38);
            cboHanSuDung.TabIndex = 17;
            // 
            // dgvLoThuoc
            // 
            dgvLoThuoc.AllowUserToAddRows = false;
            dgvLoThuoc.BackgroundColor = SystemColors.Control;
            dgvLoThuoc.BorderStyle = BorderStyle.None;
            dgvLoThuoc.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvLoThuoc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvLoThuoc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLoThuoc.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7 });
            dgvLoThuoc.EnableHeadersVisualStyles = false;
            dgvLoThuoc.ImeMode = ImeMode.NoControl;
            dgvLoThuoc.Location = new Point(4, 182);
            dgvLoThuoc.Margin = new Padding(4);
            dgvLoThuoc.MultiSelect = false;
            dgvLoThuoc.Name = "dgvLoThuoc";
            dgvLoThuoc.ReadOnly = true;
            dgvLoThuoc.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvLoThuoc.RowHeadersVisible = false;
            dgvLoThuoc.RowHeadersWidth = 51;
            dgvLoThuoc.RowTemplate.Height = 29;
            dgvLoThuoc.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLoThuoc.Size = new Size(1560, 441);
            dgvLoThuoc.TabIndex = 16;
            dgvLoThuoc.CellFormatting += dgvLoThuoc_CellFormatting;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "MaLo";
            Column1.HeaderText = "Mã lô";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 160;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "TenThuoc";
            Column2.HeaderText = "Tên thuốc";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 430;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "SoLo";
            Column3.HeaderText = "Số lô";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 120;
            // 
            // Column4
            // 
            Column4.DataPropertyName = "NgaySanXuat";
            Column4.HeaderText = "Ngày nhập";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 200;
            // 
            // Column5
            // 
            Column5.DataPropertyName = "NgayHetHan";
            Column5.HeaderText = "Ngày hết hạn";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Width = 200;
            // 
            // Column6
            // 
            Column6.DataPropertyName = "SoLuongTon";
            Column6.HeaderText = "Tồn ";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            Column6.Width = 140;
            // 
            // Column7
            // 
            Column7.DataPropertyName = "TrangThai";
            Column7.HeaderText = "Trạng thái";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            Column7.Width = 300;
            // 
            // cboTrangThaiTon
            // 
            cboTrangThaiTon.FormattingEnabled = true;
            cboTrangThaiTon.Location = new Point(578, 114);
            cboTrangThaiTon.Margin = new Padding(4);
            cboTrangThaiTon.Name = "cboTrangThaiTon";
            cboTrangThaiTon.Size = new Size(224, 38);
            cboTrangThaiTon.TabIndex = 15;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(9, 116);
            txtTimKiem.Margin = new Padding(4);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(186, 35);
            txtTimKiem.TabIndex = 12;
            // 
            // button6
            // 
            button6.Location = new Point(1362, 339);
            button6.Margin = new Padding(4);
            button6.Name = "button6";
            button6.Size = new Size(12, 12);
            button6.TabIndex = 10;
            button6.Text = "button6";
            button6.UseVisualStyleBackColor = true;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Location = new Point(1035, 116);
            btnLamMoi.Margin = new Padding(4);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(141, 44);
            btnLamMoi.TabIndex = 9;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnTim
            // 
            btnTim.Location = new Point(864, 114);
            btnTim.Margin = new Padding(4);
            btnTim.Name = "btnTim";
            btnTim.Size = new Size(141, 44);
            btnTim.TabIndex = 8;
            btnTim.Text = "Tìm";
            btnTim.UseVisualStyleBackColor = true;
            btnTim.Click += btnTim_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(578, 81);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(109, 30);
            label9.TabIndex = 7;
            label9.Text = "Trạng Thái";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(237, 81);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(132, 30);
            label7.TabIndex = 5;
            label7.Text = "Hạn sử dụng";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(9, 81);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(99, 30);
            label6.TabIndex = 4;
            label6.Text = "Tìm Kiếm";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(9, 46);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(371, 23);
            label5.TabIndex = 3;
            label5.Text = "Nhập, sửa và ngừng sử dụng lô trong kho tổng";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(4, 4);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(234, 38);
            label4.TabIndex = 2;
            label4.Text = "Quản lý lô thuốc";
            // 
            // UCQuanLyLoThuoc
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelContent);
            Margin = new Padding(4);
            Name = "UCQuanLyLoThuoc";
            Size = new Size(1564, 789);
            Load += UCQuanLyLoThuoc_Load;
            panelContent.ResumeLayout(false);
            panelContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLoThuoc).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelContent;
        private ComboBox cboHanSuDung;
        private DataGridView dgvLoThuoc;
        private ComboBox cboTrangThaiTon;
        private TextBox txtTimKiem;
        private Button button6;
        private Button btnLamMoi;
        private Button btnTim;
        private Label label9;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
    }
}
