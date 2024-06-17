using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HavalimaniOtomasyonu
{
    public partial class uçuşlarıGöster : Form
    {
        public uçuşlarıGöster()
        {
            InitializeComponent();
        }

        private void UçuşlarıGöster_Load(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost\\SQLEXPRESS;Database=master;Trusted_Connection=True;";
            string sqlSorgusu = "SELECT * FROM UCUSLAR";

            DataTable dataTable = new DataTable();

            SqlConnection sqlConnection = new SqlConnection(connectionString);
            
                try
                {
                    sqlConnection.Open();
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlSorgusu, sqlConnection);
                    
                    sqlDataAdapter.Fill(dataTable);
                    uçuşlarıListele.DataSource = dataTable;
                    
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Veritabanı hatası: " + ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata oluştu: " + ex.Message);
                }
                finally
                {
                    if (sqlConnection.State == ConnectionState.Open)
                    {
                        sqlConnection.Close();
                    }
                }
            
        }
    }
}
