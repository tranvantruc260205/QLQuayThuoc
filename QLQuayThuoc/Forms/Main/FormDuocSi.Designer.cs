namespace QLQuayThuoc
{
    partial class FormDuocSi
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
            panel1 = new Panel();
            lblDuocSi = new Label();
            panel3 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            panel4 = new Panel();
            btnLichSu = new Button();
            btnDangXuat = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label3 = new Label();
            panel5 = new Panel();
            panel6 = new Panel();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Silver;
            panel1.Controls.Add(lblDuocSi);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(2, 2);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1138, 46);
            panel1.TabIndex = 0;
            // 
            // lblDuocSi
            // 
            lblDuocSi.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblDuocSi.AutoSize = true;
            lblDuocSi.Location = new Point(907, 14);
            lblDuocSi.Margin = new Padding(2, 0, 2, 0);
            lblDuocSi.Name = "lblDuocSi";
            lblDuocSi.Size = new Size(196, 20);
            lblDuocSi.TabIndex = 3;
            lblDuocSi.Text = "DS. Trần Minh Anh | Dược sĩ ";
            // 
            // panel3
            // 
            panel3.Location = new Point(201, 48);
            panel3.Margin = new Padding(2);
            panel3.Name = "panel3";
            panel3.Size = new Size(932, 521);
            panel3.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(10, 10);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(456, 28);
            label1.TabIndex = 2;
            label1.Text = "HỆ THỐNG QUẢN LÝ QUẦY THUỐC BỆNH VIỆN";
            // 
            // panel2
            // 
            panel2.Location = new Point(2, 48);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(234, 534);
            panel2.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.BackColor = Color.LightGray;
            panel4.Controls.Add(btnLichSu);
            panel4.Controls.Add(btnDangXuat);
            panel4.Controls.Add(button3);
            panel4.Controls.Add(button2);
            panel4.Controls.Add(button1);
            panel4.Controls.Add(label3);
            panel4.Location = new Point(2, 50);
            panel4.Margin = new Padding(2);
            panel4.Name = "panel4";
            panel4.Size = new Size(197, 521);
            panel4.TabIndex = 2;
            // 
            // btnLichSu
            // 
            btnLichSu.Location = new Point(22, 88);
            btnLichSu.Margin = new Padding(2);
            btnLichSu.Name = "btnLichSu";
            btnLichSu.Size = new Size(146, 30);
            btnLichSu.TabIndex = 5;
            btnLichSu.Text = "Lịch sử xuất thuốc";
            btnLichSu.UseVisualStyleBackColor = true;
            btnLichSu.Click += btnLichSu_Click;
            // 
            // btnDangXuat
            // 
            btnDangXuat.Location = new Point(22, 474);
            btnDangXuat.Margin = new Padding(2);
            btnDangXuat.Name = "btnDangXuat";
            btnDangXuat.Size = new Size(146, 30);
            btnDangXuat.TabIndex = 4;
            btnDangXuat.Text = "Đăng xuất";
            btnDangXuat.UseVisualStyleBackColor = true;
            btnDangXuat.Click += btnDangXuat_Click;
            // 
            // button3
            // 
            button3.Location = new Point(22, 190);
            button3.Margin = new Padding(2);
            button3.Name = "button3";
            button3.Size = new Size(146, 30);
            button3.TabIndex = 3;
            button3.Text = "Phiếu xin cấp";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(22, 137);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(146, 30);
            button2.TabIndex = 2;
            button2.Text = "Tồn kho quầy";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.Location = new Point(22, 42);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(146, 30);
            button1.TabIndex = 1;
            button1.Text = "Tiếp nhận đơn";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.LightGray;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(10, 10);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(83, 20);
            label3.TabIndex = 0;
            label3.Text = "Chức năng";
            // 
            // panel5
            // 
            panel5.Controls.Add(panel6);
            panel5.Location = new Point(198, 50);
            panel5.Margin = new Padding(2);
            panel5.Name = "panel5";
            panel5.Size = new Size(937, 521);
            panel5.TabIndex = 5;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Transparent;
            panel6.Location = new Point(6, 0);
            panel6.Margin = new Padding(2);
            panel6.Name = "panel6";
            panel6.Size = new Size(937, 526);
            panel6.TabIndex = 5;
            // 
            // FormDuocSi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1147, 575);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel1);
            Margin = new Padding(2);
            Name = "FormDuocSi";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý quầy thuốc bệnh viện";
            Load += FormDuocSi_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Label lblDuocSi;
        private Button btnDangXuat;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label label3;
        private Panel panel5;
        private Panel panel6;
        private Button btnLichSu;
    }
}