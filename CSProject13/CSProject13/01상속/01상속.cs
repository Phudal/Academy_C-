using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 상속
// 부모가 가지고 있는 것을 자식 클래스가 물려받아 같이 공유하며
// 더 나아가 확장하는 개념
// 비슷한 클래스들의 공통된 코드를 묶어 기반 클래스를 만들고,
// 새로운 클래스를 작성할 때 같은 코드를 다시 작성하지 않도록 하여
// 생산성을 높이는 기법을 의미
// 클래스에서만 상속 가능
// C#에서는 다중상속 불가

public class BaseClass
{
    public void BaseMethod()
    {
        Console.WriteLine("기반 클래스 호출");
    }        
}
public class ChildClass : BaseClass
{
    public void ChildMethod()
    {
        Console.WriteLine("자식 클래스 호출");
    }
}
class _01상속
{
    private static void Main()
    {
        new _01상속().Entry();
    }
    private void Entry()
    {
        ChildClass child = new ChildClass();
        child.ChildMethod();
        child.BaseMethod();
    }
}