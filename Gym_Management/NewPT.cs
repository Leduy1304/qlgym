using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient; // thêm dòng này để kết nối sql

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
			// 1. Kiểm tra rỗng đối với các TextBox, RadioButton (giống form NewMember)
			if (string.IsNullOrWhiteSpace(txtFirstName.Text) ||
				string.IsNullOrWhiteSpace(txtLastName.Text) ||
				string.IsNullOrWhiteSpace(txtMobile.Text) ||
				string.IsNullOrWhiteSpace(txtEmail.Text) ||
				string.IsNullOrWhiteSpace(txtAddress.Text) ||
				(!radioButton1.Checked && !radioButton2.Checked))
			{
				MessageBox.Show("Vui lòng không để trống thông tin. Hãy điền hoặc chọn đầy đủ!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			// 2. Kiểm tra định dạng Email (phải chứa ký tự @)
			if (!txtEmail.Text.Contains("@"))
			{
				MessageBox.Show("Email không hợp lệ (phải chứa ký tự '@')!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			// 3. Kiểm tra số điện thoại: phải gồm đúng 10 chữ số và bắt đầu bằng số 0
			// (định dạng SĐT Việt Nam, ví dụ: 0901234567)
			string sdt = txtMobile.Text.Trim();
			bool sdtHopLe = sdt.Length == 10 && sdt.StartsWith("0");
			if (sdtHopLe)
			{
				foreach (char c in sdt)
				{
					if (!char.IsDigit(c)) { sdtHopLe = false; break; }
				}
			}
			if (!sdtHopLe)
			{
				MessageBox.Show("Số điện thoại không hợp lệ. SĐT phải gồm đúng 10 chữ số và bắt đầu bằng số 0 (ví dụ: 0901234567)!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			// --- Bắt đầu lấy dữ liệu sau khi đã kiểm tra an toàn ---
			string fname = txtFirstName.Text.Trim(); // Họ
			string lname = txtLastName.Text.Trim(); // Tên
			string gender = radioButton1.Checked ? radioButton1.Text : radioButton2.Text; // Giới tính
			DateTime dob = dateTimePickerDOB.Value.Date; // Ngày sinh
			string mobile = txtMobile.Text.Trim(); // SDT (dạng chữ để giữ số 0 ở đầu)
			string email = txtEmail.Text.Trim(); // Email
			DateTime joindate = dateTimePickerJoinDate.Value.Date; // Ngày vào làm
			string address = txtAddress.Text.Trim(); // Địa chỉ nhà

			// Bắt đầu code kết nối database với winform
			// Dùng tham số (@...) thay vì cộng chuỗi trực tiếp: tránh lỗi khi Họ/Tên/Địa chỉ
			// có dấu nháy đơn (') và tránh lỗi SQL Injection.
			try
			{
				using (SqlConnection con = new SqlConnection(DatabaseHelper.ConnectionString))
				{
					string query = "INSERT INTO NewPT (Fname, Lname, Gender, Dob, Mobile, Email, JoinDate, Paddress) " +
								   "VALUES (@Fname, @Lname, @Gender, @Dob, @Mobile, @Email, @JoinDate, @Paddress)";
					using (SqlCommand cmd = new SqlCommand(query, con))
					{
						cmd.Parameters.AddWithValue("@Fname", fname);
						cmd.Parameters.AddWithValue("@Lname", lname);
						cmd.Parameters.AddWithValue("@Gender", gender);
						cmd.Parameters.Add("@Dob", SqlDbType.Date).Value = dob;
						cmd.Parameters.AddWithValue("@Mobile", mobile);
						cmd.Parameters.AddWithValue("@Email", email);
						cmd.Parameters.Add("@JoinDate", SqlDbType.Date).Value = joindate;
						cmd.Parameters.AddWithValue("@Paddress", address);

						con.Open();
						cmd.ExecuteNonQuery();
					}
				}
				MessageBox.Show("Lưu PT thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Không lưu được vào database. Hãy kiểm tra bảng NewPT đã được tạo chưa (chạy file gym_database.sql) và SQL Server đã bật chưa.\n\nChi tiết lỗi: " + ex.Message,
					"Lỗi kết nối", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnReset_Click(object sender, EventArgs e)
		{
			// Xóa trắng các ô nhập chữ (TextBox)
			txtFirstName.Clear();
			txtLastName.Clear();
			txtMobile.Clear();
			txtEmail.Clear();
			txtAddress.Clear();

			// Bỏ chọn nút giới tính (RadioButton)
			radioButton1.Checked = false;
			radioButton2.Checked = false;

			// Trả ngày sinh và ngày vào làm về ngày hiện tại (DateTimePicker)
			dateTimePickerDOB.Value = DateTime.Now;
			dateTimePickerJoinDate.Value = DateTime.Now;

			MessageBox.Show("Reset thành công.");
		}
	}
}
