using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCIntro.Models
{
    public class Product
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Stock { get; set;  }
        public double Price { get; set; }

        public Product(string Name, String Description, int Stock, double Price)
        {
            this.Name = Name;
            this.Description = Description;
            this.Stock = Stock;
            this.Price = Price;
        }

    }
}