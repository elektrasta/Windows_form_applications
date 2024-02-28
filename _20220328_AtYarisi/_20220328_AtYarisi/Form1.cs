using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20220328_AtYarisi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random r = new Random();
            Point at1 = pnlAt1.Location;
            at1.X = at1.X + r.Next(5,20);
            //if(at1.X<300)
            //    at1.X = at1.X + r.Next(4, 15);
            //else
            //    at1.X = at1.X + r.Next(14, 20);
            pnlAt1.Location = at1;

            Point at2 = pbAt2.Location;
            at2.X = at2.X + r.Next(5, 20);
            pbAt2.Location = at2;

            Point at3 = pbAt3.Location;
            at3.X = at3.X + r.Next(5, 20);
            pbAt3.Location = at3;

            int durmaNoktasi = 1000;

            // Durma şartı ? 800 piksel
            if(at1.X>= durmaNoktasi)
            {
                timer1.Enabled = false;
                MessageBox.Show("1. At kazandı");
            }
            else if (at2.X >= durmaNoktasi)
            {
                timer1.Enabled = false;
                MessageBox.Show("2. At kazandı");
            }
            else if (at3.X >= durmaNoktasi)
            {
                timer1.Enabled = false;
                MessageBox.Show("3. At kazandı");
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //timer1.Enabled = true;
        }

        private void btnBaslat_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == false)
            {
                timer1.Enabled = true;
                btnBaslat.Text = "Durdur";
            }     
            else
            {
                timer1.Enabled = false;
                btnBaslat.Text = "Başlat";
            }
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    Point at1 = pbAt1.Location;
        //    at1.X = at1.X + 20;
        //    pbAt1.Location = at1;
        //}
    }
}
