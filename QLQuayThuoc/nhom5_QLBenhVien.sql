CREATE DATABASE  IF NOT EXISTS `wzbngkn_QLQuayThuoc` /*!40100 DEFAULT CHARACTER SET latin1 COLLATE latin1_swedish_ci */;
USE `wzbngkn_QLQuayThuoc`;
-- MySQL dump 10.13  Distrib 8.0.46, for Win64 (x86_64)
--
-- Host: 103.179.188.241    Database: wzbngkn_QLQuayThuoc
-- ------------------------------------------------------
-- Server version	5.5.5-10.6.23-MariaDB-cll-lve-log

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
-- Table structure for table `BenhNhan`
--

DROP TABLE IF EXISTS `BenhNhan`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `BenhNhan` (
  `MaBN` int(11) NOT NULL AUTO_INCREMENT,
  `HoTen` varchar(100) NOT NULL,
  `NgaySinh` datetime(6) NOT NULL,
  `GioiTinh` tinyint(1) NOT NULL,
  `DiaChi` varchar(255) NOT NULL,
  `SoDienThoai` varchar(20) NOT NULL,
  `MaBHYT` varchar(20) DEFAULT NULL,
  `MucHuongBHYT` int(11) NOT NULL,
  `NgayHetHanBHYT` datetime(6) DEFAULT NULL,
  PRIMARY KEY (`MaBN`)
) ENGINE=InnoDB AUTO_INCREMENT=21 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `BenhNhan`
--

LOCK TABLES `BenhNhan` WRITE;
/*!40000 ALTER TABLE `BenhNhan` DISABLE KEYS */;
INSERT INTO `BenhNhan` VALUES (1,'Nguyễn Văn An','1985-03-12 00:00:00.000000',1,'12 Nguyễn Trãi, Thanh Xuân, Hà Nội','0903123456','DN4010123456789',80,'2027-12-31 00:00:00.000000'),(2,'Trần Thị Mai','1992-08-21 00:00:00.000000',0,'45 Lê Lợi, Hải Châu, Đà Nẵng','0912234567','DN4010234567890',80,'2027-08-31 00:00:00.000000'),(3,'Lê Hoàng Nam','1958-11-05 00:00:00.000000',1,'78 Trần Hưng Đạo, Hoàn Kiếm, Hà Nội','0983345678','HT3010345678901',95,'2028-01-31 00:00:00.000000'),(4,'Phạm Thu Hà','2016-06-18 00:00:00.000000',0,'25 Nguyễn Văn Linh, Long Biên, Hà Nội','0934456789','TE1010456789012',100,'2027-06-30 00:00:00.000000'),(5,'Hoàng Minh Đức','1977-01-27 00:00:00.000000',1,'16 Võ Văn Tần, Quận 3, TP. Hồ Chí Minh','0975567890',NULL,0,NULL),(6,'Vũ Thị Lan','1966-09-14 00:00:00.000000',0,'102 Điện Biên Phủ, Ba Đình, Hà Nội','0966678901','DN4010678901234',80,'2027-09-30 00:00:00.000000'),(7,'Đỗ Quốc Bảo','1989-04-03 00:00:00.000000',1,'33 Cách Mạng Tháng Tám, Ninh Kiều, Cần Thơ','0947789012','DN4010789012345',80,'2026-06-30 00:00:00.000000'),(8,'Bùi Thị Hương','1954-12-09 00:00:00.000000',0,'56 Quang Trung, Hà Đông, Hà Nội','0928890123','HT3010890123456',95,'2027-12-31 00:00:00.000000'),(9,'Nguyễn Gia Huy','2001-07-25 00:00:00.000000',1,'88 Phan Đình Phùng, Phú Nhuận, TP. Hồ Chí Minh','0909901234','SV4010901234567',80,'2027-09-30 00:00:00.000000'),(10,'Trương Ngọc Anh','1995-02-17 00:00:00.000000',0,'21 Hoàng Diệu, Hải Châu, Đà Nẵng','0911012345','DN4011012345678',80,'2028-02-29 00:00:00.000000'),(11,'Phan Văn Thành','1948-05-30 00:00:00.000000',1,'9 Lý Thường Kiệt, Huế, Thừa Thiên Huế','0982123456','CC1011123456789',100,'2027-05-31 00:00:00.000000'),(12,'Lý Thu Trang','1983-10-11 00:00:00.000000',0,'73 Nguyễn Huệ, Quy Nhơn, Bình Định','0973234567',NULL,0,NULL),(13,'Hồ Minh Khang','2012-03-22 00:00:00.000000',1,'40 Hai Bà Trưng, Vinh, Nghệ An','0964345678','HS4011345678901',80,'2027-03-31 00:00:00.000000'),(14,'Dương Thị Hoa','1960-08-06 00:00:00.000000',0,'15 Lê Duẩn, Buôn Ma Thuột, Đắk Lắk','0955456789','HT3011456789012',95,'2028-06-30 00:00:00.000000'),(15,'Võ Thanh Tùng','1972-06-19 00:00:00.000000',1,'62 Nguyễn Tất Thành, Pleiku, Gia Lai','0946567890','DN4011567890123',80,'2027-06-30 00:00:00.000000'),(16,'Đặng Mỹ Linh','1999-09-01 00:00:00.000000',0,'27 Trần Phú, Nha Trang, Khánh Hòa','0937678901',NULL,0,NULL),(17,'Nguyễn Đức Long','1950-01-15 00:00:00.000000',1,'19 Bạch Đằng, Hồng Bàng, Hải Phòng','0928789012','CC1011789012345',100,'2028-01-31 00:00:00.000000'),(18,'Trần Khánh Vy','1987-12-28 00:00:00.000000',0,'81 Nguyễn Văn Cừ, Ninh Kiều, Cần Thơ','0919890123','DN4011890123456',80,'2027-12-31 00:00:00.000000'),(19,'Lê Nhật Minh','2008-04-10 00:00:00.000000',1,'34 Lê Hồng Phong, Nam Định, Nam Định','0901901234','HS4011901234567',80,'2027-08-31 00:00:00.000000'),(20,'Phạm Ngọc Yến','1979-07-07 00:00:00.000000',0,'11 Hùng Vương, Việt Trì, Phú Thọ','0992012345','DN4012012345678',80,'2026-05-31 00:00:00.000000');
/*!40000 ALTER TABLE `BenhNhan` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `CauHinhThanhToan`
--

DROP TABLE IF EXISTS `CauHinhThanhToan`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `CauHinhThanhToan` (
  `MaCauHinh` tinyint(3) unsigned NOT NULL DEFAULT 1,
  `MatKhauApi` varchar(255) NOT NULL,
  `TokenApi` varchar(500) NOT NULL,
  `DuongDanApiGiaoDich` varchar(500) NOT NULL,
  `MaNganHang` varchar(20) NOT NULL,
  `SoTaiKhoan` varchar(50) NOT NULL,
  `TenChuTaiKhoan` varchar(150) NOT NULL,
  `DuongDanTaoQR` varchar(500) NOT NULL,
  `MaDinhDanhQR` varchar(100) NOT NULL,
  `TienToNoiDungChuyenKhoan` varchar(20) NOT NULL DEFAULT 'DT',
  `DangHoatDong` tinyint(1) NOT NULL DEFAULT 1,
  `NgayCapNhat` datetime NOT NULL DEFAULT current_timestamp() ON UPDATE current_timestamp(),
  PRIMARY KEY (`MaCauHinh`),
  CONSTRAINT `CK_CauHinhThanhToan_ChiMotDong` CHECK (`MaCauHinh` = 1)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `CauHinhThanhToan`
--

LOCK TABLES `CauHinhThanhToan` WRITE;
/*!40000 ALTER TABLE `CauHinhThanhToan` DISABLE KEYS */;
INSERT INTO `CauHinhThanhToan` VALUES (1,'1','TOKEN_API','https://api.sieuthicode.vn/historyapiacbv3','970416','SOTAIKHOAN','TEN CHU TAI KHOAN','https://api.vietqr.io/image','7oKN5WV','HD',1,'2026-08-06 07:22:51');
/*!40000 ALTER TABLE `CauHinhThanhToan` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ChiTietCapTheoLo`
--

DROP TABLE IF EXISTS `ChiTietCapTheoLo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `ChiTietCapTheoLo` (
  `MaPhieu` int(11) NOT NULL,
  `MaThuoc` int(11) NOT NULL,
  `MaLo` int(11) NOT NULL,
  `SoLuongCap` int(11) NOT NULL,
  PRIMARY KEY (`MaPhieu`,`MaThuoc`,`MaLo`),
  KEY `IX_ChiTietCapTheoLo_MaLo` (`MaLo`),
  CONSTRAINT `FK_ChiTietCapTheoLo_ChiTietPhieuXinCap_MaPhieu_MaThuoc` FOREIGN KEY (`MaPhieu`, `MaThuoc`) REFERENCES `ChiTietPhieuXinCap` (`MaPhieu`, `MaThuoc`),
  CONSTRAINT `FK_ChiTietCapTheoLo_LoThuoc_MaLo` FOREIGN KEY (`MaLo`) REFERENCES `LoThuoc` (`MaLo`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ChiTietCapTheoLo`
--

LOCK TABLES `ChiTietCapTheoLo` WRITE;
/*!40000 ALTER TABLE `ChiTietCapTheoLo` DISABLE KEYS */;
INSERT INTO `ChiTietCapTheoLo` VALUES (1,1,1,100),(1,1,2,280),(1,2,3,180),(1,4,7,200),(1,6,11,80),(1,6,12,100),(2,7,13,240),(2,8,15,200),(2,8,16,280),(2,9,17,180),(2,10,19,90),(2,10,20,100),(3,11,21,40),(3,11,22,100),(3,15,29,90),(3,19,37,150),(3,20,39,90),(4,3,5,120),(4,23,45,100),(4,24,47,2),(4,24,48,18),(4,25,49,80),(6,5,9,40),(6,5,10,60),(6,13,25,8),(6,13,26,10),(6,14,27,20),(6,14,28,50),(6,16,31,90),(6,17,33,140),(7,16,31,33),(7,23,45,45),(8,10,19,100),(9,24,47,10),(10,6,11,10),(11,6,11,10),(13,20,39,6),(14,22,43,10),(16,6,11,9),(16,22,44,5),(18,13,26,30),(19,21,41,24);
/*!40000 ALTER TABLE `ChiTietCapTheoLo` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ChiTietDonThuoc`
--

DROP TABLE IF EXISTS `ChiTietDonThuoc`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `ChiTietDonThuoc` (
  `MaDonThuoc` int(11) NOT NULL,
  `MaThuoc` int(11) NOT NULL,
  `SoLuong` int(11) NOT NULL,
  `LieuDung` varchar(255) NOT NULL,
  `TanSuat` varchar(100) NOT NULL,
  `SoNgayDung` int(11) NOT NULL,
  `GhiChu` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`MaDonThuoc`,`MaThuoc`),
  KEY `IX_ChiTietDonThuoc_MaThuoc` (`MaThuoc`),
  CONSTRAINT `FK_ChiTietDonThuoc_DonThuoc_MaDonThuoc` FOREIGN KEY (`MaDonThuoc`) REFERENCES `DonThuoc` (`MaDonThuoc`),
  CONSTRAINT `FK_ChiTietDonThuoc_Thuoc_MaThuoc` FOREIGN KEY (`MaThuoc`) REFERENCES `Thuoc` (`MaThuoc`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ChiTietDonThuoc`
--

LOCK TABLES `ChiTietDonThuoc` WRITE;
/*!40000 ALTER TABLE `ChiTietDonThuoc` DISABLE KEYS */;
INSERT INTO `ChiTietDonThuoc` VALUES (1,6,30,'Uống 1 viên','1 lần/ngày',30,'Uống buổi sáng.'),(1,7,30,'Uống 1 viên','1 lần/ngày',30,'Uống buổi sáng.'),(1,10,30,'Uống 1 viên','1 lần/ngày',30,'Uống buổi tối.'),(2,1,14,'Uống 1 viên','2 lần/ngày',7,'Chỉ dùng khi đau hoặc sốt.'),(2,2,21,'Uống 1 viên','3 lần/ngày',7,'Uống sau ăn.'),(2,11,7,'Uống 1 viên','1 lần/ngày',7,'Uống buổi tối.'),(3,4,28,'Uống 1 viên','2 lần/ngày',14,'Uống trước ăn 30 phút.'),(3,20,14,'Uống 1 gói','1 lần/ngày',14,'Pha với nước, uống xa thuốc khác.'),(4,8,60,'Uống 1 viên','2 lần/ngày',30,'Uống trong hoặc ngay sau bữa ăn.'),(4,9,30,'Uống 1 viên','1 lần/ngày',30,'Uống trước bữa sáng.'),(4,10,30,'Uống 1 viên','1 lần/ngày',30,'Uống buổi tối.'),(5,1,6,'Uống 1 viên','2 lần/ngày',3,'Chỉ dùng khi sốt.'),(5,19,10,'Pha 1 gói theo hướng dẫn','Sau mỗi lần đi ngoài',3,'Không pha đặc hơn hướng dẫn.'),(5,20,9,'Uống 1 gói','3 lần/ngày',3,'Uống xa các thuốc khác ít nhất 2 giờ.'),(6,12,10,'Uống 1 viên','1 lần/ngày',10,'Uống buổi tối.'),(6,21,10,'Hòa tan 1 viên trong nước','1 lần/ngày',10,'Uống sau ăn.'),(7,1,6,'Uống 1 viên','2 lần/ngày',3,'Chỉ dùng khi đau hoặc sốt.'),(7,13,1,'Xịt 2 nhát mỗi lần','Khi khó thở, tối đa 4 lần/ngày',7,'Lắc kỹ bình trước khi dùng.'),(7,16,3,'Uống 1 viên','1 lần/ngày',3,'Uống trước hoặc sau ăn 1 giờ.'),(8,4,5,'Uống 1 viên','1 lần/ngày',5,'Uống trước bữa sáng.'),(8,17,15,'Uống 1 viên','3 lần/ngày',5,'Uống sau ăn no.'),(9,6,30,'Uống 1 viên','1 lần/ngày',30,'Uống buổi sáng.'),(9,7,30,'Uống 1 viên','1 lần/ngày',30,'Uống buổi sáng.'),(9,10,30,'Uống 1 viên','1 lần/ngày',30,'Uống buổi tối.'),(10,8,60,'Uống 1 viên','2 lần/ngày',30,'Uống trong hoặc ngay sau bữa ăn.'),(10,9,30,'Uống 1 viên','1 lần/ngày',30,'Uống trước bữa sáng.'),(10,10,30,'Uống 1 viên','1 lần/ngày',30,'Uống buổi tối.'),(11,1,14,'Uống 1 viên','2 lần/ngày',7,'Chỉ dùng khi đau hoặc sốt.'),(11,3,14,'Uống 1 viên','2 lần/ngày',7,'Uống đầu bữa ăn.'),(11,11,7,'Uống 1 viên','1 lần/ngày',7,'Uống buổi tối.'),(12,1,10,'Uống 1 viên','2 lần/ngày',5,'Chỉ dùng khi đau.'),(12,15,10,'Uống 1 viên','2 lần/ngày',5,'Uống sau ăn.'),(12,26,1,'Bôi ngoài da một lớp mỏng','2 lần/ngày',7,'Không bôi vào mắt.'),(13,11,10,'Uống 1 viên','1 lần/ngày',10,'Uống buổi tối.'),(13,13,1,'Xịt 2 nhát mỗi lần','Khi khó thở, tối đa 4 lần/ngày',10,'Mang bình xịt theo người.'),(13,14,10,'Khí dung 1 ống','2 lần/ngày',5,'Súc miệng sau khi khí dung.'),(14,1,10,'Uống 1 viên','2 lần/ngày',5,'Chỉ dùng khi đau hoặc sốt.'),(14,23,10,'Uống 1 viên','2 lần/ngày',5,'Uống sau ăn.'),(15,5,7,'Uống 1 viên','1 lần/ngày',7,'Uống trước bữa sáng.'),(15,18,14,'Uống 1 viên','2 lần/ngày',7,'Uống sau ăn no.'),(15,22,30,'Uống 1 viên','1 lần/ngày',30,'Uống sau ăn.'),(16,1,10,'Uống 1 viên','2 lần/ngày',5,'Chỉ dùng khi đau hoặc sốt.'),(16,12,5,'Uống 1 viên','1 lần/ngày',5,'Uống buổi tối.'),(16,21,10,'Hòa tan 1 viên trong nước','2 lần/ngày',5,'Uống sau ăn.'),(17,8,60,'Uống 1 viên','2 lần/ngày',30,'Uống trong hoặc ngay sau bữa ăn.'),(17,10,30,'Uống 1 viên','1 lần/ngày',30,'Uống buổi tối.'),(17,24,1,'Tiêm dưới da theo số đơn vị được hướng dẫn','2 lần/ngày',30,'Bảo quản lạnh, không để đông đá.'),(18,1,14,'Uống 1 viên','2 lần/ngày',7,'Chỉ dùng khi đau hoặc sốt.'),(18,14,10,'Khí dung 1 ống','2 lần/ngày',5,'Súc miệng sau khi khí dung.'),(18,15,14,'Uống 1 viên','2 lần/ngày',7,'Uống sau ăn.'),(19,3,14,'Uống 1 viên','2 lần/ngày',7,'Uống đầu bữa ăn.'),(19,4,7,'Uống 1 viên','1 lần/ngày',7,'Uống trước bữa sáng.'),(20,1,10,'Uống 1 viên','2 lần/ngày',5,NULL),(20,23,10,'Uống 1 viên','2 lần/ngày',5,NULL),(21,3,60,'2 viên','1 lần/1 ngày',30,NULL),(21,14,30,'1 ống','1 lần/ngày',30,NULL),(22,20,1,'1','1',1,'1'),(23,20,50,'50','1 lần/ngày',1,NULL),(23,23,20,'2 viên','1 lần/ngày',10,NULL),(24,6,1,'1','1',1,'1'),(25,6,1,'1','1',1,'cook'),(26,10,2,'1','1',2,NULL),(27,28,20,'2','1 sáng 1 tối',5,NULL),(28,10,33,'3','3',3,NULL),(29,16,10,'1','1',10,'nhaan'),(30,2,10,'1','1',10,NULL),(31,2,10,'1','1',10,NULL),(31,3,10,'1','1',10,NULL),(31,6,10,'1','1',10,NULL);
/*!40000 ALTER TABLE `ChiTietDonThuoc` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ChiTietPhieuXinCap`
--

DROP TABLE IF EXISTS `ChiTietPhieuXinCap`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `ChiTietPhieuXinCap` (
  `MaPhieu` int(11) NOT NULL,
  `MaThuoc` int(11) NOT NULL,
  `SoLuongYeuCau` int(11) NOT NULL,
  `SoLuongDuyet` int(11) DEFAULT NULL,
  `GhiChu` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`MaPhieu`,`MaThuoc`),
  KEY `IX_ChiTietPhieuXinCap_MaThuoc` (`MaThuoc`),
  CONSTRAINT `FK_ChiTietPhieuXinCap_PhieuXinCapThuoc_MaPhieu` FOREIGN KEY (`MaPhieu`) REFERENCES `PhieuXinCapThuoc` (`MaPhieu`),
  CONSTRAINT `FK_ChiTietPhieuXinCap_Thuoc_MaThuoc` FOREIGN KEY (`MaThuoc`) REFERENCES `Thuoc` (`MaThuoc`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ChiTietPhieuXinCap`
--

LOCK TABLES `ChiTietPhieuXinCap` WRITE;
/*!40000 ALTER TABLE `ChiTietPhieuXinCap` DISABLE KEYS */;
INSERT INTO `ChiTietPhieuXinCap` VALUES (1,1,400,380,'Thuốc hạ sốt dùng thường xuyên.'),(1,2,200,180,NULL),(1,4,200,200,NULL),(1,6,200,180,NULL),(2,7,250,240,NULL),(2,8,500,480,NULL),(2,9,200,180,NULL),(2,10,200,190,NULL),(3,11,150,140,'Ưu tiên lô gần hết hạn.'),(3,15,100,90,NULL),(3,19,150,150,NULL),(3,20,100,90,NULL),(4,3,120,120,NULL),(4,23,100,100,NULL),(4,24,20,20,'Yêu cầu bảo quản lạnh khi vận chuyển.'),(4,25,80,80,NULL),(5,21,600,NULL,NULL),(5,22,400,NULL,NULL),(6,5,100,100,NULL),(6,13,20,18,NULL),(6,14,80,70,NULL),(6,16,100,90,NULL),(6,17,150,140,NULL),(7,16,33,33,'t1'),(7,23,45,45,'t2'),(8,10,100,100,NULL),(9,24,10,10,'xin tâm'),(10,6,10,10,NULL),(11,6,10,10,'thiếu'),(12,28,20,NULL,NULL),(13,20,6,6,'thử'),(14,22,10,10,'qưeq'),(15,27,12,NULL,NULL),(16,6,9,9,NULL),(16,22,5,5,NULL),(17,3,90,NULL,'dsfsdfsfsf'),(18,13,30,30,NULL),(19,21,24,24,NULL),(20,18,50,NULL,NULL);
/*!40000 ALTER TABLE `ChiTietPhieuXinCap` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ChiTietPhieuXuat`
--

DROP TABLE IF EXISTS `ChiTietPhieuXuat`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `ChiTietPhieuXuat` (
  `MaPhieuXuat` int(11) NOT NULL,
  `MaLo` int(11) NOT NULL,
  `SoLuong` int(11) NOT NULL,
  `DonGiaBan` decimal(18,2) NOT NULL,
  `ThanhTien` decimal(18,2) NOT NULL,
  PRIMARY KEY (`MaPhieuXuat`,`MaLo`),
  KEY `IX_ChiTietPhieuXuat_MaLo` (`MaLo`),
  CONSTRAINT `FK_ChiTietPhieuXuat_LoThuoc_MaLo` FOREIGN KEY (`MaLo`) REFERENCES `LoThuoc` (`MaLo`),
  CONSTRAINT `FK_ChiTietPhieuXuat_PhieuXuatThuoc_MaPhieuXuat` FOREIGN KEY (`MaPhieuXuat`) REFERENCES `PhieuXuatThuoc` (`MaPhieuXuat`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ChiTietPhieuXuat`
--

LOCK TABLES `ChiTietPhieuXuat` WRITE;
/*!40000 ALTER TABLE `ChiTietPhieuXuat` DISABLE KEYS */;
INSERT INTO `ChiTietPhieuXuat` VALUES (1,11,30,900.00,27000.00),(1,13,30,1800.00,54000.00),(1,19,30,2500.00,75000.00),(2,1,8,1200.00,9600.00),(2,2,6,1200.00,7200.00),(2,3,21,2800.00,58800.00),(2,21,7,850.00,5950.00),(3,7,28,1800.00,50400.00),(3,39,14,5000.00,70000.00),(4,15,60,700.00,42000.00),(4,17,30,2300.00,69000.00),(4,19,30,2500.00,75000.00),(5,1,6,1200.00,7200.00),(5,37,10,3000.00,30000.00),(5,39,9,5000.00,45000.00),(6,23,10,1200.00,12000.00),(6,41,10,3500.00,35000.00),(7,1,6,1200.00,7200.00),(7,25,1,68000.00,68000.00),(7,31,3,9500.00,28500.00),(8,7,5,1800.00,9000.00),(8,33,15,1400.00,21000.00),(9,11,10,900.00,9000.00),(9,12,20,900.00,18000.00),(9,13,30,1800.00,54000.00),(9,19,30,2500.00,75000.00),(10,15,60,700.00,42000.00),(10,17,30,2300.00,69000.00),(10,19,30,2500.00,75000.00),(11,1,14,1200.00,16800.00),(11,5,8,14500.00,116000.00),(11,6,6,14500.00,87000.00),(11,21,7,850.00,5950.00),(12,1,10,1200.00,12000.00),(12,29,10,8500.00,85000.00),(12,51,1,17000.00,17000.00),(13,21,10,850.00,8500.00),(13,25,1,68000.00,68000.00),(13,27,4,14500.00,58000.00),(13,28,6,14500.00,87000.00),(14,1,10,1200.00,12000.00),(14,45,10,11000.00,110000.00),(15,9,7,3200.00,22400.00),(15,36,14,1000.00,14000.00),(15,43,30,2800.00,84000.00),(16,5,50,14500.00,725000.00),(16,6,10,14500.00,145000.00),(16,27,20,14500.00,290000.00),(16,28,10,14500.00,145000.00),(17,1,10,1200.00,12000.00),(17,23,5,1200.00,6000.00),(17,41,10,3500.00,35000.00),(18,1,14,1200.00,16800.00),(18,28,10,14500.00,145000.00),(18,29,14,8500.00,119000.00),(19,40,1,5000.00,5000.00),(20,1,10,1200.00,12000.00),(20,45,10,11000.00,110000.00),(21,39,40,5000.00,200000.00),(21,40,10,5000.00,50000.00),(21,45,20,11000.00,220000.00),(22,11,1,900.00,900.00),(23,11,1,900.00,900.00),(24,19,2,2500.00,5000.00),(25,31,10,9500.00,95000.00),(26,3,10,2800.00,28000.00),(26,5,10,14500.00,145000.00),(26,11,10,900.00,9000.00);
/*!40000 ALTER TABLE `ChiTietPhieuXuat` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `DonThuoc`
--

DROP TABLE IF EXISTS `DonThuoc`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `DonThuoc` (
  `MaDonThuoc` int(11) NOT NULL AUTO_INCREMENT,
  `MaBN` int(11) NOT NULL,
  `BacSiId` int(11) NOT NULL,
  `NgayKeDon` datetime(6) NOT NULL,
  `ChanDoan` varchar(255) NOT NULL,
  `TrangThai` varchar(50) NOT NULL,
  `GhiChu` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`MaDonThuoc`),
  KEY `IX_DonThuoc_BacSiId` (`BacSiId`),
  KEY `IX_DonThuoc_MaBN` (`MaBN`),
  CONSTRAINT `FK_DonThuoc_BenhNhan_MaBN` FOREIGN KEY (`MaBN`) REFERENCES `BenhNhan` (`MaBN`),
  CONSTRAINT `FK_DonThuoc_User_BacSiId` FOREIGN KEY (`BacSiId`) REFERENCES `User` (`UserId`)
) ENGINE=InnoDB AUTO_INCREMENT=32 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `DonThuoc`
--

LOCK TABLES `DonThuoc` WRITE;
/*!40000 ALTER TABLE `DonThuoc` DISABLE KEYS */;
INSERT INTO `DonThuoc` VALUES (1,1,2,'2026-06-15 08:30:00.000000','Tăng huyết áp nguyên phát, rối loạn lipid máu','DA_XUAT_THUOC','Tái khám sau 30 ngày, theo dõi huyết áp tại nhà.'),(2,2,2,'2026-06-18 09:20:00.000000','Viêm họng cấp do vi khuẩn','DA_XUAT_THUOC','Uống đủ liệu trình kháng sinh.'),(3,3,2,'2026-06-22 14:05:00.000000','Viêm dạ dày, trào ngược dạ dày thực quản','DA_XUAT_THUOC','Hạn chế cà phê, thức ăn cay và ăn khuya.'),(4,4,2,'2026-06-25 08:10:00.000000','Đái tháo đường típ 2','DA_XUAT_THUOC','Theo dõi đường huyết và tái khám sau 1 tháng.'),(5,5,2,'2026-06-29 14:35:00.000000','Tiêu chảy cấp chưa mất nước','DA_XUAT_THUOC','Bù nước thường xuyên, tái khám nếu sốt cao.'),(6,6,2,'2026-07-02 09:05:00.000000','Viêm mũi dị ứng','DA_XUAT_THUOC','Tránh tiếp xúc bụi và các dị nguyên đã biết.'),(7,7,2,'2026-07-05 10:40:00.000000','Viêm đường hô hấp dưới kèm co thắt phế quản','DA_XUAT_THUOC','Hướng dẫn kỹ cách dùng bình xịt.'),(8,8,2,'2026-07-08 15:30:00.000000','Đau cơ xương khớp vùng thắt lưng','DA_XUAT_THUOC','Uống thuốc giảm đau sau ăn.'),(9,9,2,'2026-07-10 08:15:00.000000','Tăng huyết áp kèm rối loạn lipid máu','DA_XUAT_THUOC',NULL),(10,10,2,'2026-07-12 09:40:00.000000','Đái tháo đường típ 2, rối loạn lipid máu','DA_XUAT_THUOC','Duy trì chế độ ăn hạn chế đường và tinh bột nhanh.'),(11,11,2,'2026-07-14 14:10:00.000000','Viêm xoang cấp do vi khuẩn','DA_XUAT_THUOC','Tái khám nếu triệu chứng không giảm sau 3 ngày.'),(12,12,2,'2026-07-16 09:00:00.000000','Nhiễm khuẩn da mức độ nhẹ','DA_XUAT_THUOC','Giữ vùng tổn thương sạch và khô.'),(13,13,2,'2026-07-18 10:25:00.000000','Hen phế quản, đợt cấp nhẹ','DA_XUAT_THUOC','Nếu khó thở tăng phải đến cơ sở y tế ngay.'),(14,14,2,'2026-07-20 14:45:00.000000','Nhiễm khuẩn đường tiết niệu không biến chứng','DA_XUAT_THUOC','Uống nhiều nước và dùng đủ kháng sinh.'),(15,15,2,'2026-07-21 08:20:00.000000','Thoái hóa khớp gối','DA_XUAT_THUOC','Đơn giấy đã chuyển cho bệnh nhân.'),(16,16,2,'2026-07-21 14:15:00.000000','Nhiễm siêu vi đường hô hấp trên','DA_XUAT_THUOC',NULL),(17,17,2,'2026-07-22 09:30:00.000000','Đái tháo đường típ 2 đang điều trị insulin','CHO_XUAT_THUOC','Bảo quản insulin ở 2-8 độ C.'),(18,18,2,'2026-07-22 15:10:00.000000','Viêm phổi cộng đồng mức độ nhẹ','DA_XUAT_THUOC','Tái khám sau 48-72 giờ.'),(19,19,2,'2026-07-23 10:05:00.000000','Viêm amidan cấp','CHO_XUAT_THUOC','Bác sĩ đang hoàn thiện đơn.'),(20,20,2,'2026-07-23 16:40:00.000000','Nhiễm khuẩn đường tiết niệu','DA_XUAT_THUOC','Hủy do bệnh nhân được chuyển điều trị nội trú.'),(21,8,2,'2026-07-27 11:52:30.285323','Thoái hóa đốt sống cổ','DA_XUAT_THUOC','Kiêng vận động mạnh'),(22,20,2,'2026-07-28 12:10:01.957607','abc','DA_XUAT_THUOC','xyz'),(23,11,7,'2026-07-29 20:45:58.529401','test chẩn đoán','DA_XUAT_THUOC','test ghi chú'),(24,1,7,'2026-07-29 20:55:18.570314','1','DA_XUAT_THUOC','1'),(25,5,6,'2026-07-29 21:37:20.201708','HIV','DA_XUAT_THUOC',NULL),(26,12,6,'2026-07-30 08:34:16.052437','nhana','DA_XUAT_THUOC',NULL),(27,8,3,'2026-07-31 22:04:27.226354','Đau bụng','CHO_XUAT_THUOC',NULL),(28,8,3,'2026-07-31 23:04:22.019562','dsss','CHO_XUAT_THUOC',NULL),(29,16,3,'2026-08-01 07:01:26.857195','Gan B','DA_XUAT_THUOC',NULL),(30,8,3,'2026-08-01 07:46:31.051989','vieem gan b','CHO_XUAT_THUOC',NULL),(31,14,3,'2026-08-01 07:47:22.012682','dass','DA_XUAT_THUOC',NULL);
/*!40000 ALTER TABLE `DonThuoc` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `HoaDon`
--

DROP TABLE IF EXISTS `HoaDon`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `HoaDon` (
  `MaHD` int(11) NOT NULL AUTO_INCREMENT,
  `MaPhieuXuat` int(11) NOT NULL,
  `TongTienThuoc` decimal(18,2) NOT NULL,
  `TienThuocDuocBHYT` decimal(18,2) NOT NULL,
  `TyLeBHYTApDung` int(11) NOT NULL,
  `TienBHYTThanhToan` decimal(18,2) NOT NULL,
  `TienBenhNhanTra` decimal(18,2) NOT NULL,
  `PhuongThucThanhToan` varchar(50) NOT NULL,
  `NoiDungChuyenKhoan` varchar(255) DEFAULT NULL,
  `MaGiaoDich` varchar(100) DEFAULT NULL,
  `ThoiGianThanhToan` datetime(6) NOT NULL,
  PRIMARY KEY (`MaHD`),
  UNIQUE KEY `IX_HoaDon_MaPhieuXuat` (`MaPhieuXuat`),
  UNIQUE KEY `IX_HoaDon_MaGiaoDich` (`MaGiaoDich`),
  CONSTRAINT `FK_HoaDon_PhieuXuatThuoc_MaPhieuXuat` FOREIGN KEY (`MaPhieuXuat`) REFERENCES `PhieuXuatThuoc` (`MaPhieuXuat`)
) ENGINE=InnoDB AUTO_INCREMENT=27 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `HoaDon`
--

LOCK TABLES `HoaDon` WRITE;
/*!40000 ALTER TABLE `HoaDon` DISABLE KEYS */;
INSERT INTO `HoaDon` VALUES (1,1,156000.00,156000.00,80,124800.00,31200.00,'TIEN_MAT',NULL,NULL,'2026-06-15 09:15:00.000000'),(2,2,81550.00,81550.00,80,65240.00,16310.00,'CHUYEN_KHOAN','THANH TOAN THUOC PX2','GD-SEED-2','2026-06-18 10:15:00.000000'),(3,3,120400.00,50400.00,95,47880.00,72520.00,'TIEN_MAT',NULL,NULL,'2026-06-22 14:50:00.000000'),(4,4,186000.00,186000.00,100,186000.00,0.00,'CHUYEN_KHOAN','THANH TOAN THUOC PX4','GD-SEED-4','2026-06-25 09:00:00.000000'),(5,5,82200.00,37200.00,0,0.00,82200.00,'TIEN_MAT',NULL,NULL,'2026-06-29 15:20:00.000000'),(6,6,47000.00,0.00,80,0.00,47000.00,'CHUYEN_KHOAN','THANH TOAN THUOC PX6','GD-SEED-6','2026-07-02 09:55:00.000000'),(7,7,103700.00,103700.00,0,0.00,103700.00,'TIEN_MAT',NULL,NULL,'2026-07-05 11:30:00.000000'),(8,8,30000.00,30000.00,95,28500.00,1500.00,'CHUYEN_KHOAN','THANH TOAN THUOC PX8','GD-SEED-8','2026-07-08 16:15:00.000000'),(9,9,156000.00,156000.00,80,124800.00,31200.00,'TIEN_MAT',NULL,NULL,'2026-07-10 09:00:00.000000'),(10,10,186000.00,186000.00,80,148800.00,37200.00,'CHUYEN_KHOAN','THANH TOAN THUOC PX10','GD-SEED-10','2026-07-12 10:25:00.000000'),(11,11,225750.00,225750.00,100,225750.00,0.00,'TIEN_MAT',NULL,NULL,'2026-07-14 15:00:00.000000'),(12,12,114000.00,97000.00,0,0.00,114000.00,'CHUYEN_KHOAN','THANH TOAN THUOC PX12','GD-SEED-12','2026-07-16 09:45:00.000000'),(13,13,221500.00,221500.00,80,177200.00,44300.00,'TIEN_MAT',NULL,NULL,'2026-07-18 11:10:00.000000'),(14,14,122000.00,122000.00,95,115900.00,6100.00,'CHUYEN_KHOAN','THANH TOAN THUOC PX14','GD-SEED-14','2026-07-20 15:30:00.000000'),(15,15,120400.00,36400.00,80,29120.00,91280.00,'TIEN_MAT',NULL,NULL,'2026-07-28 10:19:58.583511'),(16,16,1305000.00,1305000.00,95,1239750.00,65250.00,'CHUYEN_KHOAN','DT214DD2EF','95a860db2bf77a83528f09b80bf438e2','2026-07-28 10:29:49.400708'),(17,17,53000.00,12000.00,0,0.00,53000.00,'CHUYEN_KHOAN','DT16A83893','cb1421716d0fc69f6ef5ebd59baf654b','2026-07-28 12:02:57.960419'),(18,18,280800.00,280800.00,80,224640.00,56160.00,'CHUYEN_KHOAN','HD18DC27B7','1492c74359cb73739a24cf2d2229de7a','2026-07-28 13:30:19.716921'),(19,19,5000.00,0.00,0,0.00,5000.00,'TIEN_MAT',NULL,NULL,'2026-07-28 13:35:39.923098'),(20,20,122000.00,122000.00,0,0.00,122000.00,'CHUYEN_KHOAN','HD20BD653C','f83df724400a85a09f79c50497789cb3','2026-07-29 17:12:22.932409'),(21,21,470000.00,220000.00,100,220000.00,250000.00,'CHUYEN_KHOAN','HD23F0CEF6','6f16bf392e351795aac54c5cbdff1577','2026-07-29 20:49:48.073540'),(22,22,900.00,900.00,80,720.00,180.00,'TIEN_MAT',NULL,NULL,'2026-07-29 20:56:33.206567'),(23,23,900.00,900.00,0,0.00,900.00,'TIEN_MAT',NULL,NULL,'2026-07-29 21:39:41.501275'),(24,24,5000.00,5000.00,0,0.00,5000.00,'TIEN_MAT',NULL,NULL,'2026-07-30 08:34:56.442514'),(25,25,95000.00,95000.00,0,0.00,95000.00,'TIEN_MAT',NULL,NULL,'2026-08-01 07:49:27.605137'),(26,26,182000.00,182000.00,95,172900.00,9100.00,'CHUYEN_KHOAN','HD316BF40A','0627cb17626c0df0f3797cd7ba9c926e','2026-08-01 07:57:30.535490');
/*!40000 ALTER TABLE `HoaDon` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Kho`
--

DROP TABLE IF EXISTS `Kho`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `Kho` (
  `MaKho` int(11) NOT NULL AUTO_INCREMENT,
  `TenKho` varchar(100) NOT NULL,
  `LoaiKho` varchar(50) NOT NULL,
  PRIMARY KEY (`MaKho`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Kho`
--

LOCK TABLES `Kho` WRITE;
/*!40000 ALTER TABLE `Kho` DISABLE KEYS */;
INSERT INTO `Kho` VALUES (1,'Kho tổng','KHO_TONG'),(2,'Kho quầy','KHO_QUAY');
/*!40000 ALTER TABLE `Kho` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `LoThuoc`
--

DROP TABLE IF EXISTS `LoThuoc`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `LoThuoc` (
  `MaLo` int(11) NOT NULL AUTO_INCREMENT,
  `MaThuoc` int(11) NOT NULL,
  `SoLo` varchar(100) NOT NULL,
  `NgaySanXuat` datetime(6) DEFAULT NULL,
  `NgayHetHan` datetime(6) NOT NULL,
  PRIMARY KEY (`MaLo`),
  UNIQUE KEY `IX_LoThuoc_MaThuoc_SoLo` (`MaThuoc`,`SoLo`),
  CONSTRAINT `FK_LoThuoc_Thuoc_MaThuoc` FOREIGN KEY (`MaThuoc`) REFERENCES `Thuoc` (`MaThuoc`)
) ENGINE=InnoDB AUTO_INCREMENT=53 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `LoThuoc`
--

LOCK TABLES `LoThuoc` WRITE;
/*!40000 ALTER TABLE `LoThuoc` DISABLE KEYS */;
INSERT INTO `LoThuoc` VALUES (1,1,'PCM-2501','2025-01-15 00:00:00.000000','2026-09-30 00:00:00.000000'),(2,1,'PCM-2604','2026-04-10 00:00:00.000000','2028-04-30 00:00:00.000000'),(3,2,'AMX-2508','2025-08-05 00:00:00.000000','2026-12-31 00:00:00.000000'),(4,2,'AMX-2602','2026-02-12 00:00:00.000000','2028-02-29 00:00:00.000000'),(5,3,'AMC-2506','2025-06-20 00:00:00.000000','2027-06-30 00:00:00.000000'),(6,3,'AMC-2603','2026-03-08 00:00:00.000000','2028-03-31 00:00:00.000000'),(7,4,'OME-2504','2025-04-17 00:00:00.000000','2027-04-30 00:00:00.000000'),(8,4,'OME-2601','2026-01-09 00:00:00.000000','2028-01-31 00:00:00.000000'),(9,5,'PAN-2507','2025-07-11 00:00:00.000000','2027-07-31 00:00:00.000000'),(10,5,'PAN-2602','2026-02-18 00:00:00.000000','2028-02-29 00:00:00.000000'),(11,6,'AML-2503','2025-03-25 00:00:00.000000','2026-10-31 00:00:00.000000'),(12,6,'AML-2603','2026-03-14 00:00:00.000000','2028-03-31 00:00:00.000000'),(13,7,'LOS-2505','2025-05-06 00:00:00.000000','2027-05-31 00:00:00.000000'),(14,7,'LOS-2601','2026-01-21 00:00:00.000000','2028-01-31 00:00:00.000000'),(15,8,'MET-2502','2025-02-13 00:00:00.000000','2027-02-28 00:00:00.000000'),(16,8,'MET-2602','2026-02-06 00:00:00.000000','2028-02-29 00:00:00.000000'),(17,9,'GLC-2506','2025-06-09 00:00:00.000000','2027-06-30 00:00:00.000000'),(18,9,'GLC-2601','2026-01-16 00:00:00.000000','2028-01-31 00:00:00.000000'),(19,10,'ATV-2504','2025-04-07 00:00:00.000000','2027-04-30 00:00:00.000000'),(20,10,'ATV-2602','2026-02-23 00:00:00.000000','2028-02-29 00:00:00.000000'),(21,11,'CTZ-2501','2025-01-30 00:00:00.000000','2026-08-31 00:00:00.000000'),(22,11,'CTZ-2604','2026-04-03 00:00:00.000000','2028-04-30 00:00:00.000000'),(23,12,'LOR-2507','2025-07-19 00:00:00.000000','2027-07-31 00:00:00.000000'),(24,12,'LOR-2601','2026-01-27 00:00:00.000000','2028-01-31 00:00:00.000000'),(25,13,'SAL-2505','2025-05-15 00:00:00.000000','2027-05-31 00:00:00.000000'),(26,13,'SAL-2602','2026-02-20 00:00:00.000000','2028-02-29 00:00:00.000000'),(27,14,'BUD-2508','2025-08-24 00:00:00.000000','2026-11-30 00:00:00.000000'),(28,14,'BUD-2603','2026-03-12 00:00:00.000000','2028-03-31 00:00:00.000000'),(29,15,'CFX-2506','2025-06-28 00:00:00.000000','2027-06-30 00:00:00.000000'),(30,15,'CFX-2602','2026-02-09 00:00:00.000000','2028-02-29 00:00:00.000000'),(31,16,'AZI-2509','2025-09-05 00:00:00.000000','2027-09-30 00:00:00.000000'),(32,16,'AZI-2603','2026-03-20 00:00:00.000000','2028-03-31 00:00:00.000000'),(33,17,'IBU-2503','2025-03-04 00:00:00.000000','2027-03-31 00:00:00.000000'),(34,17,'IBU-2601','2026-01-11 00:00:00.000000','2028-01-31 00:00:00.000000'),(35,18,'DCF-2502','2025-02-08 00:00:00.000000','2026-08-15 00:00:00.000000'),(36,18,'DCF-2601','2026-01-05 00:00:00.000000','2028-01-31 00:00:00.000000'),(37,19,'ORS-2509','2025-09-17 00:00:00.000000','2026-12-31 00:00:00.000000'),(38,19,'ORS-2604','2026-04-22 00:00:00.000000','2027-10-31 00:00:00.000000'),(39,20,'DSM-2506','2025-06-16 00:00:00.000000','2027-06-30 00:00:00.000000'),(40,20,'DSM-2602','2026-02-14 00:00:00.000000','2028-02-29 00:00:00.000000'),(41,21,'VTC-2505','2025-05-10 00:00:00.000000','2027-05-31 00:00:00.000000'),(42,21,'VTC-2603','2026-03-19 00:00:00.000000','2028-03-31 00:00:00.000000'),(43,22,'CAD-2504','2025-04-13 00:00:00.000000','2027-04-30 00:00:00.000000'),(44,22,'CAD-2602','2026-02-25 00:00:00.000000','2028-02-29 00:00:00.000000'),(45,23,'CFM-2507','2025-07-02 00:00:00.000000','2027-07-31 00:00:00.000000'),(46,23,'CFM-2603','2026-03-27 00:00:00.000000','2028-03-31 00:00:00.000000'),(47,24,'INS-2509','2025-09-12 00:00:00.000000','2026-09-15 00:00:00.000000'),(48,24,'INS-2605','2026-05-06 00:00:00.000000','2027-05-31 00:00:00.000000'),(49,25,'NCL-2508','2025-08-18 00:00:00.000000','2027-08-31 00:00:00.000000'),(50,25,'NCL-2604','2026-04-15 00:00:00.000000','2028-04-30 00:00:00.000000'),(51,26,'PVI-2505','2025-05-29 00:00:00.000000','2027-05-31 00:00:00.000000'),(52,26,'PVI-2601','2026-01-18 00:00:00.000000','2028-01-31 00:00:00.000000');
/*!40000 ALTER TABLE `LoThuoc` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `PhieuXinCapThuoc`
--

DROP TABLE IF EXISTS `PhieuXinCapThuoc`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `PhieuXinCapThuoc` (
  `MaPhieu` int(11) NOT NULL AUTO_INCREMENT,
  `KhoCapId` int(11) NOT NULL,
  `KhoNhanId` int(11) NOT NULL,
  `NguoiLapId` int(11) NOT NULL,
  `NguoiDuyetId` int(11) DEFAULT NULL,
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
  CONSTRAINT `FK_PhieuXinCapThuoc_Kho_KhoCapId` FOREIGN KEY (`KhoCapId`) REFERENCES `Kho` (`MaKho`),
  CONSTRAINT `FK_PhieuXinCapThuoc_Kho_KhoNhanId` FOREIGN KEY (`KhoNhanId`) REFERENCES `Kho` (`MaKho`),
  CONSTRAINT `FK_PhieuXinCapThuoc_User_NguoiDuyetId` FOREIGN KEY (`NguoiDuyetId`) REFERENCES `User` (`UserId`),
  CONSTRAINT `FK_PhieuXinCapThuoc_User_NguoiLapId` FOREIGN KEY (`NguoiLapId`) REFERENCES `User` (`UserId`)
) ENGINE=InnoDB AUTO_INCREMENT=21 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `PhieuXinCapThuoc`
--

LOCK TABLES `PhieuXinCapThuoc` WRITE;
/*!40000 ALTER TABLE `PhieuXinCapThuoc` DISABLE KEYS */;
INSERT INTO `PhieuXinCapThuoc` VALUES (1,1,2,4,11,'2026-06-05 08:15:00.000000','2026-06-05 14:20:00.000000','Bổ sung thuốc thiết yếu phục vụ cấp phát đầu tháng.','Ưu tiên xuất các lô gần hết hạn trước.','DA_DUYET'),(2,1,2,4,11,'2026-06-20 09:05:00.000000','2026-06-20 15:10:00.000000','Bổ sung nhóm thuốc tim mạch và đái tháo đường.','Đã đối chiếu tồn kho thực tế.','DA_DUYET'),(3,1,2,4,11,'2026-07-05 10:30:00.000000','2026-07-06 08:40:00.000000','Tồn kho quầy của một số thuốc điều trị cấp tính xuống thấp.',NULL,'DA_DUYET'),(4,1,2,4,11,'2026-07-22 08:45:00.000000','2026-07-30 08:03:02.801091','Bổ sung thuốc kháng sinh, dịch truyền và insulin cho tuần cuối tháng.','','DA_DUYET'),(5,1,2,4,11,'2026-07-10 13:20:00.000000','2026-07-10 16:05:00.000000','Xin bổ sung số lượng lớn vitamin và thuốc bổ.','Số lượng yêu cầu vượt mức sử dụng; đề nghị lập lại phiếu.','DA_TU_CHOI'),(6,1,2,4,11,'2026-07-15 09:10:00.000000','2026-07-15 14:30:00.000000','Bổ sung thuốc hô hấp, kháng sinh và giảm đau.','Đã duyệt theo tồn kho thực tế.','DA_DUYET'),(7,1,2,4,11,'2026-07-27 20:47:32.777579','2026-07-30 08:31:48.690234','test','duyệt','DA_DUYET'),(8,1,2,8,11,'2026-07-28 10:23:24.454714','2026-07-30 08:38:06.345415','test4','duyệt','DA_DUYET'),(9,1,2,8,11,'2026-07-29 20:58:55.171118','2026-07-29 21:01:35.053313','xin tâm','','DA_DUYET'),(10,1,2,5,11,'2026-07-30 08:20:55.220472','2026-08-01 07:41:01.178971','thieu','','DA_DUYET'),(11,1,2,5,11,'2026-07-31 22:01:10.274352','2026-07-31 22:09:26.835521','thiếu','','DA_DUYET'),(12,1,2,5,NULL,'2026-07-31 22:05:40.005823',NULL,'hết rồi',NULL,'CHO_DUYET'),(13,1,2,5,11,'2026-01-08 07:43:00.000000','2026-08-01 08:42:13.358626','test','','DA_DUYET'),(14,1,2,8,11,'2026-01-08 07:47:00.000000','2026-08-01 08:13:33.463270','ưehs','','DA_DUYET'),(15,1,2,5,NULL,'2026-01-08 08:01:00.000000',NULL,'het',NULL,'CHO_DUYET'),(16,1,2,8,11,'2026-03-08 18:24:00.000000','2026-08-03 19:01:04.779427','tets','','DA_DUYET'),(17,1,2,8,NULL,'2026-03-08 23:44:00.000000',NULL,'sdfsd',NULL,'CHO_DUYET'),(18,1,2,8,11,'2026-03-08 23:45:00.000000','2026-08-04 07:04:27.318433','adasd','','DA_DUYET'),(19,1,2,8,11,'2026-03-08 23:45:00.000000','2026-08-03 23:46:40.092575','23423','','DA_DUYET'),(20,1,2,8,NULL,'2026-04-08 07:03:00.000000',NULL,'tétttt',NULL,'CHO_DUYET');
/*!40000 ALTER TABLE `PhieuXinCapThuoc` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `PhieuXuatThuoc`
--

DROP TABLE IF EXISTS `PhieuXuatThuoc`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `PhieuXuatThuoc` (
  `MaPhieuXuat` int(11) NOT NULL AUTO_INCREMENT,
  `MaDonThuoc` int(11) NOT NULL,
  `MaKho` int(11) NOT NULL,
  `DuocSiId` int(11) NOT NULL,
  `NgayXuat` datetime(6) NOT NULL,
  PRIMARY KEY (`MaPhieuXuat`),
  UNIQUE KEY `IX_PhieuXuatThuoc_MaDonThuoc` (`MaDonThuoc`),
  KEY `IX_PhieuXuatThuoc_DuocSiId` (`DuocSiId`),
  KEY `IX_PhieuXuatThuoc_MaKho` (`MaKho`),
  CONSTRAINT `FK_PhieuXuatThuoc_DonThuoc_MaDonThuoc` FOREIGN KEY (`MaDonThuoc`) REFERENCES `DonThuoc` (`MaDonThuoc`),
  CONSTRAINT `FK_PhieuXuatThuoc_Kho_MaKho` FOREIGN KEY (`MaKho`) REFERENCES `Kho` (`MaKho`),
  CONSTRAINT `FK_PhieuXuatThuoc_User_DuocSiId` FOREIGN KEY (`DuocSiId`) REFERENCES `User` (`UserId`)
) ENGINE=InnoDB AUTO_INCREMENT=27 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `PhieuXuatThuoc`
--

LOCK TABLES `PhieuXuatThuoc` WRITE;
/*!40000 ALTER TABLE `PhieuXuatThuoc` DISABLE KEYS */;
INSERT INTO `PhieuXuatThuoc` VALUES (1,1,2,4,'2026-06-15 09:05:00.000000'),(2,2,2,4,'2026-06-18 10:05:00.000000'),(3,3,2,4,'2026-06-22 14:40:00.000000'),(4,4,2,4,'2026-06-25 08:50:00.000000'),(5,5,2,4,'2026-06-29 15:10:00.000000'),(6,6,2,4,'2026-07-02 09:45:00.000000'),(7,7,2,4,'2026-07-05 11:20:00.000000'),(8,8,2,4,'2026-07-08 16:05:00.000000'),(9,9,2,4,'2026-07-10 08:50:00.000000'),(10,10,2,4,'2026-07-12 10:15:00.000000'),(11,11,2,4,'2026-07-14 14:50:00.000000'),(12,12,2,4,'2026-07-16 09:35:00.000000'),(13,13,2,4,'2026-07-18 11:00:00.000000'),(14,14,2,4,'2026-07-20 15:20:00.000000'),(15,15,2,4,'2026-07-28 10:19:58.583511'),(16,21,2,8,'2026-07-28 10:29:49.400708'),(17,16,2,4,'2026-07-28 12:02:57.960419'),(18,18,2,4,'2026-07-28 13:30:19.716921'),(19,22,2,4,'2026-07-28 13:35:39.923098'),(20,20,2,4,'2026-07-29 17:12:22.932409'),(21,23,2,8,'2026-07-29 20:49:48.073540'),(22,24,2,8,'2026-07-29 20:56:33.206567'),(23,25,2,5,'2026-07-29 21:39:41.501275'),(24,26,2,5,'2026-07-30 08:34:56.442514'),(25,29,2,5,'2026-08-01 07:49:27.605137'),(26,31,2,8,'2026-08-01 07:57:30.535490');
/*!40000 ALTER TABLE `PhieuXuatThuoc` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Thuoc`
--

DROP TABLE IF EXISTS `Thuoc`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `Thuoc` (
  `MaThuoc` int(11) NOT NULL AUTO_INCREMENT,
  `TenThuoc` varchar(100) NOT NULL,
  `DonViTinh` varchar(50) NOT NULL,
  `HoatChat` varchar(100) NOT NULL,
  `HamLuong` varchar(50) NOT NULL,
  `DonGiaBan` decimal(18,2) NOT NULL,
  `DuocBHYTChiTra` tinyint(1) NOT NULL,
  `TrangThai` varchar(50) NOT NULL,
  PRIMARY KEY (`MaThuoc`)
) ENGINE=InnoDB AUTO_INCREMENT=29 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Thuoc`
--

LOCK TABLES `Thuoc` WRITE;
/*!40000 ALTER TABLE `Thuoc` DISABLE KEYS */;
INSERT INTO `Thuoc` VALUES (1,'Paracetamol 500 mg','Viên','Paracetamol','500 mg',1200.00,1,'DANG_KINH_DOANH'),(2,'Amoxicillin 500 mg','Viên','Amoxicillin','500 mg',2800.00,1,'DANG_KINH_DOANH'),(3,'Amoxicillin/Clavulanate 875/125 mg','Viên','Amoxicillin + Acid clavulanic','875 mg/125 mg',14500.00,1,'DANG_KINH_DOANH'),(4,'Omeprazole 20 mg','Viên','Omeprazole','20 mg',1800.00,1,'DANG_KINH_DOANH'),(5,'Pantoprazole 40 mg','Viên','Pantoprazole','40 mg',3200.00,1,'DANG_KINH_DOANH'),(6,'Amlodipine 5 mg','Viên','Amlodipine','5 mg',900.00,1,'DANG_KINH_DOANH'),(7,'Losartan 50 mg','Viên','Losartan potassium','50 mg',1800.00,1,'DANG_KINH_DOANH'),(8,'Metformin 500 mg','Viên','Metformin hydrochloride','500 mg',700.00,1,'DANG_KINH_DOANH'),(9,'Gliclazide MR 30 mg','Viên','Gliclazide','30 mg',2300.00,1,'DANG_KINH_DOANH'),(10,'Atorvastatin 20 mg','Viên','Atorvastatin','20 mg',2500.00,1,'DANG_KINH_DOANH'),(11,'Cetirizine 10 mg','Viên','Cetirizine dihydrochloride','10 mg',850.00,1,'DANG_KINH_DOANH'),(12,'Loratadine 10 mg','Viên','Loratadine','10 mg',1200.00,0,'DANG_KINH_DOANH'),(13,'Salbutamol 100 mcg/liều','Chai','Salbutamol','100 mcg/liều',68000.00,1,'DANG_KINH_DOANH'),(14,'Budesonide khí dung 0,5 mg/2 ml','Ống','Budesonide','0,5 mg/2 ml',14500.00,1,'DANG_KINH_DOANH'),(15,'Cefuroxime 500 mg','Viên','Cefuroxime axetil','500 mg',8500.00,1,'DANG_KINH_DOANH'),(16,'Azithromycin 500 mg','Viên','Azithromycin','500 mg',9500.00,1,'DANG_KINH_DOANH'),(17,'Ibuprofen 400 mg','Viên','Ibuprofen','400 mg',1400.00,1,'DANG_KINH_DOANH'),(18,'Diclofenac 50 mg','Viên','Diclofenac sodium','50 mg',1000.00,1,'DANG_KINH_DOANH'),(19,'Oresol áp lực thẩm thấu thấp','Gói','Glucose + Natri clorid + Kali clorid + Natri citrat','27,9 g',3000.00,1,'DANG_KINH_DOANH'),(20,'Diosmectite 3 g','Gói','Diosmectite','3 g',5000.00,0,'DANG_KINH_DOANH'),(21,'Vitamin C 500 mg','Viên','Ascorbic acid','500 mg',3500.00,0,'DANG_KINH_DOANH'),(22,'Calcium 600 mg + Vitamin D3','Viên','Calcium carbonate + Cholecalciferol','600 mg/400 IU',2800.00,0,'TAM_NGUNG'),(23,'Cefixime 200 mg','Viên','Cefixime','200 mg',11000.00,1,'DANG_KINH_DOANH'),(24,'Insulin human 30/70','Lọ','Insulin human biphasic','100 IU/ml - 10 ml',125000.00,1,'TAM_NGUNG'),(25,'Natri clorid 0,9% 500 ml','Chai','Sodium chloride','0,9% - 500 ml',12000.00,1,'DANG_KINH_DOANH'),(26,'Povidone iod 10% 90 ml','Chai','Povidone iodine','10% - 90 ml',17000.00,0,'DANG_KINH_DOANH'),(27,'Vitamin B6','Viên','B6','40g',4000.00,0,'TAM_NGUNG'),(28,'Vitamin B3','Lọ','B3','30 mg',6000.00,1,'DANG_KINH_DOANH');
/*!40000 ALTER TABLE `Thuoc` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `TonKho`
--

DROP TABLE IF EXISTS `TonKho`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `TonKho` (
  `MaKho` int(11) NOT NULL,
  `MaLo` int(11) NOT NULL,
  `SoLuongTon` int(11) NOT NULL,
  PRIMARY KEY (`MaKho`,`MaLo`),
  KEY `IX_TonKho_MaLo` (`MaLo`),
  CONSTRAINT `FK_TonKho_Kho_MaKho` FOREIGN KEY (`MaKho`) REFERENCES `Kho` (`MaKho`),
  CONSTRAINT `FK_TonKho_LoThuoc_MaLo` FOREIGN KEY (`MaLo`) REFERENCES `LoThuoc` (`MaLo`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `TonKho`
--

LOCK TABLES `TonKho` WRITE;
/*!40000 ALTER TABLE `TonKho` DISABLE KEYS */;
INSERT INTO `TonKho` VALUES (1,1,300),(1,2,2400),(1,3,450),(1,4,1600),(1,5,180),(1,6,900),(1,7,500),(1,8,1300),(1,9,350),(1,10,900),(1,11,221),(1,12,1400),(1,13,400),(1,14,1400),(1,15,800),(1,16,2600),(1,17,500),(1,18,1600),(1,19,350),(1,20,1500),(1,21,120),(1,22,1000),(1,23,400),(1,24,900),(1,25,25),(1,26,60),(1,27,120),(1,28,400),(1,29,350),(1,30,1000),(1,31,267),(1,32,900),(1,33,500),(1,34,1300),(1,35,0),(1,36,650),(1,37,500),(1,38,1400),(1,39,344),(1,40,900),(1,41,576),(1,42,1200),(1,43,490),(1,44,895),(1,45,175),(1,46,900),(1,47,0),(1,48,72),(1,49,100),(1,50,600),(1,51,100),(1,52,300),(2,1,56),(2,2,650),(2,3,110),(2,4,420),(2,5,110),(2,6,90),(2,7,180),(2,8,300),(2,9,63),(2,10,130),(2,11,77),(2,12,360),(2,13,120),(2,14,320),(2,15,300),(2,16,700),(2,17,120),(2,18,300),(2,19,198),(2,20,280),(2,21,35),(2,22,250),(2,23,75),(2,24,180),(2,25,6),(2,26,46),(2,27,0),(2,28,50),(2,29,56),(2,30,180),(2,31,83),(2,32,140),(2,33,100),(2,34,250),(2,35,0),(2,36,106),(2,37,160),(2,38,320),(2,39,56),(2,40,189),(2,41,134),(2,42,240),(2,43,80),(2,44,185),(2,45,175),(2,46,140),(2,47,16),(2,48,30),(2,49,120),(2,50,120),(2,51,20),(2,52,60);
/*!40000 ALTER TABLE `TonKho` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `User`
--

DROP TABLE IF EXISTS `User`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `User` (
  `UserId` int(11) NOT NULL AUTO_INCREMENT,
  `FullName` varchar(100) NOT NULL,
  `PhoneNumber` varchar(20) NOT NULL,
  `Email` varchar(100) NOT NULL,
  `PasswordHash` varchar(255) NOT NULL,
  `Role` varchar(50) NOT NULL,
  `IsActive` tinyint(1) NOT NULL,
  PRIMARY KEY (`UserId`),
  UNIQUE KEY `IX_User_Email` (`Email`),
  UNIQUE KEY `IX_User_PhoneNumber` (`PhoneNumber`)
) ENGINE=InnoDB AUTO_INCREMENT=15 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `User`
--

LOCK TABLES `User` WRITE;
/*!40000 ALTER TABLE `User` DISABLE KEYS */;
INSERT INTO `User` VALUES (1,'Quản trị viên','0000000000','admin@gmail.com','AQAAAAEAAYagAAAAEAoi8S+gZ0EPMOKWIBoNTKwyLG/nnw896ohJOJu9e08MOxZeFhPyujJBQkB85AfiZw==','ADMIN',1),(2,'Ngô Văn Dũng','1','ngodung@gmail.com','AQAAAAEAACcQAAAAEFODFDsOdlNjXI4fYvcfQFbL1zmrSNH0O9LlRG/oG2Oh2E5bgvTHrhXzo7uVqtqmww==','BAC_SI',1),(3,'Phạm Thị Lan','0887364664','lanlan100@gmail.com','AQAAAAEAACcQAAAAEI8fzI6Yfv/gFGBVklJHzCpBO9H1ZwgTcDQ8P5UdU/edsXlqJvC2RlKWgLhc2Qvo9A==','BAC_SI',1),(4,'Phạm Kiều Oanh','3','kieuoanh@gmail.com','AQAAAAEAACcQAAAAEJi6WhLBjR5CxqtCdangHClbHjrlO+zlH5u3GjTHbR5KeNgFP1tn+KJvFswl8dAdkg==','DUOC_SI',1),(5,'Trần Thị Hồng','0776383275','hongtran@gmail.com','AQAAAAEAACcQAAAAEEDRV6Rf8Lq/9hXgxqfGA+LurREcyQp0Tqs5gma+B67Lj8U+2fBd0wlfVwLLnqbo5w==','DUOC_SI',1),(6,'Lê Minh Quân','0767635643','quanle@gmail.com','AQAAAAEAACcQAAAAEFlapDlpCxC0NHZV6JE8XKpsTcS3MR4fhoeq+2N825MaxKpnTSmR/+9UYmLWi6eyWg==','BAC_SI',1),(7,'Phạm Anh Tú','0983874557','anhtu@gmail.com','AQAAAAEAACcQAAAAEAq685VlMcOThHkdpKWqGNlh03suBb/u09duNXE2+CUtBYhcByUOoCYl/Vaz5wVm4g==','BAC_SI',1),(8,'Phạm Thu Hoài','0339488485','thuhoai@gmail.com','AQAAAAEAACcQAAAAEHMX0H7sHOvEcuI2u2toeZrGQk1FFtsR6sW05Veauv4GdgrD0S74Zwzu5mxdyDpPEw==','DUOC_SI',1),(9,'Phạm Thị Thanh Nhàn','0344995772','nhan@gmail.com','AQAAAAEAACcQAAAAEH8HktznHq5jmOc0y1ptuefmnKKU9DsKdr5f9ocjX0b0fGfl+dwuKtrDqVs5yyOD6w==','KE_TOAN',1),(10,'Phạm Phương Lan','0993441193','phuonglan@gmail.com','AQAAAAEAACcQAAAAEP8ZrVUGPlhHBXGIm4I3opXkTRBgadmNLpJ+bzZ0+HMMxFjlrXoCW63NGtWuOoMntg==','KE_TOAN',0),(11,'Nguyễn Văn Bình','0355693444','vanbinh@gmail.com','AQAAAAEAACcQAAAAEF+YWcgDw+0elbsvaDeDf14y50xLealpNRT5dAUG0XPSoTWRh00g6a2t8ZYELxbYqw==','KHO_TONG',1),(12,'Phạm Bích Ngọc','0346883474','bichngoc@gmail.com','AQAAAAEAACcQAAAAEEeJ4t86ptcElJ2AaVJrDxTbNggYfi26zB1XLuYI5eSkFDX4Tf+jg0qF1xHfggNv0g==','KHO_TONG',1),(13,'Quản trị viên 2','2','admin2@gmail.com','AQAAAAEAACcQAAAAELmHVkhkmb/5w/kTCO0gz5ADQhsc0WHENLX3nDD0mfbQuvfwjM1nsdqxDxsF5g3BBA==','ADMIN',1),(14,'345','444','huhu@gmail.com','AQAAAAEAACcQAAAAEFfJbtlT4FV64bOpsx77AXVbj2WfhDoWOnXey6ayfZOcQ6f+WUcxRvyA8kUkEumfIw==','DUOC_SI',1);
/*!40000 ALTER TABLE `User` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `__EFMigrationsHistory`
--

DROP TABLE IF EXISTS `__EFMigrationsHistory`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `__EFMigrationsHistory` (
  `MigrationId` varchar(150) NOT NULL,
  `ProductVersion` varchar(32) NOT NULL,
  PRIMARY KEY (`MigrationId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `__EFMigrationsHistory`
--

LOCK TABLES `__EFMigrationsHistory` WRITE;
/*!40000 ALTER TABLE `__EFMigrationsHistory` DISABLE KEYS */;
INSERT INTO `__EFMigrationsHistory` VALUES ('20260724113452_InitialMigration','6.0.33');
/*!40000 ALTER TABLE `__EFMigrationsHistory` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2026-08-06  7:27:28
