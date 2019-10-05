using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 튜플
// 여러 필드를 담을 수 있는 구조체
// 형식의 이름을 가지지 않는 구조체
// 튜플은 응용 프로그램 전체에서 사용할 형식을 선언 할 때가 아닌
// 암묵적으로 사용할 복합 데이터 형식을 선언할 때 사용


class _01튜플
{
    public enum HumanGender { Man, Woman }

    private static void Main()
    {
        new _01튜플().Entry();
    }
    private void Entry()
    {
        // 튜플 선언 방법
        // 괄호 사이에 두개 이상의 필드를 지정함으로써 만들 수 있음
        // 각각 입력한 튜플의 필드에는 Item1 - N 으로 접근 할 수 있음

        var tempTuple = (123, 456);

        // tempTuple -> unnamed Tuple(명명되지않은 튜플)이라고 함
        // Item1 -> 123, Item2 = 456
        // 튜플에는 valueTuple 구조체 형식 기반으로 만들어짐

        Console.WriteLine("Item1 = " + tempTuple.Item1);

        // 명명된 튜플
        // 각 필드에 이름을 선언하는 방식
        var namedTuple = (Name: "박진혁", Age: 29, Gender: HumanGender.Man);

        Console.WriteLine("namedTuple.Name = " + namedTuple.Name);
        Console.WriteLine("namedTuple.Age = " + namedTuple.Age);
        Console.WriteLine("namedTuple.Gender= " + namedTuple.Gender);
    }
}