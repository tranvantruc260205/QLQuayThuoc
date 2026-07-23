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

        [Required]
        [MaxLength(100)]
        public string SoLo { get; set; } = string.Empty;

        public DateTime? NgaySanXuat { get; set; }

        public DateTime NgayHetHan { get; set; }

        [ForeignKey(nameof(MaThuoc))]
        public Thuoc Thuoc { get; set; } = null!;

        public ICollection<TonKho> TonKhos { get; set; }
            = new List<TonKho>();

        public ICollection<ChiTietPhieuXuat> ChiTietPhieuXuats { get; set; }
            = new List<ChiTietPhieuXuat>();

        public ICollection<ChiTietCapTheoLo> ChiTietCapTheoLos { get; set; }
            = new List<ChiTietCapTheoLo>();
    }
}
