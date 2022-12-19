using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BankamatikOtomasyonu
{
    public partial class BakiyeOgrenme : Form
    {
        public BakiyeOgrenme()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ad = textBox2.Text;
            string soyad = textBox3.Text;
            BankaIslemleri bank = new BankaIslemleri();
            bank.MusteriAdDondur(ad, soyad);
            label2.Text = bank.BakiyeOgrenme(0).ToString();
            temizle();
        }
        void temizle()
        {
            textBox2.Clear();
            textBox3.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AnaEkran anaekran = new AnaEkran();
            anaekran.Show();
            this.Hide();
        }
    }
}
