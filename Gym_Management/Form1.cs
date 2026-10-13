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

		Boolean b = true;
		private void toolStripMenuItem1_Click(object sender, EventArgs e)
		{
			try
			{
				if (b == true)
				{
					menuStrip1.Dock = DockStyle.Left;
					b = false;
					toolStripMenuItem1.Image = Image.FromFile(@"D:\Mẫu Thiết Kế Phần Mềm\Image\gym\gym icons and images\gym icons and images\Name-48-50px\img3.jpg");
				}
				else
				{
					menuStrip1.Dock = DockStyle.Top;
					b = true;
					toolStripMenuItem1.Image = Image.FromFile(@"D:\Mẫu Thiết Kế Phần Mềm\Image\gym\gym icons and images\gym icons and images\Name-48-50px\img2.jpg");
				}
			}
			catch
			{
				// Nếu không tìm thấy file ảnh thì vẫn đổi vị trí menu bình thường, không để chương trình bị lỗi.
				if (b == true)
				{
					menuStrip1.Dock = DockStyle.Left;
					b = false;
				}
				else
				{
					menuStrip1.Dock = DockStyle.Top;
					b = true;
				}
			}
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			try
			{
				toolStripMenuItem1.Image = Image.FromFile(@"D:\Mẫu Thiết Kế Phần Mềm\Image\gym\gym icons and images\gym icons and images\Name-48-50px\img2.jpg");
			}
			catch
			{
				// Không tìm thấy file ảnh thì bỏ qua, chương trình vẫn chạy bình thường.
			}
		}

		private void nEWMEMBERToolStripMenuItem_Click(object sender, EventArgs e)
		{
			NewMember nm = new NewMember();
			nm.Show();
		}

		private void nEWSTAFFToolStripMenuItem_Click(object sender, EventArgs e)
		{
			NewStaff ns = new NewStaff();
			ns.Show();
		}

		private void eQUIPMENTToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Equipment eq = new Equipment();
			eq.Show();
		}

		private void sEARCHMEMBERToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SearchMember sm = new SearchMember();
			sm.Show();
		}

		private void dELETEMEMBERToolStripMenuItem_Click(object sender, EventArgs e)
		{
			DeleteMember dm = new DeleteMember();
			dm.Show();
		}

		private void sEARCHSTAFFToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SearchStaff ss = new SearchStaff();
			ss.Show();
		}

		private void dELETESTAFFToolStripMenuItem_Click(object sender, EventArgs e)
		{
			DeleteStaff ds = new DeleteStaff();
			ds.Show();
		}

		private void lOGOUTToolStripMenuItem_Click(object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show("Bạn có chắc muốn đăng xuất không?",
				"Xác nhận đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (result == DialogResult.Yes)
			{
				IsLogout = true; // Đánh dấu là đăng xuất -> Program sẽ mở lại form Đăng nhập
				this.Close();
			}
		}

		private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show("Bạn có chắc muốn thoát chương trình không?",
				"Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (result == DialogResult.Yes)
			{
				IsLogout = false; // Thoát hẳn, không quay lại form Đăng nhập
				this.Close();
			}
		}
	}
}
