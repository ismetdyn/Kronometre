using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje5._25_Kronometre
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DateTime zaman;
        private void btnBaslat_Click(object sender, EventArgs e)
        {
            int saat = Convert.ToInt32(tbSaat.Text);
            int dakika = Convert.ToInt32(tbDakika.Text);
            int saniye = Convert.ToInt32(tbSaniye.Text);
            zaman = new DateTime(2000, 1, 1, saat, dakika, saniye);
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            zaman = zaman.AddSeconds(-1);
            lSure.Text = zaman.ToString("HH:mm:ss");
            if(lSure.Text == "00:00:00")
                timer1.Enabled = false;
        }

        private void tbnDurdur_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void btnDevamEt_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void btnSifirla_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            lSure.Text = "00:00:00";
            tbSaat.Text = "0";
            tbDakika.Text = "0";
            tbSaniye.Text = "0";
        }
    }
}
