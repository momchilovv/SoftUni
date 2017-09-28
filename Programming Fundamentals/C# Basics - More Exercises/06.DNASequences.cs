using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.DNASequences
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = int.Parse(Console.ReadLine());

            int a = 1;
            int c = 2;
            int g = 3;
            int t = 4;

            var nucleic = "ACGT";

            var poss = nucleic.Select(x => x.ToString());
            int size = 3;
            for (int i = 0; i < size - 1; i++)
            {
                poss = poss.SelectMany(x => nucleic, (x, y) => x + y);
            }
            foreach (var comb in poss)
            {
                
            }
            Console.WriteLine();
        }
    }
}
