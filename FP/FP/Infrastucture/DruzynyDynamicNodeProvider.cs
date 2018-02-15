using FP.DAL;
using FP.Models;
using MvcSiteMapProvider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FP.Infrastucture
{
    public class DruzynyDynamicNodeProvider : DynamicNodeProviderBase
    {
        private DaneContext db = new DaneContext();

        public override IEnumerable<DynamicNode> GetDynamicNodeCollection(ISiteMapNode nodee)
        {
            var returnValue = new List<DynamicNode>();

            foreach(Druzyna druzyny in db.Druzyna)
            {
                DynamicNode node = new DynamicNode();
                node.Title = druzyny.Nazwa;
                node.Key = "Kategoria_" + druzyny.DruzynaId;
                node.RouteValues.Add("kraj", druzyny.Kraj);
                returnValue.Add(node);
            }

            return returnValue;
        }
    }
}