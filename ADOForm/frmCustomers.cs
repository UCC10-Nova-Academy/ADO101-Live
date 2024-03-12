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
    public partial class frmCustomers : Form
    {
        static string vs_ConnStr = "Server=PHOKAIA\\SS2019DE;Database=Northwind;Trusted_Connection=True;Integrated Security=true;TrustServerCertificate=true;";
        static string vs_SQLCommand; // SQL tarafında çalışmasını isteğim SQL kodlarını bu değişgenin içine yazcam..

        public frmCustomers()
        {
            InitializeComponent();
        }

        private void btonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCustomers_Load(object sender, EventArgs e)
        {
            PrepareGrid();

            BindGrid();

        }

        private void PrepareGrid()
        {
            // Ekrandaki grid i ayarlar

            dgrdCustomers.AutoGenerateColumns = false; // otomatik kolon oluşmaya izin.

            dgrdCustomers.AllowUserToAddRows = false; // Kullanıcı grid uzerinden veri giremesin.
            dgrdCustomers.AllowUserToDeleteRows = false; // veri silemesin.

            dgrdCustomers.RowHeadersVisible = false;
            dgrdCustomers.AllowUserToResizeRows = false;
            dgrdCustomers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Kolon genişlikleri ile ilgili
            dgrdCustomers.ReadOnly = true;
            dgrdCustomers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgrdCustomers.ColumnCount = 4;

            // Kolon tanımlama
            dgrdCustomers.Columns[0].Name = "CustomerID";
            dgrdCustomers.Columns[0].HeaderText = "Müşteri ID";
            dgrdCustomers.Columns[0].DataPropertyName = "CustomerID";

            dgrdCustomers.Columns[1].Name = "CompanyName";
            dgrdCustomers.Columns[1].HeaderText = "Müşteri Adı";
            dgrdCustomers.Columns[1].DataPropertyName = "CompanyName";


            dgrdCustomers.Columns[2].Name = "ContactName";
            dgrdCustomers.Columns[2].HeaderText = "Yetkili Kişi";
            dgrdCustomers.Columns[2].DataPropertyName = "ContactName";

            dgrdCustomers.Columns[3].Name = "Country";
            dgrdCustomers.Columns[3].HeaderText = "Ülke";
            dgrdCustomers.Columns[3].DataPropertyName = "Country";


        }

        private void BindGrid()
        {
            // VT tarafındaki bilgileri alıp DG içine gömmek için
            // 

            vs_SQLCommand = "SELECT * FROM Customers";

            using (SqlConnection connection = new SqlConnection(vs_ConnStr))
            {
                using (SqlCommand command = new SqlCommand(vs_SQLCommand, connection))
                {
                    command.CommandType = CommandType.Text;

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        using (DataSet dset = new DataSet())
                        {
                            adapter.Fill(dset);

                            dgrdCustomers.DataSource = dset.Tables[0]; // dg ye veriyi gönderiyor.
                        }
                    }

                }
            }

        }

        private void btonAdd_Click(object sender, EventArgs e)
        {
            ShowData("I");

            BindGrid();

        }

        private void btonUpdate_Click(object sender, EventArgs e)
        {
            ShowData("U");

            BindGrid();
        }

        private void btonDelete_Click(object sender, EventArgs e)
        {
            vs_SQLCommand = "DELETE FROM Customers WHERE CustomerID=@CustomerID";

            using (SqlConnection connection = new SqlConnection(vs_ConnStr))
            {
                using (SqlCommand command = new SqlCommand(vs_SQLCommand, connection))
                {
                    command.CommandType = CommandType.Text;


                    command.Parameters.Clear();
                    command.Parameters.AddWithValue("CustomerID", dgrdCustomers.CurrentRow.Cells[0].Value);



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

                        MessageBox.Show("Bilgileriniz basarıyla silindi....");

                        
                    }
                    catch (Exception message)
                    {
                        MessageBox.Show("Hata : " + message.ToString());

                    }

                    BindGrid();

                }
            }
        }

        private void ShowData(string prmMode)
        {
            // Insert ve Update seceneklerine göre diğer forma verileri gönderecek ne işlem yapacağını da soyleyecek

            frmCustomerDetail frmCustomerDetail = new frmCustomerDetail();

            frmCustomerDetail.Mod = prmMode;

            // gelen prmMode değerlerine göre ikinci form ayarlanıyor.

            switch (prmMode)
            {
                case "I": // Insert
                    frmCustomerDetail.tboxCustomerID.Enabled = true;

                    frmCustomerDetail.tboxCustomerID.Text = "";
                    frmCustomerDetail.tboxCompanyName.Text = "";
                    frmCustomerDetail.tboxContactName.Text = "";
                    frmCustomerDetail.tboxCountry.Text = "";
                    break;

                case "U": // Update
                    frmCustomerDetail.tboxCustomerID.Enabled = false;

                    frmCustomerDetail.tboxCustomerID.Text= dgrdCustomers.CurrentRow.Cells[0].Value.ToString();
                    frmCustomerDetail.tboxCompanyName.Text= dgrdCustomers.CurrentRow.Cells[1].Value.ToString();
                    frmCustomerDetail.tboxContactName.Text= dgrdCustomers.CurrentRow.Cells[2].Value.ToString();
                    frmCustomerDetail.tboxCountry.Text= dgrdCustomers.CurrentRow.Cells[3].Value.ToString();

                    break;
                default:
                    break;
            }

            frmCustomerDetail.ShowDialog();
        }

    }
}
