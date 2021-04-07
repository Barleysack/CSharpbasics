using System;

namespace Codingtest_01
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("*");
            Console.WriteLine("**");
            Console.WriteLine("***");
            Console.WriteLine("****");
            Console.WriteLine("*****");
            Console.WriteLine(" ");
            Console.WriteLine("******");
            Console.WriteLine("*******");
            Console.WriteLine("********");
            Console.WriteLine("*********");
            Console.WriteLine("**********");
            */

            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                    
                }
                Console.WriteLine(" ");
            }
            Console.WriteLine(" ");
            for (int i = 6; i < 11; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");

                }
                Console.WriteLine(" ");
            }
        }
    }
}
