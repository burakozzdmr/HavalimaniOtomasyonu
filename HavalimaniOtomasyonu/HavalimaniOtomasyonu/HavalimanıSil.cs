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
    public partial class HavalimanıSil : Form
    {
        public HavalimanıSil()
        {
            InitializeComponent();
        }

        private void HavalimanıSil_Load(object sender, EventArgs e)
        {

        }

        private void havalimaniSil_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost\\SQLEXPRESS;Database=master;Trusted_Connection=True;";
            string sqlSorgusu = "DELETE FROM HAVALIMANLARI WHERE HavalimaniKodu = @HavalimaniKodu";

            SqlConnection sqlConnection = new SqlConnection(connectionString);
            
                 SqlCommand sqlCommand = new SqlCommand(sqlSorgusu, sqlConnection);
                
                 sqlCommand.Parameters.Add("@HavalimaniKodu", SqlDbType.NVarChar).Value = silinecekHavalimani.Text;

                        try
                        {
                            sqlConnection.Open();
                            int affectedRows = sqlCommand.ExecuteNonQuery();

                            if (affectedRows > 0)
                            {
                                MessageBox.Show("Havalimanı Başarıyla Silinmiştir.");
                            }
                            else
                            {
                                MessageBox.Show("Silinecek havalimanı bulunamadı.");
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