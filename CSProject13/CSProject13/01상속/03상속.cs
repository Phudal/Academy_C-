using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 상속의 생성자, 종료자 호출 순서
// 생성자 : 최상위 기반 클래스의 생성자부터 제일 마지막으로 파생된 클래스 순서대로 호출
// 종료자 : 최하위의 파생 클래스부터 최상위 클래스의 순서대로 호출

public class A
{
    public A() { Console.WriteLine("A의 생성자 호출"); }
    ~A() { Console.WriteLine("A의 소멸자 호출"); }
}

public class B : A
{
    public B() { Console.WriteLine("B의 생성자 호출"); }
    ~B() { Console.WriteLine("B의 소멸자 호출"); }
}

public class C : B
{
    public C() { Console.WriteLine("C의 생성자 호출"); }
    ~C() { Console.WriteLine("C의 소멸자 호출"); }
}

class _03상속
{
    private static void Main() {
        new _03상속().Entry();
    }
    private void Entry()
    {
        new C();
    }
}