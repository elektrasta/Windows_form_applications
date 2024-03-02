using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doğduğumdan_beri_kaç_zaman_geçti
{
    class Program
    {
        static void Main(string[] args)
        {
            int yas = 0;
            int yıl = 0;
            int ay = 0;
            int hafta = 0;
            long gun = 0;
            long saat = 0;
            long dakika = 0;
            long saniye = 0;
            long salise = 0;
            Console.Write("Yaşınız kaç : ");
            yas = Int16.Parse(Console.ReadLine());
            yıl = (int)yas * 1;
            ay = (int)yas * 12;
            hafta = (int)yas * 52;
            gun = (long)yas * 365;
            saat = (long)yas * 365 * 24;
            dakika = (long)yas * 365 * 24 * 60;
            saniye = (long)yas * 365 * 24 * 60 * 60;
            salise = (long)yas * 365 * 24 * 60 * 60 * 60;
            Console.WriteLine("Yaşınız {0}  olduğuna göre :", yas);
            Console.WriteLine("{0} yıl", yıl);
            Console.WriteLine("{0} ay", ay);
            Console.WriteLine("{0}  hafta", hafta);
            Console.WriteLine("{0}  gün", gun);
            Console.WriteLine("{0}  saat", saat);
            Console.WriteLine("{0}  dakika", dakika);
            Console.WriteLine("{0}  saniye", saniye);
            Console.WriteLine("{0}  salise", salise);
            Console.WriteLine("yaşamışsınız.");
            Console.ReadKey();
        }
    }
}
