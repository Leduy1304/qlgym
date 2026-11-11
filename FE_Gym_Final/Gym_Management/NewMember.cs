using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Gym_Management
{
	public partial class NewMember : Form
	{
		public NewMember()
		{
			InitializeComponent();
		}

		private void NewMember_Load(object sender, EventArgs e)
		{
			LoadDanhSachPT();
		}

		private void LoadDanhSachPT()
		{
			comboBoxPT.Items.Clear();
			comboBoxPT.Items.Add("Không chọn PT");

			string? loggedInPtName = null;

			try
			{
				using (SqlConnection con = new SqlConnection(DatabaseHelper.ConnectionString))
				{
					con.Open();
					using (SqlCommand cmd = new SqlCommand("SELECT PID, (Fname + ' ' + Lname) AS HoTen FROM NewPT ORDER BY PID ASC", con))
					{
						using (SqlDataReader reader = cmd.ExecuteReader())
						{
							while (reader.Read())
							{
								int pid = Convert.ToInt32(reader["PID"]);
								string hoTen = reader["HoTen"].ToString() ?? "";
								string itemText = $"{pid} - {hoTen}";
								comboBoxPT.Items.Add(itemText);

								if (PhienDangNhap.VaiTro == "PT" && PhienDangNhap.PTId.HasValue && PhienDangNhap.PTId.Value == pid)
								{
									loggedInPtName = itemText;
								}
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Không tải được danh sách HLV: " + ex.Message, "Lỗi kết nối", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}

			if (!string.IsNullOrEmpty(loggedInPtName) && comboBoxPT.Items.Contains(loggedInPtName))
			{
				comboBoxPT.SelectedItem = loggedInPtName;
			}
			else
			{
				comboBoxPT.SelectedIndex = 0;
			}
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			// 1. Kiểm tra rỗng và khoảng trắng
			if (string.IsNullOrWhiteSpace(txtFirstName.Text))
			{
				MessageBox.Show("Vui lòng không để trống Họ của hội viên (không được chứa toàn khoảng trắng)!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txtFirstName.Focus();
				return;
			}

			if (string.IsNullOrWhiteSpace(txtLastName.Text))
			{
				MessageBox.Show("Vui lòng không để trống Tên của hội viên (không được chứa toàn khoảng trắng)!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txtLastName.Focus();
				return;
			}

			if (!radioButton1.Checked && !radioButton2.Checked)
			{
				MessageBox.Show("Vui lòng chọn Giới tính cho hội viên!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			if (string.IsNullOrWhiteSpace(txtMobile.Text))
			{
				MessageBox.Show("Vui lòng không để trống Số điện thoại (không được chứa toàn khoảng trắng)!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txtMobile.Focus();
				return;
			}

			if (string.IsNullOrWhiteSpace(txtEmail.Text))
			{
				MessageBox.Show("Vui lòng không để trống Email (không được chứa toàn khoảng trắng)!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txtEmail.Focus();
				return;
			}

			if (comboBoxGymTime.SelectedIndex == -1 || string.IsNullOrWhiteSpace(comboBoxGymTime.Text))
			{
				MessageBox.Show("Vui lòng chọn Khung giờ tập cho hội viên (không được để trống hoặc khoảng trắng)!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				comboBoxGymTime.Focus();
				return;
			}

			if (comboBoxMembership.SelectedIndex == -1 || string.IsNullOrWhiteSpace(comboBoxMembership.Text))
			{
				MessageBox.Show("Vui lòng chọn Gói tập cho hội viên (không được để trống hoặc khoảng trắng)!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				comboBoxMembership.Focus();
				return;
			}

			if (string.IsNullOrWhiteSpace(txtAddress.Text))
			{
				MessageBox.Show("Vui lòng không để trống Địa chỉ của hội viên (không được chứa toàn khoảng trắng)!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
			string gymTime = comboBoxGymTime.Text;
			string address = txtAddress.Text.Trim();
			string membership = comboBoxMembership.Text;
			string? assignedPT = (comboBoxPT.SelectedIndex > 0) ? comboBoxPT.Text : null;

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

					// 5. Thêm Hội viên vào NewMember và tạo tài khoản TaiKhoan
					using (SqlTransaction trans = con.BeginTransaction())
					{
						try
						{
							string query = @"INSERT INTO NewMember (Fname, Lname, Gender, Dob, Mobile, Email, JoinDate, Gymtime, Maddress, MembershipTime, AssignedPT) 
											VALUES (@Fname, @Lname, @Gender, @Dob, @Mobile, @Email, @JoinDate, @Gymtime, @Maddress, @MembershipTime, @AssignedPT);
											SELECT SCOPE_IDENTITY();";
							int newMid;
							using (SqlCommand cmd = new SqlCommand(query, con, trans))
							{
								cmd.Parameters.AddWithValue("@Fname", fname);
								cmd.Parameters.AddWithValue("@Lname", lname);
								cmd.Parameters.AddWithValue("@Gender", gender);
								cmd.Parameters.Add("@Dob", SqlDbType.Date).Value = dob;
								cmd.Parameters.AddWithValue("@Mobile", mobile);
								cmd.Parameters.AddWithValue("@Email", email);
								cmd.Parameters.Add("@JoinDate", SqlDbType.Date).Value = joindate;
								cmd.Parameters.AddWithValue("@Gymtime", gymTime);
								cmd.Parameters.AddWithValue("@Maddress", address);
								cmd.Parameters.AddWithValue("@MembershipTime", membership);
								cmd.Parameters.AddWithValue("@AssignedPT", (object?)assignedPT ?? DBNull.Value);
								newMid = Convert.ToInt32(cmd.ExecuteScalar());
							}

							// Tạo tài khoản mặc định dạng: <ten><mid>@hv
							string tenKd = BoDauTiengViet(lname).ToLower().Replace(" ", "");
							if (string.IsNullOrEmpty(tenKd)) tenKd = "hv";
							string autoTk = $"{tenKd}{newMid}@hv";
							string autoMk = "12345";

							string queryTk = @"INSERT INTO TaiKhoan (TenDangNhap, MatKhau, VaiTro, MID, PID) 
											  VALUES (@TK, @MK, 'HoiVien', @MID, NULL);";
							using (SqlCommand cmdTk = new SqlCommand(queryTk, con, trans))
							{
								cmdTk.Parameters.AddWithValue("@TK", autoTk);
								cmdTk.Parameters.AddWithValue("@MK", autoMk);
								cmdTk.Parameters.AddWithValue("@MID", newMid);
								cmdTk.ExecuteNonQuery();
							}

							trans.Commit();

							MessageBox.Show(
								$"Thêm hội viên thành công!\n" +
								$"Mã hội viên (MID): {newMid}\n" +
								$"HLV phụ trách: {(string.IsNullOrEmpty(assignedPT) ? "Không có" : assignedPT)}\n\n" +
								$"Đã tự động tạo tài khoản đăng nhập cho Hội viên:\n" +
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

			comboBoxGymTime.SelectedIndex = -1;
			comboBoxMembership.SelectedIndex = -1;

			LoadDanhSachPT();
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
