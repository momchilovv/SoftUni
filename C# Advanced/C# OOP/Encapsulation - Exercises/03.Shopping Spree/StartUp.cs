using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingSpree
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            List<Product> products = new List<Product>();

            string[] peopleInfo = Console.ReadLine()
                .Split(";", StringSplitOptions.RemoveEmptyEntries);

            string[] productsInfo = Console.ReadLine()
                .Split(";", StringSplitOptions.RemoveEmptyEntries);

            foreach (var p in peopleInfo)
            {
                string name = p.Split("=").First();
                decimal money = p.Split("=").Select(decimal.Parse).Last();

                try
                {
                    Person person = new Person(name, money);
                    people.Add(person);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                    Environment.Exit(0);
                }
            }

            foreach (var p in productsInfo)
            {
                string name = p.Split("=").First();
                decimal cost = p.Split("=").Select(decimal.Parse).Last();

                try
                {
                    Product product = new Product(name, cost);
                    products.Add(product);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                    Environment.Exit(0);
                }
            }

            string[] command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            while (command[0] != "END")
            {
                Person person = people.FirstOrDefault(n => n.Name == command[0]);

                person.AddProduct(products.FirstOrDefault(n => n.Name == command[1]));

                command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }

            foreach (var person in people)
            {
                Console.WriteLine(person.ToString());
            }
        }
    }
}