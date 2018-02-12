using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FP.Infrastucture
{
    public static class UrlHelpers
    {
        public static string ZdjeciaSciezka(this UrlHelper helper,string plik)
        {
            var Folder = AppConfig.ZdjeciaPilkarzaFolder;
            var sciezka = Path.Combine(Folder, plik); //add those two for example sciezka => ~/Content/Photo/Zbigniew_Lodyga.png
            var sciezkaBezwgledna = helper.Content(sciezka); //Take Content
            return sciezkaBezwgledna;
        }

        public static string GodloSciezka(this UrlHelper helper, string plik)
        {
            var Folder = AppConfig.ObrazkiGodlaFolder;
            var sciezka = Path.Combine(Folder, plik); //add those two for example sciezka => ~/Content/Photo/Zbigniew_Lodyga.png
            var sciezkaBezwgledna = helper.Content(sciezka); //Take Content
            return sciezkaBezwgledna;
        }
    }
}