using System;

namespace _12.Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            double p = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            if (type == "normal")
            {
                double weekends = 48;
                double inSofia = weekends - h;
                double gamesSofia = inSofia * 3.0 / 4;
                double holidays = p * 2.0 / 3;
                double allGames = gamesSofia + holidays + h;

                double result = Math.Truncate(allGames);
                Console.WriteLine(result);
            }
            else if (type == "leap")
            {
                double weekends = 48;
                double inSofia = weekends - h;
                double gamesSofia = inSofia * 3.0 / 4;
                double holidays = p * 2.0 / 3;
                double allGames = gamesSofia + holidays + h;
                double afterBonus = allGames * 0.15;
                double finalResult = allGames + afterBonus;

                double result = Math.Truncate(finalResult);
                Console.WriteLine(result);
            }
        }
    }
}