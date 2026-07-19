using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QLQuayThuoc.Models
{
    public class DonThuoc
    {
        [Key]
        public int MaDonThuoc { get; set; }


        [ForeignKey(nameof(BenhNhan))]
        public int MaBN { get; set; }

        public BenhNhan BenhNhan { get; set; }


        public int BacSiId { get; set; }

        [ForeignKey(nameof(BacSiId))]
        public User BacSi { get; set; }


        public DateTime NgayKeDon { get; set; }

        [Required]
        [MaxLength(100)]
        public string TrangThai { get; set; } // "CHO_XUAT_THUOC", "DA_XUAT_THUOC"


        [MaxLength(255)]
        public string? GhiChu { get; set; }


        public ICollection<ChiTietDonThuoc> ChiTietDonThuocs { get; set; }
            = new List<ChiTietDonThuoc>();


        public PhieuXuatThuoc? PhieuXuatThuoc { get; set; }

        public HoaDon? HoaDon { get; set; }
    }
}