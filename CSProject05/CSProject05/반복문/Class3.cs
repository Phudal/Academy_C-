using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProject05.반복문
{
    class Class3
    {
        static void Main()
        {
            int sum = 0, num = 1;
            while (num <= 100)
            {
                sum += num;
                num++;
            }
            Console.WriteLine(sum);
        }
    }
}
