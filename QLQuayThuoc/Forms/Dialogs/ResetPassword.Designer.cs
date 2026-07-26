namespace QLQuayThuoc.Forms.Dialogs
{
    partial class ResetPassword
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
            lblUserId = new Label();
            lblFullName = new Label();
            label3 = new Label();
            label2 = new Label();
            btnXacNhan = new Button();
            txtNewPassword = new TextBox();
            chkShow = new CheckBox();
            btnHuy = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(95, 46);
            label1.Name = "label1";
            label1.Size = new Size(68, 20);
            label1.TabIndex = 0;
            label1.Text = "User ID : ";
            // 
            // lblUserId
            // 
            lblUserId.AutoSize = true;
            lblUserId.Location = new Point(169, 46);
            lblUserId.Name = "lblUserId";
            lblUserId.Size = new Size(50, 20);
            lblUserId.TabIndex = 1;
            lblUserId.Text = "label2";
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Location = new Point(169, 87);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(50, 20);
            lblFullName.TabIndex = 3;
            lblFullName.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(79, 87);
            label3.Name = "label3";
            label3.Size = new Size(84, 20);
            label3.TabIndex = 2;
            label3.Text = "Họ và tên : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 181);
            label2.Name = "label2";
            label2.Size = new Size(100, 20);
            label2.TabIndex = 4;
            label2.Text = "Mật khẩu mới";
            // 
            // btnXacNhan
            // 
            btnXacNhan.Location = new Point(260, 320);
            btnXacNhan.Name = "btnXacNhan";
            btnXacNhan.Size = new Size(94, 29);
            btnXacNhan.TabIndex = 5;
            btnXacNhan.Text = "Xác nhận";
            btnXacNhan.UseVisualStyleBackColor = true;
            btnXacNhan.Click += btnXacNhan_Click;
            // 
            // txtNewPassword
            // 
            txtNewPassword.Location = new Point(129, 178);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.Size = new Size(225, 27);
            txtNewPassword.TabIndex = 6;
            txtNewPassword.UseSystemPasswordChar = true;
            // 
            // chkShow
            // 
            chkShow.AutoSize = true;
            chkShow.Location = new Point(129, 222);
            chkShow.Name = "chkShow";
            chkShow.Size = new Size(127, 24);
            chkShow.TabIndex = 7;
            chkShow.Text = "Hiện mật khẩu";
            chkShow.UseVisualStyleBackColor = true;
            chkShow.CheckedChanged += chkShow_CheckedChanged;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(138, 320);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(94, 29);
            btnHuy.TabIndex = 8;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // ResetPassword
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(397, 384);
            Controls.Add(btnHuy);
            Controls.Add(chkShow);
            Controls.Add(txtNewPassword);
            Controls.Add(btnXacNhan);
            Controls.Add(label2);
            Controls.Add(lblFullName);
            Controls.Add(label3);
            Controls.Add(lblUserId);
            Controls.Add(label1);
            Name = "ResetPassword";
            Text = "Đặt lại mật khẩu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblUserId;
        private Label lblFullName;
        private Label label3;
        private Label label2;
        private Button btnXacNhan;
        private TextBox txtNewPassword;
        private CheckBox chkShow;
        private Button btnHuy;
    }
}