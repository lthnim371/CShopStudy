using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exam_000
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.Write("안녕하세요");     //출력하고 줄안바꿈
            Console.WriteLine("안녕하세요"); //출력하고 줄바꿈


            //CPP
            // .    직접접근 
            //->    간접접근
            //::    네임스페이스접근

            //위와 같은 Cpp 접근 관련연산자들이 
            //C# 에서는 . 으로 대동단결된다.


            //문자열 변수 string  ( cpp 에서 stl 지원하던게 기본이다 )
            string str = "송대관";
            string str2 = "태진아";

            Console.WriteLine(str);
            Console.WriteLine(str2);

            string result = str + str2; //문자열끼리 덧셈가능
            Console.WriteLine(result);
            Console.WriteLine("빨간건 " + "현아");

  
            //c# 의 모든 변수는 문자열열화가 가능하다.
            int a = 10; 
            int b = 20;
            int c = a + b;
            //cout << a << " + " << b << " = " << c << endl;
            Console.WriteLine(a + " + " + b + " = " + c);


            string s = a.ToString();        //int 형 변수 a 를 문자열 "10" 바꿔 s 에 대입
            Console.WriteLine(s);

            Console.WriteLine(a + " + " + b + " = " + a + b);
            Console.WriteLine(a + " + " + b + " = " + (a + b));

            //위에처럼 문자열을 + 연산으로 조합하는 코드는 지양해야 한다.
            //성능저하가 온다. ( 왜성는저하가 오는지는 다음기회에... )


            //printf( "%d + %d = %d\n", a, b, c );
            Console.WriteLine("{0} + {1} = {2}", a, b, c);
            Console.WriteLine("{1} + {0} = {2}", a, b, c);

            //printf( "%d + %d = %d\n", a, a, a );
            Console.WriteLine("{0} + {0} = {0}", a);


            try
            {
                //문자열 서식으로 문자열으로 조합할때 인덱스가 부족한경우 예외발생 ( 예외가 뭔지 모르겠다면 일단 런타임 에러로 생각하자 )
                Console.WriteLine("{0} {1}", a);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


            //문자열 조합 서직양식
            //{인덱스}
            //{인덱스,차지할칸정수}
            //{인덱스:양식}
            //{인덱스,차지할칸정수:양식}

            //양식
            //X 16진수
            //D 10진수
            //O 8진수
            //F 실수

            //X10 16진수를 10자리로표현 자릿수가 없는 곳은 0 으로 채움
            //D12 10진수를 12자리로표현 자릿수가 없는 곳은 0 으로 채움
            //F5  실수를 소숫점 5자리까지
            

            int number = 65535;
            //float pi = 3.141592f;
            float pi = 0.1234567891234f;

            Console.WriteLine("{0}", number);
            Console.WriteLine("{0:X}", number);
            Console.WriteLine("{0:X8}", number);
            Console.WriteLine("{0:D13}", number);
            Console.WriteLine("{0:F}", pi);
            Console.WriteLine("{0:F10}", pi);

            Console.WriteLine("{0,10:X8}", number); //number 를 10 자리를 차지하여 오른쪽 정렬로 16진수 8자리수를 표현
            Console.WriteLine("{0,2:X8}", number);  //자리수가 부족하면 무시된다.

            float alpha = 1.0f;
            float red = 1.0f;
            float green = 0.0f;
            float blue = 1.0f;
            //[ffffffff]

            byte alphabyte = (byte)(255 * alpha);
            byte redbyte = (byte)(255 * red);
            byte greenbyte = (byte)(255 * green);
            byte bluebyte = (byte)(255 * blue);

            int color = ( alphabyte << 24 ) | ( redbyte << 16 ) | ( greenbyte << 8 ) | bluebyte;


            //string.Format() 포맷 양식으로 문자열을 만듬
            string colorString = string.Format("[{0:X8}]", color);
            Console.WriteLine(colorString);



            Console.WriteLine("{0}{1}", str, str2);
            Console.WriteLine("{0,10}{1,10}", str, str2);
            Console.WriteLine("{0,-10}{1,-10}", str, str2);

            Console.WriteLine("프로그램 끝");




            





        
            
        }
    }
}
