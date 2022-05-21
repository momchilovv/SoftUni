using System;

class Program
{
    static void Main(string[] args)
    {
        int pokemonPower = int.Parse(Console.ReadLine());
        int distance = int.Parse(Console.ReadLine());
        int exhaustFactor = int.Parse(Console.ReadLine());
        int halfPower = pokemonPower / 2;
        int pokedTargets = 0;

        while (pokemonPower >= distance)
        {
            pokemonPower -= distance;
            pokedTargets++;
            if (pokemonPower == halfPower && exhaustFactor != 0)
            {
                pokemonPower /= exhaustFactor;
            }
        }
        Console.WriteLine(pokemonPower);
        Console.WriteLine(pokedTargets);
    }
}