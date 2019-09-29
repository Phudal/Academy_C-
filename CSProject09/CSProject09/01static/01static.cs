using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProject09._01static
{
    // static ?
    // 키워드 뒤에 오는 필드(변수), 메서드(기능)을 인스턴스(객체)에 소속시키는 것이 아닌
    // 클래스 자체에 소속되도록 하는 한정자
    // 멤버 변수는 정적 필드(변수)가 되며, 메서드는 정적 메서드(기능)가 됨

    // 정적 변수나 정적 메서드, 인스턴스 변수, 인스턴스 메서드의 차이점
    // 인스턴수 변수, 메서드
    // 무조건 특정 클래스 형식으로 인스턴스 만들고 메서드를 호출
    // 무조건 특정 클래스 형식으로 인스턴스 만들고 변수도 호출
    // 각각 다른 인스턴스마다 다른 값을 가질 수 있음

    // 정적 클래스, 메서드
    // 클래스에 소속되어 있기 때문에 인스턴스를 만들지 않아도 사용 가능


    class SampleClass01
    {
        public static int Number = 0;
        public const int A = 10;

        public static void PrintNumber()
        {
            Console.WriteLine("SampleClass01.Number = " + Number);
            Console.WriteLine("A = " + A);
        }
    }
    class SampleClass02
    {
        public int Number = 0;

        public void PrintNumber()
        {
            Console.WriteLine("Number = " + Number);
        }
    }


    class _01static
    {
        SampleClass02 sample01 = new SampleClass02();
        SampleClass02 sample02 = new SampleClass02();

        static void Main()
        {
            new _01static().Entry();
        }
        void Entry()
        {
            SampleClass01.Number = 100;
            SampleClass01.PrintNumber();
            Console.WriteLine("SampleClass01.A = " + SampleClass01.A);

            sample01.Number = 100;
            sample02.Number = 200;

            sample01.PrintNumber();
            sample02.PrintNumber();
        }
    }
}
