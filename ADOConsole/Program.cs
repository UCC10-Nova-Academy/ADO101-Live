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

            

            #endregion

            #region SQL komutlarını SQL Server tarafına gönderme
            // 1. sql komutları yazmak gerekiyor
            // 2. Bu komuto calıştırmak için de SqlCommand isimli sınıfa ıhtıyac var.

            string vs_SQLCommand = "SELECT EmployeeID,FirstName,LastName,Title FROM Employees ORDER BY LastName DESC";


            SqlCommand cmd = new SqlCommand(vs_SQLCommand,conn);

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read()) 
            {
                Console.WriteLine(reader[0] + " - " + reader[1] + " " + reader[2] + " - " + reader[3]);
            }

            reader.Close();

            conn.Close();

            #endregion

            // Hack01
            // Customers tablosundan ilk 30 kayıdı CompanyName,ContactName,City olarak City bilgisi azalan sırada olacak sekilde yazdırınız..İsterseniz ayrı bir metotda yapabilirsiniz.

            // Hack02
            // Hangi siparişi(Orders) hangi Customer vermiştir




        }


        static void Main(string[] args)
        {
            SelectData();


            Console.ReadKey();
        }
    }
}
