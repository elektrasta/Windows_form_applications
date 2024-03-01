using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza
{
    public partial class Form1 : Form
    {
        double toplamFiyat = 0;
        public Form1()
        {
            InitializeComponent();
        }

        // Küçük boy fiyatları
        // Süperos-30TL, Sucuk Sever-35TL, Margarita-29TL, Bol Malzemos-40TL, Karışık-25TL
        // Orta Boy fiyatı küçük boy fiyatının 1.5 katı ,Büyük Boy fiyatı küçük boy fiyatının 2 katı

        // Kalın kenar +5 TL

        //Ekstra Malzemeler
        // Susam +0, Sosis +5TL, Jambon +5TL, Mantar +3TL
        // Siyah Zeytin +3TL, Peynir +4TL, Domates +5TL, Köz Biber +6TL

        //İsimlendirmeler
        //lstPizzalar,lstSepet
        //rbEbatKucuk,rbEbatOrta,rbEbatBuyuk - rbKenarInce, rbKenarKalin
        //cbSusam, cbSosis, cbJambon, cbMantar, cbSiyahZeytin, cbPeynir, cbDomates, cbKozBiber
        //btnHesapla, btnSepeteEkle,btnSiparisiOnayla,
        //numAdet, txtTutar, lblToplamTutar


        public bool Kontrol()
        {
            //Adet sayısı 0 olamaz, lstPizzalardan en az 1 tane seçilmiş olması lazım. 
           if(numAdet.Value ==0)
            {
                MessageBox.Show("Lütfen adet giriniz.");
                return false;
            }
           else if (lstPizzalar.SelectedItem==null)
            {
                MessageBox.Show("Lütfen pizza seçiniz.");
                return false;
            }


            return true;
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            if (Kontrol() == false)
                return;

            double fiyat=0;
           
            if((string)lstPizzalar.SelectedItem== "Süperos")
            {
                fiyat = 30;
            }
            else if((string)lstPizzalar.SelectedItem == "Sucuk Sever")
            {
                fiyat = 35;
            }
            else if ((string)lstPizzalar.SelectedItem == "Margarita")
            {
                fiyat = 29;
            }
            else if ((string)lstPizzalar.SelectedItem == "Bol Malzemos")
            {
                fiyat = 40;
            }
            else if ((string)lstPizzalar.SelectedItem == "Karışık")
            {
                fiyat = 25;
            }

           

            // Ebat
            if (rbEbatBuyuk.Checked==true)
            {
                fiyat = fiyat * 2;
            }
            else if(rbEbatOrta.Checked == true)
            {
                fiyat = fiyat * 1.5;
            }
            else if (rbEbatKucuk.Checked == true)
            {
                fiyat = fiyat * 1;
            }

            //Kenar
            if(rbKenarKalin.Checked)
            {
                fiyat = fiyat + 5;
            }
            else
            {
                //fiyat = fiyat + 0;
            }

            // Ekstra malzeme
            if(cbSusam.Checked)
            {
                fiyat = fiyat + 0;
            }

            if (cbSosis.Checked)
            {
                fiyat = fiyat + 5;
            }

            if (cbJambon.Checked)
            {
                fiyat = fiyat + 5;
            }

            if (cbMantar.Checked)
            {
                fiyat = fiyat + 3;
            }

            if (cbSiyahZeytin.Checked)
            {
                fiyat = fiyat + 3;
            }

            if (cbPeynir.Checked)
            {
                fiyat = fiyat + 4;
            }

            if (cbDomates.Checked)
            {
                fiyat = fiyat + 5;
            }

            if (cbKozBiber.Checked)
            {
                fiyat = fiyat + 6;
            }

            fiyat = fiyat * Convert.ToDouble(numAdet.Value);

            txtTutar.Text = fiyat.ToString();
            

            // Hesaplama yapılıp txtTutar içerisine toplam tutarın yazılması
        }

        private void btnSepeteEkle_Click(object sender, EventArgs e)
        {
            if (Kontrol() == false)
                return;

            double fiyat = 0;
            string ozet = "";
            if ((string)lstPizzalar.SelectedItem == "Süperos")
            {
                fiyat = 30;
            }
            else if ((string)lstPizzalar.SelectedItem == "Sucuk Sever")
            {
                fiyat = 35;
            }
            else if ((string)lstPizzalar.SelectedItem == "Margarita")
            {
                fiyat = 29;
            }
            else if ((string)lstPizzalar.SelectedItem == "Bol Malzemos")
            {
                fiyat = 40;
            }
            else if ((string)lstPizzalar.SelectedItem == "Karışık")
            {
                fiyat = 25;
            }

            ozet = (string)lstPizzalar.SelectedItem;

            // Ebat
            if (rbEbatBuyuk.Checked == true)
            {
                fiyat = fiyat * 2;
                ozet = ozet + " - Büyük boy ";
            }
            else if (rbEbatOrta.Checked == true)
            {
                fiyat = fiyat * 1.5;
                ozet = ozet + " - Orta boy ";
            }
            else if (rbEbatKucuk.Checked == true)
            {
                fiyat = fiyat * 1;
                ozet = ozet + " - Küçük boy ";
            }

            //Kenar
            if (rbKenarKalin.Checked)
            {
                fiyat = fiyat + 5;
                ozet = ozet + " - Kalın kenar ";
            }
            else
            {
                ozet = ozet + " - İnce kenar ";
                //fiyat = fiyat + 0;
            }

            ozet = ozet + "(";

            // Ekstra malzeme
            if (cbSusam.Checked)
            {
                fiyat = fiyat + 0;
                ozet = ozet + " Susam ";
            }

            if (cbSosis.Checked)
            {
                fiyat = fiyat + 5;
                ozet = ozet + " Sosis ";
            }

            if (cbJambon.Checked)
            {
                fiyat = fiyat + 5;
                ozet = ozet + " Jambon ";
            }

            if (cbMantar.Checked)
            {
                fiyat = fiyat + 3;
                ozet = ozet + " Mantar ";
            }

            if (cbSiyahZeytin.Checked)
            {
                fiyat = fiyat + 3;
                ozet = ozet + " Siyah Zeytin ";
            }

            if (cbPeynir.Checked)
            {
                fiyat = fiyat + 4;
                ozet = ozet + " Peynir ";
            }

            if (cbDomates.Checked)
            {
                fiyat = fiyat + 5;
                ozet = ozet + " Domates ";
            }

            if (cbKozBiber.Checked)
            {
                fiyat = fiyat + 6;
                ozet = ozet + " Köz Biber ";
            }

            ozet = ozet + ")";

            fiyat = fiyat * Convert.ToDouble(numAdet.Value);

            ozet = ozet + " fiyat : " + fiyat;

            ozet = numAdet.Value + " adet " + ozet;

            txtTutar.Text = fiyat.ToString();
            lstSepet.Items.Add(ozet);

            toplamFiyat = toplamFiyat + fiyat;
            lblToplamTutar.Text = "Toplam Fiyat : " + toplamFiyat;

        }

        private void btnSiparisOnayla_Click(object sender, EventArgs e)
        {
            // Yeni kayıt girilmesi için tüm nesnelerin ilk halini alması sağlanacak. 
        }
    }
}
