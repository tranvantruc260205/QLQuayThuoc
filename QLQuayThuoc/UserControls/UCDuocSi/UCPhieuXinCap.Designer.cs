namespace QLQuayThuoc
{
    partial class UCPhieuXinCap
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
            groupBox2 = new GroupBox();
            button10 = new Button();
            button11 = new Button();
            button9 = new Button();
            button8 = new Button();
            dataGridView2 = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            c = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            textBox2 = new TextBox();
            label6 = new Label();
            label5 = new Label();
            dateTimePicker1 = new DateTimePicker();
            groupBox1 = new GroupBox();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            button7 = new Button();
            label13 = new Label();
            button6 = new Button();
            textBox1 = new TextBox();
            button5 = new Button();
            label15 = new Label();
            comboBox2 = new ComboBox();
            label4 = new Label();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button10);
            groupBox2.Controls.Add(button11);
            groupBox2.Controls.Add(button9);
            groupBox2.Controls.Add(button8);
            groupBox2.Controls.Add(dataGridView2);
            groupBox2.Controls.Add(textBox2);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(dateTimePicker1);
            groupBox2.Location = new Point(719, 34);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(685, 777);
            groupBox2.TabIndex = 23;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chi tiết phiếu ";
            // 
            // button10
            // 
            button10.Location = new Point(337, 623);
            button10.Name = "button10";
            button10.Size = new Size(164, 52);
            button10.TabIndex = 17;
            button10.Text = "Luu nháp ";
            button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            button11.Location = new Point(518, 623);
            button11.Name = "button11";
            button11.Size = new Size(167, 52);
            button11.TabIndex = 16;
            button11.Text = "Gửi duyệt";
            button11.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.Location = new Point(215, 144);
            button9.Name = "button9";
            button9.Size = new Size(153, 47);
            button9.TabIndex = 9;
            button9.Text = "Xóa dòng ";
            button9.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Location = new Point(20, 144);
            button8.Name = "button8";
            button8.Size = new Size(153, 47);
            button8.TabIndex = 8;
            button8.Text = "Thêm thuốc";
            button8.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = SystemColors.ButtonFace;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, c, Column2, Column3 });
            dataGridView2.GridColor = SystemColors.ButtonShadow;
            dataGridView2.Location = new Point(3, 210);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.RowHeadersWidth = 72;
            dataGridView2.RowTemplate.Height = 37;
            dataGridView2.Size = new Size(683, 388);
            dataGridView2.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Thuốc";
            dataGridViewTextBoxColumn1.MinimumWidth = 9;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Width = 200;
            // 
            // c
            // 
            c.HeaderText = "SL yêu cầu";
            c.MinimumWidth = 9;
            c.Name = "c";
            c.Width = 155;
            // 
            // Column2
            // 
            Column2.HeaderText = "SL duyệt";
            Column2.MinimumWidth = 9;
            Column2.Name = "Column2";
            Column2.Width = 140;
            // 
            // Column3
            // 
            Column3.HeaderText = "Ghi chú";
            Column3.MinimumWidth = 9;
            Column3.Name = "Column3";
            Column3.Width = 190;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(259, 81);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(321, 49);
            textBox2.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(254, 38);
            label6.Name = "label6";
            label6.Size = new Size(62, 30);
            label6.TabIndex = 2;
            label6.Text = "Lý do";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 46);
            label5.Name = "label5";
            label5.Size = new Size(96, 30);
            label5.TabIndex = 1;
            label5.Text = "Ngày lập";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarFont = new Font("Segoe UI", 11.1428576F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(20, 89);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(222, 35);
            dateTimePicker1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Controls.Add(button7);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(button6);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(button5);
            groupBox1.Controls.Add(label15);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Location = new Point(6, 39);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(707, 777);
            groupBox1.TabIndex = 22;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh sách phiếu ";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonFace;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column4, Column6, Column7 });
            dataGridView1.GridColor = SystemColors.ButtonShadow;
            dataGridView1.Location = new Point(18, 157);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 72;
            dataGridView1.RowTemplate.Height = 37;
            dataGridView1.Size = new Size(689, 441);
            dataGridView1.TabIndex = 6;
            // 
            // Column1
            // 
            Column1.HeaderText = "Mã phiếu";
            Column1.MinimumWidth = 9;
            Column1.Name = "Column1";
            Column1.Width = 140;
            // 
            // Column4
            // 
            Column4.HeaderText = "Ngày lập";
            Column4.MinimumWidth = 9;
            Column4.Name = "Column4";
            Column4.Width = 210;
            // 
            // Column6
            // 
            Column6.HeaderText = "Lý do";
            Column6.MinimumWidth = 9;
            Column6.Name = "Column6";
            Column6.Width = 150;
            // 
            // Column7
            // 
            Column7.HeaderText = "Trạng thái ";
            Column7.MinimumWidth = 9;
            Column7.Name = "Column7";
            Column7.Width = 190;
            // 
            // button7
            // 
            button7.Location = new Point(18, 623);
            button7.Name = "button7";
            button7.Size = new Size(202, 52);
            button7.TabIndex = 15;
            button7.Text = "Tạo phiếu mới ";
            button7.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(18, 46);
            label13.Name = "label13";
            label13.Size = new Size(105, 30);
            label13.TabIndex = 7;
            label13.Text = "Tìm phiếu";
            // 
            // button6
            // 
            button6.Location = new Point(244, 623);
            button6.Name = "button6";
            button6.Size = new Size(123, 52);
            button6.TabIndex = 14;
            button6.Text = "Hủy Phiếu";
            button6.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(18, 79);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(308, 51);
            textBox1.TabIndex = 10;
            // 
            // button5
            // 
            button5.Location = new Point(599, 78);
            button5.Name = "button5";
            button5.Size = new Size(91, 52);
            button5.TabIndex = 13;
            button5.Text = "Lọc";
            button5.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(354, 46);
            label15.Name = "label15";
            label15.Size = new Size(105, 30);
            label15.TabIndex = 9;
            label15.Text = "Trạng thái";
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(354, 81);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(217, 49);
            comboBox2.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.1428576F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(6, 0);
            label4.Name = "label4";
            label4.Size = new Size(267, 37);
            label4.TabIndex = 21;
            label4.Text = "Phiếu xin cấp thuốc";
            // 
            // PhieuXinCap
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label4);
            Name = "PhieuXinCap";
            Size = new Size(1410, 819);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox2;
        private Button button10;
        private Button button11;
        private Button button9;
        private Button button8;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn c;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private TextBox textBox2;
        private Label label6;
        private Label label5;
        private DateTimePicker dateTimePicker1;
        private GroupBox groupBox1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private Button button7;
        private Label label13;
        private Button button6;
        private TextBox textBox1;
        private Button button5;
        private Label label15;
        private ComboBox comboBox2;
        private Label label4;
    }
}
