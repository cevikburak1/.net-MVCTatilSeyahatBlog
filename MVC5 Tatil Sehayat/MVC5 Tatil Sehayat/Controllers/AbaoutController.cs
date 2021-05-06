using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC5_Tatil_Sehayat.Models.Sınıflar;
namespace MVC5_Tatil_Sehayat.Controllers
{
    public class AbaoutController : Controller
    {
        // GET: Abaout
        Context c = new Context();
        public ActionResult Index()
        {
            var listele = c.Hakkımızdas.ToList();
            return View(listele);
        }
    }
}