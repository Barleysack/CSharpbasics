using System;
using System.Collections.Generic;
namespace Day4_2
{
    class SmartFactory
    {
        static void Main(string[] args)
        {
            Random rd = new Random();
            Console.WriteLine("Hello World!");
            hello.Main2(args);
            List<student> listybeaky = new List<student>();
            
            for ( int i= 1; i < 6; i++)
            {
                listybeaky.Add(new student() { name = "김"+i+"성", grade = rd.Next(1, 5) });
            }
            foreach ( var i in listybeaky)
            {
                Console.WriteLine(i.name + ":" + i.grade + "(이전)");
            }
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
        }
        
    }
    class hello
    {
        public static void Main2(string[] args)
        {
            
            Console.WriteLine("Which one will go first"); 
        }
    }
}
