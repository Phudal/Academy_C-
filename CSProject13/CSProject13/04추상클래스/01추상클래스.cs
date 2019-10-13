using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 추상클래스 : 미완성된 클래스
// 클래스 구현은 가능하지만, 인터페이스처럼 상속을 시켜서 사용해야함
// 인스턴트화가 불가능
// abstract 키워드를 사용해서 추상 클래스를 선언
// 추상 메서드를 가질 수 있음

// 추상메서드 
// 몸체가 없는 메서드를 의미
// abstract 키워드를 사용해서 추상 메서드를 선언
// 추상메서드를 갖는 클래스는 무조건 추상 클래스가 되어야함

public abstract class SampleClassBase
{
    protected string Print;

    public void HelloPrint()
    {
        Console.WriteLine("추상클래스입니다.");
    }
    public abstract void AbstractMethod();
}

public class SampleClass : SampleClassBase
{
    public override void AbstractMethod()
    {
        Print = "추상 메서드 호출";
        Console.WriteLine(Print);
    }
}
class _01추상클래스
{
    private static void Main()
    {
        new _01추상클래스().Entry();
    }
    private void Entry()
    {
        // 추상클래스 인스턴트화 불가능
        // SampleClassBase sample = new SampleClassBase();
     
        SampleClass sample = new SampleClass();
        sample.HelloPrint();
        sample.AbstractMethod();
    }
}