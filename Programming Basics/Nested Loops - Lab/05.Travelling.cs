using System;

class Program
{
    static void Main(string[] args)
    {
        string destination = Console.ReadLine();

        while (destination != "End" )
        {
            double neededMoney = double.Parse(Console.ReadLine());

            while (neededMoney > 0)
            {
                neededMoney -= double.Parse(Console.ReadLine());
            }
            Console.WriteLine($"Going to {destination}!");
            destination = Console.ReadLine();            
        }
    }
}