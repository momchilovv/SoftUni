﻿namespace FoodShortage
{
    public class Pet : IIdentifiable
    {
        public Pet(string name, string birthdate)
        {
            Name = name;
            Birthdate = birthdate;
        }

        public string Name { get; set; }
        public string Birthdate { get; set; }
        public string Id { get; set; }
    }
}