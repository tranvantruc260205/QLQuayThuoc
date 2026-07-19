using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace QLQuayThuoc.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }


        [Required]
        [MaxLength(100)]
        public string FullName { get; set; }


        [Required]
        [MaxLength(20)]
        public string PhoneNumber { get; set; }


        [Required]
        [EmailAddress]
        [MaxLength(100)]
        public string Email { get; set; }


        [Required]
        [MaxLength(255)]
        public string PasswordHash { get; set; }


        [Required]
        [MaxLength(50)]
        public string Role { get; set; }


        public bool IsActive { get; set; }


        public ICollection<PhieuXinCapThuoc> PhieuDaLap { get; set; }
            = new List<PhieuXinCapThuoc>();

        public ICollection<PhieuXinCapThuoc> PhieuDaDuyet { get; set; }
            = new List<PhieuXinCapThuoc>();


        public ICollection<DonThuoc> DonThuocs { get; set; }
            = new List<DonThuoc>();


        public ICollection<PhieuXuatThuoc> PhieuXuatThuocs { get; set; }
            = new List<PhieuXuatThuoc>();


        public ICollection<HoaDon> HoaDons { get; set; }
            = new List<HoaDon>();
    }
}