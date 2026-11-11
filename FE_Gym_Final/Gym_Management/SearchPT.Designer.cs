namespace Gym_Management
{
	partial class SearchPT
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
			btnQuickAddPT = new Button();
			dataGridView1 = new DataGridView();
			lblCount = new Label();
			label11 = new Label();
			label12 = new Label();
			groupBoxEdit = new GroupBox();
			lblEditTip = new Label();
			btnClearEdit = new Button();
			btnUpdatePT = new Button();
			txtEditAddress = new TextBox();
			lblAddress = new Label();
			dtpEditJoinDate = new DateTimePicker();
			lblJoinDate = new Label();
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
			txtEditPID = new TextBox();
			lblPID = new Label();
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
			txtSearchId.PlaceholderText = "Nhập mã PT hoặc họ tên...";
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
			// btnQuickAddPT
			// 
			btnQuickAddPT.BackColor = Color.FromArgb(14, 165, 233);
			btnQuickAddPT.FlatAppearance.BorderSize = 0;
			btnQuickAddPT.FlatStyle = FlatStyle.Flat;
			btnQuickAddPT.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
			btnQuickAddPT.ForeColor = Color.White;
			btnQuickAddPT.Location = new Point(980, 130);
			btnQuickAddPT.Name = "btnQuickAddPT";
			btnQuickAddPT.Size = new Size(240, 38);
			btnQuickAddPT.TabIndex = 4;
			btnQuickAddPT.Text = "➕ THÊM NHANH HLV";
			btnQuickAddPT.UseVisualStyleBackColor = false;
			btnQuickAddPT.Click += btnQuickAddPT_Click;
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
			lblCount.Size = new Size(150, 25);
			lblCount.TabIndex = 6;
			lblCount.Text = "Tổng số PT: 0";
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
			label12.Text = "TRA CỨU & QUẢN LÝ HUẤN LUYỆN VIÊN (PT)";
			label12.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// groupBoxEdit
			// 
			groupBoxEdit.BackColor = Color.Transparent;
			groupBoxEdit.Controls.Add(lblEditTip);
			groupBoxEdit.Controls.Add(btnClearEdit);
			groupBoxEdit.Controls.Add(btnUpdatePT);
			groupBoxEdit.Controls.Add(txtEditAddress);
			groupBoxEdit.Controls.Add(lblAddress);
			groupBoxEdit.Controls.Add(dtpEditJoinDate);
			groupBoxEdit.Controls.Add(lblJoinDate);
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
			groupBoxEdit.Controls.Add(txtEditPID);
			groupBoxEdit.Controls.Add(lblPID);
			groupBoxEdit.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
			groupBoxEdit.ForeColor = Color.FromArgb(245, 158, 11);
			groupBoxEdit.Location = new Point(40, 555);
			groupBoxEdit.Name = "groupBoxEdit";
			groupBoxEdit.Size = new Size(1180, 280);
			groupBoxEdit.TabIndex = 9;
			groupBoxEdit.TabStop = false;
			groupBoxEdit.Text = "CHỈNH SỬA THÔNG TIN HUẤN LUYỆN VIÊN (CHỈ ADMIN)";
			// 
			// lblEditTip
			// 
			lblEditTip.AutoSize = true;
			lblEditTip.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
			lblEditTip.ForeColor = Color.FromArgb(148, 163, 184);
			lblEditTip.Location = new Point(410, 230);
			lblEditTip.Name = "lblEditTip";
			lblEditTip.Size = new Size(590, 20);
			lblEditTip.TabIndex = 20;
			lblEditTip.Text = "💡 Nhấp vào 1 PT trên bảng để tải thông tin lên form, chỉnh sửa rồi bấm Lưu thay đổi.";
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
			btnClearEdit.TabIndex = 19;
			btnClearEdit.Text = "❌ HỦY CHỌN";
			btnClearEdit.UseVisualStyleBackColor = false;
			btnClearEdit.Click += btnClearEdit_Click;
			// 
			// btnUpdatePT
			// 
			btnUpdatePT.BackColor = Color.FromArgb(16, 185, 129);
			btnUpdatePT.FlatAppearance.BorderSize = 0;
			btnUpdatePT.FlatStyle = FlatStyle.Flat;
			btnUpdatePT.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
			btnUpdatePT.ForeColor = Color.White;
			btnUpdatePT.Location = new Point(20, 218);
			btnUpdatePT.Name = "btnUpdatePT";
			btnUpdatePT.Size = new Size(235, 42);
			btnUpdatePT.TabIndex = 18;
			btnUpdatePT.Text = "💾 LƯU THAY ĐỔI VÀO CSDL";
			btnUpdatePT.UseVisualStyleBackColor = false;
			btnUpdatePT.Click += btnUpdatePT_Click;
			// 
			// txtEditAddress
			// 
			txtEditAddress.Font = new Font("Segoe UI", 9.5F);
			txtEditAddress.Location = new Point(230, 155);
			txtEditAddress.Name = "txtEditAddress";
			txtEditAddress.Size = new Size(930, 29);
			txtEditAddress.TabIndex = 17;
			// 
			// lblAddress
			// 
			lblAddress.AutoSize = true;
			lblAddress.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			lblAddress.ForeColor = Color.White;
			lblAddress.Location = new Point(230, 130);
			lblAddress.Name = "lblAddress";
			lblAddress.Size = new Size(60, 20);
			lblAddress.TabIndex = 16;
			lblAddress.Text = "Địa chỉ:";
			// 
			// dtpEditJoinDate
			// 
			dtpEditJoinDate.Font = new Font("Segoe UI", 9.5F);
			dtpEditJoinDate.Format = DateTimePickerFormat.Short;
			dtpEditJoinDate.Location = new Point(20, 155);
			dtpEditJoinDate.Name = "dtpEditJoinDate";
			dtpEditJoinDate.Size = new Size(180, 29);
			dtpEditJoinDate.TabIndex = 15;
			// 
			// lblJoinDate
			// 
			lblJoinDate.AutoSize = true;
			lblJoinDate.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			lblJoinDate.ForeColor = Color.White;
			lblJoinDate.Location = new Point(20, 130);
			lblJoinDate.Name = "lblJoinDate";
			lblJoinDate.Size = new Size(108, 20);
			lblJoinDate.TabIndex = 14;
			lblJoinDate.Text = "Ngày vào làm:";
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
			// txtEditPID
			// 
			txtEditPID.BackColor = Color.FromArgb(51, 65, 85);
			txtEditPID.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
			txtEditPID.ForeColor = Color.White;
			txtEditPID.Location = new Point(20, 65);
			txtEditPID.Name = "txtEditPID";
			txtEditPID.ReadOnly = true;
			txtEditPID.Size = new Size(100, 29);
			txtEditPID.TabIndex = 1;
			// 
			// lblPID
			// 
			lblPID.AutoSize = true;
			lblPID.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			lblPID.ForeColor = Color.White;
			lblPID.Location = new Point(20, 40);
			lblPID.Name = "lblPID";
			lblPID.Size = new Size(57, 20);
			lblPID.TabIndex = 0;
			lblPID.Text = "Mã PT:";
			// 
			// SearchPT
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
			Controls.Add(btnQuickAddPT);
			Controls.Add(btnReset);
			Controls.Add(btnSearch);
			Controls.Add(txtSearchId);
			Controls.Add(label1);
			Font = new Font("Segoe UI", 10.2F);
			ForeColor = SystemColors.Control;
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "SearchPT";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Tra Cứu & Quản Lý Huấn Luyện Viên PT - Hệ Thống Quản Lý Gym Anh Tú";
			Load += SearchPT_Load;
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
		private Button btnQuickAddPT;
		private DataGridView dataGridView1;
		private Label lblCount;
		private Label label11;
		private Label label12;
		private GroupBox groupBoxEdit;
		private Label lblPID;
		private TextBox txtEditPID;
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
		private Label lblJoinDate;
		private DateTimePicker dtpEditJoinDate;
		private Label lblAddress;
		private TextBox txtEditAddress;
		private Button btnUpdatePT;
		private Button btnClearEdit;
		private Label lblEditTip;
	}
}
