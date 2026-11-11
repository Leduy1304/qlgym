using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Gym_Management
{
    // Form Đăng ký tài khoản cho Hội viên và Huấn luyện viên (PT).
    // Dữ liệu được lưu trực tiếp vào CSDL gym (bảng NewMember / NewPT và bảng TaiKhoan).
    // Đồng thời đồng bộ qua Backend API (nếu Backend đang chạy).
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
            cmbVaiTro.SelectedIndex = 0;
            cmbGioiTinh.SelectedIndex = 0;
            CapNhatTruongTheoVaiTro();
        }

        private bool LaPT => cmbVaiTro.SelectedIndex == 1;

        private void CapNhatTruongTheoVaiTro()
        {
            if (LaPT)
            {
                lblTenDangNhap.Text = "Tài khoản (@pt)";
                txtTenDangNhap.PlaceholderText = "Ví dụ: duy@pt";
                lblDiaChi.Text = "Địa chỉ (PT)";
                lblNote.Text = "* Gợi ý: Đăng ký tài khoản Huấn luyện viên theo mẫu [tên]@pt (ví dụ: duy@pt). Tài khoản, SĐT và Email không được trùng.";
            }
            else
            {
                lblTenDangNhap.Text = "Tài khoản (@hv)";
                txtTenDangNhap.PlaceholderText = "Ví dụ: duy@hv";
                lblDiaChi.Text = "Địa chỉ";
                lblNote.Text = "* Gợi ý: Đăng ký tài khoản Hội viên theo mẫu [tên]@hv (ví dụ: duy@hv). Tài khoản, SĐT và Email không được trùng.";
            }
        }

        private void cmbVaiTro_SelectedIndexChanged(object sender, EventArgs e)
        {
            CapNhatTruongTheoVaiTro();
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtMatKhau.UseSystemPasswordChar = !chkShowPassword.Checked;
            txtNhapLai.UseSystemPasswordChar = !chkShowPassword.Checked;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private async void btnDangKy_Click(object sender, EventArgs e)
        {
            // 1. Kiểm tra nhập liệu cơ bản
            var tenDangNhap = txtTenDangNhap.Text.Trim();
            var matKhau = txtMatKhau.Text;
            var ho = txtHo.Text.Trim();
            var ten = txtTen.Text.Trim();
            var sdt = txtSDT.Text.Trim();
            var email = txtEmail.Text.Trim();
            var diaChi = txtDiaChi.Text.Trim();
            var gender = cmbGioiTinh.SelectedItem?.ToString() ?? "Nam";
            var dob = dtpNgaySinh.Value.Date;

            if (string.IsNullOrWhiteSpace(tenDangNhap)
                || string.IsNullOrWhiteSpace(ho)
                || string.IsNullOrWhiteSpace(ten)
                || string.IsNullOrWhiteSpace(sdt)
                || string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Tài khoản, Mật khẩu, Họ, Tên, Số điện thoại và Email!",
                    "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (matKhau.Length < 5)
            {
                MessageBox.Show("Mật khẩu phải từ 5 ký tự trở lên!",
                    "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMatKhau.Focus();
                return;
            }

            if (matKhau != txtNhapLai.Text)
            {
                MessageBox.Show("Mật khẩu nhập lại không khớp!",
                    "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNhapLai.Clear();
                txtNhapLai.Focus();
                return;
            }

            // SĐT phải đúng 10 số và bắt đầu bằng số 0
            if (sdt.Length != 10 || sdt[0] != '0' || !sdt.All(char.IsDigit))
            {
                MessageBox.Show("Số điện thoại phải gồm đúng 10 số và bắt đầu bằng số 0 (ví dụ: 0901234567)!",
                    "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSDT.Focus();
                return;
            }

            // Email phải đúng định dạng
            if (!email.Contains("@") || !email.Contains("."))
            {
                MessageBox.Show("Email không hợp lệ (phải có dạng ví dụ: duy@gmail.com)!",
                    "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return;
            }

            btnDangKy.Enabled = false;
            try
            {
                // 2. Kiểm tra tính DUY NHẤT (Tài khoản, SĐT, Email không được trùng)
                // Các thông tin cá nhân khác (Họ, Tên, Ngày sinh, Giới tính, Địa chỉ) có thể giống nhau
                using (SqlConnection con = new SqlConnection(DatabaseHelper.ConnectionString))
                {
                    con.Open();

                    // 2.1. Kiểm tra tài khoản không được trùng
                    string sqlCheckTk = "SELECT COUNT(*) FROM TaiKhoan WHERE LOWER(TenDangNhap) = LOWER(@TK)";
                    using (SqlCommand cmd = new SqlCommand(sqlCheckTk, con))
                    {
                        cmd.Parameters.AddWithValue("@TK", tenDangNhap);
                        int countTk = Convert.ToInt32(cmd.ExecuteScalar());
                        if (countTk > 0)
                        {
                            MessageBox.Show($"Tài khoản '{tenDangNhap}' đã tồn tại trong hệ thống!\nVui lòng chọn tên tài khoản khác (ví dụ: {ten.ToLower()}@{(LaPT ? "pt" : "hv")}).",
                                "Trùng tài khoản", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtTenDangNhap.Focus();
                            return;
                        }
                    }

                    // 2.2. Kiểm tra Số điện thoại không được trùng (cả trong NewMember và NewPT)
                    string sqlCheckMobile = @"
                        SELECT (SELECT COUNT(*) FROM NewMember WHERE Mobile = @Mobile) + 
                               (SELECT COUNT(*) FROM NewPT WHERE Mobile = @Mobile)";
                    using (SqlCommand cmd = new SqlCommand(sqlCheckMobile, con))
                    {
                        cmd.Parameters.AddWithValue("@Mobile", sdt);
                        int countMobile = Convert.ToInt32(cmd.ExecuteScalar());
                        if (countMobile > 0)
                        {
                            MessageBox.Show($"Số điện thoại '{sdt}' đã được đăng ký bởi người khác trong hệ thống (Hội viên hoặc Huấn luyện viên)!\nVui lòng sử dụng số điện thoại khác.",
                                "Trùng số điện thoại", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtSDT.Focus();
                            return;
                        }
                    }

                    // 2.3. Kiểm tra Email không được trùng (cả trong NewMember và NewPT)
                    string sqlCheckEmail = @"
                        SELECT (SELECT COUNT(*) FROM NewMember WHERE LOWER(Email) = LOWER(@Email)) + 
                               (SELECT COUNT(*) FROM NewPT WHERE LOWER(Email) = LOWER(@Email))";
                    using (SqlCommand cmd = new SqlCommand(sqlCheckEmail, con))
                    {
                        cmd.Parameters.AddWithValue("@Email", email);
                        int countEmail = Convert.ToInt32(cmd.ExecuteScalar());
                        if (countEmail > 0)
                        {
                            MessageBox.Show($"Email '{email}' đã được đăng ký trong hệ thống (Hội viên hoặc Huấn luyện viên)!\nVui lòng sử dụng email khác.",
                                "Trùng Email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtEmail.Focus();
                            return;
                        }
                    }

                    // 3. Thực hiện lưu vào CSDL gym bằng Transaction
                    using (SqlTransaction trans = con.BeginTransaction())
                    {
                        try
                        {
                            if (LaPT)
                            {
                                // Lưu thông tin HLV vào NewPT
                                string sqlPT = @"INSERT INTO NewPT (Fname, Lname, Gender, Dob, Mobile, Email, JoinDate, Paddress) 
                                                VALUES (@Fname, @Lname, @Gender, @Dob, @Mobile, @Email, @JoinDate, @Paddress);
                                                SELECT SCOPE_IDENTITY();";
                                int newPid;
                                using (SqlCommand cmd = new SqlCommand(sqlPT, con, trans))
                                {
                                    cmd.Parameters.AddWithValue("@Fname", ho);
                                    cmd.Parameters.AddWithValue("@Lname", ten);
                                    cmd.Parameters.AddWithValue("@Gender", gender);
                                    cmd.Parameters.Add("@Dob", SqlDbType.Date).Value = dob;
                                    cmd.Parameters.AddWithValue("@Mobile", sdt);
                                    cmd.Parameters.AddWithValue("@Email", email);
                                    cmd.Parameters.Add("@JoinDate", SqlDbType.Date).Value = DateTime.Today;
                                    cmd.Parameters.AddWithValue("@Paddress", diaChi);
                                    newPid = Convert.ToInt32(cmd.ExecuteScalar());
                                }

                                // Tạo tài khoản đăng nhập PT liên kết PID
                                string sqlTk = @"INSERT INTO TaiKhoan (TenDangNhap, MatKhau, VaiTro, MID, PID) 
                                                VALUES (@TK, @MK, 'PT', NULL, @PID);";
                                using (SqlCommand cmd = new SqlCommand(sqlTk, con, trans))
                                {
                                    cmd.Parameters.AddWithValue("@TK", tenDangNhap);
                                    cmd.Parameters.AddWithValue("@MK", matKhau);
                                    cmd.Parameters.AddWithValue("@PID", newPid);
                                    cmd.ExecuteNonQuery();
                                }
                            }
                            else
                            {
                                // Lưu thông tin Hội viên vào NewMember
                                string sqlHv = @"INSERT INTO NewMember (Fname, Lname, Gender, Dob, Mobile, Email, JoinDate, Gymtime, Maddress, MembershipTime) 
                                                VALUES (@Fname, @Lname, @Gender, @Dob, @Mobile, @Email, @JoinDate, '', @Maddress, '');
                                                SELECT SCOPE_IDENTITY();";
                                int newMid;
                                using (SqlCommand cmd = new SqlCommand(sqlHv, con, trans))
                                {
                                    cmd.Parameters.AddWithValue("@Fname", ho);
                                    cmd.Parameters.AddWithValue("@Lname", ten);
                                    cmd.Parameters.AddWithValue("@Gender", gender);
                                    cmd.Parameters.Add("@Dob", SqlDbType.Date).Value = dob;
                                    cmd.Parameters.AddWithValue("@Mobile", sdt);
                                    cmd.Parameters.AddWithValue("@Email", email);
                                    cmd.Parameters.Add("@JoinDate", SqlDbType.Date).Value = DateTime.Today;
                                    cmd.Parameters.AddWithValue("@Maddress", diaChi);
                                    newMid = Convert.ToInt32(cmd.ExecuteScalar());
                                }

                                // Tạo tài khoản đăng nhập Hội viên liên kết MID
                                string sqlTk = @"INSERT INTO TaiKhoan (TenDangNhap, MatKhau, VaiTro, MID, PID) 
                                                VALUES (@TK, @MK, 'HoiVien', @MID, NULL);";
                                using (SqlCommand cmd = new SqlCommand(sqlTk, con, trans))
                                {
                                    cmd.Parameters.AddWithValue("@TK", tenDangNhap);
                                    cmd.Parameters.AddWithValue("@MK", matKhau);
                                    cmd.Parameters.AddWithValue("@MID", newMid);
                                    cmd.ExecuteNonQuery();
                                }
                            }

                            trans.Commit();
                        }
                        catch
                        {
                            trans.Rollback();
                            throw;
                        }
                    }
                }

                // 4. Đồng bộ thêm sang Backend API nếu BE đang chạy (không bắt buộc)
                try
                {
                    var dobOnly = DateOnly.FromDateTime(dob);
                    if (LaPT)
                    {
                        await ApiClient.DangKyPTAsync(tenDangNhap, matKhau, ho, ten, gender, dobOnly, sdt, email, diaChi);
                    }
                    else
                    {
                        await ApiClient.DangKyHoiVienAsync(tenDangNhap, matKhau, ho, ten, gender, dobOnly, sdt, email, "", diaChi, "");
                    }
                }
                catch { }

                // 5. Thông báo thành công
                MessageBox.Show(
                    $"Đăng ký thành công tài khoản '{tenDangNhap}' ({(LaPT ? "Huấn luyện viên PT" : "Hội viên")})!\n\n" +
                    "Dữ liệu đã được lưu thành công vào Cơ sở dữ liệu phòng gym (gym_database.sql).\n" +
                    "Bạn có thể quay lại form Đăng nhập để sử dụng tài khoản vừa tạo.",
                    "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu vào cơ sở dữ liệu: " + ex.Message,
                    "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnDangKy.Enabled = true;
            }
        }
    }
}
