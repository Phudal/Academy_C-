using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProject05.반복문
{
    class Class12
    {
        static void Main()
        {
            int re = 1;
            for (int i = 10; i >= 1; i--)
            {
                re *= i;
            }
            Console.WriteLine(re);
        }
    }
}
