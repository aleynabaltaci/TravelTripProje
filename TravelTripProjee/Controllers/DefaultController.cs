using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProjee.Models.Siniflar;

namespace TravelTripProjee.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        Context _context=new Context();
        public ActionResult Index()
        {
            var değerler=_context.Blogs.Take(10).ToList();
            return View(değerler);
        }
        public PartialViewResult Partial1()
        {
            var degerler=_context.Blogs.OrderByDescending(a=>a.ID).Take(2).ToList();
            return PartialView(degerler);
        } 
        public PartialViewResult Partial2()
        {
            var deger=_context.Blogs.Where(a=>a.ID==1).ToList();
            return PartialView(deger);
        }
        public  PartialViewResult Partial3()
        {
            var deger = _context.Blogs.ToList();
            return PartialView(deger);
        } 
        public  PartialViewResult Partial4()
        {
            var deger = _context.Blogs.ToList();
            return PartialView(deger);
        }


    }
}