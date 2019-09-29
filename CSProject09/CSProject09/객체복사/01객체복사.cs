using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class SampleClass
{
    public int A = 0;
}

class _01객체복사
{
    static void Main()
    {
        new _01객체복사().Entry();
    }
    void Entry()
    {
        SampleClass sample01 = new SampleClass();
        // Deep Copy: 값까지 복사
        SampleClass sample02 = sample01;
        // Shallow Copy : 참조 복사

        sample01.A = 10;
        sample02.A = 100;

        Console.WriteLine(sample01.A);
    }
}
