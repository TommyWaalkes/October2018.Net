using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StateManagement.Models
{
    public class Toy
    {
        public string Name { get; set; }
        public double Weight { get; set; }
        public double Price { get; set; }
        public bool IsBroken { get; set; }

        public Toy (string Name, double Weight, double Price, bool IsBroken)
        {
            this.Name = Name;
            this.Weight = Weight;
            this.Price = Price;
            this.IsBroken = IsBroken;
        }
    }
}