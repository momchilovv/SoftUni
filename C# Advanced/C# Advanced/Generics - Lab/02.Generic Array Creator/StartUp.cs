using System;

namespace GenericArrayCreator
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] stringArray = ArrayCreator.Create(5, "Pesho");
            int[] intArray = ArrayCreator.Create(10, 33);
        }
    }
}