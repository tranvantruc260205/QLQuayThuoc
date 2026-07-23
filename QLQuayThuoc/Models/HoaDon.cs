using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QLQuayThuoc.Models
{
    public class HoaDon
    {
        [Key]
        public int MaHD { get; set; }

        public int MaPhieuXuat { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal TongTienThuoc { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal TienThuocDuocBHYT { get; set; }

        // Lưu phần trăm đã áp dụng tại thời điểm thanh toán.
        public int TyLeBHYTApDung { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal TienBHYTThanhToan { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal TienBenhNhanTra { get; set; }

        [Required]
        [MaxLength(50)]
        public string PhuongThucThanhToan { get; set; } = string.Empty;
        // "TIEN_MAT", "CHUYEN_KHOAN"

        [MaxLength(255)]
        public string? NoiDungChuyenKhoan { get; set; }

        [MaxLength(100)]
        public string? MaGiaoDich { get; set; }

        public DateTime ThoiGianThanhToan { get; set; }

        [ForeignKey(nameof(MaPhieuXuat))]
        public PhieuXuatThuoc PhieuXuatThuoc { get; set; } = null!;
    }
}
