using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CodeFirstTest.Models
{
    public class Cat
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Breed { get; set; }
        public int Age { get; set; }
    }
    public class Dog
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }

    public class CatContext : DbContext
    {
        public DbSet<Cat> Cats { get; set; }
        public DbSet<Dog> Dogs { get; set; }
    }
}