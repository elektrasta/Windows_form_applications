using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20220307_NotHesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            double vize = 0, final = 0, ortalama = 0;
            string harfNotu = "";
            vize = Convert.ToDouble(txtVize.Text);
            final = Convert.ToDouble(txtFinal.Text);
            ortalama = (vize * 0.3) + (final * 0.7);

            if (ortalama <= 100 && ortalama >= 90)
                harfNotu = "AA";
            else if (ortalama < 90 && ortalama >= 85)
                harfNotu = "BA";
            else if (ortalama < 85 && ortalama >= 80)
                harfNotu = "BB";
            else if (ortalama < 80 && ortalama >= 70)
                harfNotu = "CB";
            else if (ortalama < 70 && ortalama >= 60)
                harfNotu = "CC";
            else if (ortalama < 60 && ortalama >= 55)
                harfNotu = "DC";
            else if (ortalama < 55 && ortalama >= 50)
                harfNotu = "DD";
            else if (ortalama < 50 && ortalama >= 40)
                harfNotu = "FD";
            else if (ortalama < 40 && ortalama >= 0)
                harfNotu = "FF";
            else
                harfNotu = "Hata";


            lblSonuc.Text = ortalama + " ortalama ile Harf Notu : " + harfNotu;

            if (harfNotu == "AA" || harfNotu == "BA")
                lblSonuc.ForeColor = Color.Green;
            else if (harfNotu == "FF" || harfNotu == "FD")
                lblSonuc.ForeColor = Color.Red;

            int sayi = new Random().Next(1, 100);


        }
    }
}
