using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace QLQuayThuoc.Models
{
    public class BenhNhan
    {
        [Key]
        public int MaBN { get; set; }
        [Required]
        [MaxLength(100)]
        public string HoTen { get; set; } = string.Empty;

        public DateTime NgaySinh { get; set; }

        public bool GioiTinh { get; set; } // true: Nam, false: Nữ

        [Required]
        [MaxLength(255)]
        public string DiaChi { get; set; } = string.Empty;

        [Required]
        [MaxLength(20)]
        public string SoDienThoai { get; set; } = string.Empty;

        [MaxLength(20)]
        public string? MaBHYT { get; set; }

        // Lưu dưới dạng phần trăm: 0, 80, 95 hoặc 100.
        public int MucHuongBHYT { get; set; }

        public DateTime? NgayHetHanBHYT { get; set; }

        public ICollection<DonThuoc> DonThuocs { get; set; } = new List<DonThuoc>();
    }
}
