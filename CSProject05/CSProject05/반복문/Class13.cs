using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProject05.반복문
{
    class Class13
    {
        static void Main()
        {
            for (int i = 0; i <= 5; i++)
            {
                for (int j = 0; j < i; j++)
                    Console.Write("* ");
                Console.WriteLine();
            }

            for (int i = 5; i >= 0; i--)
            {
                for (int j = 0; j < i; j++)               
                    Console.Write("* ");               
                Console.WriteLine();
            }

            for (int i = 0; i < 5; i++)
            {
                for (int j = 5; j > i; j--)
                    Console.Write("  ");
                for (int j = 0; j <= (i * 2); j++)
                    Console.Write("* ");
                Console.WriteLine();
            }

            for (int i = 5; i >= 0; i--)
            {
                for (int j = 5; j > i; j--)
                    Console.Write("  ");
                for (int j = 0; j <= (i * 2); j++)
                    Console.Write("* ");
                Console.WriteLine();
            }
        }
    }
}
