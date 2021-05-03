using System;

namespace Short_test_01
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("값을 입력하세요 : ");
                int input = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"입력된 값은 {input} 입니다");
                Console.WriteLine("값을 입력하세요 : ");
              //직점 실행창 및 호출 스택  확인. 

            
                
            }
            catch (Exception ex)
            {

                Console.WriteLine($"예외발생:{ex.StackTrace}");
                throw;
            }
            {
                
            }
            int ival = 10;
            Console.WriteLine($"값은 {ival} 입니다");

            for (int i = 2; i < 10; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    Console.WriteLine($"{i}*{j}={i*j}");
                }
            }

        }
    }
}
