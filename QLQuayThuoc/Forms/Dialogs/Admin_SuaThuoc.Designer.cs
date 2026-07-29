namespace QLQuayThuoc.Forms.Dialogs
{
    partial class Admin_SuaThuoc
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
            cbDonViTinh = new ComboBox();
            nudDonGia = new NumericUpDown();
            btnHuy = new Button();
            btnXacNhan = new Button();
            label5 = new Label();
            txtHamLuong = new TextBox();
            label4 = new Label();
            txtHoatChat = new TextBox();
            label3 = new Label();
            label2 = new Label();
            txtTenThuoc = new TextBox();
            label1 = new Label();
            label7 = new Label();
            cbBHYT = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)nudDonGia).BeginInit();
            SuspendLayout();
            // 
            // cbDonViTinh
            // 
            cbDonViTinh.FormattingEnabled = true;
            cbDonViTinh.Location = new Point(130, 86);
            cbDonViTinh.Name = "cbDonViTinh";
            cbDonViTinh.Size = new Size(227, 28);
            cbDonViTinh.TabIndex = 31;
            // 
            // nudDonGia
            // 
            nudDonGia.Location = new Point(130, 242);
            nudDonGia.Name = "nudDonGia";
            nudDonGia.Size = new Size(227, 27);
            nudDonGia.TabIndex = 30;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(170, 355);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(94, 29);
            btnHuy.TabIndex = 29;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // btnXacNhan
            // 
            btnXacNhan.Location = new Point(292, 355);
            btnXacNhan.Name = "btnXacNhan";
            btnXacNhan.Size = new Size(94, 29);
            btnXacNhan.TabIndex = 28;
            btnXacNhan.Text = "Xác nhận";
            btnXacNhan.UseVisualStyleBackColor = true;
            btnXacNhan.Click += btnXacNhan_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(33, 244);
            label5.Name = "label5";
            label5.Size = new Size(91, 20);
            label5.TabIndex = 24;
            label5.Text = "Đơn giá bán";
            // 
            // txtHamLuong
            // 
            txtHamLuong.Location = new Point(130, 191);
            txtHamLuong.Name = "txtHamLuong";
            txtHamLuong.Size = new Size(227, 27);
            txtHamLuong.TabIndex = 23;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(40, 194);
            label4.Name = "label4";
            label4.Size = new Size(84, 20);
            label4.TabIndex = 22;
            label4.Text = "Hàm lượng";
            // 
            // txtHoatChat
            // 
            txtHoatChat.Location = new Point(130, 138);
            txtHoatChat.Name = "txtHoatChat";
            txtHoatChat.Size = new Size(227, 27);
            txtHoatChat.TabIndex = 21;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(50, 141);
            label3.Name = "label3";
            label3.Size = new Size(74, 20);
            label3.TabIndex = 20;
            label3.Text = "Hoạt chất";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 89);
            label2.Name = "label2";
            label2.Size = new Size(81, 20);
            label2.TabIndex = 19;
            label2.Text = "Đơn vị tính";
            // 
            // txtTenThuoc
            // 
            txtTenThuoc.Location = new Point(130, 33);
            txtTenThuoc.Name = "txtTenThuoc";
            txtTenThuoc.Size = new Size(227, 27);
            txtTenThuoc.TabIndex = 18;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 36);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 17;
            label1.Text = "Tên thuốc";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(34, 292);
            label7.Name = "label7";
            label7.Size = new Size(90, 20);
            label7.TabIndex = 32;
            label7.Text = "BHYT chi trả";
            // 
            // cbBHYT
            // 
            cbBHYT.FormattingEnabled = true;
            cbBHYT.Items.AddRange(new object[] { "Có", "Không" });
            cbBHYT.Location = new Point(130, 289);
            cbBHYT.Name = "cbBHYT";
            cbBHYT.Size = new Size(227, 28);
            cbBHYT.TabIndex = 33;
            // 
            // SuaThuoc
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(416, 400);
            Controls.Add(cbBHYT);
            Controls.Add(label7);
            Controls.Add(cbDonViTinh);
            Controls.Add(nudDonGia);
            Controls.Add(btnHuy);
            Controls.Add(btnXacNhan);
            Controls.Add(label5);
            Controls.Add(txtHamLuong);
            Controls.Add(label4);
            Controls.Add(txtHoatChat);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtTenThuoc);
            Controls.Add(label1);
            Name = "SuaThuoc";
            Text = "Sửa thuốc";
            Load += SuaThuoc_Load;
            ((System.ComponentModel.ISupportInitialize)nudDonGia).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbDonViTinh;
        private NumericUpDown nudDonGia;
        private Button btnHuy;
        private Button btnXacNhan;
        private Label label5;
        private TextBox txtHamLuong;
        private Label label4;
        private TextBox txtHoatChat;
        private Label label3;
        private Label label2;
        private TextBox txtTenThuoc;
        private Label label1;
        private Label label7;
        private ComboBox cbBHYT;
    }
}