namespace QLQuayThuoc
{
    partial class UCDanhSachDonThuoc
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panelContent = new Panel();
            dgv = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            dtpDenNgay = new DateTimePicker();
            dtpTuNgay = new DateTimePicker();
            txtTimKiem = new TextBox();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            panelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            SuspendLayout();
            // 
            // panelContent
            // 
            panelContent.BackColor = SystemColors.Window;
            panelContent.Controls.Add(dgv);
            panelContent.Controls.Add(dtpDenNgay);
            panelContent.Controls.Add(dtpTuNgay);
            panelContent.Controls.Add(txtTimKiem);
            panelContent.Controls.Add(button7);
            panelContent.Controls.Add(button6);
            panelContent.Controls.Add(button5);
            panelContent.Controls.Add(button4);
            panelContent.Controls.Add(label8);
            panelContent.Controls.Add(label7);
            panelContent.Controls.Add(label6);
            panelContent.Controls.Add(label5);
            panelContent.Controls.Add(label4);
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(0, 0);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(1143, 489);
            panelContent.TabIndex = 3;
            // 
            // dgv
            // 
            dgv.BackgroundColor = SystemColors.Control;
            dgv.BorderStyle = BorderStyle.None;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column7 });
            dgv.EnableHeadersVisualStyles = false;
            dgv.ImeMode = ImeMode.NoControl;
            dgv.Location = new Point(55, 138);
            dgv.Name = "dgv";
            dgv.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgv.RowHeadersVisible = false;
            dgv.RowHeadersWidth = 51;
            dgv.RowTemplate.Height = 29;
            dgv.Size = new Size(944, 260);
            dgv.TabIndex = 16;
            // 
            // Column1
            // 
            Column1.HeaderText = "Mã đơn";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.Width = 150;
            // 
            // Column2
            // 
            Column2.HeaderText = "Bệnh nhân";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 200;
            // 
            // Column3
            // 
            Column3.HeaderText = "Ngày kê";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 155;
            // 
            // Column4
            // 
            Column4.HeaderText = "Số loại thuốc";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 155;
            // 
            // Column5
            // 
            Column5.HeaderText = "Trạng thái";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 155;
            // 
            // Column7
            // 
            Column7.HeaderText = "Ghi chú";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.Width = 125;
            // 
            // dtpDenNgay
            // 
            dtpDenNgay.Location = new Point(449, 95);
            dtpDenNgay.Name = "dtpDenNgay";
            dtpDenNgay.Size = new Size(189, 27);
            dtpDenNgay.TabIndex = 14;
            // 
            // dtpTuNgay
            // 
            dtpTuNgay.Location = new Point(228, 96);
            dtpTuNgay.Name = "dtpTuNgay";
            dtpTuNgay.Size = new Size(187, 27);
            dtpTuNgay.TabIndex = 13;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(6, 95);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(176, 27);
            txtTimKiem.TabIndex = 12;
            // 
            // button7
            // 
            button7.Location = new Point(940, 94);
            button7.Name = "button7";
            button7.Size = new Size(94, 29);
            button7.TabIndex = 11;
            button7.Text = "Kê đơn mới";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button6
            // 
            button6.Location = new Point(908, 226);
            button6.Name = "button6";
            button6.Size = new Size(8, 8);
            button6.TabIndex = 10;
            button6.Text = "button6";
            button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(776, 94);
            button5.Name = "button5";
            button5.Size = new Size(94, 29);
            button5.TabIndex = 9;
            button5.Text = "Làm mới";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.PaleTurquoise;
            button4.FlatAppearance.BorderColor = Color.DarkBlue;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Location = new Point(664, 94);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 8;
            button4.Text = "Lọc";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(460, 72);
            label8.Name = "label8";
            label8.Size = new Size(75, 20);
            label8.TabIndex = 6;
            label8.Text = "Đến Ngày";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(228, 71);
            label7.Name = "label7";
            label7.Size = new Size(65, 20);
            label7.TabIndex = 5;
            label7.Text = "Từ Ngày";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 72);
            label6.Name = "label6";
            label6.Size = new Size(72, 20);
            label6.TabIndex = 4;
            label6.Text = "Tìm Kiếm";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(6, 37);
            label5.Name = "label5";
            label5.Size = new Size(308, 15);
            label5.TabIndex = 3;
            label5.Text = "Tra cứu đơn đã kê; chỉ bản nháp/chờ cấp thuốc hoặc hủy";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(6, 9);
            label4.Name = "label4";
            label4.Size = new Size(222, 28);
            label4.TabIndex = 2;
            label4.Text = "Danh Sách Đơn Thuốc";
            // 
            // UCDanhSachDonThuoc
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelContent);
            Name = "UCDanhSachDonThuoc";
            Size = new Size(1143, 489);
            panelContent.ResumeLayout(false);
            panelContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelContent;
        private DataGridView dgv;
        private DateTimePicker dtpDenNgay;
        private DateTimePicker dtpTuNgay;
        private TextBox txtTimKiem;
        private Button button7;
        private Button button6;
        private Button button5;
        private Button button4;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column7;
    }
}
