# GIẢI THÍCH NHANH CÁC FORM CÒN LẠI — GYM MANAGEMENT

*Tiếp nối phần Equipment đã hỏi: cả 3 form Search Member, Delete Member và
Equipment đều có chung một kiểu bảng DataGridView — hiểu 1 cái là hiểu cả 3.*

## Điểm chung của các bảng danh sách (DataGridView)

- Mỗi bảng là "gương soi" của đúng 1 bảng trong database: mở form lên là chương
  trình tự chạy `SELECT * FROM <bảng đó>` rồi đổ dữ liệu lên lưới
  (hàm `LoadEquipment()` / `LoadAllMembers()`).
- Sau mỗi lần LƯU hoặc XÓA thành công, chương trình tự gọi lại hàm tải đó,
  nên lưới luôn là dữ liệu mới nhất — thấy dòng mới hiện ra = đã lưu thật
  vào SQL Server.
- Cột đầu tiên (MID / SID / EID) là khóa chính tự tăng của SQL Server,
  chương trình không tự gõ số này.

## Search Member — chỉ để XEM / TÌM, không sửa không xóa

- Mở lên: hiện toàn bộ hội viên + dòng chữ dưới cùng "Tổng số hội viên: ..."
  (biến `lblCount`, đếm bằng `Rows.Count` của bảng vừa tải).
- Nhập MID vào ô tìm kiếm → bấm TÌM KIẾM (hoặc Enter): chạy lệnh
  `SELECT * FROM NewMember WHERE MID = @MID` nên lưới chỉ còn đúng 1 người.
  Để trống ô rồi tìm = hiện lại toàn bộ.
- Nhập chữ thay vì số → báo "Mã hội viên không hợp lệ". Nhập mã không có
  → báo "Không tìm thấy hội viên có mã ...".
- Nút HIỂN THỊ TẤT CẢ: xóa ô nhập và tải lại toàn bộ danh sách.

## Delete Member — cùng cái lưới, nhưng thêm bước KIỂM TRA trước khi XÓA

- Cái lưới ở đây để đối chiếu trước khi xóa, không phải để xem chơi.
- Nhấn đúp (double-click) vào 1 dòng → MID của dòng đó tự điền lên ô nhập
  (sự kiện `dataGridView1_CellDoubleClick`).
- Bấm KIỂM TRA: lưới lọc còn đúng hội viên sắp xóa để nhìn lại cho chắc.
- Bấm XÓA: chương trình làm 3 bước — (1) kiểm tra MID có tồn tại không và
  lấy Họ Tên, (2) hiện hộp hỏi xác nhận kèm đúng tên người đó, bấm No là
  hủy, không xóa gì, (3) bấm Yes mới chạy `DELETE FROM NewMember WHERE
  MID = @MID`, xóa xong lưới tự tải lại.
- Khác Search ở 1 điểm dễ bị hỏi: Search chỉ đọc (SELECT), Delete có
  thêm DELETE và bước xác nhận, vì xóa rồi không khôi phục được.

## New Staff — không có lưới, vì sao?

- Form này chỉ có phần nhập + LƯU/RESET giống hệt New Member, lưu vào
  bảng `NewStaff` (khóa chính SID). Bản gốc của bài không yêu cầu xem
  danh sách nhân viên nên không gắn DataGridView; muốn xem nhân viên
  đã thêm thì mở bảng `NewStaff` trong SSMS là thấy.

## 3 câu dễ bị hỏi — trả lời ngắn

1. **Sao Search và Delete đều tìm theo MID mà không tìm theo tên?**
   Tên có thể trùng nhau, MID là khóa chính, không bao giờ trùng,
   nên tìm/xóa theo MID là chính xác tuyệt đối.
2. ** `@MID`, `@Fname`... là gì?** Là tham số (SqlParameter): dữ liệu
   người dùng nhập được truyền riêng, không cộng thẳng vào câu SQL —
   tránh lỗi khi tên có dấu nháy đơn và tránh SQL Injection.
3. **Đăng nhập admin/12345 nằm ở đâu, có lưu trong database không?**
   Không lưu database — khai báo cứng 2 hằng số ở đầu file `Login.cs`.
   Đăng nhập đúng thì `Program.cs` mở Form1; Log Out đóng Form1 và
   quay lại Login (cờ `IsLogout`), Exit thì kết thúc chương trình.

## Sau khi test xong vòng xóa (Delete MID của hội viên test)

Danh sách sẽ trống lại như lúc mới tạo DB. Muốn có sẵn dữ liệu đẹp để
demo/nộp bài mà không phải gõ tay từng người, chạy file
`du_lieu_mau.sql` trong thư mục này (SSMS → Execute): nó thêm sẵn
3 hội viên, 2 nhân viên, 3 thiết bị — chạy lại nhiều lần không trùng,
và mã MID/SID/EID thực tế cứ nhìn trong form Search Member là đúng nhất.
