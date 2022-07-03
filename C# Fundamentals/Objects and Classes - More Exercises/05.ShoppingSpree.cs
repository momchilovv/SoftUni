using System;
using System.Collections.Generic;
using System.Linq;

class Person
{
    public string Name { get; set; }
    
    public double Money { get; set; }

    public List<string> Product = new List<string>();
}

class Product
{
    public string Name { get; set; }

    public double Cost { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        List<Person> people = new List<Person>();
        List<Product> products = new List<Product>();
        Person person = new Person();
        Product product = new Product();

        string[] inputPerson = Console.ReadLine().Split(";");
        
        for (int i = 0; i < inputPerson.Length; i++)
        {
            string[] name = inputPerson[i].Split("=", StringSplitOptions.RemoveEmptyEntries);

            person = new Person()
            {
                Name = name[0],
                Money = double.Parse(name[1])
            };
            people.Add(person);
        }
        
        string[] inputProduct = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries);    

        for (int i = 0; i < inputProduct.Length; i++)
        {
            string[] pr = inputProduct[i].Split("=");

            product = new Product()
            {
                Name = pr[0],
                Cost = double.Parse(pr[1])
            };
            products.Add(product);
        }

        string[] input = Console.ReadLine().Split();

        while (input[0] != "END")
        {
            string per = input[0], prod = input[1];

            foreach (var p in people.Where(p => p.Name == per))
            {
                foreach (var pr in products.Where(p => p.Name == prod))
                {
                    if (p.Money >= pr.Cost)
                    {
                        Console.WriteLine($"{p.Name} bought {pr.Name}");
                        p.Money -= pr.Cost;
                        p.Product.Add(pr.Name);
                    }
                    else if (pr.Cost > p.Money)
                    {
                        Console.WriteLine($"{p.Name} can't afford {pr.Name}");
                    }
                    break;
                }
                break;
            }
            input = Console.ReadLine().Split();
        }

        foreach (var pr in people.Where(p => p.Product.Count > 0))
        {
            Console.Write($"{pr.Name} - ");
            Console.WriteLine(string.Join(", ", pr.Product));
        }
        foreach (var pr in people.Where(p => p.Product.Count <= 0))
        {
            Console.WriteLine($"{pr.Name} - Nothing bought");
        }     
    }
}