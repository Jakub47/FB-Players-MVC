using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FP.Models
{
    /// <summary>
    /// Consider as a Person who is ordering like a manager.Drużyna can not order. Only a person can
    /// So provided information will tell who ordered a specific Player
    /// </summary>
    public class Zamowienie
    {
        public int ZamowienieId { get; set; }

        [Required(ErrorMessage = "Wprowadz imię")]
        [StringLength(50)]
        public string Imie { get; set; }
        [Required(ErrorMessage = "Wprowadz nazwisko")]
        [StringLength(100)]
        public string Nazwisko { get; set; }
        [Required(ErrorMessage = "Wprowadz adres")]
        [StringLength(100)]
        public string Adres { get; set; }
        [Required(ErrorMessage = "Wprowadz Miasto")]
        [StringLength(100)]
        public string Miasto { get; set; }
        [Required(ErrorMessage = "Wprowadz kod pocztowy")]
        [StringLength(20)]
        public string KodPocztowy { get; set; }
        [Required(ErrorMessage = "Musisz wprowadzić numer telefonu")]
        [StringLength(20)]
        [RegularExpression(@"(\+\d{2})*[\d\s-]+", ErrorMessage = "Błędny format numeru telefonu.")]
        public string Telefon { get; set; }
        [Required(ErrorMessage = "Wprowadź swój adres e-mail.")]
        [EmailAddress(ErrorMessage = "Błędny format adresu e-mail.")]
        public string Email { get; set; }
        public DateTime DataZamowienia { get; set; }
        public StanZamowienia StanZamowienia { get; set; }

        public List<PozycjaZamowienia> PozycjaZamowienia { get; set; }

    }

    public enum StanZamowienia
    {
        Nowe,
        Zrealizowane
    }
}