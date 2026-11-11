using System;
using System.Drawing;
using System.Windows.Forms;

namespace Gym_Management
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		// Cờ cho biết người dùng vừa bấm LOG OUT (để Program quay lại form Đăng nhập)
		// hay bấm EXIT / đóng form (để Program thoát hẳn chương trình).
		public bool IsLogout { get; private set; } = false;

		private void Form1_Load(object sender, EventArgs e)
		{
			var vaiTro = PhienDangNhap.VaiTro;
			var tenDangNhap = string.IsNullOrEmpty(PhienDangNhap.TenDangNhap) ? "Khách" : PhienDangNhap.TenDangNhap;

			lblXinChao.Text = $"👤 {tenDangNhap}";
			lblHeroTitle.Text = $"Xin chào, {tenDangNhap}! 👋";
			lblStatusTime.Text = $"Thời gian: {DateTime.Now:dd/MM/yyyy HH:mm:ss}";

			// Trạng thái máy chủ
			if (PhienDangNhap.DaDangNhapQuaApi)
			{
				lblStatusServer.Text = $" |  Máy chủ API: Đã kết nối ({ApiClient.BaseUrl})";
				lblStatusServer.ForeColor = Color.FromArgb(74, 222, 128); // Green
			}
			else
			{
				lblStatusServer.Text = " |  Chế độ: SQL Server cục bộ (Chưa chạy Backend API)";
				lblStatusServer.ForeColor = Color.FromArgb(250, 204, 21); // Yellow
			}

			// PHÂN QUYỀN VAI TRÒ
			if (vaiTro == "Admin")
			{
				CauHinhGiaoDienAdmin();
			}
			else if (vaiTro == "PT")
			{
				CauHinhGiaoDienPT();
			}
			else
			{
				// Mặc định là Hội viên (HoiVien)
				CauHinhGiaoDienHoiVien();
			}
		}

		private void CauHinhGiaoDienAdmin()
		{
			lblRoleBadge.Text = "[ QUẢN TRỊ VIÊN ]";
			lblRoleBadge.BackColor = Color.FromArgb(220, 38, 38);
			lblStatusRole.Text = "Vai trò: Quản trị viên (Toàn quyền)";
			lblHeroDesc.Text = "Bạn đang đăng nhập với quyền Quản trị viên cao nhất. Bạn có toàn quyền thêm mới, tra cứu và quản lý Hội viên, Huấn luyện viên cũng như Thiết bị phòng tập.";

			// Admin thấy toàn bộ chức năng quản lý, bao gồm gán gói tập & giờ tập cho HV
			btnNavRegisterPackage.Visible = true;
			btnNavRegisterPackage.Text = "📦 Gói tập & Giờ tập HV";
			btnNavMyProfile.Visible = false;

			btnNavNewMember.Visible = true;
			btnNavSearchMember.Visible = true;
			btnNavDeleteMember.Visible = true;
			btnNavNewPT.Visible = true;
			btnNavSearchPT.Visible = true;
			btnNavDeletePT.Visible = true;
			btnNavEquipment.Visible = true;
			btnNavEquipment.Text = "🏋️ Quản lý thiết bị";

			// Cấu hình Cards cho Admin
			lblCard1Icon.Text = "👥";
			lblCard1Title.Text = "Quản Lý Hội Viên";
			lblCard1Desc.Text = "Thêm hội viên mới, tra cứu thông tin chi tiết hoặc xóa hồ sơ hội viên.";
			btnCardAction1.Text = "Tra Cứu Hội Viên →";
			btnCardAction1.BackColor = Color.FromArgb(59, 130, 246);
			panelCard1Accent.BackColor = Color.FromArgb(59, 130, 246);

			lblCard2Icon.Text = "🥋";
			lblCard2Title.Text = "Quản Lý HLV (PT)";
			lblCard2Desc.Text = "Thêm huấn luyện viên mới vào hệ thống, tra cứu danh sách hoặc xóa hồ sơ.";
			btnCardAction2.Text = "Quản Lý PT →";

			lblCard3Icon.Text = "🏋️";
			lblCard3Title.Text = "Trang Thiết Bị Gym";
			lblCard3Desc.Text = "Quản lý hệ thống máy móc, thiết bị theo từng nhóm cơ và giá thành.";
			btnCardAction3.Text = "Quản Lý Thiết Bị →";

			lblCard4Icon.Text = "➕";
			lblCard4Title.Text = "Thêm Hội Viên Nhanh";
			lblCard4Desc.Text = "Mở form thêm hội viên mới trực tiếp vào cơ sở dữ liệu.";
			btnCardAction4.Text = "Thêm Hội Viên Mới →";
		}

		private void CauHinhGiaoDienHoiVien()
		{
			lblRoleBadge.Text = "[ HỘI VIÊN ]";
			lblRoleBadge.BackColor = Color.FromArgb(16, 185, 129);
			lblStatusRole.Text = "Vai trò: Hội viên";
			lblHeroDesc.Text = "Chào mừng bạn đến với Hệ Thống Quản Lý Gym Anh Tú! Hãy chọn Gói tập và Khung giờ tập luyện để bắt đầu hành trình nâng cao sức khỏe ngay hôm nay.";

			// ẨN HOÀN TOÀN các nút quyền Admin: Hội viên tuyệt đối không thể thêm hay xóa người khác
			btnNavNewMember.Visible = false;
			btnNavDeleteMember.Visible = false;
			btnNavNewPT.Visible = false;
			btnNavDeletePT.Visible = false;

			// HIỆN các nút dành riêng cho Hội viên
			btnNavRegisterPackage.Visible = true;
			btnNavMyProfile.Visible = true;
			btnNavSearchPT.Visible = true;
			btnNavEquipment.Visible = true;
			btnNavEquipment.Text = "🏋️ Đề xuất thiết bị";

			// Cấu hình Cards cho Hội viên
			lblCard1Icon.Text = "📦";
			lblCard1Title.Text = "Gói Tập & Giờ Tập";
			lblCard1Desc.Text = "Lựa chọn các gói tập linh hoạt từ 1-12 tháng và khung giờ tập yêu thích.";
			btnCardAction1.Text = "Đăng Ký Gói Ngay →";
			btnCardAction1.BackColor = Color.FromArgb(16, 185, 129);
			panelCard1Accent.BackColor = Color.FromArgb(16, 185, 129);

			lblCard2Icon.Text = "🥋";
			lblCard2Title.Text = "Đội Ngũ HLV (PT)";
			lblCard2Desc.Text = "Xem danh sách các huấn luyện viên chuyên nghiệp để được hướng dẫn bài tập.";
			btnCardAction2.Text = "Xem Danh Sách PT →";

			lblCard3Icon.Text = "🏋️";
			lblCard3Title.Text = "Thiết Bị Phòng Tập";
			lblCard3Desc.Text = "Tham quan các máy móc hiện đại và trang thiết bị tập luyện đạt chuẩn.";
			btnCardAction3.Text = "Xem & Đề Xuất Thiết Bị →";

			lblCard4Icon.Text = "👤";
			lblCard4Title.Text = "Hồ Sơ Của Tôi";
			lblCard4Desc.Text = "Xem chi tiết thông tin cá nhân, gói tập hiện tại và thời gian luyện tập.";
			btnCardAction4.Text = "Xem Hồ Sơ Chi Tiết →";
		}

		private void CauHinhGiaoDienPT()
		{
			lblRoleBadge.Text = "[ HUẤN LUYỆN VIÊN ]";
			lblRoleBadge.BackColor = Color.FromArgb(14, 165, 233);
			lblStatusRole.Text = "Vai trò: Huấn luyện viên (PT)";
			lblHeroDesc.Text = "Chúc Huấn luyện viên một ngày làm việc hiệu quả, đồng hành và hỗ trợ hội viên đạt kết quả tốt nhất!";

			// PT có quyền thêm hội viên thủ công (kèm gói tập, giờ tập, PT phụ trách)
			btnNavNewMember.Visible = true;
			btnNavNewMember.Text = "➕ Thêm hội viên mới";
			btnNavDeleteMember.Visible = false;
			btnNavNewPT.Visible = false;
			btnNavDeletePT.Visible = false;
			btnNavRegisterPackage.Visible = true;
			btnNavRegisterPackage.Text = "📦 Gói tập cho Hội viên";
			btnNavMyProfile.Visible = false;

			btnNavSearchMember.Visible = true;
			btnNavSearchPT.Visible = true;
			btnNavEquipment.Visible = true;
			btnNavEquipment.Text = "🏋️ Đề xuất thiết bị";

			// Cấu hình Cards cho PT
			lblCard1Icon.Text = "👥";
			lblCard1Title.Text = "Danh Sách Hội Viên";
			lblCard1Desc.Text = "Tra cứu danh sách hội viên phòng gym để lên kế hoạch huấn luyện.";
			btnCardAction1.Text = "Tra Cứu Hội Viên →";
			btnCardAction1.BackColor = Color.FromArgb(14, 165, 233);
			panelCard1Accent.BackColor = Color.FromArgb(14, 165, 233);

			lblCard2Icon.Text = "🥋";
			lblCard2Title.Text = "Đội Ngũ Đồng Nghiệp";
			lblCard2Desc.Text = "Xem danh sách thông tin các huấn luyện viên trong hệ thống.";
			btnCardAction2.Text = "Danh Sách HLV →";

			lblCard3Icon.Text = "🏋️";
			lblCard3Title.Text = "Thiết Bị Tập Luyện";
			lblCard3Desc.Text = "Kiểm tra máy móc trang thiết bị hoặc gửi đề xuất thiết bị mới tới Quản trị viên.";
			btnCardAction3.Text = "Xem & Đề Xuất Thiết Bị →";

			lblCard4Icon.Text = "➕";
			lblCard4Title.Text = "Thêm Hội Viên Nhanh";
			lblCard4Desc.Text = "Thêm thủ công hội viên, chọn lịch tập, giờ tập và PT phụ trách.";
			btnCardAction4.Text = "Thêm Hội Viên →";
		}

		// PHƯƠNG THỨC MỞ CHỨC NĂNG CÓ KIỂM TRA PHÂN QUYỀN
		private void MoNewMember()
		{
			if (PhienDangNhap.VaiTro != "Admin" && PhienDangNhap.VaiTro != "PT")
			{
				MessageBox.Show("Bạn không có quyền thêm hội viên! Chức năng này dành cho Quản trị viên (Admin) và Huấn luyện viên (PT).",
					"Từ chối quyền truy cập", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			NewMember nm = new NewMember();
			nm.Show();
		}

		private void MoNewPT()
		{
			if (PhienDangNhap.VaiTro != "Admin")
			{
				MessageBox.Show("Bạn không có quyền thêm huấn luyện viên! Chức năng này chỉ dành riêng cho Quản trị viên (Admin).",
					"Từ chối quyền truy cập", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			NewPT pt = new NewPT();
			pt.Show();
		}

		private void MoDeleteMember()
		{
			if (PhienDangNhap.VaiTro != "Admin")
			{
				MessageBox.Show("Bạn không có quyền xóa hội viên! Chức năng này chỉ dành riêng cho Quản trị viên (Admin).",
					"Từ chối quyền truy cập", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			DeleteMember dm = new DeleteMember();
			dm.Show();
		}

		private void MoDeletePT()
		{
			if (PhienDangNhap.VaiTro != "Admin")
			{
				MessageBox.Show("Bạn không có quyền xóa huấn luyện viên! Chức năng này chỉ dành riêng cho Quản trị viên (Admin).",
					"Từ chối quyền truy cập", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			DeletePT dpt = new DeletePT();
			dpt.Show();
		}

		private void MoSearchMember()
		{
			SearchMember sm = new SearchMember();
			sm.Show();
		}

		private void MoSearchPT()
		{
			SearchPT spt = new SearchPT();
			spt.Show();
		}

		private void MoEquipment()
		{
			Equipment eq = new Equipment();
			eq.Show();
		}

		private void MoDangKyGoiTap()
		{
			using (var form = new DangKyGoiTapForm())
			{
				form.ShowDialog();
			}
		}

		private void MoHoSoHoiVien()
		{
			using (var form = new HoSoHoiVienForm())
			{
				form.ShowDialog();
			}
		}

		// SỰ KIỆN SIDEBAR BUTTONS
		private void btnNavRegisterPackage_Click(object sender, EventArgs e) => MoDangKyGoiTap();
		private void btnNavMyProfile_Click(object sender, EventArgs e) => MoHoSoHoiVien();
		private void btnNavNewMember_Click(object sender, EventArgs e) => MoNewMember();
		private void btnNavSearchMember_Click(object sender, EventArgs e) => MoSearchMember();
		private void btnNavDeleteMember_Click(object sender, EventArgs e) => MoDeleteMember();
		private void btnNavNewPT_Click(object sender, EventArgs e) => MoNewPT();
		private void btnNavSearchPT_Click(object sender, EventArgs e) => MoSearchPT();
		private void btnNavDeletePT_Click(object sender, EventArgs e) => MoDeletePT();
		private void btnNavEquipment_Click(object sender, EventArgs e) => MoEquipment();

		// SỰ KIỆN CARDS BUTTONS
		private void btnCardAction1_Click(object sender, EventArgs e)
		{
			if (PhienDangNhap.VaiTro == "Admin" || PhienDangNhap.VaiTro == "PT")
				MoSearchMember();
			else
				MoDangKyGoiTap();
		}

		private void btnCardAction2_Click(object sender, EventArgs e)
		{
			MoSearchPT();
		}

		private void btnCardAction3_Click(object sender, EventArgs e)
		{
			MoEquipment();
		}

		private void btnCardAction4_Click(object sender, EventArgs e)
		{
			if (PhienDangNhap.VaiTro == "Admin" || PhienDangNhap.VaiTro == "PT")
				MoNewMember();
			else
				MoHoSoHoiVien();
		}

		// SỰ KIỆN ĐĂNG XUẤT VÀ THOÁT
		private void btnTopLogout_Click(object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất khỏi hệ thống không?",
				"Xác nhận đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (result == DialogResult.Yes)
			{
				PhienDangNhap.Xoa();
				IsLogout = true;
				this.Close();
			}
		}

		private void btnTopExit_Click(object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát khỏi chương trình?",
				"Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (result == DialogResult.Yes)
			{
				IsLogout = false;
				this.Close();
			}
		}

		private void clockTimer_Tick(object sender, EventArgs e)
		{
			lblStatusTime.Text = $"Thời gian: {DateTime.Now:dd/MM/yyyy HH:mm:ss}";
		}
	}
}
