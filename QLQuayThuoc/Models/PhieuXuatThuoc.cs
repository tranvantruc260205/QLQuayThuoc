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

        public int MaKho { get; set; }

        public int DuocSiId { get; set; }

        public DateTime NgayXuat { get; set; }

        [ForeignKey(nameof(MaDonThuoc))]
        public DonThuoc DonThuoc { get; set; } = null!;

        [ForeignKey(nameof(MaKho))]
        public Kho Kho { get; set; } = null!;

        [ForeignKey(nameof(DuocSiId))]
        public User DuocSi { get; set; } = null!;

        public ICollection<ChiTietPhieuXuat> ChiTietPhieuXuats { get; set; }
            = new List<ChiTietPhieuXuat>();

        public HoaDon? HoaDon { get; set; }
    }
}
