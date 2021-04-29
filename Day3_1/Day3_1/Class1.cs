using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_1
{
    class Car
    {
        public string Vendor;
        public int Speed;
        public void Accel()
        {
            Speed = Speed + 10;
        }
        public void Break()
        {
            Speed = Speed - 10;
        }
        
    }
}
