namespace Gym_Management
{
    // Phiên đăng nhập hiện tại, dùng chung cho cả app sau khi Login thành công.
    public static class PhienDangNhap
    {
        public static string? Token { get; private set; }
        public static string TenDangNhap { get; private set; } = "";
        public static string VaiTro { get; private set; } = "";
        public static int? HoiVienId { get; private set; }
        public static int? PTId { get; private set; }
        public static bool DaDangNhapQuaApi { get; private set; }

        public static void LuuTuApi(DangNhapKetQua kq)
        {
            Token = kq.Token;
            TenDangNhap = kq.TenDangNhap;
            VaiTro = kq.VaiTro;
            HoiVienId = kq.HoiVienId;
            PTId = kq.PTId;
            DaDangNhapQuaApi = true;
        }

        public static void LuuThongTin(string tenDangNhap, string vaiTro, int? hoiVienId, int? ptId, string? token = null)
        {
            Token = token;
            TenDangNhap = tenDangNhap;
            VaiTro = vaiTro;
            HoiVienId = hoiVienId;
            PTId = ptId;
            DaDangNhapQuaApi = !string.IsNullOrEmpty(token);
        }

        public static void LuuAdminMacDinh()
        {
            Token = null;
            TenDangNhap = "admin";
            VaiTro = "Admin";
            HoiVienId = null;
            PTId = null;
            DaDangNhapQuaApi = false;
        }

        public static void Xoa()
        {
            Token = null;
            TenDangNhap = "";
            VaiTro = "";
            HoiVienId = null;
            PTId = null;
            DaDangNhapQuaApi = false;
        }
    }
}
