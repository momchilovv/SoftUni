using System;
using System.IO;
using System.Linq;
using System.Text;

namespace LineNumbers
{
    public class LineNumbers
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\text.txt";
            string outputFilePath = @"..\..\..\output.txt";

            ProcessLines(inputFilePath, outputFilePath);
        }

        public static void ProcessLines(string inputFilePath, string outputFilePath)
        {
            var stringBuilder = new StringBuilder();
            int lineCount = 1;
            char[] symbols = new char[]
            {
                '.', ',', '\\', '/', '?', '!',
                '\'', '\'', ';', ':', '-'
            };

            using (var streamReader = new StreamReader(inputFilePath))
            {
                while (!streamReader.EndOfStream)
                {
                    int punctuationCount = 0, letterCount = 0;

                    string currentLine = streamReader.ReadLine();

                    foreach (var letter in currentLine)
                    {
                        if (symbols.Contains(letter))
                        {
                            punctuationCount++;
                            continue;
                        }
                        if (letter == ' ')
                        {
                            continue;
                        }
                        letterCount++;
                    }
                    stringBuilder.AppendLine($"Line {lineCount}: " + currentLine + $"({letterCount})({punctuationCount})");

                    lineCount++;
                }
            }

            using (var streamWriter = new StreamWriter(outputFilePath))
            {
                streamWriter.WriteLine(stringBuilder);
            }
        }
    }
}