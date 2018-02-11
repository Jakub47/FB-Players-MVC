using FP.DAL;
using FP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FP.Controllers
{
    public class HomeController : Controller
    {
        private DaneContext db = new DaneContext();

        public ActionResult Index()
        {
            //TESTING DATABASE
            Druzyna dk = new Druzyna { Nazwa = "dsad",StanKonta = 599,Kraj = "Polska" };
            db.Druzyna.Add(dk);
            db.SaveChanges();
            //TESTING DATABASE

            return View();
        }
    }
}