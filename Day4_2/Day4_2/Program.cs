using System;
using System.Collections.Generic;
namespace Day4_2
{
    class SmartFactory
    {
        public static void Main2(string[] args)
        {
            Random rd = new Random();
            Console.WriteLine("Hello World!");
            
            List<student> listybeaky = new List<student>(); //
            
            for ( int i= 1; i < 7; i++)
            {
                listybeaky.Add(new student() { name = "김"+i+"성", grade = rd.Next(1, 5) });
            }
            foreach ( var i in listybeaky)
            {
                Console.WriteLine(i.name + ":" + i.grade + "(이전)");
            }



            Console.WriteLine(listybeaky);



            foreach (var item in listybeaky)
            {
                if (item.grade > 1)
                {
                    listybeaky.Remove(item);
                    break;
                }
            }
            foreach (var i in listybeaky)
            {
                Console.WriteLine(i.name + ":" + i.grade + "(이후)");
            }
        }//list의 요소를 제거할 때에는 역 for 반복문을 사용한다고 기억한다. 

        
    }
    class hello
    {
        public static void Main(string[] args)
        {
            
            SmartFactory.Main2(args);
            Console.WriteLine("Which one will go first"); 

        }
    }
}
