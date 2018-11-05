using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCIntro.Models
{
    public class ProductList
    {
        //So one note before we begin, data can come from APIs, Databases, or right in the C# code 
        //This acts more as an example, once we learn Databases and APIs data will usually come from 
        //Databases and/or APIs

        //More on that later! 

        public List<Product> Products { get; set; }

        public ProductList()
        {
            Products = new List<Product>();
            Products.Add(new Product("Squeegee", "It wipes windows", 20, 1.00));
            Products.Add(new Product("Diet Coke", "The classic cola", 12, 1.50));
            Products.Add(new Product("Luigi Squeegee", "It wipes windows in absolute style", 2, 10.00));
        }

        //Create
        public void Add(Product p)
        {
            Products.Add(p);
        }

        //Update
        public void UpdateProduct(int index, Product p)
        {
            if (Products.Contains(p))
            {
                if (p != null)
                {
                    if (index > 0 && index < Products.Count)
                    {
                        Product product = Products[index];
                    }
                }
            }
            
           
        }
        
        //Destroy
        public void DeleteProdcut(int index)
        {
            Products.RemoveAt(index);
        }

        public Product GetProductAt(int index)
        {
            if(index <0 || index > Products.Count)
            {
                return null;
            }
            else
            {
                return Products[index];
            }
        }
    }
}