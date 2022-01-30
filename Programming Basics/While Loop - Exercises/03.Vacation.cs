using System;

class Program
{
    static void Main(string[] args)
    {
        double vacationCost = double.Parse(Console.ReadLine());
        double money = double.Parse(Console.ReadLine());

        string action = null;
        double amount = 0;

        int days = 0;
        int spendRow = 0;

        bool run = true;

        while (run == true)
        {
            action = Console.ReadLine();
            amount = double.Parse(Console.ReadLine());

            days++;


            if (action == "spend")
            {
                spendRow++;
                if (spendRow == 5)
                {
                    Console.WriteLine($"You can't save the money.");
                    Console.WriteLine(days);
                    System.Environment.Exit(0);
                }
            }
            else         
                spendRow = 0;

            if (action == "spend")
            {
                money -= amount;
                if (money < 0)
                {
                    money = 0;
                }
            }
            else if (action == "save")
            {
                money += amount;
            }

            if (money > vacationCost || money == vacationCost)
            {
                run = false;
            }
        }
        Console.WriteLine($"You saved the money for {days} days.");
    }
}