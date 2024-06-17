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
    public partial class YolcuEkle : Form
    {
        public YolcuEkle()
        {
            InitializeComponent();
        }

        private void YolcuEkle_Load(object sender, EventArgs e)
        {

        }

        private void Yolcu_Ekle_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost\\SQLEXPRESS;Database=master;Trusted_Connection=True;";
            string sqlSorgusu = "INSERT INTO YOLCULAR(YolcuID, Ad, Soyad, TCNO, DogumTarihi, Cinsiyet, Telefon, Email, Adres) VALUES(@YolcuID, @Ad, @Soyad, @TCNO, @DogumTarihi, @Cinsiyet, @Telefon, @Email, @Adres)";

            SqlConnection sqlConnection = new SqlConnection(connectionString);
            SqlCommand sqlCommand = new SqlCommand(sqlSorgusu, sqlConnection);
                
            sqlCommand.Parameters.Add("@YolcuID", SqlDbType.Int).Value = int.Parse(yolcuID.Text);
            sqlCommand.Parameters.Add("@Ad", SqlDbType.NVarChar).Value = Ad.Text;
            sqlCommand.Parameters.Add("@Soyad", SqlDbType.NVarChar).Value = Soyad.Text;
            sqlCommand.Parameters.Add("@TCNO", SqlDbType.NVarChar).Value = kimlikNumarasi.Text;
            sqlCommand.Parameters.Add("@DogumTarihi", SqlDbType.Date).Value = DateTime.Parse(dogumTarihi.Text);
            sqlCommand.Parameters.Add("@Cinsiyet", SqlDbType.NVarChar).Value = Cinsiyet.Text;
            sqlCommand.Parameters.Add("@Telefon", SqlDbType.NVarChar).Value = Telefon.Text;
            sqlCommand.Parameters.Add("@Email", SqlDbType.NVarChar).Value = e_posta.Text;
            sqlCommand.Parameters.Add("@Adres", SqlDbType.NVarChar).Value = Adres.Text;

            try
            {
                sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Yolcu Başarıyla Eklendi.");
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