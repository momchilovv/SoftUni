using System;

namespace _01.ChooseADrink
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            switch (input)
            {
                case "Businessman":
                    Console.WriteLine("Coffee");
                    break;
                case "Businesswoman":
                    Console.WriteLine("Coffee");
                    break;
                case "Athlete":
                    Console.WriteLine("Water");
                    break;
                case "SoftUni Student":
                    Console.WriteLine("Beer");
                    break;
                default:
                    Console.WriteLine("Tea");
                    break;
            }
        }
    }
}
