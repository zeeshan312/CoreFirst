namespace CoreFirst.Migrations.NHL
{
    using CoreFirst.Data;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CoreFirst.Data.NhlContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"Migrations\NHL";
        }

        protected override void Seed(CoreFirst.Data.NhlContext context)
        {
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


            context.countries.AddOrUpdate(
                c => c.Id, DummyData.getCountries().ToArray());
            context.SaveChanges();

            context.Teams.AddOrUpdate(
                t => t.TeamId, DummyData.getTeams().ToArray());
            context.SaveChanges();

            context.Players.AddOrUpdate(
                p => p.PlayerId, DummyData.getPlayers().ToArray());
            context.SaveChanges();


        }
    }
}
