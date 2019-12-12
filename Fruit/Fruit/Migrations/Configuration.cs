namespace Fruit.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Fruit.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<Fruit.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Fruit.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            //context.MainPage.AddOrUpdate(x => x.Id,
            //    new MainPage() { Title = "შესავსები ველი", Subtitle = "შესავსები ველი" },
            //    new MainPage() { Title = "შესავსები ველი", Subtitle = "შესავსები ველი" },
            //    new MainPage() { Title = "შესავსები ველი", Subtitle = "შესავსები ველი" },
            //    new MainPage() { Title = "შესავსები ველი", Subtitle = "შესავსები ველი" },
            //    new MainPage() { Title = "შესავსები ველი", Subtitle = "შესავსები ველი" },
            //    new MainPage() { Title = "შესავსები ველი", Subtitle = "შესავსები ველი" },
            //    new MainPage() { Title = "შესავსები ველი", Subtitle = "შესავსები ველი" },
            //    new MainPage() { Title = "შესავსები ველი", Subtitle = "შესავსები ველი" }
            //    );

            //context.Ingredient.AddOrUpdate(x => x.Id,
            //    new Ingredient() { Name = "შესავსები" },
            //    new Ingredient() { Name = "შესავსები" },
            //    new Ingredient() { Name = "შესავსები" }
            //    );
        }
    }
}
