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

            string vs_ConnStr = "";

            // unutulma durumunda www.connectionstrings.com
            vs_ConnStr = "Server=myServerAddress;Database=Northwind;Trusted_Connection=True;";








        }


        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
