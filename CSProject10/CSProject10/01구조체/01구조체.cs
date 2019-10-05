using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 구조체
// 클래스와는 다르게 값 형식으로 이루어져 있음
// 클래스와 동일하게 복합 데이터 형식
// struct 키워드를 사용하여 구조체 선언
// 클래스와 동일하게 기본 접근 제한자는 private
// 대입연산자 '=' 복사를 진행할때는 얕은 복사가 아닌, 깊은 복사가 일어남
// 생성자를 호출하는 것이 아니라면 new 연산자 사용하지 않아도 됨
// 클래스와 다르게 필드에 대한 값 정의할 수 없음
// 매개 변수가 없는 생성자를 사용할 수 없음
// 생성자를 사용해야 한다면 생성자 내부에서 모든 필드에 대한 초기화가 일어나야함


public partial struct Point
{
    public double x;
    public double y;
   
}

public partial struct Point
{
    public Point(double x, double y)
    {
        this.x = x;
        this.y = y;
    }
    public Point(double InitialValue)
    {
        x = y = InitialValue;
    }

    public Point(Point point)
    {
        this = point;
    }
    public void SetPosition(double x, double y)
    {
        this.x = x;
        this.y = y;
    }
}

public static class PointExpansion
{
    public static double Distance(this Point point, Point Otherpoint)
    {
        double distance = Math.Sqrt
            (Math.Pow((Otherpoint.x - point.x), 2) +
            Math.Pow((Otherpoint.y - point.y), 2));
        return distance;
    }
}

class _01구조체
{
    private static void Main()
    {
        new _01구조체().Entry();
    }
    private void Entry()
    {
        Point myLocation = new Point();
        myLocation.SetPosition(1.0, 1.0);

        //생성자를 호출하지 않음, 직접 필드에 초기화
        Point newLocation;
        newLocation.x = 10.0;
        newLocation.y = 10.0;

        double distance = myLocation.Distance(newLocation);
        Console.WriteLine("[myLocation] distance = " + distance);
    }
}