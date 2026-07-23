using System.ComponentModel.DataAnnotations.Schema;

namespace QLQuayThuoc.Models
{
    public class ChiTietPhieuXuat
    {
        // Khóa chính kép: MaPhieuXuat + MaLo.
        public int MaPhieuXuat { get; set; }

        public int MaLo { get; set; }

        public int SoLuong { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal DonGiaBan { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal ThanhTien { get; set; }

        [ForeignKey(nameof(MaPhieuXuat))]
        public PhieuXuatThuoc PhieuXuatThuoc { get; set; } = null!;

        [ForeignKey(nameof(MaLo))]
        public LoThuoc LoThuoc { get; set; } = null!;
    }
}
