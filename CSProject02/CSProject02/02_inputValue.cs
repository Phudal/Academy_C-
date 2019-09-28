using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProject02
{
    class _02_inputValue
    {
        static void Main()
        {
            int N;
            Console.WriteLine("N의 값을 넣어주세요.");
            N = int.Parse(Console.ReadLine());
            //N에 정수값 입력받기
            Console.WriteLine("결과: N의 값은 " + N + "입니다.");
        }
    }
}
