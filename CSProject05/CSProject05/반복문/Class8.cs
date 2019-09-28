using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProject05.반복문
{
    class Class8
    {
        static void Main()
        {
            int A = 10;
            do
            {
                Console.WriteLine("A = " + A);
                A -= 2;
            } while (A != 10 && A > 0);
        }
    }
}
