using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FP.Models
{
    public class Pilkarz
    {
        public int PilkarzId { get; set; }
        public int DruzynaId { get; set; }
        [Required(ErrorMessage = "Wprowadz Imie")]
        [StringLength(50)]
        public string Imie { get; set; }
        [Required(ErrorMessage = "Wprowadz Nazwisko")]
        [StringLength(100)]
        public string Nazwisko { get; set; }
        [Required(ErrorMessage = "Wprowadz Wiek")]
        public int Wiek { get; set; }
        public decimal Wartosc { get; set; }
        public bool NaSprzedarz { get; set; }
        public string Zdjecie { get; set; }

        public virtual Druzyna Druzyna { get; set; } //override
    }
}