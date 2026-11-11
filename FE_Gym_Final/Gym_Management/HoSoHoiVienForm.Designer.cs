namespace Gym_Management
{
    partial class HoSoHoiVienForm
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
            panelContent = new Panel();
            lblPTHienTai = new Label();
            txtPTHienTai = new TextBox();
            lblTenDangNhap = new Label();
            txtTenDangNhap = new TextBox();
            lblHoTen = new Label();
            txtHoTen = new TextBox();
            lblSDT = new Label();
            txtSDT = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblGioiTinh = new Label();
            txtGioiTinh = new TextBox();
            lblGoiHienTai = new Label();
            txtGoiHienTai = new TextBox();
            lblGioTapHienTai = new Label();
            txtGioTapHienTai = new TextBox();
            btnDoiGoiTap = new Button();
            btnDong = new Button();
            panelHeader.SuspendLayout();
            panelContent.SuspendLayout();
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
            lblSubtitle.Location = new Point(27, 50);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(330, 20);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Thông tin cá nhân, gói tập và huấn luyện viên PT";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.ForeColor = Color.FromArgb(14, 165, 233);
            lblTitle.Location = new Point(25, 18);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(244, 31);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "HỒ SƠ HỘI VIÊN";
            // 
            // panelContent
            // 
            panelContent.Controls.Add(lblPTHienTai);
            panelContent.Controls.Add(txtPTHienTai);
            panelContent.Controls.Add(lblTenDangNhap);
            panelContent.Controls.Add(txtTenDangNhap);
            panelContent.Controls.Add(lblHoTen);
            panelContent.Controls.Add(txtHoTen);
            panelContent.Controls.Add(lblSDT);
            panelContent.Controls.Add(txtSDT);
            panelContent.Controls.Add(lblEmail);
            panelContent.Controls.Add(txtEmail);
            panelContent.Controls.Add(lblGioiTinh);
            panelContent.Controls.Add(txtGioiTinh);
            panelContent.Controls.Add(lblGoiHienTai);
            panelContent.Controls.Add(txtGoiHienTai);
            panelContent.Controls.Add(lblGioTapHienTai);
            panelContent.Controls.Add(txtGioTapHienTai);
            panelContent.Location = new Point(30, 100);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(520, 390);
            panelContent.TabIndex = 1;
            // 
            // lblPTHienTai
            // 
            lblPTHienTai.AutoSize = true;
            lblPTHienTai.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblPTHienTai.ForeColor = Color.FromArgb(74, 222, 128);
            lblPTHienTai.Location = new Point(10, 345);
            lblPTHienTai.Name = "lblPTHienTai";
            lblPTHienTai.Size = new Size(130, 21);
            lblPTHienTai.TabIndex = 14;
            lblPTHienTai.Text = "HLV (PT) hướng dẫn:";
            // 
            // txtPTHienTai
            // 
            txtPTHienTai.BackColor = Color.FromArgb(51, 65, 85);
            txtPTHienTai.BorderStyle = BorderStyle.FixedSingle;
            txtPTHienTai.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            txtPTHienTai.ForeColor = Color.FromArgb(134, 239, 172);
            txtPTHienTai.Location = new Point(160, 343);
            txtPTHienTai.Name = "txtPTHienTai";
            txtPTHienTai.ReadOnly = true;
            txtPTHienTai.Size = new Size(345, 29);
            txtPTHienTai.TabIndex = 15;
            // 
            // lblTenDangNhap
            // 
            lblTenDangNhap.AutoSize = true;
            lblTenDangNhap.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblTenDangNhap.ForeColor = Color.FromArgb(226, 232, 240);
            lblTenDangNhap.Location = new Point(10, 10);
            lblTenDangNhap.Name = "lblTenDangNhap";
            lblTenDangNhap.Size = new Size(116, 21);
            lblTenDangNhap.TabIndex = 0;
            lblTenDangNhap.Text = "Tên tài khoản:";
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.BackColor = Color.FromArgb(51, 65, 85);
            txtTenDangNhap.BorderStyle = BorderStyle.FixedSingle;
            txtTenDangNhap.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            txtTenDangNhap.ForeColor = Color.White;
            txtTenDangNhap.Location = new Point(160, 8);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.ReadOnly = true;
            txtTenDangNhap.Size = new Size(345, 29);
            txtTenDangNhap.TabIndex = 1;
            // 
            // lblHoTen
            // 
            lblHoTen.AutoSize = true;
            lblHoTen.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblHoTen.ForeColor = Color.FromArgb(226, 232, 240);
            lblHoTen.Location = new Point(10, 55);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(88, 21);
            lblHoTen.TabIndex = 2;
            lblHoTen.Text = "Họ và tên:";
            // 
            // txtHoTen
            // 
            txtHoTen.BackColor = Color.FromArgb(51, 65, 85);
            txtHoTen.BorderStyle = BorderStyle.FixedSingle;
            txtHoTen.Font = new Font("Segoe UI", 9.5F);
            txtHoTen.ForeColor = Color.White;
            txtHoTen.Location = new Point(160, 53);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.ReadOnly = true;
            txtHoTen.Size = new Size(345, 29);
            txtHoTen.TabIndex = 3;
            // 
            // lblSDT
            // 
            lblSDT.AutoSize = true;
            lblSDT.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblSDT.ForeColor = Color.FromArgb(226, 232, 240);
            lblSDT.Location = new Point(10, 100);
            lblSDT.Name = "lblSDT";
            lblSDT.Size = new Size(116, 21);
            lblSDT.TabIndex = 4;
            lblSDT.Text = "Số điện thoại:";
            // 
            // txtSDT
            // 
            txtSDT.BackColor = Color.FromArgb(51, 65, 85);
            txtSDT.BorderStyle = BorderStyle.FixedSingle;
            txtSDT.Font = new Font("Segoe UI", 9.5F);
            txtSDT.ForeColor = Color.White;
            txtSDT.Location = new Point(160, 98);
            txtSDT.Name = "txtSDT";
            txtSDT.ReadOnly = true;
            txtSDT.Size = new Size(345, 29);
            txtSDT.TabIndex = 5;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblEmail.ForeColor = Color.FromArgb(226, 232, 240);
            lblEmail.Location = new Point(10, 145);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(57, 21);
            lblEmail.TabIndex = 6;
            lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.FromArgb(51, 65, 85);
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Font = new Font("Segoe UI", 9.5F);
            txtEmail.ForeColor = Color.White;
            txtEmail.Location = new Point(160, 143);
            txtEmail.Name = "txtEmail";
            txtEmail.ReadOnly = true;
            txtEmail.Size = new Size(345, 29);
            txtEmail.TabIndex = 7;
            // 
            // lblGioiTinh
            // 
            lblGioiTinh.AutoSize = true;
            lblGioiTinh.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblGioiTinh.ForeColor = Color.FromArgb(226, 232, 240);
            lblGioiTinh.Location = new Point(10, 190);
            lblGioiTinh.Name = "lblGioiTinh";
            lblGioiTinh.Size = new Size(80, 21);
            lblGioiTinh.TabIndex = 8;
            lblGioiTinh.Text = "Giới tính:";
            // 
            // txtGioiTinh
            // 
            txtGioiTinh.BackColor = Color.FromArgb(51, 65, 85);
            txtGioiTinh.BorderStyle = BorderStyle.FixedSingle;
            txtGioiTinh.Font = new Font("Segoe UI", 9.5F);
            txtGioiTinh.ForeColor = Color.White;
            txtGioiTinh.Location = new Point(160, 188);
            txtGioiTinh.Name = "txtGioiTinh";
            txtGioiTinh.ReadOnly = true;
            txtGioiTinh.Size = new Size(345, 29);
            txtGioiTinh.TabIndex = 9;
            // 
            // lblGoiHienTai
            // 
            lblGoiHienTai.AutoSize = true;
            lblGoiHienTai.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblGoiHienTai.ForeColor = Color.FromArgb(245, 158, 11);
            lblGoiHienTai.Location = new Point(10, 245);
            lblGoiHienTai.Name = "lblGoiHienTai";
            lblGoiHienTai.Size = new Size(135, 21);
            lblGoiHienTai.TabIndex = 10;
            lblGoiHienTai.Text = "Gói tập hiện tại:";
            // 
            // txtGoiHienTai
            // 
            txtGoiHienTai.BackColor = Color.FromArgb(51, 65, 85);
            txtGoiHienTai.BorderStyle = BorderStyle.FixedSingle;
            txtGoiHienTai.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            txtGoiHienTai.ForeColor = Color.FromArgb(253, 224, 71);
            txtGoiHienTai.Location = new Point(160, 243);
            txtGoiHienTai.Name = "txtGoiHienTai";
            txtGoiHienTai.ReadOnly = true;
            txtGoiHienTai.Size = new Size(345, 29);
            txtGoiHienTai.TabIndex = 11;
            // 
            // lblGioTapHienTai
            // 
            lblGioTapHienTai.AutoSize = true;
            lblGioTapHienTai.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblGioTapHienTai.ForeColor = Color.FromArgb(56, 189, 248);
            lblGioTapHienTai.Location = new Point(10, 295);
            lblGioTapHienTai.Name = "lblGioTapHienTai";
            lblGioTapHienTai.Size = new Size(138, 21);
            lblGioTapHienTai.TabIndex = 12;
            lblGioTapHienTai.Text = "Khung giờ tập:";
            // 
            // txtGioTapHienTai
            // 
            txtGioTapHienTai.BackColor = Color.FromArgb(51, 65, 85);
            txtGioTapHienTai.BorderStyle = BorderStyle.FixedSingle;
            txtGioTapHienTai.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            txtGioTapHienTai.ForeColor = Color.FromArgb(125, 211, 252);
            txtGioTapHienTai.Location = new Point(160, 293);
            txtGioTapHienTai.Name = "txtGioTapHienTai";
            txtGioTapHienTai.ReadOnly = true;
            txtGioTapHienTai.Size = new Size(345, 29);
            txtGioTapHienTai.TabIndex = 13;
            // 
            // btnDoiGoiTap
            // 
            btnDoiGoiTap.BackColor = Color.FromArgb(16, 185, 129);
            btnDoiGoiTap.FlatAppearance.BorderSize = 0;
            btnDoiGoiTap.FlatStyle = FlatStyle.Flat;
            btnDoiGoiTap.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDoiGoiTap.ForeColor = Color.White;
            btnDoiGoiTap.Location = new Point(90, 505);
            btnDoiGoiTap.Name = "btnDoiGoiTap";
            btnDoiGoiTap.Size = new Size(240, 44);
            btnDoiGoiTap.TabIndex = 2;
            btnDoiGoiTap.Text = "📦 ĐỔI GÓI / GIỜ / HLV";
            btnDoiGoiTap.UseVisualStyleBackColor = false;
            btnDoiGoiTap.Click += btnDoiGoiTap_Click;
            // 
            // btnDong
            // 
            btnDong.BackColor = Color.FromArgb(71, 85, 105);
            btnDong.DialogResult = DialogResult.Cancel;
            btnDong.FlatAppearance.BorderSize = 0;
            btnDong.FlatStyle = FlatStyle.Flat;
            btnDong.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDong.ForeColor = Color.White;
            btnDong.Location = new Point(350, 505);
            btnDong.Name = "btnDong";
            btnDong.Size = new Size(130, 44);
            btnDong.TabIndex = 3;
            btnDong.Text = "ĐÓNG";
            btnDong.UseVisualStyleBackColor = false;
            btnDong.Click += btnDong_Click;
            // 
            // HoSoHoiVienForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(24, 30, 48);
            CancelButton = btnDong;
            ClientSize = new Size(580, 570);
            Controls.Add(btnDong);
            Controls.Add(btnDoiGoiTap);
            Controls.Add(panelContent);
            Controls.Add(panelHeader);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "HoSoHoiVienForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Hồ Sơ Hội Viên - Hệ Thống Quản Lý Gym Anh Tú";
            Load += HoSoHoiVienForm_Load;
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelContent.ResumeLayout(false);
            panelContent.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Label lblTitle;
        private Label lblSubtitle;
        private Panel panelContent;
        private Label lblTenDangNhap;
        private TextBox txtTenDangNhap;
        private Label lblHoTen;
        private TextBox txtHoTen;
        private Label lblSDT;
        private TextBox txtSDT;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label lblGioiTinh;
        private TextBox txtGioiTinh;
        private Label lblGoiHienTai;
        private TextBox txtGoiHienTai;
        private Label lblGioTapHienTai;
        private TextBox txtGioTapHienTai;
        private Label lblPTHienTai;
        private TextBox txtPTHienTai;
        private Button btnDoiGoiTap;
        private Button btnDong;
    }
}
