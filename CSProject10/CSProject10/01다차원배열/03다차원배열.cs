using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class _03다차원배열
{
    private void PrintArr(int[,] arr)
    {
        foreach (int i in arr)
            Console.Write(i + " ");
        Console.WriteLine();
        Console.WriteLine();
    }
    private static void Main()
    {
        new _03다차원배열().Entry();
    }
    private void Entry()
    {
        int[,] arr1 = new int[4, 5];
        int count = 0;
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 5; j++)
                arr1[i,j] = (count++) + 1;
        }
        PrintArr(arr1);
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 5; j++)
                arr1[i, j] = (--count) + 1;
        }
        PrintArr(arr1);
    }
}