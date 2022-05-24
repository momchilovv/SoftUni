using System;

class Program
{
    static void Main(string[] args)
    {
        /*
          SAMPLE CODE
        int ___Do___ = int.Parse(Console.ReadLine());
        for (int takoa = 2; takoa <= ___Do___; takoa++)
        {
            bool takovalie = true;
            for (int cepitel = 2; cepitel < takoa; cepitel++)
            {
                if (takoa % cepitel == 0)
                {
                    takovalie = false;
                    break;
                }
            }
            Console.WriteLine("{0} -> {1}", takoa, takovalie);
         }

        */

        //REFACTORED CODE
        int number = int.Parse(Console.ReadLine());

        for (int i = 2; i <= number; i++)
        {
            bool isPrime = true;
            for (int j = 2; j < i; j++)
            {
                if (i % j == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            Console.WriteLine($"{i} -> {isPrime.ToString().ToLower()}");
        }
    }
}