using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient; // thêm dòng này để kết nối sql

namespace Gym_Management
{
	public partial class SearchStaff : Form
	{
		public SearchStaff()
		{
			InitializeComponent();
		}

		// Tải toàn bộ nhân viên lên lưới và cập nhật dòng tổng số
		private void LoadAllStaff()
		{
			try
			{
				using (SqlConnection con = new SqlConnection(DatabaseHelper.ConnectionString))
				{
					SqlDataAdapter DA = new SqlDataAdapter("SELECT * FROM NewStaff", con);
					DataSet DS = new DataSet();
					DA.Fill(DS);
					dataGridView1.DataSource = DS.Tables[0];
					SetVietnameseHeaders();
					lblCount.Text = "Tổng số nhân viên: " + DS.Tables[0].Rows.Count;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Không tải được danh sách nhân viên. Hãy kiểm tra SQL Server đã bật chưa.\n\nChi tiết lỗi: " + ex.Message,
					"Lỗi kết nối", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		// Đổi chữ hiển thị ở đầu cột sang tiếng Việt.
		// QUAN TRỌNG: Đây chỉ là đổi HeaderText (nhãn hiển thị trên màn hình),
		// tên cột thật trong database (SID, Fname, Lname...) và trong code vẫn giữ nguyên
		// nên nhập / tìm kiếm / xóa dữ liệu không bị ảnh hưởng gì.
		private void SetVietnameseHeaders()
		{
			if (dataGridView1.Columns.Contains("SID")) dataGridView1.Columns["SID"]!.HeaderText = "Mã NV";
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
			if (dataGridView1.Columns.Contains("Saddress")) dataGridView1.Columns["Saddress"]!.HeaderText = "Địa chỉ";
		}

		private void SearchStaff_Load(object sender, EventArgs e)
		{
			LoadAllStaff();
		}

		private void btnSearch_Click(object sender, EventArgs e)
		{
			// Nếu để trống mã nhân viên thì hiển thị lại toàn bộ danh sách
			if (string.IsNullOrWhiteSpace(txtSearchId.Text))
			{
				LoadAllStaff();
				return;
			}

			// Mã nhân viên (SID) bắt buộc phải là số
			if (!int.TryParse(txtSearchId.Text.Trim(), out int sid))
			{
				MessageBox.Show("Mã nhân viên không hợp lệ. Vui lòng chỉ nhập số!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			try
			{
				using (SqlConnection con = new SqlConnection(DatabaseHelper.ConnectionString))
				{
					// Tìm đúng 1 nhân viên theo SID, dùng tham số @SID để tránh lỗi SQL Injection
					SqlCommand cmd = new SqlCommand("SELECT * FROM NewStaff WHERE SID = @SID", con);
					cmd.Parameters.AddWithValue("@SID", sid);
					SqlDataAdapter DA = new SqlDataAdapter(cmd);
					DataSet DS = new DataSet();
					DA.Fill(DS);
					dataGridView1.DataSource = DS.Tables[0];
					SetVietnameseHeaders();
					lblCount.Text = "Tổng số nhân viên: " + DS.Tables[0].Rows.Count;

					if (DS.Tables[0].Rows.Count == 0)
					{
						MessageBox.Show("Không tìm thấy nhân viên có mã " + sid + ".", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
			LoadAllStaff();
		}
	}
}
