using System;

namespace _03.RestaurantDiscount
{
    class Program
    {
        static void Main(string[] args)
        {
            int peopleCount = int.Parse(Console.ReadLine());
            string package = Console.ReadLine();

            double smallHallPrice = 2500;
            double terracePrice = 5000;
            double greatHallPrice = 7500;

            double normalPrice = 500;

            double goldPrice = 750;

            double platinumPrice = 1000;

            double totalPrice = 0;
            double pricePerPerson = 0;

            if (peopleCount <= 50)
            {
                if (package == "Normal")
                {
                    totalPrice = (normalPrice + smallHallPrice) * 0.95;
                    pricePerPerson = totalPrice / peopleCount;
                    Console.WriteLine($"We can offer you the Small Hall\nThe price per person is {pricePerPerson:f2}$");
                }
                else if (package == "Gold")
                {
                    totalPrice = (goldPrice + smallHallPrice) * 0.90;
                    pricePerPerson = totalPrice / peopleCount;
                    Console.WriteLine($"We can offer you the Small Hall\nThe price per person is {pricePerPerson:f2}$");
                }
                else if (package == "Platinum")
                {
                    totalPrice = (platinumPrice + smallHallPrice) * 0.85;
                    pricePerPerson = totalPrice / peopleCount;
                    Console.WriteLine($"We can offer you the Small Hall\nThe price per person is {pricePerPerson:f2}$");
                }
            }
            else if (peopleCount > 50 && peopleCount <= 100)
            {
                if (package == "Normal")
                {
                    totalPrice = (normalPrice + terracePrice) * 0.95;
                    pricePerPerson = totalPrice / peopleCount;
                    Console.WriteLine($"We can offer you the Terrace\nThe price per person is {pricePerPerson:f2}$");
                }
                else if (package == "Gold")
                {
                    totalPrice = (goldPrice + terracePrice) * 0.90;
                    pricePerPerson = totalPrice / peopleCount;
                    Console.WriteLine($"We can offer you the Terrace\nThe price per person is {pricePerPerson:f2}$");
                }
                else if (package == "Platinum")
                {
                    totalPrice = (platinumPrice + terracePrice) * 0.85;
                    pricePerPerson = totalPrice / peopleCount;
                    Console.WriteLine($"We can offer you the Terrace\nThe price per person is {pricePerPerson:f2}$");
                }
            }
            else if (peopleCount > 100 && peopleCount <= 120)
            {
                if (package == "Normal")
                {
                    totalPrice = (normalPrice + greatHallPrice) * 0.95;
                    pricePerPerson = totalPrice / peopleCount;
                    Console.WriteLine($"We can offer you the Great Hall\nThe price per person is {pricePerPerson:f2}$");
                }
                else if (package == "Gold")
                {
                    totalPrice = (goldPrice + greatHallPrice) * 0.90;
                    pricePerPerson = totalPrice / peopleCount;
                    Console.WriteLine($"We can offer you the Geat Hall\nThe price per person is {pricePerPerson:f2}$");
                }
                else if (package == "Platinum")
                {
                    totalPrice = (platinumPrice + greatHallPrice) * 0.85;
                    pricePerPerson = totalPrice / peopleCount;
                    Console.WriteLine($"We can offer you the Great Hall\nThe price per person is {pricePerPerson:f2}$");
                }
            }
            else if (peopleCount > 120)
            {
                Console.WriteLine("We do not have an appropriate hall.");
            }
        }
    }
}