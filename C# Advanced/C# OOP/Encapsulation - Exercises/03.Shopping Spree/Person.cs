using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingSpree
{
    public class Person
    {
        private string name;
        private decimal money;
        private List<Product> bagOfProducts;

        public Person(string name, decimal money)
        {
            Name = name;
            Money = money;
            bagOfProducts = new List<Product>();
        }
        public List<Product> BagOfProducts => bagOfProducts;

        public string Name
        {
            get { return name; }
            private set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be empty");
                }
                name = value;
            }
        }
        public decimal Money
        {
            get { return money; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Money cannot be negative");
                }
                money = value;
            }
        }

        public void AddProduct(Product product)
        {
            if (product.Cost > money)
            {
                Console.WriteLine($"{Name} can't afford {product.Name}");
                return;
            }

            bagOfProducts.Add(product);
            money -= product.Cost;

            Console.WriteLine($"{Name} bought {product.Name}");
        }

        public override string ToString()
        {
            if (bagOfProducts.Count == 0)
            {
                return $"{Name} - Nothing bought";
            }

            return $"{Name} - {string.Join(", ", bagOfProducts.Select(n => n.Name))}";
        }
    }
}