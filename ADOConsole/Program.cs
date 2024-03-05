using Microsoft.Data.SqlClient;

namespace ADOConsole
{
    internal class Program
    {
        static void SelectData()
        {
            // Benim bu ortamdan SQL Server ortamına bağlanabilmem için
            // en gerekli seyler
            // 1. Sql e bağlanabilmek için bir ConnectionString tanımı
            // 2. Bir SqlConnection nesnesi

            //string vs_ConnStr = null;

            // unutulma durumunda www.connectionstrings.com
            string vs_ConnStr = "Server=DESKTOP-TRUHHR2\\SQLEXPRESS;Database=Northwind;Trusted_Connection=True;Integrated Security=true;TrustServerCertificate=true;";

            SqlConnection conn= new SqlConnection(vs_ConnStr); // bir conn nesnesi yarattım

            #region DB Open/Close

            try
            {
                conn.Open(); // db yi acıyorum.
                Console.WriteLine("SQL Servera ulastım...");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Hata : {ex.Message}");

            }

            conn.Close();

            #endregion


















        }


        static void Main(string[] args)
        {
            SelectData();

            Console.ReadKey();
        }
    }
}
