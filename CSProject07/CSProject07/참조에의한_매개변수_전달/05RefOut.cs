using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProject07.참조에의한_매개변수_전달
{
    class _05RefOut
    {
        // 출력 전용 매개변수 Out
        // out은 ref처럼 참조 전달을 할 때 사용
        // ref와는 다르게 매개변수에 전달되는 인수가 메서드 내부에서 할당

        static void Divide(int a, int b, out int Quotient, out int Remainer)
        {
            Quotient = a / b;
            Remainer = a % b;
        }
        
        static void Main()
        {
            Console.WriteLine("A를 입력하시오: ");
            int A = int.Parse(Console.ReadLine());

            Console.WriteLine("B를 입력하시오: ");
            int B = int.Parse(Console.ReadLine());
            int Q, R;

            Divide(A, B, out Q, out R);

            Console.WriteLine("A % B 결과");
            Console.WriteLine("몫: " + Q);
            Console.WriteLine("나머지 " + R);
        }
    }
}
