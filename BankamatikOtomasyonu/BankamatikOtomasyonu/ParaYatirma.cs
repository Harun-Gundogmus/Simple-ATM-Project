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
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore.Query.Internal;

namespace BankamatikOtomasyonu
{
    public partial class ParaYatirma : Form
    {
        public ParaYatirma()
        {
            InitializeComponent();
        }

        private void ParaYatirma_Load(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {

                


        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string ad = textBox2.Text;
            string soyad = textBox3.Text;
            int paragir = Convert.ToInt32(textBox4.Text);
            int yatanpara = Convert.ToInt32(textBox1.Text);
            BankaIslemleri bank = new BankaIslemleri();
            bank.MusteriAdDondur(ad, soyad);
            label4.Text = bank.ParaYatirma(paragir, yatanpara).ToString();
            temizle();
        }
        void temizle()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AnaEkran anaekran = new AnaEkran();
            anaekran.Show();
            this.Hide();
        }
    }
}
