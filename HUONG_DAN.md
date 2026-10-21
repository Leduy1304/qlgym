# GYM MANAGEMENT — HƯỚNG DẪN SỬ DỤNG BẢN HOÀN CHỈNH

Bản này giữ nguyên 100% phần Duy đã làm (form **NewMember**, giao diện form chính **Form1**)
và làm nốt các chức năng còn thiếu: **New PT, Equipment, Search Member, Delete Member,
Log Out, Exit** — kèm theo form **Đăng nhập (Login)** để nút Log Out có ý nghĩa.

Đã kiểm tra biên dịch toàn bộ project: **0 lỗi**.

> **Bản PT (cập nhật 21/10/2026):** Toàn bộ phần **Staff (nhân viên)** của bản cũ đã đổi sang
> **PT (huấn luyện viên)**: form `NewStaff / SearchStaff / DeleteStaff` → `NewPT / SearchPT / DeletePT`,
> menu `NEW / SEARCH / DELETE STAFF` → `NEW / SEARCH / DELETE PT`, bảng `NewStaff` → `NewPT`,
> mã `SID` → `PID`, cột địa chỉ `Saddress` → `Paddress`, đầu cột "Mã NV" → "Mã PT".
> Các trường còn lại (Họ, Tên, Giới tính, Ngày sinh, SĐT, Email, Ngày vào làm, Địa chỉ) giữ nguyên.

---

## 1. Các bước chạy (làm đúng thứ tự)

**Bước 1 — Tạo 2 bảng mới trong database:**
Mở SQL Server Management Studio (SSMS) → mở file `gym_database.sql` trong thư mục này
→ bấm **Execute (F5)**.
Script tự tạo 2 bảng mới `NewPT` và `Equipment` (bảng `NewMember` đã có thì giữ nguyên,
không mất dữ liệu cũ). Chạy lại nhiều lần vẫn an toàn.

⚠️ **Nếu máy đã có bảng `NewStaff` của bản cũ:** chạy file
`doi_bang_NewStaff_thanh_NewPT.sql` **trước** (chỉ 1 lần) để đổi tên bảng cũ thành
`NewPT` mà **giữ nguyên dữ liệu đã nhập**, rồi mới chạy `gym_database.sql`.
Nếu bỏ qua bước này, `gym_database.sql` sẽ tạo thêm 1 bảng `NewPT` mới trống và
dữ liệu PT cũ vẫn nằm ở bảng `NewStaff` (app bản mới không đọc bảng đó nữa).

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
| NEW MEMBER | `NewMember.cs` | **Giữ nguyên của Duy** — không sửa gì |
| NEW PT | `NewPT.cs` | Giống hệt phong cách NewMember: Họ, Tên, Giới tính (Nam/Nữ), Ngày sinh, SĐT, Email, Ngày vào làm, Địa chỉ + nút LƯU / RESET. Có đủ 3 lớp kiểm tra: để trống → báo lỗi; email thiếu `@` → báo lỗi; SĐT có chữ → báo lỗi. Lưu vào bảng `NewPT` |
| EQUIPMENT | `Equipment.cs` | Nhập Tên thiết bị, Mô tả, Nhóm cơ sử dụng, Giá tiền, Số lượng, Ngày mua → LƯU vào bảng `Equipment`. Bên phải có sẵn **danh sách thiết bị** (tự tải khi mở form và sau mỗi lần lưu) + nút **XÓA THIẾT BỊ ĐÃ CHỌN** (chọn 1 dòng trên danh sách rồi bấm, có hỏi xác nhận) |
| SEARCH MEMBER | `SearchMember.cs` | Mở form là thấy **toàn bộ hội viên** + tổng số ở góc dưới. Nhập **Mã hội viên (MID)** → bấm TÌM KIẾM (hoặc nhấn Enter) để xem đúng hội viên đó; không có mã đó thì báo "Không tìm thấy". Bấm HIỂN THỊ TẤT CẢ để xem lại toàn bộ |
| DELETE MEMBER | `DeleteMember.cs` | Nhập **Mã hội viên (MID)** → KIỂM TRA để xem trước đúng hội viên đó → bấm XÓA: chương trình hiện tên hội viên và hỏi xác nhận Yes/No rồi mới xóa thật trong bảng `NewMember`, xóa xong danh sách tự tải lại. Mẹo: **nhấn đúp** vào 1 dòng trong danh sách để tự điền mã |
| SEARCH PT | `SearchPT.cs` | Bản sao của Search Member nhưng cho bảng `NewPT`: mở lên thấy toàn bộ PT + tổng số, nhập **Mã PT (PID)** để tìm đúng 1 người, lưới màu cam + đầu cột tiếng Việt (Mã PT, Họ, Tên, Giới tính, Ngày sinh, SDT, Email, Ngày vào làm, Địa chỉ) |
| DELETE PT | `DeletePT.cs` | Bản sao của Delete Member nhưng cho bảng `NewPT`: nhập PID → KIỂM TRA xem trước → XÓA có hỏi xác nhận kèm Họ Tên PT; **nhấn đúp** vào 1 dòng để tự điền mã. Menu chính đã có thêm 2 mục **SEARCH PT** và **DELETE PT** (icon dùng lại của bản Member) |
| LOG OUT | trong `Form1.cs` | Hỏi xác nhận → đóng form chính → **quay lại màn hình Đăng nhập** |
| EXIT | trong `Form1.cs` | Hỏi xác nhận → **thoát hẳn chương trình** |

## 3. Điểm kỹ thuật đáng chú ý (để trả lời khi thầy cô hỏi)

- **MID là gì?** MID là mã hội viên — khóa chính của bảng `NewMember`, SQL Server tự tăng
  (1, 2, 3...) mỗi khi thêm hội viên mới. Search/Delete đều tìm theo MID vì MID không bao giờ trùng.
- **PID là gì?** PID là mã PT (huấn luyện viên) — khóa chính của bảng `NewPT`, cũng tự tăng
  như MID. Search/Delete PT tìm theo PID. (Bản cũ gọi phần này là Staff/nhân viên với mã SID,
  bản này đã đổi hẳn sang PT vì Staff là nhân viên nói chung, không phải huấn luyện viên.)
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
