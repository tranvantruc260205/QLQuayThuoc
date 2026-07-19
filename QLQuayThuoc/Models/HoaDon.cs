using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QLQuayThuoc.Models
{
    public class HoaDon
    {
        [Key]
        public int MaHD { get; set; }


        public int MaDonThuoc { get; set; }

        [ForeignKey(nameof(MaDonThuoc))]
        public DonThuoc DonThuoc { get; set; }


        public int ThuNganId { get; set; }

        [ForeignKey(nameof(ThuNganId))]
        public User ThuNgan { get; set; }


        public decimal TongTienThuoc { get; set; }

        public decimal TienBHYTThanhToan { get; set; }

        public decimal TienBenhNhanTra { get; set; }

        [Required]
        [MaxLength(50)]
        public string HinhThucThanhToan { get; set; }

        [MaxLength(255)]
        public string? NoiDung { get; set; }

        public DateTime? NgayThanhToan { get; set; }

        [Required]
        [MaxLength(50)]
        public string TrangThai { get; set; }
    }
}