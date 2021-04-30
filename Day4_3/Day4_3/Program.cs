using System;

namespace Day4_3
{
    class program
    {

        static void Main(string[] args)
        {
            Boxy box = new Boxy(10, 20);
            box.Width = 10;
            box.Height = 20;
            Boxy.Area();
        }

        class Boxy
        {
            private int width;
            public int Width
            {
                get { return width; }
                set
                {
                    if (value > 0) { width = value; }
                }

            }
            private int height;
            public int Height
            {
                get { return height; }
                set
                {
                    if (value > 0) { width = value; }
                }
            }
            //클래스의 상속. 상위 클래스의 이름을 해당 클래스의 옆 콜론과 함께 붙임.
            //class 나 : 부모님
            //상속을 받으면 내부 속성을 모두 가져가게 됨.
          

            
            //This- 코드 중복을 최대한 줄임- This 키워드..
            //this()는 자체의 다른 생성자를 호출할때 사용

            public Boxy(int width, int height) //생성자. 
                //반환값이 없음
                //메서드 이름은 반드시 클래스의 이름을 사용
                
                //특별한 메서드 2. 이름 앞에 ~를 붙인다. 
                //이를 소멸자라 부른다.
                //소멸자는 public 불가

            {
                Width = width;
                Height = height;
               
            }


            public int Area() {
                Console.WriteLine(this.width * this.height);
                    return this.width * this.height; }
        }
    
        
        
        }
    }
