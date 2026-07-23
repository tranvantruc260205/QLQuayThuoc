using System.ComponentModel.DataAnnotations.Schema;

namespace QLQuayThuoc.Models
{
    public class ChiTietCapTheoLo
    {
        // Khóa chính kép: MaPhieu + MaThuoc + MaLo.
        public int MaPhieu { get; set; }

        public int MaThuoc { get; set; }

        public int MaLo { get; set; }

        public int SoLuongCap { get; set; }

        // FK kép MaPhieu + MaThuoc được cấu hình trong AppDbContext.
        public ChiTietPhieuXinCap ChiTietPhieuXinCap { get; set; } = null!;

        [ForeignKey(nameof(MaLo))]
        public LoThuoc LoThuoc { get; set; } = null!;
    }
}
