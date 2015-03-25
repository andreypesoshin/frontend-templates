using FrontendTemplates.Models;

namespace FrontendTemplates.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<FrontendTemplates.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(FrontendTemplates.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            context.Products.AddOrUpdate(
                p => p.Name,
                new Product { Name = "Блузка", Price = 1000 },
                new Product { Name = "Сережки", Price = 2000 },
                new Product { Name = "Часы", Price = 3000 },
                new Product { Name = "Сумка", Price = 4000 },
                new Product { Name = "Сапоги", Price = 5000 }
                );
        }
    }
}
