using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    class Testyme
    {
        public static int Add(int x, int y)
        {
            return x + y;
        }

        public static int Gugu(int x)
        {
            int Result;
            
            for ( int o = 1; o <= 9; o++)
            {
                Result = x * o;
                Console.WriteLine(Result);
            }
            
            return 0;

        }
    }
}
