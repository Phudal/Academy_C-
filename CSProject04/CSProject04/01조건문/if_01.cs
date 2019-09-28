using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProject04._01조건문
{
    class if_01
    {
        static void Main()
        {
            int N;
            Console.WriteLine("N의 값을 입력하세요:");
            N = int.Parse(Console.ReadLine());

            if (N > 100)
                Console.WriteLine("N은 100보다 큽니다");
            else
                Console.WriteLine("N은 100보다 작습니다.");
        }
    }
}
