using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProject03._01연산자
{
    class operator01
    {
        static void Main()
        {
            int N = 30;
            int M = 20;
            Console.WriteLine("덧셈 연산자 : " + (N + M));
            Console.WriteLine("뺄셈 연산자 : " + (N - M));

            int add = N + M;
            int sub = N - M;
            int mul = N * M;
            int div = N / M;
            int rem = N % M;

            Console.WriteLine(add);
        }
    }
}
