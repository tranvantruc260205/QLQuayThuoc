# Thiết kế giao diện quản lý quầy thuốc bệnh viện

Ngày: 2026-07-14  
Nền tảng: C# WinForms trên Visual Studio  
Cơ sở dữ liệu: MySQL  
Phạm vi: Đồ án 1

## 1. Mục tiêu

Xây dựng ứng dụng quản lý quầy thuốc bệnh viện theo sơ đồ use case đã thống nhất. Ứng dụng tập trung vào các nghiệp vụ chính: đăng nhập, kê đơn, tiếp nhận đơn, kiểm tra tồn kho, xuất thuốc, lập hóa đơn, thanh toán, quản lý thuốc, cảnh báo hết hạn, phiếu dự trù, thống kê doanh thu và quản lý tài khoản.

## 2. Kiến trúc giao diện

Ứng dụng sử dụng một `FrmMain` làm cửa sổ chính.

- Bên trái là menu chức năng.
- Phía trên hiển thị tên người dùng và vai trò.
- Khu vực trung tâm nạp các `UserControl`.
- Các form phụ chỉ dùng cho thêm, sửa, xem chi tiết hoặc in.

```text
Forms
├── FrmDangNhap.cs
├── FrmMain.cs
├── FrmThemSuaThuoc.cs
├── FrmChiTietDonThuoc.cs
└── FrmInHoaDon.cs

UserControls
├── UcTrangChu.cs
├── UcKeDon.cs
├── UcTiepNhanDon.cs
├── UcTonKho.cs
├── UcXuatThuoc.cs
├── UcThanhToan.cs
├── UcQuanLyThuoc.cs
├── UcCanhBaoHetHan.cs
├── UcPhieuDuTru.cs
├── UcThongKe.cs
└── UcTaiKhoan.cs
```

## 3. Các màn hình

### 3.1. Đăng nhập

Thành phần:

- TextBox tên đăng nhập
- TextBox mật khẩu
- Button đăng nhập
- Label báo lỗi

Luồng xử lý:

1. Kiểm tra dữ liệu rỗng.
2. Kiểm tra tài khoản trong MySQL.
3. Lưu thông tin người dùng đang đăng nhập.
4. Mở `FrmMain`.
5. Hiển thị menu theo vai trò.

### 3.2. Trang chủ

Hiển thị:

- Tổng số thuốc
- Số thuốc sắp hết hạn
- Số đơn thuốc trong ngày
- Doanh thu trong ngày
- Danh sách thuốc sắp hết hạn

### 3.3. Kê đơn

Dành cho bác sĩ.

Chức năng:

- Chọn bệnh nhân
- Nhập chẩn đoán
- Chọn loại đơn điện tử hoặc đơn giấy
- Thêm thuốc vào đơn
- Nhập số lượng và cách dùng
- Lưu đơn

### 3.4. Tiếp nhận đơn

Dành cho dược sĩ.

Chức năng:

- Tìm kiếm theo mã đơn hoặc bệnh nhân
- Xem danh sách đơn
- Xem chi tiết
- Chuyển trạng thái sang đã tiếp nhận

### 3.5. Kiểm tra tồn kho

Chức năng:

- Tìm thuốc
- Xem số lượng tồn
- Xem hạn sử dụng
- Hiển thị trạng thái còn hàng, sắp hết, hết hàng hoặc sắp hết hạn

### 3.6. Xuất thuốc và lập hóa đơn

Chức năng:

- Tải thông tin từ đơn thuốc
- Kiểm tra tồn kho
- Chọn số lượng thực tế xuất
- Tính tạm tính
- Áp dụng giảm BHYT
- Tạo hóa đơn
- Trừ tồn kho
- Cập nhật trạng thái đơn

Toàn bộ thao tác phải chạy trong một transaction MySQL để tránh sai lệch dữ liệu.

### 3.7. Thanh toán

Chức năng:

- Hiển thị thông tin hóa đơn
- Chọn phương thức thanh toán
- Nhập tiền khách đưa
- Tính tiền thừa
- Xác nhận thanh toán
- In hóa đơn

### 3.8. Quản lý thuốc

Chức năng:

- Xem danh sách
- Tìm kiếm
- Thêm
- Sửa
- Xóa mềm
- Làm mới dữ liệu

Dữ liệu chính:

- Mã thuốc
- Tên thuốc
- Đơn vị
- Giá bán
- Số lượng tồn
- Hạn sử dụng
- Thuộc BHYT hay không
- Trạng thái

### 3.9. Cảnh báo hết hạn

Truy vấn thuốc có hạn sử dụng trong vòng 30 ngày.

Chức năng:

- Xem danh sách thuốc sắp hết hạn
- Lọc theo số ngày còn lại
- Xuất Excel nếu còn thời gian thực hiện

### 3.10. Phiếu dự trù

Chức năng:

- Lập phiếu
- Thêm thuốc
- Nhập số lượng đề nghị
- Lưu phiếu
- Gửi duyệt
- Cập nhật số lượng được duyệt

### 3.11. Thống kê doanh thu

Chức năng:

- Chọn khoảng ngày
- Xem số lượng hóa đơn
- Xem tổng doanh thu
- Xem doanh thu theo ngày
- Xuất Excel nếu còn thời gian thực hiện

### 3.12. Quản lý tài khoản

Dành cho quản trị viên.

Chức năng:

- Thêm tài khoản
- Sửa tài khoản
- Khóa hoặc mở tài khoản
- Gán vai trò
- Đặt lại mật khẩu

## 4. Vai trò và quyền

Các vai trò:

- `DOCTOR`
- `PHARMACIST`
- `ACCOUNTANT`
- `WAREHOUSE`
- `ADMIN`
- `PATIENT`

| Vai trò | Chức năng chính |
|---|---|
| DOCTOR | Kê đơn, xem đơn |
| PHARMACIST | Tiếp nhận đơn, kiểm tra tồn, xuất thuốc |
| ACCOUNTANT | Hóa đơn, thanh toán, thống kê |
| WAREHOUSE | Quản lý thuốc, phiếu dự trù, cảnh báo |
| ADMIN | Quản lý tài khoản và toàn bộ danh mục |
| PATIENT | Xem đơn thuốc và hóa đơn của bản thân |

## 5. Cấu trúc chương trình

```text
QuanLyQuayThuoc
├── Forms
├── UserControls
├── Models
├── Repositories
├── Services
├── Helpers
├── Database
└── Program.cs
```

Trách nhiệm:

- `Models`: ánh xạ dữ liệu.
- `Repositories`: truy vấn MySQL.
- `Services`: xử lý nghiệp vụ.
- `Forms` và `UserControls`: giao diện.
- `Helpers`: định dạng tiền, kiểm tra dữ liệu, phiên đăng nhập.
- `Database`: lớp tạo kết nối MySQL.

## 6. Luồng dữ liệu

```text
Giao diện
   ↓
Service
   ↓
Repository
   ↓
MySQL
```

Giao diện không viết trực tiếp câu lệnh SQL. Mỗi lớp chỉ giữ một trách nhiệm để dễ sửa lỗi và trình bày đồ án.

## 7. Xử lý lỗi

- Không cho lưu khi thiếu trường bắt buộc.
- Không cho xuất số lượng lớn hơn tồn kho.
- Không cho thanh toán hóa đơn đã thanh toán.
- Hiển thị thông báo thân thiện bằng `MessageBox`.
- Bắt lỗi kết nối MySQL.
- Rollback transaction nếu xuất thuốc hoặc lập hóa đơn thất bại.
- Không hiển thị mật khẩu trong giao diện.

## 8. Kiểm thử tối thiểu

1. Đăng nhập đúng và sai.
2. Thêm thuốc với dữ liệu hợp lệ và không hợp lệ.
3. Kê đơn nhiều thuốc.
4. Xuất thuốc đủ tồn kho.
5. Từ chối xuất thuốc khi thiếu tồn kho.
6. Tính giảm BHYT.
7. Thanh toán và tính tiền thừa.
8. Cảnh báo thuốc hết hạn trong 30 ngày.
9. Phân quyền menu theo vai trò.
10. Thống kê đúng theo khoảng ngày.

## 9. Phạm vi không thực hiện

- Đồng bộ với hệ thống bệnh viện thật
- Chữ ký số
- Quản lý nhiều chi nhánh
- Quản lý chi tiết từng lô thuốc
- Phân quyền động theo từng quyền nhỏ
- Thanh toán trực tuyến thật
- Gửi SMS hoặc email
- API bên ngoài

## 10. Tiêu chí hoàn thành

Ứng dụng được coi là hoàn thành khi:

- Kết nối MySQL thành công.
- Đăng nhập và phân quyền hoạt động.
- Quản lý thuốc hoạt động.
- Kê và tiếp nhận đơn hoạt động.
- Xuất thuốc làm giảm tồn kho.
- Hóa đơn và thanh toán hoạt động.
- Cảnh báo hết hạn hoạt động.
- Phiếu dự trù hoạt động.
- Thống kê doanh thu hoạt động.
- Giao diện thống nhất, dễ sử dụng và không lỗi nghiêm trọng.