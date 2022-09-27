using System;
using System.IO;

namespace FolderSize
{
    public class FolderSize
    {
        static void Main()
        {
            string folderPath = @"..\..\..\Files\TestFolder";
            string outputPath = @"..\..\..\Files\output.txt";

            GetFolderSize(folderPath, outputPath);
        }

        public static void GetFolderSize(string folderPath, string outputFilePath)
        {
            double sum = 0;

            var directory = new DirectoryInfo(folderPath);
            FileInfo[] files = directory.GetFiles("*", SearchOption.AllDirectories);

            foreach (var file in files)
            {
                sum += file.Length;
            }

            sum = sum / 1024 / 1024;

            using (var streamWriter = new StreamWriter(outputFilePath))
            {
                streamWriter.WriteLine(sum.ToString());
            }
        }
    }
}