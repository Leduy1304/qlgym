using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient; // thêm dòng này để kết nối sql

namespace Gym_Management
{
	public partial class SearchPT : Form
	{
		public SearchPT()
		{
			InitializeComponent();
		}

		// Tải toàn bộ PT lên lưới và cập nhật dòng tổng số
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
					lblCount.Text = "Tổng số PT: " + DS.Tables[0].Rows.Count;
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

		private void SearchPT_Load(object sender, EventArgs e)
		{
			LoadAllPT();
		}

		private void btnSearch_Click(object sender, EventArgs e)
		{
			// Nếu để trống mã PT thì hiển thị lại toàn bộ danh sách
			if (string.IsNullOrWhiteSpace(txtSearchId.Text))
			{
				LoadAllPT();
				return;
			}

			// Mã PT (PID) bắt buộc phải là số
			if (!int.TryParse(txtSearchId.Text.Trim(), out int pid))
			{
				MessageBox.Show("Mã PT không hợp lệ. Vui lòng chỉ nhập số!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			try
			{
				using (SqlConnection con = new SqlConnection(DatabaseHelper.ConnectionString))
				{
					// Tìm đúng 1 PT theo PID, dùng tham số @PID để tránh lỗi SQL Injection
					SqlCommand cmd = new SqlCommand("SELECT * FROM NewPT WHERE PID = @PID", con);
					cmd.Parameters.AddWithValue("@PID", pid);
					SqlDataAdapter DA = new SqlDataAdapter(cmd);
					DataSet DS = new DataSet();
					DA.Fill(DS);
					dataGridView1.DataSource = DS.Tables[0];
					SetVietnameseHeaders();
					lblCount.Text = "Tổng số PT: " + DS.Tables[0].Rows.Count;

					if (DS.Tables[0].Rows.Count == 0)
					{
						MessageBox.Show("Không tìm thấy PT có mã " + pid + ".", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Không tìm kiếm được.\n\nChi tiết lỗi: " + ex.Message,
					"Lỗi kết nối", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnReset_Click(object sender, EventArgs e)
		{
			txtSearchId.Clear();
			LoadAllPT();
		}
	}
}
