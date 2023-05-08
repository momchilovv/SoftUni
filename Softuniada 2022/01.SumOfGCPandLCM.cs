public class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine()!);
        int m = int.Parse(Console.ReadLine()!);

        var firstDivisiors = new List<int>();
        var secondDivisiors = new List<int>();

        for (int i = 1; i <= n; i++)
        {
            if (n % i == 0)
            {
                firstDivisiors.Add(i);
            }
        }

        for (int i = 1; i <= m; i++)
        {
            if (m % i == 0)
            {
                secondDivisiors.Add(i);
            }
        }

        var greatestCommonDivision = firstDivisiors.Last(x => n % x == 0 && m % x == 0);

        int firstNumber, secondNumber;

        if (n > m)
        {
            firstNumber = n;
            secondNumber = m;
        }
        else
        {
            firstNumber = m;
            secondNumber = n;
        }

        int lowestCommonMultiple = firstNumber * secondNumber;

        for (int i = 1; i < secondNumber; i++)
        {
            int multiple = firstNumber * i;

            if (multiple % secondNumber == 0)
            {
                lowestCommonMultiple = multiple;
                break;
            }
        }

        Console.WriteLine(greatestCommonDivision + lowestCommonMultiple);
    }
}