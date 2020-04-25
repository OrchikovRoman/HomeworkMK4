namespace ModuleDAL.Migrations
{
    using ModuleDAL.Entities;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MyContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
            ContextKey = "BlogDAL.MyContext";
        }
        public class MyContextInitializer : CreateDatabaseIfNotExists<MyContext>
        {
            protected override void Seed(MyContext context)
            {
                context.Products.Add(new Product { Id = 1, Name = "Iphone 6s", Price = 4250, CategoryId = 1 });
                context.Products.Add(new Product { Id = 2, Name = "Dell Inspirion 5737", Price = 35000, CategoryId = 2 });
                context.Products.Add(new Product { Id = 3, Name = "Xaomi", Price = 1500, CategoryId = 1 });
                context.Products.Add(new Product { Id = 4, Name = "VW Passat b5+", Price = 250000, CategoryId = 3 });

                context.Categories.Add(new Category { Id = 1, Name = "Phone" });
                context.Categories.Add(new Category { Id = 2, Name = "Laptop" });
                context.Categories.Add(new Category { Id = 3, Name = "Auto" });
            }
        }

    }
}
