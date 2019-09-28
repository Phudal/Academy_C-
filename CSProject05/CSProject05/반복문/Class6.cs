using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProject05.반복문
{
    class Class6
    {
        static void Main()
        {
            int A = 0;
            while (A < 3)
            {
                int B = 0;
                Console.WriteLine(A++);
                while (B < 3)
                {
                    Console.WriteLine("     " + B++);
                }
            }
        }
    }
}
