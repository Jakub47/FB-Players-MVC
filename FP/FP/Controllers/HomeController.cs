using FP.DAL;
using FP.Models;
using FP.ViewModel;
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
            //var listaDruzyn = db.Druzyna.ToList();
            //return View(listaDruzyn);
            var najdrozszi = db.Pilkarz.Where(a => a.NaSprzedarz).OrderByDescending(a => a.Wartosc).Take(3).ToList();
            var druzynyChcaceKupic = db.Druzyna.OrderBy(g => Guid.NewGuid()).Take(3).ToList(); //Forgot to add something to model,Guid to somehow "replace" an error
            var vm = new HomeViewModel
            {
                Najdrozsi = najdrozszi,
                DruzynyChcaceKupic = druzynyChcaceKupic
            };
            return View(vm);

        }

        public ActionResult Informacje(string nazwa)
        {
            return View(nazwa); //It will generate a specific View Based on the name we will provide with the Url.Action().
        }
    }
}