using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HavalimaniOtomasyonu
{
    public partial class HavalimanıEkle : Form
    {
        public HavalimanıEkle()
        {
            InitializeComponent();
        }

        private void HavalimanıEkle_Load(object sender, EventArgs e)
        {

        }

        private void havalimaniEkle_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost\\SQLEXPRESS;Database=master;Trusted_Connection=True;";
            string sqlSorgusu = "INSERT INTO HAVALIMANLARI(Ulke, Sehir, HavalimaniAdi, HavalimaniKodu, Adres, Telefon, Email) VALUES(@Ulke, @Sehir, @HavalimaniAdi, @HavalimaniKodu, @Adres, @Telefon, @Email)";

            SqlConnection sqlConnection = new SqlConnection(connectionString);
            
                 SqlCommand sqlCommand = new SqlCommand(sqlSorgusu, sqlConnection);
                
                    sqlCommand.Parameters.Add("@Ulke", SqlDbType.NVarChar).Value = Ulke.Text;
                    sqlCommand.Parameters.Add("@Sehir", SqlDbType.NVarChar).Value = Sehir.Text;
                    sqlCommand.Parameters.Add("@HavalimaniAdi", SqlDbType.NVarChar).Value = havalimaniAdi.Text;
                    sqlCommand.Parameters.Add("@HavalimaniKodu", SqlDbType.NVarChar).Value = havalimaniKodu.Text;
                    sqlCommand.Parameters.Add("@Adres", SqlDbType.NVarChar).Value = Adres.Text;
                    sqlCommand.Parameters.Add("@Telefon", SqlDbType.NVarChar).Value = Telefon.Text;
                    sqlCommand.Parameters.Add("@Email", SqlDbType.NVarChar).Value = e_posta.Text;

                    try
                    {
                        sqlConnection.Open();
                        sqlCommand.ExecuteNonQuery();
                        MessageBox.Show("Havalimanı Başarıyla Eklendi.");
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
