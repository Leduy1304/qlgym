using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Gym_Management
{
	public partial class NewPT : Form
	{
		public NewPT()
		{
			InitializeComponent();
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			// 1. Kiểm tra rỗng và khoảng trắng
			if (string.IsNullOrWhiteSpace(txtFirstName.Text))
			{
				MessageBox.Show("Vui lòng không để trống Họ của HLV (không được chứa toàn khoảng trắng)!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txtFirstName.Focus();
				return;
			}

			if (string.IsNullOrWhiteSpace(txtLastName.Text))
			{
				MessageBox.Show("Vui lòng không để trống Tên của HLV (không được chứa toàn khoảng trắng)!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txtLastName.Focus();
				return;
			}

			if (!radioButton1.Checked && !radioButton2.Checked)
			{
				MessageBox.Show("Vui lòng chọn Giới tính cho HLV!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			if (string.IsNullOrWhiteSpace(txtMobile.Text))
			{
				MessageBox.Show("Vui lòng không để trống Số điện thoại của HLV (không được chứa toàn khoảng trắng)!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txtMobile.Focus();
				return;
			}

			if (string.IsNullOrWhiteSpace(txtEmail.Text))
			{
				MessageBox.Show("Vui lòng không để trống Email của HLV (không được chứa toàn khoảng trắng)!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txtEmail.Focus();
				return;
			}

			if (string.IsNullOrWhiteSpace(txtAddress.Text))
			{
				MessageBox.Show("Vui lòng không để trống Địa chỉ của HLV (không được chứa toàn khoảng trắng)!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txtAddress.Focus();
				return;
			}

			// 2. Kiểm tra định dạng Email
			string email = txtEmail.Text.Trim();
			if (!email.Contains("@") || !email.Contains("."))
			{
				MessageBox.Show("Email không hợp lệ (phải chứa ký tự '@' và '.')!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txtEmail.Focus();
				return;
			}

			// 3. Kiểm tra số điện thoại: đúng 10 số và bắt đầu bằng 0
			string mobile = txtMobile.Text.Trim();
			bool mobileHopLe = mobile.Length == 10 && mobile.StartsWith("0");
			if (mobileHopLe)
			{
				foreach (char c in mobile)
				{
					if (!char.IsDigit(c)) { mobileHopLe = false; break; }
				}
			}
			if (!mobileHopLe)
			{
				MessageBox.Show("Số điện thoại không hợp lệ. SĐT phải gồm đúng 10 chữ số và bắt đầu bằng số 0 (ví dụ: 0901234567)!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txtMobile.Focus();
				return;
			}

			string fname = txtFirstName.Text.Trim();
			string lname = txtLastName.Text.Trim();
			string gender = radioButton1.Checked ? radioButton1.Text : radioButton2.Text;
			DateTime dob = dateTimePickerDOB.Value.Date;
			DateTime joindate = dateTimePickerJoinDate.Value.Date;
			string address = txtAddress.Text.Trim();

			try
			{
				using (SqlConnection con = new SqlConnection(DatabaseHelper.ConnectionString))
				{
					con.Open();

					// 4. Kiểm tra SĐT và Email không được trùng
					string checkSql = @"
						SELECT 
							(SELECT COUNT(*) FROM NewMember WHERE Mobile = @Mobile) +
							(SELECT COUNT(*) FROM NewPT WHERE Mobile = @Mobile) AS TrungSDT,
							(SELECT COUNT(*) FROM NewMember WHERE LOWER(Email) = LOWER(@Email)) +
							(SELECT COUNT(*) FROM NewPT WHERE LOWER(Email) = LOWER(@Email)) AS TrungEmail";
					using (SqlCommand chkCmd = new SqlCommand(checkSql, con))
					{
						chkCmd.Parameters.AddWithValue("@Mobile", mobile);
						chkCmd.Parameters.AddWithValue("@Email", email);
						using (SqlDataReader r = chkCmd.ExecuteReader())
						{
							if (r.Read())
							{
								int trungSDT = Convert.ToInt32(r["TrungSDT"]);
								int trungEmail = Convert.ToInt32(r["TrungEmail"]);
								if (trungSDT > 0)
								{
									MessageBox.Show($"Số điện thoại '{mobile}' đã được sử dụng trong hệ thống! Vui lòng dùng SĐT khác.", "Trùng SĐT", MessageBoxButtons.OK, MessageBoxIcon.Warning);
									txtMobile.Focus();
									return;
								}
								if (trungEmail > 0)
								{
									MessageBox.Show($"Email '{email}' đã được sử dụng trong hệ thống! Vui lòng dùng Email khác.", "Trùng Email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
									txtEmail.Focus();
									return;
								}
							}
						}
					}

					// 5. Thêm PT vào NewPT và tạo tài khoản TaiKhoan
					using (SqlTransaction trans = con.BeginTransaction())
					{
						try
						{
							string query = @"INSERT INTO NewPT (Fname, Lname, Gender, Dob, Mobile, Email, JoinDate, Paddress) 
											VALUES (@Fname, @Lname, @Gender, @Dob, @Mobile, @Email, @JoinDate, @Paddress);
											SELECT SCOPE_IDENTITY();";
							int newPid;
							using (SqlCommand cmd = new SqlCommand(query, con, trans))
							{
								cmd.Parameters.AddWithValue("@Fname", fname);
								cmd.Parameters.AddWithValue("@Lname", lname);
								cmd.Parameters.AddWithValue("@Gender", gender);
								cmd.Parameters.Add("@Dob", SqlDbType.Date).Value = dob;
								cmd.Parameters.AddWithValue("@Mobile", mobile);
								cmd.Parameters.AddWithValue("@Email", email);
								cmd.Parameters.Add("@JoinDate", SqlDbType.Date).Value = joindate;
								cmd.Parameters.AddWithValue("@Paddress", address);
								newPid = Convert.ToInt32(cmd.ExecuteScalar());
							}

							// Tạo tài khoản mặc định dạng: <ten><newPid>@pt
							string tenKd = BoDauTiengViet(lname).ToLower().Replace(" ", "");
							if (string.IsNullOrEmpty(tenKd)) tenKd = "pt";
							string autoTk = $"{tenKd}{newPid}@pt";
							string autoMk = "12345";

							string queryTk = @"INSERT INTO TaiKhoan (TenDangNhap, MatKhau, VaiTro, MID, PID) 
											  VALUES (@TK, @MK, 'PT', NULL, @PID);";
							using (SqlCommand cmdTk = new SqlCommand(queryTk, con, trans))
							{
								cmdTk.Parameters.AddWithValue("@TK", autoTk);
								cmdTk.Parameters.AddWithValue("@MK", autoMk);
								cmdTk.Parameters.AddWithValue("@PID", newPid);
								cmdTk.ExecuteNonQuery();
							}

							trans.Commit();

							MessageBox.Show(
								$"Thêm Huấn luyện viên (PT) thành công!\n" +
								$"Mã PT (PID): {newPid}\n\n" +
								$"Đã tự động tạo tài khoản đăng nhập cho Huấn luyện viên:\n" +
								$"• Tài khoản: {autoTk}\n" +
								$"• Mật khẩu mặc định: {autoMk}",
								"Lưu thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

							btnReset_Click(sender, e);
						}
						catch
						{
							trans.Rollback();
							throw;
						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Không lưu được vào database. Hãy kiểm tra SQL Server đã bật chưa.\n\nChi tiết lỗi: " + ex.Message,
					"Lỗi kết nối", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnReset_Click(object sender, EventArgs e)
		{
			txtFirstName.Clear();
			txtLastName.Clear();
			txtMobile.Clear();
			txtEmail.Clear();
			txtAddress.Clear();

			radioButton1.Checked = false;
			radioButton2.Checked = false;

			dateTimePickerDOB.Value = DateTime.Now;
			dateTimePickerJoinDate.Value = DateTime.Now;
		}

		private static string BoDauTiengViet(string str)
		{
			if (string.IsNullOrEmpty(str)) return "";
			string[] signs = new string[] {
				"aAeEoOuUiIdDyY",
				"áàạảãâấầậẩẫăắằặẳẵ",
				"ÁÀẠẢÃÂẤẦẬẨẪĂẮẰẶẲẴ",
				"éèẹẻẽêếềệểễ",
				"ÉÈẸẺẼÊẾỀỆỂỄ",
				"óòọỏõôốồộổỗơớờợởỡ",
				"ÓÒỌỎÕÔỐỒỘỔỖƠỚỜỢỞỠ",
				"úùụủũưứừựửữ",
				"ÚÙỤỦŨƯỨỪỰỬỮ",
				"íìịỉĩ",
				"ÍÌỊỈĨ",
				"đ",
				"Đ",
				"ýỳỵỷỹ",
				"ÝỲỴỶỸ"
			};
			for (int i = 1; i < signs.Length; i++)
			{
				for (int j = 0; j < signs[i].Length; j++)
					str = str.Replace(signs[i][j], signs[0][i - 1]);
			}
			return str;
		}
	}
}
