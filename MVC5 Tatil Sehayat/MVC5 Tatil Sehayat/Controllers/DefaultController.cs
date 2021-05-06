using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC5_Tatil_Sehayat.Models.Sınıflar;
namespace MVC5_Tatil_Sehayat.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        Context c = new Context();
        public ActionResult Index()
        {

            return View();
        }
        public PartialViewResult Partial1()
        {
            var degerler = c.Blogs.OrderByDescending(x => x.ID).Take(2).ToList();
            return PartialView(degerler);
        }
        public PartialViewResult Partial2()
        {
            var degerler = c.Blogs.Where(x => x.ID==1).ToList();
            return PartialView(degerler);
        }
        public PartialViewResult Partial3()
        {
            var blog = c.Blogs.OrderByDescending(x=>x.ID).Take(10).ToList();
            return PartialView(blog);
        }

        public PartialViewResult Partial4()
        {
            var blog = c.Blogs.Take(3).ToList();
            return PartialView(blog);
        }

        public PartialViewResult Partial5()
        {
            var blog = c.Blogs.OrderByDescending(x=>x.ID).Take(3).ToList();
            return PartialView(blog);
        }
    }
   
}