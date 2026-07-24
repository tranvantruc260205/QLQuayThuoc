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
                name: "BenhNhan",
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
                    table.PrimaryKey("PK_BenhNhan", x => x.MaBN);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Kho",
                columns: table => new
                {
                    MaKho = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    TenKho = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    LoaiKho = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kho", x => x.MaKho);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Thuoc",
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
                    table.PrimaryKey("PK_Thuoc", x => x.MaThuoc);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "User",
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
                    table.PrimaryKey("PK_User", x => x.UserId);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "LoThuoc",
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
                    table.PrimaryKey("PK_LoThuoc", x => x.MaLo);
                    table.ForeignKey(
                        name: "FK_LoThuoc_Thuoc_MaThuoc",
                        column: x => x.MaThuoc,
                        principalTable: "Thuoc",
                        principalColumn: "MaThuoc",
                        onDelete: ReferentialAction.Restrict);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "DonThuoc",
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
                    table.PrimaryKey("PK_DonThuoc", x => x.MaDonThuoc);
                    table.ForeignKey(
                        name: "FK_DonThuoc_BenhNhan_MaBN",
                        column: x => x.MaBN,
                        principalTable: "BenhNhan",
                        principalColumn: "MaBN",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DonThuoc_User_BacSiId",
                        column: x => x.BacSiId,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "PhieuXinCapThuoc",
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
                    table.PrimaryKey("PK_PhieuXinCapThuoc", x => x.MaPhieu);
                    table.ForeignKey(
                        name: "FK_PhieuXinCapThuoc_Kho_KhoCapId",
                        column: x => x.KhoCapId,
                        principalTable: "Kho",
                        principalColumn: "MaKho",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PhieuXinCapThuoc_Kho_KhoNhanId",
                        column: x => x.KhoNhanId,
                        principalTable: "Kho",
                        principalColumn: "MaKho",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PhieuXinCapThuoc_User_NguoiDuyetId",
                        column: x => x.NguoiDuyetId,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PhieuXinCapThuoc_User_NguoiLapId",
                        column: x => x.NguoiLapId,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TonKho",
                columns: table => new
                {
                    MaKho = table.Column<int>(type: "int", nullable: false),
                    MaLo = table.Column<int>(type: "int", nullable: false),
                    SoLuongTon = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TonKho", x => new { x.MaKho, x.MaLo });
                    table.ForeignKey(
                        name: "FK_TonKho_Kho_MaKho",
                        column: x => x.MaKho,
                        principalTable: "Kho",
                        principalColumn: "MaKho",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TonKho_LoThuoc_MaLo",
                        column: x => x.MaLo,
                        principalTable: "LoThuoc",
                        principalColumn: "MaLo",
                        onDelete: ReferentialAction.Restrict);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ChiTietDonThuoc",
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
                    table.PrimaryKey("PK_ChiTietDonThuoc", x => new { x.MaDonThuoc, x.MaThuoc });
                    table.ForeignKey(
                        name: "FK_ChiTietDonThuoc_DonThuoc_MaDonThuoc",
                        column: x => x.MaDonThuoc,
                        principalTable: "DonThuoc",
                        principalColumn: "MaDonThuoc",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ChiTietDonThuoc_Thuoc_MaThuoc",
                        column: x => x.MaThuoc,
                        principalTable: "Thuoc",
                        principalColumn: "MaThuoc",
                        onDelete: ReferentialAction.Restrict);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "PhieuXuatThuoc",
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
                    table.PrimaryKey("PK_PhieuXuatThuoc", x => x.MaPhieuXuat);
                    table.ForeignKey(
                        name: "FK_PhieuXuatThuoc_DonThuoc_MaDonThuoc",
                        column: x => x.MaDonThuoc,
                        principalTable: "DonThuoc",
                        principalColumn: "MaDonThuoc",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PhieuXuatThuoc_Kho_MaKho",
                        column: x => x.MaKho,
                        principalTable: "Kho",
                        principalColumn: "MaKho",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PhieuXuatThuoc_User_DuocSiId",
                        column: x => x.DuocSiId,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ChiTietPhieuXinCap",
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
                    table.PrimaryKey("PK_ChiTietPhieuXinCap", x => new { x.MaPhieu, x.MaThuoc });
                    table.ForeignKey(
                        name: "FK_ChiTietPhieuXinCap_PhieuXinCapThuoc_MaPhieu",
                        column: x => x.MaPhieu,
                        principalTable: "PhieuXinCapThuoc",
                        principalColumn: "MaPhieu",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ChiTietPhieuXinCap_Thuoc_MaThuoc",
                        column: x => x.MaThuoc,
                        principalTable: "Thuoc",
                        principalColumn: "MaThuoc",
                        onDelete: ReferentialAction.Restrict);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ChiTietPhieuXuat",
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
                    table.PrimaryKey("PK_ChiTietPhieuXuat", x => new { x.MaPhieuXuat, x.MaLo });
                    table.ForeignKey(
                        name: "FK_ChiTietPhieuXuat_LoThuoc_MaLo",
                        column: x => x.MaLo,
                        principalTable: "LoThuoc",
                        principalColumn: "MaLo",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ChiTietPhieuXuat_PhieuXuatThuoc_MaPhieuXuat",
                        column: x => x.MaPhieuXuat,
                        principalTable: "PhieuXuatThuoc",
                        principalColumn: "MaPhieuXuat",
                        onDelete: ReferentialAction.Restrict);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "HoaDon",
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
                    table.PrimaryKey("PK_HoaDon", x => x.MaHD);
                    table.ForeignKey(
                        name: "FK_HoaDon_PhieuXuatThuoc_MaPhieuXuat",
                        column: x => x.MaPhieuXuat,
                        principalTable: "PhieuXuatThuoc",
                        principalColumn: "MaPhieuXuat",
                        onDelete: ReferentialAction.Restrict);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ChiTietCapTheoLo",
                columns: table => new
                {
                    MaPhieu = table.Column<int>(type: "int", nullable: false),
                    MaThuoc = table.Column<int>(type: "int", nullable: false),
                    MaLo = table.Column<int>(type: "int", nullable: false),
                    SoLuongCap = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiTietCapTheoLo", x => new { x.MaPhieu, x.MaThuoc, x.MaLo });
                    table.ForeignKey(
                        name: "FK_ChiTietCapTheoLo_ChiTietPhieuXinCap_MaPhieu_MaThuoc",
                        columns: x => new { x.MaPhieu, x.MaThuoc },
                        principalTable: "ChiTietPhieuXinCap",
                        principalColumns: new[] { "MaPhieu", "MaThuoc" },
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ChiTietCapTheoLo_LoThuoc_MaLo",
                        column: x => x.MaLo,
                        principalTable: "LoThuoc",
                        principalColumn: "MaLo",
                        onDelete: ReferentialAction.Restrict);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Kho",
                columns: new[] { "MaKho", "LoaiKho", "TenKho" },
                values: new object[] { 1, "KHO_TONG", "Kho tổng" });

            migrationBuilder.InsertData(
                table: "Kho",
                columns: new[] { "MaKho", "LoaiKho", "TenKho" },
                values: new object[] { 2, "KHO_QUAY", "Kho quầy" });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "UserId", "Email", "FullName", "IsActive", "PasswordHash", "PhoneNumber", "Role" },
                values: new object[] { 1, "admin@gmail.com", "Quản trị viên", true, "AQAAAAEAAYagAAAAEAoi8S+gZ0EPMOKWIBoNTKwyLG/nnw896ohJOJu9e08MOxZeFhPyujJBQkB85AfiZw==", "0000000000", "ADMIN" });

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietCapTheoLo_MaLo",
                table: "ChiTietCapTheoLo",
                column: "MaLo");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietDonThuoc_MaThuoc",
                table: "ChiTietDonThuoc",
                column: "MaThuoc");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietPhieuXinCap_MaThuoc",
                table: "ChiTietPhieuXinCap",
                column: "MaThuoc");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietPhieuXuat_MaLo",
                table: "ChiTietPhieuXuat",
                column: "MaLo");

            migrationBuilder.CreateIndex(
                name: "IX_DonThuoc_BacSiId",
                table: "DonThuoc",
                column: "BacSiId");

            migrationBuilder.CreateIndex(
                name: "IX_DonThuoc_MaBN",
                table: "DonThuoc",
                column: "MaBN");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDon_MaGiaoDich",
                table: "HoaDon",
                column: "MaGiaoDich",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_HoaDon_MaPhieuXuat",
                table: "HoaDon",
                column: "MaPhieuXuat",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_LoThuoc_MaThuoc_SoLo",
                table: "LoThuoc",
                columns: new[] { "MaThuoc", "SoLo" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PhieuXinCapThuoc_KhoCapId",
                table: "PhieuXinCapThuoc",
                column: "KhoCapId");

            migrationBuilder.CreateIndex(
                name: "IX_PhieuXinCapThuoc_KhoNhanId",
                table: "PhieuXinCapThuoc",
                column: "KhoNhanId");

            migrationBuilder.CreateIndex(
                name: "IX_PhieuXinCapThuoc_NguoiDuyetId",
                table: "PhieuXinCapThuoc",
                column: "NguoiDuyetId");

            migrationBuilder.CreateIndex(
                name: "IX_PhieuXinCapThuoc_NguoiLapId",
                table: "PhieuXinCapThuoc",
                column: "NguoiLapId");

            migrationBuilder.CreateIndex(
                name: "IX_PhieuXuatThuoc_DuocSiId",
                table: "PhieuXuatThuoc",
                column: "DuocSiId");

            migrationBuilder.CreateIndex(
                name: "IX_PhieuXuatThuoc_MaDonThuoc",
                table: "PhieuXuatThuoc",
                column: "MaDonThuoc",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PhieuXuatThuoc_MaKho",
                table: "PhieuXuatThuoc",
                column: "MaKho");

            migrationBuilder.CreateIndex(
                name: "IX_TonKho_MaLo",
                table: "TonKho",
                column: "MaLo");

            migrationBuilder.CreateIndex(
                name: "IX_User_Email",
                table: "User",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_User_PhoneNumber",
                table: "User",
                column: "PhoneNumber",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChiTietCapTheoLo");

            migrationBuilder.DropTable(
                name: "ChiTietDonThuoc");

            migrationBuilder.DropTable(
                name: "ChiTietPhieuXuat");

            migrationBuilder.DropTable(
                name: "HoaDon");

            migrationBuilder.DropTable(
                name: "TonKho");

            migrationBuilder.DropTable(
                name: "ChiTietPhieuXinCap");

            migrationBuilder.DropTable(
                name: "PhieuXuatThuoc");

            migrationBuilder.DropTable(
                name: "LoThuoc");

            migrationBuilder.DropTable(
                name: "PhieuXinCapThuoc");

            migrationBuilder.DropTable(
                name: "DonThuoc");

            migrationBuilder.DropTable(
                name: "Thuoc");

            migrationBuilder.DropTable(
                name: "Kho");

            migrationBuilder.DropTable(
                name: "BenhNhan");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
