namespace QLQuayThuoc.Forms.Dialogs
{
    partial class ThemSuaThuocDonThuoc
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
            dgv = new DataGridView();
            label1 = new Label();
            txtTimKiem = new TextBox();
            btnTimKiem = new Button();
            label2 = new Label();
            txtSoLuong = new TextBox();
            txtLieuDung = new TextBox();
            label3 = new Label();
            txtTanSuat = new TextBox();
            label4 = new Label();
            txtSoNgay = new TextBox();
            label5 = new Label();
            label6 = new Label();
            txtGhiChu = new RichTextBox();
            btnXacNhan = new Button();
            btnDong = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            SuspendLayout();
            // 
            // dgv
            // 
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Location = new Point(12, 74);
            dgv.Name = "dgv";
            dgv.RowHeadersWidth = 51;
            dgv.RowTemplate.Height = 29;
            dgv.Size = new Size(833, 314);
            dgv.TabIndex = 0;
            dgv.SelectionChanged += dgv_SelectionChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 22);
            label1.Name = "label1";
            label1.Size = new Size(70, 20);
            label1.TabIndex = 1;
            label1.Text = "Tìm kiếm";
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(88, 19);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(281, 27);
            txtTimKiem.TabIndex = 2;
            txtTimKiem.KeyDown += txtTimKiem_KeyDown;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(394, 18);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(94, 29);
            btnTimKiem.TabIndex = 3;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 407);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 4;
            label2.Text = "Số lượng";
            // 
            // txtSoLuong
            // 
            txtSoLuong.Location = new Point(88, 404);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(125, 27);
            txtSoLuong.TabIndex = 5;
            // 
            // txtLieuDung
            // 
            txtLieuDung.Location = new Point(324, 404);
            txtLieuDung.Name = "txtLieuDung";
            txtLieuDung.Size = new Size(194, 27);
            txtLieuDung.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(244, 407);
            label3.Name = "label3";
            label3.Size = new Size(74, 20);
            label3.TabIndex = 6;
            label3.Text = "Liều dùng";
            // 
            // txtTanSuat
            // 
            txtTanSuat.Location = new Point(624, 404);
            txtTanSuat.Name = "txtTanSuat";
            txtTanSuat.Size = new Size(181, 27);
            txtTanSuat.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(548, 407);
            label4.Name = "label4";
            label4.Size = new Size(64, 20);
            label4.TabIndex = 8;
            label4.Text = "Tần suất";
            // 
            // txtSoNgay
            // 
            txtSoNgay.Location = new Point(88, 460);
            txtSoNgay.Name = "txtSoNgay";
            txtSoNgay.Size = new Size(125, 27);
            txtSoNgay.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 463);
            label5.Name = "label5";
            label5.Size = new Size(62, 20);
            label5.TabIndex = 10;
            label5.Text = "Số ngày";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(248, 463);
            label6.Name = "label6";
            label6.Size = new Size(58, 20);
            label6.TabIndex = 12;
            label6.Text = "Ghi chú";
            // 
            // txtGhiChu
            // 
            txtGhiChu.Location = new Point(324, 457);
            txtGhiChu.Name = "txtGhiChu";
            txtGhiChu.Size = new Size(194, 72);
            txtGhiChu.TabIndex = 13;
            txtGhiChu.Text = "";
            // 
            // btnXacNhan
            // 
            btnXacNhan.Location = new Point(734, 549);
            btnXacNhan.Name = "btnXacNhan";
            btnXacNhan.Size = new Size(94, 29);
            btnXacNhan.TabIndex = 14;
            btnXacNhan.Text = "Xác nhận";
            btnXacNhan.UseVisualStyleBackColor = true;
            btnXacNhan.Click += btnXacNhan_Click;
            // 
            // btnDong
            // 
            btnDong.Location = new Point(599, 549);
            btnDong.Name = "btnDong";
            btnDong.Size = new Size(94, 29);
            btnDong.TabIndex = 15;
            btnDong.Text = "Đóng";
            btnDong.UseVisualStyleBackColor = true;
            btnDong.Click += btnDong_Click;
            // 
            // ThemSuaThuocDonThuoc
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(857, 601);
            Controls.Add(btnDong);
            Controls.Add(btnXacNhan);
            Controls.Add(txtGhiChu);
            Controls.Add(label6);
            Controls.Add(txtSoNgay);
            Controls.Add(label5);
            Controls.Add(txtTanSuat);
            Controls.Add(label4);
            Controls.Add(txtLieuDung);
            Controls.Add(label3);
            Controls.Add(txtSoLuong);
            Controls.Add(label2);
            Controls.Add(btnTimKiem);
            Controls.Add(txtTimKiem);
            Controls.Add(label1);
            Controls.Add(dgv);
            Name = "ThemSuaThuocDonThuoc";
            Text = "Thêm / Sửa thuốc";
            Load += ThemSuaThuocDonThuoc_Load;
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv;
        private Label label1;
        private TextBox txtTimKiem;
        private Button btnTimKiem;
        private Label label2;
        private TextBox txtSoLuong;
        private TextBox txtLieuDung;
        private Label label3;
        private TextBox txtTanSuat;
        private Label label4;
        private TextBox txtSoNgay;
        private Label label5;
        private Label label6;
        private RichTextBox txtGhiChu;
        private Button btnXacNhan;
        private Button btnDong;
    }
}