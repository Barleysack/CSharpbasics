using System;

using System.Collections.Generic;
namespace Day2_2
{
    class Program
    {






        static void Main(string[] args)
        {

            Console.WriteLine(CALC.Power(20));
            Console.WriteLine(CALC.Multi(30, 20));
            Console.WriteLine(CALC.Div(20, 6));
            Console.WriteLine(CALC.Add(12, 12));
            Console.WriteLine(CALC.Str(12, 3));
            Console.WriteLine(CALC.Summy(1, 200));
            Console.WriteLine(CALC.Abs(-400));
            Console.WriteLine("몇월이고");
            //오-버로딩



            int month = int.Parse(Console.ReadLine());
            switch (month)
            {
                case 12 or 1 or 2:
                    Console.WriteLine("겨울이네");
                    break;
                case 3 or 4 or 5:
                    Console.WriteLine("봄이네");
                    break;

                case 9 or 10 or 11:
                    Console.WriteLine("가을");
                    break;

                case 6 or 7 or 8:
                    Console.WriteLine("여름이지?");
                    break;

                default:
                    Console.WriteLine("?");
                    break;

            }
           
            for (int i = 0; i<10; ++i)
            {
               if ((i+1)%2==0) 
                    Console.WriteLine(i+1);
               
            }



        }
                    
                     

                    }




}





/*Custom_2 customy = new Custom_2();

List<Custom_2> custylist = new List<Custom_2>();
custylist.Add(new Custom_2() { age = 27, name = "김우식" });
custylist.Add(new Custom_2() { age = 21, name = "김수식" });
custylist.Add(new Custom_2() { age = 23, name = "김미식" });
custylist.Add(new Custom_2() { age = 26, name = "김양식" });
custylist.Add(new Custom_2() { age = 21, name = "김가식" });
custylist.Add(new Custom_2() { age = 22, name = "김서식" });
int tow;
tow = 23;
for (int i = custylist.Count - 1; i>=0; i--)
{
    if (custylist[i].age > tow)
    {
        custylist.RemoveAt(i);
    }
}
foreach (var item in custylist)
{
    Console.WriteLine(item.name + ":" + item.age);
}

if (DateTime.Now.Hour > 12)
{
    Console.WriteLine(DateTime.Now.ToString("tt hh mm ss"));

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
    Console.WriteLine(customy.age);
}*/


/*         static void Main3(string[] args)
{
 if (DateTime.Now.Hour > 12)
 {
     Console.WriteLine(DateTime.Now.ToString("tt hh mm ss"));

 }
}
class Custom_2
{
 public string name;
 public double phone_number;
 public int age;

}
static void hey(string[] args)
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
 list.Add(12);
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


/*
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

*/
