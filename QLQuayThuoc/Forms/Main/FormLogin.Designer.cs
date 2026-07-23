namespace QLQuayThuoc
{
    partial class FormLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label3 = new Label();
            checkBox1 = new CheckBox();
            button1 = new Button();
            button2 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(190, 108);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(915, 624);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Đăng nhập hệ thống ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.8571434F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(118, 57);
            label1.Name = "label1";
            label1.Size = new Size(649, 50);
            label1.TabIndex = 0;
            label1.Text = "QUẢN LÝ QUẦY THUỐC BỆNH VIỆN ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(139, 148);
            label2.Name = "label2";
            label2.Size = new Size(240, 30);
            label2.TabIndex = 1;
            label2.Text = "Email hoặc số điện thoại";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(139, 181);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(575, 35);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(139, 288);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '•';
            textBox2.Size = new Size(575, 35);
            textBox2.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(139, 255);
            label3.Name = "label3";
            label3.Size = new Size(107, 30);
            label3.TabIndex = 4;
            label3.Text = "Mật khẩu ";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(139, 346);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(225, 34);
            checkBox1.TabIndex = 5;
            checkBox1.Text = "Ghi nhớ đăng nhập ";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(372, 448);
            button1.Name = "button1";
            button1.Size = new Size(140, 50);
            button1.TabIndex = 6;
            button1.Text = "Thoát";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaption;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(560, 448);
            button2.Name = "button2";
            button2.Size = new Size(143, 50);
            button2.TabIndex = 7;
            button2.Text = "Đăng nhập";
            button2.UseVisualStyleBackColor = false;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1301, 825);
            Controls.Add(groupBox1);
            Name = "LoginForm";
            Text = "Quản Lý Quầy Thuốc Bệnh Viện";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textBox1;
        private Label label2;
        private Label label1;
        private Label label3;
        private TextBox textBox2;
        private Button button2;
        private Button button1;
        private CheckBox checkBox1;
    }
}
