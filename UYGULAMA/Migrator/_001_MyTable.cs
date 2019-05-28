using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FluentMigrator;
namespace UYGULAMA.Migrator
{
    [Migration(1)]
    public class _001_MyTable : Migration

    {
        public override void Down()
        {
            Delete.Table("Kisiler_Dersler");
            Delete.Table("Kisiler");
            Delete.Table("Yetki");
            Delete.Table("Dersler");
           
        }

        public override void Up()
        {
            Create.Table("Dersler")
                .WithColumn("DersId").AsInt32().Identity().PrimaryKey()
                .WithColumn("DersAd").AsString(50);


            Create.Table("Yetki")
                          .WithColumn("YetkiId").AsInt32().Identity().PrimaryKey()
                          .WithColumn("YetkiAdı").AsString(20);


            Create.Table("Kisiler")
                .WithColumn("Numara").AsInt32().Identity().PrimaryKey()
                .WithColumn("Ad").AsString(50)
                .WithColumn("Soyad").AsString(50)
                .WithColumn("Ders").AsInt32().ForeignKey("Dersler", "DersId").OnDelete(System.Data.Rule.Cascade).NotNullable()
                .WithColumn("Sifre").AsString(10)
                .WithColumn("Yetki").AsInt32().ForeignKey("Yetki", "YetkiId").OnDelete(System.Data.Rule.Cascade).NotNullable();

            Create.Table("Kisiler_Dersler")
                .WithColumn("kisi_dersID").AsInt32().Identity().PrimaryKey()
                .WithColumn("ders").AsInt32().ForeignKey("Dersler", "DersId").OnDelete(System.Data.Rule.Cascade).NotNullable()
                .WithColumn("Numara").AsInt32().ForeignKey("Kisiler", "Numara").OnDelete(System.Data.Rule.Cascade).NotNullable();


        }
    }
}