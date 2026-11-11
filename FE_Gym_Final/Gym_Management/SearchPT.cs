using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Gym_Management
{
	public partial class SearchPT : Form
	{
		public SearchPT()
		{
			InitializeComponent();
		}

		private bool LaAdmin => PhienDangNhap.VaiTro == "Admin";

		private void SearchPT_Load(object sender, EventArgs e)
		{
			// Phân quyền: Chỉ Admin mới có quyền thêm nhanh HLV và chỉnh sửa thông tin HLV
			btnQuickAddPT.Visible = LaAdmin;
			groupBoxEdit.Enabled = LaAdmin;
			if (!LaAdmin)
			{
				lblEditTip.Text = "🔒 Chỉ Quản trị viên (Admin) mới có quyền chỉnh sửa thông tin Huấn luyện viên.";
			}

			LoadAllPT();
		}

		// Tải toàn bộ PT lên lưới
		private void LoadAllPT()
		{
			try
			{
				using (SqlConnection con = new SqlConnection(DatabaseHelper.ConnectionString))
				{
					string query = "SELECT PID, Fname, Lname, Gender, Dob, Mobile, Email, JoinDate, Paddress FROM NewPT ORDER BY PID DESC";
					SqlDataAdapter DA = new SqlDataAdapter(query, con);
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

		private void btnSearch_Click(object sender, EventArgs e)
		{
			string keyword = txtSearchId.Text.Trim();
			if (string.IsNullOrWhiteSpace(keyword))
			{
				LoadAllPT();
				return;
			}

			try
			{
				using (SqlConnection con = new SqlConnection(DatabaseHelper.ConnectionString))
				{
					SqlCommand cmd = new SqlCommand();
					cmd.Connection = con;

					if (int.TryParse(keyword, out int pid))
					{
						cmd.CommandText = "SELECT PID, Fname, Lname, Gender, Dob, Mobile, Email, JoinDate, Paddress FROM NewPT WHERE PID = @PID";
						cmd.Parameters.AddWithValue("@PID", pid);
					}
					else
					{
						cmd.CommandText = @"SELECT PID, Fname, Lname, Gender, Dob, Mobile, Email, JoinDate, Paddress 
										   FROM NewPT 
										   WHERE Fname LIKE @Kw OR Lname LIKE @Kw OR Mobile LIKE @Kw OR Email LIKE @Kw";
						cmd.Parameters.AddWithValue("@Kw", "%" + keyword + "%");
					}

					SqlDataAdapter DA = new SqlDataAdapter(cmd);
					DataSet DS = new DataSet();
					DA.Fill(DS);
					dataGridView1.DataSource = DS.Tables[0];
					SetVietnameseHeaders();
					lblCount.Text = "Tổng số PT: " + DS.Tables[0].Rows.Count;

					if (DS.Tables[0].Rows.Count == 0)
					{
						MessageBox.Show("Không tìm thấy PT phù hợp với từ khóa: \"" + keyword + "\"", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi khi tìm kiếm: " + ex.Message, "Lỗi kết nối", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnReset_Click(object sender, EventArgs e)
		{
			txtSearchId.Clear();
			LoadAllPT();
		}

		// Nạp thông tin dòng đang chọn lên form chỉnh sửa
		private void NapThongTinDongDangChon()
		{
			if (dataGridView1.CurrentRow == null || dataGridView1.CurrentRow.Cells["PID"].Value == null)
				return;

			var row = dataGridView1.CurrentRow;
			txtEditPID.Text = row.Cells["PID"].Value?.ToString() ?? "";
			txtEditFname.Text = row.Cells["Fname"].Value?.ToString() ?? "";
			txtEditLname.Text = row.Cells["Lname"].Value?.ToString() ?? "";

			string gender = row.Cells["Gender"].Value?.ToString() ?? "Nam";
			cmbEditGender.SelectedItem = gender;

			if (row.Cells["Dob"].Value != null && DateTime.TryParse(row.Cells["Dob"].Value?.ToString(), out DateTime dob))
			{
				dtpEditDob.Value = dob;
			}

			if (row.Cells["JoinDate"].Value != null && DateTime.TryParse(row.Cells["JoinDate"].Value?.ToString(), out DateTime joinDate))
			{
				dtpEditJoinDate.Value = joinDate;
			}

			txtEditMobile.Text = row.Cells["Mobile"].Value?.ToString() ?? "";
			txtEditEmail.Text = row.Cells["Email"].Value?.ToString() ?? "";
			txtEditAddress.Text = row.Cells["Paddress"].Value?.ToString() ?? "";
		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			NapThongTinDongDangChon();
		}

		private void dataGridView1_SelectionChanged(object sender, EventArgs e)
		{
			NapThongTinDongDangChon();
		}

		// Thêm nhanh HLV (Requirement 2)
		private void btnQuickAddPT_Click(object sender, EventArgs e)
		{
			using (var form = new NewPT())
			{
				form.ShowDialog();
				LoadAllPT();
			}
		}

		// Lưu thay đổi vào CSDL SQL Server (Requirement 3 & 6)
		private void btnUpdatePT_Click(object sender, EventArgs e)
		{
			if (!LaAdmin)
			{
				MessageBox.Show("Bạn không có quyền chỉnh sửa thông tin Huấn luyện viên! Quyền này chỉ dành cho Admin.",
					"Từ chối quyền", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			if (string.IsNullOrWhiteSpace(txtEditPID.Text) || !int.TryParse(txtEditPID.Text.Trim(), out int pid))
			{
				MessageBox.Show("Vui lòng chọn 1 HLV trên bảng danh sách trước khi cập nhật!", "Chưa chọn HLV", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			string fname = txtEditFname.Text.Trim();
			string lname = txtEditLname.Text.Trim();
			string mobile = txtEditMobile.Text.Trim();
			string email = txtEditEmail.Text.Trim();
			string address = txtEditAddress.Text.Trim();
			string gender = cmbEditGender.SelectedItem?.ToString() ?? "Nam";
			DateTime dob = dtpEditDob.Value.Date;
			DateTime joinDate = dtpEditJoinDate.Value.Date;

			if (string.IsNullOrWhiteSpace(fname))
			{
				MessageBox.Show("Vui lòng không để trống Họ của HLV (không được chứa toàn khoảng trắng)!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txtEditFname.Focus();
				return;
			}

			if (string.IsNullOrWhiteSpace(lname))
			{
				MessageBox.Show("Vui lòng không để trống Tên của HLV (không được chứa toàn khoảng trắng)!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txtEditLname.Focus();
				return;
			}

			if (string.IsNullOrWhiteSpace(mobile))
			{
				MessageBox.Show("Vui lòng không để trống Số điện thoại của HLV (không được chứa toàn khoảng trắng)!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txtEditMobile.Focus();
				return;
			}

			if (mobile.Length != 10 || mobile[0] != '0' || !mobile.All(char.IsDigit))
			{
				MessageBox.Show("Số điện thoại phải gồm đúng 10 số và bắt đầu bằng số 0!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txtEditMobile.Focus();
				return;
			}

			if (string.IsNullOrWhiteSpace(email))
			{
				MessageBox.Show("Vui lòng không để trống Email của HLV (không được chứa toàn khoảng trắng)!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txtEditEmail.Focus();
				return;
			}

			if (!email.Contains("@") || !email.Contains("."))
			{
				MessageBox.Show("Email không hợp lệ (phải chứa ký tự '@' và '.')!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txtEditEmail.Focus();
				return;
			}

			if (string.IsNullOrWhiteSpace(address))
			{
				MessageBox.Show("Vui lòng không để trống Địa chỉ của HLV (không được chứa toàn khoảng trắng)!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txtEditAddress.Focus();
				return;
			}

			try
			{
				using (SqlConnection con = new SqlConnection(DatabaseHelper.ConnectionString))
				{
					con.Open();

					// Kiểm tra trùng SĐT và Email với PT khác hoặc hội viên khác
					string checkSql = @"
						SELECT 
							(SELECT COUNT(*) FROM NewPT WHERE Mobile = @Mobile AND PID != @PID) +
							(SELECT COUNT(*) FROM NewMember WHERE Mobile = @Mobile) AS TrungSDT,
							(SELECT COUNT(*) FROM NewPT WHERE LOWER(Email) = LOWER(@Email) AND PID != @PID) +
							(SELECT COUNT(*) FROM NewMember WHERE LOWER(Email) = LOWER(@Email)) AS TrungEmail";
					using (SqlCommand chkCmd = new SqlCommand(checkSql, con))
					{
						chkCmd.Parameters.AddWithValue("@Mobile", mobile);
						chkCmd.Parameters.AddWithValue("@Email", email);
						chkCmd.Parameters.AddWithValue("@PID", pid);
						using (SqlDataReader r = chkCmd.ExecuteReader())
						{
							if (r.Read())
							{
								if (Convert.ToInt32(r["TrungSDT"]) > 0)
								{
									MessageBox.Show($"Số điện thoại '{mobile}' đã bị trùng với một tài khoản khác trong hệ thống!", "Trùng SĐT", MessageBoxButtons.OK, MessageBoxIcon.Warning);
									txtEditMobile.Focus();
									return;
								}
								if (!string.IsNullOrWhiteSpace(email) && Convert.ToInt32(r["TrungEmail"]) > 0)
								{
									MessageBox.Show($"Email '{email}' đã bị trùng với một tài khoản khác trong hệ thống!", "Trùng Email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
									txtEditEmail.Focus();
									return;
								}
							}
						}
					}

					// Cập nhật vào CSDL SQL Server
					string updateSql = @"UPDATE NewPT 
										SET Fname = @Fname, Lname = @Lname, Gender = @Gender, Dob = @Dob, 
											Mobile = @Mobile, Email = @Email, JoinDate = @JoinDate, Paddress = @Paddress 
										WHERE PID = @PID";
					using (SqlCommand cmd = new SqlCommand(updateSql, con))
					{
						cmd.Parameters.AddWithValue("@Fname", fname);
						cmd.Parameters.AddWithValue("@Lname", lname);
						cmd.Parameters.AddWithValue("@Gender", gender);
						cmd.Parameters.Add("@Dob", SqlDbType.Date).Value = dob;
						cmd.Parameters.AddWithValue("@Mobile", mobile);
						cmd.Parameters.AddWithValue("@Email", email);
						cmd.Parameters.Add("@JoinDate", SqlDbType.Date).Value = joinDate;
						cmd.Parameters.AddWithValue("@Paddress", address);
						cmd.Parameters.AddWithValue("@PID", pid);

						int rows = cmd.ExecuteNonQuery();
						if (rows > 0)
						{
							MessageBox.Show(
								$"✅ CẬP NHẬT THÀNH CÔNG!\n\n" +
								$"• Mã Huấn luyện viên (PID): {pid}\n" +
								$"• Họ tên: {fname} {lname}\n" +
								$"• SĐT: {mobile}\n" +
								$"• Email: {email}\n\n" +
								"Dữ liệu đã được lưu trực tiếp vào cơ sở dữ liệu SQL Server (bảng NewPT).",
								"Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

							LoadAllPT();
						}
						else
						{
							MessageBox.Show("Không tìm thấy HLV có mã " + pid + " để cập nhật.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi khi cập nhật vào CSDL: " + ex.Message, "Lỗi kết nối", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnClearEdit_Click(object sender, EventArgs e)
		{
			txtEditPID.Clear();
			txtEditFname.Clear();
			txtEditLname.Clear();
			cmbEditGender.SelectedIndex = 0;
			dtpEditDob.Value = new DateTime(1995, 1, 1);
			dtpEditJoinDate.Value = DateTime.Now;
			txtEditMobile.Clear();
			txtEditEmail.Clear();
			txtEditAddress.Clear();
		}
	}
}
