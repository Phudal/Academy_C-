using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class SampleClass
{
    public int A = 0;
    public int B = 0;

    public SampleClass DeepCopy()
    {
        SampleClass copy = new SampleClass();

        copy.A = this.A;
        copy.B = this.B;

        return copy;
    }

}

class _02객체복사
{
    static void Main()
    {
        new _02객체복사().Entry();
    }
    void Entry()
    {
        SampleClass sample1 = new SampleClass();

        sample1.A = 10;
        sample1.B = 100;

        SampleClass sample2 = sample1.DeepCopy();

        sample2.A = 20;
        sample2.B = 200;

        Console.WriteLine();
        Console.WriteLine("sample1");
        Console.WriteLine("sample1.A = " + sample1.A);
        Console.WriteLine("sample1.B = " + sample1.B);

        Console.WriteLine();
        Console.WriteLine("sample2");
        Console.WriteLine("sample2.A = " + sample2.A);
        Console.WriteLine("sample2.B = " + sample2.B);
    }
}

