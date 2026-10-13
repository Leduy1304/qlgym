namespace Gym_Management
{
	// Chuỗi kết nối dùng chung cho các form mới (NewStaff, Equipment, SearchMember, DeleteMember).
	// LƯU Ý: Đây là đúng chuỗi kết nối Duy đang dùng trong form NewMember.
	// Nếu đổi máy / đổi tên SQL Server thì chỉ cần sửa ở đây 1 chỗ
	// (và sửa thêm 1 dòng tương tự trong NewMember.cs vì form đó đã viết sẵn từ trước).
	public static class DatabaseHelper
	{
		public static readonly string ConnectionString =
			"data source = DESKTOP-6R52ARN\\SQLEXPRESS; database = gym; integrated security = True; TrustServerCertificate=True";
	}
}
