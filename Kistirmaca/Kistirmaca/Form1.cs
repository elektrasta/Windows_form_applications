using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kistirmaca
{
    public partial class Form1 : Form
    {
        // Bütün fonksiyonlardan erişmek için global tanımlandı.
        int deger,kucuk,buyuk,kullanici;
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnTahmin_Click(object sender, EventArgs e)
        {
            //1. girilen değer aralık içinde mi?
            int sayi = Convert.ToInt32(txtSayi.Text);
            if(sayi>kucuk && sayi<buyuk)
            {
                lstSonuc.Items.Add(kullanici + ".kullanıcı : " + sayi); 


                if(sayi == deger)
                {//bildiyse
                    MessageBox.Show("Kaybettiniz.");
                    return;// aşağıdakilere bakma fonksiyondan çık
                }
                else if(sayi>deger)
                {
                    buyuk = sayi;
                    lblBuyukSayi.Text = sayi.ToString();
                }
                else if (sayi < deger)
                {
                    kucuk = sayi;
                    lblKucukSayi.Text = sayi.ToString();
                }

                //Sıra değiştir.
                if (kullanici == 1)
                    kullanici = 2;
                else
                    kullanici = 1;

                lblKullanici.Text = kullanici + ".kullanıcı";
            }
            else
            {
                string mesaj = "Lütfen " + kucuk + " ile " + buyuk + " arasında bir değer giriniz";
                string baslik = "Hatalı Giriş";
                MessageBox.Show(mesaj, baslik, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        // Form ilk açıldığında çalışan fonksiyon
        private void Form1_Load(object sender, EventArgs e)
        {
            deger = new Random().Next(1, 100);
            kucuk = 0;
            buyuk = 100;
            kullanici = 1;
        }
    }
}
