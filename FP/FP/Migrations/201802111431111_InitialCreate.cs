namespace FP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Druzyna",
                c => new
                    {
                        DruzynaId = c.Int(nullable: false, identity: true),
                        Nazwa = c.String(nullable: false, maxLength: 50),
                        StanKonta = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Kraj = c.String(nullable: false, maxLength: 50),
                        NazwaObrazkuGodla = c.String(),
                    })
                .PrimaryKey(t => t.DruzynaId);
            
            CreateTable(
                "dbo.Pilkarz",
                c => new
                    {
                        PilkarzId = c.Int(nullable: false, identity: true),
                        DruzynaId = c.Int(nullable: false),
                        Imie = c.String(nullable: false, maxLength: 50),
                        Nazwisko = c.String(nullable: false, maxLength: 100),
                        Wiek = c.Int(nullable: false),
                        Wartosc = c.Decimal(nullable: false, precision: 18, scale: 2),
                        NaSprzedarz = c.Boolean(nullable: false),
                        Zdjecie = c.String(),
                    })
                .PrimaryKey(t => t.PilkarzId)
                .ForeignKey("dbo.Druzyna", t => t.DruzynaId, cascadeDelete: true)
                .Index(t => t.DruzynaId);
            
            CreateTable(
                "dbo.PozycjaZamowienia",
                c => new
                    {
                        PozycjaZamowieniaId = c.Int(nullable: false, identity: true),
                        ZamowienieId = c.Int(nullable: false),
                        PilkarzId = c.Int(),
                        DruzynaId = c.Int(nullable: false),
                        Cena = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.PozycjaZamowieniaId)
                .ForeignKey("dbo.Druzyna", t => t.DruzynaId, cascadeDelete: true)
                .ForeignKey("dbo.Pilkarz", t => t.PilkarzId)
                .ForeignKey("dbo.Zamowienie", t => t.ZamowienieId, cascadeDelete: true)
                .Index(t => t.ZamowienieId)
                .Index(t => t.PilkarzId)
                .Index(t => t.DruzynaId);
            
            CreateTable(
                "dbo.Zamowienie",
                c => new
                    {
                        ZamowienieId = c.Int(nullable: false, identity: true),
                        Imie = c.String(nullable: false, maxLength: 50),
                        Nazwisko = c.String(nullable: false, maxLength: 100),
                        Adres = c.String(nullable: false, maxLength: 100),
                        Miasto = c.String(nullable: false, maxLength: 100),
                        KodPocztowy = c.String(nullable: false, maxLength: 20),
                        Telefon = c.String(nullable: false, maxLength: 20),
                        Email = c.String(nullable: false),
                        DataZamowienia = c.DateTime(nullable: false),
                        StanZamowienia = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ZamowienieId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PozycjaZamowienia", "ZamowienieId", "dbo.Zamowienie");
            DropForeignKey("dbo.PozycjaZamowienia", "PilkarzId", "dbo.Pilkarz");
            DropForeignKey("dbo.PozycjaZamowienia", "DruzynaId", "dbo.Druzyna");
            DropForeignKey("dbo.Pilkarz", "DruzynaId", "dbo.Druzyna");
            DropIndex("dbo.PozycjaZamowienia", new[] { "DruzynaId" });
            DropIndex("dbo.PozycjaZamowienia", new[] { "PilkarzId" });
            DropIndex("dbo.PozycjaZamowienia", new[] { "ZamowienieId" });
            DropIndex("dbo.Pilkarz", new[] { "DruzynaId" });
            DropTable("dbo.Zamowienie");
            DropTable("dbo.PozycjaZamowienia");
            DropTable("dbo.Pilkarz");
            DropTable("dbo.Druzyna");
        }
    }
}
