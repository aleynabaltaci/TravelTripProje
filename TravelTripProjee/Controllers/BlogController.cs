using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProjee.Models.Siniflar;

namespace TravelTripProjee.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
        Context _context= new Context();

        BlogYorum by = new BlogYorum();
        public ActionResult Index()
        {
            //var bloglar = _context.Blogs.ToList(); 
            by.Değer1=_context.Blogs.ToList();
            by.Değer3=_context.Blogs.OrderByDescending(x => x.ID).Take(3).ToList();
            return View(by);
        }

        public ActionResult BlogDetay(int ?id)
        {
            //var blogbul=_context.Blogs.Where(x=>x.ID==id).ToList();
            by.Değer1 = _context.Blogs.Where(x => x.ID == id).ToList();
            by.Değer2 = _context.Yorumlars.Where(x=>x.BlogID == id).ToList();

            return View(by);
        }

    }
}