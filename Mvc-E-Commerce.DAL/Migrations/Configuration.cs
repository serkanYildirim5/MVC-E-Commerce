namespace Mvc_E_Commerce.DAL.Migrations
{
    using Mvc_E_Commerce.Entity.Model;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Mvc_E_Commerce.DAL.Mvc_E_CommerceContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Mvc_E_Commerce.DAL.Mvc_E_CommerceContext context)
        {
            List<Category> kt = new List<Category>() {
                new Category(){CategoryName="Araba"},
                new Category(){CategoryName="Giyim"},
                new Category(){CategoryName="Elektronik"},
                new Category(){CategoryName="Beyaz Eþya"},
                new Category(){CategoryName="Bulaþýk Makinesi",ParentId=4},
                new Category(){CategoryName="Çamaþýr Makinesi",ParentId=4},
                new Category(){CategoryName="Telefon",ParentId=3},
                new Category(){CategoryName="Bilgisayar",ParentId=3},
                new Category(){CategoryName="Televizyon",ParentId=3},
                new Category(){CategoryName="Dýþ Giyim",ParentId=2},
                new Category(){CategoryName="Alt Giyim",ParentId=2},
                new Category(){CategoryName="Sport",ParentId=1},
                new Category(){CategoryName="Pickup",ParentId=1},
            };
            context.Categories.AddRange(kt);
            context.SaveChanges();
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
