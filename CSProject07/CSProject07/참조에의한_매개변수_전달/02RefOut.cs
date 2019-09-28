using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProject07.참조에의한_매개변수_전달
{
    class _02RefOut
    {
        static void AddNumber(ref int value, int number)
        {
            // 매개변수 앞 ref : 해당 매개변수에 전달되는 인수는 값이 아닌 참조로 전달
            value += number;
        }
        
        static void Main()
        {
            Console.Write("숫자를 입력해주세요: ");
            int A = int.Parse(Console.ReadLine());

            Console.WriteLine("A에 몇을 더할까요?");
            int B = int.Parse(Console.ReadLine());

            AddNumber(ref A, B);

            Console.WriteLine("A의 값은 " + A + " 입니다");
        }
    }
}
