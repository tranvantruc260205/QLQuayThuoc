using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QLQuayThuoc.Models
{
    public class ChiTietDonThuoc
    {
        // Khóa chính kép: MaDonThuoc + MaThuoc.
        public int MaDonThuoc { get; set; }

        public int MaThuoc { get; set; }

        public int SoLuong { get; set; }

        [Required]
        [MaxLength(255)]
        public string LieuDung { get; set; } = string.Empty;

        [Required]
        [MaxLength(100)]
        public string TanSuat { get; set; } = string.Empty;

        public int SoNgayDung { get; set; }

        [MaxLength(255)]
        public string? GhiChu { get; set; }

        [ForeignKey(nameof(MaDonThuoc))]
        public DonThuoc DonThuoc { get; set; } = null!;

        [ForeignKey(nameof(MaThuoc))]
        public Thuoc Thuoc { get; set; } = null!;
    }
}
