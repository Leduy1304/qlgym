using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Gym_Management
{
	public partial class Equipment : Form
	{
		private bool _isViewingProposals = false;
		private int _selectedEID = 0;

		public Equipment()
		{
			InitializeComponent();
		}

		private bool LaAdmin => PhienDangNhap.VaiTro == "Admin";
		private bool LaHoiVienHoacPT => PhienDangNhap.VaiTro == "HoiVien" || PhienDangNhap.VaiTro == "PT";

		private void Equipment_Load(object sender, EventArgs e)
		{
			// Phân quyền theo vai trò người dùng (Requirement 3):
			// Hội viên và PT không có quyền thêm trực tiếp / xóa thiết bị.
			// Họ chỉ được phép ĐỀ XUẤT thiết bị mới, Admin là người có quyền phê duyệt.
			if (LaHoiVienHoacPT)
			{
				string tenVaiTro = PhienDangNhap.VaiTro == "PT" ? "Huấn luyện viên (PT)" : "Hội viên";
				label12.Text = "ĐỀ XUẤT THIẾT BỊ PHÒNG TẬP";
				lblRoleNotice.Text = $"💡 Bạn đang đăng nhập với vai trò {tenVaiTro}. Bạn có quyền gửi đề xuất thiết bị mới để Quản trị viên (Admin) xem xét phê duyệt.";
				lblRoleNotice.ForeColor = Color.FromArgb(74, 222, 128); // Green

				label6.Text = "Ngày đề xuất";
				btnSave.Text = "GỬI ĐỀ XUẤT";
				btnSave.BackColor = Color.FromArgb(16, 185, 129); // Emerald Green

				btnDelete.Visible = false;
				btnApproveProposal.Visible = false;
				btnRejectProposal.Visible = false;

				btnTabProposal.Text = "📋 Đề xuất của tôi";
			}
			else
			{
				label12.Text = "QUẢN LÝ THIẾT BỊ PHÒNG TẬP";
				lblRoleNotice.Text = "👑 Bạn đang đăng nhập với quyền Quản trị viên (Admin). Bạn có toàn quyền thêm, xóa thiết bị và phê duyệt đề xuất từ Hội viên / PT.";
				lblRoleNotice.ForeColor = Color.FromArgb(250, 204, 21); // Yellow

				label6.Text = "Ngày mua";
				btnSave.Text = "THÊM THIẾT BỊ";
				btnSave.BackColor = Color.FromArgb(59, 130, 246); // Blue

				btnDelete.Visible = true;
				btnTabProposal.Text = "📋 Đề xuất từ HV / PT";
			}

			// Mặc định tải danh sách thiết bị chính thức của phòng tập
			_isViewingProposals = false;
			CapNhatGiaoDienTab();
			LoadEquipment();
		}

		private void CapNhatGiaoDienTab()
		{
			if (!_isViewingProposals)
			{
				// Tab thiết bị phòng tập
				btnTabEquipment.BackColor = Color.FromArgb(59, 130, 246);
				btnTabProposal.BackColor = Color.FromArgb(71, 85, 105);
				label7.Text = "Danh sách thiết bị chính thức tại phòng gym";
				btnDelete.Visible = LaAdmin;
				btnUpdateEquip.Visible = LaAdmin;
				btnApproveProposal.Visible = false;
				btnRejectProposal.Visible = false;
			}
			else
			{
				// Tab danh sách đề xuất
				btnTabEquipment.BackColor = Color.FromArgb(71, 85, 105);
				btnTabProposal.BackColor = Color.FromArgb(59, 130, 246);
				label7.Text = LaAdmin ? "Danh sách đề xuất thiết bị từ Hội viên & PT" : "Danh sách đề xuất thiết bị của bạn";
				btnDelete.Visible = false;
				btnUpdateEquip.Visible = false;
				btnApproveProposal.Visible = LaAdmin;
				btnRejectProposal.Visible = LaAdmin;
			}
		}

		// Tải danh sách thiết bị chính thức
		private void LoadEquipment()
		{
			try
			{
				using (SqlConnection con = new SqlConnection(DatabaseHelper.ConnectionString))
				{
					SqlDataAdapter DA = new SqlDataAdapter("SELECT * FROM Equipment ORDER BY EID DESC", con);
					DataSet DS = new DataSet();
					DA.Fill(DS);
					dataGridView1.DataSource = DS.Tables[0];

					if (dataGridView1.Columns.Contains("EID")) dataGridView1.Columns["EID"]!.HeaderText = "Mã TB";
					if (dataGridView1.Columns.Contains("EquipName")) dataGridView1.Columns["EquipName"]!.HeaderText = "Tên thiết bị";
					if (dataGridView1.Columns.Contains("EDescription")) dataGridView1.Columns["EDescription"]!.HeaderText = "Mô tả";
					if (dataGridView1.Columns.Contains("MusclesUsed")) dataGridView1.Columns["MusclesUsed"]!.HeaderText = "Nhóm cơ";
					if (dataGridView1.Columns.Contains("Cost"))
					{
						dataGridView1.Columns["Cost"]!.HeaderText = "Giá tiền (VNĐ)";
						dataGridView1.Columns["Cost"]!.DefaultCellStyle.Format = "N0";
					}
					if (dataGridView1.Columns.Contains("Units")) dataGridView1.Columns["Units"]!.HeaderText = "Số lượng";
					if (dataGridView1.Columns.Contains("PurchaseDate"))
					{
						dataGridView1.Columns["PurchaseDate"]!.HeaderText = "Ngày mua";
						dataGridView1.Columns["PurchaseDate"]!.DefaultCellStyle.Format = "dd/MM/yyyy";
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Không tải được danh sách thiết bị.\n\nChi tiết lỗi: " + ex.Message,
					"Lỗi kết nối", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		// Tải danh sách đề xuất thiết bị (DeXuatThietBi)
		private void LoadProposals()
		{
			try
			{
				using (SqlConnection con = new SqlConnection(DatabaseHelper.ConnectionString))
				{
					string query;
					SqlCommand cmd = new SqlCommand();
					cmd.Connection = con;

					if (LaAdmin)
					{
						// Admin thấy toàn bộ đề xuất của mọi người
						query = "SELECT Id, EquipName, EDescription, MusclesUsed, Cost, Units, NguoiDeXuat, VaiTro, NgayDeXuat, TrangThai FROM DeXuatThietBi ORDER BY Id DESC";
					}
					else
					{
						// Hội viên / PT chỉ thấy đề xuất do chính họ gửi
						query = "SELECT Id, EquipName, EDescription, MusclesUsed, Cost, Units, NguoiDeXuat, VaiTro, NgayDeXuat, TrangThai FROM DeXuatThietBi WHERE NguoiDeXuat = @User ORDER BY Id DESC";
						cmd.Parameters.AddWithValue("@User", PhienDangNhap.TenDangNhap);
					}
					cmd.CommandText = query;

					SqlDataAdapter DA = new SqlDataAdapter(cmd);
					DataSet DS = new DataSet();
					DA.Fill(DS);
					dataGridView1.DataSource = DS.Tables[0];

					if (dataGridView1.Columns.Contains("Id")) dataGridView1.Columns["Id"]!.HeaderText = "Mã ĐX";
					if (dataGridView1.Columns.Contains("EquipName")) dataGridView1.Columns["EquipName"]!.HeaderText = "Tên thiết bị đề xuất";
					if (dataGridView1.Columns.Contains("EDescription")) dataGridView1.Columns["EDescription"]!.HeaderText = "Mô tả";
					if (dataGridView1.Columns.Contains("MusclesUsed")) dataGridView1.Columns["MusclesUsed"]!.HeaderText = "Nhóm cơ";
					if (dataGridView1.Columns.Contains("Cost"))
					{
						dataGridView1.Columns["Cost"]!.HeaderText = "Giá dự kiến (VNĐ)";
						dataGridView1.Columns["Cost"]!.DefaultCellStyle.Format = "N0";
					}
					if (dataGridView1.Columns.Contains("Units")) dataGridView1.Columns["Units"]!.HeaderText = "Số lượng";
					if (dataGridView1.Columns.Contains("NguoiDeXuat")) dataGridView1.Columns["NguoiDeXuat"]!.HeaderText = "Người đề xuất";
					if (dataGridView1.Columns.Contains("VaiTro")) dataGridView1.Columns["VaiTro"]!.HeaderText = "Vai trò";
					if (dataGridView1.Columns.Contains("NgayDeXuat"))
					{
						dataGridView1.Columns["NgayDeXuat"]!.HeaderText = "Ngày đề xuất";
						dataGridView1.Columns["NgayDeXuat"]!.DefaultCellStyle.Format = "dd/MM/yyyy";
					}
					if (dataGridView1.Columns.Contains("TrangThai"))
					{
						dataGridView1.Columns["TrangThai"]!.HeaderText = "Trạng thái";
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Không tải được danh sách đề xuất.\n\nChi tiết lỗi: " + ex.Message,
					"Lỗi kết nối", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnTabEquipment_Click(object sender, EventArgs e)
		{
			_isViewingProposals = false;
			CapNhatGiaoDienTab();
			LoadEquipment();
		}

		private void btnTabProposal_Click(object sender, EventArgs e)
		{
			_isViewingProposals = true;
			CapNhatGiaoDienTab();
			LoadProposals();
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			// 1. Kiểm tra rỗng
			if (string.IsNullOrWhiteSpace(txtEquipName.Text) ||
				string.IsNullOrWhiteSpace(txtMuscles.Text) ||
				string.IsNullOrWhiteSpace(txtCost.Text) ||
				string.IsNullOrWhiteSpace(txtUnits.Text))
			{
				MessageBox.Show("Vui lòng điền đầy đủ Tên thiết bị, Nhóm cơ, Giá tiền và Số lượng (riêng Mô tả có thể để trống)!",
					"Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			// 2. Kiểm tra giá tiền >= 0
			if (!decimal.TryParse(txtCost.Text.Trim(), out decimal cost) || cost < 0)
			{
				MessageBox.Show("Giá tiền không hợp lệ. Vui lòng chỉ nhập số (ví dụ: 15000000)!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txtCost.Focus();
				return;
			}

			// 3. Kiểm tra số lượng > 0
			if (!int.TryParse(txtUnits.Text.Trim(), out int units) || units <= 0)
			{
				MessageBox.Show("Số lượng không hợp lệ. Vui lòng nhập số nguyên lớn hơn 0!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txtUnits.Focus();
				return;
			}

			string equipName = txtEquipName.Text.Trim();
			string description = txtDescription.Text.Trim();
			string muscles = txtMuscles.Text.Trim();
			DateTime dateValue = dateTimePickerPurchase.Value.Date;

			try
			{
				using (SqlConnection con = new SqlConnection(DatabaseHelper.ConnectionString))
				{
					con.Open();

					// PHÂN QUYỀN:
					// Nếu là Hội viên hoặc PT: Chỉ gửi ĐỀ XUẤT vào bảng DeXuatThietBi
					if (LaHoiVienHoacPT)
					{
						string query = @"INSERT INTO DeXuatThietBi (EquipName, EDescription, MusclesUsed, Cost, Units, NguoiDeXuat, VaiTro, NgayDeXuat, TrangThai) 
										VALUES (@EquipName, @EDescription, @MusclesUsed, @Cost, @Units, @NguoiDeXuat, @VaiTro, @NgayDeXuat, N'Chờ duyệt')";
						using (SqlCommand cmd = new SqlCommand(query, con))
						{
							cmd.Parameters.AddWithValue("@EquipName", equipName);
							cmd.Parameters.AddWithValue("@EDescription", description);
							cmd.Parameters.AddWithValue("@MusclesUsed", muscles);
							cmd.Parameters.AddWithValue("@Cost", cost);
							cmd.Parameters.AddWithValue("@Units", units);
							cmd.Parameters.AddWithValue("@NguoiDeXuat", PhienDangNhap.TenDangNhap);
							cmd.Parameters.AddWithValue("@VaiTro", PhienDangNhap.VaiTro);
							cmd.Parameters.Add("@NgayDeXuat", SqlDbType.Date).Value = DateTime.Today;
							cmd.ExecuteNonQuery();
						}

						MessageBox.Show(
							$"Đã gửi đề xuất thiết bị \"{equipName}\" thành công!\n\n" +
							"Đề xuất của bạn đã được chuyển đến Quản trị viên (Admin) để xem xét và phê duyệt bổ sung vào phòng tập.",
							"Gửi đề xuất thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

						btnReset_Click(sender, e);
						_isViewingProposals = true;
						CapNhatGiaoDienTab();
						LoadProposals();
					}
					else
					{
						// Nếu là Admin: Thêm trực tiếp vào bảng Equipment chính thức
						string query = @"INSERT INTO Equipment (EquipName, EDescription, MusclesUsed, Cost, Units, PurchaseDate) 
										VALUES (@EquipName, @EDescription, @MusclesUsed, @Cost, @Units, @PurchaseDate)";
						using (SqlCommand cmd = new SqlCommand(query, con))
						{
							cmd.Parameters.AddWithValue("@EquipName", equipName);
							cmd.Parameters.AddWithValue("@EDescription", description);
							cmd.Parameters.AddWithValue("@MusclesUsed", muscles);
							cmd.Parameters.AddWithValue("@Cost", cost);
							cmd.Parameters.AddWithValue("@Units", units);
							cmd.Parameters.Add("@PurchaseDate", SqlDbType.Date).Value = dateValue;
							cmd.ExecuteNonQuery();
						}

						MessageBox.Show("Thêm thiết bị vào phòng tập thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
						btnReset_Click(sender, e);
						_isViewingProposals = false;
						CapNhatGiaoDienTab();
						LoadEquipment();
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi khi lưu dữ liệu: " + ex.Message, "Lỗi kết nối", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnReset_Click(object sender, EventArgs e)
		{
			_selectedEID = 0;
			txtEquipName.Clear();
			txtDescription.Clear();
			txtMuscles.Clear();
			txtCost.Clear();
			txtUnits.Clear();
			dateTimePickerPurchase.Value = DateTime.Now;
		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex < 0 || e.RowIndex >= dataGridView1.Rows.Count) return;
			var row = dataGridView1.Rows[e.RowIndex];

			if (!_isViewingProposals)
			{
				if (row.Cells["EID"].Value != null && int.TryParse(row.Cells["EID"].Value?.ToString(), out int eid))
				{
					_selectedEID = eid;
					txtEquipName.Text = row.Cells["EquipName"].Value?.ToString() ?? "";
					txtDescription.Text = row.Cells["EDescription"].Value?.ToString() ?? "";
					txtMuscles.Text = row.Cells["MusclesUsed"].Value?.ToString() ?? "";
					txtCost.Text = row.Cells["Cost"].Value?.ToString() ?? "";
					txtUnits.Text = row.Cells["Units"].Value?.ToString() ?? "";
					if (row.Cells["PurchaseDate"].Value != null && DateTime.TryParse(row.Cells["PurchaseDate"].Value?.ToString(), out DateTime pDate))
					{
						dateTimePickerPurchase.Value = pDate;
					}
				}
			}
			else
			{
				txtEquipName.Text = row.Cells["EquipName"].Value?.ToString() ?? "";
				txtDescription.Text = row.Cells["EDescription"].Value?.ToString() ?? "";
				txtMuscles.Text = row.Cells["MusclesUsed"].Value?.ToString() ?? "";
				txtCost.Text = row.Cells["Cost"].Value?.ToString() ?? "";
				txtUnits.Text = row.Cells["Units"].Value?.ToString() ?? "";
			}
		}

		private void btnUpdateEquip_Click(object sender, EventArgs e)
		{
			if (!LaAdmin)
			{
				MessageBox.Show("Chức năng chỉnh sửa thiết bị chỉ dành riêng cho Quản trị viên (Admin)!",
					"Từ chối quyền", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			if (_selectedEID <= 0)
			{
				MessageBox.Show("Vui lòng chọn 1 thiết bị từ danh sách bên dưới trước khi thực hiện cập nhật!",
					"Chưa chọn thiết bị", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			if (string.IsNullOrWhiteSpace(txtEquipName.Text) ||
				string.IsNullOrWhiteSpace(txtMuscles.Text) ||
				string.IsNullOrWhiteSpace(txtCost.Text) ||
				string.IsNullOrWhiteSpace(txtUnits.Text))
			{
				MessageBox.Show("Vui lòng điền đầy đủ Tên thiết bị, Nhóm cơ, Giá tiền và Số lượng!",
					"Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			if (!decimal.TryParse(txtCost.Text.Trim(), out decimal cost) || cost < 0)
			{
				MessageBox.Show("Giá tiền không hợp lệ. Vui lòng chỉ nhập số dương!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txtCost.Focus();
				return;
			}

			if (!int.TryParse(txtUnits.Text.Trim(), out int units) || units <= 0)
			{
				MessageBox.Show("Số lượng không hợp lệ. Vui lòng nhập số nguyên lớn hơn 0!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txtUnits.Focus();
				return;
			}

			string equipName = txtEquipName.Text.Trim();
			string description = txtDescription.Text.Trim();
			string muscles = txtMuscles.Text.Trim();
			DateTime purchaseDate = dateTimePickerPurchase.Value.Date;

			try
			{
				using (SqlConnection con = new SqlConnection(DatabaseHelper.ConnectionString))
				{
					con.Open();
					string sql = @"UPDATE Equipment 
								   SET EquipName = @EquipName, 
									   EDescription = @EDescription, 
									   MusclesUsed = @MusclesUsed, 
									   Cost = @Cost, 
									   Units = @Units, 
									   PurchaseDate = @PurchaseDate 
								   WHERE EID = @EID";
					using (SqlCommand cmd = new SqlCommand(sql, con))
					{
						cmd.Parameters.AddWithValue("@EquipName", equipName);
						cmd.Parameters.AddWithValue("@EDescription", description);
						cmd.Parameters.AddWithValue("@MusclesUsed", muscles);
						cmd.Parameters.AddWithValue("@Cost", cost);
						cmd.Parameters.AddWithValue("@Units", units);
						cmd.Parameters.Add("@PurchaseDate", SqlDbType.Date).Value = purchaseDate;
						cmd.Parameters.AddWithValue("@EID", _selectedEID);

						int rows = cmd.ExecuteNonQuery();
						if (rows > 0)
						{
							MessageBox.Show($"Cập nhật thành công thông tin thiết bị '{equipName}' (Mã: {_selectedEID}) vào cơ sở dữ liệu SQL Server!",
								"Cập nhật thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
							LoadEquipment();
						}
						else
						{
							MessageBox.Show("Không tìm thấy thiết bị để cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi khi cập nhật thiết bị:\n" + ex.Message, "Lỗi kết nối", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		// Xóa thiết bị chính thức (Chỉ Admin)
		private void btnDelete_Click(object sender, EventArgs e)
		{
			if (!LaAdmin)
			{
				MessageBox.Show("Bạn không có quyền xóa thiết bị phòng tập! Chức năng này chỉ dành cho Admin.",
					"Từ chối quyền", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			if (dataGridView1.CurrentRow == null || dataGridView1.CurrentRow.Cells["EID"].Value == null)
			{
				MessageBox.Show("Vui lòng chọn 1 thiết bị trên danh sách để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			int eid = Convert.ToInt32(dataGridView1.CurrentRow.Cells["EID"].Value);
			string equipName = Convert.ToString(dataGridView1.CurrentRow.Cells["EquipName"].Value) ?? "";

			DialogResult result = MessageBox.Show(
				$"Bạn có chắc muốn xóa thiết bị \"{equipName}\" (Mã: {eid}) không?",
				"Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (result != DialogResult.Yes)
			{
				return;
			}

			try
			{
				using (SqlConnection con = new SqlConnection(DatabaseHelper.ConnectionString))
				{
					using (SqlCommand cmd = new SqlCommand("DELETE FROM Equipment WHERE EID = @EID", con))
					{
						cmd.Parameters.AddWithValue("@EID", eid);
						con.Open();
						cmd.ExecuteNonQuery();
					}
				}
				MessageBox.Show("Xóa thiết bị thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				LoadEquipment();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Không xóa được thiết bị.\n\nChi tiết lỗi: " + ex.Message, "Lỗi kết nối", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		// Duyệt đề xuất thiết bị (Chỉ Admin) -> chuyển sang bảng Equipment chính thức
		private void btnApproveProposal_Click(object sender, EventArgs e)
		{
			if (!LaAdmin) return;

			if (dataGridView1.CurrentRow == null || !dataGridView1.Columns.Contains("Id"))
			{
				MessageBox.Show("Vui lòng chọn 1 đề xuất trong danh sách để duyệt!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			int proposalId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value);
			string equipName = Convert.ToString(dataGridView1.CurrentRow.Cells["EquipName"].Value) ?? "";
			string description = Convert.ToString(dataGridView1.CurrentRow.Cells["EDescription"].Value) ?? "";
			string muscles = Convert.ToString(dataGridView1.CurrentRow.Cells["MusclesUsed"].Value) ?? "";
			decimal cost = Convert.ToDecimal(dataGridView1.CurrentRow.Cells["Cost"].Value);
			int units = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Units"].Value);
			string trangThai = Convert.ToString(dataGridView1.CurrentRow.Cells["TrangThai"].Value) ?? "";

			if (trangThai == "Đã duyệt")
			{
				MessageBox.Show("Đề xuất này đã được phê duyệt trước đó!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}

			DialogResult result = MessageBox.Show(
				$"Bạn có chắc chắn muốn DUYỆT đề xuất \"{equipName}\" (Số lượng: {units}, Giá: {cost:N0} VNĐ) và đưa vào danh sách thiết bị chính thức của phòng gym không?",
				"Xác nhận phê duyệt đề xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (result != DialogResult.Yes) return;

			try
			{
				using (SqlConnection con = new SqlConnection(DatabaseHelper.ConnectionString))
				{
					con.Open();
					using (SqlTransaction trans = con.BeginTransaction())
					{
						try
						{
							// 1. Thêm vào bảng Equipment chính thức
							string sqlAdd = @"INSERT INTO Equipment (EquipName, EDescription, MusclesUsed, Cost, Units, PurchaseDate) 
											 VALUES (@EquipName, @EDescription, @MusclesUsed, @Cost, @Units, @PurchaseDate)";
							using (SqlCommand cmdAdd = new SqlCommand(sqlAdd, con, trans))
							{
								cmdAdd.Parameters.AddWithValue("@EquipName", equipName);
								cmdAdd.Parameters.AddWithValue("@EDescription", description);
								cmdAdd.Parameters.AddWithValue("@MusclesUsed", muscles);
								cmdAdd.Parameters.AddWithValue("@Cost", cost);
								cmdAdd.Parameters.AddWithValue("@Units", units);
								cmdAdd.Parameters.Add("@PurchaseDate", SqlDbType.Date).Value = DateTime.Today;
								cmdAdd.ExecuteNonQuery();
							}

							// 2. Cập nhật trạng thái đề xuất thành 'Đã duyệt'
							string sqlUpdate = "UPDATE DeXuatThietBi SET TrangThai = N'Đã duyệt' WHERE Id = @Id";
							using (SqlCommand cmdUpdate = new SqlCommand(sqlUpdate, con, trans))
							{
								cmdUpdate.Parameters.AddWithValue("@Id", proposalId);
								cmdUpdate.ExecuteNonQuery();
							}

							trans.Commit();
						}
						catch
						{
							trans.Rollback();
							throw;
						}
					}
				}

				MessageBox.Show(
					$"Đã phê duyệt thành công đề xuất \"{equipName}\"!\nThiết bị đã được bổ sung vào danh mục thiết bị chính thức của phòng tập.",
					"Phê duyệt thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

				LoadProposals();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi khi phê duyệt đề xuất: " + ex.Message, "Lỗi kết nối", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		// Từ chối đề xuất thiết bị (Chỉ Admin)
		private void btnRejectProposal_Click(object sender, EventArgs e)
		{
			if (!LaAdmin) return;

			if (dataGridView1.CurrentRow == null || !dataGridView1.Columns.Contains("Id"))
			{
				MessageBox.Show("Vui lòng chọn 1 đề xuất trong danh sách để từ chối!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			int proposalId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value);
			string equipName = Convert.ToString(dataGridView1.CurrentRow.Cells["EquipName"].Value) ?? "";
			string trangThai = Convert.ToString(dataGridView1.CurrentRow.Cells["TrangThai"].Value) ?? "";

			if (trangThai == "Từ chối")
			{
				MessageBox.Show("Đề xuất này đã bị từ chối trước đó!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}

			DialogResult result = MessageBox.Show(
				$"Bạn có chắc chắn muốn TỪ CHỐI đề xuất \"{equipName}\" không?",
				"Xác nhận từ chối", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (result != DialogResult.Yes) return;

			try
			{
				using (SqlConnection con = new SqlConnection(DatabaseHelper.ConnectionString))
				{
					con.Open();
					string sqlUpdate = "UPDATE DeXuatThietBi SET TrangThai = N'Từ chối' WHERE Id = @Id";
					using (SqlCommand cmdUpdate = new SqlCommand(sqlUpdate, con))
					{
						cmdUpdate.Parameters.AddWithValue("@Id", proposalId);
						cmdUpdate.ExecuteNonQuery();
					}
				}

				MessageBox.Show($"Đã từ chối đề xuất \"{equipName}\".", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				LoadProposals();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi khi từ chối đề xuất: " + ex.Message, "Lỗi kết nối", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
