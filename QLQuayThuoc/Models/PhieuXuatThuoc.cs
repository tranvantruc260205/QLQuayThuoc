using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QLQuayThuoc.Models
{
    public class PhieuXuatThuoc
    {
        [Key]
        public int MaPhieuXuat { get; set; }


        public int MaDonThuoc { get; set; }

        [ForeignKey(nameof(MaDonThuoc))]
        public DonThuoc DonThuoc { get; set; }


        public int DuocSiId { get; set; }

        [ForeignKey(nameof(DuocSiId))]
        public User DuocSi { get; set; }


        public DateTime NgayXuat { get; set; }

        [Required]
        [MaxLength(50)]
        public string TrangThai { get; set; }


        public ICollection<ChiTietPhieuXuat> ChiTietPhieuXuats { get; set; }
            = new List<ChiTietPhieuXuat>();
    }
}