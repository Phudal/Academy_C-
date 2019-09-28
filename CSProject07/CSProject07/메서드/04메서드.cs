using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProject07
{
    class _04메서드
    {
        static int Sum(int num1, int num2)
        {
            return num1 + num2;
        }
        static void Main()
        {
            Console.WriteLine("A를 입력하세요: ");
            int A = int.Parse(Console.ReadLine());

            Console.WriteLine("B를 입력하세요: ");
            int B = int.Parse(Console.ReadLine());

            Console.WriteLine("A + B =" + Sum(A, B));
        }
    }
}
