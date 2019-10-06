using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class _02다차원배열
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
        new _02다차원배열().Entry();
    }
    private void Entry()
    {
        // 형식과 길이 명시
        int[,] arr = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };
        PrintArr(arr);
        // 길이 생략
        int[,] arr2 = new int[,] { { 1, 2, 3 }, { 4, 5, 6 } };
        PrintArr(arr2);
        // 형식과 길이 모두 생략
        int[,] arr3 = { { 1, 2, 3 }, { 4, 5, 6 } };
        PrintArr(arr3);
    }
}