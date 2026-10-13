using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Data.SqlClient; // thêm dòng này để kết nối sql

namespace Gym_Management
{
	public partial class NewMember : Form
	{
		public NewMember()
		{
			InitializeComponent();
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			// 1. Kiểm tra rỗng đối với các TextBox, RadioButton và ComboBox
			if (string.IsNullOrWhiteSpace(txtFirstName.Text) ||
				string.IsNullOrWhiteSpace(txtLastName.Text) ||
				string.IsNullOrWhiteSpace(txtMobile.Text) ||
				string.IsNullOrWhiteSpace(txtEmail.Text) ||
				string.IsNullOrWhiteSpace(txtAddress.Text) ||
				(!radioButton1.Checked && !radioButton2.Checked) ||
				comboBoxGymTime.SelectedIndex == -1 ||
				comboBoxMembership.SelectedIndex == -1)
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
			// (định dạng SĐT Việt Nam, ví dụ: 0901234567). Giữ SĐT ở dạng chữ (string)
			// để khi lưu vào database không bị mất số 0 ở đầu.
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
				return;
			}

			// --- Bắt đầu lấy dữ liệu sau khi đã kiểm tra an toàn ---
			string fname = txtFirstName.Text; // Họ
			string lname = txtLastName.Text; // Tên
			string gender = radioButton1.Checked ? radioButton1.Text : radioButton2.Text; // Rút gọn code if-else giới tính
			DateTime dob = dateTimePickerDOB.Value.Date; // Ngày sinh (lấy đúng kiểu ngày tháng)
			String email = txtEmail.Text; // Email
			DateTime joindate = dateTimePickerJoinDate.Value.Date; // Ngày tham gia (lấy đúng kiểu ngày tháng)
			String gymTime = comboBoxGymTime.Text; // Thời gian tập
			String address = txtAddress.Text; // Địa chỉ nhà
			String membership = comboBoxMembership.Text; // Gói đăng ký

			// Bắt đầu code kết nối database với winform
			// QUAN TRỌNG - SỬA LỖI MẤT DẤU TIẾNG VIỆT:
			// Cách cũ cộng chuỗi trực tiếp vào câu lệnh SQL khiến SQL Server hiểu các
			// chữ trong dấu '...' là kiểu VARCHAR (không hỗ trợ đầy đủ tiếng Việt),
			// nên các dấu như ệ, ồ, ữ bị biến thành dấu '?' ngay lúc lưu (ví dụ:
			// "thiện" -> "thi?n", "Đồng Nai" -> "Đ?ng Nai") dù cột trong bảng là NVARCHAR.
			// Cách mới dùng tham số (@...): dữ liệu chữ được gửi đi đúng kiểu NVARCHAR
			// nên tiếng Việt có dấu lưu đúng 100%, đồng thời tránh lỗi SQL Injection.
			try
			{
				using (SqlConnection con = new SqlConnection("data source = DESKTOP-6R52ARN\\SQLEXPRESS; database = gym; integrated security = True; TrustServerCertificate=True"))
				{
					string query = "INSERT INTO NewMember (Fname, Lname, Gender, Dob, Mobile, Email, JoinDate, Gymtime, Maddress, MembershipTime) " +
								   "VALUES (@Fname, @Lname, @Gender, @Dob, @Mobile, @Email, @JoinDate, @Gymtime, @Maddress, @MembershipTime)";
					using (SqlCommand cmd = new SqlCommand(query, con))
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

						con.Open();
						cmd.ExecuteNonQuery();
					}
				}
				MessageBox.Show("Lưu thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Không lưu được vào database. Hãy kiểm tra SQL Server đã bật chưa.\n\nChi tiết lỗi: " + ex.Message,
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

			// Trả ngày sinh và ngày tham gia về ngày hiện tại (DateTimePicker)
			dateTimePickerDOB.Value = DateTime.Now;
			dateTimePickerJoinDate.Value = DateTime.Now;

			// Xóa lựa chọn trong các danh sách thả xuống (ComboBox)
			comboBoxGymTime.SelectedIndex = -1;
			comboBoxMembership.SelectedIndex = -1;
			MessageBox.Show("Reset thành công.");
		}
	}
}