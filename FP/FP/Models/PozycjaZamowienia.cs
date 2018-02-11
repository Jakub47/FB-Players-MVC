using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FP.Models
{
    public class PozycjaZamowienia
    {
        public int PozycjaZamowieniaId { get; set; }
        public int ZamowienieId { get; set; }
        public int? PilkarzId { get; set; }
        public int DruzynaId { get; set; }
        public decimal Cena { get; set; }

        public virtual Pilkarz Pilkarz { get; set; }
        public virtual Druzyna Druzyna { get; set; }
    }
}