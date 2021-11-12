using System;

namespace Demo.Solid.Model
{
    public class Product
    {
        public string Name { get; set; }

        public decimal? Price { get; set; }
        private const decimal DESCONTO_PADRAO = .3m;
        public Product(string name, decimal price)
        {
            Name = name ?? throw new ArgumentNullException();
            Price = price;
        }

        public virtual void AplicarDesconto()
        {
            Price *= DESCONTO_PADRAO;
        }
    }
}



