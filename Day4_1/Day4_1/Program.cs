using System;


class SF
{
    public static string Name = "스마트 팩토리";
}
class Car
{
    // 인스턴스 변수 :
    // 객체가 생성되면 같이 생성되고
    // 객체가 제거되면 같이 제거되는 변수


    // 클래스/static 변수
    // 1. 프로그램 시작부터 생성
    // 2. 프로그램 종료까지 유지
    // 3. 객체(혹은 인스턴스)를 생성하지 않고 사용 가능
    // 4. 모든 객체들이 공통으로 사용(단 1개만 생성)
    public int SerialNumber;
    public static int SNR;

    
    public void SetSerial()
    {
        Forandom frd = new Forandom();
        SNR = frd.rnd.Next(1000, 5000);
        SerialNumber = SNR;
       
    }
}
class Forandom
{
    public Random rnd = new Random();
    
    
    
}
class Program
{
    
    
    
    static void Main(string[] args) // Main 메서드
    {
       
        
    // 지역 변수 :
    // 메서드에서 선언되면 생성되고
    // 메서드가 종료하면 제거되는 변수
    // aCarA(객체 참조 변수)  : type=> Car
    // aCarB(객체 참조 변수)  : type=> Car
    // iNum(변수)             : type=> int

    //int iNum = 200;

    Car aCarA = new Car();
        aCarA.SetSerial();
        Car aCarB = new Car();
        aCarB.SetSerial();
        Car aCarC = new Car();
        aCarC.SetSerial();
        Car aCarD = new Car();
        aCarD.SetSerial();
        Random rnrn = new Random();
        Console.WriteLine(aCarA.SerialNumber);
        Console.WriteLine(aCarB.SerialNumber);
        Console.WriteLine(aCarC.SerialNumber);
        Console.WriteLine(aCarD.SerialNumber);
        Console.WriteLine("1번 학생은 " + SF.Name+Integer.toString()
    }
}