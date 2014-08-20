using System;  //이것을 지우면 아래의 객체들을 사용을 못한다...즉, c++의 네임스페이스와 비슷하다고 보면 된다
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exam_000
{
    class Program
    {

        static void Main(string[] args)
        {
            //Console이라는 것의 함수를 사용하겠다라는 의미
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

            Console.WriteLine(a + " + " + b + " = " + a + b);  //순차적으로 연산하기 때문에 + a + b 역시 따로 연산되어 원하는 결과를 얻지 못한다..
            Console.WriteLine(a + " + " + b + " = " + (a + b));  //그러므로 우선순위 연산을 사용하여 적용한다.

            //위에처럼 문자열을 + 연산으로 조합하는 코드는 지양해야 한다.
            //성능저하가 온다. ( 왜성는저하가 오는지는 다음기회에... )
            //성능저하가 되는 이유는 c#에서는 포인터라는 개념이 없으나 아예 없는것이 아니다..
            //내부적으로 동적할당을 통해 객체를 생성하나 직접 해제는 할 수 없고 가브컬렌터???가 해제를 자동으로 관리 한다.  //가브컬렌터?? : 메모리의 제어나 해제를 관리해주므로 안정성이 뛰어나다. 단, 사용자가 직접 해제를 할 수 없고 만약 할려면 오히려 더 비용이 크다.
            //그러므로 위와 같은 코드는 연산을 하나씩 처리할때마다 내부적으로 동적할당을 하여 메모리가 계속 늘어나기 때문에 효율적이지 못하다..!
            //그렇기 때문에 아래와 같이 인덱스로 접근하는 방식으로 하는 것이 좋다.

            //printf( "%d + %d = %d\n", a, b, c );  //c++의 가변인자 사용법과 비슷하다.
            Console.WriteLine("{0} + {1} = {2}", a, b, c);  //인덱스로 사용하면 동적할당이 한번만 이루어지므로 효율적이다.
            Console.WriteLine("{1} + {0} = {2}", a, b, c);  //순서도 정할 수 있다.

            //printf( "%d + %d = %d\n", a, a, a );  //해당 갯수마다 변수가 필요하지만
            Console.WriteLine("{0} + {0} = {0}", a);  //동일한 인덱스을 사용할 경우 변수는 하나만 입력하면 된다.

            //예외 처리
            try
            {
                //문자열 서식으로 문자열으로 조합할때 인덱스가 부족한경우 예외발생 ( 예외가 뭔지 모르겠다면 일단 런타임 에러로 생각하자 )
                //신텍스에러 : 문법 에러(실행되기 전에 발생)
                //런타임에러 : 프로그램이 실행되고 있는 도중에 발생(c++의 NULL 참조 등)
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
            Console.WriteLine("{0,10}{1,10}", str, str2);  //왼쪽에서부터 빈자리 채움
            Console.WriteLine("{0,-10}{1,-10}", str, str2);  //오른쪽에서부터 빈자리 채움

            Console.WriteLine("프로그램 끝");




            





        
            
        }
    }
}
