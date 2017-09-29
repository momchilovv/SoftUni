using System;

namespace _12.CurrencyConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            double cash = double.Parse(Console.ReadLine());
            string entry = Console.ReadLine();
            string exit = Console.ReadLine();

            double oneDollar = 1.79549;
            double oneEuro = 1.95583;
            double oneLev = 1;
            double onePound = 2.53405;

            switch (entry)
            {
                case "USD":
                    if (exit == "BGN")
                    {
                        Console.WriteLine($"{cash * (oneDollar * oneLev):f2} BGN");
                    }
                    else if (exit == "EUR")
                    {
                        Console.WriteLine($"{cash * (oneDollar / oneEuro):f2} EUR");
                    }
                    else if (exit == "GBP")
                    {
                        Console.WriteLine($"{cash * (oneDollar / onePound):f2} GBP");
                    }
                    break;
                case "EUR":
                    if (exit == "GBP")
                    {
                        Console.WriteLine($"{cash * (oneEuro / onePound):f2} GBP");
                    }
                    else if (exit == "BGN")
                    {
                        Console.WriteLine($"{cash * (oneEuro * oneLev):f2} BGN");
                    }
                    else if (exit == "USD")
                    {
                        Console.WriteLine($"{cash * (oneEuro / oneDollar):f2} USD");
                    }
                    break;
                case "BGN":
                    if (exit == "GBP")
                    {
                        Console.WriteLine($"{cash * (oneLev / onePound):f2} GBP");
                    }
                    else if (exit == "USD")
                    {
                        Console.WriteLine($"{cash * (oneLev / oneDollar):f2} USD");
                    }
                    else if (exit == "EUR")
                    {
                        Console.WriteLine($"{cash * (oneLev / oneEuro):f2} EUR");
                    }
                    break;
                case "GBP":
                    if (exit == "USD")
                    {
                        Console.WriteLine($"{cash * (onePound / oneDollar):f2} USD");
                    }
                    else if (exit == "BGN")
                    {
                        Console.WriteLine($"{cash * (onePound * oneLev):f2} BGN");
                    }
                    else if (exit == "EUR")
                    {
                        Console.WriteLine($"{cash * (onePound / oneEuro):f2} EUR");
                    }
                    break;
            }
        }
    }
}