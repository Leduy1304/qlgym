using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Gym_Management
{
	public partial class SearchMember : Form
	{
		public SearchMember()
		{
			InitializeComponent();
		}

		private void SearchMember_Load(object sender, EventArgs e)
		{
			LoadPTDropdown();
			LoadAllMembers();
		}

		private void LoadPTDropdown()
		{
			cmbEditPT.Items.Clear();
			cmbEditPT.Items.Add("Không có PT (Tự tập)");

			try
			{
				using (SqlConnection con = new SqlConnection(DatabaseHelper.ConnectionString))
				{
					con.Open();
					string query = "SELECT PID, Fname, Lname FROM NewPT ORDER BY PID ASC";
					using (SqlCommand cmd = new SqlCommand(query, con))
					using (SqlDataReader reader = cmd.ExecuteReader())
					{
						while (reader.Read())
						{
							string fn = reader["Fname"]?.ToString() ?? "";
							string ln = reader["Lname"]?.ToString() ?? "";
							cmbEditPT.Items.Add($"{fn} {ln}".Trim());
						}
					}
				}
			}
			catch { }

			if (cmbEditPT.SelectedIndex == -1) cmbEditPT.SelectedIndex = 0;
		}

		// Tải toàn bộ hội viên lên lưới
		private void LoadAllMembers()
		{
			try
			{
				using (SqlConnection con = new SqlConnection(DatabaseHelper.ConnectionString))
				{
					string query = "SELECT MID, Fname, Lname, Gender, Dob, Mobile, Email, JoinDate, Gymtime, MembershipTime, AssignedPT, Maddress FROM NewMember ORDER BY MID DESC";
					SqlDataAdapter DA = new SqlDataAdapter(query, con);
					DataSet DS = new DataSet();
					DA.Fill(DS);
					dataGridView1.DataSource = DS.Tables[0];
					SetVietnameseHeaders();
					lblCount.Text = "Tổng số hội viên: " + DS.Tables[0].Rows.Count;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Không tải được danh sách hội viên. Hãy kiểm tra SQL Server đã bật chưa.\n\nChi tiết lỗi: " + ex.Message,
					"Lỗi kết nối", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

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
			if (dataGridView1.Columns.Contains("MembershipTime")) dataGridView1.Columns["MembershipTime"]!.HeaderText = "Gói tập";
			if (dataGridView1.Columns.Contains("AssignedPT")) dataGridView1.Columns["AssignedPT"]!.HeaderText = "HLV phụ trách";
			if (dataGridView1.Columns.Contains("Maddress")) dataGridView1.Columns["Maddress"]!.HeaderText = "Địa chỉ";
		}

		private void btnSearch_Click(object sender, EventArgs e)
		{
			string keyword = txtSearchId.Text.Trim();
			if (string.IsNullOrWhiteSpace(keyword))
			{
				LoadAllMembers();
				return;
			}

			try
			{
				using (SqlConnection con = new SqlConnection(DatabaseHelper.ConnectionString))
				{
					SqlCommand cmd = new SqlCommand();
					cmd.Connection = con;

					if (int.TryParse(keyword, out int mid))
					{
						cmd.CommandText = "SELECT MID, Fname, Lname, Gender, Dob, Mobile, Email, JoinDate, Gymtime, MembershipTime, AssignedPT, Maddress FROM NewMember WHERE MID = @MID";
						cmd.Parameters.AddWithValue("@MID", mid);
					}
					else
					{
						cmd.CommandText = @"SELECT MID, Fname, Lname, Gender, Dob, Mobile, Email, JoinDate, Gymtime, MembershipTime, AssignedPT, Maddress 
										   FROM NewMember 
										   WHERE Fname LIKE @Kw OR Lname LIKE @Kw OR Mobile LIKE @Kw OR Email LIKE @Kw";
						cmd.Parameters.AddWithValue("@Kw", "%" + keyword + "%");
					}

					SqlDataAdapter DA = new SqlDataAdapter(cmd);
					DataSet DS = new DataSet();
					DA.Fill(DS);
					dataGridView1.DataSource = DS.Tables[0];
					SetVietnameseHeaders();
					lblCount.Text = "Tổng số hội viên: " + DS.Tables[0].Rows.Count;

					if (DS.Tables[0].Rows.Count == 0)
					{
						MessageBox.Show("Không tìm thấy hội viên phù hợp với từ khóa: \"" + keyword + "\"", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
			LoadAllMembers();
		}

		// Nạp thông tin dòng đang chọn lên form chỉnh sửa
		private void NapThongTinDongDangChon()
		{
			if (dataGridView1.CurrentRow == null || dataGridView1.CurrentRow.Cells["MID"].Value == null)
				return;

			var row = dataGridView1.CurrentRow;
			txtEditMID.Text = row.Cells["MID"].Value?.ToString() ?? "";
			txtEditFname.Text = row.Cells["Fname"].Value?.ToString() ?? "";
			txtEditLname.Text = row.Cells["Lname"].Value?.ToString() ?? "";

			string gender = row.Cells["Gender"].Value?.ToString() ?? "Nam";
			cmbEditGender.SelectedItem = gender;

			if (row.Cells["Dob"].Value != null && DateTime.TryParse(row.Cells["Dob"].Value?.ToString(), out DateTime dob))
			{
				dtpEditDob.Value = dob;
			}

			txtEditMobile.Text = row.Cells["Mobile"].Value?.ToString() ?? "";
			txtEditEmail.Text = row.Cells["Email"].Value?.ToString() ?? "";
			txtEditAddress.Text = row.Cells["Maddress"].Value?.ToString() ?? "";

			// Gói tập
			string goi = row.Cells["MembershipTime"].Value?.ToString() ?? "";
			cmbEditMembership.SelectedIndex = -1;
			for (int i = 0; i < cmbEditMembership.Items.Count; i++)
			{
				string itemText = cmbEditMembership.Items[i]?.ToString() ?? "";
				if (!string.IsNullOrEmpty(goi) && (itemText.Contains(goi, StringComparison.OrdinalIgnoreCase) || goi.Contains(itemText, StringComparison.OrdinalIgnoreCase)))
				{
					cmbEditMembership.SelectedIndex = i;
					break;
				}
			}
			if (cmbEditMembership.SelectedIndex == -1 && cmbEditMembership.Items.Count > 0)
			{
				string goiClean = goi.ToLower().Replace(" ", "");
				for (int i = 0; i < cmbEditMembership.Items.Count; i++)
				{
					string itemClean = cmbEditMembership.Items[i]?.ToString()?.ToLower().Replace(" ", "") ?? "";
					if (goiClean.Contains("1thang") && itemClean.Contains("1thang") && !itemClean.Contains("12thang")) { cmbEditMembership.SelectedIndex = i; break; }
					if (goiClean.Contains("3thang") && itemClean.Contains("3thang")) { cmbEditMembership.SelectedIndex = i; break; }
					if (goiClean.Contains("6thang") && itemClean.Contains("6thang")) { cmbEditMembership.SelectedIndex = i; break; }
					if ((goiClean.Contains("12thang") || goiClean.Contains("1nam")) && itemClean.Contains("12thang")) { cmbEditMembership.SelectedIndex = i; break; }
				}
				if (cmbEditMembership.SelectedIndex == -1) cmbEditMembership.SelectedIndex = 0;
			}

			// Giờ tập
			string gio = row.Cells["Gymtime"].Value?.ToString() ?? "";
			cmbEditGymTime.SelectedIndex = -1;
			for (int i = 0; i < cmbEditGymTime.Items.Count; i++)
			{
				string itemText = cmbEditGymTime.Items[i]?.ToString() ?? "";
				if (!string.IsNullOrEmpty(gio) && (itemText.Contains(gio, StringComparison.OrdinalIgnoreCase) || gio.Contains(itemText, StringComparison.OrdinalIgnoreCase)))
				{
					cmbEditGymTime.SelectedIndex = i;
					break;
				}
			}
			if (cmbEditGymTime.SelectedIndex == -1 && cmbEditGymTime.Items.Count > 0)
			{
				string gioDigits = new string(gio.Where(char.IsDigit).Take(2).ToArray());
				if (!string.IsNullOrEmpty(gioDigits))
				{
					for (int i = 0; i < cmbEditGymTime.Items.Count; i++)
					{
						string it = cmbEditGymTime.Items[i]?.ToString() ?? "";
						if (it.StartsWith(gioDigits)) { cmbEditGymTime.SelectedIndex = i; break; }
					}
				}
				if (cmbEditGymTime.SelectedIndex == -1) cmbEditGymTime.SelectedIndex = 0;
			}

			// HLV phụ trách (PT)
			string pt = row.Cells["AssignedPT"].Value?.ToString() ?? "";
			cmbEditPT.SelectedIndex = 0;
			for (int i = 1; i < cmbEditPT.Items.Count; i++)
			{
				string itemText = cmbEditPT.Items[i]?.ToString() ?? "";
				if (!string.IsNullOrEmpty(pt) && (itemText.Contains(pt) || pt.Contains(itemText)))
				{
					cmbEditPT.SelectedIndex = i;
					break;
				}
			}
		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			NapThongTinDongDangChon();
		}

		private void dataGridView1_SelectionChanged(object sender, EventArgs e)
		{
			NapThongTinDongDangChon();
		}

		// Lưu thay đổi vào CSDL SQL Server (Requirement 3 & 6)
		private void btnUpdateMember_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(txtEditMID.Text) || !int.TryParse(txtEditMID.Text.Trim(), out int mid))
			{
				MessageBox.Show("Vui lòng chọn 1 hội viên trên bảng danh sách trước khi cập nhật!", "Chưa chọn hội viên", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			string fname = txtEditFname.Text.Trim();
			string lname = txtEditLname.Text.Trim();
			string mobile = txtEditMobile.Text.Trim();
			string email = txtEditEmail.Text.Trim();
			string address = txtEditAddress.Text.Trim();
			string gender = cmbEditGender.SelectedItem?.ToString() ?? "Nam";
			DateTime dob = dtpEditDob.Value.Date;
			string gymTime = cmbEditGymTime.SelectedItem?.ToString() ?? "";
			string membership = cmbEditMembership.SelectedItem?.ToString() ?? "";
			string assignedPT = cmbEditPT.SelectedIndex > 0 ? (cmbEditPT.SelectedItem?.ToString() ?? "") : "";

			if (string.IsNullOrWhiteSpace(fname))
			{
				MessageBox.Show("Vui lòng không để trống Họ của hội viên (không được chứa toàn khoảng trắng)!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txtEditFname.Focus();
				return;
			}

			if (string.IsNullOrWhiteSpace(lname))
			{
				MessageBox.Show("Vui lòng không để trống Tên của hội viên (không được chứa toàn khoảng trắng)!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txtEditLname.Focus();
				return;
			}

			if (string.IsNullOrWhiteSpace(mobile))
			{
				MessageBox.Show("Vui lòng không để trống Số điện thoại của hội viên (không được chứa toàn khoảng trắng)!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
				MessageBox.Show("Vui lòng không để trống Email của hội viên (không được chứa toàn khoảng trắng)!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txtEditEmail.Focus();
				return;
			}

			if (!email.Contains("@") || !email.Contains("."))
			{
				MessageBox.Show("Email không hợp lệ (phải chứa ký tự '@' và '.')!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txtEditEmail.Focus();
				return;
			}

			if (string.IsNullOrWhiteSpace(gymTime))
			{
				MessageBox.Show("Vui lòng chọn Khung giờ tập cho hội viên (không được để trống hoặc chỉ chứa khoảng trắng)!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				cmbEditGymTime.Focus();
				return;
			}

			if (string.IsNullOrWhiteSpace(membership))
			{
				MessageBox.Show("Vui lòng chọn Gói tập cho hội viên (không được để trống hoặc chỉ chứa khoảng trắng)!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				cmbEditMembership.Focus();
				return;
			}

			if (string.IsNullOrWhiteSpace(address))
			{
				MessageBox.Show("Vui lòng không để trống Địa chỉ của hội viên (không được chứa toàn khoảng trắng)!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txtEditAddress.Focus();
				return;
			}

			try
			{
				using (SqlConnection con = new SqlConnection(DatabaseHelper.ConnectionString))
				{
					con.Open();

					// Kiểm tra trùng SĐT và Email với hội viên khác hoặc PT khác
					string checkSql = @"
						SELECT 
							(SELECT COUNT(*) FROM NewMember WHERE Mobile = @Mobile AND MID != @MID) +
							(SELECT COUNT(*) FROM NewPT WHERE Mobile = @Mobile) AS TrungSDT,
							(SELECT COUNT(*) FROM NewMember WHERE LOWER(Email) = LOWER(@Email) AND MID != @MID) +
							(SELECT COUNT(*) FROM NewPT WHERE LOWER(Email) = LOWER(@Email)) AS TrungEmail";
					using (SqlCommand chkCmd = new SqlCommand(checkSql, con))
					{
						chkCmd.Parameters.AddWithValue("@Mobile", mobile);
						chkCmd.Parameters.AddWithValue("@Email", email);
						chkCmd.Parameters.AddWithValue("@MID", mid);
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
					string updateSql = @"UPDATE NewMember 
										SET Fname = @Fname, Lname = @Lname, Gender = @Gender, Dob = @Dob, 
											Mobile = @Mobile, Email = @Email, Gymtime = @Gymtime, 
											MembershipTime = @MembershipTime, AssignedPT = @AssignedPT, Maddress = @Maddress 
										WHERE MID = @MID";
					using (SqlCommand cmd = new SqlCommand(updateSql, con))
					{
						cmd.Parameters.AddWithValue("@Fname", fname);
						cmd.Parameters.AddWithValue("@Lname", lname);
						cmd.Parameters.AddWithValue("@Gender", gender);
						cmd.Parameters.Add("@Dob", SqlDbType.Date).Value = dob;
						cmd.Parameters.AddWithValue("@Mobile", mobile);
						cmd.Parameters.AddWithValue("@Email", email);
						cmd.Parameters.AddWithValue("@Gymtime", gymTime);
						cmd.Parameters.AddWithValue("@MembershipTime", membership);
						cmd.Parameters.AddWithValue("@AssignedPT", string.IsNullOrEmpty(assignedPT) ? (object)DBNull.Value : assignedPT);
						cmd.Parameters.AddWithValue("@Maddress", address);
						cmd.Parameters.AddWithValue("@MID", mid);

						int rows = cmd.ExecuteNonQuery();
						if (rows > 0)
						{
							MessageBox.Show(
								$"✅ CẬP NHẬT THÀNH CÔNG!\n\n" +
								$"• Mã hội viên (MID): {mid}\n" +
								$"• Họ tên: {fname} {lname}\n" +
								$"• Gói tập: {(string.IsNullOrEmpty(membership) ? "Chưa đăng ký" : membership)}\n" +
								$"• Giờ tập: {(string.IsNullOrEmpty(gymTime) ? "Chưa chọn" : gymTime)}\n" +
								$"• HLV phụ trách: {(string.IsNullOrEmpty(assignedPT) ? "Không có" : assignedPT)}\n\n" +
								"Dữ liệu đã được lưu trực tiếp vào cơ sở dữ liệu SQL Server (bảng NewMember).",
								"Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

							LoadAllMembers();
						}
						else
						{
							MessageBox.Show("Không tìm thấy hội viên có mã " + mid + " để cập nhật.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
			txtEditMID.Clear();
			txtEditFname.Clear();
			txtEditLname.Clear();
			cmbEditGender.SelectedIndex = 0;
			dtpEditDob.Value = new DateTime(2000, 1, 1);
			txtEditMobile.Clear();
			txtEditEmail.Clear();
			cmbEditGymTime.SelectedIndex = 0;
			cmbEditMembership.SelectedIndex = 0;
			cmbEditPT.SelectedIndex = 0;
			txtEditAddress.Clear();
		}

		// Mở nhanh form Đăng ký / Đổi gói tập cho hội viên được chọn
		private void btnDoiGoiTap_Click(object sender, EventArgs e)
		{
			int? selectedMid = null;
			if (!string.IsNullOrEmpty(txtEditMID.Text) && int.TryParse(txtEditMID.Text, out int mid))
			{
				selectedMid = mid;
			}
			else if (dataGridView1.CurrentRow != null && dataGridView1.CurrentRow.Cells["MID"].Value != null)
			{
				selectedMid = Convert.ToInt32(dataGridView1.CurrentRow.Cells["MID"].Value);
			}

			using (var form = new DangKyGoiTapForm(selectedMid))
			{
				if (form.ShowDialog() == DialogResult.OK)
				{
					LoadAllMembers();
				}
			}
		}
	}
}
