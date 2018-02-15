using FP.DAL;
using FP.Models;
using MvcSiteMapProvider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FP.Infrastucture
{
    public class PilkarzSzczegolyDynamicNodeProvider : DynamicNodeProviderBase
    {
        private DaneContext db = new DaneContext();

        public override IEnumerable<DynamicNode> GetDynamicNodeCollection(ISiteMapNode nodee)
        {
            var returnValue = new List<DynamicNode>();

            foreach (Pilkarz pilkarz in db.Pilkarz)
            {
                DynamicNode node = new DynamicNode();
                node.Title = pilkarz.Nazwisko;
                node.Key = "Pilkarz_" + pilkarz.PilkarzId;
                node.ParentKey = "Kategoria_" + pilkarz.DruzynaId;
                node.RouteValues.Add("id",pilkarz.PilkarzId); //Adds and element with a provided key and value.
                returnValue.Add(node);
            }

            return returnValue;
        }
    }
}