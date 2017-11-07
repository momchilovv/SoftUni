using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _03.WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = File.ReadAllLines(@"..\Files\Words.txt");
            List<string> list = new List<string>();
            var wCount = 0;

            foreach (var word in words)
            {
                if (!list.Contains(word))
                {
                    list.Add(word);
                    wCount++;
                }
            }
        }
    }
}
