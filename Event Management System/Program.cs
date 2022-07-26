using System.Data.SqlClient;
namespace Event_Management_System
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new MainMenu());
        }

        public static SqlConnection Conn()
        {
            SqlConnection? conn = null;
            string connectionString = "Data Source = DESKTOP-8DR3E29\\MSSQLSERVER01; Integrated Security=true; TrustServerCertificate=true";

            try
            {
                conn = new SqlConnection(connectionString);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            return conn;
        }
    }
}