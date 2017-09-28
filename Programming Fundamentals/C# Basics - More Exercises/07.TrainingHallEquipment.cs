using System;

namespace _07.TrainingHallEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int countOfItems = int.Parse(Console.ReadLine());
            double totalBudget = 0;
            for (int i = 0; i < countOfItems; i++)
            {
                string itemName = Console.ReadLine();
                double itemPrice = double.Parse(Console.ReadLine());
                int itemQuantity = int.Parse(Console.ReadLine());
                if (itemQuantity > 1)
                {
                    Console.WriteLine($"Adding {itemQuantity} {itemName}s to cart.");
                }
                else
                {
                    Console.WriteLine($"Adding {itemQuantity} {itemName} to cart.");
                }
                totalBudget += itemPrice * itemQuantity;
            }
            if (budget >= totalBudget)
            {
                Console.WriteLine($"Subtotal: ${totalBudget:f2}");
                Console.WriteLine($"Money left: ${budget - totalBudget:f2}");
            }
            else
            {
                Console.WriteLine($"Subtotal: ${totalBudget:f2}");
                Console.WriteLine($"Not enough. We need ${totalBudget - budget:f2} more.");
            }
        }
    }
}