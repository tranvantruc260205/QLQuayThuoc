using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLQuayThuoc.Models
{
    public class BenhNhan
    {
        [Key]
        public int MaBN { get; set; }
        [Required]
        [MaxLength(100)]
        public string HoTen { get; set; }
        
        public DateTime NgaySinh { get; set; }
        
        public bool GioiTinh { get; set; } // true: Nam, false: Nu
        [Required]
        [MaxLength(255)]
        public string DiaChi { get; set; }
        [Required]
        [MaxLength(20)]
        public string SoDienThoai { get; set; }
        
        [MaxLength(20)]
        public string? MaBHYT { get; set; }

        public ICollection<DonThuoc> DonThuocs { get; set; } = new List<DonThuoc>();
    }
}