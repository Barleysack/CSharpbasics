using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_02
{
    class Cat : Animal
    {
        
        
        //BASIC GENERATOR
        public Cat() { this.Age = 0; }
        //ACTION->METHOD
       
        public void Meow() { Console.WriteLine("MEOW MEOW"); }
    }
}
