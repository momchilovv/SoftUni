using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        long input = long.Parse(Console.ReadLine());
        long inputDouble = 0;
        inputDouble = input;
        long immuneSystemHealth = 0;
        immuneSystemHealth = inputDouble;
        var virus = Console.ReadLine().ToList();

        var foughtVirusesDict = new Dictionary<string, long>();

        while (string.Join("", virus) != "end")
        {
            long virusStrenghtCalculated = 0;
            long virusTimeToDefeatSeconds = 0;
            string virusTimeToDeafeatMinutesFormatted = string.Empty;

            for (int i = 0; i < virus.Count; i++)
            {
                virusStrenghtCalculated += virus[i];
            }

            virusStrenghtCalculated /= 3;
            virusTimeToDefeatSeconds = virusStrenghtCalculated * virus.Count();
        
            if (!foughtVirusesDict.ContainsKey(string.Join("", virus)))
            {
                foughtVirusesDict[string.Join("", virus)] = virusTimeToDefeatSeconds;
            }
            else
            {
                virusTimeToDefeatSeconds = foughtVirusesDict[string.Join("", virus)] / 3;
            }

            double seconds = virusTimeToDefeatSeconds % 60;
            double minutes = virusTimeToDefeatSeconds / 60;
            Convert.ToInt32(immuneSystemHealth);
            immuneSystemHealth -= virusTimeToDefeatSeconds;

            if (immuneSystemHealth > 0)
            {
                Console.WriteLine($"Virus {string.Join("", virus)}: {virusStrenghtCalculated} => {virusTimeToDefeatSeconds} seconds" +
                                  $"\n{string.Join("", virus)} defeated in {minutes}m {seconds}s.\nRemaining health: {immuneSystemHealth}");
                var percentCalculation = +immuneSystemHealth * 0.20;
                immuneSystemHealth += (long)percentCalculation;
                if (immuneSystemHealth > inputDouble)
                {
                    immuneSystemHealth = inputDouble;
                }
            }
            else
            {
                Console.WriteLine($"Virus {string.Join("", virus)}: {virusStrenghtCalculated} => {virusTimeToDefeatSeconds} seconds");
                Console.WriteLine("Immune System Defeated.");
                return;
            }
            virus = Console.ReadLine().ToList();
        }
        Console.WriteLine($"Final Health: {immuneSystemHealth}");
    }
}