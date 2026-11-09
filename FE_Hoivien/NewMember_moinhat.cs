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

			// 3. Kiểm tra số điện thoại (Bắt buộc phải là số)
			// Int64.TryParse sẽ cố gắng chuyển đổi chuỗi thành số. Nếu thất bại (do có chữ), nó trả về false.
			if (!Int64.TryParse(txtMobile.Text, out Int64 mobile))
			{
				MessageBox.Show("Số điện thoại không hợp lệ. Vui lòng chỉ nhập các chữ số!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			// --- Bắt đầu lấy dữ liệu sau khi đã kiểm tra an toàn ---
			string fname = txtFirstName.Text; // Họ
			string lname = txtLastName.Text; // Tên
			string gender = radioButton1.Checked ? radioButton1.Text : radioButton2.Text; // Rút gọn code if-else giới tính
			String dob = dateTimePickerDOB.Text; // Ngày sinh
			String email = txtEmail.Text; // Email
			String joindate = dateTimePickerJoinDate.Text; // Ngày tham gia
			String gymTime = comboBoxGymTime.Text; // Thời gian tập
			String address = txtAddress.Text; // Địa chỉ nhà
			String membership = comboBoxMembership.Text; // Gói đăng ký

			// Bắt đầu code kết nối database với winform
			SqlConnection con = new SqlConnection();
			con.ConnectionString = "data source = ADMIN-PC\\SQLEXPRESS; database = gym; integrated security = True; TrustServerCertificate=True";
			SqlCommand cmd = new SqlCommand();
			cmd.Connection = con;

			cmd.CommandText = "insert into NewMember (Fname,Lname,Gender,Dob,Mobile,Email,JoinDate,Gymtime,Maddress,MembershipTime) values ('" + fname + "', '" + lname + "', '" + gender + "', '" + dob + "', " + mobile + ", '" + email + "', '" + joindate + "', '" + gymTime + "', '" + address + "', '" + membership + "' )";
			SqlDataAdapter DA = new SqlDataAdapter(cmd);
			DataSet DS = new DataSet();
			DA.Fill(DS);
			MessageBox.Show("Lưu thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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