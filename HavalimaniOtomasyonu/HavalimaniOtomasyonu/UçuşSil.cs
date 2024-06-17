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
    public partial class UçuşSil : Form
    {
        public UçuşSil()
        {
            InitializeComponent();
        }

        private void UçuşSil_Load(object sender, EventArgs e)
        {

        }

        private void ucusSil_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost\\SQLEXPRESS;Database=master;Trusted_Connection=True;";
            string sqlSorgusu = "DELETE FROM UCUSLAR WHERE UcusID = @UcusID";

            SqlConnection sqlConnection = new SqlConnection(connectionString);
            SqlCommand sqlCommand = new SqlCommand(sqlSorgusu, sqlConnection);
                
            sqlCommand.Parameters.Add("@UcusID", SqlDbType.Int).Value = int.Parse(silinecekUcus.Text);

                try
                {
                    sqlConnection.Open();
                    int affectedRows = sqlCommand.ExecuteNonQuery();

                    if (affectedRows > 0)
                    {
                        MessageBox.Show("Uçuş Başarıyla Silindi.");
                    }
                    else
                    {
                        MessageBox.Show("Silinecek uçuş bulunamadı.");
                    }
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