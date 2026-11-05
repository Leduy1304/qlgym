namespace Gym_Management
{
	partial class Equipment
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
			DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
			txtEquipName = new TextBox();
			txtDescription = new RichTextBox();
			txtMuscles = new TextBox();
			txtCost = new TextBox();
			txtUnits = new TextBox();
			dateTimePickerPurchase = new DateTimePicker();
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			label4 = new Label();
			label5 = new Label();
			label6 = new Label();
			label7 = new Label();
			btnSave = new Button();
			btnReset = new Button();
			btnUpdateEquip = new Button();
			btnDelete = new Button();
			label11 = new Label();
			label12 = new Label();
			lblRoleNotice = new Label();
			btnTabEquipment = new Button();
			btnTabProposal = new Button();
			btnApproveProposal = new Button();
			btnRejectProposal = new Button();
			dataGridView1 = new DataGridView();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			SuspendLayout();
			// 
			// txtEquipName
			// 
			txtEquipName.Location = new Point(225, 165);
			txtEquipName.Name = "txtEquipName";
			txtEquipName.Size = new Size(345, 30);
			txtEquipName.TabIndex = 0;
			// 
			// txtDescription
			// 
			txtDescription.Location = new Point(225, 218);
			txtDescription.Name = "txtDescription";
			txtDescription.Size = new Size(345, 72);
			txtDescription.TabIndex = 1;
			txtDescription.Text = "";
			// 
			// txtMuscles
			// 
			txtMuscles.Location = new Point(225, 305);
			txtMuscles.Name = "txtMuscles";
			txtMuscles.Size = new Size(345, 30);
			txtMuscles.TabIndex = 2;
			// 
			// txtCost
			// 
			txtCost.Location = new Point(785, 165);
			txtCost.Name = "txtCost";
			txtCost.Size = new Size(445, 30);
			txtCost.TabIndex = 3;
			// 
			// txtUnits
			// 
			txtUnits.Location = new Point(785, 218);
			txtUnits.Name = "txtUnits";
			txtUnits.Size = new Size(445, 30);
			txtUnits.TabIndex = 4;
			// 
			// dateTimePickerPurchase
			// 
			dateTimePickerPurchase.Format = DateTimePickerFormat.Short;
			dateTimePickerPurchase.Location = new Point(785, 305);
			dateTimePickerPurchase.Name = "dateTimePickerPurchase";
			dateTimePickerPurchase.Size = new Size(200, 30);
			dateTimePickerPurchase.TabIndex = 5;
			// 
			// label1
			// 
			label1.BackColor = Color.Transparent;
			label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
			label1.ForeColor = SystemColors.Control;
			label1.Location = new Point(40, 168);
			label1.Name = "label1";
			label1.Size = new Size(170, 28);
			label1.TabIndex = 6;
			label1.Text = "Tên thiết bị";
			label1.TextAlign = ContentAlignment.TopRight;
			// 
			// label2
			// 
			label2.BackColor = Color.Transparent;
			label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
			label2.ForeColor = SystemColors.Control;
			label2.Location = new Point(40, 221);
			label2.Name = "label2";
			label2.Size = new Size(170, 28);
			label2.TabIndex = 7;
			label2.Text = "Mô tả";
			label2.TextAlign = ContentAlignment.TopRight;
			// 
			// label3
			// 
			label3.BackColor = Color.Transparent;
			label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
			label3.ForeColor = SystemColors.Control;
			label3.Location = new Point(40, 308);
			label3.Name = "label3";
			label3.Size = new Size(170, 28);
			label3.TabIndex = 8;
			label3.Text = "Nhóm cơ";
			label3.TextAlign = ContentAlignment.TopRight;
			// 
			// label4
			// 
			label4.BackColor = Color.Transparent;
			label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
			label4.ForeColor = SystemColors.Control;
			label4.Location = new Point(590, 168);
			label4.Name = "label4";
			label4.Size = new Size(185, 28);
			label4.TabIndex = 9;
			label4.Text = "Giá tiền (VNĐ)";
			label4.TextAlign = ContentAlignment.TopRight;
			// 
			// label5
			// 
			label5.BackColor = Color.Transparent;
			label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
			label5.ForeColor = SystemColors.Control;
			label5.Location = new Point(590, 221);
			label5.Name = "label5";
			label5.Size = new Size(185, 28);
			label5.TabIndex = 10;
			label5.Text = "Số lượng";
			label5.TextAlign = ContentAlignment.TopRight;
			// 
			// label6
			// 
			label6.BackColor = Color.Transparent;
			label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
			label6.ForeColor = SystemColors.Control;
			label6.Location = new Point(590, 308);
			label6.Name = "label6";
			label6.Size = new Size(185, 28);
			label6.TabIndex = 11;
			label6.Text = "Ngày mua";
			label6.TextAlign = ContentAlignment.TopRight;
			// 
			// label7
			// 
			label7.BackColor = Color.Transparent;
			label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
			label7.ForeColor = SystemColors.Control;
			label7.Location = new Point(40, 430);
			label7.Name = "label7";
			label7.Size = new Size(270, 30);
			label7.TabIndex = 12;
			label7.Text = "Danh sách thiết bị phòng tập";
			// 
			// btnSave
			// 
			btnSave.BackColor = Color.FromArgb(59, 130, 246);
			btnSave.FlatAppearance.BorderSize = 0;
			btnSave.FlatStyle = FlatStyle.Flat;
			btnSave.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
			btnSave.ForeColor = Color.White;
			btnSave.Location = new Point(225, 365);
			btnSave.Name = "btnSave";
			btnSave.Size = new Size(150, 44);
			btnSave.TabIndex = 13;
			btnSave.Text = "LƯU";
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
			btnReset.Location = new Point(395, 365);
			btnReset.Name = "btnReset";
			btnReset.Size = new Size(120, 44);
			btnReset.TabIndex = 14;
			btnReset.Text = "RESET";
			btnReset.UseVisualStyleBackColor = false;
			btnReset.Click += btnReset_Click;
			// 
			// btnUpdateEquip
			// 
			btnUpdateEquip.BackColor = Color.FromArgb(245, 158, 11);
			btnUpdateEquip.FlatAppearance.BorderSize = 0;
			btnUpdateEquip.FlatStyle = FlatStyle.Flat;
			btnUpdateEquip.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
			btnUpdateEquip.ForeColor = Color.White;
			btnUpdateEquip.Location = new Point(525, 365);
			btnUpdateEquip.Name = "btnUpdateEquip";
			btnUpdateEquip.Size = new Size(200, 44);
			btnUpdateEquip.TabIndex = 24;
			btnUpdateEquip.Text = "💾 CẬP NHẬT THIẾT BỊ";
			btnUpdateEquip.UseVisualStyleBackColor = false;
			btnUpdateEquip.Click += btnUpdateEquip_Click;
			// 
			// btnDelete
			// 
			btnDelete.BackColor = Color.FromArgb(239, 68, 68);
			btnDelete.FlatAppearance.BorderSize = 0;
			btnDelete.FlatStyle = FlatStyle.Flat;
			btnDelete.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
			btnDelete.ForeColor = Color.White;
			btnDelete.Location = new Point(1030, 365);
			btnDelete.Name = "btnDelete";
			btnDelete.Size = new Size(220, 44);
			btnDelete.TabIndex = 15;
			btnDelete.Text = "XÓA THIẾT BỊ ĐÃ CHỌN";
			btnDelete.UseVisualStyleBackColor = false;
			btnDelete.Click += btnDelete_Click;
			// 
			// label11
			// 
			label11.AutoSize = false;
			label11.BackColor = Color.Transparent;
			label11.Font = new Font("Monotype Corsiva", 28.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
			label11.ForeColor = Color.WhiteSmoke;
			label11.Location = new Point(0, 15);
			label11.Name = "label11";
			label11.Size = new Size(1300, 56);
			label11.TabIndex = 16;
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
			label12.Size = new Size(1300, 32);
			label12.TabIndex = 17;
			label12.Text = "QUẢN LÝ THIẾT BỊ PHÒNG TẬP";
			label12.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// lblRoleNotice
			// 
			lblRoleNotice.BackColor = Color.Transparent;
			lblRoleNotice.Font = new Font("Segoe UI", 10F, FontStyle.Italic);
			lblRoleNotice.ForeColor = Color.FromArgb(250, 204, 21);
			lblRoleNotice.Location = new Point(0, 115);
			lblRoleNotice.Name = "lblRoleNotice";
			lblRoleNotice.Size = new Size(1300, 35);
			lblRoleNotice.TabIndex = 19;
			lblRoleNotice.Text = "Thông báo phân quyền thiết bị";
			lblRoleNotice.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// btnTabEquipment
			// 
			btnTabEquipment.BackColor = Color.FromArgb(59, 130, 246);
			btnTabEquipment.FlatAppearance.BorderSize = 0;
			btnTabEquipment.FlatStyle = FlatStyle.Flat;
			btnTabEquipment.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
			btnTabEquipment.ForeColor = Color.White;
			btnTabEquipment.Location = new Point(330, 425);
			btnTabEquipment.Name = "btnTabEquipment";
			btnTabEquipment.Size = new Size(180, 38);
			btnTabEquipment.TabIndex = 20;
			btnTabEquipment.Text = "🏋️ Thiết bị phòng tập";
			btnTabEquipment.UseVisualStyleBackColor = false;
			btnTabEquipment.Click += btnTabEquipment_Click;
			// 
			// btnTabProposal
			// 
			btnTabProposal.BackColor = Color.FromArgb(71, 85, 105);
			btnTabProposal.FlatAppearance.BorderSize = 0;
			btnTabProposal.FlatStyle = FlatStyle.Flat;
			btnTabProposal.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
			btnTabProposal.ForeColor = Color.White;
			btnTabProposal.Location = new Point(530, 425);
			btnTabProposal.Name = "btnTabProposal";
			btnTabProposal.Size = new Size(200, 38);
			btnTabProposal.TabIndex = 21;
			btnTabProposal.Text = "📋 Đề xuất từ HV / PT";
			btnTabProposal.UseVisualStyleBackColor = false;
			btnTabProposal.Click += btnTabProposal_Click;
			// 
			// btnApproveProposal
			// 
			btnApproveProposal.BackColor = Color.FromArgb(16, 185, 129);
			btnApproveProposal.FlatAppearance.BorderSize = 0;
			btnApproveProposal.FlatStyle = FlatStyle.Flat;
			btnApproveProposal.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
			btnApproveProposal.ForeColor = Color.White;
			btnApproveProposal.Location = new Point(750, 425);
			btnApproveProposal.Name = "btnApproveProposal";
			btnApproveProposal.Size = new Size(160, 38);
			btnApproveProposal.TabIndex = 22;
			btnApproveProposal.Text = "✓ Duyệt đề xuất";
			btnApproveProposal.UseVisualStyleBackColor = false;
			btnApproveProposal.Visible = false;
			btnApproveProposal.Click += btnApproveProposal_Click;
			// 
			// btnRejectProposal
			// 
			btnRejectProposal.BackColor = Color.FromArgb(239, 68, 68);
			btnRejectProposal.FlatAppearance.BorderSize = 0;
			btnRejectProposal.FlatStyle = FlatStyle.Flat;
			btnRejectProposal.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
			btnRejectProposal.ForeColor = Color.White;
			btnRejectProposal.Location = new Point(920, 425);
			btnRejectProposal.Name = "btnRejectProposal";
			btnRejectProposal.Size = new Size(130, 38);
			btnRejectProposal.TabIndex = 23;
			btnRejectProposal.Text = "✗ Từ chối";
			btnRejectProposal.UseVisualStyleBackColor = false;
			btnRejectProposal.Visible = false;
			btnRejectProposal.Click += btnRejectProposal_Click;
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
			dataGridView1.Location = new Point(40, 475);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.ReadOnly = true;
			dataGridView1.RowHeadersWidth = 51;
			dataGridView1.Size = new Size(1220, 345);
			dataGridView1.TabIndex = 18;
			dataGridView1.CellClick += dataGridView1_CellClick;
			// 
			// Equipment
			// 
			AutoScaleDimensions = new SizeF(9F, 23F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(41, 44, 51);
			ClientSize = new Size(1300, 860);
			Controls.Add(btnUpdateEquip);
			Controls.Add(btnRejectProposal);
			Controls.Add(btnApproveProposal);
			Controls.Add(btnTabProposal);
			Controls.Add(btnTabEquipment);
			Controls.Add(lblRoleNotice);
			Controls.Add(dataGridView1);
			Controls.Add(label12);
			Controls.Add(label11);
			Controls.Add(btnDelete);
			Controls.Add(btnReset);
			Controls.Add(btnSave);
			Controls.Add(label7);
			Controls.Add(label6);
			Controls.Add(label5);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(dateTimePickerPurchase);
			Controls.Add(txtUnits);
			Controls.Add(txtCost);
			Controls.Add(txtMuscles);
			Controls.Add(txtDescription);
			Controls.Add(txtEquipName);
			Font = new Font("Segoe UI", 10.2F);
			ForeColor = SystemColors.Control;
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "Equipment";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Quản lý / Đề xuất Thiết Bị - Hệ Thống Quản Lý Gym Anh Tú";
			Load += Equipment_Load;
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox txtEquipName;
		private RichTextBox txtDescription;
		private TextBox txtMuscles;
		private TextBox txtCost;
		private TextBox txtUnits;
		private DateTimePicker dateTimePickerPurchase;
		private Label label1;
		private Label label2;
		private Label label3;
		private Label label4;
		private Label label5;
		private Label label6;
		private Label label7;
		private Button btnSave;
		private Button btnReset;
		private Button btnUpdateEquip;
		private Button btnDelete;
		private Label label11;
		private Label label12;
		private Label lblRoleNotice;
		private Button btnTabEquipment;
		private Button btnTabProposal;
		private Button btnApproveProposal;
		private Button btnRejectProposal;
		private DataGridView dataGridView1;
	}
}
