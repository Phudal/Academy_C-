using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProject05.반복문
{
    class Class7
    {
        static void Main()
        {
            //★☆
            int first = 1, second = 2;
            while (first < 10)
            {
                Console.WriteLine("☆★" + first + "단" + "★☆\n");
                while (second < 10)
                {
                    Console.WriteLine(first + " X " + second + " = " + (first * second));
                    second++;
                }
                second = 1;
                first++;
                Console.WriteLine();
            }
        }
    }
}
