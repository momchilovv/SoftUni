using System;

namespace _02.ChooseADrink2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            double coffeePrice = 1.00;
            double waterPrice = 0.70;
            double teaPrice = 1.20;
            double beerPrice = 1.70;

            double totalPrice = 0;

            string profession = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            if (profession == "Athlete")
            {
                totalPrice = waterPrice * quantity;
                Console.WriteLine($"The {profession} has to pay {totalPrice:f2}.");
            }
            else if (profession == "SoftUni Student")
            {
                totalPrice = beerPrice * quantity;
                Console.WriteLine($"The {profession} has to pay {totalPrice:f2}.");
            }
            else if (profession == "Businessman" || profession == "Businesswoman")
            {
                totalPrice = coffeePrice * quantity;
                Console.WriteLine($"The {profession} has to pay {totalPrice:f2}.");
            }
            else
            {
                totalPrice = teaPrice * quantity;
                Console.WriteLine($"The {profession} has to pay {totalPrice:f2}.");
            }
        }
    }
}
