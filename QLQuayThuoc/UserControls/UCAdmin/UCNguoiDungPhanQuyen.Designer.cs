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
            textBox1 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            button1 = new Button();
            btnLamMoi = new Button();
            btnAddUser = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            dgv = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(378, 38);
            label1.TabIndex = 0;
            label1.Text = "Người dùng và phân quyền";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(4, 86);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(84, 25);
            label2.TabIndex = 1;
            label2.Text = "Tìm kiếm";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(4, 118);
            textBox1.Margin = new Padding(4, 4, 4, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(260, 31);
            textBox1.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(284, 86);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(63, 25);
            label3.TabIndex = 3;
            label3.Text = "Vai trò";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(491, 86);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(89, 25);
            label4.TabIndex = 4;
            label4.Text = "Trạng thái";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(284, 116);
            comboBox1.Margin = new Padding(4, 4, 4, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(188, 33);
            comboBox1.TabIndex = 5;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(491, 116);
            comboBox2.Margin = new Padding(4, 4, 4, 4);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(188, 33);
            comboBox2.TabIndex = 6;
            // 
            // button1
            // 
            button1.Location = new Point(700, 115);
            button1.Margin = new Padding(4, 4, 4, 4);
            button1.Name = "button1";
            button1.Size = new Size(94, 36);
            button1.TabIndex = 7;
            button1.Text = "Tìm";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Location = new Point(819, 115);
            btnLamMoi.Margin = new Padding(4, 4, 4, 4);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(112, 36);
            btnLamMoi.TabIndex = 8;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnAddUser
            // 
            btnAddUser.Location = new Point(1040, 115);
            btnAddUser.Margin = new Padding(4, 4, 4, 4);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(186, 36);
            btnAddUser.TabIndex = 9;
            btnAddUser.Text = "Thêm người dùng";
            btnAddUser.UseVisualStyleBackColor = true;
            btnAddUser.Click += btnAddUser_Click;
            // 
            // button4
            // 
            button4.Location = new Point(686, 555);
            button4.Margin = new Padding(4, 4, 4, 4);
            button4.Name = "button4";
            button4.Size = new Size(80, 36);
            button4.TabIndex = 11;
            button4.Text = "Sửa";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(895, 555);
            button5.Margin = new Padding(4, 4, 4, 4);
            button5.Name = "button5";
            button5.Size = new Size(138, 36);
            button5.TabIndex = 12;
            button5.Text = "Khóa/Mở";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(1040, 555);
            button6.Margin = new Padding(4, 4, 4, 4);
            button6.Name = "button6";
            button6.Size = new Size(186, 36);
            button6.TabIndex = 13;
            button6.Text = "Đặt lại mật khẩu...";
            button6.UseVisualStyleBackColor = true;
            // 
            // dgv
            // 
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6 });
            dgv.Location = new Point(4, 176);
            dgv.Margin = new Padding(4, 4, 4, 4);
            dgv.Name = "dgv";
            dgv.RowHeadersVisible = false;
            dgv.RowHeadersWidth = 51;
            dgv.RowTemplate.Height = 29;
            dgv.Size = new Size(1235, 359);
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
            // button2
            // 
            button2.Location = new Point(787, 556);
            button2.Name = "button2";
            button2.Size = new Size(92, 34);
            button2.TabIndex = 15;
            button2.Text = "Xóa";
            button2.UseVisualStyleBackColor = true;
            // 
            // UCNguoiDungPhanQuyen
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button2);
            Controls.Add(dgv);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(btnAddUser);
            Controls.Add(btnLamMoi);
            Controls.Add(button1);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(4, 4, 4, 4);
            Name = "UCNguoiDungPhanQuyen";
            Size = new Size(1258, 698);
            Load += UCNguoiDungPhanQuyen_Load;
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private Label label4;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Button button1;
        private Button btnLamMoi;
        private Button btnAddUser;
        private Button button4;
        private Button button5;
        private Button button6;
        private DataGridView dgv;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private Button button2;
    }
}
