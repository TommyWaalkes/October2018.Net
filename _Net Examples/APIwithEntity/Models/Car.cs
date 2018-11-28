using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace APIwithEntity.Models
{
    public class Car
    {
        public int ID { get; set; }
        public string Make { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
    }

    public class CarContext : DbContext
    {
        public DbSet<Car> Cars { get; set; }
    }
}