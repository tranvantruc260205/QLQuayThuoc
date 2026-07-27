namespace QLQuayThuoc.Forms.Dialogs
{
    partial class Admin_AddUser
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
            label1 = new Label();
            txtHoTen = new TextBox();
            txtSdt = new TextBox();
            label2 = new Label();
            txtEmail = new TextBox();
            label3 = new Label();
            txtMk = new TextBox();
            label4 = new Label();
            label5 = new Label();
            cbRole = new ComboBox();
            label6 = new Label();
            rdoHoatDong = new RadioButton();
            rdoKhoa = new RadioButton();
            btnHuy = new Button();
            btnXacNhan = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 51);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 0;
            label1.Text = "Họ và tên";
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(129, 48);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(288, 27);
            txtHoTen.TabIndex = 1;
            // 
            // txtSdt
            // 
            txtSdt.Location = new Point(129, 117);
            txtSdt.Name = "txtSdt";
            txtSdt.Size = new Size(288, 27);
            txtSdt.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 120);
            label2.Name = "label2";
            label2.Size = new Size(97, 20);
            label2.TabIndex = 2;
            label2.Text = "Số điện thoại";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(129, 190);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(288, 27);
            txtEmail.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(77, 193);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 4;
            label3.Text = "Email";
            // 
            // txtMk
            // 
            txtMk.Location = new Point(129, 257);
            txtMk.Name = "txtMk";
            txtMk.Size = new Size(288, 27);
            txtMk.TabIndex = 7;
            txtMk.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(53, 260);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 6;
            label4.Text = "Mật khẩu";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(71, 327);
            label5.Name = "label5";
            label5.Size = new Size(52, 20);
            label5.TabIndex = 8;
            label5.Text = "Vai trò";
            // 
            // cbRole
            // 
            cbRole.FormattingEnabled = true;
            cbRole.Items.AddRange(new object[] { "Bác sĩ", "Dược sĩ", "Kế toán", "Kho tổng" });
            cbRole.Location = new Point(129, 324);
            cbRole.Name = "cbRole";
            cbRole.Size = new Size(288, 28);
            cbRole.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(48, 391);
            label6.Name = "label6";
            label6.Size = new Size(75, 20);
            label6.TabIndex = 10;
            label6.Text = "Trạng thái";
            // 
            // rdoHoatDong
            // 
            rdoHoatDong.AutoSize = true;
            rdoHoatDong.Checked = true;
            rdoHoatDong.Location = new Point(171, 389);
            rdoHoatDong.Name = "rdoHoatDong";
            rdoHoatDong.Size = new Size(102, 24);
            rdoHoatDong.TabIndex = 11;
            rdoHoatDong.TabStop = true;
            rdoHoatDong.Text = "Hoạt động";
            rdoHoatDong.UseVisualStyleBackColor = true;
            // 
            // rdoKhoa
            // 
            rdoKhoa.AutoSize = true;
            rdoKhoa.Location = new Point(302, 389);
            rdoKhoa.Name = "rdoKhoa";
            rdoKhoa.Size = new Size(64, 24);
            rdoKhoa.TabIndex = 12;
            rdoKhoa.Text = "Khóa";
            rdoKhoa.UseVisualStyleBackColor = true;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(244, 475);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(94, 29);
            btnHuy.TabIndex = 13;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // btnXacNhan
            // 
            btnXacNhan.Location = new Point(366, 475);
            btnXacNhan.Name = "btnXacNhan";
            btnXacNhan.Size = new Size(94, 29);
            btnXacNhan.TabIndex = 14;
            btnXacNhan.Text = "Xác nhận";
            btnXacNhan.UseVisualStyleBackColor = true;
            btnXacNhan.Click += btnXacNhan_Click;
            // 
            // AddUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 533);
            Controls.Add(btnXacNhan);
            Controls.Add(btnHuy);
            Controls.Add(rdoKhoa);
            Controls.Add(rdoHoatDong);
            Controls.Add(label6);
            Controls.Add(cbRole);
            Controls.Add(label5);
            Controls.Add(txtMk);
            Controls.Add(label4);
            Controls.Add(txtEmail);
            Controls.Add(label3);
            Controls.Add(txtSdt);
            Controls.Add(label2);
            Controls.Add(txtHoTen);
            Controls.Add(label1);
            Name = "AddUser";
            Text = "Thêm người dùng";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtHoTen;
        private TextBox txtSdt;
        private Label label2;
        private TextBox txtEmail;
        private Label label3;
        private TextBox txtMk;
        private Label label4;
        private Label label5;
        private ComboBox cbRole;
        private Label label6;
        private RadioButton rdoHoatDong;
        private RadioButton rdoKhoa;
        private Button btnHuy;
        private Button btnXacNhan;
    }
}