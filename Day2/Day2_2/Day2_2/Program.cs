using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Day2_2
{
        class Program
        {

            class Custom_2
            {
                public string name;
                public double phone_number;
                public int age;

            }
            static void Main(string[] args)
            {



            }
            static void Main1(string[] args)
            {

                Custom_2 custom2 = new Custom_2();

                var Number = 100;
                Console.WriteLine(Number);

                List<int> list = new List<int>();

                custom2.name = "으아이";
                custom2.phone_number = 01055907993;


                custom2.age = 27;
                Console.WriteLine(custom2.name + ":" + custom2.age);

                list.Add(9);
                list.Add(15);
                list.Add(23);
                list.Add(12);

                list.Add(18);
                foreach (var item in list)
                {
                    Console.WriteLine(item);
                }



                //int banbok = 0;
                //for (int i = 0; i <= 100; i++)
                /*{
                    banbok = banbok + 1;
                }
                Console.WriteLine(banbok);*/


               
                {

                }
                Random random = new Random();


                var testy = 8;

                double testy_2 = testy; //auto type cast 
                testy_2 = random.Next(1, 2);
                var testy_3 = testy + testy_2;

                Console.WriteLine(testy_3.GetType());
                for (int i = 1; i <= 10; i = i + 4)
                {
                    Console.WriteLine(random.Next(1, 10));
                    double a;
                    a = random.NextDouble();

                    Console.WriteLine(a);

                }



                int[] intArray = new int[10];
                long[] longArray = new long[10];



            }
        }
    }


