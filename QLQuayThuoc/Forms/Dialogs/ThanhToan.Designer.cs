namespace QLQuayThuoc
{
    partial class ThanhToan
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
            groupBox1 = new GroupBox();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ControlLight;
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(26, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1683, 105);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 52);
            label1.Name = "label1";
            label1.Size = new Size(68, 30);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.LightGray;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dataGridView1.GridColor = SystemColors.ButtonShadow;
            dataGridView1.Location = new Point(26, 144);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 72;
            dataGridView1.RowTemplate.Height = 37;
            dataGridView1.Size = new Size(1683, 262);
            dataGridView1.TabIndex = 7;
            // 
            // Column1
            // 
            Column1.HeaderText = "Thuốc";
            Column1.MinimumWidth = 9;
            Column1.Name = "Column1";
            Column1.Width = 750;
            // 
            // Column2
            // 
            Column2.HeaderText = "Số Lượng";
            Column2.MinimumWidth = 9;
            Column2.Name = "Column2";
            Column2.Width = 170;
            // 
            // Column3
            // 
            Column3.HeaderText = "Đơn giá";
            Column3.MinimumWidth = 9;
            Column3.Name = "Column3";
            Column3.Width = 350;
            // 
            // Column4
            // 
            Column4.HeaderText = "Thành tiền";
            Column4.MinimumWidth = 9;
            Column4.Name = "Column4";
            Column4.Width = 410;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.ControlLight;
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(26, 426);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(831, 312);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tóm tắt thanh toán";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = SystemColors.ControlLight;
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(label6);
            groupBox3.Location = new Point(882, 426);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(827, 312);
            groupBox3.TabIndex = 9;
            groupBox3.TabStop = false;
            groupBox3.Text = "QR thanh toán ";
            // 
            // button1
            // 
            button1.Location = new Point(1117, 761);
            button1.Name = "button1";
            button1.Size = new Size(131, 57);
            button1.TabIndex = 10;
            button1.Text = "Hủy";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(1271, 761);
            button2.Name = "button2";
            button2.Size = new Size(131, 57);
            button2.TabIndex = 11;
            button2.Text = "Tạo";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(1431, 761);
            button3.Name = "button3";
            button3.Size = new Size(278, 57);
            button3.TabIndex = 12;
            button3.Text = "Xác nhận đã thanh toán ";
            button3.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(42, 49);
            label2.Name = "label2";
            label2.Size = new Size(160, 30);
            label2.TabIndex = 0;
            label2.Text = "Tổng tiền thuốc";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(42, 97);
            label3.Name = "label3";
            label3.Size = new Size(177, 30);
            label3.TabIndex = 1;
            label3.Text = "Mức hưởng BHYT";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(42, 149);
            label4.Name = "label4";
            label4.Size = new Size(216, 30);
            label4.TabIndex = 2;
            label4.Text = "Tiền BHYT thanh toán";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(44, 194);
            label5.Name = "label5";
            label5.Size = new Size(214, 30);
            label5.TabIndex = 3;
            label5.Text = "Số tiền bệnh nhân trả";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(483, 51);
            label6.Name = "label6";
            label6.Size = new Size(100, 30);
            label6.TabIndex = 0;
            label6.Text = "Nội dung";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(483, 109);
            label7.Name = "label7";
            label7.Size = new Size(77, 30);
            label7.TabIndex = 1;
            label7.Text = "Số tiền";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(487, 174);
            label8.Name = "label8";
            label8.Size = new Size(105, 30);
            label8.TabIndex = 2;
            label8.Text = "Trạng thái";
            // 
            // ThanhToan
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1746, 845);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Name = "ThanhToan";
            Text = "Thanh toán và in hóa đơn ";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label8;
        private Label label7;
        private Label label6;
    }
}