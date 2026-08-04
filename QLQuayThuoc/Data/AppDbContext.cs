using Microsoft.EntityFrameworkCore;
using QLQuayThuoc.Models;

namespace QLQuayThuoc.Data
{
    public class AppDbContext : DbContext
    {
        private const string ConnectionString = "";

        public DbSet<User> Users { get; set; } = null!;
        public DbSet<BenhNhan> BenhNhans { get; set; } = null!;
        public DbSet<DonThuoc> DonThuocs { get; set; } = null!;
        public DbSet<ChiTietDonThuoc> ChiTietDonThuocs { get; set; } = null!;
        public DbSet<Thuoc> Thuocs { get; set; } = null!;
        public DbSet<LoThuoc> LoThuocs { get; set; } = null!;
        public DbSet<Kho> Khos { get; set; } = null!;
        public DbSet<TonKho> TonKhos { get; set; } = null!;
        public DbSet<PhieuXuatThuoc> PhieuXuatThuocs { get; set; } = null!;
        public DbSet<ChiTietPhieuXuat> ChiTietPhieuXuats { get; set; } = null!;
        public DbSet<HoaDon> HoaDons { get; set; } = null!;
        public DbSet<PhieuXinCapThuoc> PhieuXinCapThuocs { get; set; } = null!;
        public DbSet<ChiTietPhieuXinCap> ChiTietPhieuXinCaps { get; set; } = null!;
        public DbSet<ChiTietCapTheoLo> ChiTietCapTheoLos { get; set; } = null!;
        public DbSet<CauHinhThanhToan> CauHinhThanhToans { get; set; } = null!;

        public AppDbContext()
        {
        }

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(
            DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySQL(ConnectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<CauHinhThanhToan>().ToTable("CauHinhThanhToan",table => table.ExcludeFromMigrations());

            // Đặt tên bảng ở dạng số ít
            modelBuilder.Entity<User>()
                .ToTable("User");

            modelBuilder.Entity<BenhNhan>()
                .ToTable("BenhNhan");

            modelBuilder.Entity<DonThuoc>()
                .ToTable("DonThuoc");

            modelBuilder.Entity<ChiTietDonThuoc>()
                .ToTable("ChiTietDonThuoc");

            modelBuilder.Entity<Thuoc>()
                .ToTable("Thuoc");

            modelBuilder.Entity<LoThuoc>()
                .ToTable("LoThuoc");

            modelBuilder.Entity<Kho>()
                .ToTable("Kho");

            modelBuilder.Entity<TonKho>()
                .ToTable("TonKho");

            modelBuilder.Entity<PhieuXuatThuoc>()
                .ToTable("PhieuXuatThuoc");

            modelBuilder.Entity<ChiTietPhieuXuat>()
                .ToTable("ChiTietPhieuXuat");

            modelBuilder.Entity<HoaDon>()
                .ToTable("HoaDon");

            modelBuilder.Entity<PhieuXinCapThuoc>()
                .ToTable("PhieuXinCapThuoc");

            modelBuilder.Entity<ChiTietPhieuXinCap>()
                .ToTable("ChiTietPhieuXinCap");

            modelBuilder.Entity<ChiTietCapTheoLo>()
                .ToTable("ChiTietCapTheoLo");

            // =========================================================
            // 1. KHÓA CHÍNH KÉP
            // =========================================================

            modelBuilder.Entity<ChiTietDonThuoc>()
                .HasKey(x => new { x.MaDonThuoc, x.MaThuoc });

            modelBuilder.Entity<TonKho>()
                .HasKey(x => new { x.MaKho, x.MaLo });

            modelBuilder.Entity<ChiTietPhieuXuat>()
                .HasKey(x => new { x.MaPhieuXuat, x.MaLo });

            modelBuilder.Entity<ChiTietPhieuXinCap>()
                .HasKey(x => new { x.MaPhieu, x.MaThuoc });

            modelBuilder.Entity<ChiTietCapTheoLo>()
                .HasKey(x => new { x.MaPhieu, x.MaThuoc, x.MaLo });

            // =========================================================
            // 2. CÁC GIÁ TRỊ KHÔNG ĐƯỢC TRÙNG
            // =========================================================

            modelBuilder.Entity<User>()
                .HasIndex(x => x.Email)
                .IsUnique();

            modelBuilder.Entity<User>()
            .HasIndex(x => x.PhoneNumber)
            .IsUnique();

            modelBuilder.Entity<LoThuoc>()
                .HasIndex(x => new { x.MaThuoc, x.SoLo })
                .IsUnique();

            modelBuilder.Entity<HoaDon>()
                .HasIndex(x => x.MaGiaoDich)
                .IsUnique();

            // =========================================================
            // 3. USER
            // =========================================================

            modelBuilder.Entity<DonThuoc>()
                .HasOne(x => x.BacSi)
                .WithMany(x => x.DonThuocs)
                .HasForeignKey(x => x.BacSiId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<PhieuXuatThuoc>()
                .HasOne(x => x.DuocSi)
                .WithMany(x => x.PhieuXuatThuocs)
                .HasForeignKey(x => x.DuocSiId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<PhieuXinCapThuoc>()
                .HasOne(x => x.NguoiLap)
                .WithMany(x => x.PhieuDaLap)
                .HasForeignKey(x => x.NguoiLapId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<PhieuXinCapThuoc>()
                .HasOne(x => x.NguoiDuyet)
                .WithMany(x => x.PhieuDaDuyet)
                .HasForeignKey(x => x.NguoiDuyetId)
                .OnDelete(DeleteBehavior.Restrict);

            // =========================================================
            // 4. BỆNH NHÂN - ĐƠN THUỐC - CHI TIẾT ĐƠN
            // =========================================================

            modelBuilder.Entity<DonThuoc>()
                .HasOne(x => x.BenhNhan)
                .WithMany(x => x.DonThuocs)
                .HasForeignKey(x => x.MaBN)
                .OnDelete(DeleteBehavior.Restrict);

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
            // 5. THUỐC - LÔ THUỐC - TỒN KHO
            // =========================================================

            modelBuilder.Entity<LoThuoc>()
                .HasOne(x => x.Thuoc)
                .WithMany(x => x.LoThuocs)
                .HasForeignKey(x => x.MaThuoc)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<TonKho>()
                .HasOne(x => x.Kho)
                .WithMany(x => x.TonKhos)
                .HasForeignKey(x => x.MaKho)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<TonKho>()
                .HasOne(x => x.LoThuoc)
                .WithMany(x => x.TonKhos)
                .HasForeignKey(x => x.MaLo)
                .OnDelete(DeleteBehavior.Restrict);

            // =========================================================
            // 6. ĐƠN THUỐC - PHIẾU XUẤT - HÓA ĐƠN
            // =========================================================

            modelBuilder.Entity<DonThuoc>()
                .HasOne(x => x.PhieuXuatThuoc)
                .WithOne(x => x.DonThuoc)
                .HasForeignKey<PhieuXuatThuoc>(x => x.MaDonThuoc)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<PhieuXuatThuoc>()
                .HasOne(x => x.Kho)
                .WithMany(x => x.PhieuXuatThuocs)
                .HasForeignKey(x => x.MaKho)
                .OnDelete(DeleteBehavior.Restrict);

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

            modelBuilder.Entity<PhieuXuatThuoc>()
                .HasOne(x => x.HoaDon)
                .WithOne(x => x.PhieuXuatThuoc)
                .HasForeignKey<HoaDon>(x => x.MaPhieuXuat)
                .OnDelete(DeleteBehavior.Restrict);

            // =========================================================
            // 7. PHIẾU XIN CẤP THUỐC
            // =========================================================

            modelBuilder.Entity<PhieuXinCapThuoc>()
                .HasOne(x => x.KhoCap)
                .WithMany(x => x.PhieuCapDi)
                .HasForeignKey(x => x.KhoCapId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<PhieuXinCapThuoc>()
                .HasOne(x => x.KhoNhan)
                .WithMany(x => x.PhieuNhanVe)
                .HasForeignKey(x => x.KhoNhanId)
                .OnDelete(DeleteBehavior.Restrict);

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

            modelBuilder.Entity<ChiTietCapTheoLo>()
                .HasOne(x => x.ChiTietPhieuXinCap)
                .WithMany(x => x.ChiTietCapTheoLos)
                .HasForeignKey(x => new { x.MaPhieu, x.MaThuoc })
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<ChiTietCapTheoLo>()
                .HasOne(x => x.LoThuoc)
                .WithMany(x => x.ChiTietCapTheoLos)
                .HasForeignKey(x => x.MaLo)
                .OnDelete(DeleteBehavior.Restrict);

            // =========================================================
            // 8. DỮ LIỆU CỐ ĐỊNH BAN ĐẦU
            // =========================================================

            modelBuilder.Entity<Kho>().HasData(
                new Kho
                {
                    MaKho = 1,
                    TenKho = "Kho tổng",
                    LoaiKho = "KHO_TONG"
                },
                new Kho
                {
                    MaKho = 2,
                    TenKho = "Kho quầy",
                    LoaiKho = "KHO_QUAY"
                }
            );

            modelBuilder.Entity<User>().HasData(
                new User
                {
                    UserId = 1,
                    FullName = "Quản trị viên",
                    PhoneNumber = "0000000000",
                    Email = "admin@gmail.com",
                    PasswordHash = "AQAAAAEAAYagAAAAEAoi8S+gZ0EPMOKWIBoNTKwyLG/nnw896ohJOJu9e08MOxZeFhPyujJBQkB85AfiZw==", //Password : Admin@123
                    Role = "ADMIN",
                    IsActive = true
                }
            );
        }
    }
}
