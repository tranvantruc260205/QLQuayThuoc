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
        public string FullName { get; set; } = string.Empty;

        [Required]
        [MaxLength(20)]
        public string PhoneNumber { get; set; } = string.Empty;

        [Required]
        [EmailAddress]
        [MaxLength(100)]
        public string Email { get; set; } = string.Empty;

        [Required]
        [MaxLength(255)]
        public string PasswordHash { get; set; } = string.Empty;

        [Required]
        [MaxLength(50)]
        public string Role { get; set; } = string.Empty;

        public bool IsActive { get; set; }

        public ICollection<DonThuoc> DonThuocs { get; set; }
            = new List<DonThuoc>();

        public ICollection<PhieuXuatThuoc> PhieuXuatThuocs { get; set; }
            = new List<PhieuXuatThuoc>();

        public ICollection<PhieuXinCapThuoc> PhieuDaLap { get; set; }
            = new List<PhieuXinCapThuoc>();

        public ICollection<PhieuXinCapThuoc> PhieuDaDuyet { get; set; }
            = new List<PhieuXinCapThuoc>();
    }
}
