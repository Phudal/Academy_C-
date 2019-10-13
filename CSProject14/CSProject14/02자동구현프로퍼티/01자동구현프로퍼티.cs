using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// 자동 구현 프로퍼티
// C# 3.0부터 지원, 프로퍼티를 조금 더 간결하게 사용 가능

// private 변수를 선언하지 않고, 프로퍼티만 구성해서
// get/set에 세미콜론만 붙이면 됨

public struct Point
{
    public int x, y;

    public Point(int x, int y)
    {
        this.x = x;
        this.y = y;
    }
}

public class Object
{
    // 자동구현 프로퍼티 구성
    public string objectName { get; private set; }

    // private string ObjectName;
    // public string objectName;
    // {
    //      get { return ObjectName; }
    //      set { object = value; }
    // }

    // C# 7.0 버전 이상부터 프로퍼티를 구성함과 동시에 
    // 초기화를 진행 할 수 있음
    public Point point { get; set; } = new Point(100, 100);

    public Object (string objectname)
    {
        this.objectName = objectname;
    }
    public override string ToString()
    {
        return (objectName + " : " + point.x + ", " + point.y);
    }
}

class _01자동구현프로퍼티
{
    private static void Main()
    {
        new _01자동구현프로퍼티().Entry();
    }
    private void Entry()
    {
        Object myobject = new Object("내 오브젝트");
        //myObject.point.x = 150;
        myobject.point = new Point(150, myobject.point.y);
        Console.WriteLine(myobject.ToString());
    }
}