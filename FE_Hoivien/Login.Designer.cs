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
			labelHint = new Label();
			SuspendLayout();
			//
			// label11
			//
			label11.AutoSize = true;
			label11.BackColor = Color.Transparent;
			label11.Font = new Font("Monotype Corsiva", 28.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
			label11.ForeColor = Color.WhiteSmoke;
			label11.Location = new Point(145, 30);
			label11.Name = "label11";
			label11.Size = new Size(249, 56);
			label11.TabIndex = 0;
			label11.Text = "Anh Tú Gym";
			//
			// label12
			//
			label12.AutoSize = true;
			label12.BackColor = Color.Transparent;
			label12.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
			label12.ForeColor = Color.Orange;
			label12.Location = new Point(185, 100);
			label12.Name = "label12";
			label12.Size = new Size(170, 32);
			label12.TabIndex = 1;
			label12.Text = "ĐĂNG NHẬP";
			//
			// label1
			//
			label1.BackColor = Color.Transparent;
			label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
			label1.ForeColor = SystemColors.Control;
			label1.Location = new Point(40, 170);
			label1.Name = "label1";
			label1.Size = new Size(130, 28);
			label1.TabIndex = 2;
			label1.Text = "Tài khoản";
			label1.TextAlign = ContentAlignment.TopRight;
			//
			// label2
			//
			label2.BackColor = Color.Transparent;
			label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
			label2.ForeColor = SystemColors.Control;
			label2.Location = new Point(40, 236);
			label2.Name = "label2";
			label2.Size = new Size(130, 28);
			label2.TabIndex = 3;
			label2.Text = "Mật khẩu";
			label2.TextAlign = ContentAlignment.TopRight;
			//
			// txtUsername
			//
			txtUsername.Location = new Point(190, 168);
			txtUsername.Name = "txtUsername";
			txtUsername.Size = new Size(280, 30);
			txtUsername.TabIndex = 4;
			//
			// txtPassword
			//
			txtPassword.Location = new Point(190, 234);
			txtPassword.Name = "txtPassword";
			txtPassword.Size = new Size(280, 30);
			txtPassword.TabIndex = 5;
			txtPassword.UseSystemPasswordChar = true;
			//
			// chkShowPassword
			//
			chkShowPassword.AutoSize = true;
			chkShowPassword.BackColor = Color.Transparent;
			chkShowPassword.Font = new Font("Segoe UI", 10.2F);
			chkShowPassword.ForeColor = SystemColors.Control;
			chkShowPassword.Location = new Point(190, 280);
			chkShowPassword.Name = "chkShowPassword";
			chkShowPassword.Size = new Size(133, 27);
			chkShowPassword.TabIndex = 6;
			chkShowPassword.Text = "Hiện mật khẩu";
			chkShowPassword.UseVisualStyleBackColor = false;
			chkShowPassword.CheckedChanged += chkShowPassword_CheckedChanged;
			//
			// btnLogin
			//
			btnLogin.BackColor = SystemColors.Control;
			btnLogin.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
			btnLogin.ForeColor = SystemColors.ActiveCaptionText;
			btnLogin.Location = new Point(120, 340);
			btnLogin.Name = "btnLogin";
			btnLogin.Size = new Size(140, 44);
			btnLogin.TabIndex = 7;
			btnLogin.Text = "ĐĂNG NHẬP";
			btnLogin.UseVisualStyleBackColor = false;
			btnLogin.Click += btnLogin_Click;
			//
			// btnExit
			//
			btnExit.BackColor = Color.MistyRose;
			btnExit.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
			btnExit.ForeColor = SystemColors.ActiveCaptionText;
			btnExit.Location = new Point(300, 340);
			btnExit.Name = "btnExit";
			btnExit.Size = new Size(110, 44);
			btnExit.TabIndex = 8;
			btnExit.Text = "THOÁT";
			btnExit.UseVisualStyleBackColor = false;
			btnExit.Click += btnExit_Click;
			//
			// labelHint
			//
			labelHint.AutoSize = true;
			labelHint.BackColor = Color.Transparent;
			labelHint.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
			labelHint.ForeColor = Color.LightGray;
			labelHint.Location = new Point(110, 410);
			labelHint.Name = "labelHint";
			labelHint.Size = new Size(330, 20);
			labelHint.TabIndex = 9;
			labelHint.Text = "Tài khoản mặc định: admin  /  Mật khẩu: 12345";
			//
			// Login
			//
			AcceptButton = btnLogin;
			AutoScaleDimensions = new SizeF(9F, 23F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(41, 44, 51);
			CancelButton = btnExit;
			ClientSize = new Size(540, 460);
			Controls.Add(labelHint);
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
			Text = "Đăng nhập - Gym Management";
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
		private Label labelHint;
	}
}
