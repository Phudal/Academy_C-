using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProject03._07조건연산자
{
    class operator07
    {
        static void Main()
        {
            int candy = 5;
            string msg;
            msg = candy > 3 ? "사탕이 충분합니다" : "사탕이 부족합니다";
            Console.WriteLine(msg);

            int best,
                N = 10,
                M = 12;
            best = (N > M) ? N : M;
            Console.WriteLine(best + "가 더 큽니다");
        }
    }
}
