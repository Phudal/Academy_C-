using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProject02
{
    class datatype
    {
        enum Food { COOKIE = 300, CAKE, DOUGHNUT};
        static void Main()
        {
            //데이터          키워드         메모리 차지          값의 표현
            //타입                           용량(byte)            범위
            //
            //무치형
            //                 void            0                   없습니다
            //정수형           
            //                 sbyte           1                   -128 ~ 127
            //                 short           2                   -32768 ~ 32767
            //                 int             4                   -21억 ~ 21억
            //                 long            8                   -928경 ~ 928경
            //음수 부호가 없는 자료형
            //                 byte            1                   0 ~ 255
            //                 ushort          2                   0 ~ 65535
            //                 uint            4                   0 ~ 42억
            //                 ulong           8                   0 ~ 1844경
            //실수형
            //                 float           4                   유효자리 7자리
            //                 double          8                   유효자리 15자리
            //                 decimal         16                  유효자리 28자리
            //열거형
            //                 enum            4                   정수를 대신해서 사용하는
            //                                                     목록형 자료형(상수값)
            //                                                     해당 상수에 대해 값을 따로 지정하지 않는다면
            //                                                     0부터 차례대로 값이 들어갑니다.
            //논리형
            //                 bool            1                   true / false
            //문자형
            //                 char            2                   문자 1개
            //문자열
            //                 string                              문자열 저장

            Console.WriteLine("정수형__");

            int i;
            i = 2100000000;
            Console.WriteLine("i = " + i);
            //MaxValue, MinValue
            //최댓값, 최솟값
            int intmax = int.MaxValue;
            int intmin = int.MinValue;
            Console.WriteLine("intmax = " + intmax + ", intmin = " + intmin);

            Console.WriteLine();
            Console.WriteLine("실수형__");

            float f = 3.14159f;
            //float 사용시 f를 붙임
            Console.WriteLine("f = " + f);

            double d = 123.456789;
            Console.WriteLine("d = " + d);

            decimal dm = 123.4567m;
            //decimal 사용시 m을 붙임
            Console.WriteLine("dm = " + dm);

            Console.WriteLine();
            Console.WriteLine("열거형__");

            Food E1 = Food.COOKIE;
            Console.WriteLine("E1 = " + E1);

            Console.WriteLine();
            Console.WriteLine("논리형__");
            bool b1 = true;
            Console.WriteLine("b1 = " + b1);
            //C#에서는 bool형 정수로 출력 불가

            Console.WriteLine();
            Console.WriteLine("문자형__");
            char c = '가';
            Console.WriteLine("c = " + c);

            Console.WriteLine();
            Console.WriteLine("문자열__");
            string str = "안녕하세요";
            Console.WriteLine("str = " + str);

            Console.WriteLine();
            //상수 사용법: 자료형 앞에 const를 넣음
            const int MY_NUMBER = 30;
            Console.WriteLine("MY_NUMBER = " + MY_NUMBER);
        }
    }
}
