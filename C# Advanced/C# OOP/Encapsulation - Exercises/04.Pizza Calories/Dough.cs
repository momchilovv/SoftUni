using System;

namespace PizzaCalories
{
    public class Dough
    {
        private const int MinDoughWeight = 1;
        private const int MaxDoughWeight = 200;

        private string flourType;
        private string bakingTechnique;
        private double weight;

        public Dough(string flourType, string bakingTechnique, double weight)
        {
            FlourType = flourType.ToLower();
            BakingTechnique = bakingTechnique.ToLower();
            Weight = weight;
        }

        public string FlourType
        {
            get { return flourType; }
            private set
            {
                if (value != "white" && value != "wholegrain")
                {
                    throw new ArgumentException("Invalid type of dough.");
                }
                flourType = value;
            }
        }
        public string BakingTechnique
        {
            get { return bakingTechnique; }
            private set
            {
                if (value != "crispy" && value != "chewy" && value != "homemade")
                {
                    throw new ArgumentException("Invalid type of dough.");
                }
                bakingTechnique = value;
            }
        }
        public double Weight
        {
            get { return weight; }
            private set
            {
                if (value < MinDoughWeight || value > MaxDoughWeight)
                {
                    throw new ArgumentException($"Dough weight should be in the range [{MinDoughWeight}..{MaxDoughWeight}].");
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
            double flourModifier = 0;
            double bakingModifier = 0;

            switch (flourType)
            {
                case "white":
                    flourModifier = 1.5;
                    break;
                case "wholegrain":
                    flourModifier = 1.0;
                    break;
            }

            switch (bakingTechnique)
            {
                case "crispy":
                    bakingModifier = 0.9;
                    break;
                case "chewy":
                    bakingModifier = 1.1;
                    break;
                case "homemade":
                    bakingModifier = 1.0;
                    break;
            }

            return (2 * weight) * flourModifier * bakingModifier;
        }
    }
}