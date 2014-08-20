using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exam_001
{
    class Program
    {
        static void Main(string[] args)
        {
            // C# 은 크게 2가지의 형태의 변수가 존재한다.
            // 벨류타입 ( 구조체형 )
            // 참조타입 ( 클래스형 )

            //
            // 벨류타입의  변수들....
            //

            int a = 10;
            Console.WriteLine("int {0}byte {1} ~ {2}", 
                sizeof(int),        //int 형변수 의 크기를 안다 ( 주의 사항 변수로 크기확인 안되고 자료형으로 알아야된다, 또한 크기는 참조형 변수는 알수 없다 ) 걱정하지 말아라 쓸일없다.
                int.MinValue,       //int 형변수 최소값
                int.MaxValue        //int 형변수 최대값
                );

            uint b = 20;
            Console.WriteLine("uint {0}byte {1} ~ {2}",
                sizeof(uint), 
                uint.MinValue, 
                uint.MaxValue);


            short c = 20;
            Console.WriteLine("short {0}byte {1} ~ {2}",
                sizeof(short),
                short.MinValue,
                short.MaxValue);

            ushort d = 20;
            Console.WriteLine("ushort {0}byte {1} ~ {2}",
                sizeof(ushort),
                ushort.MinValue,
                ushort.MaxValue);


            long e = 20;
            Console.WriteLine("long {0}byte {1} ~ {2}",
                sizeof(long),
                long.MinValue,
                long.MaxValue);
            
            ulong f = 20;
            Console.WriteLine("ulong {0}byte {1} ~ {2}",
                sizeof(ulong),
                ulong.MinValue,
                ulong.MaxValue);

            //Console.WriteLine(ulong.MaxValue / (31536000L * 1000000000L));
            decimal g = 20;
            Console.WriteLine("decimal {0}byte {1} ~ {2}",
                sizeof(decimal),
                decimal.MinValue,
                decimal.MaxValue);

            byte h = 10;
            Console.WriteLine("byte {0}byte {1} ~ {2}",
                sizeof(byte),
                byte.MinValue,
                byte.MaxValue);


            sbyte i = 10;
            Console.WriteLine("sbyte {0}byte {1} ~ {2}",
                sizeof(sbyte),
                sbyte.MinValue,
                sbyte.MaxValue);

            //char ch = 'A';      //c# 에 서는 기본적으로 문자체계가 유니코드이다 ( 따라서 char 형이 2byte 를 사용하게 된다 )
            //주의 사항
            //char ch = 65;       //문자에 숫자대입안됨 ( 참고로 C# 이 자료형에 대해서는 Cpp 보다 훨씬 엄격하다 ) //형변환을 확실하게 표시해주어야 한다??
            char ch = '송';
            Console.WriteLine(ch);
            Console.WriteLine("char {0}byte {1} ~ {2}",
                sizeof(char),
                char.MinValue,
                char.MaxValue);

          
            float pi = 3.141592f;           //float 리터럴 쓸때 f 반듯이 붙여야한다....
            double pi2 = 1.41321456237;     //double 은 f 안붙여도 된다........



            //
            // 참조형 변수
            //
            string str = "차차차";




        }
    }
}
