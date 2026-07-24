using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

#nullable disable

namespace QLQuayThuoc.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "BenhNhans",
                columns: table => new
                {
                    MaBN = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    HoTen = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    NgaySinh = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    GioiTinh = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    DiaChi = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    SoDienThoai = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    MaBHYT = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true),
                    MucHuongBHYT = table.Column<int>(type: "int", nullable: false),
                    NgayHetHanBHYT = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BenhNhans", x => x.MaBN);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Khos",
                columns: table => new
                {
                    MaKho = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    TenKho = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    LoaiKho = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Khos", x => x.MaKho);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Thuocs",
                columns: table => new
                {
                    MaThuoc = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    TenThuoc = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    DonViTinh = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    HoatChat = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    HamLuong = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    DonGiaBan = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DuocBHYTChiTra = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    TrangThai = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Thuocs", x => x.MaThuoc);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    FullName = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    PhoneNumber = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    Email = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    PasswordHash = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    Role = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    IsActive = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "LoThuocs",
                columns: table => new
                {
                    MaLo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    MaThuoc = table.Column<int>(type: "int", nullable: false),
                    SoLo = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    NgaySanXuat = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    NgayHetHan = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoThuocs", x => x.MaLo);
                    table.ForeignKey(
                        name: "FK_LoThuocs_Thuocs_MaThuoc",
                        column: x => x.MaThuoc,
                        principalTable: "Thuocs",
                        principalColumn: "MaThuoc",
                        onDelete: ReferentialAction.Restrict);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "DonThuocs",
                columns: table => new
                {
                    MaDonThuoc = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    MaBN = table.Column<int>(type: "int", nullable: false),
                    BacSiId = table.Column<int>(type: "int", nullable: false),
                    NgayKeDon = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    ChanDoan = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    TrangThai = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    GhiChu = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DonThuocs", x => x.MaDonThuoc);
                    table.ForeignKey(
                        name: "FK_DonThuocs_BenhNhans_MaBN",
                        column: x => x.MaBN,
                        principalTable: "BenhNhans",
                        principalColumn: "MaBN",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DonThuocs_Users_BacSiId",
                        column: x => x.BacSiId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "PhieuXinCapThuocs",
                columns: table => new
                {
                    MaPhieu = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    KhoCapId = table.Column<int>(type: "int", nullable: false),
                    KhoNhanId = table.Column<int>(type: "int", nullable: false),
                    NguoiLapId = table.Column<int>(type: "int", nullable: false),
                    NguoiDuyetId = table.Column<int>(type: "int", nullable: true),
                    NgayLap = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    NgayDuyet = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    LyDo = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    GhiChuDuyet = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true),
                    TrangThai = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhieuXinCapThuocs", x => x.MaPhieu);
                    table.ForeignKey(
                        name: "FK_PhieuXinCapThuocs_Khos_KhoCapId",
                        column: x => x.KhoCapId,
                        principalTable: "Khos",
                        principalColumn: "MaKho",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PhieuXinCapThuocs_Khos_KhoNhanId",
                        column: x => x.KhoNhanId,
                        principalTable: "Khos",
                        principalColumn: "MaKho",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PhieuXinCapThuocs_Users_NguoiDuyetId",
                        column: x => x.NguoiDuyetId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PhieuXinCapThuocs_Users_NguoiLapId",
                        column: x => x.NguoiLapId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TonKhos",
                columns: table => new
                {
                    MaKho = table.Column<int>(type: "int", nullable: false),
                    MaLo = table.Column<int>(type: "int", nullable: false),
                    SoLuongTon = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TonKhos", x => new { x.MaKho, x.MaLo });
                    table.ForeignKey(
                        name: "FK_TonKhos_Khos_MaKho",
                        column: x => x.MaKho,
                        principalTable: "Khos",
                        principalColumn: "MaKho",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TonKhos_LoThuocs_MaLo",
                        column: x => x.MaLo,
                        principalTable: "LoThuocs",
                        principalColumn: "MaLo",
                        onDelete: ReferentialAction.Restrict);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ChiTietDonThuocs",
                columns: table => new
                {
                    MaDonThuoc = table.Column<int>(type: "int", nullable: false),
                    MaThuoc = table.Column<int>(type: "int", nullable: false),
                    SoLuong = table.Column<int>(type: "int", nullable: false),
                    LieuDung = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    TanSuat = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    SoNgayDung = table.Column<int>(type: "int", nullable: false),
                    GhiChu = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiTietDonThuocs", x => new { x.MaDonThuoc, x.MaThuoc });
                    table.ForeignKey(
                        name: "FK_ChiTietDonThuocs_DonThuocs_MaDonThuoc",
                        column: x => x.MaDonThuoc,
                        principalTable: "DonThuocs",
                        principalColumn: "MaDonThuoc",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ChiTietDonThuocs_Thuocs_MaThuoc",
                        column: x => x.MaThuoc,
                        principalTable: "Thuocs",
                        principalColumn: "MaThuoc",
                        onDelete: ReferentialAction.Restrict);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "PhieuXuatThuocs",
                columns: table => new
                {
                    MaPhieuXuat = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    MaDonThuoc = table.Column<int>(type: "int", nullable: false),
                    MaKho = table.Column<int>(type: "int", nullable: false),
                    DuocSiId = table.Column<int>(type: "int", nullable: false),
                    NgayXuat = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhieuXuatThuocs", x => x.MaPhieuXuat);
                    table.ForeignKey(
                        name: "FK_PhieuXuatThuocs_DonThuocs_MaDonThuoc",
                        column: x => x.MaDonThuoc,
                        principalTable: "DonThuocs",
                        principalColumn: "MaDonThuoc",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PhieuXuatThuocs_Khos_MaKho",
                        column: x => x.MaKho,
                        principalTable: "Khos",
                        principalColumn: "MaKho",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PhieuXuatThuocs_Users_DuocSiId",
                        column: x => x.DuocSiId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ChiTietPhieuXinCaps",
                columns: table => new
                {
                    MaPhieu = table.Column<int>(type: "int", nullable: false),
                    MaThuoc = table.Column<int>(type: "int", nullable: false),
                    SoLuongYeuCau = table.Column<int>(type: "int", nullable: false),
                    SoLuongDuyet = table.Column<int>(type: "int", nullable: true),
                    GhiChu = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiTietPhieuXinCaps", x => new { x.MaPhieu, x.MaThuoc });
                    table.ForeignKey(
                        name: "FK_ChiTietPhieuXinCaps_PhieuXinCapThuocs_MaPhieu",
                        column: x => x.MaPhieu,
                        principalTable: "PhieuXinCapThuocs",
                        principalColumn: "MaPhieu",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ChiTietPhieuXinCaps_Thuocs_MaThuoc",
                        column: x => x.MaThuoc,
                        principalTable: "Thuocs",
                        principalColumn: "MaThuoc",
                        onDelete: ReferentialAction.Restrict);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ChiTietPhieuXuats",
                columns: table => new
                {
                    MaPhieuXuat = table.Column<int>(type: "int", nullable: false),
                    MaLo = table.Column<int>(type: "int", nullable: false),
                    SoLuong = table.Column<int>(type: "int", nullable: false),
                    DonGiaBan = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ThanhTien = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiTietPhieuXuats", x => new { x.MaPhieuXuat, x.MaLo });
                    table.ForeignKey(
                        name: "FK_ChiTietPhieuXuats_LoThuocs_MaLo",
                        column: x => x.MaLo,
                        principalTable: "LoThuocs",
                        principalColumn: "MaLo",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ChiTietPhieuXuats_PhieuXuatThuocs_MaPhieuXuat",
                        column: x => x.MaPhieuXuat,
                        principalTable: "PhieuXuatThuocs",
                        principalColumn: "MaPhieuXuat",
                        onDelete: ReferentialAction.Restrict);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "HoaDons",
                columns: table => new
                {
                    MaHD = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    MaPhieuXuat = table.Column<int>(type: "int", nullable: false),
                    TongTienThuoc = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TienThuocDuocBHYT = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TyLeBHYTApDung = table.Column<int>(type: "int", nullable: false),
                    TienBHYTThanhToan = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TienBenhNhanTra = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PhuongThucThanhToan = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    NoiDungChuyenKhoan = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true),
                    MaGiaoDich = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    ThoiGianThanhToan = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoaDons", x => x.MaHD);
                    table.ForeignKey(
                        name: "FK_HoaDons_PhieuXuatThuocs_MaPhieuXuat",
                        column: x => x.MaPhieuXuat,
                        principalTable: "PhieuXuatThuocs",
                        principalColumn: "MaPhieuXuat",
                        onDelete: ReferentialAction.Restrict);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ChiTietCapTheoLos",
                columns: table => new
                {
                    MaPhieu = table.Column<int>(type: "int", nullable: false),
                    MaThuoc = table.Column<int>(type: "int", nullable: false),
                    MaLo = table.Column<int>(type: "int", nullable: false),
                    SoLuongCap = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiTietCapTheoLos", x => new { x.MaPhieu, x.MaThuoc, x.MaLo });
                    table.ForeignKey(
                        name: "FK_ChiTietCapTheoLos_ChiTietPhieuXinCaps_MaPhieu_MaThuoc",
                        columns: x => new { x.MaPhieu, x.MaThuoc },
                        principalTable: "ChiTietPhieuXinCaps",
                        principalColumns: new[] { "MaPhieu", "MaThuoc" },
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ChiTietCapTheoLos_LoThuocs_MaLo",
                        column: x => x.MaLo,
                        principalTable: "LoThuocs",
                        principalColumn: "MaLo",
                        onDelete: ReferentialAction.Restrict);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Khos",
                columns: new[] { "MaKho", "LoaiKho", "TenKho" },
                values: new object[] { 1, "KHO_TONG", "Kho tổng" });

            migrationBuilder.InsertData(
                table: "Khos",
                columns: new[] { "MaKho", "LoaiKho", "TenKho" },
                values: new object[] { 2, "KHO_QUAY", "Kho quầy" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Email", "FullName", "IsActive", "PasswordHash", "PhoneNumber", "Role" },
                values: new object[] { 1, "admin@gmail.com", "Quản trị viên", true, "AQAAAAEAAYagAAAAEAoi8S+gZ0EPMOKWIBoNTKwyLG/nnw896ohJOJu9e08MOxZeFhPyujJBQkB85AfiZw==", "0000000000", "ADMIN" });

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietCapTheoLos_MaLo",
                table: "ChiTietCapTheoLos",
                column: "MaLo");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietDonThuocs_MaThuoc",
                table: "ChiTietDonThuocs",
                column: "MaThuoc");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietPhieuXinCaps_MaThuoc",
                table: "ChiTietPhieuXinCaps",
                column: "MaThuoc");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietPhieuXuats_MaLo",
                table: "ChiTietPhieuXuats",
                column: "MaLo");

            migrationBuilder.CreateIndex(
                name: "IX_DonThuocs_BacSiId",
                table: "DonThuocs",
                column: "BacSiId");

            migrationBuilder.CreateIndex(
                name: "IX_DonThuocs_MaBN",
                table: "DonThuocs",
                column: "MaBN");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDons_MaGiaoDich",
                table: "HoaDons",
                column: "MaGiaoDich",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_HoaDons_MaPhieuXuat",
                table: "HoaDons",
                column: "MaPhieuXuat",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_LoThuocs_MaThuoc_SoLo",
                table: "LoThuocs",
                columns: new[] { "MaThuoc", "SoLo" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PhieuXinCapThuocs_KhoCapId",
                table: "PhieuXinCapThuocs",
                column: "KhoCapId");

            migrationBuilder.CreateIndex(
                name: "IX_PhieuXinCapThuocs_KhoNhanId",
                table: "PhieuXinCapThuocs",
                column: "KhoNhanId");

            migrationBuilder.CreateIndex(
                name: "IX_PhieuXinCapThuocs_NguoiDuyetId",
                table: "PhieuXinCapThuocs",
                column: "NguoiDuyetId");

            migrationBuilder.CreateIndex(
                name: "IX_PhieuXinCapThuocs_NguoiLapId",
                table: "PhieuXinCapThuocs",
                column: "NguoiLapId");

            migrationBuilder.CreateIndex(
                name: "IX_PhieuXuatThuocs_DuocSiId",
                table: "PhieuXuatThuocs",
                column: "DuocSiId");

            migrationBuilder.CreateIndex(
                name: "IX_PhieuXuatThuocs_MaDonThuoc",
                table: "PhieuXuatThuocs",
                column: "MaDonThuoc",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PhieuXuatThuocs_MaKho",
                table: "PhieuXuatThuocs",
                column: "MaKho");

            migrationBuilder.CreateIndex(
                name: "IX_TonKhos_MaLo",
                table: "TonKhos",
                column: "MaLo");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Email",
                table: "Users",
                column: "Email",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChiTietCapTheoLos");

            migrationBuilder.DropTable(
                name: "ChiTietDonThuocs");

            migrationBuilder.DropTable(
                name: "ChiTietPhieuXuats");

            migrationBuilder.DropTable(
                name: "HoaDons");

            migrationBuilder.DropTable(
                name: "TonKhos");

            migrationBuilder.DropTable(
                name: "ChiTietPhieuXinCaps");

            migrationBuilder.DropTable(
                name: "PhieuXuatThuocs");

            migrationBuilder.DropTable(
                name: "LoThuocs");

            migrationBuilder.DropTable(
                name: "PhieuXinCapThuocs");

            migrationBuilder.DropTable(
                name: "DonThuocs");

            migrationBuilder.DropTable(
                name: "Thuocs");

            migrationBuilder.DropTable(
                name: "Khos");

            migrationBuilder.DropTable(
                name: "BenhNhans");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
