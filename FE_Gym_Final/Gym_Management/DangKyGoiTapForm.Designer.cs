namespace Gym_Management
{
    partial class DangKyGoiTapForm
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
            panelHeader = new Panel();
            lblSubtitle = new Label();
            lblTitle = new Label();
            lblHoiVien = new Label();
            txtHoiVien = new TextBox();
            cmbChonHoiVien = new ComboBox();
            lblGoiTap = new Label();
            cmbGoiTap = new ComboBox();
            lblGioTap = new Label();
            cmbGioTap = new ComboBox();
            lblPT = new Label();
            cmbPT = new ComboBox();
            lblGhiChuGoi = new Label();
            btnXacNhan = new Button();
            btnHuy = new Button();
            panelHeader.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(15, 23, 42);
            panelHeader.Controls.Add(lblSubtitle);
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(580, 85);
            panelHeader.TabIndex = 0;
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblSubtitle.ForeColor = Color.FromArgb(148, 163, 184);
            lblSubtitle.Location = new Point(27, 49);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(440, 20);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Lựa chọn gói hội viên, khung giờ tập và huấn luyện viên hướng dẫn";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 13.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.ForeColor = Color.FromArgb(245, 158, 11);
            lblTitle.Location = new Point(25, 16);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(470, 31);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "ĐĂNG KÝ GÓI TẬP, GIỜ TẬP && HLV (PT)";
            // 
            // lblHoiVien
            // 
            lblHoiVien.AutoSize = true;
            lblHoiVien.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblHoiVien.ForeColor = Color.FromArgb(226, 232, 240);
            lblHoiVien.Location = new Point(40, 105);
            lblHoiVien.Name = "lblHoiVien";
            lblHoiVien.Size = new Size(168, 23);
            lblHoiVien.TabIndex = 1;
            lblHoiVien.Text = "Hội viên đăng ký:";
            // 
            // txtHoiVien
            // 
            txtHoiVien.BackColor = Color.FromArgb(51, 65, 85);
            txtHoiVien.BorderStyle = BorderStyle.FixedSingle;
            txtHoiVien.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtHoiVien.ForeColor = Color.FromArgb(241, 245, 249);
            txtHoiVien.Location = new Point(40, 132);
            txtHoiVien.Name = "txtHoiVien";
            txtHoiVien.ReadOnly = true;
            txtHoiVien.Size = new Size(500, 30);
            txtHoiVien.TabIndex = 2;
            // 
            // cmbChonHoiVien
            // 
            cmbChonHoiVien.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbChonHoiVien.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            cmbChonHoiVien.FormattingEnabled = true;
            cmbChonHoiVien.Location = new Point(40, 132);
            cmbChonHoiVien.Name = "cmbChonHoiVien";
            cmbChonHoiVien.Size = new Size(500, 31);
            cmbChonHoiVien.TabIndex = 2;
            cmbChonHoiVien.Visible = false;
            cmbChonHoiVien.SelectedIndexChanged += cmbChonHoiVien_SelectedIndexChanged;
            // 
            // lblGoiTap
            // 
            lblGoiTap.AutoSize = true;
            lblGoiTap.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblGoiTap.ForeColor = Color.FromArgb(226, 232, 240);
            lblGoiTap.Location = new Point(40, 175);
            lblGoiTap.Name = "lblGoiTap";
            lblGoiTap.Size = new Size(147, 23);
            lblGoiTap.TabIndex = 3;
            lblGoiTap.Text = "Lựa chọn Gói tập:";
            // 
            // cmbGoiTap
            // 
            cmbGoiTap.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGoiTap.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            cmbGoiTap.FormattingEnabled = true;
            cmbGoiTap.Items.AddRange(new object[] {
            "Gói 1 Tháng (300,000 đ) - Thẻ tập tiêu chuẩn",
            "Gói 3 Tháng (850,000 đ) - Tiết kiệm 5% + Đo InBody",
            "Gói 6 Tháng (1,600,000 đ) - Tiết kiệm 10% + 1 buổi PT",
            "Gói 12 Tháng VIP (3,000,000 đ) - Không giới hạn + Tủ riêng"});
            cmbGoiTap.Location = new Point(40, 202);
            cmbGoiTap.Name = "cmbGoiTap";
            cmbGoiTap.Size = new Size(500, 31);
            cmbGoiTap.TabIndex = 4;
            // 
            // lblGioTap
            // 
            lblGioTap.AutoSize = true;
            lblGioTap.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblGioTap.ForeColor = Color.FromArgb(226, 232, 240);
            lblGioTap.Location = new Point(40, 245);
            lblGioTap.Name = "lblGioTap";
            lblGioTap.Size = new Size(187, 23);
            lblGioTap.TabIndex = 5;
            lblGioTap.Text = "Lựa chọn Khung giờ tập:";
            // 
            // cmbGioTap
            // 
            cmbGioTap.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGioTap.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            cmbGioTap.FormattingEnabled = true;
            cmbGioTap.Items.AddRange(new object[] {
            "06:00 - 08:00 (Sáng sớm)",
            "08:00 - 10:00 (Buổi sáng)",
            "14:00 - 16:00 (Đầu giờ chiều)",
            "16:00 - 18:00 (Chiều tan tầm)",
            "18:00 - 20:00 (Buổi tối)",
            "20:00 - 22:00 (Tối muộn)"});
            cmbGioTap.Location = new Point(40, 272);
            cmbGioTap.Name = "cmbGioTap";
            cmbGioTap.Size = new Size(500, 31);
            cmbGioTap.TabIndex = 6;
            // 
            // lblPT
            // 
            lblPT.AutoSize = true;
            lblPT.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblPT.ForeColor = Color.FromArgb(226, 232, 240);
            lblPT.Location = new Point(40, 315);
            lblPT.Name = "lblPT";
            lblPT.Size = new Size(245, 23);
            lblPT.TabIndex = 7;
            lblPT.Text = "Huấn luyện viên (PT) hướng dẫn:";
            // 
            // cmbPT
            // 
            cmbPT.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPT.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            cmbPT.FormattingEnabled = true;
            cmbPT.Location = new Point(40, 342);
            cmbPT.Name = "cmbPT";
            cmbPT.Size = new Size(500, 31);
            cmbPT.TabIndex = 8;
            // 
            // lblGhiChuGoi
            // 
            lblGhiChuGoi.BackColor = Color.FromArgb(30, 41, 59);
            lblGhiChuGoi.BorderStyle = BorderStyle.FixedSingle;
            lblGhiChuGoi.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            lblGhiChuGoi.ForeColor = Color.FromArgb(148, 163, 184);
            lblGhiChuGoi.Location = new Point(40, 390);
            lblGhiChuGoi.Name = "lblGhiChuGoi";
            lblGhiChuGoi.Padding = new Padding(10);
            lblGhiChuGoi.Size = new Size(500, 75);
            lblGhiChuGoi.TabIndex = 9;
            lblGhiChuGoi.Text = "💡 Quyền lợi: Sau khi xác nhận đăng ký, hội viên có thể tham gia tập luyện theo khung giờ đã chọn, sử dụng đầy đủ các máy móc thiết bị và được kèm cặp bởi Huấn luyện viên (PT) phụ trách.";
            // 
            // btnXacNhan
            // 
            btnXacNhan.BackColor = Color.FromArgb(16, 185, 129);
            btnXacNhan.FlatAppearance.BorderSize = 0;
            btnXacNhan.FlatStyle = FlatStyle.Flat;
            btnXacNhan.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnXacNhan.ForeColor = Color.White;
            btnXacNhan.Location = new Point(130, 485);
            btnXacNhan.Name = "btnXacNhan";
            btnXacNhan.Size = new Size(190, 44);
            btnXacNhan.TabIndex = 10;
            btnXacNhan.Text = "XÁC NHẬN ĐĂNG KÝ";
            btnXacNhan.UseVisualStyleBackColor = false;
            btnXacNhan.Click += btnXacNhan_Click;
            // 
            // btnHuy
            // 
            btnHuy.BackColor = Color.FromArgb(71, 85, 105);
            btnHuy.DialogResult = DialogResult.Cancel;
            btnHuy.FlatAppearance.BorderSize = 0;
            btnHuy.FlatStyle = FlatStyle.Flat;
            btnHuy.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnHuy.ForeColor = Color.White;
            btnHuy.Location = new Point(340, 485);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(110, 44);
            btnHuy.TabIndex = 11;
            btnHuy.Text = "HỦY";
            btnHuy.UseVisualStyleBackColor = false;
            btnHuy.Click += btnHuy_Click;
            // 
            // DangKyGoiTapForm
            // 
            AcceptButton = btnXacNhan;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(24, 30, 48);
            CancelButton = btnHuy;
            ClientSize = new Size(580, 560);
            Controls.Add(btnHuy);
            Controls.Add(btnXacNhan);
            Controls.Add(lblGhiChuGoi);
            Controls.Add(cmbPT);
            Controls.Add(lblPT);
            Controls.Add(cmbGioTap);
            Controls.Add(lblGioTap);
            Controls.Add(cmbGoiTap);
            Controls.Add(lblGoiTap);
            Controls.Add(cmbChonHoiVien);
            Controls.Add(txtHoiVien);
            Controls.Add(lblHoiVien);
            Controls.Add(panelHeader);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DangKyGoiTapForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Đăng Ký Gói Tập, Giờ Tập & Huấn Luyện Viên PT";
            Load += DangKyGoiTapForm_Load;
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelHeader;
        private Label lblTitle;
        private Label lblSubtitle;
        private Label lblHoiVien;
        private TextBox txtHoiVien;
        private ComboBox cmbChonHoiVien;
        private Label lblGoiTap;
        private ComboBox cmbGoiTap;
        private Label lblGioTap;
        private ComboBox cmbGioTap;
        private Label lblPT;
        private ComboBox cmbPT;
        private Label lblGhiChuGoi;
        private Button btnXacNhan;
        private Button btnHuy;
    }
}
