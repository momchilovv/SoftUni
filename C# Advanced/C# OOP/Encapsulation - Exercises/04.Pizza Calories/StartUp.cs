using System;

namespace PizzaCalories
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            try
            {
                string[] input = Console.ReadLine().Split();

                Pizza pizza = new Pizza(input[1]);

                string[] command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                Dough dough = new Dough(command[1], command[2], double.Parse(command[3]));

                pizza.Dough = dough;

                command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                while (command[0] != "END")
                {
                    Topping topping = new Topping(command[1], double.Parse(command[2]));
                    pizza.AddTopping(topping);

                    command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                }

                Console.WriteLine(pizza.ToString());
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                Environment.Exit(0);
            }
        }
    }
}