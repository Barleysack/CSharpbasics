using System;

namespace Codingtest_01
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 4; i++)
            {
                Console.Write("3,6,9! ");

            }
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            for (int i = 0; i < 11; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    string k = i.ToString();
                    string f = j.ToString();
                    string GOAL = k + f;

                    if (int.Parse(GOAL) <= 100)
                    {


                        if (i == 0)
                        {


                            if (j % 3 == 0)
                            {
                                Console.Write("짝!    ");
                            }
                            else if (j % 6 == 0)
                            {
                                Console.Write("짝!    ");
                            }
                            else if (j % 9 == 0)
                            {
                                Console.Write("짝!    ");
                            }
                            else
                            {
                                Console.Write($"{f}    ");
                            }
                        }
                        else if (i == 10) 
                        {
                            Console.Write($"{GOAL}    ");
                        }
                        else
                        {
                            if (i % 3 == 0)
                            {
                                Console.Write("짝!   ");
                            }
                            else if (i % 6 == 0)
                            {
                                Console.Write("짝!   ");
                            }
                            else if (i % 9 == 0)
                            {
                                Console.Write("짝!   ");
                            }
                            else if (j % 3 == 0)
                            {
                                Console.Write("짝!   ");
                            }
                            else if (j % 6 == 0)
                            {
                                Console.Write("짝!   ");
                            }
                            else if (j % 9 == 0)
                            {
                                Console.Write("짝!   ");
                            }
                            else
                            {
                                Console.Write($"{GOAL}    ");
                            }






                        }
                    }
                }


            }
        }
            

            
            
        
    }
}
