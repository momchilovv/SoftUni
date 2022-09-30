namespace ZipAndExtract
{
    using System;
    using System.IO;
    using System.IO.Compression;

    public class ZipAndExtract
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\copyMe.png";
            string zippedFilePath = @"..\..\..\archive.zip";
            string extractedFilePath = @"..\..\..\extracted.png";

            ZipFileToArchive(inputFilePath, zippedFilePath);

            var fileName = Path.GetFileName(inputFilePath);
            ExtractFileFromArchive(zippedFilePath, fileName, extractedFilePath);
        }

        public static void ZipFileToArchive(string inputFilePath, string zipArchiveFilePath)
        {
            using (var archive = ZipFile.Open(zipArchiveFilePath, ZipArchiveMode.Create))
            {
                string name = Path.GetFileName(inputFilePath);

                archive.CreateEntryFromFile(inputFilePath, name);
            }
        }

        public static void ExtractFileFromArchive(string zipArchiveFilePath, string fileName, string outputFilePath)
        {
            using (var archive = ZipFile.OpenRead(zipArchiveFilePath))
            {
                ZipArchiveEntry extraction = archive.GetEntry(fileName);

                extraction.ExtractToFile(outputFilePath);
            }
        }
    }
}