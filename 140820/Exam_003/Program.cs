using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exam_003
{
    class Program
    {
        static void Main(string[] args)
        {
           
            //논리 이항 연산 
            // &&       A && B = A 와 B 가 참일때 참
            // ||       A || B = A 나 B 둘중 하나라도 참이면 참

            int num1 = 10;
            int num2 = 20;
            int num3 = 30;
            int num4 = 40;

            if ((++num1 > ++num2) || (++num3 < ++num4))
            {
                Console.WriteLine("참");
            }
            else
            {
                Console.WriteLine("거짓");
            }

            Console.WriteLine("{0} {1} {2} {3}", num1, num2, num3, num4);


            //논리 단항 !Not
            bool b = !( 10 > 20 );

            //!논리       
            //참은 거짓으로 참조되고 거짓은 참으로 참조된다.
            Console.WriteLine(b);

            int number = 3;

            if (number > 9)
                Console.WriteLine("number 는 9 보다 크다");

            else if (number > 5)
               Console.WriteLine("number 는 5 보다 크다");

            else if (number > 3)
               Console.WriteLine("number 는 3 보다 크다");

            else
               Console.WriteLine("number 는 3 보다 작거나 같다");

            /*
            for (int i = 0; i < 10; i++)
                if (i > 5)
                    Console.WriteLine(i);
                else
                    Console.WriteLine("아직5를 안넘었다");
            */
            
        }
    }
}
