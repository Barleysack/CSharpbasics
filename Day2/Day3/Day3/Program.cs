using System;
using System.Linq;
using System.Threading;
namespace Day3
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
        static void Main2(string[] args)
        {


            ConsoleKeyInfo info = Console.ReadKey();
            switch (info.Key)
            {
                case ConsoleKey.UpArrow:
                    Console.WriteLine("UP");
                    break;

                case ConsoleKey.RightArrow:
                    Console.WriteLine("r");
                    break;

                case ConsoleKey.LeftArrow:
                    Console.WriteLine("L");
                    break;

                case ConsoleKey.DownArrow:
                    Console.WriteLine("d");
                    break;

                case ConsoleKey.X:
                    break;

            }
            
            /*while (true)
            {
                int x = 1;
                

                while (x < 50)
                {
                    Console.Clear();
                    Console.SetCursorPosition(x, 5);
                    if (x % 3 == 0)
                    {
                        Console.WriteLine("__@");

                    }
                    else if (x % 3 == 1)
                    {
                        Console.WriteLine("_^@");

                    }
                    else
                    {
                        Console.WriteLine("^_@");
                    }
                    Thread.Sleep(1);
                    x++;
                }
            }

            /*string bs = "Test test TEST";
            Console.WriteLine(bs.ToLower());
            Console.WriteLine(bs.ToUpper());
            string new_bs = bs.ToLower();
            Console.WriteLine(new_bs);
            string[] inputs = bs.Split(new char[] { ' ' });
            foreach (var item in inputs)
            {
                Console.WriteLine(item);
            }
            string hithere = "          go         \n";
            Console.WriteLine(hithere.Trim());
           
            
            Console.WriteLine("df"+hithere.Trim());



            /*static void Main3(string[] args)
            {
                int i = 0;

                while (i <= 10)
                {
                    i = i + 1;
                    if (i % 2 == 1)
                    {
                        continue;
                    }

                    Console.WriteLine(i);

                }
            }
            static void Main4(string[] args)
            {
                double[] a = { 100, 90, 91 };
                double davg;
                davg = Enumerable.Average(a);
                Console.WriteLine(davg);
                var lol = Enumerable.Range(1, 10);

                Console.WriteLine(lol);
                int k;
                k = 7;
                int p;
                p = 9;
                int answer = Testyme.Add(k, p);
                Console.WriteLine(answer);


                int[] iscore;
                iscore = new int[4];
                for (int i = 0; i <= 3; i++)
                {


                    iscore[i] = (i + 1) * 1000;

                }
                Console.WriteLine(iscore.Length);

                foreach (int i in iscore)
                {
                    Console.WriteLine(i);
                }
                int bdan = 2;
                for (; bdan < 10; bdan++)
                {
                    for (int c = 1; c < 10; c++)
                    {
                        Console.WriteLine(bdan + "단:" + bdan * c);
                    }

                }
                Console.WriteLine(Testyme.Gugu(7));*/


        }
    }
}
