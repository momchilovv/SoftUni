using System;

namespace _11.EqualWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstWord = Console.ReadLine().ToLower();
            string secondWord = Console.ReadLine().ToLower();

            if (firstWord.Equals(secondWord))           
                Console.WriteLine("yes");

            else
                Console.WriteLine("no");  
        }
    }
}