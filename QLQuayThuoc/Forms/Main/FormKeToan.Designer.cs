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
            label2 = new Label();
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
            btnLogout.BackColor = SystemColors.Control;
            btnLogout.Location = new Point(20, 662);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(226, 42);
            btnLogout.TabIndex = 0;
            btnLogout.Text = "Đăng xuất";
            btnLogout.UseVisualStyleBackColor = false;
            // 
            // btnDanhSachHoaDon
            // 
            btnDanhSachHoaDon.BackColor = SystemColors.Control;
            btnDanhSachHoaDon.Location = new Point(20, 53);
            btnDanhSachHoaDon.Name = "btnDanhSachHoaDon";
            btnDanhSachHoaDon.Size = new Size(226, 42);
            btnDanhSachHoaDon.TabIndex = 1;
            btnDanhSachHoaDon.Text = "Danh Sách Hóa Đơn";
            btnDanhSachHoaDon.UseVisualStyleBackColor = false;
            btnDanhSachHoaDon.Click += btnDanhSachHoaDon_Click;
            // 
            // btnBaoCaoDoanhThu
            // 
            btnBaoCaoDoanhThu.BackColor = SystemColors.Control;
            btnBaoCaoDoanhThu.Location = new Point(20, 122);
            btnBaoCaoDoanhThu.Name = "btnBaoCaoDoanhThu";
            btnBaoCaoDoanhThu.Size = new Size(226, 42);
            btnBaoCaoDoanhThu.TabIndex = 2;
            btnBaoCaoDoanhThu.Text = "Báo Cáo Doanh Thu";
            btnBaoCaoDoanhThu.UseVisualStyleBackColor = false;
            btnBaoCaoDoanhThu.Click += btnBaoCaoDoanhThu_Click;
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.Silver;
            panelHeader.Controls.Add(label2);
            panelHeader.Controls.Add(label1);
            panelHeader.Location = new Point(1, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1303, 72);
            panelHeader.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1112, 28);
            label2.Name = "label2";
            label2.Size = new Size(178, 20);
            label2.TabIndex = 1;
            label2.Text = "Phạm Thu Trang | Kế toán";
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
            panelMenu.BackColor = Color.LightGray;
            panelMenu.Controls.Add(label3);
            panelMenu.Controls.Add(btnBaoCaoDoanhThu);
            panelMenu.Controls.Add(btnDanhSachHoaDon);
            panelMenu.Controls.Add(btnLogout);
            panelMenu.Location = new Point(1, 72);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(266, 715);
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
            panelContent.Location = new Point(267, 72);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(1037, 715);
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
        private Label label2;
        private Label label3;
    }
}