using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace QLQuayThuoc.Models
{
    public class Thuoc
    {
        [Key]
        public int MaThuoc { get; set; }

        [Required]
        [MaxLength(100)]
        public string TenThuoc { get; set; }

        [Required]
        [MaxLength(50)]
        public string DonViTinh { get; set; }

        [Required]
        [MaxLength(100)]
        public string HoatChat { get; set; }

        [Required]
        [MaxLength(50)]
        public string HamLuong { get; set; }

        public decimal DonGia { get; set; }

        [Required]
        [MaxLength(50)]
        public string TrangThai { get; set; }

        public ICollection<ChiTietDonThuoc> ChiTietDonThuocs { get; set; }
            = new List<ChiTietDonThuoc>();

        public ICollection<LoThuoc> LoThuocs { get; set; }
            = new List<LoThuoc>();

        public ICollection<ChiTietPhieuXinCap> ChiTietPhieuXinCaps { get; set; }
            = new List<ChiTietPhieuXinCap>();
    }
}