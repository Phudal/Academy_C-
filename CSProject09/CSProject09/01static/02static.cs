using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// 만약 static 한정자를 이용해서 클래스를 선언
// 해당 클래스는 인스턴트 필드를 가질 수 없음
// 멤버는 무조건 상수나, static 메서드

static class StaticClass
{
    public const int Level = 99;

    public static void PrintLevel()
    {
        Console.WriteLine("레벨: " + Level);
    }
}


class _02static
{
    static void Main()
    {
        new _02static().Entry();
    }
    void Entry()
    {
        StaticClass.PrintLevel();
        // 어떠한 클래스에 선언된 상수값은 타 클래스에서 수정 불가
        // StaticClass.Level = 1;
        Console.WriteLine("Level = " + StaticClass.Level);
    }
}

