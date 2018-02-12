using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FP.Models;

namespace FP.ViewModel
{
    public class HomeViewModel
    {
        //Here we will define a list of our players and teams
        public IEnumerable<Pilkarz> Najdrozsi { get; set; }
        public IEnumerable<Pilkarz> NaSprzedarz { get; set; }
        public IEnumerable<Druzyna> DruzynyChcaceKupic { get; set; }
    }
}