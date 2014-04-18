namespace Prepool_k21_BookStore.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Prepool_k21_BookStore.Models.BookDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Prepool_k21_BookStore.Models.BookDb context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            context.Categories.AddOrUpdate(
              p => p.Name,
              new Category { Name = "Default" }
            );
        }
    }
}
