namespace Gym_Management
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            // Luồng chạy của chương trình:
            // 1. Mở form Đăng nhập (Login) trước.
            // 2. Đăng nhập đúng -> mở form chính (Form1).
            // 3. Ở form chính: bấm LOG OUT -> quay lại bước 1; bấm EXIT / đóng form -> thoát hẳn.
            bool exitApp = false;
            while (!exitApp)
            {
                using (Login loginForm = new Login())
                {
                    if (loginForm.ShowDialog() == DialogResult.OK)
                    {
                        using (Form1 mainForm = new Form1())
                        {
                            mainForm.ShowDialog();
                            // Nếu vừa đăng xuất thì vòng lặp chạy tiếp để hiện lại form Đăng nhập,
                            // ngược lại (EXIT / đóng form) thì thoát chương trình.
                            exitApp = !mainForm.IsLogout;
                        }
                    }
                    else
                    {
                        exitApp = true;
                    }
                }
            }
        }
    }
}
