using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace BuildSite.Models
{
    public class DataBase : DbContext
    {
        public DbSet<Item> Items { get; set; }
        public DbSet<Build> Builds { get; set; }
        public DbSet<Officiality> Officialities { get; set; }
    }
}