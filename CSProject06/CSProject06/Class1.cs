using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProject06
{
    class Class1
    {
        static void Main()
        {
            int A = 0;
            while (A < 5)
            {
                Console.WriteLine("A = " + A);

                System.Threading.Thread.Sleep(500);
                //System.Threading == 다중 스레드 프로그래밍을 할 수 있는 
                //클래스와 인터페이스를 제공하는 네임스페이스
                //
                //Thread == 스레드를 만들고 제어하는 클래스
                //

                if (A == 3)
                {
                    continue;
                }
                A++;
            }
        }
    }
}
