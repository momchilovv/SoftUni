using System;

namespace EvenLines
{
    using System;
    using System.IO;
    using System.Linq;
    using System.Text;

    public class EvenLines
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\text.txt";

            Console.WriteLine(ProcessLines(inputFilePath));
        }

        public static string ProcessLines(string inputFilePath)
        {
            var stringBuilder = new StringBuilder();

            string[] symbolsToReplace = new string[] { ".", ",", "-", "!", "?" };

            int count = 0;

            using (var streamReader = new StreamReader(inputFilePath))
            {
                string currentLine = string.Empty;

                while (!streamReader.EndOfStream)
                {
                    if (count % 2 == 0)
                    {
                        currentLine = streamReader.ReadLine();
                        foreach (var ch in symbolsToReplace)
                        {
                            currentLine = currentLine.Replace(ch, "@");
                        }
                        string[] reversed = currentLine.Split().Reverse().ToArray();

                        stringBuilder.AppendLine(string.Join(" ", reversed));
                    }
                    count++;
                }
                return stringBuilder.ToString();
            }
        }
    }
}