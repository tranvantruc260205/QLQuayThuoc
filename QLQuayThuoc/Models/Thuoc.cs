using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QLQuayThuoc.Models
{
    public class Thuoc
    {
        [Key]
        public int MaThuoc { get; set; }

        [Required]
        [MaxLength(100)]
        public string TenThuoc { get; set; } = string.Empty;

        [Required]
        [MaxLength(50)]
        public string DonViTinh { get; set; } = string.Empty;

        [Required]
        [MaxLength(100)]
        public string HoatChat { get; set; } = string.Empty;

        [Required]
        [MaxLength(50)]
        public string HamLuong { get; set; } = string.Empty;

        [Column(TypeName = "decimal(18,2)")]
        public decimal DonGiaBan { get; set; }

        public bool DuocBHYTChiTra { get; set; }

        [Required]
        [MaxLength(50)]
        public string TrangThai { get; set; } = string.Empty;

        public ICollection<ChiTietDonThuoc> ChiTietDonThuocs { get; set; }
            = new List<ChiTietDonThuoc>();

        public ICollection<LoThuoc> LoThuocs { get; set; }
            = new List<LoThuoc>();

        public ICollection<ChiTietPhieuXinCap> ChiTietPhieuXinCaps { get; set; }
            = new List<ChiTietPhieuXinCap>();
    }
}
