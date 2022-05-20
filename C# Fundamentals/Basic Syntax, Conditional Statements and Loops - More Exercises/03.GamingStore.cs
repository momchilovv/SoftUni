using System;

class Program
{
    static void Main(string[] args)
    {
        double currentBalance = double.Parse(Console.ReadLine());
        double balance = currentBalance;
        double totalSpent = 0;

        string input = Console.ReadLine();

        while (input != "Game Time")
        {
            switch (input)
            {
                case "OutFall 4":
                    if (currentBalance >= 39.99)
                    {
                        currentBalance -= 39.99;
                        totalSpent += 39.99;
                        Console.WriteLine($"Bought {input}");
                    }
                    else
                    {
                        Console.WriteLine($"Too Expensive");
                    }
                    break;
                case "CS: OG":
                    if (currentBalance >= 15.99)
                    {
                        currentBalance -= 15.99;
                        totalSpent += 15.99;
                        Console.WriteLine($"Bought {input}");
                    }
                    else
                    {
                        Console.WriteLine($"Too Expensive");
                    }
                    break;
                case "Zplinter Zell":
                    if (currentBalance >= 19.99)
                    {
                        currentBalance -= 19.99;
                        totalSpent += 19.99;
                        Console.WriteLine($"Bought {input}");
                    }
                    else
                    {
                        Console.WriteLine($"Too Expensive");
                    }
                    break;
                case "Honored 2":
                    if (currentBalance >= 59.99)
                    {
                        currentBalance -= 59.99;
                        totalSpent += 59.99;
                        Console.WriteLine($"Bought {input}");
                    }
                    else
                    {
                        Console.WriteLine($"Too Expensive");
                    }
                    break;
                case "RoverWatch":
                    if (currentBalance >= 29.99)
                    {
                        currentBalance -= 29.99;
                        totalSpent += 29.99;
                        Console.WriteLine($"Bought {input}");
                    }
                    else
                    {
                        Console.WriteLine($"Too Expensive");
                    }
                    break;
                case "RoverWatch Origins Edition":
                    if (currentBalance >= 39.99)
                    {
                        currentBalance -= 39.99;
                        totalSpent += 39.99;
                        Console.WriteLine($"Bought {input}");
                    }
                    else
                    {
                        Console.WriteLine($"Too Expensive");
                    }
                    break;
                default:
                    Console.WriteLine("Not Found");
                    break;
            }
            if (currentBalance == 0)
            {
                Console.WriteLine("Out of money!");
                Environment.Exit(0);
            }
            input = Console.ReadLine();
        }
        Console.WriteLine($"Total spent: ${totalSpent:f2}. Remaining: ${Math.Abs(totalSpent - balance):f2}");
    }
}