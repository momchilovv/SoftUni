using System;

class Program
{
    static void Main(string[] args)
    {
        double numberOfStudents = double.Parse(Console.ReadLine());
        double numberOfLectures = double.Parse(Console.ReadLine());
        double additionalBonus = double.Parse(Console.ReadLine());

        double maxBonus = 0, attendedLectures = 0;

        for (int i = 1; i <= numberOfStudents; i++)
        {
            double studentAttendance = double.Parse(Console.ReadLine());
            double currentBonus = (5 + additionalBonus) * studentAttendance / numberOfLectures;

            if (currentBonus > maxBonus)
            {
                maxBonus = Math.Ceiling(currentBonus);
                attendedLectures = Math.Ceiling(studentAttendance);
            }
        }
        Console.WriteLine($"Max Bonus: {maxBonus}.");
        Console.WriteLine($"The student has attended {attendedLectures} lectures.");
    }
}