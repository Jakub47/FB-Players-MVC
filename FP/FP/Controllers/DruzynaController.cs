using FP.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FP.Controllers
{
    public class DruzynaController : Controller
    {
        private DaneContext db = new DaneContext();

        // GET: Druzyna
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Kupno(string nazwa)
        {
            var druzyna = db.Druzyna.Where(a => a.Nazwa == nazwa).Single();
            return View(druzyna);
        }
    }
}