using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.CitiesByContinentAndCountry
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, List<string>>> dict = new Dictionary<string, Dictionary<string, List<string>>>();

            string[] input;

            for (int i = 0; i < n; i++)
            {
                input = Console.ReadLine().Split().ToArray();
                string continent = input[0];
                string country = input[1];
                string city = input[2];

                if (!dict.ContainsKey(continent))
                    dict[continent] = new Dictionary<string, List<string>>();

                if (!dict[continent].ContainsKey(country))
                    dict[continent][country] = new List<string>();

                dict[continent][country].Add(city);             
            }

            foreach (var continents in dict)
            {
                string continentName = continents.Key;
                Dictionary<string, List<string>> countries = continents.Value;

                Console.WriteLine($"{continentName}:");
                foreach (var cities in countries)
                {
                    string countryName = cities.Key;
                    List<string> cityName = cities.Value;

                    Console.WriteLine("  {0} -> {1} ", countryName, string.Join(", ", cityName));
                }
            }
        }
    }
}