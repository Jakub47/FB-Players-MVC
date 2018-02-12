using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace FP
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "PodstawoeInfo",
                url: "strony/{nazwa}.html",
                defaults: new { controller = "Home", action = "Informacje" }
                );

            routes.MapRoute(
                name: "SzczegolyOPilkarzu",
                url: "strony/{nazwisko}-{imie}",
                defaults: new { controller = "Pilkarz", action = "Pokaz" }
                );

            routes.MapRoute(
               name: "SzczegolyODruzynie",
               url: "strony/{nazwa}",
               defaults: new { controller = "Druzyna", action = "Kupno" }
               );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
