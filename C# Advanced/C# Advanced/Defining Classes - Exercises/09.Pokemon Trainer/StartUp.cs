using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main()
        {
            var trainers = new Dictionary<string, Trainer>();

            string[] pokemonInput = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            while (pokemonInput[0] != "Tournament")
            {
                string trainerName = pokemonInput[0];
                string pokemonName = pokemonInput[1];
                string element = pokemonInput[2];
                int health = int.Parse(pokemonInput[3]);

                Pokemon pokemon = new Pokemon(pokemonName, element, health);

                if (!trainers.ContainsKey(trainerName))
                {
                    trainers[trainerName] = new Trainer(trainerName);
                }
                trainers[trainerName].Pokemons.Add(pokemon);
                
                pokemonInput = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }

            string command = Console.ReadLine();

            while (command != "End")
            {
                foreach (var trainer in trainers.Values)
                {
                    if (trainer.Pokemons.Any(p => p.Element == command))
                    {
                        trainer.NumberOfBadges++;
                    }
                    else
                    {
                        trainer.Pokemons.ForEach(p => p.Health -= 10);
                        trainer.Pokemons.RemoveAll(p => p.Health <= 0);
                    }
                }

                command = Console.ReadLine();
            }

            foreach (var trainer in trainers.Values.OrderByDescending(b => b.NumberOfBadges))
            {
                Console.WriteLine(trainer.ToString());
            }
        }
    }
}