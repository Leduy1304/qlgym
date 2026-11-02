using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient; // thêm dòng này để kết nối sql

namespace Gym_Management
{
	public partial class Equipment : Form
	{
		public Equipment()
		{
			InitializeComponent();
		}

		// Tải toàn bộ danh sách thiết bị lên lưới (dùng khi mở form và sau khi LƯU / XÓA)
		private void LoadEquipment()
		{
			try
			{
				using (SqlConnection con = new SqlConnection(DatabaseHelper.ConnectionString))
				{
					SqlDataAdapter DA = new SqlDataAdapter("SELECT * FROM Equipment", con);
					DataSet DS = new DataSet();
					DA.Fill(DS);
					dataGridView1.DataSource = DS.Tables[0];
					// Đổi tiêu đề cột sang tiếng Việt cho dễ nhìn (tên cột gốc trong code vẫn giữ nguyên)
					if (dataGridView1.Columns.Contains("EID")) dataGridView1.Columns["EID"]!.HeaderText = "Mã";
					if (dataGridView1.Columns.Contains("EquipName")) dataGridView1.Columns["EquipName"]!.HeaderText = "Tên thiết bị";
					if (dataGridView1.Columns.Contains("EDescription")) dataGridView1.Columns["EDescription"]!.HeaderText = "Mô tả";
					if (dataGridView1.Columns.Contains("MusclesUsed")) dataGridView1.Columns["MusclesUsed"]!.HeaderText = "Nhóm cơ";
					if (dataGridView1.Columns.Contains("Cost"))
					{
						dataGridView1.Columns["Cost"]!.HeaderText = "Giá tiền";
						dataGridView1.Columns["Cost"]!.DefaultCellStyle.Format = "N0"; // Hiện giá có dấu phân cách nghìn: 25,000,000
					}
					if (dataGridView1.Columns.Contains("Units")) dataGridView1.Columns["Units"]!.HeaderText = "Số lượng";
					if (dataGridView1.Columns.Contains("PurchaseDate")) dataGridView1.Columns["PurchaseDate"]!.HeaderText = "Ngày mua";
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Không tải được danh sách thiết bị. Hãy kiểm tra bảng Equipment đã được tạo chưa (chạy file gym_database.sql) và SQL Server đã bật chưa.\n\nChi tiết lỗi: " + ex.Message,
					"Lỗi kết nối", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void Equipment_Load(object sender, EventArgs e)
		{
			LoadEquipment();
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			// 1. Kiểm tra rỗng
			if (string.IsNullOrWhiteSpace(txtEquipName.Text) ||
				string.IsNullOrWhiteSpace(txtMuscles.Text) ||
				string.IsNullOrWhiteSpace(txtCost.Text) ||
				string.IsNullOrWhiteSpace(txtUnits.Text))
			{
				MessageBox.Show("Vui lòng không để trống thông tin. Hãy điền đầy đủ (riêng Mô tả có thể để trống)!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			// 2. Kiểm tra giá tiền phải là số >= 0
			if (!decimal.TryParse(txtCost.Text.Trim(), out decimal cost) || cost < 0)
			{
				MessageBox.Show("Giá tiền không hợp lệ. Vui lòng chỉ nhập số (ví dụ: 15000000)!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			// 3. Kiểm tra số lượng phải là số nguyên > 0
			if (!int.TryParse(txtUnits.Text.Trim(), out int units) || units <= 0)
			{
				MessageBox.Show("Số lượng không hợp lệ. Vui lòng nhập số nguyên lớn hơn 0!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			// --- Bắt đầu lấy dữ liệu sau khi đã kiểm tra an toàn ---
			string equipName = txtEquipName.Text.Trim(); // Tên thiết bị
			string description = txtDescription.Text.Trim(); // Mô tả
			string muscles = txtMuscles.Text.Trim(); // Nhóm cơ sử dụng
			DateTime purchaseDate = dateTimePickerPurchase.Value.Date; // Ngày mua

			try
			{
				using (SqlConnection con = new SqlConnection(DatabaseHelper.ConnectionString))
				{
					string query = "INSERT INTO Equipment (EquipName, EDescription, MusclesUsed, Cost, Units, PurchaseDate) " +
								   "VALUES (@EquipName, @EDescription, @MusclesUsed, @Cost, @Units, @PurchaseDate)";
					using (SqlCommand cmd = new SqlCommand(query, con))
					{
						cmd.Parameters.AddWithValue("@EquipName", equipName);
						cmd.Parameters.AddWithValue("@EDescription", description);
						cmd.Parameters.AddWithValue("@MusclesUsed", muscles);
						cmd.Parameters.AddWithValue("@Cost", cost);
						cmd.Parameters.AddWithValue("@Units", units);
						cmd.Parameters.Add("@PurchaseDate", SqlDbType.Date).Value = purchaseDate;

						con.Open();
						cmd.ExecuteNonQuery();
					}
				}
				MessageBox.Show("Lưu thiết bị thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				LoadEquipment(); // Tải lại lưới để thấy thiết bị vừa thêm
			}
			catch (Exception ex)
			{
				MessageBox.Show("Không lưu được vào database.\n\nChi tiết lỗi: " + ex.Message,
					"Lỗi kết nối", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnReset_Click(object sender, EventArgs e)
		{
			txtEquipName.Clear();
			txtDescription.Clear();
			txtMuscles.Clear();
			txtCost.Clear();
			txtUnits.Clear();
			dateTimePickerPurchase.Value = DateTime.Now;
			MessageBox.Show("Reset thành công.");
		}

		// Xóa thiết bị đang được chọn trên lưới (phần bổ sung để quản lý thiết bị đầy đủ hơn)
		private void btnDelete_Click(object sender, EventArgs e)
		{
			if (dataGridView1.CurrentRow == null || dataGridView1.CurrentRow.Cells["EID"].Value == null)
			{
				MessageBox.Show("Vui lòng chọn 1 thiết bị trên danh sách để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			int eid = Convert.ToInt32(dataGridView1.CurrentRow.Cells["EID"].Value);
			string equipName = Convert.ToString(dataGridView1.CurrentRow.Cells["EquipName"].Value) ?? "";

			DialogResult result = MessageBox.Show(
				"Bạn có chắc muốn xóa thiết bị \"" + equipName + "\" (Mã: " + eid + ") không?",
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
				MessageBox.Show("Không xóa được thiết bị.\n\nChi tiết lỗi: " + ex.Message,
					"Lỗi kết nối", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
