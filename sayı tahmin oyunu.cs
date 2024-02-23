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
    public partial class Form2 : Form
    {
        int sayi;

        public Form2()
        {
            InitializeComponent();
        }

        private void btnTahmin_Click(object sender, EventArgs e)
        {
            int tahmin = 0;
            tahmin = Convert.ToInt32(txtSayi.Text);

            if(tahmin==sayi)
            {
                lblSonuc.Text = "Tebrikler :)";
            }
            else if (tahmin>sayi)
            {
                lblSonuc.Text = tahmin + " den daha küçük bir sayi";
            }
            else
            {
                lblSonuc.Text = tahmin + " den daha büyük bir sayi";

            }







        }

        private void Form2_Load(object sender, EventArgs e)
        {
            sayi = new Random().Next(1, 100);
        }
    }
}
