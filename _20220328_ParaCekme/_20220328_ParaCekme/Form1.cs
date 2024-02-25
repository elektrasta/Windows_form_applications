using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20220328_ParaCekme
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btnParaCek_Click(object sender, EventArgs e)
        {
            // Bankada bulunan paralar
            int l200 = 5, l100 = 5, l50 = 10, l20 = 100, l10 = 1000;
            lstPara.Items.Clear(); // listbox içerisini temizler
            int s200=0, s100=0, s50=0, s20=0, s10=0;
            int para = Convert.ToInt32(txtPara.Text);

            if (para < 10)
            {
                MessageBox.Show("Lütfen en az 10 TL ve katları giriniz.");
                return;
            }


            if(para%10!=0) // 10 sayısına tam bölünmüyorsa
            {
                MessageBox.Show("Lütfen 10 ve katları giriniz.");
                return;
            }


            while(para!=0)
            {
                if (para >= 200)
                {
                    para = para - 200;
                    s200++; //s200 = s200 + 1;
                }
                else if (para >= 100)
                {
                    para = para - 100;
                    s100++;
                }
                else if (para >= 50)
                {
                    para = para - 50;
                    s50++;
                }
                else if (para >= 20)
                {
                    para = para - 20;
                    s20++;
                }
                else if (para >= 10)
                {
                    para = para - 10;
                    s10++;
                }
            }

            if (s200 > 0)
                lstPara.Items.Add(s200 + " adet 200 TL");
            if (s100 > 0)
                lstPara.Items.Add(s100 + " adet 100 TL");
            if (s50 > 0)
                lstPara.Items.Add(s50 + " adet 50 TL");
            if (s20 > 0)
                lstPara.Items.Add(s20 + " adet 20 TL");
            if (s10 > 0)
                lstPara.Items.Add(s10 + " adet 10 TL");


        }
    }
}
