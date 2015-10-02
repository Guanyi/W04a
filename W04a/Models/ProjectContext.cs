using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace W04a.Models
{
    public class ProjectContext: DbContext
    {
        public ProjectContext() : base("DefaultConnection") { }

        public DbSet<City> Cities { get; set; }

        public DbSet<Province> Provinces { get; set; }
    }
}