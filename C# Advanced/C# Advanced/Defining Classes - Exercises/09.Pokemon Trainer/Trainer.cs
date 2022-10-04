using System.Collections.Generic;

namespace DefiningClasses
{
    public class Trainer
    {
        public Trainer(string name)
        {
            this.Name = name;
            this.Pokemons = new List<Pokemon>();
        }

        public string Name { get; set; }
        public int NumberOfBadges { get; set; } = 0;
        public List<Pokemon> Pokemons { get; set; }

        public override string ToString()
        {
            return $"{Name} {NumberOfBadges} {Pokemons.Count}";
        }
    }
}