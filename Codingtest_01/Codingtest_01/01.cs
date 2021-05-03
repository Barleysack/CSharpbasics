using System;

namespace Codingtest_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("원의 반지름을 입력하세요 :");
            double r = double.Parse(Console.ReadLine());
            double s = r * r * Math.PI;
            Console.WriteLine($"원의 넓이는 {s}");

            
        }
    }
}
