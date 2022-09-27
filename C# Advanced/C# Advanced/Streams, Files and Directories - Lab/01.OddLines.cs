using System;
using System.IO;
using System.Text;

namespace OddLines
{
    public class OddLines
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\Files\input.txt";
            string outputFilePath = @"..\..\..\Files\output.txt";

            ExtractOddLines(inputFilePath, outputFilePath);
        }

        public static void ExtractOddLines(string inputFilePath, string outputFilePath)
        {
            var stringBuilder = new StringBuilder();
            int count = 0;

            using (var stream = new StreamReader("../../../input.txt"))
            {
                while (!stream.EndOfStream)
                { 
                    if (count % 2 == 1)
                    {
                        stringBuilder.AppendLine(stream.ReadLine());
                    }
                    else
                    {
                        stream.ReadLine();
                    }
                    count++;
                }
            }

            using (var streamWriter = new StreamWriter("../../../output.txt"))
            {
                streamWriter.WriteLine(stringBuilder.ToString());
            }
        }
    }
}