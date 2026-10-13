using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient; // thêm dòng này để kết nối sql

namespace Gym_Management
{
	public partial class DeleteMember : Form
	{
		public DeleteMember()
		{
			InitializeComponent();
		}

		// Tải toàn bộ hội viên lên lưới (để chọn / đối chiếu trước khi xóa)
		private void LoadAllMembers()
		{
			try
			{
				using (SqlConnection con = new SqlConnection(DatabaseHelper.ConnectionString))
				{
					SqlDataAdapter DA = new SqlDataAdapter("SELECT * FROM NewMember", con);
					DataSet DS = new DataSet();
					DA.Fill(DS);
					dataGridView1.DataSource = DS.Tables[0];
					SetVietnameseHeaders();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Không tải được danh sách hội viên. Hãy kiểm tra SQL Server đã bật chưa.\n\nChi tiết lỗi: " + ex.Message,
					"Lỗi kết nối", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}


		// Đổi chữ hiển thị ở đầu cột sang tiếng Việt.
		// QUAN TRỌNG: Đây chỉ là đổi HeaderText (nhãn hiển thị trên màn hình),
		// tên cột thật trong database (MID, Fname, Lname...) và trong code vẫn giữ nguyên
		// nên nhập / tìm kiếm / xóa dữ liệu không bị ảnh hưởng gì.
		private void SetVietnameseHeaders()
		{
			if (dataGridView1.Columns.Contains("MID")) dataGridView1.Columns["MID"]!.HeaderText = "Mã HV";
			if (dataGridView1.Columns.Contains("Fname")) dataGridView1.Columns["Fname"]!.HeaderText = "Họ";
			if (dataGridView1.Columns.Contains("Lname")) dataGridView1.Columns["Lname"]!.HeaderText = "Tên";
			if (dataGridView1.Columns.Contains("Gender")) dataGridView1.Columns["Gender"]!.HeaderText = "Giới tính";
			if (dataGridView1.Columns.Contains("Dob"))
			{
				dataGridView1.Columns["Dob"]!.HeaderText = "Ngày sinh";
				dataGridView1.Columns["Dob"]!.DefaultCellStyle.Format = "dd/MM/yyyy";
			}
			if (dataGridView1.Columns.Contains("Mobile")) dataGridView1.Columns["Mobile"]!.HeaderText = "SDT";
			if (dataGridView1.Columns.Contains("Email")) dataGridView1.Columns["Email"]!.HeaderText = "Email";
			if (dataGridView1.Columns.Contains("JoinDate"))
			{
				dataGridView1.Columns["JoinDate"]!.HeaderText = "Ngày đăng ký";
				dataGridView1.Columns["JoinDate"]!.DefaultCellStyle.Format = "dd/MM/yyyy";
			}
			if (dataGridView1.Columns.Contains("Gymtime")) dataGridView1.Columns["Gymtime"]!.HeaderText = "Giờ tập";
			if (dataGridView1.Columns.Contains("Maddress")) dataGridView1.Columns["Maddress"]!.HeaderText = "Địa chỉ";
			if (dataGridView1.Columns.Contains("MembershipTime")) dataGridView1.Columns["MembershipTime"]!.HeaderText = "Gói tập";
		}

		private void DeleteMember_Load(object sender, EventArgs e)
		{
			LoadAllMembers();
		}

		// Nhấn đúp vào 1 dòng trên lưới để tự điền mã hội viên lên ô nhập
		private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0 && dataGridView1.Columns.Contains("MID"))
			{
				object? value = dataGridView1.Rows[e.RowIndex].Cells["MID"].Value;
				if (value != null)
				{
					txtId.Text = value.ToString();
				}
			}
		}

		// Kiểm tra hội viên theo mã trước khi xóa: chỉ hiển thị đúng hội viên đó trên lưới
		private void btnSearch_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(txtId.Text))
			{
				LoadAllMembers();
				return;
			}

			if (!int.TryParse(txtId.Text.Trim(), out int mid))
			{
				MessageBox.Show("Mã hội viên không hợp lệ. Vui lòng chỉ nhập số!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			try
			{
				using (SqlConnection con = new SqlConnection(DatabaseHelper.ConnectionString))
				{
					SqlCommand cmd = new SqlCommand("SELECT * FROM NewMember WHERE MID = @MID", con);
					cmd.Parameters.AddWithValue("@MID", mid);
					SqlDataAdapter DA = new SqlDataAdapter(cmd);
					DataSet DS = new DataSet();
					DA.Fill(DS);
					dataGridView1.DataSource = DS.Tables[0];
					SetVietnameseHeaders();

					if (DS.Tables[0].Rows.Count == 0)
					{
						MessageBox.Show("Không tìm thấy hội viên có mã " + mid + ".", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Không kiểm tra được hội viên.\n\nChi tiết lỗi: " + ex.Message,
					"Lỗi kết nối", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			// 1. Kiểm tra mã hội viên đã nhập và phải là số
			if (string.IsNullOrWhiteSpace(txtId.Text) || !int.TryParse(txtId.Text.Trim(), out int mid))
			{
				MessageBox.Show("Vui lòng nhập mã hội viên (MID) hợp lệ trước khi xóa!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			try
			{
				using (SqlConnection con = new SqlConnection(DatabaseHelper.ConnectionString))
				{
					con.Open();

					// 2. Kiểm tra hội viên có tồn tại không và lấy Họ Tên để hỏi xác nhận cho rõ ràng
					string? fullName = null;
					using (SqlCommand checkCmd = new SqlCommand("SELECT Fname, Lname FROM NewMember WHERE MID = @MID", con))
					{
						checkCmd.Parameters.AddWithValue("@MID", mid);
						using (SqlDataReader reader = checkCmd.ExecuteReader())
						{
							if (reader.Read())
							{
								fullName = (reader["Fname"] + " " + reader["Lname"]).Trim();
							}
						}
					}

					if (fullName == null)
					{
						MessageBox.Show("Không tìm thấy hội viên có mã " + mid + " để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
						return;
					}

					// 3. Hỏi xác nhận trước khi xóa (xóa rồi không khôi phục được)
					DialogResult result = MessageBox.Show(
						"Bạn có chắc muốn xóa hội viên \"" + fullName + "\" (Mã: " + mid + ") không?\nHành động này không thể hoàn tác!",
						"Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
					if (result != DialogResult.Yes)
					{
						return;
					}

					// 4. Thực hiện xóa
					using (SqlCommand cmd = new SqlCommand("DELETE FROM NewMember WHERE MID = @MID", con))
					{
						cmd.Parameters.AddWithValue("@MID", mid);
						int rows = cmd.ExecuteNonQuery();
						if (rows > 0)
						{
							MessageBox.Show("Xóa hội viên thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
							txtId.Clear();
						}
						else
						{
							MessageBox.Show("Không xóa được hội viên có mã " + mid + ".", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
						}
					}
				}
				LoadAllMembers(); // Tải lại danh sách sau khi xóa
			}
			catch (Exception ex)
			{
				MessageBox.Show("Không xóa được hội viên.\n\nChi tiết lỗi: " + ex.Message,
					"Lỗi kết nối", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnReset_Click(object sender, EventArgs e)
		{
			txtId.Clear();
			LoadAllMembers();
		}
	}
}
