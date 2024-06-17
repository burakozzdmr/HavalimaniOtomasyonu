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
    public partial class UçuşGüncelle : Form
    {
        public UçuşGüncelle()
        {
            InitializeComponent();
        }

        private void UçuşGüncelle_Load(object sender, EventArgs e)
        {

        }

        private void ucusGuncelle_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost\\SQLEXPRESS;Database=master;Trusted_Connection=True;";
            string sqlSorgusu = "UPDATE UCUSLAR SET Havayolu = @Havayolu, UcakModeli = @UcakModeli, Nereden = @Nereden, Nereye = @Nereye, KalkisTarihi = @KalkisTarihi, InisTarihi = @InisTarihi, KalkisHavalimaniKOD = @KalkisHavalimaniKOD, KalkisHavalimani = @KalkisHavalimani, VarisHavalimaniKOD = @VarisHavalimaniKOD, VarisHavalimani = @VarisHavalimani WHERE UcusID = @UcusID";

            SqlConnection sqlConnection = new SqlConnection(connectionString);
            SqlCommand sqlCommand = new SqlCommand(sqlSorgusu, sqlConnection);
                
            sqlCommand.Parameters.Add("@UcusID", SqlDbType.NVarChar).Value = ucusID.Text;
            sqlCommand.Parameters.Add("@Havayolu", SqlDbType.NVarChar).Value = Havayolu.Text;
            sqlCommand.Parameters.Add("@UcakModeli", SqlDbType.NVarChar).Value = ucakModeli.Text;
            sqlCommand.Parameters.Add("@Nereden", SqlDbType.NVarChar).Value = Nereden.Text;
            sqlCommand.Parameters.Add("@Nereye", SqlDbType.NVarChar).Value = Nereye.Text;
            sqlCommand.Parameters.Add("@KalkisTarihi", SqlDbType.DateTime).Value = DateTime.Parse(kalkisTarihi.Text);
            sqlCommand.Parameters.Add("@InisTarihi", SqlDbType.DateTime).Value = DateTime.Parse(varisTarihi.Text);
            sqlCommand.Parameters.Add("@KalkisHavalimaniKOD", SqlDbType.NVarChar).Value = kalkisHavalimaniKod.Text;
            sqlCommand.Parameters.Add("@KalkisHavalimani", SqlDbType.NVarChar).Value = kalkisHavalimani.Text;
            sqlCommand.Parameters.Add("@VarisHavalimaniKOD", SqlDbType.NVarChar).Value = varisHavalimaniKod.Text;
            sqlCommand.Parameters.Add("@VarisHavalimani", SqlDbType.NVarChar).Value = varisHavalimani.Text;

            try
            {
                sqlConnection.Open();
                int affectedRows = sqlCommand.ExecuteNonQuery();

                if (affectedRows > 0)
                {
                    MessageBox.Show("Uçuş Başarıyla Güncellendi.");
                }
                else
                {
                    MessageBox.Show("Güncellenecek uçuş bulunamadı.");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Veritabanı hatası: " + ex.Message);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Tarih formatı hatası: " + ex.Message);
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
