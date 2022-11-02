using System;
using System.Collections.Generic;
using System.Linq;

namespace PizzaCalories
{
    public class Topping
    {
        private const int MinToppingWeight = 1;
        private const int MaxToppingWeight = 50;

        private string type;
        private double weight;

        public Topping(string type, double weight)
        {
            Type = type;
            Weight = weight;
        }

        public string Type
        {
            get { return type; }
            private set
            {
                var topping = value.ToLower();
                if (topping != "meat" && topping != "veggies" && topping != "cheese" && topping != "sauce")
                {
                    throw new ArgumentException($"Cannot place {value} on top of your pizza.");
                }
                type = value.ToLower();
            }
        }

        public double Weight
        {
            get { return weight; }
            private set
            {
                if (value < MinToppingWeight || value > MaxToppingWeight)
                {
                    string type = char.ToUpper(Type[0]) + Type.Substring(1);
                    throw new ArgumentException($"{type} weight should be in the range [{MinToppingWeight}..{MaxToppingWeight}].");
                }
                weight = value;
            }
        }

        public double Calories
        {
            get { return GetCalories(); }
        }

        public double GetCalories()
        {
            double modifier = 0;

            switch (type)
            {
                case "meat":
                    modifier = 1.2;
                    break;
                case "veggies":
                    modifier = 0.8;
                    break;
                case "cheese":
                    modifier = 1.1;
                    break;
                case "sauce":
                    modifier = 0.9;
                    break;
            }

            return 2 * (modifier * weight);
        }
    }
}