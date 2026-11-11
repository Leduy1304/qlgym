using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Gym_Management
{
    public partial class DangKyGoiTapForm : Form
    {
        private class HoiVienItem
        {
            public int MID { get; set; }
            public string DisplayText { get; set; } = "";
            public string MembershipTime { get; set; } = "";
            public string Gymtime { get; set; } = "";
            public string AssignedPT { get; set; } = "";

            public override string ToString() => DisplayText;
        }

        private class PTItem
        {
            public int PID { get; set; }
            public string TenPT { get; set; } = "";
            public string DisplayText { get; set; } = "";

            public override string ToString() => DisplayText;
        }

        private int? _targetMemberId;

        public DangKyGoiTapForm(int? targetMemberId = null)
        {
            InitializeComponent();
            _targetMemberId = targetMemberId;
        }

        private bool LaQuanTriHoacPT => PhienDangNhap.VaiTro == "Admin" || PhienDangNhap.VaiTro == "PT";

        private async void DangKyGoiTapForm_Load(object sender, EventArgs e)
        {
            cmbGoiTap.SelectedIndex = 0;
            cmbGioTap.SelectedIndex = 0;

            // 1. Tải danh sách HLV (PT) vào cmbPT
            LoadDanhSachPT();

            // 2. Phân quyền hiển thị:
            // Nếu là Admin hoặc PT -> Cho phép chọn bất kỳ hội viên nào từ danh sách
            if (LaQuanTriHoacPT)
            {
                txtHoiVien.Visible = false;
                cmbChonHoiVien.Visible = true;
                lblHoiVien.Text = "Chọn Hội viên cần đăng ký / xếp lịch:";
                LoadDanhSachHoiVien();
            }
            else
            {
                // Nếu là Hội viên đăng nhập tự đăng ký cho chính mình
                txtHoiVien.Visible = true;
                cmbChonHoiVien.Visible = false;
                lblHoiVien.Text = "Tài khoản Hội viên:";
                txtHoiVien.Text = $"{PhienDangNhap.TenDangNhap} (Vai trò: Hội viên)";

                // Tải thông tin hiện tại của hội viên từ SQL Server
                LoadThongTinHoiVienHienTai();
            }
        }

        private void LoadDanhSachPT()
        {
            cmbPT.Items.Clear();
            cmbPT.Items.Add(new PTItem { PID = 0, TenPT = "", DisplayText = "Không chọn PT (Tự tập luyện)" });

            try
            {
                using (SqlConnection con = new SqlConnection(DatabaseHelper.ConnectionString))
                {
                    con.Open();
                    string query = "SELECT PID, Fname, Lname, Mobile FROM NewPT ORDER BY PID ASC";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int pid = Convert.ToInt32(reader["PID"]);
                            string fname = reader["Fname"]?.ToString() ?? "";
                            string lname = reader["Lname"]?.ToString() ?? "";
                            string mobile = reader["Mobile"]?.ToString() ?? "";
                            string tenDayDu = $"{fname} {lname}".Trim();

                            var item = new PTItem
                            {
                                PID = pid,
                                TenPT = tenDayDu,
                                DisplayText = $"{tenDayDu} (Mã: {pid}) - SĐT: {mobile}"
                            };
                            cmbPT.Items.Add(item);

                            // Nếu đang đăng nhập bằng tài khoản PT này thì tự động chọn luôn
                            if (PhienDangNhap.VaiTro == "PT" && PhienDangNhap.PTId == pid)
                            {
                                cmbPT.SelectedItem = item;
                            }
                        }
                    }
                }
            }
            catch { }

            if (cmbPT.SelectedIndex == -1) cmbPT.SelectedIndex = 0;
        }

        private void LoadDanhSachHoiVien()
        {
            cmbChonHoiVien.Items.Clear();
            int selectedIndex = 0;

            try
            {
                using (SqlConnection con = new SqlConnection(DatabaseHelper.ConnectionString))
                {
                    con.Open();
                    string query = "SELECT MID, Fname, Lname, Mobile, MembershipTime, Gymtime, AssignedPT FROM NewMember ORDER BY MID DESC";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        int index = 0;
                        while (reader.Read())
                        {
                            int mid = Convert.ToInt32(reader["MID"]);
                            string fname = reader["Fname"]?.ToString() ?? "";
                            string lname = reader["Lname"]?.ToString() ?? "";
                            string mobile = reader["Mobile"]?.ToString() ?? "";
                            string goi = reader["MembershipTime"]?.ToString() ?? "";
                            string gio = reader["Gymtime"]?.ToString() ?? "";
                            string pt = reader["AssignedPT"]?.ToString() ?? "";

                            var item = new HoiVienItem
                            {
                                MID = mid,
                                DisplayText = $"[Mã: {mid}] {fname} {lname} - SĐT: {mobile}",
                                MembershipTime = goi,
                                Gymtime = gio,
                                AssignedPT = pt
                            };
                            cmbChonHoiVien.Items.Add(item);

                            if (_targetMemberId.HasValue && _targetMemberId.Value == mid)
                            {
                                selectedIndex = index;
                            }
                            index++;
                        }
                    }
                }
            }
            catch { }

            if (cmbChonHoiVien.Items.Count > 0)
            {
                cmbChonHoiVien.SelectedIndex = selectedIndex;
            }
            else
            {
                cmbChonHoiVien.Items.Add("Chưa có hội viên nào trong hệ thống");
                cmbChonHoiVien.SelectedIndex = 0;
            }
        }

        private void cmbChonHoiVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbChonHoiVien.SelectedItem is HoiVienItem hv)
            {
                ChonGiaTriGoiVaGio(hv.MembershipTime, hv.Gymtime, hv.AssignedPT);
            }
        }

        private void LoadThongTinHoiVienHienTai()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(DatabaseHelper.ConnectionString))
                {
                    con.Open();
                    string query = @"SELECT TOP 1 MID, Fname, Lname, Mobile, MembershipTime, Gymtime, AssignedPT 
                                     FROM NewMember 
                                     WHERE MID = @MID OR Fname = @Fname";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@MID", PhienDangNhap.HoiVienId ?? 0);
                        cmd.Parameters.AddWithValue("@Fname", PhienDangNhap.TenDangNhap);
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string fn = reader["Fname"]?.ToString() ?? "";
                                string ln = reader["Lname"]?.ToString() ?? "";
                                string mob = reader["Mobile"]?.ToString() ?? "";
                                string goi = reader["MembershipTime"]?.ToString() ?? "";
                                string gio = reader["Gymtime"]?.ToString() ?? "";
                                string pt = reader["AssignedPT"]?.ToString() ?? "";

                                txtHoiVien.Text = $"{fn} {ln} (TK: {PhienDangNhap.TenDangNhap}) - SĐT: {mob}";
                                ChonGiaTriGoiVaGio(goi, gio, pt);
                            }
                        }
                    }
                }
            }
            catch { }
        }

        private void ChonGiaTriGoiVaGio(string goiTap, string gioTap, string ptName)
        {
            if (!string.IsNullOrEmpty(goiTap))
            {
                for (int i = 0; i < cmbGoiTap.Items.Count; i++)
                {
                    string itemText = cmbGoiTap.Items[i]?.ToString() ?? "";
                    if (itemText.Contains(goiTap) || goiTap.Contains(itemText))
                    {
                        cmbGoiTap.SelectedIndex = i;
                        break;
                    }
                }
            }

            if (!string.IsNullOrEmpty(gioTap))
            {
                for (int i = 0; i < cmbGioTap.Items.Count; i++)
                {
                    string itemText = cmbGioTap.Items[i]?.ToString() ?? "";
                    if (itemText.Contains(gioTap) || gioTap.Contains(itemText))
                    {
                        cmbGioTap.SelectedIndex = i;
                        break;
                    }
                }
            }

            if (!string.IsNullOrEmpty(ptName))
            {
                for (int i = 1; i < cmbPT.Items.Count; i++)
                {
                    if (cmbPT.Items[i] is PTItem ptItem && (ptItem.TenPT.Contains(ptName) || ptName.Contains(ptItem.TenPT)))
                    {
                        cmbPT.SelectedIndex = i;
                        break;
                    }
                }
            }
        }

        private async void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (cmbGoiTap.SelectedIndex == -1 || string.IsNullOrWhiteSpace(cmbGoiTap.Text))
            {
                MessageBox.Show("Vui lòng chọn Gói tập cho hội viên (không được để trống hoặc khoảng trắng)!",
                    "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbGoiTap.Focus();
                return;
            }

            if (cmbGioTap.SelectedIndex == -1 || string.IsNullOrWhiteSpace(cmbGioTap.Text))
            {
                MessageBox.Show("Vui lòng chọn Khung giờ tập cho hội viên (không được để trống hoặc khoảng trắng)!",
                    "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbGioTap.Focus();
                return;
            }

            int targetMID = 0;
            string memberDisplay = "";

            if (LaQuanTriHoacPT)
            {
                if (cmbChonHoiVien.SelectedItem is HoiVienItem hv)
                {
                    targetMID = hv.MID;
                    memberDisplay = hv.DisplayText;
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn 1 hội viên từ danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else
            {
                targetMID = PhienDangNhap.HoiVienId ?? 0;
                memberDisplay = txtHoiVien.Text;
            }

            string goiTap = cmbGoiTap.SelectedItem?.ToString() ?? "";
            string gioTap = cmbGioTap.SelectedItem?.ToString() ?? "";
            string assignedPT = "";

            if (cmbPT.SelectedItem is PTItem selectedPT && selectedPT.PID > 0)
            {
                assignedPT = selectedPT.TenPT;
            }

            btnXacNhan.Enabled = false;
            try
            {
                bool daLuu = false;

                // Cập nhật CSDL SQL Server (bảng NewMember)
                try
                {
                    using (SqlConnection con = new SqlConnection(DatabaseHelper.ConnectionString))
                    {
                        con.Open();
                        string query = @"UPDATE NewMember 
                                         SET Gymtime = @Gymtime, MembershipTime = @MembershipTime, AssignedPT = @AssignedPT 
                                         WHERE MID = @MID";
                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@Gymtime", gioTap);
                            cmd.Parameters.AddWithValue("@MembershipTime", goiTap);
                            cmd.Parameters.AddWithValue("@AssignedPT", string.IsNullOrEmpty(assignedPT) ? (object)DBNull.Value : assignedPT);
                            cmd.Parameters.AddWithValue("@MID", targetMID);

                            int rows = cmd.ExecuteNonQuery();
                            if (rows > 0) daLuu = true;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi lưu vào SQL Server: " + ex.Message, "Lỗi kết nối", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Đồng bộ thêm Backend API nếu đang chạy
                if (PhienDangNhap.DaDangNhapQuaApi && !LaQuanTriHoacPT)
                {
                    try
                    {
                        await ApiClient.DangKyGoiVaGioTapAsync(goiTap, gioTap);
                    }
                    catch { }
                }

                if (daLuu)
                {
                    string ptInfo = string.IsNullOrEmpty(assignedPT) ? "Tự tập luyện (Không kèm PT)" : assignedPT;
                    MessageBox.Show(
                        $"🎉 ĐĂNG KÝ THÀNH CÔNG!\n\n" +
                        $"• Hội viên: {memberDisplay}\n" +
                        $"• Gói tập: {goiTap}\n" +
                        $"• Khung giờ: {gioTap}\n" +
                        $"• Huấn luyện viên PT: {ptInfo}\n\n" +
                        $"Dữ liệu đã được lưu thành công vào cơ sở dữ liệu phòng tập.",
                        "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    DialogResult = DialogResult.OK;
                    Close();
                }
            }
            finally
            {
                btnXacNhan.Enabled = true;
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
