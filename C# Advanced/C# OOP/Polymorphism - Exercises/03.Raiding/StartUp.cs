using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Raiding.Factories;
using Raiding.Models;

namespace Raiding
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<BaseHero> heroes = new List<BaseHero>();

            int numberOfHeroes = int.Parse(Console.ReadLine());

            int counter = 0;

            while (counter != numberOfHeroes)
            {
                string name = Console.ReadLine();
                string type = Console.ReadLine();

                try
                {
                    BaseHero hero = Hero.CreateHero(type, name);
                    heroes.Add(hero);

                    counter++;
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            double bossPower = double.Parse(Console.ReadLine());

            foreach (var hero in heroes)
            {
                Console.WriteLine(hero.CastAbility());
            }

            double totalPower = heroes.Sum(h => h.Power);

            if (totalPower >= bossPower)
            {
                Console.WriteLine("Victory!");
            }
            else
            {
                Console.WriteLine("Defeat...");
            }
        }
    }
}