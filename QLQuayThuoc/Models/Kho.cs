using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace QLQuayThuoc.Models
{
    public class Kho
    {
        [Key]
        public int MaKho { get; set; }

        [Required]
        [MaxLength(100)]
        public string TenKho { get; set; } = string.Empty;

        [Required]
        [MaxLength(50)]
        public string LoaiKho { get; set; } = string.Empty;
        // "KHO_TONG", "KHO_QUAY"

        public ICollection<TonKho> TonKhos { get; set; }
            = new List<TonKho>();

        public ICollection<PhieuXuatThuoc> PhieuXuatThuocs { get; set; }
            = new List<PhieuXuatThuoc>();

        public ICollection<PhieuXinCapThuoc> PhieuCapDi { get; set; }
            = new List<PhieuXinCapThuoc>();

        public ICollection<PhieuXinCapThuoc> PhieuNhanVe { get; set; }
            = new List<PhieuXinCapThuoc>();
    }
}
