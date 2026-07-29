namespace QLQuayThuoc
{
    partial class FormKhoTong
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
            panelContent = new Panel();
            button3 = new Button();
            btn_KhoThuoc = new Button();
            btn_PhieuXinCap = new Button();
            label3 = new Label();
            panelMenu = new Panel();
            lbKhoTong = new Label();
            label1 = new Label();
            panelHeader = new Panel();
            panelMenu.SuspendLayout();
            panelHeader.SuspendLayout();
            SuspendLayout();
            // 
            // panelContent
            // 
            panelContent.BackColor = SystemColors.Window;
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(272, 75);
            panelContent.Margin = new Padding(4);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(1573, 677);
            panelContent.TabIndex = 5;
            // 
            // button3
            // 
            button3.AccessibleRole = AccessibleRole.Clock;
            button3.BackColor = SystemColors.ButtonFace;
            button3.Location = new Point(18, 624);
            button3.Margin = new Padding(4);
            button3.Name = "button3";
            button3.Size = new Size(232, 44);
            button3.TabIndex = 3;
            button3.Text = "Đăng Xuất";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // btn_KhoThuoc
            // 
            btn_KhoThuoc.BackColor = SystemColors.ButtonFace;
            btn_KhoThuoc.Location = new Point(18, 128);
            btn_KhoThuoc.Margin = new Padding(4);
            btn_KhoThuoc.Name = "btn_KhoThuoc";
            btn_KhoThuoc.Size = new Size(232, 44);
            btn_KhoThuoc.TabIndex = 2;
            btn_KhoThuoc.Text = "Tồn kho/Lô thuốc";
            btn_KhoThuoc.UseVisualStyleBackColor = false;
            btn_KhoThuoc.Click += btn_KhoThuoc_Click;
            // 
            // btn_PhieuXinCap
            // 
            btn_PhieuXinCap.BackColor = SystemColors.ButtonFace;
            btn_PhieuXinCap.Location = new Point(18, 75);
            btn_PhieuXinCap.Margin = new Padding(4);
            btn_PhieuXinCap.Name = "btn_PhieuXinCap";
            btn_PhieuXinCap.Size = new Size(232, 44);
            btn_PhieuXinCap.TabIndex = 1;
            btn_PhieuXinCap.Text = "Phiếu xin cấp";
            btn_PhieuXinCap.UseVisualStyleBackColor = false;
            btn_PhieuXinCap.Click += btn_PhieuXinCap_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(33, 24);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(123, 30);
            label3.TabIndex = 0;
            label3.Text = "Chức Năng";
            // 
            // panelMenu
            // 
            panelMenu.BackColor = SystemColors.ControlLight;
            panelMenu.Controls.Add(button3);
            panelMenu.Controls.Add(btn_KhoThuoc);
            panelMenu.Controls.Add(btn_PhieuXinCap);
            panelMenu.Controls.Add(label3);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 75);
            panelMenu.Margin = new Padding(4);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(272, 677);
            panelMenu.TabIndex = 4;
            // 
            // lbKhoTong
            // 
            lbKhoTong.AutoSize = true;
            lbKhoTong.Location = new Point(1514, 27);
            lbKhoTong.Margin = new Padding(4, 0, 4, 0);
            lbKhoTong.Name = "lbKhoTong";
            lbKhoTong.Size = new Size(182, 30);
            lbKhoTong.TabIndex = 1;
            lbKhoTong.Text = "NV | Trần Văn Trúc";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlLight;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(18, 27);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(426, 30);
            label1.TabIndex = 0;
            label1.Text = "Hệ Thống Quản Lý Quầy Thuốc Bệnh Viện";
            // 
            // panelHeader
            // 
            panelHeader.BackColor = SystemColors.ControlLight;
            panelHeader.Controls.Add(lbKhoTong);
            panelHeader.Controls.Add(label1);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Margin = new Padding(4);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1845, 75);
            panelHeader.TabIndex = 3;
            // 
            // FormKhoTong
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1845, 752);
            Controls.Add(panelContent);
            Controls.Add(panelMenu);
            Controls.Add(panelHeader);
            Margin = new Padding(4);
            Name = "FormKhoTong";
            Text = "Quản lý quầy thuốc bệnh viện";
            Load += DuyetPhieuXinCap_Load;
            panelMenu.ResumeLayout(false);
            panelMenu.PerformLayout();
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panelContent;
        private Button button3;
        private Button btn_KhoThuoc;
        private Button btn_PhieuXinCap;
        private Label label3;
        private Panel panelMenu;
        private Label lbKhoTong;
        private Label label1;
        private Panel panelHeader;
    }
}