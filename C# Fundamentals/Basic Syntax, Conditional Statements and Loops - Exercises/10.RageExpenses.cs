using System;

class Program
{
    static void Main(string[] args)
    {
        int lostGames = int.Parse(Console.ReadLine());
        double headsetPrice = double.Parse(Console.ReadLine());
        double mousePrice = double.Parse(Console.ReadLine());
        double keyboardPrice = double.Parse(Console.ReadLine());
        double displayPrice = double.Parse(Console.ReadLine());

        int headsetsTrashed = 0;
        int mousesTrashed = 0;
        int keyboardsTrashed = 0;
        int displaysTrashed = 0;

        for (int i = 1; i <= lostGames; i++)
        {
            if (i % 2 == 0)
            {
                headsetsTrashed++;
            }
            if (i % 3 == 0)
            {
                mousesTrashed++;
            }
            if (i % 2 == 0 && i % 3 == 0)
            {
                keyboardsTrashed++;
                if (keyboardsTrashed % 2 == 0)
                {
                    displaysTrashed++;
                }
            }
        }

        double expenses = (headsetsTrashed * headsetPrice) + (mousesTrashed * mousePrice) + (keyboardsTrashed * keyboardPrice)
            + (displaysTrashed * displayPrice);

        Console.WriteLine($"Rage expenses: {expenses:f2} lv.");
    }
}