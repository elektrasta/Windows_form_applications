using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace e_ticaret_web_proje.Models.Siniflar
{
    public class SatisHaraket
    {
        [Key]
        public int Satisid { get; set; }
        //ürün
        //musteri
        //personel
        public DateTime Tarih { get; set; }
        public int Adet { get; set; }
        public decimal Fiyat { get; set; }
        public decimal ToplamTutar { get; set; }
        public Urun Urun { get; set; }
        public Musteriler Musteriler { get; set; }
        public Personel Personel { get; set; }
    }
}