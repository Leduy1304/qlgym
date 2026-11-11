namespace Gym_Management
{
	partial class SearchMember
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
			DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
			label1 = new Label();
			txtSearchId = new TextBox();
			btnSearch = new Button();
			btnReset = new Button();
			btnDoiGoiTap = new Button();
			dataGridView1 = new DataGridView();
			lblCount = new Label();
			label11 = new Label();
			label12 = new Label();
			groupBoxEdit = new GroupBox();
			lblEditTip = new Label();
			btnClearEdit = new Button();
			btnUpdateMember = new Button();
			txtEditAddress = new TextBox();
			lblAddress = new Label();
			cmbEditPT = new ComboBox();
			lblPT = new Label();
			cmbEditMembership = new ComboBox();
			lblMembership = new Label();
			cmbEditGymTime = new ComboBox();
			lblGymTime = new Label();
			txtEditEmail = new TextBox();
			lblEmail = new Label();
			txtEditMobile = new TextBox();
			lblMobile = new Label();
			dtpEditDob = new DateTimePicker();
			lblDob = new Label();
			cmbEditGender = new ComboBox();
			lblGender = new Label();
			txtEditLname = new TextBox();
			lblLname = new Label();
			txtEditFname = new TextBox();
			lblFname = new Label();
			txtEditMID = new TextBox();
			lblMID = new Label();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			groupBoxEdit.SuspendLayout();
			SuspendLayout();
			// 
			// label1
			// 
			label1.BackColor = Color.Transparent;
			label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
			label1.ForeColor = SystemColors.Control;
			label1.Location = new Point(40, 137);
			label1.Name = "label1";
			label1.Size = new Size(180, 28);
			label1.TabIndex = 0;
			label1.Text = "Tìm theo Mã / Tên:";
			label1.TextAlign = ContentAlignment.MiddleRight;
			// 
			// txtSearchId
			// 
			txtSearchId.Location = new Point(230, 135);
			txtSearchId.Name = "txtSearchId";
			txtSearchId.PlaceholderText = "Nhập mã HV hoặc họ tên...";
			txtSearchId.Size = new Size(240, 30);
			txtSearchId.TabIndex = 1;
			// 
			// btnSearch
			// 
			btnSearch.BackColor = Color.FromArgb(59, 130, 246);
			btnSearch.FlatAppearance.BorderSize = 0;
			btnSearch.FlatStyle = FlatStyle.Flat;
			btnSearch.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
			btnSearch.ForeColor = Color.White;
			btnSearch.Location = new Point(485, 130);
			btnSearch.Name = "btnSearch";
			btnSearch.Size = new Size(130, 38);
			btnSearch.TabIndex = 2;
			btnSearch.Text = "🔍 TÌM KIẾM";
			btnSearch.UseVisualStyleBackColor = false;
			btnSearch.Click += btnSearch_Click;
			// 
			// btnReset
			// 
			btnReset.BackColor = Color.FromArgb(71, 85, 105);
			btnReset.FlatAppearance.BorderSize = 0;
			btnReset.FlatStyle = FlatStyle.Flat;
			btnReset.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
			btnReset.ForeColor = Color.White;
			btnReset.Location = new Point(625, 130);
			btnReset.Name = "btnReset";
			btnReset.Size = new Size(150, 38);
			btnReset.TabIndex = 3;
			btnReset.Text = "📋 HIỆN TẤT CẢ";
			btnReset.UseVisualStyleBackColor = false;
			btnReset.Click += btnReset_Click;
			// 
			// btnDoiGoiTap
			// 
			btnDoiGoiTap.BackColor = Color.FromArgb(16, 185, 129);
			btnDoiGoiTap.FlatAppearance.BorderSize = 0;
			btnDoiGoiTap.FlatStyle = FlatStyle.Flat;
			btnDoiGoiTap.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
			btnDoiGoiTap.ForeColor = Color.White;
			btnDoiGoiTap.Location = new Point(980, 130);
			btnDoiGoiTap.Name = "btnDoiGoiTap";
			btnDoiGoiTap.Size = new Size(240, 38);
			btnDoiGoiTap.TabIndex = 4;
			btnDoiGoiTap.Text = "📦 ĐỔI GÓI TẬP / HLV";
			btnDoiGoiTap.UseVisualStyleBackColor = false;
			btnDoiGoiTap.Click += btnDoiGoiTap_Click;
			// 
			// dataGridView1
			// 
			dataGridView1.AllowUserToAddRows = false;
			dataGridView1.AllowUserToDeleteRows = false;
			dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dataGridView1.BackgroundColor = Color.WhiteSmoke;
			dataGridView1.ColumnHeadersHeight = 42;
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = Color.Orange;
			dataGridViewCellStyle1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
			dataGridViewCellStyle1.ForeColor = Color.White;
			dataGridViewCellStyle1.SelectionBackColor = Color.Orange;
			dataGridViewCellStyle1.SelectionForeColor = Color.White;
			dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = Color.White;
			dataGridViewCellStyle2.Font = new Font("Segoe UI", 10.2F);
			dataGridViewCellStyle2.ForeColor = Color.Black;
			dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(255, 190, 90);
			dataGridViewCellStyle2.SelectionForeColor = Color.Black;
			dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
			dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
			dataGridView1.EnableHeadersVisualStyles = false;
			dataGridView1.GridColor = Color.LightGray;
			dataGridView1.Location = new Point(40, 180);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.ReadOnly = true;
			dataGridView1.RowHeadersWidth = 51;
			dataGridView1.RowTemplate.Height = 32;
			dataGridViewCellStyle3.BackColor = Color.FromArgb(255, 243, 224);
			dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
			dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dataGridView1.Size = new Size(1180, 335);
			dataGridView1.TabIndex = 5;
			dataGridView1.CellClick += dataGridView1_CellClick;
			dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
			// 
			// lblCount
			// 
			lblCount.AutoSize = true;
			lblCount.BackColor = Color.Transparent;
			lblCount.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
			lblCount.ForeColor = Color.FromArgb(250, 204, 21);
			lblCount.Location = new Point(40, 525);
			lblCount.Name = "lblCount";
			lblCount.Size = new Size(190, 25);
			lblCount.TabIndex = 6;
			lblCount.Text = "Tổng số hội viên: 0";
			// 
			// label11
			// 
			label11.AutoSize = false;
			label11.BackColor = Color.Transparent;
			label11.Font = new Font("Monotype Corsiva", 28.2F, FontStyle.Bold | FontStyle.Italic);
			label11.ForeColor = Color.WhiteSmoke;
			label11.Location = new Point(0, 12);
			label11.Name = "label11";
			label11.Size = new Size(1260, 56);
			label11.TabIndex = 7;
			label11.Text = "Anh Tú Gym";
			label11.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// label12
			// 
			label12.AutoSize = false;
			label12.BackColor = Color.Transparent;
			label12.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
			label12.ForeColor = Color.Orange;
			label12.Location = new Point(0, 75);
			label12.Name = "label12";
			label12.Size = new Size(1260, 32);
			label12.TabIndex = 8;
			label12.Text = "TRA CỨU & QUẢN LÝ HỘI VIÊN";
			label12.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// groupBoxEdit
			// 
			groupBoxEdit.BackColor = Color.Transparent;
			groupBoxEdit.Controls.Add(lblEditTip);
			groupBoxEdit.Controls.Add(btnClearEdit);
			groupBoxEdit.Controls.Add(btnUpdateMember);
			groupBoxEdit.Controls.Add(txtEditAddress);
			groupBoxEdit.Controls.Add(lblAddress);
			groupBoxEdit.Controls.Add(cmbEditPT);
			groupBoxEdit.Controls.Add(lblPT);
			groupBoxEdit.Controls.Add(cmbEditMembership);
			groupBoxEdit.Controls.Add(lblMembership);
			groupBoxEdit.Controls.Add(cmbEditGymTime);
			groupBoxEdit.Controls.Add(lblGymTime);
			groupBoxEdit.Controls.Add(txtEditEmail);
			groupBoxEdit.Controls.Add(lblEmail);
			groupBoxEdit.Controls.Add(txtEditMobile);
			groupBoxEdit.Controls.Add(lblMobile);
			groupBoxEdit.Controls.Add(dtpEditDob);
			groupBoxEdit.Controls.Add(lblDob);
			groupBoxEdit.Controls.Add(cmbEditGender);
			groupBoxEdit.Controls.Add(lblGender);
			groupBoxEdit.Controls.Add(txtEditLname);
			groupBoxEdit.Controls.Add(lblLname);
			groupBoxEdit.Controls.Add(txtEditFname);
			groupBoxEdit.Controls.Add(lblFname);
			groupBoxEdit.Controls.Add(txtEditMID);
			groupBoxEdit.Controls.Add(lblMID);
			groupBoxEdit.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
			groupBoxEdit.ForeColor = Color.FromArgb(245, 158, 11);
			groupBoxEdit.Location = new Point(40, 555);
			groupBoxEdit.Name = "groupBoxEdit";
			groupBoxEdit.Size = new Size(1180, 280);
			groupBoxEdit.TabIndex = 9;
			groupBoxEdit.TabStop = false;
			groupBoxEdit.Text = "CHỈNH SỬA THÔNG TIN HỘI VIÊN (ADMIN && PT)";
			// 
			// lblEditTip
			// 
			lblEditTip.AutoSize = true;
			lblEditTip.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
			lblEditTip.ForeColor = Color.FromArgb(148, 163, 184);
			lblEditTip.Location = new Point(410, 230);
			lblEditTip.Name = "lblEditTip";
			lblEditTip.Size = new Size(610, 20);
			lblEditTip.TabIndex = 24;
			lblEditTip.Text = "💡 Nhấp vào 1 hội viên trên bảng để tải thông tin lên form này, chỉnh sửa rồi bấm Lưu thay đổi.";
			// 
			// btnClearEdit
			// 
			btnClearEdit.BackColor = Color.FromArgb(71, 85, 105);
			btnClearEdit.FlatAppearance.BorderSize = 0;
			btnClearEdit.FlatStyle = FlatStyle.Flat;
			btnClearEdit.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
			btnClearEdit.ForeColor = Color.White;
			btnClearEdit.Location = new Point(270, 218);
			btnClearEdit.Name = "btnClearEdit";
			btnClearEdit.Size = new Size(120, 42);
			btnClearEdit.TabIndex = 23;
			btnClearEdit.Text = "❌ HỦY CHỌN";
			btnClearEdit.UseVisualStyleBackColor = false;
			btnClearEdit.Click += btnClearEdit_Click;
			// 
			// btnUpdateMember
			// 
			btnUpdateMember.BackColor = Color.FromArgb(16, 185, 129);
			btnUpdateMember.FlatAppearance.BorderSize = 0;
			btnUpdateMember.FlatStyle = FlatStyle.Flat;
			btnUpdateMember.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
			btnUpdateMember.ForeColor = Color.White;
			btnUpdateMember.Location = new Point(20, 218);
			btnUpdateMember.Name = "btnUpdateMember";
			btnUpdateMember.Size = new Size(235, 42);
			btnUpdateMember.TabIndex = 22;
			btnUpdateMember.Text = "💾 LƯU THAY ĐỔI VÀO CSDL";
			btnUpdateMember.UseVisualStyleBackColor = false;
			btnUpdateMember.Click += btnUpdateMember_Click;
			// 
			// txtEditAddress
			// 
			txtEditAddress.Font = new Font("Segoe UI", 9.5F);
			txtEditAddress.Location = new Point(780, 155);
			txtEditAddress.Name = "txtEditAddress";
			txtEditAddress.Size = new Size(380, 29);
			txtEditAddress.TabIndex = 21;
			// 
			// lblAddress
			// 
			lblAddress.AutoSize = true;
			lblAddress.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			lblAddress.ForeColor = Color.White;
			lblAddress.Location = new Point(780, 130);
			lblAddress.Name = "lblAddress";
			lblAddress.Size = new Size(60, 20);
			lblAddress.TabIndex = 20;
			lblAddress.Text = "Địa chỉ:";
			// 
			// cmbEditPT
			// 
			cmbEditPT.DropDownStyle = ComboBoxStyle.DropDownList;
			cmbEditPT.Font = new Font("Segoe UI", 9.5F);
			cmbEditPT.FormattingEnabled = true;
			cmbEditPT.Location = new Point(510, 155);
			cmbEditPT.Name = "cmbEditPT";
			cmbEditPT.Size = new Size(250, 29);
			cmbEditPT.TabIndex = 19;
			// 
			// lblPT
			// 
			lblPT.AutoSize = true;
			lblPT.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			lblPT.ForeColor = Color.FromArgb(74, 222, 128);
			lblPT.Location = new Point(510, 130);
			lblPT.Name = "lblPT";
			lblPT.Size = new Size(130, 20);
			lblPT.TabIndex = 18;
			lblPT.Text = "HLV (PT) phụ trách:";
			// 
			// cmbEditMembership
			// 
			cmbEditMembership.DropDownStyle = ComboBoxStyle.DropDownList;
			cmbEditMembership.Font = new Font("Segoe UI", 9.5F);
			cmbEditMembership.FormattingEnabled = true;
			cmbEditMembership.Items.AddRange(new object[] {
            "Gói 1 Tháng (300,000 đ) - Thẻ tập tiêu chuẩn",
            "Gói 3 Tháng (850,000 đ) - Tiết kiệm 5% + Đo InBody",
            "Gói 6 Tháng (1,600,000 đ) - Tiết kiệm 10% + 1 buổi PT",
            "Gói 12 Tháng VIP (3,000,000 đ) - Không giới hạn + Tủ riêng"});
			cmbEditMembership.Location = new Point(230, 155);
			cmbEditMembership.Name = "cmbEditMembership";
			cmbEditMembership.Size = new Size(260, 29);
			cmbEditMembership.TabIndex = 17;
			// 
			// lblMembership
			// 
			lblMembership.AutoSize = true;
			lblMembership.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			lblMembership.ForeColor = Color.FromArgb(245, 158, 11);
			lblMembership.Location = new Point(230, 130);
			lblMembership.Name = "lblMembership";
			lblMembership.Size = new Size(68, 20);
			lblMembership.TabIndex = 16;
			lblMembership.Text = "Gói tập:";
			// 
			// cmbEditGymTime
			// 
			cmbEditGymTime.DropDownStyle = ComboBoxStyle.DropDownList;
			cmbEditGymTime.Font = new Font("Segoe UI", 9.5F);
			cmbEditGymTime.FormattingEnabled = true;
			cmbEditGymTime.Items.AddRange(new object[] {
            "06:00 - 08:00 (Sáng sớm)",
            "08:00 - 10:00 (Buổi sáng)",
            "14:00 - 16:00 (Đầu giờ chiều)",
            "16:00 - 18:00 (Chiều tan tầm)",
            "18:00 - 20:00 (Buổi tối)",
            "20:00 - 22:00 (Tối muộn)"});
			cmbEditGymTime.Location = new Point(20, 155);
			cmbEditGymTime.Name = "cmbEditGymTime";
			cmbEditGymTime.Size = new Size(190, 29);
			cmbEditGymTime.TabIndex = 15;
			// 
			// lblGymTime
			// 
			lblGymTime.AutoSize = true;
			lblGymTime.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			lblGymTime.ForeColor = Color.FromArgb(56, 189, 248);
			lblGymTime.Location = new Point(20, 130);
			lblGymTime.Name = "lblGymTime";
			lblGymTime.Size = new Size(89, 20);
			lblGymTime.TabIndex = 14;
			lblGymTime.Text = "Giờ tập luyện:";
			// 
			// txtEditEmail
			// 
			txtEditEmail.Font = new Font("Segoe UI", 9.5F);
			txtEditEmail.Location = new Point(930, 65);
			txtEditEmail.Name = "txtEditEmail";
			txtEditEmail.Size = new Size(230, 29);
			txtEditEmail.TabIndex = 13;
			// 
			// lblEmail
			// 
			lblEmail.AutoSize = true;
			lblEmail.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			lblEmail.ForeColor = Color.White;
			lblEmail.Location = new Point(930, 40);
			lblEmail.Name = "lblEmail";
			lblEmail.Size = new Size(51, 20);
			lblEmail.TabIndex = 12;
			lblEmail.Text = "Email:";
			// 
			// txtEditMobile
			// 
			txtEditMobile.Font = new Font("Segoe UI", 9.5F);
			txtEditMobile.Location = new Point(780, 65);
			txtEditMobile.Name = "txtEditMobile";
			txtEditMobile.Size = new Size(130, 29);
			txtEditMobile.TabIndex = 11;
			// 
			// lblMobile
			// 
			lblMobile.AutoSize = true;
			lblMobile.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			lblMobile.ForeColor = Color.White;
			lblMobile.Location = new Point(780, 40);
			lblMobile.Name = "lblMobile";
			lblMobile.Size = new Size(104, 20);
			lblMobile.TabIndex = 10;
			lblMobile.Text = "Số điện thoại:";
			// 
			// dtpEditDob
			// 
			dtpEditDob.Font = new Font("Segoe UI", 9.5F);
			dtpEditDob.Format = DateTimePickerFormat.Short;
			dtpEditDob.Location = new Point(610, 65);
			dtpEditDob.Name = "dtpEditDob";
			dtpEditDob.Size = new Size(150, 29);
			dtpEditDob.TabIndex = 9;
			// 
			// lblDob
			// 
			lblDob.AutoSize = true;
			lblDob.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			lblDob.ForeColor = Color.White;
			lblDob.Location = new Point(610, 40);
			lblDob.Name = "lblDob";
			lblDob.Size = new Size(83, 20);
			lblDob.TabIndex = 8;
			lblDob.Text = "Ngày sinh:";
			// 
			// cmbEditGender
			// 
			cmbEditGender.DropDownStyle = ComboBoxStyle.DropDownList;
			cmbEditGender.Font = new Font("Segoe UI", 9.5F);
			cmbEditGender.FormattingEnabled = true;
			cmbEditGender.Items.AddRange(new object[] { "Nam", "Nữ", "Khác" });
			cmbEditGender.Location = new Point(480, 65);
			cmbEditGender.Name = "cmbEditGender";
			cmbEditGender.Size = new Size(110, 29);
			cmbEditGender.TabIndex = 7;
			// 
			// lblGender
			// 
			lblGender.AutoSize = true;
			lblGender.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			lblGender.ForeColor = Color.White;
			lblGender.Location = new Point(480, 40);
			lblGender.Name = "lblGender";
			lblGender.Size = new Size(73, 20);
			lblGender.TabIndex = 6;
			lblGender.Text = "Giới tính:";
			// 
			// txtEditLname
			// 
			txtEditLname.Font = new Font("Segoe UI", 9.5F);
			txtEditLname.Location = new Point(310, 65);
			txtEditLname.Name = "txtEditLname";
			txtEditLname.Size = new Size(150, 29);
			txtEditLname.TabIndex = 5;
			// 
			// lblLname
			// 
			lblLname.AutoSize = true;
			lblLname.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			lblLname.ForeColor = Color.White;
			lblLname.Location = new Point(310, 40);
			lblLname.Name = "lblLname";
			lblLname.Size = new Size(38, 20);
			lblLname.TabIndex = 4;
			lblLname.Text = "Tên:";
			// 
			// txtEditFname
			// 
			txtEditFname.Font = new Font("Segoe UI", 9.5F);
			txtEditFname.Location = new Point(140, 65);
			txtEditFname.Name = "txtEditFname";
			txtEditFname.Size = new Size(150, 29);
			txtEditFname.TabIndex = 3;
			// 
			// lblFname
			// 
			lblFname.AutoSize = true;
			lblFname.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			lblFname.ForeColor = Color.White;
			lblFname.Location = new Point(140, 40);
			lblFname.Name = "lblFname";
			lblFname.Size = new Size(34, 20);
			lblFname.TabIndex = 2;
			lblFname.Text = "Họ:";
			// 
			// txtEditMID
			// 
			txtEditMID.BackColor = Color.FromArgb(51, 65, 85);
			txtEditMID.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
			txtEditMID.ForeColor = Color.White;
			txtEditMID.Location = new Point(20, 65);
			txtEditMID.Name = "txtEditMID";
			txtEditMID.ReadOnly = true;
			txtEditMID.Size = new Size(100, 29);
			txtEditMID.TabIndex = 1;
			// 
			// lblMID
			// 
			lblMID.AutoSize = true;
			lblMID.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			lblMID.ForeColor = Color.White;
			lblMID.Location = new Point(20, 40);
			lblMID.Name = "lblMID";
			lblMID.Size = new Size(61, 20);
			lblMID.TabIndex = 0;
			lblMID.Text = "Mã HV:";
			// 
			// SearchMember
			// 
			AcceptButton = btnSearch;
			AutoScaleDimensions = new SizeF(9F, 23F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(41, 44, 51);
			ClientSize = new Size(1260, 860);
			Controls.Add(groupBoxEdit);
			Controls.Add(label12);
			Controls.Add(label11);
			Controls.Add(lblCount);
			Controls.Add(dataGridView1);
			Controls.Add(btnDoiGoiTap);
			Controls.Add(btnReset);
			Controls.Add(btnSearch);
			Controls.Add(txtSearchId);
			Controls.Add(label1);
			Font = new Font("Segoe UI", 10.2F);
			ForeColor = SystemColors.Control;
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "SearchMember";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Tra Cứu & Quản Lý Hội Viên - Hệ Thống Quản Lý Gym Anh Tú";
			Load += SearchMember_Load;
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			groupBoxEdit.ResumeLayout(false);
			groupBoxEdit.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private TextBox txtSearchId;
		private Button btnSearch;
		private Button btnReset;
		private Button btnDoiGoiTap;
		private DataGridView dataGridView1;
		private Label lblCount;
		private Label label11;
		private Label label12;
		private GroupBox groupBoxEdit;
		private Label lblMID;
		private TextBox txtEditMID;
		private Label lblFname;
		private TextBox txtEditFname;
		private Label lblLname;
		private TextBox txtEditLname;
		private Label lblGender;
		private ComboBox cmbEditGender;
		private Label lblDob;
		private DateTimePicker dtpEditDob;
		private Label lblMobile;
		private TextBox txtEditMobile;
		private Label lblEmail;
		private TextBox txtEditEmail;
		private Label lblGymTime;
		private ComboBox cmbEditGymTime;
		private Label lblMembership;
		private ComboBox cmbEditMembership;
		private Label lblPT;
		private ComboBox cmbEditPT;
		private Label lblAddress;
		private TextBox txtEditAddress;
		private Button btnUpdateMember;
		private Button btnClearEdit;
		private Label lblEditTip;
	}
}
