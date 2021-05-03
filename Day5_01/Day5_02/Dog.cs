using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_02
{
    class Dog : Animal
    {
  
        public string Color { get; set; }
//BASIC GENERATOR
        public Dog() { this.Age = 0; this.Color = "white"; }
        //ACTION->METHOD

        public void Bark() { Console.WriteLine("BARK BARK"); }


    }   
}
