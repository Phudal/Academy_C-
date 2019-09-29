using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// 생성자의 this()
// overload되어있는 자기 자신의 다른 생성자를 가르킴
// 같은 코드를 중복 작성하지 않도록 할 때 사용

class MyClass
{
    public int A;
    public int B;
    public int C;

    public MyClass(int A)
    {
        this.A = A;
        Console.WriteLine("A = " + this.A);
    }
    public MyClass(int A, int B) : this(A)
    {
        this.B = B;
        Console.WriteLine("B = " + B);
    }
    public MyClass(int A, int B, int C) : this(A, B)
    {
        this.C = C;
        Console.WriteLine("C = " + C);
    }
    ~MyClass()
    {
        Console.WriteLine("소멸자 실행");
    }
}

class this생성자
{
    static void Main()
    {
        new this생성자().Entry();
    }
    void Entry()
    {
        new MyClass(1);
        new MyClass(2);
        new MyClass(3);
    }
}

