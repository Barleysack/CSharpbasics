using System;

namespace Codingtest_01
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 7; i <10; i++)
            {
                Console.WriteLine($"\n{i}단 계산 시작");
                for (int j = 1; j < 10; j++)
                {
                    int mul = i * j;
                    Console.Write($" {i}*{ j}={mul} ");
                }
                
            }
            
            
        }
    }
}
