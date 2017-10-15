using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.PopulationCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, Dictionary<string, long>>();

            string city = "";
            string country = "";
            long population = 0;

            while (true)
            {
                var data = Console.ReadLine().Split('|').ToList();
                city = data[0];
                if (city == "report") break;
                country = data[1];
                population = long.Parse(data[2]);

                var eachPopulation = new Dictionary<string, long>();
                if (!dict.ContainsKey(country))
                {
                    eachPopulation[city] = population;
                    dict[country] = eachPopulation;
                }
                else
                {
                    eachPopulation = dict[country];
                    if (eachPopulation.ContainsKey(city))
                        eachPopulation[city] += population;
                    else
                        eachPopulation.Add(city, population);

                    dict[country] = eachPopulation;
                }
            }
            foreach (var each in dict.OrderByDescending(x => x.Value.Sum(y => y.Value)))
            {
                var sumOfCities = each.Value.Select(x => x.Value).ToList();

                Console.WriteLine($"{each.Key} (total population: {sumOfCities.Sum()})");
                Console.Write($"=>{string.Join("=>", each.Value.OrderByDescending(x => x.Value).Select(x => $"{x.Key}: {x.Value}\r\n"))}");
            }
        }
    }
}