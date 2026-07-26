namespace QLQuayThuoc.Forms.Dialogs
{
    partial class EditUser
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
            btnXacNhan = new Button();
            btnHuy = new Button();
            rdoKhoa = new RadioButton();
            rdoHoatDong = new RadioButton();
            label6 = new Label();
            cbRole = new ComboBox();
            label5 = new Label();
            txtEmail = new TextBox();
            label3 = new Label();
            txtSdt = new TextBox();
            label2 = new Label();
            txtHoTen = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnXacNhan
            // 
            btnXacNhan.Location = new Point(325, 423);
            btnXacNhan.Name = "btnXacNhan";
            btnXacNhan.Size = new Size(94, 29);
            btnXacNhan.TabIndex = 29;
            btnXacNhan.Text = "Xác nhận";
            btnXacNhan.UseVisualStyleBackColor = true;
            btnXacNhan.Click += btnXacNhan_Click;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(191, 423);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(94, 29);
            btnHuy.TabIndex = 28;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // rdoKhoa
            // 
            rdoKhoa.AutoSize = true;
            rdoKhoa.Location = new Point(304, 337);
            rdoKhoa.Name = "rdoKhoa";
            rdoKhoa.Size = new Size(64, 24);
            rdoKhoa.TabIndex = 27;
            rdoKhoa.Text = "Khóa";
            rdoKhoa.UseVisualStyleBackColor = true;
            // 
            // rdoHoatDong
            // 
            rdoHoatDong.AutoSize = true;
            rdoHoatDong.Checked = true;
            rdoHoatDong.Location = new Point(173, 337);
            rdoHoatDong.Name = "rdoHoatDong";
            rdoHoatDong.Size = new Size(102, 24);
            rdoHoatDong.TabIndex = 26;
            rdoHoatDong.TabStop = true;
            rdoHoatDong.Text = "Hoạt động";
            rdoHoatDong.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(50, 339);
            label6.Name = "label6";
            label6.Size = new Size(75, 20);
            label6.TabIndex = 25;
            label6.Text = "Trạng thái";
            // 
            // cbRole
            // 
            cbRole.FormattingEnabled = true;
            cbRole.Items.AddRange(new object[] { "Bác sĩ", "Dược sĩ", "Kế toán", "Kho tổng" });
            cbRole.Location = new Point(131, 272);
            cbRole.Name = "cbRole";
            cbRole.Size = new Size(288, 28);
            cbRole.TabIndex = 24;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(73, 275);
            label5.Name = "label5";
            label5.Size = new Size(52, 20);
            label5.TabIndex = 23;
            label5.Text = "Vai trò";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(131, 202);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(288, 27);
            txtEmail.TabIndex = 20;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(79, 205);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 19;
            label3.Text = "Email";
            // 
            // txtSdt
            // 
            txtSdt.Location = new Point(131, 129);
            txtSdt.Name = "txtSdt";
            txtSdt.Size = new Size(288, 27);
            txtSdt.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 132);
            label2.Name = "label2";
            label2.Size = new Size(97, 20);
            label2.TabIndex = 17;
            label2.Text = "Số điện thoại";
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(131, 60);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(288, 27);
            txtHoTen.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 63);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 15;
            label1.Text = "Họ và tên";
            // 
            // EditUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(476, 506);
            Controls.Add(btnXacNhan);
            Controls.Add(btnHuy);
            Controls.Add(rdoKhoa);
            Controls.Add(rdoHoatDong);
            Controls.Add(label6);
            Controls.Add(cbRole);
            Controls.Add(label5);
            Controls.Add(txtEmail);
            Controls.Add(label3);
            Controls.Add(txtSdt);
            Controls.Add(label2);
            Controls.Add(txtHoTen);
            Controls.Add(label1);
            Name = "EditUser";
            Text = "Chỉnh sửa người dùng";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnXacNhan;
        private Button btnHuy;
        private RadioButton rdoKhoa;
        private RadioButton rdoHoatDong;
        private Label label6;
        private ComboBox cbRole;
        private Label label5;
        private TextBox txtEmail;
        private Label label3;
        private TextBox txtSdt;
        private Label label2;
        private TextBox txtHoTen;
        private Label label1;
    }
}