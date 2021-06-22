using System;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {

            // TODO Be sure to follow best practice when creating your classes

            Bird Penguin = new Bird()
            {
                Age = 45,
                Name = "Happy Feet",
                Legs = 2,
                HasFur = false,
                CanFly = false,
                Type = "Penguin",
                HasFeathers = true,
                DoesMigrate = true,
            };
            Console.WriteLine($"{Penguin.Name} is {Penguin.Age} he has {Penguin.Legs} legs. The type of bird he is is a {Penguin.Type}. Can he fly? {Penguin.CanFly}, Does he have wings then? {Penguin.HasFeathers}. And does he migrate? {Penguin.DoesMigrate}");
            var Snake = new Reptile()
            {
                Age = 779,
                Name = "Snake-y",
                Legs = 0,
                HasFur = false,
                WarmBlooded = false,
                Type = "Snake",
                HasClaws = false,
                WaterBreathing = false,
            };
            Console.WriteLine($"My pet reptile is a {Snake.Type}, her name is {Snake.Name}. She is {Snake.Age}. The amount of legs she has is {Snake.Legs}. Is she warm-blooded? {Snake.WarmBlooded}. Does She have claws? {Snake.HasClaws}. Can she breathe in water? {Snake.WaterBreathing}. Does she have fur? {Snake.HasFur}");

           
        }
    }
}
