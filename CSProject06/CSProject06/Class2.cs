using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProject06
{
    class Class2
    {
        static void Main()
        {
            //goto == 지정된 레이블 위치로 도약
            int A = 0;
            while (true)
            {
                if (A == 5)
                {
                    goto First;         //First로 도약
                }
                Console.WriteLine("A의 값은 " + (A++) + " 입니다.");
            }
        First:                          //도약 받음
            Console.WriteLine("First입니다.");
        }
    }
}
