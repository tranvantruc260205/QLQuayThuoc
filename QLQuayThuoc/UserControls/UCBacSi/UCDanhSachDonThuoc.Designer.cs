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
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            comboBox1 = new ComboBox();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            textBox1 = new TextBox();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            panelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panelContent
            // 
            panelContent.BackColor = SystemColors.Window;
            panelContent.Controls.Add(dataGridView1);
            panelContent.Controls.Add(comboBox1);
            panelContent.Controls.Add(dateTimePicker2);
            panelContent.Controls.Add(dateTimePicker1);
            panelContent.Controls.Add(textBox1);
            panelContent.Controls.Add(button7);
            panelContent.Controls.Add(button6);
            panelContent.Controls.Add(button5);
            panelContent.Controls.Add(button4);
            panelContent.Controls.Add(label9);
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
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7 });
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ImeMode = ImeMode.NoControl;
            dataGridView1.Location = new Point(3, 144);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1044, 227);
            dataGridView1.TabIndex = 16;
            // 
            // Column1
            // 
            Column1.HeaderText = "Mã đơn";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.Width = 200;
            // 
            // Column2
            // 
            Column2.HeaderText = "Bệnh nhân";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 150;
            // 
            // Column3
            // 
            Column3.HeaderText = "Ngày kê";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "Số thuốc";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 125;
            // 
            // Column5
            // 
            Column5.HeaderText = "Trạng thái";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 155;
            // 
            // Column6
            // 
            Column6.HeaderText = "Ghi chú";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.Width = 160;
            // 
            // Column7
            // 
            Column7.HeaderText = "Thao tác";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.Width = 125;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(547, 93);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 15;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(377, 93);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(151, 27);
            dateTimePicker2.TabIndex = 14;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(163, 93);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(187, 27);
            dateTimePicker1.TabIndex = 13;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(6, 95);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 12;
            // 
            // button7
            // 
            button7.Location = new Point(941, 91);
            button7.Name = "button7";
            button7.Size = new Size(94, 29);
            button7.TabIndex = 11;
            button7.Text = "Kê đơn mới";
            button7.UseVisualStyleBackColor = true;
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
            button5.Location = new Point(804, 91);
            button5.Name = "button5";
            button5.Size = new Size(94, 29);
            button5.TabIndex = 9;
            button5.Text = "Làm mới";
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.BackColor = Color.PaleTurquoise;
            button4.FlatAppearance.BorderColor = Color.DarkBlue;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Location = new Point(704, 91);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 8;
            button4.Text = "Lọc";
            button4.UseVisualStyleBackColor = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(547, 70);
            label9.Name = "label9";
            label9.Size = new Size(78, 20);
            label9.TabIndex = 7;
            label9.Text = "Trạng Thái";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(377, 72);
            label8.Name = "label8";
            label8.Size = new Size(75, 20);
            label8.TabIndex = 6;
            label8.Text = "Đến Ngày";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(163, 70);
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
            label5.Size = new Size(309, 15);
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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelContent;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private ComboBox comboBox1;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox1;
        private Button button7;
        private Button button6;
        private Button button5;
        private Button button4;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
    }
}
