using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 가변 인자 매개변수
// 개수가 유연하게 변할 수 있는 매개변수
// 매개변수의 개수에 따라 오버로딩을 처리해주지 않아도 됨
// params 키워드와 배열을 사용
// 선언 한 뒤, 매개변수를 선언할 수 없음


class _01가변인자매개변수
{
    private void PrintAll(params string[] prints)
    {
        foreach (string str in prints)
            Console.WriteLine(str);
    }

    private static void Main()
    {
        new _01가변인자매개변수().Entry();
    }
    private void Entry()
    {
        PrintAll("나는", "C#과", "유니티가", "너무", "재밌어요");
    }
}
