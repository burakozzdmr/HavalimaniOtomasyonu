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
    public partial class YolcuSil : Form
    {
        public YolcuSil()
        {
            InitializeComponent();
        }

        private void YolcuSil_Load(object sender, EventArgs e)
        {

        }

        private void Yolcu_Sil_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost\\SQLEXPRESS;Database=master;Trusted_Connection=True;";
            string sqlSorgusu = "DELETE FROM YOLCULAR WHERE YolcuID = @YolcuID";

            SqlConnection sqlConnection = new SqlConnection(connectionString);
            SqlCommand sqlCommand = new SqlCommand(sqlSorgusu, sqlConnection);
                
            sqlCommand.Parameters.Add("@YolcuID", SqlDbType.NVarChar).Value = silinecekYolcu.Text;

            try
            {
                sqlConnection.Open();
                int affectedRows = sqlCommand.ExecuteNonQuery();

                if (affectedRows > 0)
                {
                    MessageBox.Show("Yolcu Başarıyla Silindi.");
                }
                else
                {
                    MessageBox.Show("Silinecek yolcu bulunamadı.");
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
