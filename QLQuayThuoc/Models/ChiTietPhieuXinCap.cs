using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QLQuayThuoc.Models
{
    public class ChiTietPhieuXinCap
    {
        // Khóa chính kép: MaPhieu + MaThuoc.
        public int MaPhieu { get; set; }

        public int MaThuoc { get; set; }

        public int SoLuongYeuCau { get; set; }

        public int? SoLuongDuyet { get; set; }

        [MaxLength(255)]
        public string? GhiChu { get; set; }

        [ForeignKey(nameof(MaPhieu))]
        public PhieuXinCapThuoc PhieuXinCapThuoc { get; set; } = null!;

        [ForeignKey(nameof(MaThuoc))]
        public Thuoc Thuoc { get; set; } = null!;

        public ICollection<ChiTietCapTheoLo> ChiTietCapTheoLos { get; set; }
            = new List<ChiTietCapTheoLo>();
    }
}
