using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProjee.Models.Siniflar;

namespace TravelTripProjee.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin

        Context _context=new Context();
        [Authorize]
        public ActionResult Index()
        {
            var degerler=_context.Blogs.ToList();
            return View(degerler);
        }
        [HttpGet]
        public ActionResult YeniBlog()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YeniBlog(Blog blog)
        {
            _context.Blogs.Add(blog);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }


        public ActionResult BlogSil(int id)
        {
            var blog= _context.Blogs.Find(id);
            _context.Blogs.Remove(blog);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult BlogGetir(int id)
        {
            var blog= _context.Blogs.Find(id);
            return View("BlogGetir",blog);
        }
        public ActionResult BlogGuncelle(Blog blog)
        {
            var blg= _context.Blogs.Find(blog.ID);
            blg.Aciklama=blog.Aciklama;
            blg.Baslik=blog.Baslik;
            blg.Tarih=blog.Tarih;
            blg.BlogImage=blog.BlogImage;
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult YorumListesi()
        {
            var yorumlar = _context.Yorumlars.ToList();
            return View(yorumlar);
        }
        public ActionResult YorumSil(int id)
        {
            var yorum = _context.Yorumlars.Find(id);
            _context.Yorumlars.Remove(yorum);
            _context.SaveChanges();
            return RedirectToAction("YorumListesi");
        }
        public ActionResult YorumGetir(int id)
        {
            var yorum = _context.Yorumlars.Find(id);
            return View("YorumGetir", yorum);
        }
        public ActionResult YorumGuncelle(Yorumlar y)
        {
            var yrm = _context.Yorumlars.Find(y.ID);
            yrm.KullaniciAdi = y.KullaniciAdi;
            yrm.Mail = y.Mail;
            yrm.Yorum = y.Yorum;

            _context.SaveChanges();
            return RedirectToAction("YorumListesi");

        }
    }
}