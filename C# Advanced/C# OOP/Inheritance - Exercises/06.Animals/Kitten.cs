﻿namespace Animals
{
    public class Kitten : Cat
    {
        public Kitten(string name, int age) : base(name, age, gender: "Female") { }
        public override string ProduceSound()
        {
            return "Meow";
        }
    }
}