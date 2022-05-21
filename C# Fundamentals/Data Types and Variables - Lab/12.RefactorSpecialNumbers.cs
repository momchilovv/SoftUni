using System;

class Program
{
    static void Main(string[] args)
    {
        /*
            SAMPLE CODE

        int kolkko = int.Parse(Console.ReadLine());
        int obshto = 0;
        int takova = 0;
        bool toe = false;
        for (int ch = 1; ch <= kolkko; ch++)
        {
            takova = ch;
            while (ch > 0)
            {
                obshto += ch % 10;
                ch = ch / 10;
            }
            toe = (obshto == 5) || (obshto == 7) || (obshto == 11);
            Console.WriteLine("{0} -> {1}", takova, toe);
            obshto = 0;
            ch = takova;
        }
        */


        //REFACTORED CODE
        int number = int.Parse(Console.ReadLine());
        bool check = false;
        
        for (int ch = 1; ch <= number; ch++)
        {
            int sum = 0;
            int currentNumber = ch;
            while (currentNumber > 0)
            {
                sum += currentNumber % 10;
                currentNumber /= 10;
            }
            check = (sum == 5) || (sum == 7) || (sum == 11);
            Console.WriteLine("{0} -> {1}", ch, check);
        }
    }
}