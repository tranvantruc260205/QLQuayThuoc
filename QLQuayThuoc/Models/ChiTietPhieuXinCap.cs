using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QLQuayThuoc.Models
{
    public class ChiTietPhieuXinCap
    {
        public int MaPhieu { get; set; }

        [ForeignKey(nameof(MaPhieu))]
        public PhieuXinCapThuoc PhieuXinCapThuoc { get; set; }


        public int MaThuoc { get; set; }

        [ForeignKey(nameof(MaThuoc))]
        public Thuoc Thuoc { get; set; }


        public int SoLuongYeuCau { get; set; }

        public int? SoLuongDuyet { get; set; }

        [MaxLength(255)]
        public string? GhiChu { get; set; }
    }
}