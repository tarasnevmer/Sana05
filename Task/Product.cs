using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    public class Product
    {
        protected string Name { get; set; }
        protected double Price { get; set; }
        protected Currency Cost { get; set; }
        protected int Quantity { get; set; }
        protected string Producer { get; set; }
        protected double Weight { get; set; }

        public Product()
        {
            
        }
        public Product(string name, double price, Currency cost, int quantity, string producer, double weight)
        {
            Name = name;
            Price = price;
            Cost = cost;
            Quantity = quantity;
            Producer = producer;
            Weight = weight;
        }

        public Product(Product otherProduct)
        {
            Name = otherProduct.Name;
            Price = otherProduct.Price;
            Cost = new Currency(otherProduct.Cost); 
            Quantity = otherProduct.Quantity;
            Producer = otherProduct.Producer;
            Weight = otherProduct.Weight;
        }

        public double GetPriceInUAH()
        {
            return Price * Cost.ExRate;
        }

        public double GetTotalPriceInUAH()
        {
            return Quantity * GetPriceInUAH();
        }

        public double GetTotalWeight()
        {
            return Quantity * Weight;
        }

    }
}
