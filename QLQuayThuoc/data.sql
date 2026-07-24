CREATE DATABASE  IF NOT EXISTS `qlquaythuoc` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `qlquaythuoc`;
-- MySQL dump 10.13  Distrib 8.0.46, for Win64 (x86_64)
--
-- Host: localhost    Database: qlquaythuoc
-- ------------------------------------------------------
-- Server version	8.4.10

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `__efmigrationshistory`
--

DROP TABLE IF EXISTS `__efmigrationshistory`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `__efmigrationshistory` (
  `MigrationId` varchar(150) NOT NULL,
  `ProductVersion` varchar(32) NOT NULL,
  PRIMARY KEY (`MigrationId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `__efmigrationshistory`
--

LOCK TABLES `__efmigrationshistory` WRITE;
/*!40000 ALTER TABLE `__efmigrationshistory` DISABLE KEYS */;
INSERT INTO `__efmigrationshistory` VALUES ('20260724113452_InitialMigration','6.0.33');
/*!40000 ALTER TABLE `__efmigrationshistory` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `benhnhan`
--

DROP TABLE IF EXISTS `benhnhan`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `benhnhan` (
  `MaBN` int NOT NULL AUTO_INCREMENT,
  `HoTen` varchar(100) NOT NULL,
  `NgaySinh` datetime(6) NOT NULL,
  `GioiTinh` tinyint(1) NOT NULL,
  `DiaChi` varchar(255) NOT NULL,
  `SoDienThoai` varchar(20) NOT NULL,
  `MaBHYT` varchar(20) DEFAULT NULL,
  `MucHuongBHYT` int NOT NULL,
  `NgayHetHanBHYT` datetime(6) DEFAULT NULL,
  PRIMARY KEY (`MaBN`)
) ENGINE=InnoDB AUTO_INCREMENT=21 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `benhnhan`
--

LOCK TABLES `benhnhan` WRITE;
/*!40000 ALTER TABLE `benhnhan` DISABLE KEYS */;
INSERT INTO `benhnhan` VALUES (1,'Nguyễn Văn An','1985-03-12 00:00:00.000000',1,'12 Nguyễn Trãi, Thanh Xuân, Hà Nội','0903123456','DN4010123456789',80,'2027-12-31 00:00:00.000000'),(2,'Trần Thị Mai','1992-08-21 00:00:00.000000',0,'45 Lê Lợi, Hải Châu, Đà Nẵng','0912234567','DN4010234567890',80,'2027-08-31 00:00:00.000000'),(3,'Lê Hoàng Nam','1958-11-05 00:00:00.000000',1,'78 Trần Hưng Đạo, Hoàn Kiếm, Hà Nội','0983345678','HT3010345678901',95,'2028-01-31 00:00:00.000000'),(4,'Phạm Thu Hà','2016-06-18 00:00:00.000000',0,'25 Nguyễn Văn Linh, Long Biên, Hà Nội','0934456789','TE1010456789012',100,'2027-06-30 00:00:00.000000'),(5,'Hoàng Minh Đức','1977-01-27 00:00:00.000000',1,'16 Võ Văn Tần, Quận 3, TP. Hồ Chí Minh','0975567890',NULL,0,NULL),(6,'Vũ Thị Lan','1966-09-14 00:00:00.000000',0,'102 Điện Biên Phủ, Ba Đình, Hà Nội','0966678901','DN4010678901234',80,'2027-09-30 00:00:00.000000'),(7,'Đỗ Quốc Bảo','1989-04-03 00:00:00.000000',1,'33 Cách Mạng Tháng Tám, Ninh Kiều, Cần Thơ','0947789012','DN4010789012345',80,'2026-06-30 00:00:00.000000'),(8,'Bùi Thị Hương','1954-12-09 00:00:00.000000',0,'56 Quang Trung, Hà Đông, Hà Nội','0928890123','HT3010890123456',95,'2027-12-31 00:00:00.000000'),(9,'Nguyễn Gia Huy','2001-07-25 00:00:00.000000',1,'88 Phan Đình Phùng, Phú Nhuận, TP. Hồ Chí Minh','0909901234','SV4010901234567',80,'2027-09-30 00:00:00.000000'),(10,'Trương Ngọc Anh','1995-02-17 00:00:00.000000',0,'21 Hoàng Diệu, Hải Châu, Đà Nẵng','0911012345','DN4011012345678',80,'2028-02-29 00:00:00.000000'),(11,'Phan Văn Thành','1948-05-30 00:00:00.000000',1,'9 Lý Thường Kiệt, Huế, Thừa Thiên Huế','0982123456','CC1011123456789',100,'2027-05-31 00:00:00.000000'),(12,'Lý Thu Trang','1983-10-11 00:00:00.000000',0,'73 Nguyễn Huệ, Quy Nhơn, Bình Định','0973234567',NULL,0,NULL),(13,'Hồ Minh Khang','2012-03-22 00:00:00.000000',1,'40 Hai Bà Trưng, Vinh, Nghệ An','0964345678','HS4011345678901',80,'2027-03-31 00:00:00.000000'),(14,'Dương Thị Hoa','1960-08-06 00:00:00.000000',0,'15 Lê Duẩn, Buôn Ma Thuột, Đắk Lắk','0955456789','HT3011456789012',95,'2028-06-30 00:00:00.000000'),(15,'Võ Thanh Tùng','1972-06-19 00:00:00.000000',1,'62 Nguyễn Tất Thành, Pleiku, Gia Lai','0946567890','DN4011567890123',80,'2027-06-30 00:00:00.000000'),(16,'Đặng Mỹ Linh','1999-09-01 00:00:00.000000',0,'27 Trần Phú, Nha Trang, Khánh Hòa','0937678901',NULL,0,NULL),(17,'Nguyễn Đức Long','1950-01-15 00:00:00.000000',1,'19 Bạch Đằng, Hồng Bàng, Hải Phòng','0928789012','CC1011789012345',100,'2028-01-31 00:00:00.000000'),(18,'Trần Khánh Vy','1987-12-28 00:00:00.000000',0,'81 Nguyễn Văn Cừ, Ninh Kiều, Cần Thơ','0919890123','DN4011890123456',80,'2027-12-31 00:00:00.000000'),(19,'Lê Nhật Minh','2008-04-10 00:00:00.000000',1,'34 Lê Hồng Phong, Nam Định, Nam Định','0901901234','HS4011901234567',80,'2027-08-31 00:00:00.000000'),(20,'Phạm Ngọc Yến','1979-07-07 00:00:00.000000',0,'11 Hùng Vương, Việt Trì, Phú Thọ','0992012345','DN4012012345678',80,'2026-05-31 00:00:00.000000');
/*!40000 ALTER TABLE `benhnhan` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `chitietcaptheolo`
--

DROP TABLE IF EXISTS `chitietcaptheolo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `chitietcaptheolo` (
  `MaPhieu` int NOT NULL,
  `MaThuoc` int NOT NULL,
  `MaLo` int NOT NULL,
  `SoLuongCap` int NOT NULL,
  PRIMARY KEY (`MaPhieu`,`MaThuoc`,`MaLo`),
  KEY `IX_ChiTietCapTheoLo_MaLo` (`MaLo`),
  CONSTRAINT `FK_ChiTietCapTheoLo_ChiTietPhieuXinCap_MaPhieu_MaThuoc` FOREIGN KEY (`MaPhieu`, `MaThuoc`) REFERENCES `chitietphieuxincap` (`MaPhieu`, `MaThuoc`) ON DELETE RESTRICT,
  CONSTRAINT `FK_ChiTietCapTheoLo_LoThuoc_MaLo` FOREIGN KEY (`MaLo`) REFERENCES `lothuoc` (`MaLo`) ON DELETE RESTRICT
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `chitietcaptheolo`
--

LOCK TABLES `chitietcaptheolo` WRITE;
/*!40000 ALTER TABLE `chitietcaptheolo` DISABLE KEYS */;
INSERT INTO `chitietcaptheolo` VALUES (1,1,1,100),(1,1,2,280),(1,2,3,180),(1,4,7,200),(1,6,11,80),(1,6,12,100),(2,7,13,240),(2,8,15,200),(2,8,16,280),(2,9,17,180),(2,10,19,90),(2,10,20,100),(3,11,21,40),(3,11,22,100),(3,15,29,90),(3,19,37,150),(3,20,39,90),(6,5,9,40),(6,5,10,60),(6,13,25,8),(6,13,26,10),(6,14,27,20),(6,14,28,50),(6,16,31,90),(6,17,33,140);
/*!40000 ALTER TABLE `chitietcaptheolo` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `chitietdonthuoc`
--

DROP TABLE IF EXISTS `chitietdonthuoc`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `chitietdonthuoc` (
  `MaDonThuoc` int NOT NULL,
  `MaThuoc` int NOT NULL,
  `SoLuong` int NOT NULL,
  `LieuDung` varchar(255) NOT NULL,
  `TanSuat` varchar(100) NOT NULL,
  `SoNgayDung` int NOT NULL,
  `GhiChu` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`MaDonThuoc`,`MaThuoc`),
  KEY `IX_ChiTietDonThuoc_MaThuoc` (`MaThuoc`),
  CONSTRAINT `FK_ChiTietDonThuoc_DonThuoc_MaDonThuoc` FOREIGN KEY (`MaDonThuoc`) REFERENCES `donthuoc` (`MaDonThuoc`) ON DELETE RESTRICT,
  CONSTRAINT `FK_ChiTietDonThuoc_Thuoc_MaThuoc` FOREIGN KEY (`MaThuoc`) REFERENCES `thuoc` (`MaThuoc`) ON DELETE RESTRICT
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `chitietdonthuoc`
--

LOCK TABLES `chitietdonthuoc` WRITE;
/*!40000 ALTER TABLE `chitietdonthuoc` DISABLE KEYS */;
INSERT INTO `chitietdonthuoc` VALUES (1,6,30,'Uống 1 viên','1 lần/ngày',30,'Uống buổi sáng.'),(1,7,30,'Uống 1 viên','1 lần/ngày',30,'Uống buổi sáng.'),(1,10,30,'Uống 1 viên','1 lần/ngày',30,'Uống buổi tối.'),(2,1,14,'Uống 1 viên','2 lần/ngày',7,'Chỉ dùng khi đau hoặc sốt.'),(2,2,21,'Uống 1 viên','3 lần/ngày',7,'Uống sau ăn.'),(2,11,7,'Uống 1 viên','1 lần/ngày',7,'Uống buổi tối.'),(3,4,28,'Uống 1 viên','2 lần/ngày',14,'Uống trước ăn 30 phút.'),(3,20,14,'Uống 1 gói','1 lần/ngày',14,'Pha với nước, uống xa thuốc khác.'),(4,8,60,'Uống 1 viên','2 lần/ngày',30,'Uống trong hoặc ngay sau bữa ăn.'),(4,9,30,'Uống 1 viên','1 lần/ngày',30,'Uống trước bữa sáng.'),(4,10,30,'Uống 1 viên','1 lần/ngày',30,'Uống buổi tối.'),(5,1,6,'Uống 1 viên','2 lần/ngày',3,'Chỉ dùng khi sốt.'),(5,19,10,'Pha 1 gói theo hướng dẫn','Sau mỗi lần đi ngoài',3,'Không pha đặc hơn hướng dẫn.'),(5,20,9,'Uống 1 gói','3 lần/ngày',3,'Uống xa các thuốc khác ít nhất 2 giờ.'),(6,12,10,'Uống 1 viên','1 lần/ngày',10,'Uống buổi tối.'),(6,21,10,'Hòa tan 1 viên trong nước','1 lần/ngày',10,'Uống sau ăn.'),(7,1,6,'Uống 1 viên','2 lần/ngày',3,'Chỉ dùng khi đau hoặc sốt.'),(7,13,1,'Xịt 2 nhát mỗi lần','Khi khó thở, tối đa 4 lần/ngày',7,'Lắc kỹ bình trước khi dùng.'),(7,16,3,'Uống 1 viên','1 lần/ngày',3,'Uống trước hoặc sau ăn 1 giờ.'),(8,4,5,'Uống 1 viên','1 lần/ngày',5,'Uống trước bữa sáng.'),(8,17,15,'Uống 1 viên','3 lần/ngày',5,'Uống sau ăn no.'),(9,6,30,'Uống 1 viên','1 lần/ngày',30,'Uống buổi sáng.'),(9,7,30,'Uống 1 viên','1 lần/ngày',30,'Uống buổi sáng.'),(9,10,30,'Uống 1 viên','1 lần/ngày',30,'Uống buổi tối.'),(10,8,60,'Uống 1 viên','2 lần/ngày',30,'Uống trong hoặc ngay sau bữa ăn.'),(10,9,30,'Uống 1 viên','1 lần/ngày',30,'Uống trước bữa sáng.'),(10,10,30,'Uống 1 viên','1 lần/ngày',30,'Uống buổi tối.'),(11,1,14,'Uống 1 viên','2 lần/ngày',7,'Chỉ dùng khi đau hoặc sốt.'),(11,3,14,'Uống 1 viên','2 lần/ngày',7,'Uống đầu bữa ăn.'),(11,11,7,'Uống 1 viên','1 lần/ngày',7,'Uống buổi tối.'),(12,1,10,'Uống 1 viên','2 lần/ngày',5,'Chỉ dùng khi đau.'),(12,15,10,'Uống 1 viên','2 lần/ngày',5,'Uống sau ăn.'),(12,26,1,'Bôi ngoài da một lớp mỏng','2 lần/ngày',7,'Không bôi vào mắt.'),(13,11,10,'Uống 1 viên','1 lần/ngày',10,'Uống buổi tối.'),(13,13,1,'Xịt 2 nhát mỗi lần','Khi khó thở, tối đa 4 lần/ngày',10,'Mang bình xịt theo người.'),(13,14,10,'Khí dung 1 ống','2 lần/ngày',5,'Súc miệng sau khi khí dung.'),(14,1,10,'Uống 1 viên','2 lần/ngày',5,'Chỉ dùng khi đau hoặc sốt.'),(14,23,10,'Uống 1 viên','2 lần/ngày',5,'Uống sau ăn.'),(15,5,7,'Uống 1 viên','1 lần/ngày',7,'Uống trước bữa sáng.'),(15,18,14,'Uống 1 viên','2 lần/ngày',7,'Uống sau ăn no.'),(15,22,30,'Uống 1 viên','1 lần/ngày',30,'Uống sau ăn.'),(16,1,10,'Uống 1 viên','2 lần/ngày',5,'Chỉ dùng khi đau hoặc sốt.'),(16,12,5,'Uống 1 viên','1 lần/ngày',5,'Uống buổi tối.'),(16,21,10,'Hòa tan 1 viên trong nước','2 lần/ngày',5,'Uống sau ăn.'),(17,8,60,'Uống 1 viên','2 lần/ngày',30,'Uống trong hoặc ngay sau bữa ăn.'),(17,10,30,'Uống 1 viên','1 lần/ngày',30,'Uống buổi tối.'),(17,24,1,'Tiêm dưới da theo số đơn vị được hướng dẫn','2 lần/ngày',30,'Bảo quản lạnh, không để đông đá.'),(18,1,14,'Uống 1 viên','2 lần/ngày',7,'Chỉ dùng khi đau hoặc sốt.'),(18,14,10,'Khí dung 1 ống','2 lần/ngày',5,'Súc miệng sau khi khí dung.'),(18,15,14,'Uống 1 viên','2 lần/ngày',7,'Uống sau ăn.'),(19,3,14,'Uống 1 viên','2 lần/ngày',7,'Uống đầu bữa ăn.'),(19,4,7,'Uống 1 viên','1 lần/ngày',7,'Uống trước bữa sáng.'),(20,1,10,'Uống 1 viên','2 lần/ngày',5,NULL),(20,23,10,'Uống 1 viên','2 lần/ngày',5,NULL);
/*!40000 ALTER TABLE `chitietdonthuoc` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `chitietphieuxincap`
--

DROP TABLE IF EXISTS `chitietphieuxincap`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `chitietphieuxincap` (
  `MaPhieu` int NOT NULL,
  `MaThuoc` int NOT NULL,
  `SoLuongYeuCau` int NOT NULL,
  `SoLuongDuyet` int DEFAULT NULL,
  `GhiChu` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`MaPhieu`,`MaThuoc`),
  KEY `IX_ChiTietPhieuXinCap_MaThuoc` (`MaThuoc`),
  CONSTRAINT `FK_ChiTietPhieuXinCap_PhieuXinCapThuoc_MaPhieu` FOREIGN KEY (`MaPhieu`) REFERENCES `phieuxincapthuoc` (`MaPhieu`) ON DELETE RESTRICT,
  CONSTRAINT `FK_ChiTietPhieuXinCap_Thuoc_MaThuoc` FOREIGN KEY (`MaThuoc`) REFERENCES `thuoc` (`MaThuoc`) ON DELETE RESTRICT
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `chitietphieuxincap`
--

LOCK TABLES `chitietphieuxincap` WRITE;
/*!40000 ALTER TABLE `chitietphieuxincap` DISABLE KEYS */;
INSERT INTO `chitietphieuxincap` VALUES (1,1,400,380,'Thuốc hạ sốt dùng thường xuyên.'),(1,2,200,180,NULL),(1,4,200,200,NULL),(1,6,200,180,NULL),(2,7,250,240,NULL),(2,8,500,480,NULL),(2,9,200,180,NULL),(2,10,200,190,NULL),(3,11,150,140,'Ưu tiên lô gần hết hạn.'),(3,15,100,90,NULL),(3,19,150,150,NULL),(3,20,100,90,NULL),(4,3,120,NULL,NULL),(4,23,100,NULL,NULL),(4,24,20,NULL,'Yêu cầu bảo quản lạnh khi vận chuyển.'),(4,25,80,NULL,NULL),(5,21,600,NULL,NULL),(5,22,400,NULL,NULL),(6,5,100,100,NULL),(6,13,20,18,NULL),(6,14,80,70,NULL),(6,16,100,90,NULL),(6,17,150,140,NULL);
/*!40000 ALTER TABLE `chitietphieuxincap` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `chitietphieuxuat`
--

DROP TABLE IF EXISTS `chitietphieuxuat`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `chitietphieuxuat` (
  `MaPhieuXuat` int NOT NULL,
  `MaLo` int NOT NULL,
  `SoLuong` int NOT NULL,
  `DonGiaBan` decimal(18,2) NOT NULL,
  `ThanhTien` decimal(18,2) NOT NULL,
  PRIMARY KEY (`MaPhieuXuat`,`MaLo`),
  KEY `IX_ChiTietPhieuXuat_MaLo` (`MaLo`),
  CONSTRAINT `FK_ChiTietPhieuXuat_LoThuoc_MaLo` FOREIGN KEY (`MaLo`) REFERENCES `lothuoc` (`MaLo`) ON DELETE RESTRICT,
  CONSTRAINT `FK_ChiTietPhieuXuat_PhieuXuatThuoc_MaPhieuXuat` FOREIGN KEY (`MaPhieuXuat`) REFERENCES `phieuxuatthuoc` (`MaPhieuXuat`) ON DELETE RESTRICT
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `chitietphieuxuat`
--

LOCK TABLES `chitietphieuxuat` WRITE;
/*!40000 ALTER TABLE `chitietphieuxuat` DISABLE KEYS */;
INSERT INTO `chitietphieuxuat` VALUES (1,11,30,900.00,27000.00),(1,13,30,1800.00,54000.00),(1,19,30,2500.00,75000.00),(2,1,8,1200.00,9600.00),(2,2,6,1200.00,7200.00),(2,3,21,2800.00,58800.00),(2,21,7,850.00,5950.00),(3,7,28,1800.00,50400.00),(3,39,14,5000.00,70000.00),(4,15,60,700.00,42000.00),(4,17,30,2300.00,69000.00),(4,19,30,2500.00,75000.00),(5,1,6,1200.00,7200.00),(5,37,10,3000.00,30000.00),(5,39,9,5000.00,45000.00),(6,23,10,1200.00,12000.00),(6,41,10,3500.00,35000.00),(7,1,6,1200.00,7200.00),(7,25,1,68000.00,68000.00),(7,31,3,9500.00,28500.00),(8,7,5,1800.00,9000.00),(8,33,15,1400.00,21000.00),(9,11,10,900.00,9000.00),(9,12,20,900.00,18000.00),(9,13,30,1800.00,54000.00),(9,19,30,2500.00,75000.00),(10,15,60,700.00,42000.00),(10,17,30,2300.00,69000.00),(10,19,30,2500.00,75000.00),(11,1,14,1200.00,16800.00),(11,5,8,14500.00,116000.00),(11,6,6,14500.00,87000.00),(11,21,7,850.00,5950.00),(12,1,10,1200.00,12000.00),(12,29,10,8500.00,85000.00),(12,51,1,17000.00,17000.00),(13,21,10,850.00,8500.00),(13,25,1,68000.00,68000.00),(13,27,4,14500.00,58000.00),(13,28,6,14500.00,87000.00),(14,1,10,1200.00,12000.00),(14,45,10,11000.00,110000.00);
/*!40000 ALTER TABLE `chitietphieuxuat` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `donthuoc`
--

DROP TABLE IF EXISTS `donthuoc`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `donthuoc` (
  `MaDonThuoc` int NOT NULL AUTO_INCREMENT,
  `MaBN` int NOT NULL,
  `BacSiId` int NOT NULL,
  `NgayKeDon` datetime(6) NOT NULL,
  `ChanDoan` varchar(255) NOT NULL,
  `TrangThai` varchar(50) NOT NULL,
  `GhiChu` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`MaDonThuoc`),
  KEY `IX_DonThuoc_BacSiId` (`BacSiId`),
  KEY `IX_DonThuoc_MaBN` (`MaBN`),
  CONSTRAINT `FK_DonThuoc_BenhNhan_MaBN` FOREIGN KEY (`MaBN`) REFERENCES `benhnhan` (`MaBN`) ON DELETE RESTRICT,
  CONSTRAINT `FK_DonThuoc_User_BacSiId` FOREIGN KEY (`BacSiId`) REFERENCES `user` (`UserId`) ON DELETE RESTRICT
) ENGINE=InnoDB AUTO_INCREMENT=21 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `donthuoc`
--

LOCK TABLES `donthuoc` WRITE;
/*!40000 ALTER TABLE `donthuoc` DISABLE KEYS */;
INSERT INTO `donthuoc` VALUES (1,1,2,'2026-06-15 08:30:00.000000','Tăng huyết áp nguyên phát, rối loạn lipid máu','DA_XUAT_THUOC','Tái khám sau 30 ngày, theo dõi huyết áp tại nhà.'),(2,2,2,'2026-06-18 09:20:00.000000','Viêm họng cấp do vi khuẩn','DA_XUAT_THUOC','Uống đủ liệu trình kháng sinh.'),(3,3,2,'2026-06-22 14:05:00.000000','Viêm dạ dày, trào ngược dạ dày thực quản','DA_XUAT_THUOC','Hạn chế cà phê, thức ăn cay và ăn khuya.'),(4,4,2,'2026-06-25 08:10:00.000000','Đái tháo đường típ 2','DA_XUAT_THUOC','Theo dõi đường huyết và tái khám sau 1 tháng.'),(5,5,2,'2026-06-29 14:35:00.000000','Tiêu chảy cấp chưa mất nước','DA_XUAT_THUOC','Bù nước thường xuyên, tái khám nếu sốt cao.'),(6,6,2,'2026-07-02 09:05:00.000000','Viêm mũi dị ứng','DA_XUAT_THUOC','Tránh tiếp xúc bụi và các dị nguyên đã biết.'),(7,7,2,'2026-07-05 10:40:00.000000','Viêm đường hô hấp dưới kèm co thắt phế quản','DA_XUAT_THUOC','Hướng dẫn kỹ cách dùng bình xịt.'),(8,8,2,'2026-07-08 15:30:00.000000','Đau cơ xương khớp vùng thắt lưng','DA_XUAT_THUOC','Uống thuốc giảm đau sau ăn.'),(9,9,2,'2026-07-10 08:15:00.000000','Tăng huyết áp kèm rối loạn lipid máu','DA_XUAT_THUOC',NULL),(10,10,2,'2026-07-12 09:40:00.000000','Đái tháo đường típ 2, rối loạn lipid máu','DA_XUAT_THUOC','Duy trì chế độ ăn hạn chế đường và tinh bột nhanh.'),(11,11,2,'2026-07-14 14:10:00.000000','Viêm xoang cấp do vi khuẩn','DA_XUAT_THUOC','Tái khám nếu triệu chứng không giảm sau 3 ngày.'),(12,12,2,'2026-07-16 09:00:00.000000','Nhiễm khuẩn da mức độ nhẹ','DA_XUAT_THUOC','Giữ vùng tổn thương sạch và khô.'),(13,13,2,'2026-07-18 10:25:00.000000','Hen phế quản, đợt cấp nhẹ','DA_XUAT_THUOC','Nếu khó thở tăng phải đến cơ sở y tế ngay.'),(14,14,2,'2026-07-20 14:45:00.000000','Nhiễm khuẩn đường tiết niệu không biến chứng','DA_XUAT_THUOC','Uống nhiều nước và dùng đủ kháng sinh.'),(15,15,2,'2026-07-21 08:20:00.000000','Thoái hóa khớp gối','CHO_XUAT_THUOC','Đơn giấy đã chuyển cho bệnh nhân.'),(16,16,2,'2026-07-21 14:15:00.000000','Nhiễm siêu vi đường hô hấp trên','CHO_XUAT_THUOC',NULL),(17,17,2,'2026-07-22 09:30:00.000000','Đái tháo đường típ 2 đang điều trị insulin','CHO_XUAT_THUOC','Bảo quản insulin ở 2-8 độ C.'),(18,18,2,'2026-07-22 15:10:00.000000','Viêm phổi cộng đồng mức độ nhẹ','CHO_XUAT_THUOC','Tái khám sau 48-72 giờ.'),(19,19,2,'2026-07-23 10:05:00.000000','Viêm amidan cấp','NHAP','Bác sĩ đang hoàn thiện đơn.'),(20,20,2,'2026-07-23 16:40:00.000000','Nhiễm khuẩn đường tiết niệu','DA_HUY','Hủy do bệnh nhân được chuyển điều trị nội trú.');
/*!40000 ALTER TABLE `donthuoc` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `hoadon`
--

DROP TABLE IF EXISTS `hoadon`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `hoadon` (
  `MaHD` int NOT NULL AUTO_INCREMENT,
  `MaPhieuXuat` int NOT NULL,
  `TongTienThuoc` decimal(18,2) NOT NULL,
  `TienThuocDuocBHYT` decimal(18,2) NOT NULL,
  `TyLeBHYTApDung` int NOT NULL,
  `TienBHYTThanhToan` decimal(18,2) NOT NULL,
  `TienBenhNhanTra` decimal(18,2) NOT NULL,
  `PhuongThucThanhToan` varchar(50) NOT NULL,
  `NoiDungChuyenKhoan` varchar(255) DEFAULT NULL,
  `MaGiaoDich` varchar(100) DEFAULT NULL,
  `ThoiGianThanhToan` datetime(6) NOT NULL,
  PRIMARY KEY (`MaHD`),
  UNIQUE KEY `IX_HoaDon_MaPhieuXuat` (`MaPhieuXuat`),
  UNIQUE KEY `IX_HoaDon_MaGiaoDich` (`MaGiaoDich`),
  CONSTRAINT `FK_HoaDon_PhieuXuatThuoc_MaPhieuXuat` FOREIGN KEY (`MaPhieuXuat`) REFERENCES `phieuxuatthuoc` (`MaPhieuXuat`) ON DELETE RESTRICT
) ENGINE=InnoDB AUTO_INCREMENT=16 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `hoadon`
--

LOCK TABLES `hoadon` WRITE;
/*!40000 ALTER TABLE `hoadon` DISABLE KEYS */;
INSERT INTO `hoadon` VALUES (1,1,156000.00,156000.00,80,124800.00,31200.00,'TIEN_MAT',NULL,NULL,'2026-06-15 09:15:00.000000'),(2,2,81550.00,81550.00,80,65240.00,16310.00,'CHUYEN_KHOAN','THANH TOAN THUOC PX2','GD-SEED-2','2026-06-18 10:15:00.000000'),(3,3,120400.00,50400.00,95,47880.00,72520.00,'TIEN_MAT',NULL,NULL,'2026-06-22 14:50:00.000000'),(4,4,186000.00,186000.00,100,186000.00,0.00,'CHUYEN_KHOAN','THANH TOAN THUOC PX4','GD-SEED-4','2026-06-25 09:00:00.000000'),(5,5,82200.00,37200.00,0,0.00,82200.00,'TIEN_MAT',NULL,NULL,'2026-06-29 15:20:00.000000'),(6,6,47000.00,0.00,80,0.00,47000.00,'CHUYEN_KHOAN','THANH TOAN THUOC PX6','GD-SEED-6','2026-07-02 09:55:00.000000'),(7,7,103700.00,103700.00,0,0.00,103700.00,'TIEN_MAT',NULL,NULL,'2026-07-05 11:30:00.000000'),(8,8,30000.00,30000.00,95,28500.00,1500.00,'CHUYEN_KHOAN','THANH TOAN THUOC PX8','GD-SEED-8','2026-07-08 16:15:00.000000'),(9,9,156000.00,156000.00,80,124800.00,31200.00,'TIEN_MAT',NULL,NULL,'2026-07-10 09:00:00.000000'),(10,10,186000.00,186000.00,80,148800.00,37200.00,'CHUYEN_KHOAN','THANH TOAN THUOC PX10','GD-SEED-10','2026-07-12 10:25:00.000000'),(11,11,225750.00,225750.00,100,225750.00,0.00,'TIEN_MAT',NULL,NULL,'2026-07-14 15:00:00.000000'),(12,12,114000.00,97000.00,0,0.00,114000.00,'CHUYEN_KHOAN','THANH TOAN THUOC PX12','GD-SEED-12','2026-07-16 09:45:00.000000'),(13,13,221500.00,221500.00,80,177200.00,44300.00,'TIEN_MAT',NULL,NULL,'2026-07-18 11:10:00.000000'),(14,14,122000.00,122000.00,95,115900.00,6100.00,'CHUYEN_KHOAN','THANH TOAN THUOC PX14','GD-SEED-14','2026-07-20 15:30:00.000000');
/*!40000 ALTER TABLE `hoadon` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `kho`
--

DROP TABLE IF EXISTS `kho`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `kho` (
  `MaKho` int NOT NULL AUTO_INCREMENT,
  `TenKho` varchar(100) NOT NULL,
  `LoaiKho` varchar(50) NOT NULL,
  PRIMARY KEY (`MaKho`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `kho`
--

LOCK TABLES `kho` WRITE;
/*!40000 ALTER TABLE `kho` DISABLE KEYS */;
INSERT INTO `kho` VALUES (1,'Kho tổng','KHO_TONG'),(2,'Kho quầy','KHO_QUAY');
/*!40000 ALTER TABLE `kho` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `lothuoc`
--

DROP TABLE IF EXISTS `lothuoc`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `lothuoc` (
  `MaLo` int NOT NULL AUTO_INCREMENT,
  `MaThuoc` int NOT NULL,
  `SoLo` varchar(100) NOT NULL,
  `NgaySanXuat` datetime(6) DEFAULT NULL,
  `NgayHetHan` datetime(6) NOT NULL,
  PRIMARY KEY (`MaLo`),
  UNIQUE KEY `IX_LoThuoc_MaThuoc_SoLo` (`MaThuoc`,`SoLo`),
  CONSTRAINT `FK_LoThuoc_Thuoc_MaThuoc` FOREIGN KEY (`MaThuoc`) REFERENCES `thuoc` (`MaThuoc`) ON DELETE RESTRICT
) ENGINE=InnoDB AUTO_INCREMENT=53 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `lothuoc`
--

LOCK TABLES `lothuoc` WRITE;
/*!40000 ALTER TABLE `lothuoc` DISABLE KEYS */;
INSERT INTO `lothuoc` VALUES (1,1,'PCM-2501','2025-01-15 00:00:00.000000','2026-09-30 00:00:00.000000'),(2,1,'PCM-2604','2026-04-10 00:00:00.000000','2028-04-30 00:00:00.000000'),(3,2,'AMX-2508','2025-08-05 00:00:00.000000','2026-12-31 00:00:00.000000'),(4,2,'AMX-2602','2026-02-12 00:00:00.000000','2028-02-29 00:00:00.000000'),(5,3,'AMC-2506','2025-06-20 00:00:00.000000','2027-06-30 00:00:00.000000'),(6,3,'AMC-2603','2026-03-08 00:00:00.000000','2028-03-31 00:00:00.000000'),(7,4,'OME-2504','2025-04-17 00:00:00.000000','2027-04-30 00:00:00.000000'),(8,4,'OME-2601','2026-01-09 00:00:00.000000','2028-01-31 00:00:00.000000'),(9,5,'PAN-2507','2025-07-11 00:00:00.000000','2027-07-31 00:00:00.000000'),(10,5,'PAN-2602','2026-02-18 00:00:00.000000','2028-02-29 00:00:00.000000'),(11,6,'AML-2503','2025-03-25 00:00:00.000000','2026-10-31 00:00:00.000000'),(12,6,'AML-2603','2026-03-14 00:00:00.000000','2028-03-31 00:00:00.000000'),(13,7,'LOS-2505','2025-05-06 00:00:00.000000','2027-05-31 00:00:00.000000'),(14,7,'LOS-2601','2026-01-21 00:00:00.000000','2028-01-31 00:00:00.000000'),(15,8,'MET-2502','2025-02-13 00:00:00.000000','2027-02-28 00:00:00.000000'),(16,8,'MET-2602','2026-02-06 00:00:00.000000','2028-02-29 00:00:00.000000'),(17,9,'GLC-2506','2025-06-09 00:00:00.000000','2027-06-30 00:00:00.000000'),(18,9,'GLC-2601','2026-01-16 00:00:00.000000','2028-01-31 00:00:00.000000'),(19,10,'ATV-2504','2025-04-07 00:00:00.000000','2027-04-30 00:00:00.000000'),(20,10,'ATV-2602','2026-02-23 00:00:00.000000','2028-02-29 00:00:00.000000'),(21,11,'CTZ-2501','2025-01-30 00:00:00.000000','2026-08-31 00:00:00.000000'),(22,11,'CTZ-2604','2026-04-03 00:00:00.000000','2028-04-30 00:00:00.000000'),(23,12,'LOR-2507','2025-07-19 00:00:00.000000','2027-07-31 00:00:00.000000'),(24,12,'LOR-2601','2026-01-27 00:00:00.000000','2028-01-31 00:00:00.000000'),(25,13,'SAL-2505','2025-05-15 00:00:00.000000','2027-05-31 00:00:00.000000'),(26,13,'SAL-2602','2026-02-20 00:00:00.000000','2028-02-29 00:00:00.000000'),(27,14,'BUD-2508','2025-08-24 00:00:00.000000','2026-11-30 00:00:00.000000'),(28,14,'BUD-2603','2026-03-12 00:00:00.000000','2028-03-31 00:00:00.000000'),(29,15,'CFX-2506','2025-06-28 00:00:00.000000','2027-06-30 00:00:00.000000'),(30,15,'CFX-2602','2026-02-09 00:00:00.000000','2028-02-29 00:00:00.000000'),(31,16,'AZI-2509','2025-09-05 00:00:00.000000','2027-09-30 00:00:00.000000'),(32,16,'AZI-2603','2026-03-20 00:00:00.000000','2028-03-31 00:00:00.000000'),(33,17,'IBU-2503','2025-03-04 00:00:00.000000','2027-03-31 00:00:00.000000'),(34,17,'IBU-2601','2026-01-11 00:00:00.000000','2028-01-31 00:00:00.000000'),(35,18,'DCF-2502','2025-02-08 00:00:00.000000','2026-08-15 00:00:00.000000'),(36,18,'DCF-2601','2026-01-05 00:00:00.000000','2028-01-31 00:00:00.000000'),(37,19,'ORS-2509','2025-09-17 00:00:00.000000','2026-12-31 00:00:00.000000'),(38,19,'ORS-2604','2026-04-22 00:00:00.000000','2027-10-31 00:00:00.000000'),(39,20,'DSM-2506','2025-06-16 00:00:00.000000','2027-06-30 00:00:00.000000'),(40,20,'DSM-2602','2026-02-14 00:00:00.000000','2028-02-29 00:00:00.000000'),(41,21,'VTC-2505','2025-05-10 00:00:00.000000','2027-05-31 00:00:00.000000'),(42,21,'VTC-2603','2026-03-19 00:00:00.000000','2028-03-31 00:00:00.000000'),(43,22,'CAD-2504','2025-04-13 00:00:00.000000','2027-04-30 00:00:00.000000'),(44,22,'CAD-2602','2026-02-25 00:00:00.000000','2028-02-29 00:00:00.000000'),(45,23,'CFM-2507','2025-07-02 00:00:00.000000','2027-07-31 00:00:00.000000'),(46,23,'CFM-2603','2026-03-27 00:00:00.000000','2028-03-31 00:00:00.000000'),(47,24,'INS-2509','2025-09-12 00:00:00.000000','2026-09-15 00:00:00.000000'),(48,24,'INS-2605','2026-05-06 00:00:00.000000','2027-05-31 00:00:00.000000'),(49,25,'NCL-2508','2025-08-18 00:00:00.000000','2027-08-31 00:00:00.000000'),(50,25,'NCL-2604','2026-04-15 00:00:00.000000','2028-04-30 00:00:00.000000'),(51,26,'PVI-2505','2025-05-29 00:00:00.000000','2027-05-31 00:00:00.000000'),(52,26,'PVI-2601','2026-01-18 00:00:00.000000','2028-01-31 00:00:00.000000');
/*!40000 ALTER TABLE `lothuoc` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `phieuxincapthuoc`
--

DROP TABLE IF EXISTS `phieuxincapthuoc`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `phieuxincapthuoc` (
  `MaPhieu` int NOT NULL AUTO_INCREMENT,
  `KhoCapId` int NOT NULL,
  `KhoNhanId` int NOT NULL,
  `NguoiLapId` int NOT NULL,
  `NguoiDuyetId` int DEFAULT NULL,
  `NgayLap` datetime(6) NOT NULL,
  `NgayDuyet` datetime(6) DEFAULT NULL,
  `LyDo` varchar(255) NOT NULL,
  `GhiChuDuyet` varchar(255) DEFAULT NULL,
  `TrangThai` varchar(50) NOT NULL,
  PRIMARY KEY (`MaPhieu`),
  KEY `IX_PhieuXinCapThuoc_KhoCapId` (`KhoCapId`),
  KEY `IX_PhieuXinCapThuoc_KhoNhanId` (`KhoNhanId`),
  KEY `IX_PhieuXinCapThuoc_NguoiDuyetId` (`NguoiDuyetId`),
  KEY `IX_PhieuXinCapThuoc_NguoiLapId` (`NguoiLapId`),
  CONSTRAINT `FK_PhieuXinCapThuoc_Kho_KhoCapId` FOREIGN KEY (`KhoCapId`) REFERENCES `kho` (`MaKho`) ON DELETE RESTRICT,
  CONSTRAINT `FK_PhieuXinCapThuoc_Kho_KhoNhanId` FOREIGN KEY (`KhoNhanId`) REFERENCES `kho` (`MaKho`) ON DELETE RESTRICT,
  CONSTRAINT `FK_PhieuXinCapThuoc_User_NguoiDuyetId` FOREIGN KEY (`NguoiDuyetId`) REFERENCES `user` (`UserId`) ON DELETE RESTRICT,
  CONSTRAINT `FK_PhieuXinCapThuoc_User_NguoiLapId` FOREIGN KEY (`NguoiLapId`) REFERENCES `user` (`UserId`) ON DELETE RESTRICT
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `phieuxincapthuoc`
--

LOCK TABLES `phieuxincapthuoc` WRITE;
/*!40000 ALTER TABLE `phieuxincapthuoc` DISABLE KEYS */;
INSERT INTO `phieuxincapthuoc` VALUES (1,1,2,4,11,'2026-06-05 08:15:00.000000','2026-06-05 14:20:00.000000','Bổ sung thuốc thiết yếu phục vụ cấp phát đầu tháng.','Ưu tiên xuất các lô gần hết hạn trước.','DA_DUYET'),(2,1,2,4,11,'2026-06-20 09:05:00.000000','2026-06-20 15:10:00.000000','Bổ sung nhóm thuốc tim mạch và đái tháo đường.','Đã đối chiếu tồn kho thực tế.','DA_DUYET'),(3,1,2,4,11,'2026-07-05 10:30:00.000000','2026-07-06 08:40:00.000000','Tồn kho quầy của một số thuốc điều trị cấp tính xuống thấp.',NULL,'DA_DUYET'),(4,1,2,4,NULL,'2026-07-22 08:45:00.000000',NULL,'Bổ sung thuốc kháng sinh, dịch truyền và insulin cho tuần cuối tháng.',NULL,'CHO_DUYET'),(5,1,2,4,11,'2026-07-10 13:20:00.000000','2026-07-10 16:05:00.000000','Xin bổ sung số lượng lớn vitamin và thuốc bổ.','Số lượng yêu cầu vượt mức sử dụng; đề nghị lập lại phiếu.','DA_TU_CHOI'),(6,1,2,4,11,'2026-07-15 09:10:00.000000','2026-07-15 14:30:00.000000','Bổ sung thuốc hô hấp, kháng sinh và giảm đau.','Đã duyệt theo tồn kho thực tế.','DA_DUYET');
/*!40000 ALTER TABLE `phieuxincapthuoc` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `phieuxuatthuoc`
--

DROP TABLE IF EXISTS `phieuxuatthuoc`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `phieuxuatthuoc` (
  `MaPhieuXuat` int NOT NULL AUTO_INCREMENT,
  `MaDonThuoc` int NOT NULL,
  `MaKho` int NOT NULL,
  `DuocSiId` int NOT NULL,
  `NgayXuat` datetime(6) NOT NULL,
  PRIMARY KEY (`MaPhieuXuat`),
  UNIQUE KEY `IX_PhieuXuatThuoc_MaDonThuoc` (`MaDonThuoc`),
  KEY `IX_PhieuXuatThuoc_DuocSiId` (`DuocSiId`),
  KEY `IX_PhieuXuatThuoc_MaKho` (`MaKho`),
  CONSTRAINT `FK_PhieuXuatThuoc_DonThuoc_MaDonThuoc` FOREIGN KEY (`MaDonThuoc`) REFERENCES `donthuoc` (`MaDonThuoc`) ON DELETE RESTRICT,
  CONSTRAINT `FK_PhieuXuatThuoc_Kho_MaKho` FOREIGN KEY (`MaKho`) REFERENCES `kho` (`MaKho`) ON DELETE RESTRICT,
  CONSTRAINT `FK_PhieuXuatThuoc_User_DuocSiId` FOREIGN KEY (`DuocSiId`) REFERENCES `user` (`UserId`) ON DELETE RESTRICT
) ENGINE=InnoDB AUTO_INCREMENT=15 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `phieuxuatthuoc`
--

LOCK TABLES `phieuxuatthuoc` WRITE;
/*!40000 ALTER TABLE `phieuxuatthuoc` DISABLE KEYS */;
INSERT INTO `phieuxuatthuoc` VALUES (1,1,2,4,'2026-06-15 09:05:00.000000'),(2,2,2,4,'2026-06-18 10:05:00.000000'),(3,3,2,4,'2026-06-22 14:40:00.000000'),(4,4,2,4,'2026-06-25 08:50:00.000000'),(5,5,2,4,'2026-06-29 15:10:00.000000'),(6,6,2,4,'2026-07-02 09:45:00.000000'),(7,7,2,4,'2026-07-05 11:20:00.000000'),(8,8,2,4,'2026-07-08 16:05:00.000000'),(9,9,2,4,'2026-07-10 08:50:00.000000'),(10,10,2,4,'2026-07-12 10:15:00.000000'),(11,11,2,4,'2026-07-14 14:50:00.000000'),(12,12,2,4,'2026-07-16 09:35:00.000000'),(13,13,2,4,'2026-07-18 11:00:00.000000'),(14,14,2,4,'2026-07-20 15:20:00.000000');
/*!40000 ALTER TABLE `phieuxuatthuoc` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `thuoc`
--

DROP TABLE IF EXISTS `thuoc`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `thuoc` (
  `MaThuoc` int NOT NULL AUTO_INCREMENT,
  `TenThuoc` varchar(100) NOT NULL,
  `DonViTinh` varchar(50) NOT NULL,
  `HoatChat` varchar(100) NOT NULL,
  `HamLuong` varchar(50) NOT NULL,
  `DonGiaBan` decimal(18,2) NOT NULL,
  `DuocBHYTChiTra` tinyint(1) NOT NULL,
  `TrangThai` varchar(50) NOT NULL,
  PRIMARY KEY (`MaThuoc`)
) ENGINE=InnoDB AUTO_INCREMENT=27 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `thuoc`
--

LOCK TABLES `thuoc` WRITE;
/*!40000 ALTER TABLE `thuoc` DISABLE KEYS */;
INSERT INTO `thuoc` VALUES (1,'Paracetamol 500 mg','Viên','Paracetamol','500 mg',1200.00,1,'DANG_KINH_DOANH'),(2,'Amoxicillin 500 mg','Viên nang','Amoxicillin','500 mg',2800.00,1,'DANG_KINH_DOANH'),(3,'Amoxicillin/Clavulanate 875/125 mg','Viên','Amoxicillin + Acid clavulanic','875 mg/125 mg',14500.00,1,'DANG_KINH_DOANH'),(4,'Omeprazole 20 mg','Viên nang','Omeprazole','20 mg',1800.00,1,'DANG_KINH_DOANH'),(5,'Pantoprazole 40 mg','Viên','Pantoprazole','40 mg',3200.00,1,'DANG_KINH_DOANH'),(6,'Amlodipine 5 mg','Viên','Amlodipine','5 mg',900.00,1,'DANG_KINH_DOANH'),(7,'Losartan 50 mg','Viên','Losartan potassium','50 mg',1800.00,1,'DANG_KINH_DOANH'),(8,'Metformin 500 mg','Viên','Metformin hydrochloride','500 mg',700.00,1,'DANG_KINH_DOANH'),(9,'Gliclazide MR 30 mg','Viên giải phóng chậm','Gliclazide','30 mg',2300.00,1,'DANG_KINH_DOANH'),(10,'Atorvastatin 20 mg','Viên','Atorvastatin','20 mg',2500.00,1,'DANG_KINH_DOANH'),(11,'Cetirizine 10 mg','Viên','Cetirizine dihydrochloride','10 mg',850.00,1,'DANG_KINH_DOANH'),(12,'Loratadine 10 mg','Viên','Loratadine','10 mg',1200.00,0,'DANG_KINH_DOANH'),(13,'Salbutamol 100 mcg/liều','Bình xịt','Salbutamol','100 mcg/liều',68000.00,1,'DANG_KINH_DOANH'),(14,'Budesonide khí dung 0,5 mg/2 ml','Ống','Budesonide','0,5 mg/2 ml',14500.00,1,'DANG_KINH_DOANH'),(15,'Cefuroxime 500 mg','Viên','Cefuroxime axetil','500 mg',8500.00,1,'DANG_KINH_DOANH'),(16,'Azithromycin 500 mg','Viên','Azithromycin','500 mg',9500.00,1,'DANG_KINH_DOANH'),(17,'Ibuprofen 400 mg','Viên','Ibuprofen','400 mg',1400.00,1,'DANG_KINH_DOANH'),(18,'Diclofenac 50 mg','Viên','Diclofenac sodium','50 mg',1000.00,1,'TAM_NGUNG'),(19,'Oresol áp lực thẩm thấu thấp','Gói','Glucose + Natri clorid + Kali clorid + Natri citrat','27,9 g',3000.00,1,'DANG_KINH_DOANH'),(20,'Diosmectite 3 g','Gói','Diosmectite','3 g',5000.00,0,'DANG_KINH_DOANH'),(21,'Vitamin C 500 mg','Viên sủi','Ascorbic acid','500 mg',3500.00,0,'DANG_KINH_DOANH'),(22,'Calcium 600 mg + Vitamin D3','Viên','Calcium carbonate + Cholecalciferol','600 mg/400 IU',2800.00,0,'DANG_KINH_DOANH'),(23,'Cefixime 200 mg','Viên nang','Cefixime','200 mg',11000.00,1,'DANG_KINH_DOANH'),(24,'Insulin human 30/70','Lọ','Insulin human biphasic','100 IU/ml - 10 ml',125000.00,1,'DANG_KINH_DOANH'),(25,'Natri clorid 0,9% 500 ml','Chai','Sodium chloride','0,9% - 500 ml',12000.00,1,'DANG_KINH_DOANH'),(26,'Povidone iod 10% 90 ml','Chai','Povidone iodine','10% - 90 ml',17000.00,0,'DANG_KINH_DOANH');
/*!40000 ALTER TABLE `thuoc` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tonkho`
--

DROP TABLE IF EXISTS `tonkho`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tonkho` (
  `MaKho` int NOT NULL,
  `MaLo` int NOT NULL,
  `SoLuongTon` int NOT NULL,
  PRIMARY KEY (`MaKho`,`MaLo`),
  KEY `IX_TonKho_MaLo` (`MaLo`),
  CONSTRAINT `FK_TonKho_Kho_MaKho` FOREIGN KEY (`MaKho`) REFERENCES `kho` (`MaKho`) ON DELETE RESTRICT,
  CONSTRAINT `FK_TonKho_LoThuoc_MaLo` FOREIGN KEY (`MaLo`) REFERENCES `lothuoc` (`MaLo`) ON DELETE RESTRICT
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tonkho`
--

LOCK TABLES `tonkho` WRITE;
/*!40000 ALTER TABLE `tonkho` DISABLE KEYS */;
INSERT INTO `tonkho` VALUES (1,1,300),(1,2,2400),(1,3,450),(1,4,1600),(1,5,300),(1,6,900),(1,7,500),(1,8,1300),(1,9,350),(1,10,900),(1,11,250),(1,12,1400),(1,13,400),(1,14,1400),(1,15,800),(1,16,2600),(1,17,500),(1,18,1600),(1,19,450),(1,20,1500),(1,21,120),(1,22,1000),(1,23,400),(1,24,900),(1,25,25),(1,26,90),(1,27,120),(1,28,400),(1,29,350),(1,30,1000),(1,31,300),(1,32,900),(1,33,500),(1,34,1300),(1,35,0),(1,36,650),(1,37,500),(1,38,1400),(1,39,350),(1,40,900),(1,41,600),(1,42,1200),(1,43,500),(1,44,900),(1,45,320),(1,46,900),(1,47,12),(1,48,90),(1,49,180),(1,50,600),(1,51,100),(1,52,300),(2,1,90),(2,2,650),(2,3,120),(2,4,420),(2,5,50),(2,6,100),(2,7,180),(2,8,300),(2,9,70),(2,10,130),(2,11,60),(2,12,360),(2,13,120),(2,14,320),(2,15,300),(2,16,700),(2,17,120),(2,18,300),(2,19,100),(2,20,280),(2,21,35),(2,22,250),(2,23,80),(2,24,180),(2,25,6),(2,26,16),(2,27,20),(2,28,70),(2,29,70),(2,30,180),(2,31,60),(2,32,140),(2,33,100),(2,34,250),(2,35,0),(2,36,120),(2,37,160),(2,38,320),(2,39,90),(2,40,200),(2,41,120),(2,42,240),(2,43,100),(2,44,180),(2,45,60),(2,46,140),(2,47,4),(2,48,12),(2,49,40),(2,50,120),(2,51,20),(2,52,60);
/*!40000 ALTER TABLE `tonkho` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `user`
--

DROP TABLE IF EXISTS `user`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `user` (
  `UserId` int NOT NULL AUTO_INCREMENT,
  `FullName` varchar(100) NOT NULL,
  `PhoneNumber` varchar(20) NOT NULL,
  `Email` varchar(100) NOT NULL,
  `PasswordHash` varchar(255) NOT NULL,
  `Role` varchar(50) NOT NULL,
  `IsActive` tinyint(1) NOT NULL,
  PRIMARY KEY (`UserId`),
  UNIQUE KEY `IX_User_Email` (`Email`),
  UNIQUE KEY `IX_User_PhoneNumber` (`PhoneNumber`)
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `user`
--

LOCK TABLES `user` WRITE;
/*!40000 ALTER TABLE `user` DISABLE KEYS */;
INSERT INTO `user` VALUES (1,'Quản trị viên','0000000000','admin@gmail.com','AQAAAAEAAYagAAAAEAoi8S+gZ0EPMOKWIBoNTKwyLG/nnw896ohJOJu9e08MOxZeFhPyujJBQkB85AfiZw==','ADMIN',1),(2,'Ngô Văn Dũng','098278323','ngodung@gmail.com','AQAAAAEAACcQAAAAEIkzJCCt8ak2quibH6rzRgVugPxTy2Bq9iL1hgDt6cVyt6Vxi0TOEdA6EyiNiP3PwQ==','BAC_SI',1),(3,'Phạm Thị Lan','0887364663','lanlan@gmail.com','AQAAAAEAACcQAAAAEI8fzI6Yfv/gFGBVklJHzCpBO9H1ZwgTcDQ8P5UdU/edsXlqJvC2RlKWgLhc2Qvo9A==','BAC_SI',1),(4,'Phạm Kiều Oanh','0343494885','kieuoanh@gmail.com','AQAAAAEAACcQAAAAEK9jGBnd9GTgJpu/Sh2WjL82+x93JDK6RjPuSplczETEzWMmNTR7wJG9gUeK2TIK1A==','DUOC_SI',1),(5,'Trần Thị Hồng','0776383275','hongtran@gmail.com','AQAAAAEAACcQAAAAEEDRV6Rf8Lq/9hXgxqfGA+LurREcyQp0Tqs5gma+B67Lj8U+2fBd0wlfVwLLnqbo5w==','DUOC_SI',1),(6,'Lê Minh Quân','0767635643','quanle@gmail.com','AQAAAAEAACcQAAAAEFlapDlpCxC0NHZV6JE8XKpsTcS3MR4fhoeq+2N825MaxKpnTSmR/+9UYmLWi6eyWg==','BAC_SI',1),(7,'Phạm Anh Tú','0983874557','anhtu@gmail.com','AQAAAAEAACcQAAAAEAq685VlMcOThHkdpKWqGNlh03suBb/u09duNXE2+CUtBYhcByUOoCYl/Vaz5wVm4g==','BAC_SI',1),(8,'Phạm Thu Hoài','0339488485','thuhoai@gmail.com','AQAAAAEAACcQAAAAEHMX0H7sHOvEcuI2u2toeZrGQk1FFtsR6sW05Veauv4GdgrD0S74Zwzu5mxdyDpPEw==','DUOC_SI',1),(9,'Phạm Thị Thanh Nhàn','0344995772','nhan@gmail.com','AQAAAAEAACcQAAAAEH8HktznHq5jmOc0y1ptuefmnKKU9DsKdr5f9ocjX0b0fGfl+dwuKtrDqVs5yyOD6w==','KE_TOAN',1),(10,'Phạm Phương Lan','0993441193','phuonglan@gmail.com','AQAAAAEAACcQAAAAEP8ZrVUGPlhHBXGIm4I3opXkTRBgadmNLpJ+bzZ0+HMMxFjlrXoCW63NGtWuOoMntg==','KE_TOAN',1),(11,'Nguyễn Văn Bình','0355693444','vanbinh@gmail.com','AQAAAAEAACcQAAAAEF+YWcgDw+0elbsvaDeDf14y50xLealpNRT5dAUG0XPSoTWRh00g6a2t8ZYELxbYqw==','KHO_TONG',1),(12,'Phạm Bích Ngọc','0346883474','bichngoc@gmail.com','AQAAAAEAACcQAAAAEEeJ4t86ptcElJ2AaVJrDxTbNggYfi26zB1XLuYI5eSkFDX4Tf+jg0qF1xHfggNv0g==','KHO_TONG',1);
/*!40000 ALTER TABLE `user` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2026-07-24 21:43:11
