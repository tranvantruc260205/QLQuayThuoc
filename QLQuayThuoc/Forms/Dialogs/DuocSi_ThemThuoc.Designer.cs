namespace QLQuayThuoc.Forms.Dialogs
{
    partial class DuocSi_ThemThuoc
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
            btnTimKiem = new Button();
            txtTimKiem = new TextBox();
            label1 = new Label();
            dgv = new DataGridView();
            label2 = new Label();
            nudSoLuong = new NumericUpDown();
            label3 = new Label();
            txtGhiChu = new RichTextBox();
            btnXacNhan = new Button();
            btnDong = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudSoLuong).BeginInit();
            SuspendLayout();
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(399, 23);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(94, 29);
            btnTimKiem.TabIndex = 6;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(93, 24);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(281, 27);
            txtTimKiem.TabIndex = 5;
            txtTimKiem.KeyDown += txtTimKiem_KeyDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 27);
            label1.Name = "label1";
            label1.Size = new Size(70, 20);
            label1.TabIndex = 4;
            label1.Text = "Tìm kiếm";
            // 
            // dgv
            // 
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Location = new Point(12, 79);
            dgv.Name = "dgv";
            dgv.RowHeadersWidth = 51;
            dgv.RowTemplate.Height = 29;
            dgv.Size = new Size(682, 323);
            dgv.TabIndex = 7;
            dgv.SelectionChanged += dgv_SelectionChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 424);
            label2.Name = "label2";
            label2.Size = new Size(131, 20);
            label2.TabIndex = 8;
            label2.Text = "Số lượng xin cấp : ";
            // 
            // nudSoLuong
            // 
            nudSoLuong.Location = new Point(152, 422);
            nudSoLuong.Name = "nudSoLuong";
            nudSoLuong.Size = new Size(210, 27);
            nudSoLuong.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(77, 469);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 10;
            label3.Text = "Ghi chú : ";
            // 
            // txtGhiChu
            // 
            txtGhiChu.Location = new Point(152, 466);
            txtGhiChu.Name = "txtGhiChu";
            txtGhiChu.Size = new Size(210, 76);
            txtGhiChu.TabIndex = 11;
            txtGhiChu.Text = "";
            // 
            // btnXacNhan
            // 
            btnXacNhan.Location = new Point(581, 548);
            btnXacNhan.Name = "btnXacNhan";
            btnXacNhan.Size = new Size(94, 29);
            btnXacNhan.TabIndex = 12;
            btnXacNhan.Text = "Xác nhận";
            btnXacNhan.UseVisualStyleBackColor = true;
            btnXacNhan.Click += btnXacNhan_Click;
            // 
            // btnDong
            // 
            btnDong.Location = new Point(462, 548);
            btnDong.Name = "btnDong";
            btnDong.Size = new Size(94, 29);
            btnDong.TabIndex = 13;
            btnDong.Text = "Đóng";
            btnDong.UseVisualStyleBackColor = true;
            btnDong.Click += btnDong_Click;
            // 
            // DuocSi_ThemThuoc
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(706, 589);
            Controls.Add(btnDong);
            Controls.Add(btnXacNhan);
            Controls.Add(txtGhiChu);
            Controls.Add(label3);
            Controls.Add(nudSoLuong);
            Controls.Add(label2);
            Controls.Add(dgv);
            Controls.Add(btnTimKiem);
            Controls.Add(txtTimKiem);
            Controls.Add(label1);
            Name = "DuocSi_ThemThuoc";
            Text = "Thêm thuốc vào phiếu";
            Load += DuocSi_ThemThuoc_Load;
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudSoLuong).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnTimKiem;
        private TextBox txtTimKiem;
        private Label label1;
        private DataGridView dgv;
        private Label label2;
        private NumericUpDown nudSoLuong;
        private Label label3;
        private RichTextBox txtGhiChu;
        private Button btnXacNhan;
        private Button btnDong;
    }
}