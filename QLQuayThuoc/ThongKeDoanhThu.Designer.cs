namespace QLQuayThuoc
{
    partial class frmThongKeDoanhThu
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
            pnMenu = new Panel();
            btnHoaDon = new Button();
            btnTongQuan = new Button();
            lblChucNang = new Label();
            pnHeader = new Panel();
            pnContent = new Panel();
            pnMenu.SuspendLayout();
            SuspendLayout();
            // 
            // pnMenu
            // 
            pnMenu.Controls.Add(btnHoaDon);
            pnMenu.Controls.Add(btnTongQuan);
            pnMenu.Controls.Add(lblChucNang);
            pnMenu.Dock = DockStyle.Left;
            pnMenu.Location = new Point(0, 0);
            pnMenu.Name = "pnMenu";
            pnMenu.Size = new Size(158, 450);
            pnMenu.TabIndex = 0;
            // 
            // btnHoaDon
            // 
            btnHoaDon.Location = new Point(12, 70);
            btnHoaDon.Name = "btnHoaDon";
            btnHoaDon.Size = new Size(136, 38);
            btnHoaDon.TabIndex = 2;
            btnHoaDon.Text = "Hóa đơn";
            btnHoaDon.UseVisualStyleBackColor = true;
            btnHoaDon.Click += btnHoaDon_Click;
            // 
            // btnTongQuan
            // 
            btnTongQuan.Location = new Point(12, 24);
            btnTongQuan.Name = "btnTongQuan";
            btnTongQuan.Size = new Size(136, 40);
            btnTongQuan.TabIndex = 1;
            btnTongQuan.Text = "Tổng quan doanh thu";
            btnTongQuan.UseVisualStyleBackColor = true;
            btnTongQuan.Click += btnTongQuan_Click;
            // 
            // lblChucNang
            // 
            lblChucNang.AutoSize = true;
            lblChucNang.Font = new Font("Segoe UI Semibold", 6.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblChucNang.Location = new Point(19, 9);
            lblChucNang.Name = "lblChucNang";
            lblChucNang.Size = new Size(59, 12);
            lblChucNang.TabIndex = 0;
            lblChucNang.Text = "CHỨC NĂNG";
            // 
            // pnHeader
            // 
            pnHeader.Dock = DockStyle.Top;
            pnHeader.Location = new Point(158, 0);
            pnHeader.Name = "pnHeader";
            pnHeader.Size = new Size(642, 70);
            pnHeader.TabIndex = 1;
            // 
            // pnContent
            // 
            pnContent.Dock = DockStyle.Fill;
            pnContent.Location = new Point(158, 70);
            pnContent.Name = "pnContent";
            pnContent.Size = new Size(642, 380);
            pnContent.TabIndex = 2;
            // 
            // frmThongKeDoanhThu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pnContent);
            Controls.Add(pnHeader);
            Controls.Add(pnMenu);
            Name = "frmThongKeDoanhThu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thống kê doanh thu";
            WindowState = FormWindowState.Minimized;
            Load += frmThongKeDoanhThu_Load;
            pnMenu.ResumeLayout(false);
            pnMenu.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnMenu;
        private Panel pnHeader;
        private Panel pnContent;
        private Label lblChucNang;
        private Button btnHoaDon;
        private Button btnTongQuan;
    }
}