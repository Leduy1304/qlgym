# Gym Management — Phần mềm quản lý phòng gym (Anh Tú Gym)

Ứng dụng Windows Forms (C#) quản lý phòng gym: quản lý hội viên, huấn luyện viên và thiết bị,
dữ liệu lưu trong SQL Server.

## Công nghệ sử dụng
- C# Windows Forms (.NET 10)
- SQL Server Express + Microsoft.Data.SqlClient
- Visual Studio

## Chức năng chính
- **Đăng nhập / Đăng xuất / Thoát** (tài khoản mẫu: `admin` / `12345`)
- **New Member** — đăng ký hội viên mới, có kiểm tra dữ liệu nhập (ô trống, email, SĐT 10 số)
- **New PT** — thêm huấn luyện viên mới
- **Equipment** — quản lý thiết bị: thêm mới, xem danh sách, xóa thiết bị đã chọn
- **Search Member / Search PT** — xem toàn bộ danh sách và tìm kiếm theo mã (MID / SID)
- **Delete Member / Delete PT** — xóa theo mã, kiểm tra trước và hỏi xác nhận kèm Họ Tên

## Cách chạy chương trình
1. Mở SQL Server Management Studio (SSMS), chạy file `gym_database.sql` để tạo database `gym` và 3 bảng dữ liệu
2. Mở file `Gym_Management.slnx` bằng Visual Studio
3. Nhấn **F5** để chạy và đăng nhập

> Hướng dẫn chi tiết từng chức năng: xem file [HUONG_DAN.md](HUONG_DAN.md)

## Cấu trúc thư mục
- `Gym_Management/` — toàn bộ mã nguồn (các form + `DatabaseHelper.cs`)
- `gym_database.sql` — script tạo database đầy đủ
- `du_lieu_mau.sql` — dữ liệu mẫu để test nhanh
- `HUONG_DAN.md` — tài liệu hướng dẫn sử dụng chi tiết

## Nhóm thực hiện
Nhóm 03
