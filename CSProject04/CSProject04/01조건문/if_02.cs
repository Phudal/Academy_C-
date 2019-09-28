using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProject04._01조건문
{
    class if_02
    {
        static void Main()
        {
            Console.Write("값을 입력하세요:");
            int N = int.Parse(Console.ReadLine());

            if (N % 3 == 0)
                Console.WriteLine("3의 배수");
            else
                Console.WriteLine("3의 배수가 아님");
            Console.WriteLine(N);
        }
    }
}
