using Raiding.Models;
using System;

namespace Raiding.Factories
{
    public class Hero
    {
        public static BaseHero CreateHero(string type, string name)
        {
            BaseHero baseHero;

            if (type == "Druid")
            {
                baseHero = new Druid(name);
            }
            else if (type == "Paladin")
            {
                baseHero = new Paladin(name);
            }
            else if (type == "Rogue")
            {
                baseHero = new Rogue(name);
            }
            else if (type == "Warrior")
            {
                baseHero = new Warrior(name);
            }
            else
            {
                throw new ArgumentException("Invalid hero!");
            }

            return baseHero;
        }
    }
}