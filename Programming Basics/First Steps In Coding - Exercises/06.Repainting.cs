using System;

class Program
{
    static void Main(string[] args)
    {
        int nylon = int.Parse(Console.ReadLine());
        int paint = int.Parse(Console.ReadLine());
        int thinner = int.Parse(Console.ReadLine());
        int workHours = int.Parse(Console.ReadLine());

        double nylonSum = (nylon + 2) * 1.5;
        double paintSum = (paint + (paint * 0.1)) * 14.50;
        double thinnerSum = thinner * 5;
        double bagSum = 0.40;

        double totalMaterialsSum = nylonSum + paintSum + thinnerSum + bagSum;

        double workersFee = (totalMaterialsSum * 0.3) * workHours;

        double totalSum = totalMaterialsSum + workersFee;

        Console.WriteLine(totalSum);
    }
}