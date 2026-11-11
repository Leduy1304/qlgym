namespace Gym_Management
{
	partial class NewMember
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewMember));
			txtFirstName = new TextBox();
			txtLastName = new TextBox();
			radioButton1 = new RadioButton();
			radioButton2 = new RadioButton();
			dateTimePickerDOB = new DateTimePicker();
			txtMobile = new TextBox();
			txtEmail = new TextBox();
			dateTimePickerJoinDate = new DateTimePicker();
			txtAddress = new RichTextBox();
			labelPT = new Label();
			comboBoxPT = new ComboBox();
			comboBoxGymTime = new ComboBox();
			comboBoxMembership = new ComboBox();
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			label4 = new Label();
			label5 = new Label();
			label6 = new Label();
			label7 = new Label();
			label8 = new Label();
			label9 = new Label();
			label10 = new Label();
			btnSave = new Button();
			btnReset = new Button();
			label11 = new Label();
			pictureBox1 = new PictureBox();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// txtFirstName
			// 
			txtFirstName.Location = new Point(245, 228);
			txtFirstName.Name = "txtFirstName";
			txtFirstName.Size = new Size(240, 30);
			txtFirstName.TabIndex = 0;
			// 
			// txtLastName
			// 
			txtLastName.Location = new Point(245, 283);
			txtLastName.Name = "txtLastName";
			txtLastName.Size = new Size(240, 30);
			txtLastName.TabIndex = 1;
			// 
			// radioButton1
			// 
			radioButton1.AutoSize = true;
			radioButton1.BackColor = Color.Transparent;
			radioButton1.Font = new Font("Segoe UI", 10.2F);
			radioButton1.ForeColor = SystemColors.Control;
			radioButton1.Location = new Point(245, 342);
			radioButton1.Name = "radioButton1";
			radioButton1.Size = new Size(75, 27);
			radioButton1.TabIndex = 2;
			radioButton1.TabStop = true;
			radioButton1.Text = "Nam";
			radioButton1.UseVisualStyleBackColor = false;
			// 
			// radioButton2
			// 
			radioButton2.AutoSize = true;
			radioButton2.BackColor = Color.Transparent;
			radioButton2.Font = new Font("Segoe UI", 10.2F);
			radioButton2.ForeColor = SystemColors.Control;
			radioButton2.Location = new Point(345, 342);
			radioButton2.Name = "radioButton2";
			radioButton2.Size = new Size(75, 27);
			radioButton2.TabIndex = 3;
			radioButton2.TabStop = true;
			radioButton2.Text = "Nữ";
			radioButton2.UseVisualStyleBackColor = false;
			// 
			// dateTimePickerDOB
			// 
			dateTimePickerDOB.Format = DateTimePickerFormat.Short;
			dateTimePickerDOB.Location = new Point(245, 393);
			dateTimePickerDOB.Name = "dateTimePickerDOB";
			dateTimePickerDOB.Size = new Size(240, 30);
			dateTimePickerDOB.TabIndex = 4;
			// 
			// txtMobile
			// 
			txtMobile.Location = new Point(245, 448);
			txtMobile.Name = "txtMobile";
			txtMobile.Size = new Size(240, 30);
			txtMobile.TabIndex = 5;
			// 
			// txtEmail
			// 
			txtEmail.Location = new Point(725, 228);
			txtEmail.Name = "txtEmail";
			txtEmail.Size = new Size(270, 30);
			txtEmail.TabIndex = 6;
			// 
			// dateTimePickerJoinDate
			// 
			dateTimePickerJoinDate.Format = DateTimePickerFormat.Short;
			dateTimePickerJoinDate.Location = new Point(725, 283);
			dateTimePickerJoinDate.Name = "dateTimePickerJoinDate";
			dateTimePickerJoinDate.Size = new Size(270, 30);
			dateTimePickerJoinDate.TabIndex = 7;
			// 
			// comboBoxGymTime
			// 
			comboBoxGymTime.DropDownStyle = ComboBoxStyle.DropDownList;
			comboBoxGymTime.FormattingEnabled = true;
			comboBoxGymTime.Items.AddRange(new object[] {
            "06:00 - 08:00 (Sáng sớm)",
            "08:00 - 10:00 (Buổi sáng)",
            "14:00 - 16:00 (Đầu giờ chiều)",
            "16:00 - 18:00 (Chiều tan tầm)",
            "18:00 - 20:00 (Buổi tối)",
            "20:00 - 22:00 (Tối muộn)"});
			comboBoxGymTime.Location = new Point(725, 338);
			comboBoxGymTime.Name = "comboBoxGymTime";
			comboBoxGymTime.Size = new Size(270, 31);
			comboBoxGymTime.TabIndex = 8;
			// 
			// comboBoxMembership
			// 
			comboBoxMembership.DropDownStyle = ComboBoxStyle.DropDownList;
			comboBoxMembership.FormattingEnabled = true;
			comboBoxMembership.Items.AddRange(new object[] {
            "Gói 1 Tháng (300,000 đ) - Thẻ tập tiêu chuẩn",
            "Gói 3 Tháng (850,000 đ) - Tiết kiệm 5% + Đo InBody",
            "Gói 6 Tháng (1,600,000 đ) - Tiết kiệm 10% + 1 buổi PT",
            "Gói 12 Tháng VIP (3,000,000 đ) - Không giới hạn + Tủ riêng"});
			comboBoxMembership.Location = new Point(725, 393);
			comboBoxMembership.Name = "comboBoxMembership";
			comboBoxMembership.Size = new Size(270, 31);
			comboBoxMembership.TabIndex = 9;
			// 
			// labelPT
			// 
			labelPT.BackColor = Color.Transparent;
			labelPT.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
			labelPT.ForeColor = Color.FromArgb(74, 222, 128);
			labelPT.Location = new Point(520, 450);
			labelPT.Name = "labelPT";
			labelPT.Size = new Size(190, 28);
			labelPT.TabIndex = 21;
			labelPT.Text = "HLV (PT) phụ trách:";
			labelPT.TextAlign = ContentAlignment.MiddleRight;
			// 
			// comboBoxPT
			// 
			comboBoxPT.DropDownStyle = ComboBoxStyle.DropDownList;
			comboBoxPT.FormattingEnabled = true;
			comboBoxPT.Location = new Point(725, 448);
			comboBoxPT.Name = "comboBoxPT";
			comboBoxPT.Size = new Size(270, 31);
			comboBoxPT.TabIndex = 10;
			// 
			// txtAddress
			// 
			txtAddress.Location = new Point(245, 503);
			txtAddress.Name = "txtAddress";
			txtAddress.Size = new Size(750, 75);
			txtAddress.TabIndex = 11;
			txtAddress.Text = "";
			// 
			// label1
			// 
			label1.BackColor = Color.Transparent;
			label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
			label1.ForeColor = SystemColors.Control;
			label1.Location = new Point(50, 230);
			label1.Name = "label1";
			label1.Size = new Size(180, 28);
			label1.TabIndex = 12;
			label1.Text = "Họ:";
			label1.TextAlign = ContentAlignment.MiddleRight;
			// 
			// label2
			// 
			label2.BackColor = Color.Transparent;
			label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
			label2.ForeColor = SystemColors.Control;
			label2.Location = new Point(50, 285);
			label2.Name = "label2";
			label2.Size = new Size(180, 28);
			label2.TabIndex = 13;
			label2.Text = "Tên:";
			label2.TextAlign = ContentAlignment.MiddleRight;
			// 
			// label3
			// 
			label3.BackColor = Color.Transparent;
			label3.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
			label3.ForeColor = SystemColors.Control;
			label3.Location = new Point(50, 340);
			label3.Name = "label3";
			label3.Size = new Size(180, 28);
			label3.TabIndex = 14;
			label3.Text = "Giới tính:";
			label3.TextAlign = ContentAlignment.MiddleRight;
			// 
			// label4
			// 
			label4.BackColor = Color.Transparent;
			label4.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
			label4.ForeColor = SystemColors.Control;
			label4.Location = new Point(50, 395);
			label4.Name = "label4";
			label4.Size = new Size(180, 28);
			label4.TabIndex = 15;
			label4.Text = "Ngày sinh:";
			label4.TextAlign = ContentAlignment.MiddleRight;
			// 
			// label5
			// 
			label5.BackColor = Color.Transparent;
			label5.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
			label5.ForeColor = SystemColors.Control;
			label5.Location = new Point(50, 450);
			label5.Name = "label5";
			label5.Size = new Size(180, 28);
			label5.TabIndex = 16;
			label5.Text = "Số điện thoại:";
			label5.TextAlign = ContentAlignment.MiddleRight;
			// 
			// label6
			// 
			label6.BackColor = Color.Transparent;
			label6.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
			label6.ForeColor = SystemColors.Control;
			label6.Location = new Point(520, 230);
			label6.Name = "label6";
			label6.Size = new Size(190, 28);
			label6.TabIndex = 17;
			label6.Text = "Email:";
			label6.TextAlign = ContentAlignment.MiddleRight;
			// 
			// label7
			// 
			label7.BackColor = Color.Transparent;
			label7.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
			label7.ForeColor = SystemColors.Control;
			label7.Location = new Point(520, 285);
			label7.Name = "label7";
			label7.Size = new Size(190, 28);
			label7.TabIndex = 18;
			label7.Text = "Ngày đăng ký:";
			label7.TextAlign = ContentAlignment.MiddleRight;
			// 
			// label8
			// 
			label8.BackColor = Color.Transparent;
			label8.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
			label8.ForeColor = SystemColors.Control;
			label8.Location = new Point(520, 340);
			label8.Name = "label8";
			label8.Size = new Size(190, 28);
			label8.TabIndex = 19;
			label8.Text = "Giờ tập luyện:";
			label8.TextAlign = ContentAlignment.MiddleRight;
			// 
			// label10
			// 
			label10.BackColor = Color.Transparent;
			label10.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
			label10.ForeColor = SystemColors.Control;
			label10.Location = new Point(520, 395);
			label10.Name = "label10";
			label10.Size = new Size(190, 28);
			label10.TabIndex = 20;
			label10.Text = "Gói tập:";
			label10.TextAlign = ContentAlignment.MiddleRight;
			// 
			// label9
			// 
			label9.BackColor = Color.Transparent;
			label9.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
			label9.ForeColor = SystemColors.Control;
			label9.Location = new Point(50, 505);
			label9.Name = "label9";
			label9.Size = new Size(180, 28);
			label9.TabIndex = 22;
			label9.Text = "Địa chỉ:";
			label9.TextAlign = ContentAlignment.MiddleRight;
			// 
			// btnSave
			// 
			btnSave.BackColor = Color.FromArgb(16, 185, 129);
			btnSave.FlatAppearance.BorderSize = 0;
			btnSave.FlatStyle = FlatStyle.Flat;
			btnSave.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
			btnSave.ForeColor = Color.White;
			btnSave.Location = new Point(400, 600);
			btnSave.Name = "btnSave";
			btnSave.Size = new Size(130, 44);
			btnSave.TabIndex = 23;
			btnSave.Text = "💾 LƯU";
			btnSave.UseVisualStyleBackColor = false;
			btnSave.Click += btnSave_Click;
			// 
			// btnReset
			// 
			btnReset.BackColor = Color.FromArgb(71, 85, 105);
			btnReset.FlatAppearance.BorderSize = 0;
			btnReset.FlatStyle = FlatStyle.Flat;
			btnReset.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
			btnReset.ForeColor = Color.White;
			btnReset.Location = new Point(550, 600);
			btnReset.Name = "btnReset";
			btnReset.Size = new Size(130, 44);
			btnReset.TabIndex = 24;
			btnReset.Text = "📋 RESET";
			btnReset.UseVisualStyleBackColor = false;
			btnReset.Click += btnReset_Click;
			// 
			// label11
			// 
			label11.BackColor = Color.Transparent;
			label11.Font = new Font("Monotype Corsiva", 28.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
			label11.ForeColor = Color.WhiteSmoke;
			label11.Location = new Point(0, 118);
			label11.Name = "label11";
			label11.Size = new Size(1064, 56);
			label11.TabIndex = 25;
			label11.Text = "Anh Tú Gym";
			label11.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// pictureBox1
			// 
			pictureBox1.BackColor = Color.Transparent;
			pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
			pictureBox1.Location = new Point(406, 10);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(252, 105);
			pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox1.TabIndex = 26;
			pictureBox1.TabStop = false;
			// 
			// NewMember
			// 
			AutoScaleDimensions = new SizeF(9F, 23F);
			AutoScaleMode = AutoScaleMode.Font;
			BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
			BackgroundImageLayout = ImageLayout.Stretch;
			ClientSize = new Size(1064, 680);
			Controls.Add(comboBoxPT);
			Controls.Add(labelPT);
			Controls.Add(pictureBox1);
			Controls.Add(label11);
			Controls.Add(btnReset);
			Controls.Add(btnSave);
			Controls.Add(label10);
			Controls.Add(label9);
			Controls.Add(label8);
			Controls.Add(label7);
			Controls.Add(label6);
			Controls.Add(label5);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(comboBoxMembership);
			Controls.Add(comboBoxGymTime);
			Controls.Add(txtAddress);
			Controls.Add(txtEmail);
			Controls.Add(txtMobile);
			Controls.Add(dateTimePickerJoinDate);
			Controls.Add(dateTimePickerDOB);
			Controls.Add(radioButton2);
			Controls.Add(radioButton1);
			Controls.Add(txtLastName);
			Controls.Add(txtFirstName);
			Font = new Font("Segoe UI", 10.2F);
			ForeColor = SystemColors.Control;
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "NewMember";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Thêm Hội Viên Mới - Hệ Thống Quản Lý Gym Anh Tú";
			Load += NewMember_Load;
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox txtFirstName;
		private TextBox txtLastName;
		private RadioButton radioButton1;
		private RadioButton radioButton2;
		private DateTimePicker dateTimePickerDOB;
		private TextBox txtMobile;
		private TextBox txtEmail;
		private DateTimePicker dateTimePickerJoinDate;
		private RichTextBox txtAddress;
		private ComboBox comboBoxGymTime;
		private ComboBox comboBoxMembership;
		private Label labelPT;
		private ComboBox comboBoxPT;
		private Label label1;
		private Label label2;
		private Label label3;
		private Label label4;
		private Label label5;
		private Label label6;
		private Label label7;
		private Label label8;
		private Label label9;
		private Label label10;
		private Button btnSave;
		private Button btnReset;
		private Label label11;
		private PictureBox pictureBox1;
	}
}