using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace e_ticaret_web_proje.Models.Siniflar
{
    public class Musteriler
    {
        [Key]
        public int Musteriid { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string MusteriAd { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string MusteriSoyad { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(13)]
        public string MusteriSehir { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(50)]
        public string MusteriMail { get; set; }
        public ICollection<SatisHaraket> SatisHarakets { get; set; }
    }
}