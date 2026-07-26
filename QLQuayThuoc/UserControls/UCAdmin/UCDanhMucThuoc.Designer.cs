namespace QLQuayThuoc
{
    partial class UCDanhMucThuoc
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
            label2 = new Label();
            txtTimKiem = new TextBox();
            label3 = new Label();
            cbTrangThai = new ComboBox();
            btnTimKiem = new Button();
            btnLamMoi = new Button();
            btnThemThuoc = new Button();
            dgv = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            btnSuaThuoc = new Button();
            btnkdtn = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(191, 31);
            label1.TabIndex = 0;
            label1.Text = "Danh mục thuốc";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 69);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 1;
            label2.Text = "Tìm kiếm";
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(3, 92);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(229, 27);
            txtTimKiem.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(242, 69);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 3;
            label3.Text = "Trạng thái";
            // 
            // cbTrangThai
            // 
            cbTrangThai.FormattingEnabled = true;
            cbTrangThai.Items.AddRange(new object[] { "Tất cả", "Đang kinh doanh", "Tạm ngừng" });
            cbTrangThai.Location = new Point(242, 92);
            cbTrangThai.Name = "cbTrangThai";
            cbTrangThai.Size = new Size(169, 28);
            cbTrangThai.TabIndex = 4;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(434, 91);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(94, 29);
            btnTimKiem.TabIndex = 5;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Location = new Point(534, 91);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(94, 29);
            btnLamMoi.TabIndex = 6;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnThemThuoc
            // 
            btnThemThuoc.Location = new Point(857, 91);
            btnThemThuoc.Name = "btnThemThuoc";
            btnThemThuoc.Size = new Size(125, 29);
            btnThemThuoc.TabIndex = 7;
            btnThemThuoc.Text = "Thêm thuốc";
            btnThemThuoc.UseVisualStyleBackColor = true;
            btnThemThuoc.Click += btnThemThuoc_Click;
            // 
            // dgv
            // 
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8 });
            dgv.Location = new Point(3, 142);
            dgv.Name = "dgv";
            dgv.RowHeadersVisible = false;
            dgv.RowHeadersWidth = 51;
            dgv.RowTemplate.Height = 29;
            dgv.Size = new Size(988, 287);
            dgv.TabIndex = 8;
            // 
            // Column1
            // 
            Column1.HeaderText = "Mã thuốc";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 135;
            // 
            // Column2
            // 
            Column2.HeaderText = "Tên thuốc";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 265;
            // 
            // Column3
            // 
            Column3.HeaderText = "Đơn vị";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "Hoạt chất";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 190;
            // 
            // Column5
            // 
            Column5.HeaderText = "Hàm lượng ";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 130;
            // 
            // Column6
            // 
            Column6.HeaderText = "Đơn giá";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.Width = 130;
            // 
            // Column7
            // 
            Column7.HeaderText = "BHYT chi trả";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.Width = 125;
            // 
            // Column8
            // 
            Column8.HeaderText = "Trạng thái";
            Column8.MinimumWidth = 6;
            Column8.Name = "Column8";
            Column8.Width = 130;
            // 
            // btnSuaThuoc
            // 
            btnSuaThuoc.Location = new Point(686, 456);
            btnSuaThuoc.Name = "btnSuaThuoc";
            btnSuaThuoc.Size = new Size(94, 29);
            btnSuaThuoc.TabIndex = 9;
            btnSuaThuoc.Text = "Sửa thuốc";
            btnSuaThuoc.UseVisualStyleBackColor = true;
            btnSuaThuoc.Click += btnSuaThuoc_Click;
            // 
            // btnkdtn
            // 
            btnkdtn.Location = new Point(800, 456);
            btnkdtn.Name = "btnkdtn";
            btnkdtn.Size = new Size(182, 29);
            btnkdtn.TabIndex = 10;
            btnkdtn.Text = "Kinh doanh/Tạm ngừng";
            btnkdtn.UseVisualStyleBackColor = true;
            btnkdtn.Click += btnkdtn_Click;
            // 
            // UCDanhMucThuoc
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnkdtn);
            Controls.Add(btnSuaThuoc);
            Controls.Add(dgv);
            Controls.Add(btnThemThuoc);
            Controls.Add(btnLamMoi);
            Controls.Add(btnTimKiem);
            Controls.Add(cbTrangThai);
            Controls.Add(label3);
            Controls.Add(txtTimKiem);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UCDanhMucThuoc";
            Size = new Size(1006, 558);
            Load += UCDanhMucThuoc_Load;
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtTimKiem;
        private Label label3;
        private ComboBox cbTrangThai;
        private Button btnTimKiem;
        private Button btnLamMoi;
        private Button btnThemThuoc;
        private DataGridView dgv;
        private Button btnSuaThuoc;
        private Button btnkdtn;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
    }
}
