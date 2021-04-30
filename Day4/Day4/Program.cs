using System;
using System.Threading;
using System.Collections.Generic;
namespace Day4
{

    //기계어(code)//heap영역-(객체)/stack영역(지역변수)/
    class Program
    {
        static void Main(string[] args)
        {
            List<double> listy = new List<double>();
            listy.Add(3);
            listy.Add(4);
            listy.Add(5);
            listy.Add(Math.Sqrt(29));
            listy.Add(Math.Ceiling(29.123));
            listy.Add(Math.Floor(29.123));
            listy.Add(Math.Pow(29,2));
            listy.Add(Math.Sqrt(29.123));
            listy.Add(Math.Sqrt(29.123));
            foreach (int a in listy)
            {
                Console.WriteLine(0);
            }

            Outer.Outer1 ought = new Outer.Outer1();
            ought.size = 28.28;
            ought.price = 299000;
            ought.name = "dㅇㅇㄴ";
            ought.whatever = 29;
            

                
        }
        static void Main2(string[] args)
        {
            Car car = new Car();
            Console.WriteLine("Hello World!");
            int K = Car.Abs(-89);
            Console.WriteLine(K);
            int glo = Car.Add(8,8) + 8;
            Console.WriteLine(glo);
            Random rnd = new Random();
            int[] array1 = { 3, 4, 5 };
            foreach(int i in array1)
            {
                Console.WriteLine(i);
            }
            
            
            for ( int i = 1; i<40; i++)
            {
                Console.WriteLine(rnd.Next(2, 10));
                Thread.Sleep(10);
                Console.Clear();
                
                
             }
            
            
        }
    }
    class Car
    {

        public string nothing;//public-아무나 쓸 수 있는것
        public double hello;//
        private int Speed;
        public int Speed2;
        public int speed3;

     



    }


        
    

}
