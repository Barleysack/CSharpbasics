using System;

namespace Day3_1
{//객체는 상태와 행위로 나뉘어있더라.
    //status/action ->객체타입.
    //클래스를 만드는 것을 모델링이라고 한다.

    class Program
    {
        static int ADD_Number(int x, int y)
        {
            return x + y;

        }

        static double ADD_Number(double x, double y)
        {
            return x + y;

        }

        static void Main(String[] args)
        {
            Car car = new Car();
            Car car2 = new Car();//요걸 객체의 생성이라고 부른다.
            //car=객체 참조 변수. 
            //car는 객체가 아니고 객체를 가리키는 것
            //new로 Car 객체를 만든다. 
            //int는 기본형...
            //클래스를 만드는건 타입을 만드는 것
            //실물이냐-객체 개념이냐-클래스
            //new는 객체로 만들때 사용한다.
            //car는 객체로 보기도 한다.
            car.Vendor = "AUDI";
            car2.Vendor = "Tesla"
           //Vendor,speed,Accel,Break등은 클래스의 '멤버이다'

            car.Speed = 0;
            car2.Speed = 0;

            ADD_Number(2, 3);
        //메서드 오버로딩:메서드의 이름이 동일하고
        //인자의 순서나 타입이 다른 메소드를
        //2개 이상 만든 경우
        //이름이 같아도 인자가 다르다면. 오버로딩이 가능하다.
        //이는 객체지향 언어에서 중요한 부분이다.


        }
        static void Main4(string[] args)
        {
            var f = ADD_Number(2, 3);
            var e = ADD_Number(2.4, 3.2);
            Console.WriteLine(f);
           
        }



        static int hellothere(int a,int b)
        {
            int c = a * b;
            return c;
        }
        static void Main3(string[] args)
        {
            var d=hellothere(2, 3);
            Console.WriteLine(d);

        }
        static int Square(int Number)
        {
            return Number * Number;
        }

        static void Addy(int Number)
        {
            for( int i = 1; i<=Number; i++)
            {
                Console.WriteLine("ADDY HERE");
            }
            string[] hi = { "yi" };
            
            
                
        }
        static void Main2(string[] args)
        {
            Main1(args);
            Addy(10);
            var plot=Square(12);
            Console.WriteLine(plot);

        }



        static void Main1(string[] args)
        {//main이라는 메소드를 제일 먼저 실행시키겠다.
            //엔트리 포인트 개념 
            //Entry point-진입점


            Test();
            Test();
            Test2();
            Console.WriteLine(Test2());

        }
        static void Test()
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hello World!");
            
        }

        static int Test2()
        {
            double x = 120;
            double y = 130;
            double z = x + y;
            return (int)(z);
        }
    }
}
