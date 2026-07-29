namespace QLQuayThuoc.UserControls.UCKhoTong
{
    partial class FrmXemTruocPhieuXinCap
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            toolStrip1 = new ToolStrip();
            tsbIn = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            tsbThuNho = new ToolStripButton();
            tsbPhongTo = new ToolStripButton();
            tsbMotTrang = new ToolStripButton();
            tsbHaiTrang = new ToolStripButton();
            pnlBenPhai = new Panel();
            btnDong = new Button();
            btnInPhieu = new Button();
            previewPhieu = new PrintPreviewControl();
            documentPhieu = new System.Drawing.Printing.PrintDocument();
            printDialog1 = new PrintDialog();
            toolStrip1.SuspendLayout();
            pnlBenPhai.SuspendLayout();
            SuspendLayout();
            // toolStrip1
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { tsbIn, toolStripSeparator1, tsbThuNho, tsbPhongTo, tsbMotTrang, tsbHaiTrang });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Padding = new Padding(10, 4, 10, 4);
            toolStrip1.Size = new Size(1350, 38);
            toolStrip1.TabIndex = 0;
            // tsbIn
            tsbIn.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsbIn.Name = "tsbIn";
            tsbIn.Padding = new Padding(8, 0, 8, 0);
            tsbIn.Size = new Size(48, 27);
            tsbIn.Text = "In";
            // toolStripSeparator1
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 30);
            // tsbThuNho
            tsbThuNho.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsbThuNho.Name = "tsbThuNho";
            tsbThuNho.Padding = new Padding(8, 0, 8, 0);
            tsbThuNho.Size = new Size(89, 27);
            tsbThuNho.Text = "Thu nhỏ";
            // tsbPhongTo
            tsbPhongTo.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsbPhongTo.Name = "tsbPhongTo";
            tsbPhongTo.Padding = new Padding(8, 0, 8, 0);
            tsbPhongTo.Size = new Size(91, 27);
            tsbPhongTo.Text = "Phóng to";
            // tsbMotTrang
            tsbMotTrang.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsbMotTrang.Name = "tsbMotTrang";
            tsbMotTrang.Padding = new Padding(8, 0, 8, 0);
            tsbMotTrang.Size = new Size(101, 27);
            tsbMotTrang.Text = "Một trang";
            // tsbHaiTrang
            tsbHaiTrang.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsbHaiTrang.Name = "tsbHaiTrang";
            tsbHaiTrang.Padding = new Padding(8, 0, 8, 0);
            tsbHaiTrang.Size = new Size(95, 27);
            tsbHaiTrang.Text = "Hai trang";
            // pnlBenPhai
            pnlBenPhai.BackColor = Color.WhiteSmoke;
            pnlBenPhai.Controls.Add(btnDong);
            pnlBenPhai.Controls.Add(btnInPhieu);
            pnlBenPhai.Dock = DockStyle.Right;
            pnlBenPhai.Location = new Point(1120, 38);
            pnlBenPhai.Name = "pnlBenPhai";
            pnlBenPhai.Padding = new Padding(20);
            pnlBenPhai.Size = new Size(230, 712);
            pnlBenPhai.TabIndex = 1;
            // btnDong
            btnDong.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnDong.Font = new Font("Segoe UI", 10F);
            btnDong.Location = new Point(20, 115);
            btnDong.Name = "btnDong";
            btnDong.Size = new Size(190, 52);
            btnDong.TabIndex = 1;
            btnDong.Text = "Đóng";
            btnDong.UseVisualStyleBackColor = true;
            // btnInPhieu
            btnInPhieu.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnInPhieu.BackColor = Color.FromArgb(0, 83, 180);
            btnInPhieu.FlatAppearance.BorderSize = 0;
            btnInPhieu.FlatStyle = FlatStyle.Flat;
            btnInPhieu.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnInPhieu.ForeColor = Color.White;
            btnInPhieu.Location = new Point(20, 35);
            btnInPhieu.Name = "btnInPhieu";
            btnInPhieu.Size = new Size(190, 52);
            btnInPhieu.TabIndex = 0;
            btnInPhieu.Text = "In phiếu";
            btnInPhieu.UseVisualStyleBackColor = false;
            // previewPhieu
            previewPhieu.AutoZoom = true;
            previewPhieu.BackColor = Color.Gainsboro;
            previewPhieu.Dock = DockStyle.Fill;
            previewPhieu.Location = new Point(0, 38);
            previewPhieu.Name = "previewPhieu";
            previewPhieu.Size = new Size(1120, 712);
            previewPhieu.TabIndex = 2;
            previewPhieu.UseAntiAlias = true;
            // printDialog1
            printDialog1.UseEXDialog = true;
            // FrmXemTruocPhieuXinCap
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1350, 750);
            Controls.Add(previewPhieu);
            Controls.Add(pnlBenPhai);
            Controls.Add(toolStrip1);
            MinimumSize = new Size(1000, 650);
            Name = "FrmXemTruocPhieuXinCap";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Xem trước phiếu xin cấp thuốc";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            pnlBenPhai.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton tsbIn;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton tsbThuNho;
        private ToolStripButton tsbPhongTo;
        private ToolStripButton tsbMotTrang;
        private ToolStripButton tsbHaiTrang;
        private Panel pnlBenPhai;
        private Button btnDong;
        private Button btnInPhieu;
        private PrintPreviewControl previewPhieu;
        private System.Drawing.Printing.PrintDocument documentPhieu;
        private PrintDialog printDialog1;
    }
}
