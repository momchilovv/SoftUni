using System;
using System.IO;
using System.Security.Cryptography;

namespace SplitMergeBinaryFile
{
    public class SplitMergeBinaryFile
    {
        static void Main()
        {
            string sourceFilePath = @"..\..\..\Files\example.png";
            string joinedFilePath = @"..\..\..\Files\example-joined.png";
            string partOnePath = @"..\..\..\Files\part-1.bin";
            string partTwoPath = @"..\..\..\Files\part-2.bin";

            SplitBinaryFile(sourceFilePath, partOnePath, partTwoPath);
            MergeBinaryFiles(partOnePath, partTwoPath, joinedFilePath);
        }

        public static void SplitBinaryFile(string sourceFilePath, string partOneFilePath, string partTwoFilePath)
        {
            using (var source = new FileStream(sourceFilePath, FileMode.Open))
            {
                using (var firstPart = new FileStream(partOneFilePath, FileMode.Create))
                {
                    int odd = source.Length % 2 == 1 ? 1 : 0;

                    byte[] buffer = new byte[source.Length / 2 + odd];
                    source.Read(buffer);
                    firstPart.Write(buffer);
                }

                using (var secondPart = new FileStream(partTwoFilePath, FileMode.Create))
                {
                    byte[] buffer = new byte[source.Length / 2];
                    source.Read(buffer);
                    secondPart.Write(buffer);
                }
            }
        }

        public static void MergeBinaryFiles(string partOneFilePath, string partTwoFilePath, string joinedFilePath)
        {
            using (var joined = new FileStream(joinedFilePath, FileMode.Create))
            {
                using (var firstPart = new FileStream(partOneFilePath, FileMode.Open))
                {
                    
                    byte[] buffer = new byte[firstPart.Length];
                    firstPart.Read(buffer);
                    joined.Write(buffer);
                }

                using (var secondPart = new FileStream(partTwoFilePath, FileMode.Open))
                {
                    byte[] buffer = new byte[secondPart.Length];
                    secondPart.Read(buffer);
                    joined.Write(buffer);
                }
            }
        }
    }
}