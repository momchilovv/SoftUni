﻿namespace FoodShortage
{
    public class Citizen : IIdentifiable, IBuyer
    {
        public Citizen(string name, int age, string id, string birthdate)
        {
            Name = name;
            Age = age;
            Id = id;
            Birthdate = birthdate;
        }

        public string Name { get; set; }
        public int Age { get; set; }
        public string Birthdate { get; set; }
        public string Id { get; set; }
        public int Food { get; set; } = 0;

        public void BuyFood()
        {
            Food += 10;
        }
    }
}