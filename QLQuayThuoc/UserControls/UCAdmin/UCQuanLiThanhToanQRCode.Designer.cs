namespace QLQuayThuoc.UserControls.UCAdmin
{
    partial class UCQuanLiThanhToanQRCode
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            groupBox1 = new GroupBox();
            label12 = new Label();
            label7 = new Label();
            txtSTK = new TextBox();
            txtTienTo = new TextBox();
            label6 = new Label();
            txtChuTK = new TextBox();
            label5 = new Label();
            txtPassword = new TextBox();
            label4 = new Label();
            txtTokenApi = new TextBox();
            label3 = new Label();
            txtUrlApi = new TextBox();
            label2 = new Label();
            groupBox2 = new GroupBox();
            txtMaNganHang = new TextBox();
            label13 = new Label();
            txtTemplateID = new TextBox();
            label10 = new Label();
            label9 = new Label();
            txtUrlTaoQR = new TextBox();
            label8 = new Label();
            btnLuu = new Button();
            btnBatTat = new Button();
            label11 = new Label();
            lblTrangThai = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(0, 9);
            label1.Name = "label1";
            label1.Size = new Size(492, 31);
            label1.TabIndex = 1;
            label1.Text = "Quản Lí Thanh Toán QRCode (Auto Payment)";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtSTK);
            groupBox1.Controls.Add(txtTienTo);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtChuTK);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtPassword);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtTokenApi);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtUrlApi);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(15, 91);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(477, 357);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cấu hình API Bank";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 7.8F, FontStyle.Italic, GraphicsUnit.Point);
            label12.Location = new Point(6, 337);
            label12.Name = "label12";
            label12.Size = new Size(300, 17);
            label12.TabIndex = 12;
            label12.Text = "API Auto Bank được cung cấp bởi api.sieuthicode.net";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 139);
            label7.Name = "label7";
            label7.Size = new Size(47, 20);
            label7.TabIndex = 10;
            label7.Text = "Số TK";
            // 
            // txtSTK
            // 
            txtSTK.Location = new Point(93, 136);
            txtSTK.Name = "txtSTK";
            txtSTK.Size = new Size(343, 27);
            txtSTK.TabIndex = 11;
            // 
            // txtTienTo
            // 
            txtTienTo.Location = new Point(152, 287);
            txtTienTo.Name = "txtTienTo";
            txtTienTo.Size = new Size(284, 27);
            txtTienTo.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 290);
            label6.Name = "label6";
            label6.Size = new Size(140, 20);
            label6.TabIndex = 8;
            label6.Text = "Tiền tố nội dung CK";
            // 
            // txtChuTK
            // 
            txtChuTK.Location = new Point(93, 235);
            txtChuTK.Name = "txtChuTK";
            txtChuTK.Size = new Size(343, 27);
            txtChuTK.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 238);
            label5.Name = "label5";
            label5.Size = new Size(55, 20);
            label5.TabIndex = 6;
            label5.Text = "Chủ TK";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(93, 183);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(343, 27);
            txtPassword.TabIndex = 5;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 186);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 4;
            label4.Text = "Password";
            // 
            // txtTokenApi
            // 
            txtTokenApi.Location = new Point(93, 88);
            txtTokenApi.Name = "txtTokenApi";
            txtTokenApi.Size = new Size(343, 27);
            txtTokenApi.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 91);
            label3.Name = "label3";
            label3.Size = new Size(74, 20);
            label3.TabIndex = 2;
            label3.Text = "Token API";
            // 
            // txtUrlApi
            // 
            txtUrlApi.Location = new Point(93, 40);
            txtUrlApi.Name = "txtUrlApi";
            txtUrlApi.Size = new Size(343, 27);
            txtUrlApi.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 43);
            label2.Name = "label2";
            label2.Size = new Size(61, 20);
            label2.TabIndex = 0;
            label2.Text = "URL API";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtMaNganHang);
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(txtTemplateID);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(txtUrlTaoQR);
            groupBox2.Controls.Add(label8);
            groupBox2.Location = new Point(498, 91);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(477, 357);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Cấu hình tạo QRCode";
            // 
            // txtMaNganHang
            // 
            txtMaNganHang.Location = new Point(116, 88);
            txtMaNganHang.Name = "txtMaNganHang";
            txtMaNganHang.Size = new Size(343, 27);
            txtMaNganHang.TabIndex = 14;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 7.8F, FontStyle.Italic, GraphicsUnit.Point);
            label13.Location = new Point(0, 337);
            label13.Name = "label13";
            label13.Size = new Size(247, 17);
            label13.TabIndex = 13;
            label13.Text = "QRCode được tạo bởi quicklink tại vietqr.io";
            // 
            // txtTemplateID
            // 
            txtTemplateID.Location = new Point(116, 136);
            txtTemplateID.Name = "txtTemplateID";
            txtTemplateID.Size = new Size(343, 27);
            txtTemplateID.TabIndex = 7;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(9, 139);
            label10.Name = "label10";
            label10.Size = new Size(90, 20);
            label10.TabIndex = 6;
            label10.Text = "Template ID";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(9, 91);
            label9.Name = "label9";
            label9.Size = new Size(104, 20);
            label9.TabIndex = 4;
            label9.Text = "Mã ngân hàng";
            // 
            // txtUrlTaoQR
            // 
            txtUrlTaoQR.Location = new Point(116, 40);
            txtUrlTaoQR.Name = "txtUrlTaoQR";
            txtUrlTaoQR.Size = new Size(343, 27);
            txtUrlTaoQR.TabIndex = 3;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 43);
            label8.Name = "label8";
            label8.Size = new Size(85, 20);
            label8.TabIndex = 2;
            label8.Text = "URL tạo QR";
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(881, 490);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(94, 29);
            btnLuu.TabIndex = 4;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnBatTat
            // 
            btnBatTat.Location = new Point(637, 490);
            btnBatTat.Name = "btnBatTat";
            btnBatTat.Size = new Size(220, 29);
            btnBatTat.TabIndex = 5;
            btnBatTat.Text = "Bật/Tắt Thanh toán QRCode";
            btnBatTat.UseVisualStyleBackColor = true;
            btnBatTat.Click += btnBatTat_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(728, 15);
            label11.Name = "label11";
            label11.Size = new Size(109, 25);
            label11.TabIndex = 6;
            label11.Text = "Trạng thái :";
            // 
            // lblTrangThai
            // 
            lblTrangThai.AutoSize = true;
            lblTrangThai.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblTrangThai.Location = new Point(831, 15);
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Size = new Size(93, 25);
            lblTrangThai.TabIndex = 7;
            lblTrangThai.Text = "Unknown";
            // 
            // UCQuanLiThanhToanQRCode
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblTrangThai);
            Controls.Add(label11);
            Controls.Add(btnBatTat);
            Controls.Add(btnLuu);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "UCQuanLiThanhToanQRCode";
            Size = new Size(1006, 558);
            Load += UCQuanLiThanhToanQRCode_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button btnLuu;
        private Label label2;
        private TextBox txtUrlApi;
        private TextBox txtTokenApi;
        private Label label3;
        private TextBox txtPassword;
        private Label label4;
        private TextBox txtChuTK;
        private Label label5;
        private TextBox txtTienTo;
        private Label label6;
        private Label label7;
        private TextBox txtSTK;
        private TextBox txtUrlTaoQR;
        private Label label8;
        private Label label9;
        private TextBox txtTemplateID;
        private Label label10;
        private Button btnBatTat;
        private Label label11;
        private Label lblTrangThai;
        private Label label12;
        private Label label13;
        private TextBox txtMaNganHang;
    }
}
