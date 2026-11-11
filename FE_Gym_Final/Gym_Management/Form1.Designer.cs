namespace Gym_Management
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panelTopBar = new Panel();
            panelUserInfo = new Panel();
            btnTopExit = new Button();
            btnTopLogout = new Button();
            lblRoleBadge = new Label();
            lblXinChao = new Label();
            lblSystemSubtitle = new Label();
            lblLogo = new Label();
            panelSidebar = new Panel();
            panelSidebarButtons = new FlowLayoutPanel();
            btnNavRegisterPackage = new Button();
            btnNavMyProfile = new Button();
            btnNavNewMember = new Button();
            btnNavSearchMember = new Button();
            btnNavDeleteMember = new Button();
            btnNavNewPT = new Button();
            btnNavSearchPT = new Button();
            btnNavDeletePT = new Button();
            btnNavEquipment = new Button();
            lblSidebarTitle = new Label();
            panelContent = new Panel();
            flowCards = new FlowLayoutPanel();
            panelCard1 = new Panel();
            btnCardAction1 = new Button();
            lblCard1Desc = new Label();
            lblCard1Title = new Label();
            lblCard1Icon = new Label();
            panelCard1Accent = new Panel();
            panelCard2 = new Panel();
            btnCardAction2 = new Button();
            lblCard2Desc = new Label();
            lblCard2Title = new Label();
            lblCard2Icon = new Label();
            panelCard2Accent = new Panel();
            panelCard3 = new Panel();
            btnCardAction3 = new Button();
            lblCard3Desc = new Label();
            lblCard3Title = new Label();
            lblCard3Icon = new Label();
            panelCard3Accent = new Panel();
            panelCard4 = new Panel();
            btnCardAction4 = new Button();
            lblCard4Desc = new Label();
            lblCard4Title = new Label();
            lblCard4Icon = new Label();
            panelCard4Accent = new Panel();
            panelHero = new Panel();
            lblHeroDesc = new Label();
            lblHeroTitle = new Label();
            statusStrip1 = new StatusStrip();
            lblStatusRole = new ToolStripStatusLabel();
            lblStatusServer = new ToolStripStatusLabel();
            lblStatusTime = new ToolStripStatusLabel();
            clockTimer = new System.Windows.Forms.Timer(components);
            panelTopBar.SuspendLayout();
            panelUserInfo.SuspendLayout();
            panelSidebar.SuspendLayout();
            panelSidebarButtons.SuspendLayout();
            panelContent.SuspendLayout();
            flowCards.SuspendLayout();
            panelCard1.SuspendLayout();
            panelCard2.SuspendLayout();
            panelCard3.SuspendLayout();
            panelCard4.SuspendLayout();
            panelHero.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panelTopBar
            // 
            panelTopBar.BackColor = Color.FromArgb(15, 23, 42);
            panelTopBar.Controls.Add(panelUserInfo);
            panelTopBar.Controls.Add(lblSystemSubtitle);
            panelTopBar.Controls.Add(lblLogo);
            panelTopBar.Dock = DockStyle.Top;
            panelTopBar.Location = new Point(0, 0);
            panelTopBar.Name = "panelTopBar";
            panelTopBar.Padding = new Padding(20, 0, 20, 0);
            panelTopBar.Size = new Size(1280, 75);
            panelTopBar.TabIndex = 0;
            // 
            // panelUserInfo
            // 
            panelUserInfo.Controls.Add(btnTopExit);
            panelUserInfo.Controls.Add(btnTopLogout);
            panelUserInfo.Controls.Add(lblRoleBadge);
            panelUserInfo.Controls.Add(lblXinChao);
            panelUserInfo.Dock = DockStyle.Right;
            panelUserInfo.Location = new Point(680, 0);
            panelUserInfo.Name = "panelUserInfo";
            panelUserInfo.Size = new Size(580, 75);
            panelUserInfo.TabIndex = 2;
            // 
            // btnTopExit
            // 
            btnTopExit.BackColor = Color.FromArgb(185, 28, 28);
            btnTopExit.FlatAppearance.BorderSize = 0;
            btnTopExit.FlatStyle = FlatStyle.Flat;
            btnTopExit.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnTopExit.ForeColor = Color.White;
            btnTopExit.Location = new Point(480, 20);
            btnTopExit.Name = "btnTopExit";
            btnTopExit.Size = new Size(85, 34);
            btnTopExit.TabIndex = 3;
            btnTopExit.Text = "🚪 Thoát";
            btnTopExit.UseVisualStyleBackColor = false;
            btnTopExit.Click += btnTopExit_Click;
            // 
            // btnTopLogout
            // 
            btnTopLogout.BackColor = Color.FromArgb(51, 65, 85);
            btnTopLogout.FlatAppearance.BorderSize = 0;
            btnTopLogout.FlatStyle = FlatStyle.Flat;
            btnTopLogout.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnTopLogout.ForeColor = Color.White;
            btnTopLogout.Location = new Point(365, 20);
            btnTopLogout.Name = "btnTopLogout";
            btnTopLogout.Size = new Size(105, 34);
            btnTopLogout.TabIndex = 2;
            btnTopLogout.Text = "🔑 Đăng xuất";
            btnTopLogout.UseVisualStyleBackColor = false;
            btnTopLogout.Click += btnTopLogout_Click;
            // 
            // lblRoleBadge
            // 
            lblRoleBadge.BackColor = Color.FromArgb(16, 185, 129);
            lblRoleBadge.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblRoleBadge.ForeColor = Color.White;
            lblRoleBadge.Location = new Point(220, 22);
            lblRoleBadge.Name = "lblRoleBadge";
            lblRoleBadge.Size = new Size(135, 30);
            lblRoleBadge.TabIndex = 1;
            lblRoleBadge.Text = "[ HỘI VIÊN ]";
            lblRoleBadge.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblXinChao
            // 
            lblXinChao.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            lblXinChao.ForeColor = Color.FromArgb(241, 245, 249);
            lblXinChao.Location = new Point(10, 24);
            lblXinChao.Name = "lblXinChao";
            lblXinChao.Size = new Size(205, 25);
            lblXinChao.TabIndex = 0;
            lblXinChao.Text = "👤 Xin chào: Duy";
            lblXinChao.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblSystemSubtitle
            // 
            lblSystemSubtitle.AutoSize = true;
            lblSystemSubtitle.Font = new Font("Segoe UI", 8.25F);
            lblSystemSubtitle.ForeColor = Color.FromArgb(148, 163, 184);
            lblSystemSubtitle.Location = new Point(22, 45);
            lblSystemSubtitle.Name = "lblSystemSubtitle";
            lblSystemSubtitle.Size = new Size(318, 19);
            lblSystemSubtitle.TabIndex = 1;
            lblSystemSubtitle.Text = "HỆ THỐNG QUẢN LÝ PHÒNG TẬP THỂ HÌNH HIỆN ĐẠI";
            // 
            // lblLogo
            // 
            lblLogo.AutoSize = true;
            lblLogo.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblLogo.ForeColor = Color.FromArgb(245, 158, 11);
            lblLogo.Location = new Point(20, 14);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new Size(420, 32);
            lblLogo.TabIndex = 0;
            lblLogo.Text = "🏋️ HỆ THỐNG QUẢN LÝ GYM ANH TÚ";
            // 
            // panelSidebar
            // 
            panelSidebar.BackColor = Color.FromArgb(30, 41, 59);
            panelSidebar.Controls.Add(panelSidebarButtons);
            panelSidebar.Controls.Add(lblSidebarTitle);
            panelSidebar.Dock = DockStyle.Left;
            panelSidebar.Location = new Point(0, 75);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Size = new Size(270, 655);
            panelSidebar.TabIndex = 1;
            // 
            // panelSidebarButtons
            // 
            panelSidebarButtons.AutoScroll = true;
            panelSidebarButtons.Controls.Add(btnNavRegisterPackage);
            panelSidebarButtons.Controls.Add(btnNavMyProfile);
            panelSidebarButtons.Controls.Add(btnNavNewMember);
            panelSidebarButtons.Controls.Add(btnNavSearchMember);
            panelSidebarButtons.Controls.Add(btnNavDeleteMember);
            panelSidebarButtons.Controls.Add(btnNavNewPT);
            panelSidebarButtons.Controls.Add(btnNavSearchPT);
            panelSidebarButtons.Controls.Add(btnNavDeletePT);
            panelSidebarButtons.Controls.Add(btnNavEquipment);
            panelSidebarButtons.Dock = DockStyle.Fill;
            panelSidebarButtons.FlowDirection = FlowDirection.TopDown;
            panelSidebarButtons.Location = new Point(0, 45);
            panelSidebarButtons.Name = "panelSidebarButtons";
            panelSidebarButtons.Padding = new Padding(10, 10, 10, 10);
            panelSidebarButtons.Size = new Size(270, 610);
            panelSidebarButtons.TabIndex = 1;
            panelSidebarButtons.WrapContents = false;
            // 
            // btnNavRegisterPackage
            // 
            btnNavRegisterPackage.BackColor = Color.FromArgb(16, 185, 129);
            btnNavRegisterPackage.FlatAppearance.BorderSize = 0;
            btnNavRegisterPackage.FlatStyle = FlatStyle.Flat;
            btnNavRegisterPackage.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnNavRegisterPackage.ForeColor = Color.White;
            btnNavRegisterPackage.Location = new Point(13, 13);
            btnNavRegisterPackage.Name = "btnNavRegisterPackage";
            btnNavRegisterPackage.Size = new Size(240, 48);
            btnNavRegisterPackage.TabIndex = 0;
            btnNavRegisterPackage.Text = "📦  Đăng Ký Gói && Giờ";
            btnNavRegisterPackage.TextAlign = ContentAlignment.MiddleLeft;
            btnNavRegisterPackage.UseVisualStyleBackColor = false;
            btnNavRegisterPackage.Click += btnNavRegisterPackage_Click;
            // 
            // btnNavMyProfile
            // 
            btnNavMyProfile.BackColor = Color.FromArgb(51, 65, 85);
            btnNavMyProfile.FlatAppearance.BorderSize = 0;
            btnNavMyProfile.FlatStyle = FlatStyle.Flat;
            btnNavMyProfile.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnNavMyProfile.ForeColor = Color.White;
            btnNavMyProfile.Location = new Point(13, 67);
            btnNavMyProfile.Name = "btnNavMyProfile";
            btnNavMyProfile.Size = new Size(240, 46);
            btnNavMyProfile.TabIndex = 1;
            btnNavMyProfile.Text = "👤  Hồ Sơ Của Tôi";
            btnNavMyProfile.TextAlign = ContentAlignment.MiddleLeft;
            btnNavMyProfile.UseVisualStyleBackColor = false;
            btnNavMyProfile.Click += btnNavMyProfile_Click;
            // 
            // btnNavNewMember
            // 
            btnNavNewMember.BackColor = Color.FromArgb(51, 65, 85);
            btnNavNewMember.FlatAppearance.BorderSize = 0;
            btnNavNewMember.FlatStyle = FlatStyle.Flat;
            btnNavNewMember.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnNavNewMember.ForeColor = Color.White;
            btnNavNewMember.Location = new Point(13, 119);
            btnNavNewMember.Name = "btnNavNewMember";
            btnNavNewMember.Size = new Size(240, 46);
            btnNavNewMember.TabIndex = 2;
            btnNavNewMember.Text = "➕  Thêm Hội Viên";
            btnNavNewMember.TextAlign = ContentAlignment.MiddleLeft;
            btnNavNewMember.UseVisualStyleBackColor = false;
            btnNavNewMember.Click += btnNavNewMember_Click;
            // 
            // btnNavSearchMember
            // 
            btnNavSearchMember.BackColor = Color.FromArgb(51, 65, 85);
            btnNavSearchMember.FlatAppearance.BorderSize = 0;
            btnNavSearchMember.FlatStyle = FlatStyle.Flat;
            btnNavSearchMember.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnNavSearchMember.ForeColor = Color.White;
            btnNavSearchMember.Location = new Point(13, 171);
            btnNavSearchMember.Name = "btnNavSearchMember";
            btnNavSearchMember.Size = new Size(240, 46);
            btnNavSearchMember.TabIndex = 3;
            btnNavSearchMember.Text = "🔍  Tra Cứu Hội Viên";
            btnNavSearchMember.TextAlign = ContentAlignment.MiddleLeft;
            btnNavSearchMember.UseVisualStyleBackColor = false;
            btnNavSearchMember.Click += btnNavSearchMember_Click;
            // 
            // btnNavDeleteMember
            // 
            btnNavDeleteMember.BackColor = Color.FromArgb(51, 65, 85);
            btnNavDeleteMember.FlatAppearance.BorderSize = 0;
            btnNavDeleteMember.FlatStyle = FlatStyle.Flat;
            btnNavDeleteMember.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnNavDeleteMember.ForeColor = Color.FromArgb(252, 165, 165);
            btnNavDeleteMember.Location = new Point(13, 223);
            btnNavDeleteMember.Name = "btnNavDeleteMember";
            btnNavDeleteMember.Size = new Size(240, 46);
            btnNavDeleteMember.TabIndex = 4;
            btnNavDeleteMember.Text = "🗑️  Xóa Hội Viên";
            btnNavDeleteMember.TextAlign = ContentAlignment.MiddleLeft;
            btnNavDeleteMember.UseVisualStyleBackColor = false;
            btnNavDeleteMember.Click += btnNavDeleteMember_Click;
            // 
            // btnNavNewPT
            // 
            btnNavNewPT.BackColor = Color.FromArgb(51, 65, 85);
            btnNavNewPT.FlatAppearance.BorderSize = 0;
            btnNavNewPT.FlatStyle = FlatStyle.Flat;
            btnNavNewPT.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnNavNewPT.ForeColor = Color.White;
            btnNavNewPT.Location = new Point(13, 275);
            btnNavNewPT.Name = "btnNavNewPT";
            btnNavNewPT.Size = new Size(240, 46);
            btnNavNewPT.TabIndex = 5;
            btnNavNewPT.Text = "➕  Thêm HLV (PT)";
            btnNavNewPT.TextAlign = ContentAlignment.MiddleLeft;
            btnNavNewPT.UseVisualStyleBackColor = false;
            btnNavNewPT.Click += btnNavNewPT_Click;
            // 
            // btnNavSearchPT
            // 
            btnNavSearchPT.BackColor = Color.FromArgb(51, 65, 85);
            btnNavSearchPT.FlatAppearance.BorderSize = 0;
            btnNavSearchPT.FlatStyle = FlatStyle.Flat;
            btnNavSearchPT.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnNavSearchPT.ForeColor = Color.White;
            btnNavSearchPT.Location = new Point(13, 327);
            btnNavSearchPT.Name = "btnNavSearchPT";
            btnNavSearchPT.Size = new Size(240, 46);
            btnNavSearchPT.TabIndex = 6;
            btnNavSearchPT.Text = "🥋  Tra Cứu HLV (PT)";
            btnNavSearchPT.TextAlign = ContentAlignment.MiddleLeft;
            btnNavSearchPT.UseVisualStyleBackColor = false;
            btnNavSearchPT.Click += btnNavSearchPT_Click;
            // 
            // btnNavDeletePT
            // 
            btnNavDeletePT.BackColor = Color.FromArgb(51, 65, 85);
            btnNavDeletePT.FlatAppearance.BorderSize = 0;
            btnNavDeletePT.FlatStyle = FlatStyle.Flat;
            btnNavDeletePT.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnNavDeletePT.ForeColor = Color.FromArgb(252, 165, 165);
            btnNavDeletePT.Location = new Point(13, 379);
            btnNavDeletePT.Name = "btnNavDeletePT";
            btnNavDeletePT.Size = new Size(240, 46);
            btnNavDeletePT.TabIndex = 7;
            btnNavDeletePT.Text = "🗑️  Xóa HLV (PT)";
            btnNavDeletePT.TextAlign = ContentAlignment.MiddleLeft;
            btnNavDeletePT.UseVisualStyleBackColor = false;
            btnNavDeletePT.Click += btnNavDeletePT_Click;
            // 
            // btnNavEquipment
            // 
            btnNavEquipment.BackColor = Color.FromArgb(51, 65, 85);
            btnNavEquipment.FlatAppearance.BorderSize = 0;
            btnNavEquipment.FlatStyle = FlatStyle.Flat;
            btnNavEquipment.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnNavEquipment.ForeColor = Color.White;
            btnNavEquipment.Location = new Point(13, 431);
            btnNavEquipment.Name = "btnNavEquipment";
            btnNavEquipment.Size = new Size(240, 46);
            btnNavEquipment.TabIndex = 8;
            btnNavEquipment.Text = "🏋️  Thiết Bị Phòng Tập";
            btnNavEquipment.TextAlign = ContentAlignment.MiddleLeft;
            btnNavEquipment.UseVisualStyleBackColor = false;
            btnNavEquipment.Click += btnNavEquipment_Click;
            // 
            // lblSidebarTitle
            // 
            lblSidebarTitle.Dock = DockStyle.Top;
            lblSidebarTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblSidebarTitle.ForeColor = Color.FromArgb(148, 163, 184);
            lblSidebarTitle.Location = new Point(0, 0);
            lblSidebarTitle.Name = "lblSidebarTitle";
            lblSidebarTitle.Padding = new Padding(15, 12, 0, 0);
            lblSidebarTitle.Size = new Size(270, 45);
            lblSidebarTitle.TabIndex = 0;
            lblSidebarTitle.Text = "DANH MỤC CHỨC NĂNG";
            // 
            // panelContent
            // 
            panelContent.BackColor = Color.FromArgb(241, 245, 249);
            panelContent.Controls.Add(flowCards);
            panelContent.Controls.Add(panelHero);
            panelContent.Controls.Add(statusStrip1);
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(270, 75);
            panelContent.Name = "panelContent";
            panelContent.Padding = new Padding(25, 20, 25, 10);
            panelContent.Size = new Size(1010, 655);
            panelContent.TabIndex = 2;
            // 
            // flowCards
            // 
            flowCards.AutoScroll = true;
            flowCards.Controls.Add(panelCard1);
            flowCards.Controls.Add(panelCard2);
            flowCards.Controls.Add(panelCard3);
            flowCards.Controls.Add(panelCard4);
            flowCards.Dock = DockStyle.Fill;
            flowCards.Location = new Point(25, 150);
            flowCards.Name = "flowCards";
            flowCards.Padding = new Padding(5);
            flowCards.Size = new Size(960, 469);
            flowCards.TabIndex = 2;
            // 
            // panelCard1
            // 
            panelCard1.BackColor = Color.White;
            panelCard1.BorderStyle = BorderStyle.FixedSingle;
            panelCard1.Controls.Add(btnCardAction1);
            panelCard1.Controls.Add(lblCard1Desc);
            panelCard1.Controls.Add(lblCard1Title);
            panelCard1.Controls.Add(lblCard1Icon);
            panelCard1.Controls.Add(panelCard1Accent);
            panelCard1.Location = new Point(15, 15);
            panelCard1.Margin = new Padding(10);
            panelCard1.Name = "panelCard1";
            panelCard1.Size = new Size(295, 215);
            panelCard1.TabIndex = 0;
            // 
            // btnCardAction1
            // 
            btnCardAction1.BackColor = Color.FromArgb(16, 185, 129);
            btnCardAction1.FlatAppearance.BorderSize = 0;
            btnCardAction1.FlatStyle = FlatStyle.Flat;
            btnCardAction1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCardAction1.ForeColor = Color.White;
            btnCardAction1.Location = new Point(15, 160);
            btnCardAction1.Name = "btnCardAction1";
            btnCardAction1.Size = new Size(265, 38);
            btnCardAction1.TabIndex = 4;
            btnCardAction1.Text = "Đăng Ký Gói Ngay →";
            btnCardAction1.UseVisualStyleBackColor = false;
            btnCardAction1.Click += btnCardAction1_Click;
            // 
            // lblCard1Desc
            // 
            lblCard1Desc.Font = new Font("Segoe UI", 9F);
            lblCard1Desc.ForeColor = Color.FromArgb(100, 116, 139);
            lblCard1Desc.Location = new Point(15, 95);
            lblCard1Desc.Name = "lblCard1Desc";
            lblCard1Desc.Size = new Size(265, 55);
            lblCard1Desc.TabIndex = 3;
            lblCard1Desc.Text = "Lựa chọn gói hội viên từ 1-12 tháng và khung giờ tập luyện phù hợp với thời gian của bạn.";
            // 
            // lblCard1Title
            // 
            lblCard1Title.AutoSize = true;
            lblCard1Title.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblCard1Title.ForeColor = Color.FromArgb(15, 23, 42);
            lblCard1Title.Location = new Point(15, 65);
            lblCard1Title.Name = "lblCard1Title";
            lblCard1Title.Size = new Size(168, 25);
            lblCard1Title.TabIndex = 2;
            lblCard1Title.Text = "Gói Tập && Giờ Tập";
            // 
            // lblCard1Icon
            // 
            lblCard1Icon.AutoSize = true;
            lblCard1Icon.Font = new Font("Segoe UI", 20F);
            lblCard1Icon.Location = new Point(12, 16);
            lblCard1Icon.Name = "lblCard1Icon";
            lblCard1Icon.Size = new Size(54, 46);
            lblCard1Icon.TabIndex = 1;
            lblCard1Icon.Text = "📦";
            // 
            // panelCard1Accent
            // 
            panelCard1Accent.BackColor = Color.FromArgb(16, 185, 129);
            panelCard1Accent.Dock = DockStyle.Top;
            panelCard1Accent.Location = new Point(0, 0);
            panelCard1Accent.Name = "panelCard1Accent";
            panelCard1Accent.Size = new Size(293, 6);
            panelCard1Accent.TabIndex = 0;
            // 
            // panelCard2
            // 
            panelCard2.BackColor = Color.White;
            panelCard2.BorderStyle = BorderStyle.FixedSingle;
            panelCard2.Controls.Add(btnCardAction2);
            panelCard2.Controls.Add(lblCard2Desc);
            panelCard2.Controls.Add(lblCard2Title);
            panelCard2.Controls.Add(lblCard2Icon);
            panelCard2.Controls.Add(panelCard2Accent);
            panelCard2.Location = new Point(330, 15);
            panelCard2.Margin = new Padding(10);
            panelCard2.Name = "panelCard2";
            panelCard2.Size = new Size(295, 215);
            panelCard2.TabIndex = 1;
            // 
            // btnCardAction2
            // 
            btnCardAction2.BackColor = Color.FromArgb(14, 165, 233);
            btnCardAction2.FlatAppearance.BorderSize = 0;
            btnCardAction2.FlatStyle = FlatStyle.Flat;
            btnCardAction2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCardAction2.ForeColor = Color.White;
            btnCardAction2.Location = new Point(15, 160);
            btnCardAction2.Name = "btnCardAction2";
            btnCardAction2.Size = new Size(265, 38);
            btnCardAction2.TabIndex = 4;
            btnCardAction2.Text = "Xem Danh Sách PT →";
            btnCardAction2.UseVisualStyleBackColor = false;
            btnCardAction2.Click += btnCardAction2_Click;
            // 
            // lblCard2Desc
            // 
            lblCard2Desc.Font = new Font("Segoe UI", 9F);
            lblCard2Desc.ForeColor = Color.FromArgb(100, 116, 139);
            lblCard2Desc.Location = new Point(15, 95);
            lblCard2Desc.Name = "lblCard2Desc";
            lblCard2Desc.Size = new Size(265, 55);
            lblCard2Desc.TabIndex = 3;
            lblCard2Desc.Text = "Đội ngũ huấn luyện viên chuyên nghiệp, tận tâm hướng dẫn lộ trình tập chuẩn khoa học.";
            // 
            // lblCard2Title
            // 
            lblCard2Title.AutoSize = true;
            lblCard2Title.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblCard2Title.ForeColor = Color.FromArgb(15, 23, 42);
            lblCard2Title.Location = new Point(15, 65);
            lblCard2Title.Name = "lblCard2Title";
            lblCard2Title.Size = new Size(207, 25);
            lblCard2Title.TabIndex = 2;
            lblCard2Title.Text = "Huấn Luyện Viên (PT)";
            // 
            // lblCard2Icon
            // 
            lblCard2Icon.AutoSize = true;
            lblCard2Icon.Font = new Font("Segoe UI", 20F);
            lblCard2Icon.Location = new Point(12, 16);
            lblCard2Icon.Name = "lblCard2Icon";
            lblCard2Icon.Size = new Size(54, 46);
            lblCard2Icon.TabIndex = 1;
            lblCard2Icon.Text = "🥋";
            // 
            // panelCard2Accent
            // 
            panelCard2Accent.BackColor = Color.FromArgb(14, 165, 233);
            panelCard2Accent.Dock = DockStyle.Top;
            panelCard2Accent.Location = new Point(0, 0);
            panelCard2Accent.Name = "panelCard2Accent";
            panelCard2Accent.Size = new Size(293, 6);
            panelCard2Accent.TabIndex = 0;
            // 
            // panelCard3
            // 
            panelCard3.BackColor = Color.White;
            panelCard3.BorderStyle = BorderStyle.FixedSingle;
            panelCard3.Controls.Add(btnCardAction3);
            panelCard3.Controls.Add(lblCard3Desc);
            panelCard3.Controls.Add(lblCard3Title);
            panelCard3.Controls.Add(lblCard3Icon);
            panelCard3.Controls.Add(panelCard3Accent);
            panelCard3.Location = new Point(645, 15);
            panelCard3.Margin = new Padding(10);
            panelCard3.Name = "panelCard3";
            panelCard3.Size = new Size(295, 215);
            panelCard3.TabIndex = 2;
            // 
            // btnCardAction3
            // 
            btnCardAction3.BackColor = Color.FromArgb(245, 158, 11);
            btnCardAction3.FlatAppearance.BorderSize = 0;
            btnCardAction3.FlatStyle = FlatStyle.Flat;
            btnCardAction3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCardAction3.ForeColor = Color.White;
            btnCardAction3.Location = new Point(15, 160);
            btnCardAction3.Name = "btnCardAction3";
            btnCardAction3.Size = new Size(265, 38);
            btnCardAction3.TabIndex = 4;
            btnCardAction3.Text = "Xem Thiết Bị Phòng →";
            btnCardAction3.UseVisualStyleBackColor = false;
            btnCardAction3.Click += btnCardAction3_Click;
            // 
            // lblCard3Desc
            // 
            lblCard3Desc.Font = new Font("Segoe UI", 9F);
            lblCard3Desc.ForeColor = Color.FromArgb(100, 116, 139);
            lblCard3Desc.Location = new Point(15, 95);
            lblCard3Desc.Name = "lblCard3Desc";
            lblCard3Desc.Size = new Size(265, 55);
            lblCard3Desc.TabIndex = 3;
            lblCard3Desc.Text = "Hệ thống máy móc, trang thiết bị tập luyện hiện đại theo từng nhóm cơ chuyên sâu.";
            // 
            // lblCard3Title
            // 
            lblCard3Title.AutoSize = true;
            lblCard3Title.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblCard3Title.ForeColor = Color.FromArgb(15, 23, 42);
            lblCard3Title.Location = new Point(15, 65);
            lblCard3Title.Name = "lblCard3Title";
            lblCard3Title.Size = new Size(183, 25);
            lblCard3Title.TabIndex = 2;
            lblCard3Title.Text = "Thiết Bị Phòng Tập";
            // 
            // lblCard3Icon
            // 
            lblCard3Icon.AutoSize = true;
            lblCard3Icon.Font = new Font("Segoe UI", 20F);
            lblCard3Icon.Location = new Point(12, 16);
            lblCard3Icon.Name = "lblCard3Icon";
            lblCard3Icon.Size = new Size(54, 46);
            lblCard3Icon.TabIndex = 1;
            lblCard3Icon.Text = "🏋️";
            // 
            // panelCard3Accent
            // 
            panelCard3Accent.BackColor = Color.FromArgb(245, 158, 11);
            panelCard3Accent.Dock = DockStyle.Top;
            panelCard3Accent.Location = new Point(0, 0);
            panelCard3Accent.Name = "panelCard3Accent";
            panelCard3Accent.Size = new Size(293, 6);
            panelCard3Accent.TabIndex = 0;
            // 
            // panelCard4
            // 
            panelCard4.BackColor = Color.White;
            panelCard4.BorderStyle = BorderStyle.FixedSingle;
            panelCard4.Controls.Add(btnCardAction4);
            panelCard4.Controls.Add(lblCard4Desc);
            panelCard4.Controls.Add(lblCard4Title);
            panelCard4.Controls.Add(lblCard4Icon);
            panelCard4.Controls.Add(panelCard4Accent);
            panelCard4.Location = new Point(15, 250);
            panelCard4.Margin = new Padding(10);
            panelCard4.Name = "panelCard4";
            panelCard4.Size = new Size(295, 215);
            panelCard4.TabIndex = 3;
            // 
            // btnCardAction4
            // 
            btnCardAction4.BackColor = Color.FromArgb(99, 102, 241);
            btnCardAction4.FlatAppearance.BorderSize = 0;
            btnCardAction4.FlatStyle = FlatStyle.Flat;
            btnCardAction4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCardAction4.ForeColor = Color.White;
            btnCardAction4.Location = new Point(15, 160);
            btnCardAction4.Name = "btnCardAction4";
            btnCardAction4.Size = new Size(265, 38);
            btnCardAction4.TabIndex = 4;
            btnCardAction4.Text = "Xem Hồ Sơ Chi Tiết →";
            btnCardAction4.UseVisualStyleBackColor = false;
            btnCardAction4.Click += btnCardAction4_Click;
            // 
            // lblCard4Desc
            // 
            lblCard4Desc.Font = new Font("Segoe UI", 9F);
            lblCard4Desc.ForeColor = Color.FromArgb(100, 116, 139);
            lblCard4Desc.Location = new Point(15, 95);
            lblCard4Desc.Name = "lblCard4Desc";
            lblCard4Desc.Size = new Size(265, 55);
            lblCard4Desc.TabIndex = 3;
            lblCard4Desc.Text = "Kiểm tra thông tin cá nhân, gói tập đã đăng ký và thời gian luyện tập của bạn.";
            // 
            // lblCard4Title
            // 
            lblCard4Title.AutoSize = true;
            lblCard4Title.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblCard4Title.ForeColor = Color.FromArgb(15, 23, 42);
            lblCard4Title.Location = new Point(15, 65);
            lblCard4Title.Name = "lblCard4Title";
            lblCard4Title.Size = new Size(139, 25);
            lblCard4Title.TabIndex = 2;
            lblCard4Title.Text = "Hồ Sơ Của Tôi";
            // 
            // lblCard4Icon
            // 
            lblCard4Icon.AutoSize = true;
            lblCard4Icon.Font = new Font("Segoe UI", 20F);
            lblCard4Icon.Location = new Point(12, 16);
            lblCard4Icon.Name = "lblCard4Icon";
            lblCard4Icon.Size = new Size(54, 46);
            lblCard4Icon.TabIndex = 1;
            lblCard4Icon.Text = "👤";
            // 
            // panelCard4Accent
            // 
            panelCard4Accent.BackColor = Color.FromArgb(99, 102, 241);
            panelCard4Accent.Dock = DockStyle.Top;
            panelCard4Accent.Location = new Point(0, 0);
            panelCard4Accent.Name = "panelCard4Accent";
            panelCard4Accent.Size = new Size(293, 6);
            panelCard4Accent.TabIndex = 0;
            // 
            // panelHero
            // 
            panelHero.BackColor = Color.FromArgb(30, 41, 59);
            panelHero.Controls.Add(lblHeroDesc);
            panelHero.Controls.Add(lblHeroTitle);
            panelHero.Dock = DockStyle.Top;
            panelHero.Location = new Point(25, 20);
            panelHero.Name = "panelHero";
            panelHero.Padding = new Padding(25, 20, 25, 20);
            panelHero.Size = new Size(960, 130);
            panelHero.TabIndex = 1;
            // 
            // lblHeroDesc
            // 
            lblHeroDesc.Dock = DockStyle.Fill;
            lblHeroDesc.Font = new Font("Segoe UI", 10.5F);
            lblHeroDesc.ForeColor = Color.FromArgb(203, 213, 225);
            lblHeroDesc.Location = new Point(25, 60);
            lblHeroDesc.Name = "lblHeroDesc";
            lblHeroDesc.Size = new Size(910, 50);
            lblHeroDesc.TabIndex = 1;
            lblHeroDesc.Text = "Chào mừng bạn đến với Hệ Thống Quản Lý Gym Anh Tú. Hãy chọn gói tập và khung giờ để bắt đầu!";
            // 
            // lblHeroTitle
            // 
            lblHeroTitle.Dock = DockStyle.Top;
            lblHeroTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblHeroTitle.ForeColor = Color.White;
            lblHeroTitle.Location = new Point(25, 20);
            lblHeroTitle.Name = "lblHeroTitle";
            lblHeroTitle.Size = new Size(910, 40);
            lblHeroTitle.TabIndex = 0;
            lblHeroTitle.Text = "Xin chào, Duy! 👋";
            // 
            // statusStrip1
            // 
            statusStrip1.BackColor = Color.FromArgb(15, 23, 42);
            statusStrip1.Font = new Font("Segoe UI", 9F);
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] {
            lblStatusRole,
            lblStatusServer,
            lblStatusTime});
            statusStrip1.Location = new Point(25, 619);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(960, 26);
            statusStrip1.TabIndex = 0;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblStatusRole
            // 
            lblStatusRole.ForeColor = Color.FromArgb(245, 158, 11);
            lblStatusRole.Name = "lblStatusRole";
            lblStatusRole.Size = new Size(130, 20);
            lblStatusRole.Text = "Vai trò: Hội viên";
            // 
            // lblStatusServer
            // 
            lblStatusServer.ForeColor = Color.FromArgb(148, 163, 184);
            lblStatusServer.Name = "lblStatusServer";
            lblStatusServer.Size = new Size(230, 20);
            lblStatusServer.Text = " |  Kết nối Backend: Đang hoạt động";
            // 
            // lblStatusTime
            // 
            lblStatusTime.ForeColor = Color.FromArgb(148, 163, 184);
            lblStatusTime.Name = "lblStatusTime";
            lblStatusTime.Size = new Size(585, 20);
            lblStatusTime.Spring = true;
            lblStatusTime.Text = "Thời gian: 10:30:00";
            lblStatusTime.TextAlign = ContentAlignment.MiddleRight;
            // 
            // clockTimer
            // 
            clockTimer.Enabled = true;
            clockTimer.Interval = 1000;
            clockTimer.Tick += clockTimer_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(241, 245, 249);
            ClientSize = new Size(1280, 730);
            Controls.Add(panelContent);
            Controls.Add(panelSidebar);
            Controls.Add(panelTopBar);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            MinimumSize = new Size(1000, 600);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hệ Thống Quản Lý Gym Anh Tú - Bảng Điều Khiển";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            panelTopBar.ResumeLayout(false);
            panelTopBar.PerformLayout();
            panelUserInfo.ResumeLayout(false);
            panelSidebar.ResumeLayout(false);
            panelSidebarButtons.ResumeLayout(false);
            panelContent.ResumeLayout(false);
            panelContent.PerformLayout();
            flowCards.ResumeLayout(false);
            panelCard1.ResumeLayout(false);
            panelCard1.PerformLayout();
            panelCard2.ResumeLayout(false);
            panelCard2.PerformLayout();
            panelCard3.ResumeLayout(false);
            panelCard3.PerformLayout();
            panelCard4.ResumeLayout(false);
            panelCard4.PerformLayout();
            panelHero.ResumeLayout(false);
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTopBar;
        private Label lblLogo;
        private Label lblSystemSubtitle;
        private Panel panelUserInfo;
        private Label lblXinChao;
        private Label lblRoleBadge;
        private Button btnTopLogout;
        private Button btnTopExit;
        private Panel panelSidebar;
        private Label lblSidebarTitle;
        private FlowLayoutPanel panelSidebarButtons;
        private Button btnNavRegisterPackage;
        private Button btnNavMyProfile;
        private Button btnNavNewMember;
        private Button btnNavSearchMember;
        private Button btnNavDeleteMember;
        private Button btnNavNewPT;
        private Button btnNavSearchPT;
        private Button btnNavDeletePT;
        private Button btnNavEquipment;
        private Panel panelContent;
        private Panel panelHero;
        private Label lblHeroTitle;
        private Label lblHeroDesc;
        private FlowLayoutPanel flowCards;
        private Panel panelCard1;
        private Panel panelCard1Accent;
        private Label lblCard1Icon;
        private Label lblCard1Title;
        private Label lblCard1Desc;
        private Button btnCardAction1;
        private Panel panelCard2;
        private Panel panelCard2Accent;
        private Label lblCard2Icon;
        private Label lblCard2Title;
        private Label lblCard2Desc;
        private Button btnCardAction2;
        private Panel panelCard3;
        private Panel panelCard3Accent;
        private Label lblCard3Icon;
        private Label lblCard3Title;
        private Label lblCard3Desc;
        private Button btnCardAction3;
        private Panel panelCard4;
        private Panel panelCard4Accent;
        private Label lblCard4Icon;
        private Label lblCard4Title;
        private Label lblCard4Desc;
        private Button btnCardAction4;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblStatusRole;
        private ToolStripStatusLabel lblStatusServer;
        private ToolStripStatusLabel lblStatusTime;
        private System.Windows.Forms.Timer clockTimer;
    }
}
