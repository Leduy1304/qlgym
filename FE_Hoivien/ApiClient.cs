using System.Net.Http.Json;
using System.Text.Json;

namespace Gym_Management
{
    // Kết quả đăng nhập, tách riêng 3 trường hợp để Login.cs xử lý đúng:
    // - ThanhCong: BE trả về token.
    // - SaiThongTin: BE đã chạy và trả về 401 (sai tài khoản/mật khẩu).
    // - KhongKetNoiDuoc: BE chưa chạy / sai địa chỉ. Lúc này Login.cs
    //   mới được phép dùng tài khoản admin mặc định cũ làm fallback.
    //   Khi BE đã chạy thì KHÔNG dùng fallback, tránh bypass mật khẩu mới.
    public enum KetQuaDangNhap
    {
        ThanhCong,
        SaiThongTin,
        KhongKetNoiDuoc
    }

    public record DangNhapKetQua(
        string Token,
        string TenDangNhap,
        string VaiTro,
        int? HoiVienId,
        int? PTId);

    public record HoiVienHoSoDto(
        int Id,
        string Fname,
        string Lname,
        string? Gender,
        DateOnly? Dob,
        string Mobile,
        string? Email,
        DateOnly? JoinDate,
        string? Gymtime,
        string? Maddress,
        string? MembershipTime);

    // Client gọi BE (GymManagement.Api). BE phải đang chạy trước thì
    // Đăng ký / Đăng nhập bằng tài khoản Hội viên, PT mới hoạt động.
    // Địa chỉ mặc định là profile "http" trong launchSettings.json của BE
    // (http://localhost:5000). Nếu bạn chạy BE bằng profile "https"
    // thì đổi BaseUrl thành https://localhost:5001.
    public static class ApiClient
    {
        public const string BaseUrl = "http://localhost:5000";

        private static readonly HttpClient _http = new()
        {
            BaseAddress = new Uri(BaseUrl),
            Timeout = TimeSpan.FromSeconds(10)
        };

        private static readonly JsonSerializerOptions _jsonOptions = new()
        {
            PropertyNameCaseInsensitive = true
        };

        public static async Task<(KetQuaDangNhap TrangThai, DangNhapKetQua? KetQua, string? Loi)>
            DangNhapAsync(string tenDangNhap, string matKhau)
        {
            try
            {
                using var resp = await _http.PostAsJsonAsync("/api/auth/dang-nhap",
                    new { TenDangNhap = tenDangNhap, MatKhau = matKhau });
                if (resp.IsSuccessStatusCode)
                {
                    var kq = await resp.Content.ReadFromJsonAsync<DangNhapKetQua>(_jsonOptions);
                    if (kq == null)
                        return (KetQuaDangNhap.SaiThongTin, null, "BE trả về dữ liệu trống.");
                    return (KetQuaDangNhap.ThanhCong, kq, null);
                }
                var loi = await DocLoiAsync(resp);
                return (KetQuaDangNhap.SaiThongTin, null, loi);
            }
            catch (HttpRequestException)
            {
                return (KetQuaDangNhap.KhongKetNoiDuoc, null,
                    "Không kết nối được BE. Hãy chạy BE trước (dotnet run --project GymManagement.Api).");
            }
            catch (TaskCanceledException)
            {
                return (KetQuaDangNhap.KhongKetNoiDuoc, null,
                    "BE phản hồi quá chậm hoặc chưa chạy. Hãy chạy BE trước rồi thử lại.");
            }
        }

        public static async Task<(bool Ok, string? Loi)> DangKyHoiVienAsync(
            string tenDangNhap, string matKhau,
            string fname, string lname, string gender, DateOnly dob,
            string mobile, string email, string gymtime, string maddress,
            string membershipTime)
        {
            return await DangKyAsync("/api/auth/dang-ky-hoi-vien", new
            {
                TenDangNhap = tenDangNhap,
                MatKhau = matKhau,
                Fname = fname,
                Lname = lname,
                Gender = gender,
                Dob = dob,
                Mobile = mobile,
                Email = email,
                Gymtime = gymtime,
                Maddress = maddress,
                MembershipTime = membershipTime
            });
        }

        public static async Task<(bool Ok, string? Loi)> DangKyPTAsync(
            string tenDangNhap, string matKhau,
            string fname, string lname, string gender, DateOnly dob,
            string mobile, string email, string paddress)
        {
            return await DangKyAsync("/api/auth/dang-ky-pt", new
            {
                TenDangNhap = tenDangNhap,
                MatKhau = matKhau,
                Fname = fname,
                Lname = lname,
                Gender = gender,
                Dob = dob,
                Mobile = mobile,
                Email = email,
                Paddress = paddress
            });
        }

        // Đăng ký gói tập và giờ tập cho Hội viên (sau khi đăng nhập)
        public static async Task<(bool Ok, string? Loi)> DangKyGoiVaGioTapAsync(string goiTap, string gioTap)
        {
            if (string.IsNullOrEmpty(PhienDangNhap.Token))
                return (false, "Chưa có mã phiên đăng nhập BE.");

            try
            {
                using var request = new HttpRequestMessage(HttpMethod.Put, "/api/hoi-vien/dang-ky-goi-va-gio-tap");
                request.Headers.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", PhienDangNhap.Token);
                request.Content = JsonContent.Create(new { GoiTap = goiTap, GioTap = gioTap });

                using var resp = await _http.SendAsync(request);
                if (resp.IsSuccessStatusCode)
                    return (true, null);

                return (false, await DocLoiAsync(resp));
            }
            catch (Exception ex)
            {
                return (false, "Lỗi kết nối tới BE: " + ex.Message);
            }
        }

        // Lấy thông tin hồ sơ của Hội viên đang đăng nhập
        public static async Task<(bool Ok, HoiVienHoSoDto? HoSo, string? Loi)> LayHoSoHoiVienAsync()
        {
            if (string.IsNullOrEmpty(PhienDangNhap.Token))
                return (false, null, "Chưa có mã phiên đăng nhập BE.");

            try
            {
                using var request = new HttpRequestMessage(HttpMethod.Get, "/api/hoi-vien/ho-so");
                request.Headers.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", PhienDangNhap.Token);

                using var resp = await _http.SendAsync(request);
                if (resp.IsSuccessStatusCode)
                {
                    var data = await resp.Content.ReadFromJsonAsync<HoiVienHoSoDto>(_jsonOptions);
                    return (true, data, null);
                }

                return (false, null, await DocLoiAsync(resp));
            }
            catch (Exception ex)
            {
                return (false, null, "Lỗi kết nối tới BE: " + ex.Message);
            }
        }

        private static async Task<(bool Ok, string? Loi)> DangKyAsync(string url, object body)
        {
            try
            {
                using var resp = await _http.PostAsJsonAsync(url, body);
                if (resp.IsSuccessStatusCode)
                    return (true, null);
                return (false, await DocLoiAsync(resp));
            }
            catch (HttpRequestException)
            {
                return (false,
                    "Không kết nối được BE. Hãy chạy BE trước (dotnet run --project GymManagement.Api).");
            }
            catch (TaskCanceledException)
            {
                return (false,
                    "BE phản hồi quá chậm hoặc chưa chạy. Hãy chạy BE trước rồi thử lại.");
            }
        }

        // BE trả lỗi dạng text thuần (ví dụ "Tên đăng nhập đã tồn tại.").
        // Nếu BE trả về chuỗi JSON ("...") thì bỏ dấu ngoặc kép ngoài.
        private static async Task<string> DocLoiAsync(HttpResponseMessage resp)
        {
            var text = (await resp.Content.ReadAsStringAsync()).Trim();
            if (text.Length >= 2 && text.StartsWith("\"") && text.EndsWith("\""))
                text = text[1..^1];
            return string.IsNullOrWhiteSpace(text)
                ? $"BE trả về lỗi {(int)resp.StatusCode}."
                : text;
        }
    }
}
