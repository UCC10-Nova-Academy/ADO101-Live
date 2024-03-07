using Microsoft.Data.SqlClient;

namespace ADOForm
{
    public partial class Form1 : Form
    {
        static string vs_ConnStr = "Server=DESKTOP-TRUHHR2\\SQLEXPRESS;Database=Northwind;Trusted_Connection=True;Integrated Security=true;TrustServerCertificate=true;";

        SqlConnection conn = new SqlConnection(vs_ConnStr); // bir conn nesnesi yaratt�m
        SqlCommand cmd = new SqlCommand(); // sql komut tas�y�c�
        SqlDataReader dataReader; // sql komutunu g�nderen cal�st�ran ve sonuclar�n� geri alan yap�
        string sqlstr; // sql deyimlerini yazaca��m de�i�gen


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

            FormInit(true); // ilk giri�te yasaklad�m

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
            // Veriyi SQL Server taraf�n �ekecek sorguyu olusturuyorum.

            sqlstr = "SELECT EmployeeID,FirstName,LastName,Title,City,Country FROM Employees ORDER BY EmployeeID";

            cmd.CommandText = sqlstr;

            // �imdi al bu sql text i kars�ya g�nder cal��t�r  sonuclar� al

            dataReader = cmd.ExecuteReader();

            ShowData();

        }

        private void ShowData()
        {
            if (dataReader.Read()) // read bir sonraki kay�d� okur
            {
                // her okudu�unda ekrana yerlestir.
                tboxEmployeeID.Text = dataReader[0].ToString();
                tboxFName.Text = dataReader[1].ToString();
                tboxLName.Text = dataReader[2].ToString();
                tboxTitle.Text = dataReader[3].ToString();
                tboxCity.Text = dataReader[4].ToString();
                tboxCountry.Text = dataReader[5].ToString();
            }
            else
            {
                MessageBox.Show("G�sterilecek kay�t yok..Kay�tlar bitti");
            }
        }

        private void btonNext_Click(object sender, EventArgs e)
        {
            ShowData();
        }

        private void btonNew_Click(object sender, EventArgs e)
        {
            // buras� yeni bilgi eklemek i�in ekran gerekli bilgileri al�r.

            // temizleme harekat� ve yasaklar� kald�rs�n

            FormInit(false);

            // �nce acaba hangi ID �le kay�t olacak
            sqlstr = "SELECT ISNULL(MAX(EmployeeID),1000) + 1 FROM Employees";
            cmd.CommandText = sqlstr;

            dataReader.Close();

            //dataReader = cmd.ExecuteReader();

            tboxEmployeeID.Text = cmd.ExecuteScalar().ToString();

            tboxFName.Focus();
        }

        private void btonInsert_Click(object sender, EventArgs e)
        {
            // �nce kontrol 
            // db taraf�ndaki tablonun k�s�tlar�na gore

            if (tboxFName.Text == "")
            {
                MessageBox.Show("Ad alan� bo� olamaz...");
            }
            else if (tboxLName.Text == "")
            {
                MessageBox.Show("Soyad alan� bo� olamaz...");
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
                MessageBox.Show("��lem basar�l�");
            }
            else
                MessageBox.Show("Bir terslik var...");


        }
    }
}
