using System;

class Program
{
    static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());

        for (int i = 1111; i <= 9999; i++)
        {
            bool isSpecial = false;
            foreach (var item in i.ToString())
            {
                if (int.Parse(item.ToString()) != 0 && number % int.Parse(item.ToString()) == 0)
                {
                    isSpecial = true;
                }
                else
                {
                    isSpecial = false;
                    break;
                }
            }
            if (isSpecial)
            {
                Console.Write($"{i} ");
            }
        }
    }
}