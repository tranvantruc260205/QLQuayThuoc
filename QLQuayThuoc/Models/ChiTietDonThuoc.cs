using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QLQuayThuoc.Models
{
    public class ChiTietDonThuoc
    {
        public int MaDonThuoc { get; set; }

        [ForeignKey(nameof(MaDonThuoc))]
        public DonThuoc DonThuoc { get; set; }


        public int MaThuoc { get; set; }

        [ForeignKey(nameof(MaThuoc))]
        public Thuoc Thuoc { get; set; }


        public int SoLuong { get; set; }

        [Required]
        [MaxLength(255)]
        public string LieuDung { get; set; }

        [Required]
        [MaxLength(100)]
        public string TanSuat { get; set; }

        public int SoNgayDung { get; set; }

        [MaxLength(255)]
        public string? GhiChu { get; set; }
    }
}