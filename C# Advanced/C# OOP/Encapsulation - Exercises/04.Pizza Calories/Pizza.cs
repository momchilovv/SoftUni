using System;
using System.Collections.Generic;
using System.Linq;

namespace PizzaCalories
{
    public class Pizza
    {
        private const int MinToppings = 0;
        private const int MaxToppings = 10;

        private string name;
        private List<Topping> toppings;
        private Dough dough;

        public Pizza(string name)
        {
            Name = name;
            Toppings = new List<Topping>();
        }

        public string Name
        {
            get { return name; }
            private set
            {
                if (string.IsNullOrEmpty(value) || value.Length > 15)
                {
                    throw new ArgumentException($"Pizza name should be between 1 and 15 symbols.");
                }
                name = value;
            }
        }

        public Dough Dough
        {
            get { return dough; }
            set { dough = value; }
        }

        public List<Topping> Toppings
        {
            get { return toppings; }
            private set
            {
                toppings = value;
            }
        }

        public void AddTopping(Topping topping)
        {
            if (Toppings.Count > MaxToppings)
            {
                throw new ArgumentException("Number of toppings should be in range [0..10].");
            }

            Toppings.Add(topping);        
        }

        private double Calories()
        {
            return Dough.Calories + Toppings.Sum(c => c.Calories);
        }

        public override string ToString()
        {
            return $"{Name} - {Calories():f2} Calories.";
        }
    }
}