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
			txtFirstName.Location = new Point(264, 261);
			txtFirstName.Name = "txtFirstName";
			txtFirstName.Size = new Size(194, 30);
			txtFirstName.TabIndex = 0;
			// 
			// txtLastName
			// 
			txtLastName.Location = new Point(264, 327);
			txtLastName.Name = "txtLastName";
			txtLastName.Size = new Size(194, 30);
			txtLastName.TabIndex = 0;
			// 
			// radioButton1
			// 
			radioButton1.AutoSize = true;
			radioButton1.BackColor = Color.Transparent;
			radioButton1.Font = new Font("Segoe UI", 10.2F);
			radioButton1.ForeColor = SystemColors.Control;
			radioButton1.Location = new Point(264, 397);
			radioButton1.Name = "radioButton1";
			radioButton1.Size = new Size(68, 27);
			radioButton1.TabIndex = 1;
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
			radioButton2.Location = new Point(387, 397);
			radioButton2.Name = "radioButton2";
			radioButton2.Size = new Size(54, 27);
			radioButton2.TabIndex = 1;
			radioButton2.TabStop = true;
			radioButton2.Text = "Nữ";
			radioButton2.UseVisualStyleBackColor = false;
			// 
			// dateTimePickerDOB
			// 
			dateTimePickerDOB.Format = DateTimePickerFormat.Short;
			dateTimePickerDOB.Location = new Point(264, 462);
			dateTimePickerDOB.Name = "dateTimePickerDOB";
			dateTimePickerDOB.Size = new Size(119, 30);
			dateTimePickerDOB.TabIndex = 2;
			// 
			// txtMobile
			// 
			txtMobile.Location = new Point(271, 532);
			txtMobile.Name = "txtMobile";
			txtMobile.Size = new Size(187, 30);
			txtMobile.TabIndex = 3;
			// 
			// txtEmail
			// 
			txtEmail.Location = new Point(734, 260);
			txtEmail.Name = "txtEmail";
			txtEmail.Size = new Size(275, 30);
			txtEmail.TabIndex = 3;
			// 
			// dateTimePickerJoinDate
			// 
			dateTimePickerJoinDate.Format = DateTimePickerFormat.Short;
			dateTimePickerJoinDate.Location = new Point(734, 328);
			dateTimePickerJoinDate.Name = "dateTimePickerJoinDate";
			dateTimePickerJoinDate.Size = new Size(160, 30);
			dateTimePickerJoinDate.TabIndex = 2;
			// 
			// txtAddress
			// 
			txtAddress.Location = new Point(734, 466);
			txtAddress.Name = "txtAddress";
			txtAddress.Size = new Size(275, 137);
			txtAddress.TabIndex = 4;
			txtAddress.Text = "";
			// 
			// comboBoxGymTime
			// 
			comboBoxGymTime.DropDownStyle = ComboBoxStyle.DropDownList;
			comboBoxGymTime.FormattingEnabled = true;
			comboBoxGymTime.Items.AddRange(new object[] { "06AM-07AM", "07AM-08AM", "08AM-09AM", "05PM-06PM", "06PM-07PM", "07PM-08PM" });
			comboBoxGymTime.Location = new Point(734, 396);
			comboBoxGymTime.Name = "comboBoxGymTime";
			comboBoxGymTime.Size = new Size(160, 31);
			comboBoxGymTime.TabIndex = 5;
			// 
			// comboBoxMembership
			// 
			comboBoxMembership.DropDownStyle = ComboBoxStyle.DropDownList;
			comboBoxMembership.FormattingEnabled = true;
			comboBoxMembership.Items.AddRange(new object[] { "1 tháng", "2 tháng", "3 tháng", "6 tháng", "1 năm" });
			comboBoxMembership.Location = new Point(488, 644);
			comboBoxMembership.Name = "comboBoxMembership";
			comboBoxMembership.Size = new Size(212, 31);
			comboBoxMembership.TabIndex = 5;
			// 
			// label1
			// 
			label1.BackColor = Color.Transparent;
			label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
			label1.ForeColor = SystemColors.Control;
			label1.Image = (Image)resources.GetObject("label1.Image");
			label1.ImageAlign = ContentAlignment.MiddleLeft;
			label1.Location = new Point(148, 263);
			label1.Name = "label1";
			label1.Size = new Size(110, 28);
			label1.TabIndex = 6;
			label1.Text = "Họ";
			label1.TextAlign = ContentAlignment.TopCenter;
			// 
			// label2
			// 
			label2.BackColor = Color.Transparent;
			label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
			label2.ForeColor = SystemColors.Control;
			label2.Image = (Image)resources.GetObject("label2.Image");
			label2.ImageAlign = ContentAlignment.TopLeft;
			label2.Location = new Point(151, 323);
			label2.Name = "label2";
			label2.Size = new Size(70, 28);
			label2.TabIndex = 6;
			label2.Text = "Tên";
			label2.TextAlign = ContentAlignment.TopRight;
			// 
			// label3
			// 
			label3.BackColor = Color.Transparent;
			label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
			label3.ForeColor = SystemColors.Control;
			label3.Image = (Image)resources.GetObject("label3.Image");
			label3.ImageAlign = ContentAlignment.MiddleLeft;
			label3.Location = new Point(107, 394);
			label3.Name = "label3";
			label3.Size = new Size(122, 28);
			label3.TabIndex = 6;
			label3.Text = "Giới tính";
			label3.TextAlign = ContentAlignment.TopRight;
			// 
			// label4
			// 
			label4.BackColor = Color.Transparent;
			label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
			label4.ForeColor = SystemColors.Control;
			label4.Image = (Image)resources.GetObject("label4.Image");
			label4.ImageAlign = ContentAlignment.MiddleLeft;
			label4.Location = new Point(86, 460);
			label4.Name = "label4";
			label4.Size = new Size(135, 28);
			label4.TabIndex = 6;
			label4.Text = "Ngày sinh";
			label4.TextAlign = ContentAlignment.TopRight;
			// 
			// label5
			// 
			label5.BackColor = Color.Transparent;
			label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
			label5.ForeColor = SystemColors.Control;
			label5.Image = (Image)resources.GetObject("label5.Image");
			label5.ImageAlign = ContentAlignment.MiddleLeft;
			label5.Location = new Point(148, 530);
			label5.Name = "label5";
			label5.Size = new Size(73, 28);
			label5.TabIndex = 6;
			label5.Text = "SDT";
			label5.TextAlign = ContentAlignment.TopRight;
			// 
			// label6
			// 
			label6.BackColor = Color.Transparent;
			label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
			label6.ForeColor = SystemColors.Control;
			label6.Image = (Image)resources.GetObject("label6.Image");
			label6.ImageAlign = ContentAlignment.MiddleLeft;
			label6.Location = new Point(623, 263);
			label6.Name = "label6";
			label6.Size = new Size(91, 28);
			label6.TabIndex = 6;
			label6.Text = "Email";
			label6.TextAlign = ContentAlignment.TopRight;
			// 
			// label7
			// 
			label7.BackColor = Color.Transparent;
			label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
			label7.ForeColor = SystemColors.Control;
			label7.Image = (Image)resources.GetObject("label7.Image");
			label7.ImageAlign = ContentAlignment.MiddleLeft;
			label7.Location = new Point(543, 327);
			label7.Name = "label7";
			label7.Size = new Size(185, 28);
			label7.TabIndex = 6;
			label7.Text = "Ngày Đăng Ký";
			label7.TextAlign = ContentAlignment.TopRight;
			// 
			// label8
			// 
			label8.BackColor = Color.Transparent;
			label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
			label8.ForeColor = SystemColors.Control;
			label8.Image = (Image)resources.GetObject("label8.Image");
			label8.ImageAlign = ContentAlignment.MiddleLeft;
			label8.Location = new Point(543, 401);
			label8.Name = "label8";
			label8.Size = new Size(162, 28);
			label8.TabIndex = 6;
			label8.Text = "Thời gian tập";
			label8.TextAlign = ContentAlignment.TopRight;
			// 
			// label9
			// 
			label9.BackColor = Color.Transparent;
			label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
			label9.ForeColor = SystemColors.Control;
			label9.Image = (Image)resources.GetObject("label9.Image");
			label9.ImageAlign = ContentAlignment.MiddleLeft;
			label9.Location = new Point(587, 497);
			label9.Name = "label9";
			label9.Size = new Size(114, 28);
			label9.TabIndex = 6;
			label9.Text = "Địa chỉ";
			label9.TextAlign = ContentAlignment.TopRight;
			// 
			// label10
			// 
			label10.BackColor = Color.Transparent;
			label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
			label10.ForeColor = SystemColors.Control;
			label10.Image = (Image)resources.GetObject("label10.Image");
			label10.ImageAlign = ContentAlignment.TopLeft;
			label10.Location = new Point(307, 639);
			label10.Name = "label10";
			label10.Size = new Size(149, 28);
			label10.TabIndex = 6;
			label10.Text = "Các gói tập";
			label10.TextAlign = ContentAlignment.TopRight;
			// 
			// btnSave
			// 
			btnSave.BackColor = SystemColors.Control;
			btnSave.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
			btnSave.ForeColor = SystemColors.ActiveCaptionText;
			btnSave.Image = (Image)resources.GetObject("btnSave.Image");
			btnSave.ImageAlign = ContentAlignment.MiddleLeft;
			btnSave.Location = new Point(364, 702);
			btnSave.Name = "btnSave";
			btnSave.Size = new Size(77, 44);
			btnSave.TabIndex = 7;
			btnSave.Text = "LƯU";
			btnSave.TextAlign = ContentAlignment.MiddleRight;
			btnSave.UseVisualStyleBackColor = false;
			btnSave.Click += btnSave_Click;
			// 
			// btnReset
			// 
			btnReset.BackColor = SystemColors.Control;
			btnReset.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
			btnReset.ForeColor = SystemColors.ActiveCaptionText;
			btnReset.Image = (Image)resources.GetObject("btnReset.Image");
			btnReset.ImageAlign = ContentAlignment.MiddleLeft;
			btnReset.Location = new Point(587, 702);
			btnReset.Name = "btnReset";
			btnReset.Size = new Size(91, 44);
			btnReset.TabIndex = 7;
			btnReset.Text = "RESET";
			btnReset.TextAlign = ContentAlignment.MiddleRight;
			btnReset.UseVisualStyleBackColor = false;
			btnReset.Click += btnReset_Click;
			// 
			// label11
			// 
			label11.AutoSize = true;
			label11.BackColor = Color.Transparent;
			label11.Font = new Font("Monotype Corsiva", 28.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
			label11.ForeColor = Color.WhiteSmoke;
			label11.Location = new Point(387, 128);
			label11.Name = "label11";
			label11.Size = new Size(249, 56);
			label11.TabIndex = 8;
			label11.Text = "Anh Tú Gym";
			// 
			// pictureBox1
			// 
			pictureBox1.BackColor = Color.Transparent;
			pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
			pictureBox1.Location = new Point(404, 14);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(252, 110);
			pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox1.TabIndex = 9;
			pictureBox1.TabStop = false;
			// 
			// NewMember
			// 
			AutoScaleDimensions = new SizeF(9F, 23F);
			AutoScaleMode = AutoScaleMode.Font;
			BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
			BackgroundImageLayout = ImageLayout.Stretch;
			ClientSize = new Size(1064, 804);
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
			Text = "NewMember";
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