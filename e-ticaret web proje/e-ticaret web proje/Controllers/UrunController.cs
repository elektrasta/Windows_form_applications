using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using e_ticaret_web_proje.Models.Siniflar;

namespace e_ticaret_web_proje.Controllers
{
    public class UrunController : Controller
    {
        Context c = new Context();
        // GET: Urun
        public ActionResult Index()
        {
            var urunler = c.Uruns.Where(x => x.Durum == true).ToList();//sadece durumu true olanları getir
            return View(urunler);
        }
        [HttpGet]
        public ActionResult YeniUrun()
        {
            List<SelectListItem> deger1 = (from x in c.Kategoris.ToList() select new SelectListItem { Text = x.KategoriAd, Value = x.KategoriID.ToString() }).ToList();
            ViewBag.dgr1 = deger1;//deger1 i dgr1 e eşitledim yukarıda da deger 1 verileri kategoris den alacak bize gösterecek
            return View();
        }
        [HttpPost]
        public ActionResult YeniUrun(Urun p)
        {
            c.Uruns.Add(p);//context te bulunan ürüne ekle
            c.SaveChanges();//veri tabanına kaydet
            return RedirectToAction("Index");//index e yönlendir sonra
        }
        public ActionResult UrunSil(int id)
        {
            var deger = c.Uruns.Find(id);//girdiğim id i kategoriste bul
            deger.Durum = false;//sql de durumu false yapar
            c.SaveChanges();//veri tabanına kaydet
            return RedirectToAction("Index");//index e yönlendir sonra
        }
        public ActionResult UrunGetir(int id) 
        {
            List<SelectListItem> deger1 = (from x in c.Kategoris.ToList() select new SelectListItem { Text = x.KategoriAd, Value = x.KategoriID.ToString() }).ToList();
            ViewBag.dgr1 = deger1;//deger1 i dgr1 e eşitledim yukarıda da deger 1 verileri kategoris den alacak bize gösterecek
            var urundeger = c.Uruns.Find(id);
            return View("UrunGetir", urundeger);
        }
        public ActionResult UrunGuncelle(Urun p)
        {
            var urn = c.Uruns.Find(p.Urunid);
            urn.AlisFiyat = p.AlisFiyat;
            urn.Durum = p.Durum;
            urn.Kategoriid = p.Kategoriid;
            urn.Marka = p.Marka;
            urn.SatisFiyat = p.SatisFiyat;
            urn.Stok = p.Stok;
            urn.UrunAd = p.UrunAd;
            urn.UrunGorsel = p.UrunGorsel;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}