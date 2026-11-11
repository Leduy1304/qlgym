namespace Gym_Management
{
	partial class RegisterForm
	{
		private System.ComponentModel.IContainer components = null;

		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		private void InitializeComponent()
		{
			labelTitle = new Label();
			lblVaiTro = new Label();
			cmbVaiTro = new ComboBox();
			lblTenDangNhap = new Label();
			txtTenDangNhap = new TextBox();
			lblMatKhau = new Label();
			txtMatKhau = new TextBox();
			lblNhapLai = new Label();
			txtNhapLai = new TextBox();
			chkShowPassword = new CheckBox();
			lblHo = new Label();
			txtHo = new TextBox();
			lblTen = new Label();
			txtTen = new TextBox();
			lblGioiTinh = new Label();
			cmbGioiTinh = new ComboBox();
			lblNgaySinh = new Label();
			dtpNgaySinh = new DateTimePicker();
			lblSDT = new Label();
			txtSDT = new TextBox();
			lblEmail = new Label();
			txtEmail = new TextBox();
			lblDiaChi = new Label();
			txtDiaChi = new TextBox();
			lblNote = new Label();
			btnDangKy = new Button();
			btnHuy = new Button();
			SuspendLayout();
			//
			// labelTitle
			//
			labelTitle.AutoSize = false;
			labelTitle.BackColor = Color.Transparent;
			labelTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
			labelTitle.ForeColor = Color.Orange;
			labelTitle.Location = new Point(0, 20);
			labelTitle.Name = "labelTitle";
			labelTitle.Size = new Size(560, 32);
			labelTitle.TabIndex = 0;
			labelTitle.Text = "ĐĂNG KÝ TÀI KHOẢN";
			labelTitle.TextAlign = ContentAlignment.MiddleCenter;
			//
			// lblVaiTro
			//
			lblVaiTro.BackColor = Color.Transparent;
			lblVaiTro.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
			lblVaiTro.ForeColor = SystemColors.Control;
			lblVaiTro.Location = new Point(40, 70);
			lblVaiTro.Name = "lblVaiTro";
			lblVaiTro.Size = new Size(140, 28);
			lblVaiTro.TabIndex = 1;
			lblVaiTro.Text = "Vai trò";
			lblVaiTro.TextAlign = ContentAlignment.TopRight;
			//
			// cmbVaiTro
			//
			cmbVaiTro.DropDownStyle = ComboBoxStyle.DropDownList;
			cmbVaiTro.Items.AddRange(new object[] { "Hội viên", "Huấn luyện viên (PT)" });
			cmbVaiTro.Location = new Point(190, 68);
			cmbVaiTro.Name = "cmbVaiTro";
			cmbVaiTro.Size = new Size(300, 31);
			cmbVaiTro.TabIndex = 2;
			cmbVaiTro.SelectedIndexChanged += cmbVaiTro_SelectedIndexChanged;
			//
			// lblTenDangNhap
			//
			lblTenDangNhap.BackColor = Color.Transparent;
			lblTenDangNhap.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
			lblTenDangNhap.ForeColor = SystemColors.Control;
			lblTenDangNhap.Location = new Point(40, 112);
			lblTenDangNhap.Name = "lblTenDangNhap";
			lblTenDangNhap.Size = new Size(140, 28);
			lblTenDangNhap.TabIndex = 3;
			lblTenDangNhap.Text = "Tài khoản";
			lblTenDangNhap.TextAlign = ContentAlignment.TopRight;
			//
			// txtTenDangNhap
			//
			txtTenDangNhap.Location = new Point(190, 110);
			txtTenDangNhap.Name = "txtTenDangNhap";
			txtTenDangNhap.Size = new Size(300, 30);
			txtTenDangNhap.TabIndex = 4;
			//
			// lblMatKhau
			//
			lblMatKhau.BackColor = Color.Transparent;
			lblMatKhau.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
			lblMatKhau.ForeColor = SystemColors.Control;
			lblMatKhau.Location = new Point(40, 154);
			lblMatKhau.Name = "lblMatKhau";
			lblMatKhau.Size = new Size(140, 28);
			lblMatKhau.TabIndex = 5;
			lblMatKhau.Text = "Mật khẩu";
			lblMatKhau.TextAlign = ContentAlignment.TopRight;
			//
			// txtMatKhau
			//
			txtMatKhau.Location = new Point(190, 152);
			txtMatKhau.Name = "txtMatKhau";
			txtMatKhau.Size = new Size(300, 30);
			txtMatKhau.TabIndex = 6;
			txtMatKhau.UseSystemPasswordChar = true;
			//
			// lblNhapLai
			//
			lblNhapLai.BackColor = Color.Transparent;
			lblNhapLai.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
			lblNhapLai.ForeColor = SystemColors.Control;
			lblNhapLai.Location = new Point(40, 196);
			lblNhapLai.Name = "lblNhapLai";
			lblNhapLai.Size = new Size(140, 28);
			lblNhapLai.TabIndex = 7;
			lblNhapLai.Text = "Nhập lại MK";
			lblNhapLai.TextAlign = ContentAlignment.TopRight;
			//
			// txtNhapLai
			//
			txtNhapLai.Location = new Point(190, 194);
			txtNhapLai.Name = "txtNhapLai";
			txtNhapLai.Size = new Size(300, 30);
			txtNhapLai.TabIndex = 8;
			txtNhapLai.UseSystemPasswordChar = true;
			//
			// chkShowPassword
			//
			chkShowPassword.AutoSize = true;
			chkShowPassword.BackColor = Color.Transparent;
			chkShowPassword.Font = new Font("Segoe UI", 10.2F);
			chkShowPassword.ForeColor = SystemColors.Control;
			chkShowPassword.Location = new Point(190, 230);
			chkShowPassword.Name = "chkShowPassword";
			chkShowPassword.Size = new Size(133, 27);
			chkShowPassword.TabIndex = 9;
			chkShowPassword.Text = "Hiện mật khẩu";
			chkShowPassword.UseVisualStyleBackColor = false;
			chkShowPassword.CheckedChanged += chkShowPassword_CheckedChanged;
			//
			// lblHo
			//
			lblHo.BackColor = Color.Transparent;
			lblHo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
			lblHo.ForeColor = SystemColors.Control;
			lblHo.Location = new Point(40, 264);
			lblHo.Name = "lblHo";
			lblHo.Size = new Size(140, 28);
			lblHo.TabIndex = 10;
			lblHo.Text = "Họ";
			lblHo.TextAlign = ContentAlignment.TopRight;
			//
			// txtHo
			//
			txtHo.Location = new Point(190, 262);
			txtHo.Name = "txtHo";
			txtHo.Size = new Size(300, 30);
			txtHo.TabIndex = 11;
			//
			// lblTen
			//
			lblTen.BackColor = Color.Transparent;
			lblTen.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
			lblTen.ForeColor = SystemColors.Control;
			lblTen.Location = new Point(40, 306);
			lblTen.Name = "lblTen";
			lblTen.Size = new Size(140, 28);
			lblTen.TabIndex = 12;
			lblTen.Text = "Tên";
			lblTen.TextAlign = ContentAlignment.TopRight;
			//
			// txtTen
			//
			txtTen.Location = new Point(190, 304);
			txtTen.Name = "txtTen";
			txtTen.Size = new Size(300, 30);
			txtTen.TabIndex = 13;
			//
			// lblGioiTinh
			//
			lblGioiTinh.BackColor = Color.Transparent;
			lblGioiTinh.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
			lblGioiTinh.ForeColor = SystemColors.Control;
			lblGioiTinh.Location = new Point(40, 348);
			lblGioiTinh.Name = "lblGioiTinh";
			lblGioiTinh.Size = new Size(140, 28);
			lblGioiTinh.TabIndex = 14;
			lblGioiTinh.Text = "Giới tính";
			lblGioiTinh.TextAlign = ContentAlignment.TopRight;
			//
			// cmbGioiTinh
			//
			cmbGioiTinh.DropDownStyle = ComboBoxStyle.DropDownList;
			cmbGioiTinh.Items.AddRange(new object[] { "Nam", "Nữ", "Khác" });
			cmbGioiTinh.Location = new Point(190, 346);
			cmbGioiTinh.Name = "cmbGioiTinh";
			cmbGioiTinh.Size = new Size(300, 31);
			cmbGioiTinh.TabIndex = 15;
			//
			// lblNgaySinh
			//
			lblNgaySinh.BackColor = Color.Transparent;
			lblNgaySinh.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
			lblNgaySinh.ForeColor = SystemColors.Control;
			lblNgaySinh.Location = new Point(40, 390);
			lblNgaySinh.Name = "lblNgaySinh";
			lblNgaySinh.Size = new Size(140, 28);
			lblNgaySinh.TabIndex = 16;
			lblNgaySinh.Text = "Ngày sinh";
			lblNgaySinh.TextAlign = ContentAlignment.TopRight;
			//
			// dtpNgaySinh
			//
			dtpNgaySinh.Format = DateTimePickerFormat.Short;
			dtpNgaySinh.Location = new Point(190, 388);
			dtpNgaySinh.Name = "dtpNgaySinh";
			dtpNgaySinh.Size = new Size(300, 30);
			dtpNgaySinh.TabIndex = 17;
			dtpNgaySinh.Value = new DateTime(2004, 1, 1);
			//
			// lblSDT
			//
			lblSDT.BackColor = Color.Transparent;
			lblSDT.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
			lblSDT.ForeColor = SystemColors.Control;
			lblSDT.Location = new Point(40, 432);
			lblSDT.Name = "lblSDT";
			lblSDT.Size = new Size(140, 28);
			lblSDT.TabIndex = 18;
			lblSDT.Text = "Số điện thoại";
			lblSDT.TextAlign = ContentAlignment.TopRight;
			//
			// txtSDT
			//
			txtSDT.Location = new Point(190, 430);
			txtSDT.Name = "txtSDT";
			txtSDT.Size = new Size(300, 30);
			txtSDT.TabIndex = 19;
			//
			// lblEmail
			//
			lblEmail.BackColor = Color.Transparent;
			lblEmail.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
			lblEmail.ForeColor = SystemColors.Control;
			lblEmail.Location = new Point(40, 474);
			lblEmail.Name = "lblEmail";
			lblEmail.Size = new Size(140, 28);
			lblEmail.TabIndex = 20;
			lblEmail.Text = "Email";
			lblEmail.TextAlign = ContentAlignment.TopRight;
			//
			// txtEmail
			//
			txtEmail.Location = new Point(190, 472);
			txtEmail.Name = "txtEmail";
			txtEmail.Size = new Size(300, 30);
			txtEmail.TabIndex = 21;
			//
			// lblDiaChi
			//
			lblDiaChi.BackColor = Color.Transparent;
			lblDiaChi.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
			lblDiaChi.ForeColor = SystemColors.Control;
			lblDiaChi.Location = new Point(40, 516);
			lblDiaChi.Name = "lblDiaChi";
			lblDiaChi.Size = new Size(140, 28);
			lblDiaChi.TabIndex = 22;
			lblDiaChi.Text = "Địa chỉ";
			lblDiaChi.TextAlign = ContentAlignment.TopRight;
			//
			// txtDiaChi
			//
			txtDiaChi.Location = new Point(190, 514);
			txtDiaChi.Name = "txtDiaChi";
			txtDiaChi.Size = new Size(300, 30);
			txtDiaChi.TabIndex = 23;
			//
			// btnDangKy
			//
			btnDangKy.BackColor = Color.FromArgb(14, 165, 233);
			btnDangKy.FlatAppearance.BorderSize = 0;
			btnDangKy.FlatStyle = FlatStyle.Flat;
			btnDangKy.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
			btnDangKy.ForeColor = Color.White;
			btnDangKy.Location = new Point(130, 565);
			btnDangKy.Name = "btnDangKy";
			btnDangKy.Size = new Size(150, 42);
			btnDangKy.TabIndex = 24;
			btnDangKy.Text = "ĐĂNG KÝ";
			btnDangKy.UseVisualStyleBackColor = false;
			btnDangKy.Click += btnDangKy_Click;
			//
			// btnHuy
			//
			btnHuy.BackColor = Color.FromArgb(71, 85, 105);
			btnHuy.FlatAppearance.BorderSize = 0;
			btnHuy.FlatStyle = FlatStyle.Flat;
			btnHuy.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
			btnHuy.ForeColor = Color.White;
			btnHuy.Location = new Point(310, 565);
			btnHuy.Name = "btnHuy";
			btnHuy.Size = new Size(110, 42);
			btnHuy.TabIndex = 25;
			btnHuy.Text = "HỦY";
			btnHuy.UseVisualStyleBackColor = false;
			btnHuy.Click += btnHuy_Click;
			//
			// lblNote
			//
			lblNote.BackColor = Color.Transparent;
			lblNote.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
			lblNote.ForeColor = Color.FromArgb(148, 163, 184);
			lblNote.Location = new Point(40, 615);
			lblNote.Name = "lblNote";
			lblNote.Size = new Size(480, 24);
			lblNote.TabIndex = 26;
			lblNote.Text = "* Lưu ý: Gói tập và khung giờ tập có thể lựa chọn sau khi đăng nhập.";
			lblNote.TextAlign = ContentAlignment.MiddleCenter;
			//
			// RegisterForm
			//
			AcceptButton = btnDangKy;
			AutoScaleDimensions = new SizeF(9F, 23F);
			AutoScaleMode = AutoScaleMode.Font;
			AutoScroll = true;
			BackColor = Color.FromArgb(41, 44, 51);
			CancelButton = btnHuy;
			ClientSize = new Size(560, 650);
			Controls.Add(lblNote);
			Controls.Add(btnHuy);
			Controls.Add(btnDangKy);
			Controls.Add(txtDiaChi);
			Controls.Add(lblDiaChi);
			Controls.Add(txtEmail);
			Controls.Add(lblEmail);
			Controls.Add(txtSDT);
			Controls.Add(lblSDT);
			Controls.Add(dtpNgaySinh);
			Controls.Add(lblNgaySinh);
			Controls.Add(cmbGioiTinh);
			Controls.Add(lblGioiTinh);
			Controls.Add(txtTen);
			Controls.Add(lblTen);
			Controls.Add(txtHo);
			Controls.Add(lblHo);
			Controls.Add(chkShowPassword);
			Controls.Add(txtNhapLai);
			Controls.Add(lblNhapLai);
			Controls.Add(txtMatKhau);
			Controls.Add(lblMatKhau);
			Controls.Add(txtTenDangNhap);
			Controls.Add(lblTenDangNhap);
			Controls.Add(cmbVaiTro);
			Controls.Add(lblVaiTro);
			Controls.Add(labelTitle);
			Font = new Font("Segoe UI", 10.2F);
			ForeColor = SystemColors.Control;
			FormBorderStyle = FormBorderStyle.FixedSingle;
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "RegisterForm";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Đăng ký - Hệ Thống Quản Lý Gym Anh Tú";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label labelTitle;
		private Label lblVaiTro;
		private ComboBox cmbVaiTro;
		private Label lblTenDangNhap;
		private TextBox txtTenDangNhap;
		private Label lblMatKhau;
		private TextBox txtMatKhau;
		private Label lblNhapLai;
		private TextBox txtNhapLai;
		private CheckBox chkShowPassword;
		private Label lblHo;
		private TextBox txtHo;
		private Label lblTen;
		private TextBox txtTen;
		private Label lblGioiTinh;
		private ComboBox cmbGioiTinh;
		private Label lblNgaySinh;
		private DateTimePicker dtpNgaySinh;
		private Label lblSDT;
		private TextBox txtSDT;
		private Label lblEmail;
		private TextBox txtEmail;
		private Label lblDiaChi;
		private TextBox txtDiaChi;
		private Label lblNote;
		private Button btnDangKy;
		private Button btnHuy;
	}
}
