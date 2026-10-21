using System;
using System.Windows.Forms;

namespace Gym_Management
{
	public partial class Login : Form
	{
		// Tài khoản đăng nhập mặc định của chương trình.
		// Muốn đổi tài khoản / mật khẩu thì chỉ cần sửa 2 dòng này.
		private const string AdminUsername = "admin";
		private const string AdminPassword = "12345";

		public Login()
		{
			InitializeComponent();
		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			// 1. Kiểm tra rỗng
			if (string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
			{
				MessageBox.Show("Vui lòng nhập đầy đủ Tài khoản và Mật khẩu!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			// 2. Kiểm tra tài khoản / mật khẩu
			if (txtUsername.Text.Trim() == AdminUsername && txtPassword.Text == AdminPassword)
			{
				// Đăng nhập đúng: trả về OK để Program mở form chính (Form1).
				// Khi bấm LOG OUT ở form chính, chương trình sẽ quay lại form đăng nhập này.
				this.DialogResult = DialogResult.OK;
				this.Close();
			}
			else
			{
				MessageBox.Show("Tài khoản hoặc Mật khẩu không đúng. Vui lòng thử lại!", "Đăng nhập thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
				txtPassword.Clear();
				txtPassword.Focus();
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
