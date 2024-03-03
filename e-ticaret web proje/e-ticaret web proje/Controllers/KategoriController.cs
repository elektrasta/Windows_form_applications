using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using e_ticaret_web_proje.Models.Siniflar;

namespace e_ticaret_web_proje.Controllers
{
    public class KategoriController : Controller
    {
        // GET: Kategori
        Context c = new Context();
        public ActionResult Index()
        {
            var degerler = c.Kategoris.ToList();//tolist metodu ile kategorileri getir dedim
            return View(degerler);//değerleri döndür
        }
        [HttpGet]//boş sayfayı getir
        public ActionResult KategoriEkle()
        {
            return View();
        }
        [HttpPost]//butona tıkladığım zaman çalıştır
        public ActionResult KategoriEkle(Kategori k)
        {
            c.Kategoris.Add(k);//context te bulunan kategoriye ekle
            c.SaveChanges();//veri tabanına kaydet
            return RedirectToAction("Index");//index e yönlendir sonra
        }
        public ActionResult KategoriSil(int id)
        {
            var ktg = c.Kategoris.Find(id);//girdiğim id i kategoriste bul
            c.Kategoris.Remove(ktg);//sil
            c.SaveChanges();//veri tabanına kaydet
            return RedirectToAction("Index");//index e yönlendir sonra
        }
        public ActionResult KategoriGetir(int id)
        {
            var kategori = c.Kategoris.Find(id);//girdiğim id i kategoriste bul
            return View("KategoriGetir", kategori);
        }
        public ActionResult KategoriGuncelle(Kategori k)
        {
            var ktgr = c.Kategoris.Find(k.KategoriID);//aynı id e yi sql de bul
            ktgr.KategoriAd = k.KategoriAd;//adı yazdır
            c.SaveChanges();//veri tabanına yeni ismiyle kaydet
            return RedirectToAction("Index");//index e yönlendir sonra

        }
    }
}