namespace QLQuayThuoc
{
    partial class UCNguoiDungPhanQuyen
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
            label4 = new Label();
            cbRole = new ComboBox();
            cbTrangThai = new ComboBox();
            btnTim = new Button();
            btnLamMoi = new Button();
            btnAddUser = new Button();
            btnSua = new Button();
            btnKhoaMo = new Button();
            btnRsPassword = new Button();
            dgv = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            btnXoa = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(306, 31);
            label1.TabIndex = 0;
            label1.Text = "Người dùng và phân quyền";
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
            txtTimKiem.Location = new Point(3, 94);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(209, 27);
            txtTimKiem.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(227, 69);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 3;
            label3.Text = "Vai trò";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(393, 69);
            label4.Name = "label4";
            label4.Size = new Size(75, 20);
            label4.TabIndex = 4;
            label4.Text = "Trạng thái";
            // 
            // cbRole
            // 
            cbRole.FormattingEnabled = true;
            cbRole.Items.AddRange(new object[] { "Tất cả", "Bác sĩ", "Dược sĩ", "Kế toán", "Kho tổng", "Admin" });
            cbRole.Location = new Point(227, 93);
            cbRole.Name = "cbRole";
            cbRole.Size = new Size(151, 28);
            cbRole.TabIndex = 5;
            // 
            // cbTrangThai
            // 
            cbTrangThai.FormattingEnabled = true;
            cbTrangThai.Items.AddRange(new object[] { "Tất cả", "Hoạt động", "Khóa" });
            cbTrangThai.Location = new Point(393, 93);
            cbTrangThai.Name = "cbTrangThai";
            cbTrangThai.Size = new Size(151, 28);
            cbTrangThai.TabIndex = 6;
            // 
            // btnTim
            // 
            btnTim.Location = new Point(560, 92);
            btnTim.Name = "btnTim";
            btnTim.Size = new Size(75, 29);
            btnTim.TabIndex = 7;
            btnTim.Text = "Tìm";
            btnTim.UseVisualStyleBackColor = true;
            btnTim.Click += btnTim_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Location = new Point(655, 92);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(90, 29);
            btnLamMoi.TabIndex = 8;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnAddUser
            // 
            btnAddUser.Location = new Point(832, 92);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(149, 29);
            btnAddUser.TabIndex = 9;
            btnAddUser.Text = "Thêm người dùng";
            btnAddUser.UseVisualStyleBackColor = true;
            btnAddUser.Click += btnAddUser_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(561, 444);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(64, 29);
            btnSua.TabIndex = 11;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnKhoaMo
            // 
            btnKhoaMo.Location = new Point(709, 445);
            btnKhoaMo.Name = "btnKhoaMo";
            btnKhoaMo.Size = new Size(110, 29);
            btnKhoaMo.TabIndex = 12;
            btnKhoaMo.Text = "Khóa/Mở";
            btnKhoaMo.UseVisualStyleBackColor = true;
            btnKhoaMo.Click += btnKhoaMo_Click;
            // 
            // btnRsPassword
            // 
            btnRsPassword.Location = new Point(825, 445);
            btnRsPassword.Name = "btnRsPassword";
            btnRsPassword.Size = new Size(149, 29);
            btnRsPassword.TabIndex = 13;
            btnRsPassword.Text = "Đặt lại mật khẩu...";
            btnRsPassword.UseVisualStyleBackColor = true;
            btnRsPassword.Click += btnRsPassword_Click;
            // 
            // dgv
            // 
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6 });
            dgv.Location = new Point(3, 141);
            dgv.Name = "dgv";
            dgv.RowHeadersVisible = false;
            dgv.RowHeadersWidth = 51;
            dgv.RowTemplate.Height = 29;
            dgv.Size = new Size(988, 287);
            dgv.TabIndex = 14;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "UserId";
            Column1.HeaderText = "Mã";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 130;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "FullName";
            Column2.HeaderText = "Họ tên";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 170;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "PhoneNumber";
            Column3.HeaderText = "Số điện thoại";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 150;
            // 
            // Column4
            // 
            Column4.DataPropertyName = "Email";
            Column4.HeaderText = "Email";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 285;
            // 
            // Column5
            // 
            Column5.DataPropertyName = "Role";
            Column5.HeaderText = "Role";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 130;
            // 
            // Column6
            // 
            Column6.DataPropertyName = "TrangThai";
            Column6.HeaderText = "Trạng thái";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.Width = 240;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(630, 445);
            btnXoa.Margin = new Padding(2);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(74, 27);
            btnXoa.TabIndex = 15;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // UCNguoiDungPhanQuyen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnXoa);
            Controls.Add(dgv);
            Controls.Add(btnRsPassword);
            Controls.Add(btnKhoaMo);
            Controls.Add(btnSua);
            Controls.Add(btnAddUser);
            Controls.Add(btnLamMoi);
            Controls.Add(btnTim);
            Controls.Add(cbTrangThai);
            Controls.Add(cbRole);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtTimKiem);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UCNguoiDungPhanQuyen";
            Size = new Size(1006, 558);
            Load += UCNguoiDungPhanQuyen_Load;
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtTimKiem;
        private Label label3;
        private Label label4;
        private ComboBox cbRole;
        private ComboBox cbTrangThai;
        private Button btnTim;
        private Button btnLamMoi;
        private Button btnAddUser;
        private Button btnSua;
        private Button btnKhoaMo;
        private Button btnRsPassword;
        private DataGridView dgv;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private Button btnXoa;
    }
}
