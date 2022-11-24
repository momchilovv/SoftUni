using System;
using System.Collections.Generic;
using WildFarm.Models;

namespace WildFarm
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();

            Animal animal = null;
            Food food = null;

            while (true)
            {
                string[] input = Console.ReadLine().Split();

                if (input[0] == "End")
                    break;

                string[] foodInfo = Console.ReadLine().Split();

                if (input[0] == "Cat")
                {
                    animal = new Cat(input[1], double.Parse(input[2]), input[3], input[4]);
                }
                if (input[0] == "Tiger")
                {
                    animal = new Tiger(input[1], double.Parse(input[2]), input[3], input[4]);
                }
                if (input[0] == "Dog")
                {
                    animal = new Dog(input[1], double.Parse(input[2]), input[3]);
                }
                if (input[0] == "Hen")
                {
                    animal = new Hen(input[1], double.Parse(input[2]), double.Parse(input[3]));
                }
                if (input[0] == "Owl")
                {
                    animal = new Owl(input[1], double.Parse(input[2]), double.Parse(input[3]));
                }
                if (input[0] == "Mouse")
                {
                    animal = new Mouse(input[1], double.Parse(input[2]), input[3]);
                }

                if (foodInfo[0] == "Vegetable")
                {
                    food = new Vegetable(int.Parse(foodInfo[1]));
                }
                if (foodInfo[0] == "Fruit")
                {
                    food = new Fruit(int.Parse(foodInfo[1]));
                }
                if (foodInfo[0] == "Meat")
                {
                    food = new Meat(int.Parse(foodInfo[1]));
                }
                if (foodInfo[0] == "Seeds")
                {
                    food = new Seeds(int.Parse(foodInfo[1]));
                }
                Console.WriteLine(animal.AskForFood());
                animal.GiveFood(food);
                animals.Add(animal);
            }

            foreach (var a in animals)
            {
                Console.WriteLine(a.ToString());
            }
        }
    }
}