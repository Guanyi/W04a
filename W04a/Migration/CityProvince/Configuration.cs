namespace W04a.Migration.CityProvince
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using W04a.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<W04a.Models.ProjectContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"Migration\CityProvince";
        }

        protected override void Seed(W04a.Models.ProjectContext context)
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

            List<Province> provinces = new List<Province>();
            provinces.Add( new Province() { ProvinceName = "Alberta" } );
            provinces.Add(new Province() { ProvinceName = "British Columbia" });
            provinces.Add(new Province() { ProvinceName = "Manitoba" });
            provinces.Add(new Province() { ProvinceName = "Ontario" });
            provinces.Add(new Province() { ProvinceName = "Quebec" });
            provinces.Add(new Province() { ProvinceName = "Saskatchewan" });
            provinces.Add(new Province() { ProvinceName = "Nova Scotia" });
            provinces.Add(new Province() { ProvinceName = "New Brunswick" });
            provinces.Add(new Province() { ProvinceName = "Newfoundland and Labrador" });
            provinces.Add(new Province() { ProvinceName = "Prince Edward Island" });
            provinces.Add(new Province() { ProvinceName = "Northwest Territories" });
            provinces.Add(new Province() { ProvinceName = "Yukon" });
            provinces.Add(new Province() { ProvinceName = "Nunavut" });

            context.Provinces.AddRange(provinces);
            context.SaveChanges();

            List<City> cities = new List<City>();
            cities.Add( new City()
            {
                CityName = "Vancouver",
                Population = 400000,
                Province = (provinces.Where(p => p.ProvinceName == "British Columbia").Select(t => t).FirstOrDefault())
            });

            cities.Add(new City()
            {
                CityName = "Burnaby",
                Population = 300000,
                Province = (provinces.Where(p => p.ProvinceName == "British Columbia").Select(t => t).FirstOrDefault())
            });

            cities.Add(new City()
            {
                CityName = "Toronto",
                Population = 1000000,
                Province = (provinces.Where(p => p.ProvinceName == "Ontario").Select(t => t).FirstOrDefault())
            });

            cities.Add(new City()
            {
                CityName = "Edmonton",
                Population = 200000,
                Province = (provinces.Where(p => p.ProvinceName == "Alberta").Select(t => t).FirstOrDefault())
            });

            cities.Add(new City()
            {
                CityName = "Calgary",
                Population = 150000,
                Province = (provinces.Where(p => p.ProvinceName == "Alberta").Select(t => t).FirstOrDefault())
            });

            cities.Add(new City()
            {
                CityName = "Whitehorse",
                Population = 150000,
                Province = (provinces.Where(p => p.ProvinceName == "Yukon").Select(t => t).FirstOrDefault())
            });

            cities.Add(new City()
            {
                CityName = "Winnipeg",
                Population = 180000,
                Province = (provinces.Where(p => p.ProvinceName == "Manitoba").Select(t => t).FirstOrDefault())
            });

            context.Cities.AddRange(cities);
            context.SaveChanges();
        }
    }
}
