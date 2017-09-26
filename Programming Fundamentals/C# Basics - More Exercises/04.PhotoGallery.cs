using System;

namespace _04.PhotoGallery
{
    class Program
    {
        static void Main(string[] args)
        {
            int photoNumber = int.Parse(Console.ReadLine());
            int day = int.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());
            int hour = int.Parse(Console.ReadLine());
            int minute = int.Parse(Console.ReadLine());
            double photoSize = double.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            string currentByte = null;

            if (photoSize < 1000)
            {
                currentByte = "B";
            }
            else if (photoSize < 1000000)
            {
                photoSize /= 1000;
                currentByte = "KB";
            }
            else
            {
                photoSize /= 1000000;
                currentByte = "MB";
            }
            Console.WriteLine($"Name: DSC_{photoNumber:d4}.jpg");
            Console.WriteLine($"Date Taken: {day}/{month}/{year} {hour:d2}:{minute:d2}");
            Console.WriteLine($"Size: {photoSize}{currentByte}");
            if (width > height)
            {
                Console.WriteLine($"Resolution: {width}x{height} (landscape)");
            }
            else if (width < height)
            {
                Console.WriteLine($"Resolution: {width}x{height} (portrait)");
            }
            else if (width == height)
            {
                Console.WriteLine($"Resolution: {width}x{height} (square)");
            }
        }
    }
}