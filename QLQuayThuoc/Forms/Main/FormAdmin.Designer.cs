namespace QLQuayThuoc
{
    partial class FormAdmin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            panel4 = new Panel();
            btnDangXuat = new Button();
            btnDanhMuc = new Button();
            btnPhanQuyen = new Button();
            label2 = new Label();
            panel2 = new Panel();
            label1 = new Label();
            label4 = new Label();
            lblAdmin = new Label();
            panel3 = new Panel();
            panel5 = new Panel();
            button1 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ScrollBar;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(btnDangXuat);
            panel1.Controls.Add(btnDanhMuc);
            panel1.Controls.Add(btnPhanQuyen);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(0, 57);
            panel1.Name = "panel1";
            panel1.Size = new Size(244, 564);
            panel1.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ControlDark;
            panel4.Location = new Point(247, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(5, 565);
            panel4.TabIndex = 4;
            // 
            // btnDangXuat
            // 
            btnDangXuat.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnDangXuat.Location = new Point(4, 509);
            btnDangXuat.Name = "btnDangXuat";
            btnDangXuat.Size = new Size(232, 29);
            btnDangXuat.TabIndex = 3;
            btnDangXuat.Text = "Đăng xuất";
            btnDangXuat.UseVisualStyleBackColor = true;
            btnDangXuat.Click += btnDangXuat_Click;
            // 
            // btnDanhMuc
            // 
            btnDanhMuc.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnDanhMuc.Location = new Point(4, 118);
            btnDanhMuc.Name = "btnDanhMuc";
            btnDanhMuc.Size = new Size(232, 29);
            btnDanhMuc.TabIndex = 2;
            btnDanhMuc.Text = "Danh mục thuốc";
            btnDanhMuc.UseVisualStyleBackColor = true;
            btnDanhMuc.Click += btnDanhMuc_Click;
            // 
            // btnPhanQuyen
            // 
            btnPhanQuyen.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnPhanQuyen.Location = new Point(3, 78);
            btnPhanQuyen.Name = "btnPhanQuyen";
            btnPhanQuyen.Size = new Size(233, 34);
            btnPhanQuyen.TabIndex = 1;
            btnPhanQuyen.Text = "Người dùng";
            btnPhanQuyen.UseVisualStyleBackColor = true;
            btnPhanQuyen.Click += btnPhanQuyen_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.Location = new Point(4, 24);
            label2.Name = "label2";
            label2.Size = new Size(97, 20);
            label2.TabIndex = 0;
            label2.Text = "CHỨC NĂNG";
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            panel2.Location = new Point(250, 60);
            panel2.Name = "panel2";
            panel2.Size = new Size(1123, 561);
            panel2.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(156, 150);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(8, 9);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(444, 28);
            label4.TabIndex = 2;
            label4.Text = "HỆ THỐNG QUẢN LÝ QUẦY THUỐC BỆNH VIỆN";
            // 
            // lblAdmin
            // 
            lblAdmin.AutoSize = true;
            lblAdmin.Font = new Font("Bahnschrift Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblAdmin.Location = new Point(1193, 17);
            lblAdmin.Name = "lblAdmin";
            lblAdmin.Size = new Size(155, 18);
            lblAdmin.TabIndex = 4;
            lblAdmin.Text = " Trần Văn Trúc | Admin";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ScrollBar;
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(lblAdmin);
            panel3.Controls.Add(label4);
            panel3.Location = new Point(0, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(1373, 57);
            panel3.TabIndex = 3;
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.ControlDark;
            panel5.Location = new Point(0, 52);
            panel5.Name = "panel5";
            panel5.Size = new Size(1373, 24);
            panel5.TabIndex = 1;
            // 
            // button1
            // 
            button1.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(3, 153);
            button1.Name = "button1";
            button1.Size = new Size(232, 29);
            button1.TabIndex = 5;
            button1.Text = "Quản lí thanh toán QRCode";
            button1.UseVisualStyleBackColor = true;
            // 
            // FormAdmin
            // 
            AutoScaleDimensions = new SizeF(12F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1386, 620);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "FormAdmin";
            Text = "Trang Admin";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Label label2;
        private Panel panel2;
        private Button btnPhanQuyen;
        private Button btnDanhMuc;
        private Button btnDangXuat;
        private Label label4;
        private Label lblAdmin;
        private Panel panel3;
        private Label label1;
        private Panel panel4;
        private Panel panel5;
        private Button button1;
    }
}
