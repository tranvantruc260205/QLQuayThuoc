using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QLQuayThuoc.Models
{
    public class LoThuoc
    {
        [Key]
        public int MaLo { get; set; }


        public int MaThuoc { get; set; }

        [ForeignKey(nameof(MaThuoc))]
        public Thuoc Thuoc { get; set; }


        [Required]
        [MaxLength(100)]
        public string SoLo { get; set; }

        public DateTime NgayNhap { get; set; }

        public DateTime NgayHetHan { get; set; }

        public int SoLuongTon { get; set; }

        public decimal GiaNhap { get; set; }


        public ICollection<ChiTietPhieuXuat> ChiTietPhieuXuats { get; set; }
            = new List<ChiTietPhieuXuat>();
    }
}