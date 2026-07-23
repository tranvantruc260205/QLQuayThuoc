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

        public int MaBN { get; set; }

        public int BacSiId { get; set; }

        [ForeignKey(nameof(MaBN))]
        public BenhNhan BenhNhan { get; set; } = null!;

        [ForeignKey(nameof(BacSiId))]
        public User BacSi { get; set; } = null!;

        public DateTime NgayKeDon { get; set; }

        [Required]
        [MaxLength(255)]
        public string ChanDoan { get; set; } = string.Empty;

        [Required]
        [MaxLength(50)]
        public string TrangThai { get; set; } = string.Empty;
        // "NHAP", "CHO_XUAT_THUOC", "DA_XUAT_THUOC", "DA_HUY"

        [MaxLength(255)]
        public string? GhiChu { get; set; }

        public ICollection<ChiTietDonThuoc> ChiTietDonThuocs { get; set; }
            = new List<ChiTietDonThuoc>();

        public PhieuXuatThuoc? PhieuXuatThuoc { get; set; }
    }
}
