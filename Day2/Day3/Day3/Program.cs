using System;
using System.Linq;
namespace Day3
{
    class Program
    {
        
        static void Main3(string[] args)
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
        static void Main(string[] args)
        {
            double[] a= { 100, 90, 91 };
            double davg;
            davg = Enumerable.Average(a);
            Console.WriteLine(davg);
            var lol = Enumerable.Range(1, 10);

            Console.WriteLine(lol);
            int k;
            k = 7;
            int p;
            p = 9;
            int answer=Testyme.Add(k, p);
            Console.WriteLine(answer);

           
            int[] iscore;
            iscore = new int[4];
            for(int i=0; i<=3; i++)
            {
                
                
                iscore[i] = (i + 1) * 1000;
               
            }
            Console.WriteLine(iscore.Length);
            
            foreach(int i in iscore)
            {
                Console.WriteLine(i);
            }




        }
    }
}
