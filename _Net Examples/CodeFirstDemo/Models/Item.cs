using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace CodeFirstDemo.Models
{
    public class Item
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public int Stock { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public int Sold { get; set; }

    }

    public class DBItemContext : DbContext
    {
        public DbSet<Item> Items { get; set; }
    }
}