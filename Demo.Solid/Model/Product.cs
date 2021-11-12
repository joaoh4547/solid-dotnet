using System;

namespace Demo.Solid.Model
{
    public class Product
    {
        public string Name { get; set; }

        public decimal? Price { get; set; }
        public Product(string name, decimal price)
        {
            Name = name ?? throw new ArgumentNullException();
            Price = price;
        }

    }
}



