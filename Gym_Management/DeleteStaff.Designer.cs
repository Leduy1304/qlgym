namespace Gym_Management
{
	partial class DeleteStaff
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
			label1 = new Label();
			txtId = new TextBox();
			btnSearch = new Button();
			btnDelete = new Button();
			btnReset = new Button();
			dataGridView1 = new DataGridView();
			labelHint = new Label();
			label11 = new Label();
			label12 = new Label();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			SuspendLayout();
			//
			// label1
			//
			label1.BackColor = Color.Transparent;
			label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
			label1.ForeColor = SystemColors.Control;
			label1.Location = new Point(140, 170);
			label1.Name = "label1";
			label1.Size = new Size(220, 28);
			label1.TabIndex = 0;
			label1.Text = "Mã nhân viên (SID)";
			label1.TextAlign = ContentAlignment.TopRight;
			//
			// txtId
			//
			txtId.Location = new Point(380, 168);
			txtId.Name = "txtId";
			txtId.Size = new Size(200, 30);
			txtId.TabIndex = 1;
			//
			// btnSearch
			//
			btnSearch.BackColor = SystemColors.Control;
			btnSearch.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
			btnSearch.ForeColor = SystemColors.ActiveCaptionText;
			btnSearch.Location = new Point(610, 162);
			btnSearch.Name = "btnSearch";
			btnSearch.Size = new Size(130, 44);
			btnSearch.TabIndex = 2;
			btnSearch.Text = "KIỂM TRA";
			btnSearch.UseVisualStyleBackColor = false;
			btnSearch.Click += btnSearch_Click;
			//
			// btnDelete
			//
			btnDelete.BackColor = Color.MistyRose;
			btnDelete.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
			btnDelete.ForeColor = SystemColors.ActiveCaptionText;
			btnDelete.Location = new Point(770, 162);
			btnDelete.Name = "btnDelete";
			btnDelete.Size = new Size(130, 44);
			btnDelete.TabIndex = 3;
			btnDelete.Text = "XÓA";
			btnDelete.UseVisualStyleBackColor = false;
			btnDelete.Click += btnDelete_Click;
			//
			// btnReset
			//
			btnReset.BackColor = SystemColors.Control;
			btnReset.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
			btnReset.ForeColor = SystemColors.ActiveCaptionText;
			btnReset.Location = new Point(930, 162);
			btnReset.Name = "btnReset";
			btnReset.Size = new Size(130, 44);
			btnReset.TabIndex = 4;
			btnReset.Text = "RESET";
			btnReset.UseVisualStyleBackColor = false;
			btnReset.Click += btnReset_Click;
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
			dataGridView1.Location = new Point(40, 250);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.ReadOnly = true;
			dataGridView1.RowHeadersWidth = 51;
			dataGridView1.RowTemplate.Height = 32;
			dataGridViewCellStyle3.BackColor = Color.FromArgb(255, 243, 224);
			dataGridViewCellStyle3.Font = new Font("Segoe UI", 10.2F);
			dataGridViewCellStyle3.ForeColor = Color.Black;
			dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(255, 190, 90);
			dataGridViewCellStyle3.SelectionForeColor = Color.Black;
			dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
			dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dataGridView1.Size = new Size(1020, 370);
			dataGridView1.TabIndex = 5;
			dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
			//
			// labelHint
			//
			labelHint.AutoSize = true;
			labelHint.BackColor = Color.Transparent;
			labelHint.Font = new Font("Segoe UI", 10F, FontStyle.Italic);
			labelHint.ForeColor = Color.LightGray;
			labelHint.Location = new Point(40, 640);
			labelHint.Name = "labelHint";
			labelHint.Size = new Size(560, 23);
			labelHint.TabIndex = 6;
			labelHint.Text = "Mẹo: Nhấn đúp vào 1 dòng trong danh sách để tự điền mã nhân viên, rồi bấm XÓA.";
			//
			// label11
			//
			label11.AutoSize = true;
			label11.BackColor = Color.Transparent;
			label11.Font = new Font("Monotype Corsiva", 28.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
			label11.ForeColor = Color.WhiteSmoke;
			label11.Location = new Point(425, 20);
			label11.Name = "label11";
			label11.Size = new Size(249, 56);
			label11.TabIndex = 7;
			label11.Text = "Anh Tú Gym";
			//
			// label12
			//
			label12.AutoSize = true;
			label12.BackColor = Color.Transparent;
			label12.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
			label12.ForeColor = Color.Orange;
			label12.Location = new Point(390, 90);
			label12.Name = "label12";
			label12.Size = new Size(320, 32);
			label12.TabIndex = 8;
			label12.Text = "XÓA NHÂN VIÊN - DELETE STAFF";
			//
			// DeleteStaff
			//
			AutoScaleDimensions = new SizeF(9F, 23F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(41, 44, 51);
			ClientSize = new Size(1100, 690);
			Controls.Add(label12);
			Controls.Add(label11);
			Controls.Add(labelHint);
			Controls.Add(dataGridView1);
			Controls.Add(btnReset);
			Controls.Add(btnDelete);
			Controls.Add(btnSearch);
			Controls.Add(txtId);
			Controls.Add(label1);
			Font = new Font("Segoe UI", 10.2F);
			ForeColor = SystemColors.Control;
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "DeleteStaff";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Delete Staff";
			Load += DeleteStaff_Load;
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private TextBox txtId;
		private Button btnSearch;
		private Button btnDelete;
		private Button btnReset;
		private DataGridView dataGridView1;
		private Label labelHint;
		private Label label11;
		private Label label12;
	}
}
