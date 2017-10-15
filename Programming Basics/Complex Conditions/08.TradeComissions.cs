using System;

namespace _08.TradeComissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine().ToLower();
            double sales = double.Parse(Console.ReadLine());

            if (town == "plovdiv")
            {
                if (sales >= 0 && sales <= 500)
                    Console.WriteLine($"{sales * 0.055:f2}");
                else if (sales > 500 && sales <= 1000)
                    Console.WriteLine($"{sales * 0.08:f2}");
                else if (sales > 1000 && sales < 10000)
                    Console.WriteLine($"{sales * 0.12:f2}");
                else if (sales > 10000)
                    Console.WriteLine($"{sales * 0.145:f2}");
                else
                    Console.WriteLine("error");
            }
            else if (town == "sofia")
            {
                if (sales >= 0 && sales <= 500)
                    Console.WriteLine($"{sales * 0.05:f2}");
                else if (sales > 500 && sales <= 1000)
                    Console.WriteLine($"{sales * 0.07:f2}");
                else if (sales > 1000 && sales <= 10000)
                    Console.WriteLine($"{sales * 0.08:f2}");
                else if (sales > 10000)
                    Console.WriteLine($"{sales * 0.12:f2}");
                else
                    Console.WriteLine("error");
            }
            else if (town == "varna")
            {
                if (sales >= 0 && sales <= 500)
                    Console.WriteLine($"{sales * 0.045:f2}");
                else if (sales > 500 && sales <= 1000)
                    Console.WriteLine($"{sales * 0.075:f2}");
                else if (sales > 1000 && sales <= 10000)
                    Console.WriteLine($"{sales * 0.10:f2}");
                else if (sales > 10000)
                    Console.WriteLine($"{sales * 0.13:f2}");
                else
                    Console.WriteLine("error");
            }
            else
                Console.WriteLine("error");
        }
    }
}