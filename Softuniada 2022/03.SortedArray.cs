public class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine()!);
        int[] array = new int[n];

        var input = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

        for (int i = 0; i < input.Length; i++)
        {
            if (i == 0)
            {
                array[i] = input[0];
                continue;
            }

            if (i % 2 == 1)
            {
                if (input[i] <= array[i - 1])
                {
                    array[i] = input[i];
                }
                else if (input[i] >= array[i - 1])
                {
                    array[i] = array[i - 1];
                    array[i - 1] = input[i];
                }
            }
            else
            {
                if (input[i] >= array[i - 1])
                {
                    array[i] = input[i];
                }
                else if (input[i] <= array[i - 1])
                {
                    array[i] = array[i - 1];
                    array[i - 1] = input[i];
                }
            }
        }
        Console.WriteLine(string.Join(" ", array));
    }
}