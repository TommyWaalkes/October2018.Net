using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EntityExample.Models
{
    public class Item
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }
    }

    public class DBItemContext : DbContext
    {
        public DbSet<Item> Items { get; set; }
    }
}