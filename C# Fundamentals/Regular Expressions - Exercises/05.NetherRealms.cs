using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, Dictionary<double, double>> demons = new Dictionary<string, Dictionary<double, double>>();

        List<string> input = Console.ReadLine().Split(new[] { ' ', '\t', '\n', ',' }, StringSplitOptions.RemoveEmptyEntries).Select(n => n.Trim()).ToList();

        Regex namePattern = new Regex(@"([^\d\+\-\*\/\.\,])");
        Regex damagePattern = new Regex(@"((\+|-)?([0-9]+)(\.[0-9]+)?)|((\+|-)?\.?[0-9]+)");
        Regex dividePattern = new Regex(@"[\/]");
        Regex multiplyPattern = new Regex(@"[\*]");

        foreach (var demon in input)
        {
            string demonName = string.Empty;
            double currentHealth = 0, currentDamage = 0;
            int divideCount = 0, multiplyCount = 0;

            foreach (Match match in multiplyPattern.Matches(demon))
            {
                multiplyCount++;
            }

            foreach (Match match in dividePattern.Matches(demon))
            {
                divideCount++;
            }

            foreach (Match match in namePattern.Matches(demon))
            {
                demonName += match.Value;
            }

            foreach (var letter in demonName)
            {
                currentHealth += letter;
            }

            foreach (Match match in damagePattern.Matches(demon))
            {
                currentDamage += double.Parse(match.Value);
            }

            for (int i = 0; i < multiplyCount; i++)
            {
                currentDamage *= 2;
            }
            for (int i = 0; i < divideCount; i++)
            {
                currentDamage /= 2;
            }

            var temp = new Dictionary<double, double>();
            temp.Add(currentHealth, currentDamage);

            demons.Add(demon, temp);
        }

        foreach (var demon in demons.OrderBy(n => n.Key))
        {
            foreach (var item in demon.Value)
            {
                Console.WriteLine($"{demon.Key} - {item.Key} health, {item.Value:f2} damage");
            }
        }
    }
}