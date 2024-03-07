using Microsoft.Data.SqlClient;

namespace ADOForm
{
    public partial class Form1 : Form
    {
        static string vs_ConnStr = "Server=DESKTOP-TRUHHR2\\SQLEXPRESS;Database=Northwind;Trusted_Connection=True;Integrated Security=true;TrustServerCertificate=true;";

        SqlConnection conn = new SqlConnection(vs_ConnStr); // bir conn nesnesi yarattým
        SqlCommand cmd = new SqlCommand(); // sql komut tasýyýcý
        SqlDataReader dataReader; // sql komutunu gçnderen calýstýran ve sonuclarýný geri alan yapý
        string sqlstr; // sql deyimlerini yazacaðým deðiþgen


        public Form1()
        {
            InitializeComponent();
        }

        private void btonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmd.Connection = conn;

            conn.Open();

            FormInit(true); // ilk giriþte yasakladým

            LoadData();


        }

        private void FormInit(Boolean pStatus)
        {
            tboxEmployeeID.Clear();
            tboxFName.Clear();
            tboxLName.Clear();
            tboxTitle.Clear();
            tboxCity.Clear();
            tboxCountry.Clear();

            if (pStatus == true)
            {
                tboxEmployeeID.ReadOnly = true;
                tboxFName.ReadOnly = true;
                tboxLName.ReadOnly = true;
                tboxTitle.ReadOnly = true;
                tboxCity.ReadOnly = true;
                tboxCountry.ReadOnly = true;

                btonInsert.Enabled = false;
                btonDelete.Enabled = false;
                btonUpdate.Enabled = false;
            }
            else
            {

                tboxFName.ReadOnly = false;
                tboxLName.ReadOnly = false;
                tboxTitle.ReadOnly = false;
                tboxCity.ReadOnly = false;
                tboxCountry.ReadOnly = false;

                btonInsert.Enabled = true;
                btonDelete.Enabled = true;
                btonUpdate.Enabled = true;
            }

        }

        private void LoadData()
        {
            // Veriyi SQL Server tarafýn çekecek sorguyu olusturuyorum.

            sqlstr = "SELECT EmployeeID,FirstName,LastName,Title,City,Country FROM Employees ORDER BY EmployeeID";

            cmd.CommandText = sqlstr;

            // þimdi al bu sql text i karsýya gçnder calýþtýr  sonuclarý al

            dataReader = cmd.ExecuteReader();

            ShowData();

        }

        private void ShowData()
        {
            if (dataReader.Read()) // read bir sonraki kayýdý okur
            {
                // her okuduðunda ekrana yerlestir.
                tboxEmployeeID.Text = dataReader[0].ToString();
                tboxFName.Text = dataReader[1].ToString();
                tboxLName.Text = dataReader[2].ToString();
                tboxTitle.Text = dataReader[3].ToString();
                tboxCity.Text = dataReader[4].ToString();
                tboxCountry.Text = dataReader[5].ToString();
            }
            else
            {
                MessageBox.Show("Gösterilecek kayýt yok..Kayýtlar bitti");
            }
        }

        private void btonNext_Click(object sender, EventArgs e)
        {
            ShowData();
        }

        private void btonNew_Click(object sender, EventArgs e)
        {
            // burasý yeni bilgi eklemek için ekran gerekli bilgileri alýr.

            // temizleme harekatý ve yasaklarý kaldýrsýn

            FormInit(false);

            // çnce acaba hangi ID þle kayýt olacak
            sqlstr = "SELECT ISNULL(MAX(EmployeeID),1000) + 1 FROM Employees";
            cmd.CommandText = sqlstr;

            dataReader.Close();

            //dataReader = cmd.ExecuteReader();

            tboxEmployeeID.Text = cmd.ExecuteScalar().ToString();

            tboxFName.Focus();
        }

        private void btonInsert_Click(object sender, EventArgs e)
        {
            // önce kontrol 
            // db tarafýndaki tablonun kýsýtlarýna gore

            if (tboxFName.Text == "")
            {
                MessageBox.Show("Ad alaný boþ olamaz...");
            }
            else if (tboxLName.Text == "")
            {
                MessageBox.Show("Soyad alaný boþ olamaz...");
            }
            else
            {
                sqlstr=string.Format("INSERT INTO Employees (FirstName,LastName,Title,City,Country) VALUES ('{0}','{1}','{2}','{3}','{4}')",tboxFName.Text,tboxLName.Text,tboxTitle.Text,tboxCity.Text,tboxCountry.Text);

                ExecuteSQL();

                btonInsert.Enabled = false;

                LoadData();

            }


        }

        private void ExecuteSQL()
        {
            cmd.CommandText= sqlstr;

            int count= cmd.ExecuteNonQuery();

            if (count > 0)
            {
                MessageBox.Show("Ýþlem basarýlý");
            }
            else
                MessageBox.Show("Bir terslik var...");


        }
    }
}
