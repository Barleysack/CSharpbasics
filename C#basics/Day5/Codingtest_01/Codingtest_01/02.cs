using System;

namespace Codingtest_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("이름을 입력하세요 :");
            string name = Console.ReadLine();
            Console.Write("나이를 입력하세요 :");
            string age = Console.ReadLine();
            Console.Write("주소를 입력하세요 :");
            string add = Console.ReadLine();

            Console.WriteLine($"반갑습니다. 저는 {add}에 살고 있는 {age}살 {name}입니다.");
            
        }
    }
}
