using System;

class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        double coins = 0;

        while (input != "Start")
        {
            if (input == "0.1" || input == "0.2" || input == "0.5" || input == "1" || input == "2")
            {
                coins += double.Parse(input);
            }
            else
            {
                Console.WriteLine($"Cannot accept {input}");
            }
            input = Console.ReadLine();
        }

        input = Console.ReadLine();

        while (input != "End")
        {
            switch (input)
            {
                case "Nuts":
                    if (coins >= 2.0)
                    {
                        coins -= 2.0;
                        Console.WriteLine($"Purchased {input.ToLower()}");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                    break;
                case "Water":
                    if (coins >= 0.7)
                    {
                        coins -= 0.7;
                        Console.WriteLine($"Purchased {input.ToLower()}");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                    break;
                case "Crisps":
                    if (coins >= 1.5)
                    {
                        coins -= 1.5;
                        Console.WriteLine($"Purchased {input.ToLower()}");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                    break;
                case "Soda":
                    if (coins >= 0.8)
                    {
                        coins -= 0.8;
                        Console.WriteLine($"Purchased {input.ToLower()}");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                    break;
                case "Coke":
                    if (coins >= 1.0)
                    {
                        coins -= 1.0;
                        Console.WriteLine($"Purchased {input.ToLower()}");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                    break;
                default:
                    Console.WriteLine("Invalid product");
                    break;
            }
            input = Console.ReadLine();
        }
        Console.WriteLine($"Change: {coins:f2}");
    }
}