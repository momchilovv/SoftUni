using System;
using System.Collections.Generic;

namespace Animals
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Beast!")
                {
                    break;
                }

                string[] data = Console.ReadLine().Split();

                switch (input)
                {
                    case "Dog":
                        try
                        {
                            Dog dog = new Dog(data[0], int.Parse(data[1]), data[2]);
                            animals.Add(dog);
                        }
                        catch (ArgumentException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;
                    
                    case "Cat":
                        try
                        {
                            Cat cat = new Cat(data[0], int.Parse(data[1]), data[2]);
                            animals.Add(cat);
                        }
                        catch (ArgumentException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        
                        break;
                    
                    case "Frog":
                        try
                        {
                            Frog frog = new Frog(data[0], int.Parse(data[1]), data[2]);
                            animals.Add(frog);
                        }
                        catch (ArgumentException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }                
                        break;
                    
                    case "Kitten":
                        try
                        {
                            Kitten kitten = new Kitten(data[0], int.Parse(data[1]));
                            animals.Add(kitten);
                        }
                        catch (ArgumentException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }                    
                        break;

                    case "Tomcat":
                        try
                        {
                            Tomcat tomcat = new Tomcat(data[0], int.Parse(data[1]));
                            animals.Add(tomcat);
                        }
                        catch (ArgumentException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }                 
                        break;
                }
            }

            foreach (var animal in animals)
            {
                Console.WriteLine(animal);
            }
        }
    }
}