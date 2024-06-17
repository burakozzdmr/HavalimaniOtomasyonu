using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace HavalimaniOtomasyonu
{
    public partial class Hoşgeldiniz : Form
    {
        public Hoşgeldiniz()
        {
            InitializeComponent();
        }

        private void uçuşEkle_Click(object sender, EventArgs e)
        {
            UçuşEkle uçuşEkle = new UçuşEkle();

            uçuşEkle.Show();
        }

        private void uçuşGüncelle_Click(object sender, EventArgs e)
        {
            UçuşGüncelle uçuşGüncelle = new UçuşGüncelle();

            uçuşGüncelle.Show();
        }
        private void uçuşlarıGöster_Click(object sender, EventArgs e)
        {
            uçuşlarıGöster uçuşlarıGöster = new uçuşlarıGöster();

            uçuşlarıGöster.Show();
        }

        private void uçuşSil_Click(object sender, EventArgs e)
        {
            UçuşSil uçuşSil = new UçuşSil();

            uçuşSil.Show();
        }

        private void yolcuEkle_Click(object sender, EventArgs e)
        {
            YolcuEkle yolcuEkle = new YolcuEkle();

            yolcuEkle.Show();
        }

        private void yolcuSil_Click(object sender, EventArgs e)
        {
            YolcuSil yolcuSil = new YolcuSil();

            yolcuSil.Show();
        }

        private void Çıkış_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void havalimanıEkle_Click(object sender, EventArgs e)
        {
            HavalimanıEkle havalimanıEkle = new HavalimanıEkle();

            havalimanıEkle.Show();
        }

        private void havalimanıSil_Click(object sender, EventArgs e)
        {
            HavalimanıSil havalimanıSil = new HavalimanıSil();

            havalimanıSil.Show();
        }

        private void havalimanlarınıGöster_Click(object sender, EventArgs e)
        {
            havalimanlariniGöster havalimanlarınıGöster = new havalimanlariniGöster();

            havalimanlarınıGöster.Show();
        }

        private void Hoşgeldiniz_Load(object sender, EventArgs e)
        {

        }
    }
}
