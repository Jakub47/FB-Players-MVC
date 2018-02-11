using FP.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace FP.DAL
{
    public class DaneContext : DbContext
    {
        public DaneContext() : base("DaneContext")
        {

        }

        

        public virtual DbSet<Druzyna> Druzyna { get; set; }
        public virtual DbSet<Pilkarz> Pilkarz { get; set; }
        public virtual DbSet<Zamowienie> Zamowienie { get; set; }
        public  DbSet<PozycjaZamowienia> PozycjaZamowienia { get; set; }

        // DO NOT ADD s AT THE END OF TABLE NAME!!
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}