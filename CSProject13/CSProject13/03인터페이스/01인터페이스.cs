using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 인터페이스
// 클래스와 비슷하지만, 메서드, 이벤트, 인덱서, 프로퍼티만 가질 수 있음
// 접근제한자 사용 불가능
// 다중 상속 가능
// interface 키워드 사용

public interface SampleInterface1
{
    // 해당 인터페이스를 상속받는 클래스에서 HelloWorld라는 메서드를 구현
    void HelloWorld();
}

public interface SampleInterface2
{
    void PrintHello();
}

public class SampleClass : SampleInterface1, SampleInterface2
{
    // 멤버 구현 두가지 방법
    // 1) 암묵적 구현
    // public 접근제한자 사용

    public void HelloWorld()
    {
        Console.WriteLine("세계에 오신 것을 환영합니다.");
    }
    // 2) 명시적 구현
    // private 접근제한자 사용
    // 노출시킬 필요가 없는 경우 사용
    // 인터페이스 여러 개에 같은 이름의 메서드가 있다면
    // 구현하는 클래스에서 각긱 다른 메서드로 구현할 수 있음

    void SampleInterface2.PrintHello()
    {
        Console.WriteLine("안녕이라고 인사합니다.");
    }
}

class _01인터페이스
{
    private static void Main()
    {
        new _01인터페이스().Entry();
    }
    private void Entry()
    {
        SampleClass sample = new SampleClass();
        // 암묵적 멤버 구현의 호출
        sample.HelloWorld();
        // 명시적 멤버 구현의 호출
        (sample as SampleInterface2).PrintHello();
    }
}