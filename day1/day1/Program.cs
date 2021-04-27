using System;

namespace day1
{
    class Program
    {
        static void Main(string[] args)
        {
            //sizeof는 연산자.
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
            int m = 5;

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

            int output = 0;

            for ( int q = 0; q<= 10; q++)
            {
                output += q;
                
            }
            Console.WriteLine(output);
            double holy = 1;

            for (double x = 1; x <= 5; x++)
            {
                holy*= x;
            }
            Console.WriteLine(holy);

            int[] intArray = { 1, 2, 3, 4, 5, 6 };
            for (int i = intArray.Length -1; i>=0; i--)
            {

                Console.WriteLine(intArray[i]);

            }
            string[] array = { "가", "나", "다", "라", "마" };
            foreach ( string item in array)
            {
                Console.WriteLine(item);

            }
            for (int i = 0; i < 10; i++)
            {
                for (int j =0; j< i+1; j++)
                
                    Console.Write("*");
                 Console.WriteLine("\n");   
                
            }
          //권장은 데이터타입을 먼저 넣는 것을 권장한다.
          //초기화는 미리 해두고 필요할때 값을 집어넣는다. 
          //코드가 길어지면 기억이 안난다.
          //변수는 식별가능하도록
          //웬만하면 알아보기 쉽도록. 축약 연산(복합연산자)같은거 하지 마라....
          //꿀-팁

            bool one = 10 < 0;
            bool two = 100 > 10;
            Console.WriteLine(two);
            Console.WriteLine(one);
            int number = 10;
            number++;//number=number+1
            Console.WriteLine(number);
            number--;//number=number-1
            Console.WriteLine(number);

        }
    }
}
