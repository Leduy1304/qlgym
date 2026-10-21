using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient; // thêm dòng này để kết nối sql

namespace Gym_Management
{
	public partial class DeletePT : Form
	{
		public DeletePT()
		{
			InitializeComponent();
		}

		// Tải toàn bộ PT lên lưới (để chọn / đối chiếu trước khi xóa)
		private void LoadAllPT()
		{
			try
			{
				using (SqlConnection con = new SqlConnection(DatabaseHelper.ConnectionString))
				{
					SqlDataAdapter DA = new SqlDataAdapter("SELECT * FROM NewPT", con);
					DataSet DS = new DataSet();
					DA.Fill(DS);
					dataGridView1.DataSource = DS.Tables[0];
					SetVietnameseHeaders();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Không tải được danh sách PT. Hãy kiểm tra SQL Server đã bật chưa.\n\nChi tiết lỗi: " + ex.Message,
					"Lỗi kết nối", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		// Đổi chữ hiển thị ở đầu cột sang tiếng Việt.
		// QUAN TRỌNG: Đây chỉ là đổi HeaderText (nhãn hiển thị trên màn hình),
		// tên cột thật trong database (PID, Fname, Lname...) và trong code vẫn giữ nguyên
		// nên nhập / tìm kiếm / xóa dữ liệu không bị ảnh hưởng gì.
		private void SetVietnameseHeaders()
		{
			if (dataGridView1.Columns.Contains("PID")) dataGridView1.Columns["PID"]!.HeaderText = "Mã PT";
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
				dataGridView1.Columns["JoinDate"]!.HeaderText = "Ngày vào làm";
				dataGridView1.Columns["JoinDate"]!.DefaultCellStyle.Format = "dd/MM/yyyy";
			}
			if (dataGridView1.Columns.Contains("Paddress")) dataGridView1.Columns["Paddress"]!.HeaderText = "Địa chỉ";
		}

		private void DeletePT_Load(object sender, EventArgs e)
		{
			LoadAllPT();
		}

		// Nhấn đúp vào 1 dòng trên lưới để tự điền mã PT lên ô nhập
		private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0 && dataGridView1.Columns.Contains("PID"))
			{
				object? value = dataGridView1.Rows[e.RowIndex].Cells["PID"].Value;
				if (value != null)
				{
					txtId.Text = value.ToString();
				}
			}
		}

		// Kiểm tra PT theo mã trước khi xóa: chỉ hiển thị đúng PT đó trên lưới
		private void btnSearch_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(txtId.Text))
			{
				LoadAllPT();
				return;
			}

			if (!int.TryParse(txtId.Text.Trim(), out int pid))
			{
				MessageBox.Show("Mã PT không hợp lệ. Vui lòng chỉ nhập số!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			try
			{
				using (SqlConnection con = new SqlConnection(DatabaseHelper.ConnectionString))
				{
					SqlCommand cmd = new SqlCommand("SELECT * FROM NewPT WHERE PID = @PID", con);
					cmd.Parameters.AddWithValue("@PID", pid);
					SqlDataAdapter DA = new SqlDataAdapter(cmd);
					DataSet DS = new DataSet();
					DA.Fill(DS);
					dataGridView1.DataSource = DS.Tables[0];
					SetVietnameseHeaders();

					if (DS.Tables[0].Rows.Count == 0)
					{
						MessageBox.Show("Không tìm thấy PT có mã " + pid + ".", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Không kiểm tra được PT.\n\nChi tiết lỗi: " + ex.Message,
					"Lỗi kết nối", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			// 1. Kiểm tra mã PT đã nhập và phải là số
			if (string.IsNullOrWhiteSpace(txtId.Text) || !int.TryParse(txtId.Text.Trim(), out int pid))
			{
				MessageBox.Show("Vui lòng nhập mã PT (PID) hợp lệ trước khi xóa!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			try
			{
				using (SqlConnection con = new SqlConnection(DatabaseHelper.ConnectionString))
				{
					con.Open();

					// 2. Kiểm tra PT có tồn tại không và lấy Họ Tên để hỏi xác nhận cho rõ ràng
					string? fullName = null;
					using (SqlCommand checkCmd = new SqlCommand("SELECT Fname, Lname FROM NewPT WHERE PID = @PID", con))
					{
						checkCmd.Parameters.AddWithValue("@PID", pid);
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
						MessageBox.Show("Không tìm thấy PT có mã " + pid + " để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
						return;
					}

					// 3. Hỏi xác nhận trước khi xóa (xóa rồi không khôi phục được)
					DialogResult result = MessageBox.Show(
						"Bạn có chắc muốn xóa PT \"" + fullName + "\" (Mã: " + pid + ") không?\nHành động này không thể hoàn tác!",
						"Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
					if (result != DialogResult.Yes)
					{
						return;
					}

					// 4. Thực hiện xóa
					using (SqlCommand cmd = new SqlCommand("DELETE FROM NewPT WHERE PID = @PID", con))
					{
						cmd.Parameters.AddWithValue("@PID", pid);
						int rows = cmd.ExecuteNonQuery();
						if (rows > 0)
						{
							MessageBox.Show("Xóa PT thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
							txtId.Clear();
						}
						else
						{
							MessageBox.Show("Không xóa được PT có mã " + pid + ".", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
						}
					}
				}
				LoadAllPT(); // Tải lại danh sách sau khi xóa
			}
			catch (Exception ex)
			{
				MessageBox.Show("Không xóa được PT.\n\nChi tiết lỗi: " + ex.Message,
					"Lỗi kết nối", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnReset_Click(object sender, EventArgs e)
		{
			txtId.Clear();
			LoadAllPT();
		}
	}
}
