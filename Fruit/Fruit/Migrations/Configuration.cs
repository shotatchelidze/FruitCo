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

            context.Information.AddOrUpdate(x => x.Id,
                new Information() { Title = "შესავსები ველი", Subtitle = "შესავსები ველი", Text = "შესავსები ველი" },
                new Information() { Title = "შესავსები ველი", Subtitle = "შესავსები ველი", Text = "შესავსები ველი" },
                new Information() { Title = "შესავსები ველი", Subtitle = "შესავსები ველი", Text = "შესავსები ველი" },
                new Information() { Title = "შესავსები ველი", Subtitle = "შესავსები ველი", Text = "შესავსები ველი" },
                new Information() { Title = "შესავსები ველი", Subtitle = "შესავსები ველი", Text = "შესავსები ველი" },
                new Information() { Title = "შესავსები ველი", Subtitle = "შესავსები ველი", Text = "შესავსები ველი" },
                new Information() { Title = "შესავსები ველი", Subtitle = "შესავსები ველი", Text = "შესავსები ველი" },
                new Information() { Title = "შესავსები ველი", Subtitle = "შესავსები ველი", Text = "შესავსები ველი" }
                );
        }
    }
}
