using Microsoft.EntityFrameworkCore;
using QLQuayThuoc.Models;

namespace QLQuayThuoc.Data
{
    public class AppDbContext : DbContext
    {
        // Nếu máy của các thành viên dùng tài khoản MySQL khác,
        // chỉ cần sửa chuỗi kết nối này trước khi chạy Update-Database.
        private const string ConnectionString =
            "server=localhost;port=3306;database=QLQuayThuoc;user=root;password=12345678;";     // Sửa chuỗi kết nối nếu cần thiết (password đang trống)

        public DbSet<User> Users { get; set; }
        public DbSet<BenhNhan> BenhNhans { get; set; }
        public DbSet<DonThuoc> DonThuocs { get; set; }
        public DbSet<ChiTietDonThuoc> ChiTietDonThuocs { get; set; }
        public DbSet<Thuoc> Thuocs { get; set; }
        public DbSet<LoThuoc> LoThuocs { get; set; }
        public DbSet<PhieuXuatThuoc> PhieuXuatThuocs { get; set; }
        public DbSet<ChiTietPhieuXuat> ChiTietPhieuXuats { get; set; }
        public DbSet<PhieuXinCapThuoc> PhieuXinCapThuocs { get; set; }
        public DbSet<ChiTietPhieuXinCap> ChiTietPhieuXinCaps { get; set; }
        public DbSet<HoaDon> HoaDons { get; set; }

        public AppDbContext()
        {
        }

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySQL(ConnectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // =========================================================
            // 1. KHÓA CHÍNH KÉP
            // =========================================================

            modelBuilder.Entity<ChiTietDonThuoc>()
                .HasKey(x => new
                {
                    x.MaDonThuoc,
                    x.MaThuoc
                });

            modelBuilder.Entity<ChiTietPhieuXuat>()
                .HasKey(x => new
                {
                    x.MaPhieuXuat,
                    x.MaLo
                });

            modelBuilder.Entity<ChiTietPhieuXinCap>()
                .HasKey(x => new
                {
                    x.MaPhieu,
                    x.MaThuoc
                });


            // =========================================================
            // 2. USER
            // =========================================================

            // Không cho phép trùng email tài khoản.
            modelBuilder.Entity<User>()
                .HasIndex(x => x.Email)
                .IsUnique();

            // Một User (bác sĩ) có thể kê nhiều đơn thuốc.
            modelBuilder.Entity<DonThuoc>()
                .HasOne(x => x.BacSi)
                .WithMany(x => x.DonThuocs)
                .HasForeignKey(x => x.BacSiId)
                .OnDelete(DeleteBehavior.Restrict);

            // Một User (dược sĩ) có thể lập nhiều phiếu xuất thuốc.
            modelBuilder.Entity<PhieuXuatThuoc>()
                .HasOne(x => x.DuocSi)
                .WithMany(x => x.PhieuXuatThuocs)
                .HasForeignKey(x => x.DuocSiId)
                .OnDelete(DeleteBehavior.Restrict);

            // Một User (thu ngân) có thể xử lý nhiều hóa đơn.
            modelBuilder.Entity<HoaDon>()
                .HasOne(x => x.ThuNgan)
                .WithMany(x => x.HoaDons)
                .HasForeignKey(x => x.ThuNganId)
                .OnDelete(DeleteBehavior.Restrict);

            // Một User có thể lập nhiều phiếu xin cấp thuốc.
            modelBuilder.Entity<PhieuXinCapThuoc>()
                .HasOne(x => x.NguoiLap)
                .WithMany(x => x.PhieuDaLap)
                .HasForeignKey(x => x.NguoiLapId)
                .OnDelete(DeleteBehavior.Restrict);

            // Một User có thể duyệt nhiều phiếu xin cấp thuốc.
            modelBuilder.Entity<PhieuXinCapThuoc>()
                .HasOne(x => x.NguoiDuyet)
                .WithMany(x => x.PhieuDaDuyet)
                .HasForeignKey(x => x.NguoiDuyetId)
                .OnDelete(DeleteBehavior.Restrict);


            // =========================================================
            // 3. BỆNH NHÂN - ĐƠN THUỐC
            // =========================================================

            // Một bệnh nhân có thể có nhiều đơn thuốc.
            modelBuilder.Entity<DonThuoc>()
                .HasOne(x => x.BenhNhan)
                .WithMany(x => x.DonThuocs)
                .HasForeignKey(x => x.MaBN)
                .OnDelete(DeleteBehavior.Restrict);


            // =========================================================
            // 4. ĐƠN THUỐC - CHI TIẾT ĐƠN THUỐC
            // =========================================================

            modelBuilder.Entity<ChiTietDonThuoc>()
                .HasOne(x => x.DonThuoc)
                .WithMany(x => x.ChiTietDonThuocs)
                .HasForeignKey(x => x.MaDonThuoc)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<ChiTietDonThuoc>()
                .HasOne(x => x.Thuoc)
                .WithMany(x => x.ChiTietDonThuocs)
                .HasForeignKey(x => x.MaThuoc)
                .OnDelete(DeleteBehavior.Restrict);


            // =========================================================
            // 5. THUỐC - LÔ THUỐC
            // =========================================================

            // Một thuốc có nhiều lô thuốc.
            modelBuilder.Entity<LoThuoc>()
                .HasOne(x => x.Thuoc)
                .WithMany(x => x.LoThuocs)
                .HasForeignKey(x => x.MaThuoc)
                .OnDelete(DeleteBehavior.Restrict);

            // Không cho phép trùng số lô của cùng một thuốc.
            modelBuilder.Entity<LoThuoc>()
                .HasIndex(x => new
                {
                    x.MaThuoc,
                    x.SoLo
                })
                .IsUnique();


            // =========================================================
            // 6. ĐƠN THUỐC - PHIẾU XUẤT THUỐC
            // =========================================================

            // Một đơn thuốc có tối đa một phiếu xuất thuốc.
            modelBuilder.Entity<DonThuoc>()
                .HasOne(x => x.PhieuXuatThuoc)
                .WithOne(x => x.DonThuoc)
                .HasForeignKey<PhieuXuatThuoc>(x => x.MaDonThuoc)
                .OnDelete(DeleteBehavior.Restrict);


            // =========================================================
            // 7. PHIẾU XUẤT - CHI TIẾT PHIẾU XUẤT - LÔ THUỐC
            // =========================================================

            modelBuilder.Entity<ChiTietPhieuXuat>()
                .HasOne(x => x.PhieuXuatThuoc)
                .WithMany(x => x.ChiTietPhieuXuats)
                .HasForeignKey(x => x.MaPhieuXuat)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<ChiTietPhieuXuat>()
                .HasOne(x => x.LoThuoc)
                .WithMany(x => x.ChiTietPhieuXuats)
                .HasForeignKey(x => x.MaLo)
                .OnDelete(DeleteBehavior.Restrict);


            // =========================================================
            // 8. PHIẾU XIN CẤP - CHI TIẾT PHIẾU XIN CẤP - THUỐC
            // =========================================================

            modelBuilder.Entity<ChiTietPhieuXinCap>()
                .HasOne(x => x.PhieuXinCapThuoc)
                .WithMany(x => x.ChiTietPhieuXinCaps)
                .HasForeignKey(x => x.MaPhieu)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<ChiTietPhieuXinCap>()
                .HasOne(x => x.Thuoc)
                .WithMany(x => x.ChiTietPhieuXinCaps)
                .HasForeignKey(x => x.MaThuoc)
                .OnDelete(DeleteBehavior.Restrict);


            // =========================================================
            // 9. ĐƠN THUỐC - HÓA ĐƠN
            // =========================================================

            // Một đơn thuốc có tối đa một hóa đơn.
            modelBuilder.Entity<DonThuoc>()
                .HasOne(x => x.HoaDon)
                .WithOne(x => x.DonThuoc)
                .HasForeignKey<HoaDon>(x => x.MaDonThuoc)
                .OnDelete(DeleteBehavior.Restrict);


            // =========================================================
            // 10. KIỂU DECIMAL
            // =========================================================

            modelBuilder.Entity<Thuoc>()
                .Property(x => x.DonGia)
                .HasPrecision(18, 2);

            modelBuilder.Entity<LoThuoc>()
                .Property(x => x.GiaNhap)
                .HasPrecision(18, 2);

            modelBuilder.Entity<ChiTietPhieuXuat>()
                .Property(x => x.DonGia)
                .HasPrecision(18, 2);

            modelBuilder.Entity<ChiTietPhieuXuat>()
                .Property(x => x.ThanhTien)
                .HasPrecision(18, 2);

            modelBuilder.Entity<HoaDon>()
                .Property(x => x.TongTienThuoc)
                .HasPrecision(18, 2);

            modelBuilder.Entity<HoaDon>()
                .Property(x => x.TienBHYTThanhToan)
                .HasPrecision(18, 2);

            modelBuilder.Entity<HoaDon>()
                .Property(x => x.TienBenhNhanTra)
                .HasPrecision(18, 2);


            // =========================================================
            // 11. SEED ADMIN MẶC ĐỊNH
            // =========================================================
            //
            // Tài khoản đăng nhập ban đầu:
            // Email:    admin@gmail.com
            // Password: Admin@123
            //
            // PasswordHash bên dưới là hash cố định theo định dạng
            // ASP.NET Core Identity PasswordHasher.
            // Không gọi HashPassword() trực tiếp tại đây vì HasData
            // cần dữ liệu cố định để migration không thay đổi mỗi lần.
            //
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    UserId = 1,
                    FullName = "Quản trị viên",
                    PhoneNumber = "0000000000",
                    Email = "admin@gmail.com",
                    PasswordHash = "AQAAAAEAAYagAAAAEAoi8S+gZ0EPMOKWIBoNTKwyLG/nnw896ohJOJu9e08MOxZeFhPyujJBQkB85AfiZw==",
                    Role = "ADMIN",
                    IsActive = true
                }
            );
        }
    }
}
