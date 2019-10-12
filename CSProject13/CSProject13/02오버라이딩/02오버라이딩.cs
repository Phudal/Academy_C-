using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Shape
{
    public virtual void Draw()
    {
        Console.WriteLine();
        Console.WriteLine("도형을 그립니다");
    }
}

public class Ellipse : Shape
{
    public override void Draw()
    {
        base.Draw();
        Console.WriteLine("원을 그립니다. ");
    }
}

public class Rectangle : Shape
{
    public override void Draw()
    {
        base.Draw();
        Console.WriteLine("사각형을 그립니다. ");
    }
}

public class Triangle : Shape
{
    public override void Draw()
    {
        base.Draw();
        Console.WriteLine("삼각형을 그립니다. ");
    }
}

class _02오버라이딩
{
    private static void Main()
    {
        new _02오버라이딩().Entry();
    }
    private void Entry()
    {
        Shape[] shapes = { new Triangle(), new Rectangle(), new Ellipse() };
        foreach (Shape sp in shapes)
        {
            sp.Draw();
        }
    }
}