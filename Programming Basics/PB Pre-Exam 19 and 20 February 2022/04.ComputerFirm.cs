using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        double totalSales = 0;

        List<double> ratingList = new List<double>();

        for (int i = 0; i < n; i++)
        {
            double number = int.Parse(Console.ReadLine());

            double rating = number % 10;
            ratingList.Add(rating);
            double sales = (number - number % 10) / 10; 

            switch (rating)
            {
                case 3:
                    totalSales += sales * 0.50;
                    break;
                case 4:
                    totalSales += sales * 0.70;
                    break;
                case 5:
                    totalSales += sales * 0.85;
                    break;
                case 6:
                    totalSales += sales;
                    break;
            }
        }
        Console.WriteLine($"{totalSales:f2}");
        Console.WriteLine($"{ratingList.Average():f2}");
    }
}