using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class BaseClass
{
    // virtual : 파생클래스에서 오버라이딩이 가능하도록
    public virtual void PrintName()
    {
        Console.WriteLine("부모클래스 ");
    }
}

public class ChildClass : BaseClass
{
    // 오버라이딩 사용할때 override 키워드 사용
    // 더이상 상속받지 못하게 만들 경우 sealed 키워드 사용하면 
    // 오버라이딩 봉인 가능
    public override sealed void PrintName()
    {
        Console.WriteLine("자식 클래스 ");
    }
}
class _01오버라이딩
{
    private static void Main()
    {
        new _01오버라이딩().Entry();
    }
    private void Entry()
    {
        BaseClass myclass = new ChildClass();
        myclass.PrintName();
    }
}