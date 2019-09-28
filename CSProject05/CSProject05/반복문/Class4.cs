using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProject05.반복문
{
    class Class4
    {
        static void Main()
        {
            int num = 10;         
            int nfac = f_fac.re_fac(num);
            Console.WriteLine(nfac);
        }
    }
    
}
class f_fac
{
    int re_fac(int value)
    {
        int fac = 1;
        while (value > 0)
        {
            fac = fac * value;
            value--;
        }
        return fac;
    }
}