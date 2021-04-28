using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Day2_2
{
        class Program
        {   static void Main(string[] args)
            {


            Custom_2 customy = new Custom_2();

            List<Custom_2> custylist = new List<Custom_2>();
            custylist.Add(new Custom_2() { age = 27, name = "김우식" });
            custylist.Add(new Custom_2() { age = 21, name = "김수식" });
            custylist.Add(new Custom_2() { age = 23, name = "김미식" });
            custylist.Add(new Custom_2() { age = 26, name = "김양식" });
            custylist.Add(new Custom_2() { age = 21, name = "김가식" });
            custylist.Add(new Custom_2() { age = 22, name = "김서식" });

            foreach (var item in custylist)
            {
                Console.WriteLine(item.name + ":" + item.age);
            }


            /*int input;
            input = int.Parse(Console.ReadLine());

            if (input % 2 == 0)
            {
                customy.age = 27;
                Console.WriteLine(customy.age);
            }
            else
            {
                customy.age = 26;
                Console.WriteLine(customy.age);*/
        }

            

            class Custom_2
            {
                public string name;
                public double phone_number;
                public int age;

            }
            static void hey (string[] args)
            {
            Carcass body = new Carcass();
            Custom_2 customy = new Custom_2();
            customy.age = 28;
            body.bloodtype = 'A';
            string bit = customy.age + " and " + body.bloodtype;
            Console.WriteLine(bit);
            int[] minimini = { 1, 2, 3, 4, 5 };
            string NS = "123456";
            int IN = int.Parse(NS);
            
            

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


