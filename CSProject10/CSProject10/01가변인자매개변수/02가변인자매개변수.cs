using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class _02가변인자매개변수
{
    private int[] MakeIntArr(params int[] value)
    { return (int[])value.Clone(); }

    private static void Main()
    {
        new _02가변인자매개변수().Entry();
    }
    private void Entry()
    {
        int[] myArray = MakeIntArr(10, 20, 30, 40, 50);
        foreach (int i in myArray)
            Console.Write(i + " ");
        Console.WriteLine();
    }

}