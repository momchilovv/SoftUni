using System;

namespace _06.BonusScore
{
    class Program
    {
        static void Main(string[] args)
        {
            double score = double.Parse(Console.ReadLine());
            double bonusScore = 0;
            
            if (score <= 100)
            {
                bonusScore += 5;
                if (score % 10 == 5)
                {
                    bonusScore += 2;
                }
                if (score % 2 == 0)
                {
                    bonusScore += 1;
                }
            }
            if (score > 100 && score <= 1000)
            {
                bonusScore += score * 0.20;
                if (score % 10 == 5)
                {
                    bonusScore += 2;
                }
                if (score % 2 == 0)
                {
                    bonusScore += 1;
                }
            }
            if (score > 1000)
            {
                bonusScore += score * 0.10;
                if (score % 10 == 5)
                {
                    bonusScore += 2;
                }
                if (score % 2 == 0)
                {
                    bonusScore += 1;
                }
            }
            Console.WriteLine($"{bonusScore}");
            Console.WriteLine($"{bonusScore + score}");
        }
    }
}