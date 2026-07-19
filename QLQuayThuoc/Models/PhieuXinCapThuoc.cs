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


        public int NguoiLapId { get; set; }

        [ForeignKey(nameof(NguoiLapId))]
        public User NguoiLap { get; set; }


        public DateTime NgayLap { get; set; }

        [Required]
        [MaxLength(255)]
        public string LyDo { get; set; }

        [Required]
        [MaxLength(100)]
        public string TrangThai { get; set; }
        // "CHO_DUYET", "DA_DUYET", "DA_TU_CHOI"


        public int? NguoiDuyetId { get; set; }

        [ForeignKey(nameof(NguoiDuyetId))]
        public User? NguoiDuyet { get; set; }


        public ICollection<ChiTietPhieuXinCap> ChiTietPhieuXinCaps { get; set; }
            = new List<ChiTietPhieuXinCap>();
    }
}