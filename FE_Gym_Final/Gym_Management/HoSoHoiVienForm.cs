using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Gym_Management
{
    public partial class HoSoHoiVienForm : Form
    {
        public HoSoHoiVienForm()
        {
            InitializeComponent();
        }

        private async void HoSoHoiVienForm_Load(object sender, EventArgs e)
        {
            txtTenDangNhap.Text = PhienDangNhap.TenDangNhap;
            txtHoTen.Text = "(Đang tải...)";
            txtSDT.Text = "(Đang tải...)";
            txtEmail.Text = "(Đang tải...)";
            txtGioiTinh.Text = "(Đang tải...)";
            txtGoiHienTai.Text = "Chưa đăng ký gói";
            txtGioTapHienTai.Text = "Chưa chọn khung giờ";
            txtPTHienTai.Text = "Tự tập luyện (Chưa đăng ký PT)";

            // 1. Tải từ API nếu có token BE
            if (PhienDangNhap.DaDangNhapQuaApi)
            {
                var (ok, hoSo, _) = await ApiClient.LayHoSoHoiVienAsync();
                if (ok && hoSo != null)
                {
                    txtHoTen.Text = $"{hoSo.Fname} {hoSo.Lname}";
                    txtSDT.Text = hoSo.Mobile;
                    txtEmail.Text = string.IsNullOrEmpty(hoSo.Email) ? "(Chưa cập nhật)" : hoSo.Email;
                    txtGioiTinh.Text = string.IsNullOrEmpty(hoSo.Gender) ? "(Chưa rõ)" : hoSo.Gender;
                    txtGoiHienTai.Text = string.IsNullOrEmpty(hoSo.MembershipTime) ? "Chưa đăng ký gói" : hoSo.MembershipTime;
                    txtGioTapHienTai.Text = string.IsNullOrEmpty(hoSo.Gymtime) ? "Chưa chọn khung giờ" : hoSo.Gymtime;
                }
            }

            // 2. Tải thêm từ database SQL Server (lấy đầy đủ cả AssignedPT)
            try
            {
                using (SqlConnection con = new SqlConnection(DatabaseHelper.ConnectionString))
                {
                    con.Open();
                    string query = @"SELECT TOP 1 Fname, Lname, Mobile, Email, Gender, MembershipTime, Gymtime, AssignedPT 
                                     FROM NewMember 
                                     WHERE MID = @MID OR Fname = @Fname";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@MID", PhienDangNhap.HoiVienId ?? 0);
                        cmd.Parameters.AddWithValue("@Fname", PhienDangNhap.TenDangNhap);
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string fn = reader["Fname"]?.ToString() ?? "";
                                string ln = reader["Lname"]?.ToString() ?? "";
                                txtHoTen.Text = $"{fn} {ln}".Trim();
                                txtSDT.Text = reader["Mobile"]?.ToString() ?? "";
                                txtEmail.Text = reader["Email"]?.ToString() ?? "(Chưa cập nhật)";
                                txtGioiTinh.Text = reader["Gender"]?.ToString() ?? "";
                                string goi = reader["MembershipTime"]?.ToString() ?? "";
                                string gio = reader["Gymtime"]?.ToString() ?? "";
                                string pt = reader["AssignedPT"]?.ToString() ?? "";

                                txtGoiHienTai.Text = string.IsNullOrEmpty(goi) ? "Chưa đăng ký gói" : goi;
                                txtGioTapHienTai.Text = string.IsNullOrEmpty(gio) ? "Chưa chọn khung giờ" : gio;
                                txtPTHienTai.Text = string.IsNullOrEmpty(pt) ? "Tự tập luyện (Chưa đăng ký PT)" : pt;
                                return;
                            }
                        }
                    }
                }
            }
            catch { }
        }

        private void btnDoiGoiTap_Click(object sender, EventArgs e)
        {
            using (var form = new DangKyGoiTapForm(PhienDangNhap.HoiVienId))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    HoSoHoiVienForm_Load(sender, e);
                }
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
