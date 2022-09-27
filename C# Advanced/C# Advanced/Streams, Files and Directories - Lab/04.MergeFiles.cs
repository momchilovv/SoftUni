using System;
using System.IO;
using System.Text;

namespace MergeFiles
{
    public class MergeFiles
    {
        static void Main()
        {
            var firstInputFilePath = @"..\..\..\Files\input1.txt";
            var secondInputFilePath = @"..\..\..\Files\input2.txt";
            var outputFilePath = @"..\..\..\Files\output.txt";

            MergeTextFiles(firstInputFilePath, secondInputFilePath, outputFilePath);
        }

        public static void MergeTextFiles(string firstInputFilePath, string secondInputFilePath, string outputFilePath)
        {
            var stringBuilder = new StringBuilder();

            using (var firstInputReader = new StreamReader(firstInputFilePath))
            {
                using (var secondInputReader = new StreamReader(secondInputFilePath))
                {
                    while (!firstInputReader.EndOfStream && !secondInputReader.EndOfStream)
                    {
                       
                        stringBuilder.AppendLine(firstInputReader.ReadLine());
                        stringBuilder.AppendLine(secondInputReader.ReadLine());
                    }
                }
            }

            using (var streamWriter = new StreamWriter(outputFilePath))
            {
                streamWriter.WriteLine(stringBuilder.ToString());
            }
        }
    }
}