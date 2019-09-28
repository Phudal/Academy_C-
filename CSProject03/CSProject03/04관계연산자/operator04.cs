using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProject03._04관계연산자
{
    class operator04
    {
        static void Main()
        {
            int a = 5,
                b = 5,
                c = 10;

            bool check1 = (a == b);
            Console.WriteLine(check1);

            bool check2 = (a == c);
            Console.WriteLine(check2);

            bool check3 = !(b == c);
            Console.WriteLine(check3);

            bool check4 = (a > b);
            Console.WriteLine(check4);

            bool check5 = (a < c);
            Console.WriteLine(check5);
        }
    }
}
