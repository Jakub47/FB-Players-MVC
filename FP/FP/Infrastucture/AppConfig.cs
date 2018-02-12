using FP.Migrations;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace FP.Infrastucture
{
    /// <summary>
    /// Connector with Web.cofnig
    /// </summary>
    public class AppConfig
    {
        private static  string _zdjeciaPilkarzaFolder = ConfigurationManager.AppSettings["zdjeciaPilkarzaFolder"];

        //Due to fact that we just want to get the specific folder we do not want to let someone change it 
        public static string ZdjeciaPilkarzaFolder
        {
            get
            {
                return _zdjeciaPilkarzaFolder;
            }
        }

        private static string _obrazkiGodlaFolder = ConfigurationManager.AppSettings["obrazkiGodlaFolder"];

        //Due to fact that we just want to get the specific folder we do not want to let someone change it 
        public static string ObrazkiGodlaFolder
        {
            get
            {
                return _obrazkiGodlaFolder;
            }
        }
    }
}