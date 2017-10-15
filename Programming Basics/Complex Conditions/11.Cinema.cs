using System;

namespace _11.Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeProjection = Console.ReadLine();
            double r = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            double premierePrice = 12.00;
            double normalPrice = 7.50;
            double discountPrice = 5.00;

            if (typeProjection == "Premiere")
            {
                double result = premierePrice * r * c;
                Console.WriteLine($"{result:f2} leva");
            }
            else if (typeProjection == "Normal")
            {
                double result = normalPrice * r * c;
                Console.WriteLine($"{result:f2} leva");
            }
            else if (typeProjection == "Discount")
            {
                double result = discountPrice * r * c;
                Console.WriteLine($"{result:f2} leva");
            }
            else
                Console.WriteLine("You have entered an invalid type of projection.");
        }
    }
}