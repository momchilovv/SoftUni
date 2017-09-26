using System;

namespace _02.VaporStore
{
    class Program
    {
        static void Main(string[] args)
        {
            double ballance = double.Parse(Console.ReadLine());
            double spent = 0.0;

            while (true)
            {
                if (ballance == 0)
                {
                    Console.WriteLine("Out of money!");
                    break;
                }
                string input = Console.ReadLine();
                if (input.Equals("Game Time"))
                {
                    Console.WriteLine($"Total spent: ${spent:F2}. Remaining: ${ballance:F2}");
                    break;
                }
                switch (input)
                {
                    case "OutFall 4":
                        double price1 = 39.99;
                        if (ballance >= price1)
                        {
                            ballance -= price1;
                            spent += price1;
                            Console.WriteLine($"Bought {input}");
                        }
                        else if (ballance > 0 && ballance < price1)
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;
                    case "CS: OG":
                        double price2 = 15.99;
                        if (ballance >= price2)
                        {
                            ballance -= price2;
                            spent += price2;
                            Console.WriteLine($"Bought {input}");
                        }
                        else if (ballance > 0 && ballance < price2)
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;
                    case "Zplinter Zell":
                        double price3 = 19.99;
                        if (ballance >= price3)
                        {
                            ballance -= price3;
                            spent += price3;
                            Console.WriteLine($"Bought {input}");
                        }
                        else if (ballance > 0 && ballance < price3)
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;
                    case "Honored 2":
                        double price4 = 59.99;
                        if (ballance >= price4)
                        {
                            ballance -= price4;
                            spent += price4;
                            Console.WriteLine($"Bought {input}");
                        }
                        else if (ballance > 0 && ballance < price4)
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;
                    case "RoverWatch":
                        double price5 = 29.99;
                        if (ballance >= price5)
                        {
                            ballance -= price5;
                            spent += price5;
                            Console.WriteLine($"Bought {input}");
                        }
                        else if (ballance > 0 && ballance < price5)
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;
                    case "RoverWatch Origins Edition":
                        double price6 = 39.99;
                        if (ballance >= price6)
                        {
                            ballance -= price6;
                            spent += price6;
                            Console.WriteLine($"Bought {input}");
                        }
                        else if (ballance > 0 && ballance < price6)
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;
                    default:
                        Console.WriteLine("Not Found");
                        break;
                }
            }

        }
    }
}