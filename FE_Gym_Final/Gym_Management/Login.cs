using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Gym_Management
{
	public partial class Login : Form
	{
		private const string AdminUsername = "admin";
		private const string AdminPassword = "12345";

		public Login()
		{
			InitializeComponent();
		}

		private async void btnLogin_Click(object sender, EventArgs e)
		{
			// 1. Kiểm tra rỗng
			if (string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
			{
				MessageBox.Show("Vui lòng nhập đầy đủ Tài khoản và Mật khẩu!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			var tenDangNhap = txtUsername.Text.Trim();
			var matKhau = txtPassword.Text;

			btnLogin.Enabled = false;
			try
			{
				// 2. Kiểm tra tài khoản trong database gym (CSDL SQL Server)
				bool dangNhapThanhCong = false;
				string vaiTro = "";
				int? mid = null;
				int? pid = null;

				try
				{
					using (SqlConnection con = new SqlConnection(DatabaseHelper.ConnectionString))
					{
						con.Open();
						string query = "SELECT Id, TenDangNhap, MatKhau, VaiTro, MID, PID FROM TaiKhoan WHERE LOWER(TenDangNhap) = LOWER(@TK) AND MatKhau = @MK";
						using (SqlCommand cmd = new SqlCommand(query, con))
						{
							cmd.Parameters.AddWithValue("@TK", tenDangNhap);
							cmd.Parameters.AddWithValue("@MK", matKhau);
							using (SqlDataReader reader = cmd.ExecuteReader())
							{
								if (reader.Read())
								{
									dangNhapThanhCong = true;
									vaiTro = reader["VaiTro"].ToString() ?? "HoiVien";
									if (reader["MID"] != DBNull.Value) mid = Convert.ToInt32(reader["MID"]);
									if (reader["PID"] != DBNull.Value) pid = Convert.ToInt32(reader["PID"]);
								}
							}
						}
					}
				}
				catch
				{
					// Nếu chưa kết nối được SQL Server thì kiểm tra tiếp qua BE hoặc fallback
				}

				// 3. Nếu tìm thấy trong Database gym
				if (dangNhapThanhCong)
				{
					// Lấy thêm JWT Token nếu Backend API đang chạy
					string? token = null;
					try
					{
						var (trangThaiBe, beKq, _) = await ApiClient.DangNhapAsync(tenDangNhap, matKhau);
						if (trangThaiBe == KetQuaDangNhap.ThanhCong && beKq != null)
						{
							token = beKq.Token;
						}
					}
					catch { }

					PhienDangNhap.LuuThongTin(tenDangNhap, vaiTro, mid, pid, token);
					this.DialogResult = DialogResult.OK;
					this.Close();
					return;
				}

				// 4. Nếu trong database gym chưa có, kiểm tra qua Backend API
				try
				{
					var (trangThai, ketQua, loi) = await ApiClient.DangNhapAsync(tenDangNhap, matKhau);
					if (trangThai == KetQuaDangNhap.ThanhCong && ketQua != null)
					{
						PhienDangNhap.LuuTuApi(ketQua);
						this.DialogResult = DialogResult.OK;
						this.Close();
						return;
					}
				}
				catch { }

				// 5. Fallback tài khoản admin mặc định (admin / 12345)
				if (tenDangNhap == AdminUsername && matKhau == AdminPassword)
				{
					PhienDangNhap.LuuAdminMacDinh();
					this.DialogResult = DialogResult.OK;
					this.Close();
					return;
				}

				// Nếu không khớp tài khoản nào
				MessageBox.Show("Tài khoản hoặc Mật khẩu không đúng. Vui lòng thử lại!",
					"Đăng nhập thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
				txtPassword.Clear();
				txtPassword.Focus();
			}
			finally
			{
				btnLogin.Enabled = true;
			}
		}

		private void btnRegister_Click(object sender, EventArgs e)
		{
			using (var form = new RegisterForm())
			{
				if (form.ShowDialog() == DialogResult.OK)
				{
					txtPassword.Clear();
					txtPassword.Focus();
				}
			}
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show("Bạn có chắc muốn thoát chương trình không?",
				"Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (result == DialogResult.Yes)
			{
				this.DialogResult = DialogResult.Cancel;
				this.Close();
			}
		}

		// Hiện / ẩn mật khẩu khi tích vào ô "Hiện mật khẩu"
		private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
		{
			txtPassword.UseSystemPasswordChar = !chkShowPassword.Checked;
		}
	}
}
