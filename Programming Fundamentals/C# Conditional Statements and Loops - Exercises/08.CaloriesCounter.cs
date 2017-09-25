using System;

namespace _08.CaloriesCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            int cheeseC = 500;
            int tSauceC = 150;
            int salamiC = 600;
            int pepperC = 50;

            int totalAmount = 0;

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine().ToLower();
                if (input == "cheese")
                {
                    totalAmount += cheeseC;
                }
                else if (input == "tomato sauce")
                {
                    totalAmount += tSauceC;
                }
                else if (input == "salami")
                {
                    totalAmount += salamiC;
                }
                else if (input == "pepper")
                {
                    totalAmount += pepperC;
                }
            }
            Console.WriteLine($"Total calories: {totalAmount}");
        }
    }
}