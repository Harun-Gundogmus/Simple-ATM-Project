using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankamatikOtomasyonu
{
    public partial class ParaCekme : Form
    {
        public ParaCekme()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ad = textBox2.Text;
            string soyad = textBox3.Text;
            int paragir = Convert.ToInt32(textBox4.Text);
            int cekilenpara = Convert.ToInt32(textBox1.Text);
            BankaIslemleri bank = new BankaIslemleri();
            bank.MusteriAdDondur(ad, soyad);
            label4.Text = bank.ParaCekme(paragir, cekilenpara).ToString();
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
