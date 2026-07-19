using System.ComponentModel.DataAnnotations.Schema;

namespace QLQuayThuoc.Models
{
    public class ChiTietPhieuXuat
    {
        public int MaPhieuXuat { get; set; }

        [ForeignKey(nameof(MaPhieuXuat))]
        public PhieuXuatThuoc PhieuXuatThuoc { get; set; }


        public int MaLo { get; set; }

        [ForeignKey(nameof(MaLo))]
        public LoThuoc LoThuoc { get; set; }


        public int SoLuong { get; set; }

        public decimal DonGia { get; set; }

        public decimal ThanhTien { get; set; }
    }
}