using System;

namespace _04.FruitOrVegetable
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();

            if (type == "banana" || type == "apple" || type == "kiwi" || type == "cherry"
                || type == "lemon" || type == "grapes")
                Console.WriteLine("fruit");
            else if (type == "cucumber" || type == "tomato" || type == "carrot" || type == "pepper")
                Console.WriteLine("vegetable");
            else
                Console.WriteLine("unknown");
        }
    }
}