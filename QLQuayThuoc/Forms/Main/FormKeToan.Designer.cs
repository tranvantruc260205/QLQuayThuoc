namespace QLQuayThuoc.Forms.Main
{
    partial class FormKeToan
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
            Button btnLogout;
            Button btnDanhSachHoaDon;
            Button btnBaoCaoDoanhThu;
            panelHeader = new Panel();
            lbKeToan = new Label();
            label1 = new Label();
            panelMenu = new Panel();
            label3 = new Label();
            panelContent = new Panel();
            btnLogout = new Button();
            btnDanhSachHoaDon = new Button();
            btnBaoCaoDoanhThu = new Button();
            panelHeader.SuspendLayout();
            panelMenu.SuspendLayout();
            SuspendLayout();
            // 
            // btnLogout
            // 
            btnLogout.BackColor = SystemColors.ButtonFace;
            btnLogout.Location = new Point(7, 671);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(140, 33);
            btnLogout.TabIndex = 0;
            btnLogout.Text = "Đăng xuất";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnDanhSachHoaDon
            // 
            btnDanhSachHoaDon.BackColor = SystemColors.ButtonFace;
            btnDanhSachHoaDon.Location = new Point(3, 48);
            btnDanhSachHoaDon.Name = "btnDanhSachHoaDon";
            btnDanhSachHoaDon.Size = new Size(153, 36);
            btnDanhSachHoaDon.TabIndex = 1;
            btnDanhSachHoaDon.Text = "Danh Sách Hóa Đơn";
            btnDanhSachHoaDon.UseVisualStyleBackColor = false;
            btnDanhSachHoaDon.Click += btnDanhSachHoaDon_Click;
            // 
            // btnBaoCaoDoanhThu
            // 
            btnBaoCaoDoanhThu.BackColor = SystemColors.ButtonFace;
            btnBaoCaoDoanhThu.Location = new Point(3, 107);
            btnBaoCaoDoanhThu.Name = "btnBaoCaoDoanhThu";
            btnBaoCaoDoanhThu.Size = new Size(153, 35);
            btnBaoCaoDoanhThu.TabIndex = 2;
            btnBaoCaoDoanhThu.Text = "Báo Cáo Doanh Thu";
            btnBaoCaoDoanhThu.UseVisualStyleBackColor = false;
            btnBaoCaoDoanhThu.Click += btnBaoCaoDoanhThu_Click;
            // 
            // panelHeader
            // 
            panelHeader.BackColor = SystemColors.Control;
            panelHeader.Controls.Add(lbKeToan);
            panelHeader.Controls.Add(label1);
            panelHeader.Location = new Point(1, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1303, 72);
            panelHeader.TabIndex = 0;
            // 
            // lbKeToan
            // 
            lbKeToan.AutoSize = true;
            lbKeToan.Location = new Point(1062, 28);
            lbKeToan.Name = "lbKeToan";
            lbKeToan.Size = new Size(178, 20);
            lbKeToan.TabIndex = 1;
            lbKeToan.Text = "Phạm Thu Trang | Kế toán";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(11, 19);
            label1.Name = "label1";
            label1.Size = new Size(519, 31);
            label1.TabIndex = 0;
            label1.Text = "HỆ THỐNG QUẢN LÝ QUẦY THUỐC BỆNH VIỆN";
            // 
            // panelMenu
            // 
            panelMenu.BackColor = SystemColors.Control;
            panelMenu.Controls.Add(label3);
            panelMenu.Controls.Add(btnBaoCaoDoanhThu);
            panelMenu.Controls.Add(btnDanhSachHoaDon);
            panelMenu.Controls.Add(btnLogout);
            panelMenu.Location = new Point(1, 72);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(169, 715);
            panelMenu.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(20, 3);
            label3.Name = "label3";
            label3.Size = new Size(99, 25);
            label3.TabIndex = 0;
            label3.Text = "Chức năng";
            // 
            // panelContent
            // 
            panelContent.BackColor = SystemColors.ControlLightLight;
            panelContent.Location = new Point(163, 72);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(1141, 715);
            panelContent.TabIndex = 2;
            // 
            // FormKeToan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1304, 788);
            Controls.Add(panelContent);
            Controls.Add(panelMenu);
            Controls.Add(panelHeader);
            Name = "FormKeToan";
            Text = "Quản lý quầy thuốc bệnh viện";
            Load += FormKeToan_Load;
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelMenu.ResumeLayout(false);
            panelMenu.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Panel panelMenu;
        private Panel panelContent;
        private Label label1;
        private Label lbKeToan;
        private Label label3;
    }
}