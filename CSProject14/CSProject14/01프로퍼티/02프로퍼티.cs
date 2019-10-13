using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class SampleClass
{
    private int Variable1;
    public int variable1
    {
        get { return Variable1; }
        private set { Variable1 = value; }
    }
    private int Variable2;
    // 읽기 전용 프로퍼티
    public int variable2
    {
        get { return Variable2; }
    }
    private int Variable3;
    public int variable3
    {
        set { Variable3 = value; }
    }
    // 쓰기 전용 프로퍼티

    public SampleClass(int v1, int v2, int v3)
    {
        variable1 = v1;
        Variable2 = v2;
        // 프로퍼티 미사용
        variable3 = v3;
    }
}

class _02프로퍼티
{
    private static void Main()
    {
        new _02프로퍼티().Entry();
    }
    private void Entry()
    {
        SampleClass sample = new SampleClass(1, 2, 3);
        Console.WriteLine(sample.variable1);
        Console.WriteLine(sample.variable2);
        //Console.WriteLine(sample.variable3);
    }
}