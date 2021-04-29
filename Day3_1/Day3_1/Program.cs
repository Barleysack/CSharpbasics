using System;

namespace Day3_1
{
    class Program
    {
        static void Addy(int Number)
        {
            for( int i = 1; i<=Number; i++)
            {
                Console.WriteLine("ADDY HERE");
            }
                
        }
        static void Main(string[] args)
        {
            Main1(args);
            Addy(10);

        }



        static void Main1(string[] args)
        {//main이라는 메소드를 제일 먼저 실행시키겠다.
            //엔트리 포인트 개념 
            //Entry point-진입점


            Test();
            Test();
            Test2();
            Console.WriteLine(Test2());

        }
        static void Test()
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hello World!");
            
        }

        static int Test2()
        {
            double x = 120;
            double y = 130;
            double z = x + y;
            return (int)(z);
        }
    }
}
