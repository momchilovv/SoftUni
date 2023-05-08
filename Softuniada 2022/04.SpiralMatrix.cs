public class Program
{
    static void Main(string[] args)
    {
        int rows = int.Parse(Console.ReadLine()!);
        int cols = int.Parse(Console.ReadLine()!);

        var matrix = new int[rows, cols];

        var resultArray = new int[rows * cols];

        int topRow = 0;
        int botRow = rows - 1;
        int leftCol = 0;
        int rightCol = cols - 1;

        int index = 0;

        for (int i = 0; i < rows; i++)
        {
            var inputLine = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

            int currentCol = 0;

            foreach (var num in inputLine)
            {
                matrix[i, currentCol] = num;

                currentCol++;
            }
        }

        while (topRow <= botRow && leftCol <= rightCol)
        {
            for (int i = leftCol; i <= rightCol; i++)
            {
                resultArray[index] = matrix[topRow, i];
                index++;
            }
            topRow++;

            for (int i = topRow; i <= botRow; i++)
            {
                resultArray[index] = matrix[i, rightCol];
                index++;
            }
            rightCol--;

            if (topRow <= botRow)
            {
                for (int i = rightCol; i >= leftCol; i--)
                {
                    resultArray[index] = matrix[botRow, i];
                    index++;
                }
                botRow--;
            }

            if (leftCol <= rightCol)
            {
                for (int i = botRow; i >= topRow; i--)
                {
                    resultArray[index] = matrix[i, leftCol];
                    index++;
                }
                leftCol++;
            }
        }
   
        Console.WriteLine(string.Join(" ", resultArray));   
    }
}