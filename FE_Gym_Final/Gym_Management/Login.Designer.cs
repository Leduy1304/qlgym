namespace Gym_Management
{
	partial class Login
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			label11 = new Label();
			label12 = new Label();
			label1 = new Label();
			label2 = new Label();
			txtUsername = new TextBox();
			txtPassword = new TextBox();
			chkShowPassword = new CheckBox();
			btnLogin = new Button();
			btnExit = new Button();
			btnRegister = new Button();
			labelHint = new Label();
			SuspendLayout();
			//
			// label11
			//
			label11.AutoSize = false;
			label11.BackColor = Color.Transparent;
			label11.Font = new Font("Monotype Corsiva", 28.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
			label11.ForeColor = Color.WhiteSmoke;
			label11.Location = new Point(0, 25);
			label11.Name = "label11";
			label11.Size = new Size(540, 50);
			label11.TabIndex = 0;
			label11.Text = "Anh Tú Gym";
			label11.TextAlign = ContentAlignment.MiddleCenter;
			//
			// label12
			//
			label12.AutoSize = false;
			label12.BackColor = Color.Transparent;
			label12.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
			label12.ForeColor = Color.Orange;
			label12.Location = new Point(0, 80);
			label12.Name = "label12";
			label12.Size = new Size(540, 32);
			label12.TabIndex = 1;
			label12.Text = "ĐĂNG NHẬP HỆ THỐNG";
			label12.TextAlign = ContentAlignment.MiddleCenter;
			//
			// label1
			//
			label1.AutoSize = false;
			label1.BackColor = Color.Transparent;
			label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
			label1.ForeColor = SystemColors.Control;
			label1.Location = new Point(50, 140);
			label1.Name = "label1";
			label1.Size = new Size(120, 30);
			label1.TabIndex = 2;
			label1.Text = "Tài khoản:";
			label1.TextAlign = ContentAlignment.MiddleRight;
			//
			// label2
			//
			label2.AutoSize = false;
			label2.BackColor = Color.Transparent;
			label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
			label2.ForeColor = SystemColors.Control;
			label2.Location = new Point(50, 195);
			label2.Name = "label2";
			label2.Size = new Size(120, 30);
			label2.TabIndex = 3;
			label2.Text = "Mật khẩu:";
			label2.TextAlign = ContentAlignment.MiddleRight;
			//
			// txtUsername
			//
			txtUsername.Font = new Font("Segoe UI", 10.5F);
			txtUsername.Location = new Point(180, 140);
			txtUsername.Name = "txtUsername";
			txtUsername.Size = new Size(290, 31);
			txtUsername.TabIndex = 4;
			//
			// txtPassword
			//
			txtPassword.Font = new Font("Segoe UI", 10.5F);
			txtPassword.Location = new Point(180, 195);
			txtPassword.Name = "txtPassword";
			txtPassword.Size = new Size(290, 31);
			txtPassword.TabIndex = 5;
			txtPassword.UseSystemPasswordChar = true;
			//
			// chkShowPassword
			//
			chkShowPassword.AutoSize = true;
			chkShowPassword.BackColor = Color.Transparent;
			chkShowPassword.Font = new Font("Segoe UI", 9.5F);
			chkShowPassword.ForeColor = Color.FromArgb(203, 213, 225);
			chkShowPassword.Location = new Point(180, 235);
			chkShowPassword.Name = "chkShowPassword";
			chkShowPassword.Size = new Size(135, 25);
			chkShowPassword.TabIndex = 6;
			chkShowPassword.Text = "Hiện mật khẩu";
			chkShowPassword.UseVisualStyleBackColor = false;
			chkShowPassword.CheckedChanged += chkShowPassword_CheckedChanged;
			//
			// btnLogin
			//
			btnLogin.BackColor = Color.FromArgb(16, 185, 129);
			btnLogin.FlatAppearance.BorderSize = 0;
			btnLogin.FlatStyle = FlatStyle.Flat;
			btnLogin.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
			btnLogin.ForeColor = Color.White;
			btnLogin.Location = new Point(90, 275);
			btnLogin.Name = "btnLogin";
			btnLogin.Size = new Size(175, 44);
			btnLogin.TabIndex = 7;
			btnLogin.Text = "ĐĂNG NHẬP";
			btnLogin.UseVisualStyleBackColor = false;
			btnLogin.Click += btnLogin_Click;
			//
			// btnExit
			//
			btnExit.BackColor = Color.FromArgb(71, 85, 105);
			btnExit.FlatAppearance.BorderSize = 0;
			btnExit.FlatStyle = FlatStyle.Flat;
			btnExit.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
			btnExit.ForeColor = Color.White;
			btnExit.Location = new Point(275, 275);
			btnExit.Name = "btnExit";
			btnExit.Size = new Size(175, 44);
			btnExit.TabIndex = 8;
			btnExit.Text = "THOÁT";
			btnExit.UseVisualStyleBackColor = false;
			btnExit.Click += btnExit_Click;
			//
			// btnRegister
			//
			btnRegister.BackColor = Color.FromArgb(245, 158, 11);
			btnRegister.FlatAppearance.BorderSize = 0;
			btnRegister.FlatStyle = FlatStyle.Flat;
			btnRegister.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
			btnRegister.ForeColor = Color.White;
			btnRegister.Location = new Point(90, 332);
			btnRegister.Name = "btnRegister";
			btnRegister.Size = new Size(360, 44);
			btnRegister.TabIndex = 9;
			btnRegister.Text = "📝 ĐĂNG KÝ TÀI KHOẢN MỚI";
			btnRegister.UseVisualStyleBackColor = false;
			btnRegister.Click += btnRegister_Click;
			//
			// labelHint
			//
			labelHint.AutoSize = false;
			labelHint.BackColor = Color.Transparent;
			labelHint.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
			labelHint.ForeColor = Color.FromArgb(148, 163, 184);
			labelHint.Location = new Point(0, 395);
			labelHint.Name = "labelHint";
			labelHint.Size = new Size(540, 30);
			labelHint.TabIndex = 10;
			labelHint.Text = "💡 Tài khoản Quản trị viên mặc định: admin / 12345";
			labelHint.TextAlign = ContentAlignment.MiddleCenter;
			//
			// Login
			//
			AcceptButton = btnLogin;
			AutoScaleDimensions = new SizeF(9F, 23F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(30, 41, 59);
			CancelButton = btnExit;
			ClientSize = new Size(540, 445);
			Controls.Add(labelHint);
			Controls.Add(btnRegister);
			Controls.Add(btnExit);
			Controls.Add(btnLogin);
			Controls.Add(chkShowPassword);
			Controls.Add(txtPassword);
			Controls.Add(txtUsername);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(label12);
			Controls.Add(label11);
			Font = new Font("Segoe UI", 10.2F);
			ForeColor = SystemColors.Control;
			FormBorderStyle = FormBorderStyle.FixedSingle;
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "Login";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Đăng nhập - Hệ Thống Quản Lý Gym Anh Tú";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label11;
		private Label label12;
		private Label label1;
		private Label label2;
		private TextBox txtUsername;
		private TextBox txtPassword;
		private CheckBox chkShowPassword;
		private Button btnLogin;
		private Button btnExit;
		private Button btnRegister;
		private Label labelHint;
	}
}
