using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace WordCount
{
    public class WordCount
    {
        static void Main()
        {
            string wordPath = @"..\..\..\Files\words.txt";
            string textPath = @"..\..\..\Files\text.txt";
            string outputPath = @"..\..\..\Files\output.txt";

            CalculateWordCounts(wordPath, textPath, outputPath);
        }

        public static void CalculateWordCounts(string wordsFilePath, string textFilePath, string outputFilePath)
        {
            string[] words;

            var wordsDictionary = new Dictionary<string, int>();

            using (var wordReader = new StreamReader(wordsFilePath))
            {
                words = wordReader.ReadLine().Split();

                foreach (var word in words)
                {
                    wordsDictionary.Add(word, 0);
                }
            }

            using (var textReader = new StreamReader(textFilePath))
            {
                while (!textReader.EndOfStream)
                {
                    string[] currentLine = textReader.ReadLine().Split(new char[] { ',', '.', '!', '?', ' ', '-' });

                    foreach (var word in words)
                    {
                        foreach (var w in currentLine)
                        {
                            if (word == w.ToLower())
                            {
                                wordsDictionary[word]++;
                            }
                        }
                    }
                }
            }

            using (var streamWriter = new StreamWriter(outputFilePath))
            {
                foreach (var word in wordsDictionary.OrderByDescending(x => x.Value))
                {
                    streamWriter.WriteLine($"{word.Key} - {word.Value}");
                }
            }
        }
    }
}