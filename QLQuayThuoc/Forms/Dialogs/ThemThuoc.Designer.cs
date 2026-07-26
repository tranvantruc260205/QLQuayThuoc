namespace QLQuayThuoc.Forms.Dialogs
{
    partial class ThemThuoc
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
            txtTenThuoc = new TextBox();
            label2 = new Label();
            txtHoatChat = new TextBox();
            label3 = new Label();
            txtHamLuong = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            rdoDangKD = new RadioButton();
            rdoTamNgung = new RadioButton();
            btnXacNhan = new Button();
            btnHuy = new Button();
            nudDonGia = new NumericUpDown();
            cbDonViTinh = new ComboBox();
            label7 = new Label();
            cbBHYT = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)nudDonGia).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 54);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 0;
            label1.Text = "Tên thuốc";
            // 
            // txtTenThuoc
            // 
            txtTenThuoc.Location = new Point(114, 51);
            txtTenThuoc.Name = "txtTenThuoc";
            txtTenThuoc.Size = new Size(227, 27);
            txtTenThuoc.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 107);
            label2.Name = "label2";
            label2.Size = new Size(81, 20);
            label2.TabIndex = 2;
            label2.Text = "Đơn vị tính";
            // 
            // txtHoatChat
            // 
            txtHoatChat.Location = new Point(114, 156);
            txtHoatChat.Name = "txtHoatChat";
            txtHoatChat.Size = new Size(227, 27);
            txtHoatChat.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 159);
            label3.Name = "label3";
            label3.Size = new Size(74, 20);
            label3.TabIndex = 4;
            label3.Text = "Hoạt chất";
            // 
            // txtHamLuong
            // 
            txtHamLuong.Location = new Point(114, 209);
            txtHamLuong.Name = "txtHamLuong";
            txtHamLuong.Size = new Size(227, 27);
            txtHamLuong.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 212);
            label4.Name = "label4";
            label4.Size = new Size(84, 20);
            label4.TabIndex = 6;
            label4.Text = "Hàm lượng";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(17, 262);
            label5.Name = "label5";
            label5.Size = new Size(91, 20);
            label5.TabIndex = 8;
            label5.Text = "Đơn giá bán";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(33, 366);
            label6.Name = "label6";
            label6.Size = new Size(75, 20);
            label6.TabIndex = 10;
            label6.Text = "Trạng thái";
            // 
            // rdoDangKD
            // 
            rdoDangKD.AutoSize = true;
            rdoDangKD.Location = new Point(114, 364);
            rdoDangKD.Name = "rdoDangKD";
            rdoDangKD.Size = new Size(143, 24);
            rdoDangKD.TabIndex = 11;
            rdoDangKD.TabStop = true;
            rdoDangKD.Text = "Đang kinh doanh";
            rdoDangKD.UseVisualStyleBackColor = true;
            // 
            // rdoTamNgung
            // 
            rdoTamNgung.AutoSize = true;
            rdoTamNgung.Location = new Point(264, 364);
            rdoTamNgung.Name = "rdoTamNgung";
            rdoTamNgung.Size = new Size(106, 24);
            rdoTamNgung.TabIndex = 12;
            rdoTamNgung.TabStop = true;
            rdoTamNgung.Text = "Tạm ngừng";
            rdoTamNgung.UseVisualStyleBackColor = true;
            // 
            // btnXacNhan
            // 
            btnXacNhan.Location = new Point(276, 418);
            btnXacNhan.Name = "btnXacNhan";
            btnXacNhan.Size = new Size(94, 29);
            btnXacNhan.TabIndex = 13;
            btnXacNhan.Text = "Xác nhận";
            btnXacNhan.UseVisualStyleBackColor = true;
            btnXacNhan.Click += btnXacNhan_Click;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(154, 418);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(94, 29);
            btnHuy.TabIndex = 14;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // nudDonGia
            // 
            nudDonGia.Location = new Point(114, 260);
            nudDonGia.Name = "nudDonGia";
            nudDonGia.Size = new Size(227, 27);
            nudDonGia.TabIndex = 15;
            // 
            // cbDonViTinh
            // 
            cbDonViTinh.FormattingEnabled = true;
            cbDonViTinh.Location = new Point(114, 104);
            cbDonViTinh.Name = "cbDonViTinh";
            cbDonViTinh.Size = new Size(227, 28);
            cbDonViTinh.TabIndex = 16;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(18, 318);
            label7.Name = "label7";
            label7.Size = new Size(90, 20);
            label7.TabIndex = 17;
            label7.Text = "BHYT chi trả";
            // 
            // cbBHYT
            // 
            cbBHYT.FormattingEnabled = true;
            cbBHYT.Items.AddRange(new object[] { "Có", "Không" });
            cbBHYT.Location = new Point(114, 315);
            cbBHYT.Name = "cbBHYT";
            cbBHYT.Size = new Size(227, 28);
            cbBHYT.TabIndex = 18;
            // 
            // ThemThuoc
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(403, 465);
            Controls.Add(cbBHYT);
            Controls.Add(label7);
            Controls.Add(cbDonViTinh);
            Controls.Add(nudDonGia);
            Controls.Add(btnHuy);
            Controls.Add(btnXacNhan);
            Controls.Add(rdoTamNgung);
            Controls.Add(rdoDangKD);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtHamLuong);
            Controls.Add(label4);
            Controls.Add(txtHoatChat);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtTenThuoc);
            Controls.Add(label1);
            Name = "ThemThuoc";
            Text = "Thêm thuốc mới";
            ((System.ComponentModel.ISupportInitialize)nudDonGia).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtTenThuoc;
        private Label label2;
        private TextBox txtHoatChat;
        private Label label3;
        private TextBox txtHamLuong;
        private Label label4;
        private Label label5;
        private Label label6;
        private RadioButton rdoDangKD;
        private RadioButton rdoTamNgung;
        private Button btnXacNhan;
        private Button btnHuy;
        private NumericUpDown nudDonGia;
        private ComboBox cbDonViTinh;
        private Label label7;
        private ComboBox cbBHYT;
    }
}