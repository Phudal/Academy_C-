using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProject07.참조에의한_매개변수_전달
{
    class _04RefOut
    {
        static void Swap(ref int num1, ref int num2)
        {
            int tmp = num1;
            num1 = num2;
            num2 = tmp;
        }
        static void Main()
        {
            int A = 10, B = 20;
            Swap(ref A, ref B);
            Console.WriteLine("A = " + A + "\nB = " + B);
        }
    }
}
