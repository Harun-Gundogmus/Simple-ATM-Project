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
    public partial class AnaEkran : Form
    {
        public AnaEkran()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ParaYatirma parayatirma = new ParaYatirma();
            parayatirma.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ParaCekme paracekme = new ParaCekme();
            paracekme.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            KrediKartiBorcu borc = new KrediKartiBorcu();
            borc.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            BakiyeOgrenme bakiye = new BakiyeOgrenme();
            bakiye.Show();
            this.Hide();
        }
    }
}
