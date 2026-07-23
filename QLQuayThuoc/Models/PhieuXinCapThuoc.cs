using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QLQuayThuoc.Models
{
    public class PhieuXinCapThuoc
    {
        [Key]
        public int MaPhieu { get; set; }

        public int KhoCapId { get; set; }

        public int KhoNhanId { get; set; }

        public int NguoiLapId { get; set; }

        public int? NguoiDuyetId { get; set; }

        public DateTime NgayLap { get; set; }

        public DateTime? NgayDuyet { get; set; }

        [Required]
        [MaxLength(255)]
        public string LyDo { get; set; } = string.Empty;

        [MaxLength(255)]
        public string? GhiChuDuyet { get; set; }

        [Required]
        [MaxLength(50)]
        public string TrangThai { get; set; } = string.Empty;
        // "CHO_DUYET", "DA_DUYET", "DA_TU_CHOI"

        [ForeignKey(nameof(KhoCapId))]
        public Kho KhoCap { get; set; } = null!;

        [ForeignKey(nameof(KhoNhanId))]
        public Kho KhoNhan { get; set; } = null!;

        [ForeignKey(nameof(NguoiLapId))]
        public User NguoiLap { get; set; } = null!;

        [ForeignKey(nameof(NguoiDuyetId))]
        public User? NguoiDuyet { get; set; }

        public ICollection<ChiTietPhieuXinCap> ChiTietPhieuXinCaps { get; set; }
            = new List<ChiTietPhieuXinCap>();
    }
}
