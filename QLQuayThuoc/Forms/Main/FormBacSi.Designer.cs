namespace QLQuayThuoc
{
    partial class FormBacSi
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
            panelHeader = new Panel();
            lblBacSi = new Label();
            label1 = new Label();
            panelMenu = new Panel();
            btnDangXuat = new Button();
            btn_KeDonMoi = new Button();
            btn_DonThuoc = new Button();
            label3 = new Label();
            panelContent = new Panel();
            panelHeader.SuspendLayout();
            panelMenu.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = SystemColors.ControlLight;
            panelHeader.Controls.Add(lblBacSi);
            panelHeader.Controls.Add(label1);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1226, 50);
            panelHeader.TabIndex = 0;
            // 
            // lblBacSi
            // 
            lblBacSi.AutoSize = true;
            lblBacSi.Location = new Point(1004, 18);
            lblBacSi.Name = "lblBacSi";
            lblBacSi.Size = new Size(186, 20);
            lblBacSi.TabIndex = 1;
            lblBacSi.Text = "Bác Sĩ | Phạm Thành Nghĩa";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlLight;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(300, 20);
            label1.TabIndex = 0;
            label1.Text = "Hệ Thống Quản Lý Quầy Thuốc Bệnh Viện";
            // 
            // panelMenu
            // 
            panelMenu.BackColor = SystemColors.ControlLight;
            panelMenu.Controls.Add(btnDangXuat);
            panelMenu.Controls.Add(btn_KeDonMoi);
            panelMenu.Controls.Add(btn_DonThuoc);
            panelMenu.Controls.Add(label3);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 50);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(130, 495);
            panelMenu.TabIndex = 1;
            // 
            // btnDangXuat
            // 
            btnDangXuat.AccessibleRole = AccessibleRole.Clock;
            btnDangXuat.BackColor = SystemColors.ButtonFace;
            btnDangXuat.Location = new Point(12, 454);
            btnDangXuat.Name = "btnDangXuat";
            btnDangXuat.Size = new Size(104, 29);
            btnDangXuat.TabIndex = 3;
            btnDangXuat.Text = "Đăng Xuất";
            btnDangXuat.UseVisualStyleBackColor = false;
            btnDangXuat.Click += btnDangXuat_Click;
            // 
            // btn_KeDonMoi
            // 
            btn_KeDonMoi.BackColor = SystemColors.ButtonFace;
            btn_KeDonMoi.Location = new Point(12, 85);
            btn_KeDonMoi.Name = "btn_KeDonMoi";
            btn_KeDonMoi.Size = new Size(104, 29);
            btn_KeDonMoi.TabIndex = 2;
            btn_KeDonMoi.Text = "Kê Đơn Mới";
            btn_KeDonMoi.UseVisualStyleBackColor = false;
            btn_KeDonMoi.Click += btn_KeDonMoi_Click;
            // 
            // btn_DonThuoc
            // 
            btn_DonThuoc.BackColor = SystemColors.Control;
            btn_DonThuoc.FlatAppearance.BorderColor = SystemColors.Desktop;
            btn_DonThuoc.FlatStyle = FlatStyle.Flat;
            btn_DonThuoc.Location = new Point(12, 50);
            btn_DonThuoc.Name = "btn_DonThuoc";
            btn_DonThuoc.Size = new Size(104, 29);
            btn_DonThuoc.TabIndex = 1;
            btn_DonThuoc.Text = "Đơn Thuốc";
            btn_DonThuoc.UseVisualStyleBackColor = false;
            btn_DonThuoc.Click += btn_DonThuoc_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(22, 16);
            label3.Name = "label3";
            label3.Size = new Size(86, 20);
            label3.TabIndex = 0;
            label3.Text = "Chức Năng";
            // 
            // panelContent
            // 
            panelContent.BackColor = SystemColors.Window;
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(130, 50);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(1096, 495);
            panelContent.TabIndex = 2;
            // 
            // FormBacSi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1226, 545);
            Controls.Add(panelContent);
            Controls.Add(panelMenu);
            Controls.Add(panelHeader);
            Name = "FormBacSi";
            Text = "Quản Lý Quầy Thuốc Bệnh Viện";
            Load += DanhSachDonThuoc_Load;
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelMenu.ResumeLayout(false);
            panelMenu.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Label lblBacSi;
        private Label label1;
        private Panel panelMenu;
        private Button btn_KeDonMoi;
        private Button btn_DonThuoc;
        private Label label3;
        private Button btnDangXuat;
        private Panel panelContent;
    }
}