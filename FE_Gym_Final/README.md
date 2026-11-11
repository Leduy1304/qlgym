# HƯỚNG DẪN FRONTEND WINFORMS (FE)

Thư mục này chứa toàn bộ mã nguồn ứng dụng WinForms Client (.NET 10.0 Windows Forms).

## Cấu trúc thư mục

- `Gym_Management/`: Dự án WinForms
  - `Form1.cs` / `Form1.Designer.cs`: Màn hình giao diện chính (Dashboard hiện đại, phân quyền rõ ràng theo từng vai trò: Admin, Hội viên, Huấn luyện viên).
  - `Login.cs`: Màn hình Đăng nhập (hỗ trợ xác thực qua API Backend, lưu phiên làm việc).
  - `RegisterForm.cs`: Màn hình Đăng ký tài khoản Hội viên / Huấn luyện viên (bỏ qua nhập gói tập và giờ tập lúc đăng ký, để người dùng lựa chọn sau khi đăng nhập).
  - `DangKyGoiTapForm.cs`: Màn hình cho phép Hội viên lựa chọn gói tập & khung giờ tập sau khi đã đăng nhập vào hệ thống.
  - `NewMember.cs`, `SearchMember.cs`, `DeleteMember.cs`: Các chức năng quản lý hội viên (dành riêng cho Quản trị viên).
  - `NewPT.cs`, `SearchPT.cs`, `DeletePT.cs`: Các chức năng quản lý Huấn luyện viên cá nhân (dành riêng cho Quản trị viên).
  - `Equipment.cs`: Quản lý & xem danh sách trang thiết bị phòng tập.
  - `ApiClient.cs`: Gọi HTTP Client kết nối tới Backend API (`http://localhost:5000`).
  - `DatabaseHelper.cs`: Kết nối trực tiếp cơ sở dữ liệu SQL Server `gym`.
  - `PhienDangNhap.cs`: Lưu thông tin tài khoản hiện tại (Token, Tên đăng nhập, Vai trò, ID hội viên/PT).
- `Gym_Management.slnx`: Solution mở trực tiếp trên Visual Studio.

## Cách chạy WinForms

1. **Khởi động Backend trước**: Xem hướng dẫn tại thư mục `BE/` để khởi động API ở `http://localhost:5000`.
2. **Khởi động WinForms**:
   - Mở file `Gym_Management.slnx` bằng Visual Studio và bấm **F5**.
   - Hoặc chạy lệnh trong terminal:
     ```bash
     dotnet run --project Gym_Management/Gym_Management.csproj
     ```

