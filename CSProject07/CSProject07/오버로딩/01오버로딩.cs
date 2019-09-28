using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProject07.오버로딩
{
    class _01오버로딩
    {
        // 오버로딩 조건
        // 메서드 이름이 같고, 매개변수의 갯수나 데이터 타입이 달라야함
        // 반환형식만 다른 경우에는 오버로딩 성립 X

        static int Add(int A, int B)
        {
            return (A + B);
        }
        static int Add(int A, int B, int C)
        {
            return (A + B + C);
        }
        static int Add(int A, int B, int C, int D)
        {
            return (A + B + C + D);
        }

        static void Main()
        {
            Console.WriteLine(Add(10, 20, 30, 40));
            Console.WriteLine(Add(10, 50));
        }
    }
}
