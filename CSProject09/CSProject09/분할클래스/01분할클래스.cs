using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// 분할 클래스
// 여러번 나눠서 구현하는 클래스
// 클래스가 길어질 시에 사용
// 클래스 키워드 앞에 partial 키워드 사용
// 분할 작성할 클래스의 이름은 같아야함

partial class MyClass
{
    public void TestMethod1()
    {
        Console.WriteLine("TestMethod1 호출됨");
    }
    public void TestMethod2()
    {
        Console.WriteLine("TestMethod2 호출됨");
    }
}
partial class MyClass
{
    public void TestMethod3()
    {
        Console.WriteLine("TestMethod3 호출됨");
    }
    public void TestMethod4()
    {
        Console.WriteLine("TestMethod4 호출됨");
    }
}


class _01분할클래스
{
    MyClass myClass = null;
    // 객체 초기화를 위해 null
    static void Main()
    {
        new _01분할클래스().Entry();
    }
    void Entry()
    {
        myClass = new MyClass();

        myClass.TestMethod1();
        myClass.TestMethod2();
        myClass.TestMethod3();
        myClass.TestMethod4();
    }

}