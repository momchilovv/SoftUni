using System;

namespace _15.NeighbourWars
{
    class Program
    {
        static void Main(string[] args)
        {
            int damageOfPesho = int.Parse(Console.ReadLine());
            int damageOfGosho = int.Parse(Console.ReadLine());

            int peshoHealth = 100;
            int goshoHealth = 100;

            bool isPeshoAlive = peshoHealth >= 0;
            bool isGoshoAlive = goshoHealth >= 0;

            string winner = string.Empty;

            int round = 1;

            while (isPeshoAlive || isGoshoAlive)
            {
                if (round % 2 == 0)
                {
                    peshoHealth -= damageOfGosho;

                    if (peshoHealth > 0)
                    {
                        Console.WriteLine($"Gosho used Thunderous fist and reduced Pesho to {peshoHealth} health.");
                    }

                    else
                    {
                        winner = "Gosho";
                        break;
                    }
                }

                else
                {
                    goshoHealth -= damageOfPesho;

                    if (goshoHealth > 0)
                    {
                        Console.WriteLine($"Pesho used Roundhouse kick and reduced Gosho to {goshoHealth} health.");
                    }

                    else
                    {
                        winner = "Pesho";
                        break;
                    }
                }

                if (round % 3 == 0)
                {
                    goshoHealth += 10;
                    peshoHealth += 10;
                }

                round++;
            }

            Console.WriteLine($"{winner} won in {round}th round.");
        }
    }
}