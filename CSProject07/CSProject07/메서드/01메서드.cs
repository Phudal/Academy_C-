using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProject07
{
    class _01메서드
    {
        static void Main()
        {
            //한정자 반환형식 메서드이름(매개변수)
            //한정자 : 메서드 속성
            //static : PrintHello, Main 등을 정적 메서드로 선언
            //void : 무반환형
            PrintHello(50);
        }

        static void PrintHello(int value)
        {
            Console.WriteLine("Hello, you called " + value);
        }
    }
}
