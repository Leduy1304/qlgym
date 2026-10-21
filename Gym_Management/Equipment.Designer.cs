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
			btnDelete = new Button();
			label11 = new Label();
			label12 = new Label();
			dataGridView1 = new DataGridView();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			SuspendLayout();
			//
			// txtEquipName
			//
			txtEquipName.Location = new Point(230, 170);
			txtEquipName.Name = "txtEquipName";
			txtEquipName.Size = new Size(340, 30);
			txtEquipName.TabIndex = 0;
			//
			// txtDescription
			//
			txtDescription.Location = new Point(230, 226);
			txtDescription.Name = "txtDescription";
			txtDescription.Size = new Size(340, 80);
			txtDescription.TabIndex = 1;
			txtDescription.Text = "";
			//
			// txtMuscles
			//
			txtMuscles.Location = new Point(230, 330);
			txtMuscles.Name = "txtMuscles";
			txtMuscles.Size = new Size(340, 30);
			txtMuscles.TabIndex = 2;
			//
			// txtCost
			//
			txtCost.Location = new Point(790, 170);
			txtCost.Name = "txtCost";
			txtCost.Size = new Size(440, 30);
			txtCost.TabIndex = 3;
			//
			// txtUnits
			//
			txtUnits.Location = new Point(790, 226);
			txtUnits.Name = "txtUnits";
			txtUnits.Size = new Size(440, 30);
			txtUnits.TabIndex = 4;
			//
			// dateTimePickerPurchase
			//
			dateTimePickerPurchase.Format = DateTimePickerFormat.Short;
			dateTimePickerPurchase.Location = new Point(790, 292);
			dateTimePickerPurchase.Name = "dateTimePickerPurchase";
			dateTimePickerPurchase.Size = new Size(160, 30);
			dateTimePickerPurchase.TabIndex = 5;
			//
			// label1
			//
			label1.BackColor = Color.Transparent;
			label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
			label1.ForeColor = SystemColors.Control;
			label1.Location = new Point(30, 170);
			label1.Name = "label1";
			label1.Size = new Size(185, 28);
			label1.TabIndex = 6;
			label1.Text = "Tên thiết bị";
			label1.TextAlign = ContentAlignment.TopRight;
			//
			// label2
			//
			label2.BackColor = Color.Transparent;
			label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
			label2.ForeColor = SystemColors.Control;
			label2.Location = new Point(30, 226);
			label2.Name = "label2";
			label2.Size = new Size(185, 28);
			label2.TabIndex = 7;
			label2.Text = "Mô tả";
			label2.TextAlign = ContentAlignment.TopRight;
			//
			// label3
			//
			label3.BackColor = Color.Transparent;
			label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
			label3.ForeColor = SystemColors.Control;
			label3.Location = new Point(30, 330);
			label3.Name = "label3";
			label3.Size = new Size(185, 28);
			label3.TabIndex = 8;
			label3.Text = "Nhóm cơ sử dụng";
			label3.TextAlign = ContentAlignment.TopRight;
			//
			// label4
			//
			label4.BackColor = Color.Transparent;
			label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
			label4.ForeColor = SystemColors.Control;
			label4.Location = new Point(585, 170);
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
			label5.Location = new Point(585, 226);
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
			label6.Location = new Point(585, 292);
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
			label7.Location = new Point(40, 455);
			label7.Name = "label7";
			label7.Size = new Size(300, 28);
			label7.TabIndex = 12;
			label7.Text = "Danh sách thiết bị";
			//
			// btnSave
			//
			btnSave.BackColor = SystemColors.Control;
			btnSave.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
			btnSave.ForeColor = SystemColors.ActiveCaptionText;
			btnSave.Location = new Point(230, 390);
			btnSave.Name = "btnSave";
			btnSave.Size = new Size(110, 44);
			btnSave.TabIndex = 13;
			btnSave.Text = "LƯU";
			btnSave.UseVisualStyleBackColor = false;
			btnSave.Click += btnSave_Click;
			//
			// btnReset
			//
			btnReset.BackColor = SystemColors.Control;
			btnReset.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
			btnReset.ForeColor = SystemColors.ActiveCaptionText;
			btnReset.Location = new Point(380, 390);
			btnReset.Name = "btnReset";
			btnReset.Size = new Size(110, 44);
			btnReset.TabIndex = 14;
			btnReset.Text = "RESET";
			btnReset.UseVisualStyleBackColor = false;
			btnReset.Click += btnReset_Click;
			//
			// btnDelete
			//
			btnDelete.BackColor = Color.MistyRose;
			btnDelete.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
			btnDelete.ForeColor = SystemColors.ActiveCaptionText;
			btnDelete.Location = new Point(1010, 390);
			btnDelete.Name = "btnDelete";
			btnDelete.Size = new Size(220, 44);
			btnDelete.TabIndex = 15;
			btnDelete.Text = "XÓA THIẾT BỊ ĐÃ CHỌN";
			btnDelete.UseVisualStyleBackColor = false;
			btnDelete.Click += btnDelete_Click;
			//
			// label11
			//
			label11.AutoSize = true;
			label11.BackColor = Color.Transparent;
			label11.Font = new Font("Monotype Corsiva", 28.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
			label11.ForeColor = Color.WhiteSmoke;
			label11.Location = new Point(525, 20);
			label11.Name = "label11";
			label11.Size = new Size(249, 56);
			label11.TabIndex = 16;
			label11.Text = "Anh Tú Gym";
			//
			// label12
			//
			label12.AutoSize = true;
			label12.BackColor = Color.Transparent;
			label12.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
			label12.ForeColor = Color.Orange;
			label12.Location = new Point(505, 90);
			label12.Name = "label12";
			label12.Size = new Size(290, 32);
			label12.TabIndex = 17;
			label12.Text = "THIẾT BỊ - EQUIPMENT";
			//
			// dataGridView1
			//
			DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
			dataGridView1.AllowUserToAddRows = false;
			dataGridView1.AllowUserToDeleteRows = false;
			dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = Color.Orange;
			dataGridViewCellStyle1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
			dataGridViewCellStyle1.ForeColor = Color.White;
			dataGridViewCellStyle1.SelectionBackColor = Color.Orange;
			dataGridViewCellStyle1.SelectionForeColor = Color.White;
			dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dataGridView1.BackgroundColor = Color.WhiteSmoke;
			dataGridView1.ColumnHeadersHeight = 42;
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
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
			dataGridView1.Location = new Point(40, 490);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.ReadOnly = true;
			dataGridView1.RowHeadersWidth = 51;
			dataGridView1.RowTemplate.Height = 32;
			dataGridViewCellStyle3.BackColor = Color.FromArgb(255, 243, 224);
			dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
			dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dataGridView1.Size = new Size(1220, 330);
			dataGridView1.TabIndex = 18;
			//
			// Equipment
			//
			AutoScaleDimensions = new SizeF(9F, 23F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(41, 44, 51);
			ClientSize = new Size(1300, 860);
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
			Text = "Equipment";
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
		private Button btnDelete;
		private Label label11;
		private Label label12;
		private DataGridView dataGridView1;
	}
}
