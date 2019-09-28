using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProject07.참조에의한_매개변수_전달
{
    class _03RefOut
    {
        // Ref 한정자 사용시 참조 반환 가능
        // 반환 형식에 ref 한정자를 작성하고, return문이 반환하는 
        // 변수 앞에도 ref 키워드를 명시

        // 매개 변수로 전달된 variableForPass를 참조 반환하는 메서드
        static ref int GetRefData(ref int variableForPass)
        {
            return ref variableForPass;
        }
        static void Main()
        {
            int A = 10;
            ref int B = ref GetRefData(ref A);
            ref int C = ref B;
            C = 100;

            Console.WriteLine("A = " + A);
            Console.WriteLine("B = " + B);

            Console.WriteLine("C = " + C);
        }
    }
}
