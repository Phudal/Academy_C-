using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProject05.반복문
{
    class Class5
    {
        static void Main()
        {
            Console.Write("출력할 단: ");
            int value = int.Parse(Console.ReadLine());

            int num = 1;
            while (num < 10)
            {
                Console.WriteLine(value + "*" + num + "=" + (value * num));
                num++;
            }

        }
    }
}
