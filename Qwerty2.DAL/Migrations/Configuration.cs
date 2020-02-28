using Qwerty2.Entities;

namespace Qwerty2.DAL.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Qwerty2.DAL.Database.ProjectContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Qwerty2.DAL.Database.ProjectContext context)
        {
            if (!context.AboutPage.Any())
            {
                var aboutPage = new AboutPage
                {
                    TitleName = "Örnek Baþlýk",
                    AboutDescription = "Seed ile gelen içerik"
                };

                context.AboutPage.Add(aboutPage);
                context.SaveChanges();
            }
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
