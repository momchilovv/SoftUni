public class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine()!);
        var name = Console.ReadLine()!.ToUpper();

        int coffeeWidth = 3 * n + 6;
        int namePart = n - 2;
        int topCoffeeLine = n * 2 + name!.Length;

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(" ");
            }
            for (int k = 0; k < 5; k++)
            {
                if (k % 2 == 0)
                {
                    Console.Write("~");
                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
        for (int i = 0; i < coffeeWidth - 1; i++)
        {
            Console.Write("=");
        }

        Console.WriteLine();

        for (int j = 1; j <= namePart; j++)
        {
            Console.Write("|");

            for (int k = 0; k < n; k++)
            {
                Console.Write("~");
            }

            if (j == n / 2)
            {
                Console.Write(name);
            }
            else
            {
                Console.Write(new string('~', name.Length));
            }

            for (int k = 0; k < n; k++)
            {
                Console.Write("~");
            }

            Console.Write("|");

            for (int i = 0; i < n - 1; i++)
            {
                Console.Write(" ");
            }

            Console.WriteLine("|");
        }

        for (int i = 0; i < coffeeWidth - 1; i++)
        {
            Console.Write("=");
        }

        Console.WriteLine();

        for (int i = 0; i < n; i++)
        {
            Console.Write(new string(' ', i) + "\\");

            Console.Write(new string('@', topCoffeeLine - i * 2));

            Console.Write('/');
            Console.WriteLine();
        }
        Console.WriteLine(new string('-', coffeeWidth - 1));
    }
}