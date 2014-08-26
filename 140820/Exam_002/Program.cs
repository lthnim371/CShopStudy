using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exam_002
{
    class Program
    {
        static void Main(string[] args)
        {
            // +, -, * , / , % 더 이상의 자세한 설명은 생략한다.
            
            //cpp 와 % 연산이 조금 다른데 c# 에서는 정수는 물론 실수까지 
            //% 연산이 가능하다.

            float val1 = 10.0f;
            float val2 = 3.0f;
            float result = val1 % val2;     //실수의 나머지값은 몫이 정수인경우의 나머지값이다.

            Console.WriteLine("{0} % {1} = {2}", val1, val2, result);



            //변수에 접근한다는 것은 크게 참조와 대입이 있다.
            //참조는 변수에 어떤값이 들어있는지 확인하는 것이고
            //대입은 변수에 어떤값을 넣은 것이다.
            int a = 10;
            int b = 20;
            int c = 0;
            c = a + b;        //a 에대한 참조, b 에 대한 참조, c 에 대한 대입

            a += 10;            //참조가 가능해야 스스로 10 증가가가능하다.
            // a = a + 10;


            // ++, -- 

            int num = 10;
            int result2 = num++;
            Console.WriteLine("{0} {1}", num, result2);

            //위의 전치 후치 증감문은 참조와 대입이 같이 일어난다.
            num = 0;
            //++num;      //1 증가

            //a = ++num; 
            //a = num++;
            Console.WriteLine("{0}", ++num);
            Console.WriteLine("{0}", num++);
            Console.WriteLine("{0}", num);

            //비트 2 항
            // &    ( 두비트를 비교하여 둘다 1 이면 1  아니면 0 )
            // |    ( 두비트를 비교하여 둘중 하나라도 1 이면 1 아니면 0 )
            // ^    ( 두비트를 비교하여 둘다 다른 경우 1 아니면 0 )


            a = 10;
            b = 3;
            Console.WriteLine("{0} & {1} = {2}", a, b, a & b);
            // 0000 0000 0000 0000 0000 0000 0000 1010
            // 0000 0000 0000 0000 0000 0000 0000 0011
            // &연산
            // 0000 0000 0000 0000 0000 0000 0000 0010 => 2

            Console.WriteLine("{0} | {1} = {2}", a, b, a | b);
            // 0000 0000 0000 0000 0000 0000 0000 1010
            // 0000 0000 0000 0000 0000 0000 0000 0011
            // |연산
            // 0000 0000 0000 0000 0000 0000 0000 1011 => 11


            Console.WriteLine("{0} ^ {1} = {2}", a, b, a ^ b);
            // 0000 0000 0000 0000 0000 0000 0000 1010
            // 0000 0000 0000 0000 0000 0000 0000 0011
            // ^연산
            // 0000 0000 0000 0000 0000 0000 0000 1001 => 9


            a = 10;
            b = -1;
            Console.WriteLine("{0} & {1} = {2}", a, b, a & b);
            Console.WriteLine("{0} | {1} = {2}", a, b, a | b);
            Console.WriteLine("{0} ^ {1} = {2}", a, b, a ^ b);  //


            // 0000 0000 0000 0000 0000 0000 0000 1010
            // 1111 1111 1111 1111 1111 1111 1111 1111
            // ^ Xor
            // 1111 1111 1111 1111 1111 1111 1111 0101


            int 검           = 0x001;        //1             
            int 활           = 0x002;        //2             
            int 창           = 0x004;        //4
            int 마법서       = 0x008;        //8
            int 단검         = 0x010;        //16

            //int 사용가능무기 = 검 | 창 | 마법서;
            int 사용가능무기 = -1 ^ 단검;   //다쓰는데 단검만 못씀



            if ((사용가능무기 & 검) != 0) 
                Console.WriteLine("검 사용 가능");
            
            if ((사용가능무기 & 활) != 0) 
                Console.WriteLine("활 사용 가능");
            
            if ((사용가능무기 & 창) != 0) 
                Console.WriteLine("창 사용 가능");
            
            if ((사용가능무기 & 마법서) != 0) 
                Console.WriteLine("마법서 사용 가능");
            
            if ((사용가능무기 & 단검) != 0) 
                Console.WriteLine("단검 사용 가능");

            //비트 단항 연산
            int d = 10;
            int e = ~d;     //~ 비트 Not ( 1 은 0 으로 0 은 1로 참조됨 )
            Console.WriteLine(e);


            //비트 쉬프트 << 
            a = 10;         // a << b == a * (2^b)
            b = 2;
            Console.WriteLine("{0} << {1} = {2}", a, b, a << b);

            a = 80;         // a >> b == a / (2^b)
            b = 2;
            Console.WriteLine("{0} >> {1} = {2}", a, b, a >> b);

            a = -1;
            b = 10;
            Console.WriteLine("{0} >> {1} = {2}", a, b, a >> b);    //비트를 오른쪽으로 밀면 (좌측에 새롭게 채워지는 값이 이전의 부호 비트에 따른다 )
            
            //3byte 24bit Pixel 이미지의 Pitch 데이터를 비트연산으로 구해보자...
            int pixel = 6;
            //int pitchByteSize = ( (3 * pixel)&~3) | ((pixel + 3) & ~3);
            //Console.WriteLine(pitchByteSize);

            //아래의 2 개의 숫자를 바꿔라 단 다른 변수의 사용은 안된다. 
            int number1 = 30000;
            int number2 = 20;
            number1 += number2 << 16;  //안전하게 2byte만 이동하여 보관
            number2 += number1 << 16;
            number1 = number1 >> 16;
            number2 = number2 >> 16;
            Console.WriteLine("number1 = {0} , number2 = {1}" , number1, number2);

           //Console.WriteLine( (6 + 3)&~3 );

            



            

        }
    }
}
