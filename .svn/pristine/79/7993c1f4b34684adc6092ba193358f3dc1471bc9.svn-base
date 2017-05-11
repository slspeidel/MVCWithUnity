namespace MVCWithUnity.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using MVCWithUnity.Domain;

    internal sealed class Configuration : DbMigrationsConfiguration<MVCWithUnity.Infrastructure.ItemDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(MVCWithUnity.Infrastructure.ItemDb context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            context.Items.AddOrUpdate(
              p => p.ItemName,
              new ItemClass { ItemName = "Dragon", ItemPrice = "1.5M" },
              new ItemClass { ItemName = "Hammer", ItemPrice = "15.00" },
              new ItemClass { ItemName = "Pickle", ItemPrice = "1.00" }
            );
            context.OtherItems.AddOrUpdate(
              p => p.OtherItemName,
              new OtherItemClass { OtherItemName = "Dragon Egg Incubator", OtherItemPrice = "1000" },
              new OtherItemClass { OtherItemName = "Dragon Egg Bowling Game", OtherItemPrice = "15.00" },
              new OtherItemClass { OtherItemName = "Dragon Egg Omelette Recipe", OtherItemPrice = "2.00" }
            );
            //
        }
    }
}
