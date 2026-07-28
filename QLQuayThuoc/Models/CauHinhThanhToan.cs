using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QLQuayThuoc.Models
{
    public class CauHinhThanhToan
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public byte MaCauHinh { get; set; }

        [Required]
        [MaxLength(255)]
        public string MatKhauApi { get; set; } = string.Empty;

        [Required]
        [MaxLength(500)]
        public string TokenApi { get; set; } = string.Empty;

        [Required]
        [MaxLength(500)]
        public string DuongDanApiGiaoDich { get; set; } = string.Empty;

        [Required]
        [MaxLength(20)]
        public string MaNganHang { get; set; } = string.Empty;

        [Required]
        [MaxLength(50)]
        public string SoTaiKhoan { get; set; } = string.Empty;

        [Required]
        [MaxLength(150)]
        public string TenChuTaiKhoan { get; set; } = string.Empty;

        [Required]
        [MaxLength(500)]
        public string DuongDanTaoQR { get; set; } = string.Empty;

        [Required]
        [MaxLength(100)]
        public string MaDinhDanhQR { get; set; } = string.Empty;

        [Required]
        [MaxLength(20)]
        public string TienToNoiDungChuyenKhoan { get; set; } =
            string.Empty;

        public bool DangHoatDong { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime NgayCapNhat { get; set; }
    }
}