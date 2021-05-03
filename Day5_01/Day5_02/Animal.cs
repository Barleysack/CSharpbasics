using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_02
{
    class Animal
    {
       public int Age { get; set; }
        public Animal() { this.Age = 0; }

        public void Eat() { Console.WriteLine("nyam"); }
        public void Sleep() { Console.WriteLine("cool"); }

    }
}
