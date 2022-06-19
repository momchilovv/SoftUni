using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<int> pokemons = Console.ReadLine().Split().Select(int.Parse).ToList();
        int sum = 0, tempValue = 0;

        while (pokemons.Count > 0)
        {
            int index = int.Parse(Console.ReadLine());
            if (index < 0)
            {
                tempValue = pokemons[0];
                sum += tempValue;
                pokemons[0] = pokemons.Last();
            }
            else if (index > pokemons.Count - 1)
            {

                tempValue = pokemons[pokemons.Count - 1];
                sum += tempValue;
                pokemons[pokemons.Count - 1] = pokemons[0];
            }
            else
            {
                tempValue = pokemons[index];
                sum += tempValue;
                pokemons.RemoveAt(index); 
            }
            for (int i = 0; i < pokemons.Count; i++)
            {
                if (pokemons[i] <= tempValue)
                {
                    pokemons[i] += tempValue;
                }
                else
                {
                    pokemons[i] -= tempValue;
                }
            }
        }
        Console.WriteLine(sum);
    }
}