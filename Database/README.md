# HƯỚNG DẪN CƠ SỞ DỮ LIỆU (DATABASE)

Thư mục này chứa toàn bộ các script SQL phục vụ cho hệ thống Gym Management.

## Danh sách các file Script SQL

1. **`gym_database.sql`** (Script chính):
   - Tạo database `gym` (nếu chưa có).
   - Tạo 3 bảng chính cho ứng dụng WinForms:
     - `NewMember`: Lưu trữ thông tin hội viên (Mã HV, Họ, Tên, Giới tính, Ngày sinh, SĐT, Email, Ngày tham gia, Giờ tập, Địa chỉ, Gói tập).
     - `NewPT`: Lưu trữ thông tin huấn luyện viên cá nhân (Mã HLV, Họ, Tên, Giới tính, Ngày sinh, SĐT, Email, Ngày tham gia, Địa chỉ).
     - `Equipment`: Lưu trữ trang thiết bị phòng tập (Mã thiết bị, Tên thiết bị, Mô tả, Nhóm cơ tác động, Ngày mua, Giá tiền).

2. **`du_lieu_mau.sql`**:
   - Chứa dữ liệu mẫu tiếng Việt chuẩn cho Hội viên, Huấn luyện viên (PT) và Thiết bị để thử nghiệm ứng dụng ngay lập tức mà không cần nhập tay từ đầu.

3. **`chi_them_2_bang.sql`**:
   - Dùng khi đã có sẵn bảng `NewMember` cũ và chỉ muốn bổ sung thêm 2 bảng `NewPT` và `Equipment`.

4. **`doi_bang_NewStaff_thanh_NewPT.sql`**:
   - Dùng khi nâng cấp từ phiên bản cũ (sử dụng tên bảng `NewStaff`) sang phiên bản chuẩn (`NewPT`).

5. **`newmembergym_goc_cua_Duy.sql`**:
   - File backup script gốc ban đầu để đối chiếu khi cần.

---

## Hướng dẫn cài đặt Database trong SQL Server Management Studio (SSMS)

1. Mở **SQL Server Management Studio (SSMS)** và kết nối tới SQL Server của bạn (ví dụ `DESKTOP-6R52ARN\SQLEXPRESS` hoặc `.\SQLEXPRESS` hoặc `localhost`).
2. Mở file **`gym_database.sql`** -> Bấm **Execute** (hoặc phím **F5**) để tạo database `gym` và các bảng.
3. Mở tiếp file **`du_lieu_mau.sql`** -> Bấm **Execute** (F5) để nạp dữ liệu mẫu ban đầu.
4. Kiểm tra chuỗi kết nối trong file:
   - `FE\Gym_Management\DatabaseHelper.cs` (cho WinForms)
   - `BE\GymManagement.Api\appsettings.json` (cho Backend API)
   Đảm bảo tên server SQL Server trùng với máy tính của bạn.

