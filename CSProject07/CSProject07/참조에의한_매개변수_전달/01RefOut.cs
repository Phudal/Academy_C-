using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProject07.참조에의한_매개변수_전달
{
    class _01RefOut
    {
        static void AddTen(int value)
        {
            value += 10;
        }

        static void Main()
        {
            int A = 0;
            AddTen(A);
            Console.WriteLine(A);
        }
    }
}
