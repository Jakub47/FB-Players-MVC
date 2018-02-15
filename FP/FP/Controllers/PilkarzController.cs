using FP.DAL;
using FP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FP.Controllers
{
    public class PilkarzController : Controller
    {
        private DaneContext db = new DaneContext();

        // GET: Pilkarz
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Pokaz(string nazwisko, string imie)
        {
            var pilkarz = db.Pilkarz.Where(n => n.Nazwisko == nazwisko && n.Imie == imie).Single();
            return View(pilkarz);
        }

        public ActionResult Lista(string kraj)
        {
            var pk = db.Druzyna.Where(a => a.Kraj == kraj).ToList(); //Here we took all the countries that has specifc country
            var id = pk.Select(s => s.DruzynaId).ToList();
            var pilkarze = db.Pilkarz.TakeWhile(i => i.Druzyna != null);
            return View(pilkarze);
        }
    }
}