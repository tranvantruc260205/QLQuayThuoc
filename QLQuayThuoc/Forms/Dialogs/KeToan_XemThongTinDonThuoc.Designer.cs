namespace QLQuayThuoc.Forms.Dialogs
{
    partial class KeToan_XemThongTinDonThuoc
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
            lblTieuDe = new Label();
            dgvHoaDon = new DataGridView();
            btnDong = new Button();
            colMaHD = new DataGridViewTextBoxColumn();
            colBenhNhan = new DataGridViewTextBoxColumn();
            colDuocSi = new DataGridViewTextBoxColumn();
            colThoiGianThanhToan = new DataGridViewTextBoxColumn();
            colPhuongThuc = new DataGridViewTextBoxColumn();
            colTongTienThuoc = new DataGridViewTextBoxColumn();
            colTienBHYT = new DataGridViewTextBoxColumn();
            colTienBenhNhanTra = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvHoaDon).BeginInit();
            SuspendLayout();
            // 
            // lblTieuDe
            // 
            lblTieuDe.AutoSize = true;
            lblTieuDe.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            lblTieuDe.Location = new Point(335, 25);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new Size(218, 30);
            lblTieuDe.TabIndex = 0;
            lblTieuDe.Text = "Danh Sách Hóa Đơn";
            // 
            // dgvHoaDon
            // 
            dgvHoaDon.BackgroundColor = SystemColors.ButtonHighlight;
            dgvHoaDon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHoaDon.Columns.AddRange(new DataGridViewColumn[] { colMaHD, colBenhNhan, colDuocSi, colThoiGianThanhToan, colPhuongThuc, colTongTienThuoc, colTienBHYT, colTienBenhNhanTra });
            dgvHoaDon.Location = new Point(12, 89);
            dgvHoaDon.Name = "dgvHoaDon";
            dgvHoaDon.RowHeadersVisible = false;
            dgvHoaDon.RowHeadersWidth = 51;
            dgvHoaDon.RowTemplate.Height = 29;
            dgvHoaDon.Size = new Size(1005, 314);
            dgvHoaDon.TabIndex = 1;
            // 
            // btnDong
            // 
            btnDong.Location = new Point(923, 409);
            btnDong.Name = "btnDong";
            btnDong.Size = new Size(94, 29);
            btnDong.TabIndex = 2;
            btnDong.Text = "Đóng";
            btnDong.UseVisualStyleBackColor = true;
            // 
            // colMaHD
            // 
            colMaHD.HeaderText = "Mã HD";
            colMaHD.MinimumWidth = 6;
            colMaHD.Name = "colMaHD";
            // 
            // colBenhNhan
            // 
            colBenhNhan.HeaderText = "Bệnh nhân";
            colBenhNhan.MinimumWidth = 6;
            colBenhNhan.Name = "colBenhNhan";
            colBenhNhan.Width = 125;
            // 
            // colDuocSi
            // 
            colDuocSi.HeaderText = "Dược sĩ";
            colDuocSi.MinimumWidth = 6;
            colDuocSi.Name = "colDuocSi";
            colDuocSi.Width = 125;
            // 
            // colThoiGianThanhToan
            // 
            colThoiGianThanhToan.HeaderText = "Thời gian thanh toán";
            colThoiGianThanhToan.MinimumWidth = 6;
            colThoiGianThanhToan.Name = "colThoiGianThanhToan";
            colThoiGianThanhToan.Width = 125;
            // 
            // colPhuongThuc
            // 
            colPhuongThuc.HeaderText = "Phương thức";
            colPhuongThuc.MinimumWidth = 6;
            colPhuongThuc.Name = "colPhuongThuc";
            colPhuongThuc.Width = 125;
            // 
            // colTongTienThuoc
            // 
            colTongTienThuoc.HeaderText = "Tổng tiền thuốc";
            colTongTienThuoc.MinimumWidth = 6;
            colTongTienThuoc.Name = "colTongTienThuoc";
            colTongTienThuoc.Width = 125;
            // 
            // colTienBHYT
            // 
            colTienBHYT.HeaderText = "BHYT chi trả";
            colTienBHYT.MinimumWidth = 6;
            colTienBHYT.Name = "colTienBHYT";
            colTienBHYT.Width = 125;
            // 
            // colTienBenhNhanTra
            // 
            colTienBenhNhanTra.HeaderText = "Bệnh nhân trả";
            colTienBenhNhanTra.MinimumWidth = 6;
            colTienBenhNhanTra.Name = "colTienBenhNhanTra";
            colTienBenhNhanTra.Width = 125;
            // 
            // KeToan_XemThongTinDonThuoc
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 450);
            Controls.Add(btnDong);
            Controls.Add(dgvHoaDon);
            Controls.Add(lblTieuDe);
            Name = "KeToan_XemThongTinDonThuoc";
            Text = "Thông tin hóa đơn";
            Load += KeToan_XemThongTinDonThuoc_Load;
            ((System.ComponentModel.ISupportInitialize)dgvHoaDon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTieuDe;
        private DataGridView dgvHoaDon;
        private Button btnDong;
        private DataGridViewTextBoxColumn colMaHD;
        private DataGridViewTextBoxColumn colBenhNhan;
        private DataGridViewTextBoxColumn colDuocSi;
        private DataGridViewTextBoxColumn colThoiGianThanhToan;
        private DataGridViewTextBoxColumn colPhuongThuc;
        private DataGridViewTextBoxColumn colTongTienThuoc;
        private DataGridViewTextBoxColumn colTienBHYT;
        private DataGridViewTextBoxColumn colTienBenhNhanTra;
    }
}