using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProject07.매개변수
{
    class _01매개변수
    {
        static int GetHigh(int num1, int num2)
        {
            Console.WriteLine("num1 = " + num1);
            Console.WriteLine("num2 = " + num2);

            return (num1 >= num2) ? num1 : num2;
        }
        static void Main()
        {
            Console.WriteLine("비교할 첫번째 숫자 입력: ");
            int A = int.Parse(Console.ReadLine());
            Console.WriteLine("비교할 두번째 숫자 입력: ");
            int B = int.Parse(Console.ReadLine());

            int best = GetHigh(num1 : A, num2: B);
            Console.WriteLine();
            Console.WriteLine("더 큰수는 " + best + " 입니다.");
        }
    }
}
