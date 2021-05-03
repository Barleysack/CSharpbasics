using Day5_02;
using System;
using System.Collections.Generic;
namespace Day5_02_inheritTest
{
    class Program //Access Modifier : public, protected, private
    {
        static void Main(string[] args)
        {
            List<Dog> dogs = new List<Dog>()
            {
                new Dog(), new Dog()
            };
            List<Cat> cats = new List<Cat>()
            {
                new Cat(), new Cat()
            };
            foreach (Dog item in dogs)
            {
                item.Age = 10;
                item.Color = "Black";
                item.Eat();
                item.Sleep();
                item.Bark();
            }
            foreach (Cat item in cats)
            {
                item.Age = 10;
                
                item.Eat();
                item.Sleep();
                item.Meow();
            }
        }
    }
}
