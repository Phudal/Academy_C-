using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProject03._02단항연산자
{
    class operator02
    {
        static void Main()
        {
            int count = 0;
            ++count;
            Console.WriteLine(count);

            int count2 = 0;
            count2++;
            Console.WriteLine(count2);

            int num1 = 0, num2 = 0;

            Console.WriteLine("num1=" + (num1++));
            Console.WriteLine("num1=" + num1);


            Console.WriteLine("num2=" + (++num2));
            Console.WriteLine("num2=" + num2);
        }
    }
}
