using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADOForm
{
    public partial class frmCustomerDetail : Form
    {
        static string vs_ConnStr = "Server=PHOKAIA\\SS2019DE;Database=Northwind;Trusted_Connection=True;Integrated Security=true;TrustServerCertificate=true;";
        
        static string vs_SQLCommand=""; // SQL tarafında çalışmasını isteğim SQL kodlarını bu değişgenin içine yazcam..

        public string Mod = ""; // I Insert anlasın,U Update anlasın.

        public frmCustomerDetail()
        {
            InitializeComponent();
        }

        private void btonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btonSave_Click(object sender, EventArgs e)
        {
            switch (Mod)
            {
                // Eğer verinizi dış dünyadaki hackerlardan korumak görünmemesini sağlamak istiyorsanız asağıdaki görüldüğü gibi parametresel yapıyı kullanmak yerinde olur.

                case "I":
                    vs_SQLCommand = "INSERT INTO Customers (CustomerID,CompanyName,ContactName,Country) VALUES (@CustomerID,@CompanyName,@ContactName,@Country)";
                        break;

                case "U":
                    vs_SQLCommand = "UPDATE Customers SET ";
                    vs_SQLCommand += "CompanyName=@CompanyName,";
                    vs_SQLCommand += "ContactName=@ContactName,";
                    vs_SQLCommand += "Country=@Country ";
                    vs_SQLCommand += "WHERE CustomerID = @CustomerID";



                    break;

                default:
                    break;
            }

            // yani sql işlemi yapabilmek için gerekli yapıyı oluşturduk...sıra geldi parametrelerin içini doldurmaya


            using (SqlConnection connection = new SqlConnection(vs_ConnStr))
            {
                using (SqlCommand command = new SqlCommand(vs_SQLCommand, connection))
                {
                    command.CommandType = CommandType.Text;


                    command.Parameters.Clear();
                    command.Parameters.AddWithValue("CustomerID", tboxCustomerID.Text);
                    command.Parameters.AddWithValue("CompanyName", tboxCompanyName.Text);
                    command.Parameters.AddWithValue("ContactName", tboxContactName.Text);
                    command.Parameters.AddWithValue("Country", tboxCountry.Text);


                    //using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    //{
                    //    using (DataSet dset = new DataSet())
                    //    {
                    //        adapter.Fill(dset);

                    //        dgrdCustomers.DataSource = dset.Tables[0]; // dg ye veriyi gönderiyor.
                    //    }
                    //}

                    try
                    {
                        connection.Open();

                        command.ExecuteNonQuery(); // direkt çalıştır...

                        MessageBox.Show("Bilgileriniz basarıyla kayıt edildi....");

                        this.Close();

                    }
                    catch (Exception message)
                    {
                        MessageBox.Show("Hata : " + message.ToString());
                        
                    }

                }
            }
        }
    }
}
