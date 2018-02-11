using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FP.Models
{
    public class Druzyna
    {
        public int DruzynaId { get; set; }
        [Required(ErrorMessage = "Wprowadz nazwe druzyny")]
        [StringLength(50)]
        public string Nazwa { get; set; }
        [Required(ErrorMessage = "Wprowadz stan konta")]
        public decimal StanKonta { get; set; }
        [Required(ErrorMessage = "Wprowadz stan konta")]
        [StringLength(50)]
        public string Kraj { get; set; }
        public string NazwaObrazkuGodla { get; set; }

        public virtual IEnumerable<Pilkarz> Pilkarz { get; set; } //Override
    }
}