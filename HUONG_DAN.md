# GYM MANAGEMENT — HƯỚNG DẪN SỬ DỤNG BẢN HOÀN CHỈNH

Bản này giữ nguyên 100% phần Duy đã làm (form **NewMember**, giao diện form chính **Form1**)
và làm nốt các chức năng còn thiếu: **New Staff, Equipment, Search Member, Delete Member,
Log Out, Exit** — kèm theo form **Đăng nhập (Login)** để nút Log Out có ý nghĩa.


---

## 1. Các bước chạy (làm đúng thứ tự)

**Bước 1 — Tạo 2 bảng mới trong database:**
Mở SQL Server Management Studio (SSMS) → mở file `gym_database.sql` trong thư mục này
→ bấm **Execute (F5)**.
Script tự tạo 2 bảng mới `NewStaff` và `Equipment` (bảng `NewMember` đã có thì giữ nguyên,
không mất dữ liệu cũ). Chạy lại nhiều lần vẫn an toàn.

**Bước 2 — Mở project:**
Mở Visual Studio → Open → chọn file `Gym_Management.slnx` (hoặc
`Gym_Management/Gym_Management.csproj`) → bấm **F5 / Start** để chạy.

**Bước 3 — Đăng nhập:**
- Tài khoản: `admin`
- Mật khẩu: `12345`
(Muốn đổi: mở file `Gym_Management/Login.cs`, sửa 2 dòng `AdminUsername` / `AdminPassword`
ở đầu file.)

---

## 2. Từng chức năng đã làm

| Menu | Form | Cách hoạt động |
|---|---|---|
| NEW MEMBER | `NewMember.cs` | Form đăng ký hội viên mới: nhập Họ, Tên, Giới tính (chọn Nam/Nữ), Ngày sinh, SĐT, Email, Ngày Đăng Ký (2 mục ngày chọn bằng lịch), Thời gian tập (chọn sẵn: 06AM-07AM, 07AM-08AM, 08AM-09AM, 05PM-06PM, 06PM-07PM, 07PM-08PM), Địa chỉ, Các gói tập (1 tháng, 2 tháng, 3 tháng, 6 tháng, 1 năm) + nút LƯU / RESET. Bấm LƯU thì kiểm tra 3 lớp trước: để trống mục nào → báo lỗi; email thiếu @ → báo lỗi; SĐT sai định dạng (phải đúng 10 chữ số và bắt đầu bằng số 0) → báo lỗi. Đạt hết mới lưu vào bảng NewMember bằng tham số (@...) nên giữ đúng dấu tiếng Việt và số 0 đầu của SĐT, ngày tháng lưu đúng kiểu DATE; lưu xong báo "Lưu thành công". Nút RESET xóa trắng mọi ô nhập, trả 2 ô ngày về hôm nay, bỏ chọn giới tính / giờ tập / gói tập |
| NEW STAFF | `NewStaff.cs` | Giống hệt phong cách NewMember: Họ, Tên, Giới tính (Nam/Nữ), Ngày sinh, SĐT, Email, Ngày vào làm, Địa chỉ + nút LƯU / RESET. Có đủ 3 lớp kiểm tra: để trống → báo lỗi; email thiếu `@` → báo lỗi; SĐT có chữ → báo lỗi. Lưu vào bảng `NewStaff` |
| EQUIPMENT | `Equipment.cs` | Nhập Tên thiết bị, Mô tả, Nhóm cơ sử dụng, Giá tiền, Số lượng, Ngày mua → LƯU vào bảng `Equipment`. Bên phải có sẵn **danh sách thiết bị** (tự tải khi mở form và sau mỗi lần lưu) + nút **XÓA THIẾT BỊ ĐÃ CHỌN** (chọn 1 dòng trên danh sách rồi bấm, có hỏi xác nhận) |
| SEARCH MEMBER | `SearchMember.cs` | Mở form là thấy **toàn bộ hội viên** + tổng số ở góc dưới. Nhập **Mã hội viên (MID)** → bấm TÌM KIẾM (hoặc nhấn Enter) để xem đúng hội viên đó; không có mã đó thì báo "Không tìm thấy". Bấm HIỂN THỊ TẤT CẢ để xem lại toàn bộ |
| DELETE MEMBER | `DeleteMember.cs` | Nhập **Mã hội viên (MID)** → KIỂM TRA để xem trước đúng hội viên đó → bấm XÓA: chương trình hiện tên hội viên và hỏi xác nhận Yes/No rồi mới xóa thật trong bảng `NewMember`, xóa xong danh sách tự tải lại. Mẹo: **nhấn đúp** vào 1 dòng trong danh sách để tự điền mã |
| SEARCH STAFF | `SearchStaff.cs` | Bản sao của Search Member nhưng cho bảng `NewStaff`: mở lên thấy toàn bộ nhân viên + tổng số, nhập **Mã nhân viên (SID)** để tìm đúng 1 người, lưới màu cam + đầu cột tiếng Việt (Mã NV, Họ, Tên, Giới tính, Ngày sinh, SDT, Email, Ngày vào làm, Địa chỉ) |
| DELETE STAFF | `DeleteStaff.cs` | Bản sao của Delete Member nhưng cho bảng `NewStaff`: nhập SID → KIỂM TRA xem trước → XÓA có hỏi xác nhận kèm Họ Tên nhân viên; **nhấn đúp** vào 1 dòng để tự điền mã. Menu chính đã có thêm 2 mục **SEARCH STAFF** và **DELETE STAFF** (icon dùng lại của bản Member) |
| LOG OUT | trong `Form1.cs` | Hỏi xác nhận → đóng form chính → **quay lại màn hình Đăng nhập** |
| EXIT | trong `Form1.cs` | Hỏi xác nhận → **thoát hẳn chương trình** |

## 3. Điểm kỹ thuật đáng chú ý

- **MID là gì?** MID là mã hội viên — khóa chính của bảng `NewMember`, SQL Server tự tăng
  (1, 2, 3...) mỗi khi thêm hội viên mới. Search/Delete đều tìm theo MID vì MID không bao giờ trùng.
- **Chuỗi kết nối để ở đâu?** Các form mới dùng chung 1 chỗ duy nhất trong file
  `DatabaseHelper.cs`. Nếu đổi máy/đổi tên SQL Server thì chỉ sửa ở đó
  (riêng form NewMember cũ của Duy vẫn giữ chuỗi kết nối viết ngay trong `NewMember.cs` như ban đầu).
- **Vì sao code mới dùng `@thamso` (SqlParameter) thay vì cộng chuỗi như NewMember?**
  Cộng chuỗi sẽ lỗi ngay khi Họ/Tên/Địa chỉ có dấu nháy đơn `'` và dễ bị SQL Injection.
  Dùng tham số thì an toàn và không lỗi. Ngoài ra ngày tháng được truyền đúng kiểu `DATE`
  và SĐT truyền dạng chữ nên **giữ được số 0 ở đầu** (bảng đang là VARCHAR(20)).
- **Luồng Đăng nhập / Đăng xuất để ở đâu?** Ở `Program.cs`: mở Login → đúng thì vào Form1 →
  Log Out thì quay lại Login, Exit thì kết thúc vòng lặp và thoát app. Form1 dùng cờ
  `IsLogout` để báo cho Program biết người dùng vừa chọn Log Out hay Exit.
- Mọi thao tác database ở form mới đều có `try/catch`: nếu SQL Server chưa bật hoặc bảng
  chưa tạo thì hiện thông báo lỗi tiếng Việt dễ hiểu thay vì văng chương trình.

## 4. Hai lưu ý nhỏ

1. Form chính (Form1) có đoạn nạp ảnh từ đường dẫn tuyệt đối
   `D:\Mẫu Thiết Kế Phần Mềm\Image\gym\...` — đã bọc thêm `try/catch`: nếu máy khác không có
   thư mục ảnh đó thì menu vẫn đổi vị trí bình thường, chương trình không bị lỗi nữa.
   Trên máy của Duy (có sẵn thư mục ảnh) thì mọi thứ chạy y như cũ.
2. File SQL gốc `newmembergym.sql` Duy gửi có 1 dòng bắt đầu bằng `//` — đó không phải
   cú pháp chú thích của SQL Server (phải là `--`), nếu Execute cả file sẽ báo lỗi ở dòng đó.
   File `gym_database.sql` trong bản này đã viết đúng chuẩn và bao luôn phần việc đó,
   nên chỉ cần chạy file mới này.
