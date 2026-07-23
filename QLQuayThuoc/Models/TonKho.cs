using System.ComponentModel.DataAnnotations.Schema;

namespace QLQuayThuoc.Models
{
    public class TonKho
    {
        // Khóa chính kép: MaKho + MaLo.
        public int MaKho { get; set; }

        public int MaLo { get; set; }

        public int SoLuongTon { get; set; }

        [ForeignKey(nameof(MaKho))]
        public Kho Kho { get; set; } = null!;

        [ForeignKey(nameof(MaLo))]
        public LoThuoc LoThuoc { get; set; } = null!;
    }
}
