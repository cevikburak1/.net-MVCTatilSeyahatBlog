using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC5_Tatil_Sehayat.Models.Sınıflar;
namespace MVC5_Tatil_Sehayat.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        Context c = new Context();
        [Authorize]
        public ActionResult Index()
        {
            var liste = c.Blogs.ToList();
            return View(liste);
        }
        [HttpGet]
        public ActionResult BlogEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult BlogEkle(Blog b)
        {
            c.Blogs.Add(b);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult BlogSil(int id)
        {
            var sil = c.Blogs.Find(id);
            c.Blogs.Remove(sil);
            c.SaveChanges();
            return RedirectToAction("Index");


        }

        public ActionResult BlogGetir(int id)
        {
          var blogbul=  c.Blogs.Find(id);
            return View("BlogGetir", blogbul);
        }

        public ActionResult BlogGuncelle(Blog b)
        {
            var bul = c.Blogs.Find(b.ID);
            bul.Baslik = b.Baslik;
            bul.Tarih = b.Tarih;
            bul.Aciklama = b.Aciklama;
            bul.BlogImage = b.BlogImage;
            c.SaveChanges();
            return RedirectToAction("Index");

        }
        public ActionResult YorumListesi()
        {
            var yorumlar = c.Yorumlars.ToList();
            return View(yorumlar);
        }
        public ActionResult YorumSil(int id)
        {
          var sil=  c.Yorumlars.Find(id);
            c.Yorumlars.Remove(sil);
            c.SaveChanges();
            return RedirectToAction("YorumListesi");
        }
        public ActionResult YorumGetir(int id)
        {
          var yorumbul = c.Yorumlars.Find(id);
            return View("YorumGetir", yorumbul);
        }
        public ActionResult YorumGuncelle(Yorumlar y)
        {
            var Guncelle = c.Yorumlars.Find(y.ID);
            Guncelle.KullaniciAdi = y.KullaniciAdi;
            Guncelle.Mail = y.Mail;
            Guncelle.Yorum = y.Yorum;
            c.SaveChanges();
            return RedirectToAction("YorumListesi");
        }
    }
}