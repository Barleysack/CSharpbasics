using System;

namespace day1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Hello \nHello");
            Console.WriteLine("Hello \nHello"[0]);
            Console.WriteLine(5 / 2);
            Console.WriteLine(1>2);
            Console.WriteLine(1<2);
            Console.WriteLine(1==2);
            Console.WriteLine(1>=2);
            Console.WriteLine(1<=2);
            Console.WriteLine(1<=2);
            int a = 120;
            Console.WriteLine(a/7);
            float b = 240;
            Console.WriteLine(b/7);
            double c = 1230.255;
            Console.WriteLine(c/7);
            char d = 'B';
            Console.WriteLine(d);
            string e = "hi there";
            Console.WriteLine(e);
            bool f = a > b;
            Console.WriteLine(f);
            a += 10;
            Console.WriteLine(a);
            a++;
            Console.WriteLine(a);
            var k = 123.14;
            var p = k.GetType();
            Console.WriteLine(p);
         
            Console.Write("enter the number");
            int m = int.Parse(Console.ReadLine());

            if (m % 2 == 0)
            {
                Console.WriteLine(m);
            }
            else
            {
                Console.WriteLine("홀수는 취급 안함");
            }
            Console.Write(DateTime.Now.Year);
            Console.Write(DateTime.Now.Month);
            Console.Write(DateTime.Now.Day);

            if (a > 120)
            {
                if (DateTime.Now.Year < 2022)
                {
                    Console.WriteLine("아직 늦지 않았네");
                }
                else
                {
                    Console.WriteLine("늦었구나 친구야");
                }
            }
            else
            {
                if (DateTime.Now.Year < 2022)
                {
                    Console.WriteLine("아직 늦지 않았네");
                }
                else
                {
                    Console.WriteLine("늦었구나 친구야");
                }
            }
            if (DateTime.Now.Hour < 11)
            {
                Console.WriteLine("Morning");
            }
            else
            {
                if (DateTime.Now.Hour < 16)
                {
                    Console.WriteLine("Afternoon");
                }
                else
                {
                    Console.WriteLine("Maybe too late");
                }
            }
            switch (DateTime.Now.Hour > 16)
            {
                case true:
                    Console.WriteLine("lol");
                    break;
                case false:
                    Console.WriteLine("HEY");
                    break;

            }

        }
    }
}
