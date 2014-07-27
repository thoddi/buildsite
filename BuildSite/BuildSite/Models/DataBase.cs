using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace BuildSite.Models
{
    public class DataBase : DbContext
    {
        // Allir hlutir sem til eru
        public DbSet<Item> Items { get; set; }
        // Öll build sem til eru
        public DbSet<Build> Builds { get; set; }
        // Listi yfir öll build-in og hvort þau eru official eða ekki
        public DbSet<Officiality> Officialities { get; set; }
    }
}