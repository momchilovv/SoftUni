using System;
using System.IO;
using System.Text;

namespace LineNumbers
{
    public class LineNumbers
    {
        static void Main()
        {
            string inputPath = @"..\..\..\Files\input.txt";
            string outputPath = @"..\..\..\Files\output.txt";

            RewriteFileWithLineNumbers(inputPath, outputPath);
        }

        public static void RewriteFileWithLineNumbers(string inputFilePath, string outputFilePath)
        {
            var stringBuilder = new StringBuilder();
            int count = 1;

            using (var streamReader = new StreamReader(inputFilePath))
            {
                while (!streamReader.EndOfStream)
                {
                    stringBuilder.AppendLine($"{count}. " + streamReader.ReadLine());
                    count++;
                }
            }

            using (var streamWriter = new StreamWriter(outputFilePath))
            {
                streamWriter.WriteLine(stringBuilder.ToString());
            }
        }
    }
}