namespace QLQuayThuoc.UserControls
{
    partial class UCTiepNhanDon
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
            comboBox1 = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            label5 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            groupBox2 = new GroupBox();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            groupBox3 = new GroupBox();
            dataGridView2 = new DataGridView();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            Column10 = new DataGridViewTextBoxColumn();
            button4 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(20, 17);
            label1.Name = "label1";
            label1.Size = new Size(273, 30);
            label1.TabIndex = 0;
            label1.Text = "Tiếp Nhận Và Xuất Thuốc";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ControlLight;
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(20, 63);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1201, 150);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông Tin Đơn Thuốc";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(566, 80);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(182, 33);
            comboBox1.TabIndex = 8;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(802, 78);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(311, 31);
            dateTimePicker1.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(802, 52);
            label5.Name = "label5";
            label5.Size = new Size(77, 25);
            label5.TabIndex = 6;
            label5.Text = "Ngày kê";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(284, 80);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(228, 31);
            textBox2.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(37, 80);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(566, 52);
            label4.Name = "label4";
            label4.Size = new Size(116, 25);
            label4.TabIndex = 2;
            label4.Text = "Bác sĩ kê đơn";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(284, 52);
            label3.Name = "label3";
            label3.Size = new Size(84, 25);
            label3.TabIndex = 1;
            label3.Text = "Mã BHYT";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 52);
            label2.Name = "label2";
            label2.Size = new Size(95, 25);
            label2.TabIndex = 0;
            label2.Text = "Bệnh nhân";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.ControlLight;
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Controls.Add(button3);
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(button1);
            groupBox2.Location = new Point(20, 226);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(620, 362);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thuốc trên đơn giấy";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6 });
            dataGridView1.Location = new Point(17, 98);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(587, 239);
            dataGridView1.TabIndex = 3;
            // 
            // Column1
            // 
            Column1.HeaderText = "Thuốc";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.Width = 150;
            // 
            // Column2
            // 
            Column2.HeaderText = "SL";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            Column2.Width = 150;
            // 
            // Column3
            // 
            Column3.HeaderText = "Liều dùng";
            Column3.MinimumWidth = 8;
            Column3.Name = "Column3";
            Column3.Width = 130;
            // 
            // Column4
            // 
            Column4.HeaderText = "Tần suất";
            Column4.MinimumWidth = 8;
            Column4.Name = "Column4";
            Column4.Width = 130;
            // 
            // Column5
            // 
            Column5.HeaderText = "Ngày";
            Column5.MinimumWidth = 8;
            Column5.Name = "Column5";
            Column5.Width = 150;
            // 
            // Column6
            // 
            Column6.HeaderText = "Ghi chú";
            Column6.MinimumWidth = 8;
            Column6.Name = "Column6";
            Column6.Width = 130;
            // 
            // button3
            // 
            button3.Location = new Point(329, 44);
            button3.Name = "button3";
            button3.Size = new Size(112, 34);
            button3.TabIndex = 2;
            button3.Text = "Xóa dòng";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(182, 44);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 1;
            button2.Text = "Sửa dòng";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(17, 44);
            button1.Name = "button1";
            button1.Size = new Size(137, 34);
            button1.TabIndex = 0;
            button1.Text = "Thêm thuốc";
            button1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = SystemColors.ControlLight;
            groupBox3.Controls.Add(dataGridView2);
            groupBox3.Location = new Point(646, 226);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(581, 362);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Kiểm tra tồn và chọn lô";
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = SystemColors.Control;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { Column7, Column8, Column9, Column10 });
            dataGridView2.Location = new Point(6, 98);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.RowHeadersWidth = 62;
            dataGridView2.RowTemplate.Height = 33;
            dataGridView2.Size = new Size(544, 225);
            dataGridView2.TabIndex = 0;
            // 
            // Column7
            // 
            Column7.HeaderText = "Lô";
            Column7.MinimumWidth = 8;
            Column7.Name = "Column7";
            Column7.Width = 150;
            // 
            // Column8
            // 
            Column8.HeaderText = "Hết hạn";
            Column8.MinimumWidth = 8;
            Column8.Name = "Column8";
            Column8.Width = 150;
            // 
            // Column9
            // 
            Column9.HeaderText = "Tồn";
            Column9.MinimumWidth = 8;
            Column9.Name = "Column9";
            Column9.Width = 150;
            // 
            // Column10
            // 
            Column10.HeaderText = "Xuất";
            Column10.MinimumWidth = 8;
            Column10.Name = "Column10";
            Column10.Width = 150;
            // 
            // button4
            // 
            button4.Location = new Point(944, 613);
            button4.Name = "button4";
            button4.Size = new Size(218, 34);
            button4.TabIndex = 4;
            button4.Text = "Xác nhận thanh toán";
            button4.UseVisualStyleBackColor = true;
            // 
            // UCTiepNhanDon
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "UCTiepNhanDon";
            Size = new Size(1225, 679);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private DateTimePicker dateTimePicker1;
        private Label label5;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private GroupBox groupBox2;
        private Button button3;
        private Button button2;
        private Button button1;
        private GroupBox groupBox3;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private ComboBox comboBox1;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column10;
        private Button button4;
    }
}
