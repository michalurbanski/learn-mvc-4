namespace TestWebApplication.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using TestWebApplication.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<TestWebApplication.Models.MovieDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(TestWebApplication.Models.MovieDBContext context)
        {
            //  This method will be called after migrating to the latest version.

            context.Movies.AddOrUpdate(s => s.Title,
                new Movie
                {
                    Title = "Rio Bravo", 
                    ReleaseDate = DateTime.Parse("1959-4-15"), 
                    Genre = "Western",
                    Price = 3.99M, 
                    Rating = "G"
                });

        }
    }
}
