using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using FP.Models;

namespace FP.DAL
{
    public class DaneInitializer : DropCreateDatabaseAlways<DaneContext>
    {
        protected override void Seed(DaneContext context)
        {
            var druzyna = new List<Druzyna>
            {
                new Druzyna() { DruzynaId=1, Nazwa="Orly",       StanKonta=2000,   Kraj="German"  ,NazwaObrazkuGodla = "Orly.png"},
                new Druzyna() { DruzynaId=2, Nazwa="Arka",       StanKonta=1000,   Kraj="Poland"  ,NazwaObrazkuGodla = "Arka.png"},
                new Druzyna() { DruzynaId=3, Nazwa="Black",      StanKonta=100000, Kraj="German"  ,NazwaObrazkuGodla = "Black.png"},
                new Druzyna() { DruzynaId=4, Nazwa="Menchester", StanKonta=5000,   Kraj="Poland"  ,NazwaObrazkuGodla = "Menchester.png"},
                new Druzyna() { DruzynaId=5, Nazwa="Glesgo",     StanKonta=20000,  Kraj="England" ,NazwaObrazkuGodla = "Glesgo.png"},
                new Druzyna() { DruzynaId=6, Nazwa="Chan",       StanKonta=30000,  Kraj="England" ,NazwaObrazkuGodla = "Chan.png"},
                new Druzyna() { DruzynaId=7, Nazwa="Shhot",      StanKonta=2500,   Kraj="Italy"   ,NazwaObrazkuGodla = "Shhot.png"}
            };

            druzyna.ForEach(d => context.Druzyna.Add(d));
            context.SaveChanges();

            var pilkarze = new List<Pilkarz>
            {
                new Pilkarz() { PilkarzId = 1, DruzynaId=1, Imie="Zbigniew", Nazwisko="Lodyga", Wiek=22,Wartosc = 200,NaSprzedarz = true, Zdjecie="Zbigniew_Lodyga.png"},
                new Pilkarz() { PilkarzId = 2, DruzynaId=3, Imie="Drogba", Nazwisko="Dred", Wiek=28,Wartosc = 400,NaSprzedarz = true, Zdjecie="Drogba_Dred.png"},
                new Pilkarz() { PilkarzId = 3, DruzynaId=2, Imie="James", Nazwisko="London", Wiek=20,Wartosc = 700,NaSprzedarz = true, Zdjecie="James_London.png"},
                new Pilkarz() { PilkarzId = 4, DruzynaId=7, Imie="Michael", Nazwisko="Brown", Wiek=25,Wartosc = 500,NaSprzedarz = false, Zdjecie="Michael_Brown.png"},
                new Pilkarz() { PilkarzId = 5, DruzynaId=5, Imie="John", Nazwisko="Johnes", Wiek=19,Wartosc = 300,NaSprzedarz = false, Zdjecie="John_Johnes.png"},
                new Pilkarz() { PilkarzId = 6, DruzynaId=3, Imie="Arthur", Nazwisko="Great", Wiek=18,Wartosc = 100,NaSprzedarz = true, Zdjecie="Arthur_Great.png"},
                new Pilkarz() { PilkarzId = 7, DruzynaId=5, Imie="Darth", Nazwisko="Vader", Wiek=80,Wartosc = 1000,NaSprzedarz = false, Zdjecie="Darth_Vader.png"},
                new Pilkarz() { PilkarzId = 8, DruzynaId=6, Imie="Mickey", Nazwisko="Mouse", Wiek=212,Wartosc = 1200,NaSprzedarz = true, Zdjecie="Mickey_Mouse.png"},
                new Pilkarz() { PilkarzId = 9, DruzynaId=1, Imie="Vergil", Nazwisko="Devil", Wiek=666,Wartosc = 7000,NaSprzedarz = false, Zdjecie="Vergil_Devil.png"},
                new Pilkarz() { PilkarzId = 10, DruzynaId=6, Imie="Nathan", Nazwisko="Drake", Wiek=37,Wartosc = 2000,NaSprzedarz = true, Zdjecie="Nathan_Drake.png"},

            };
            pilkarze.ForEach(p => context.Pilkarz.Add(p));
            context.SaveChanges();

        }
    }
}