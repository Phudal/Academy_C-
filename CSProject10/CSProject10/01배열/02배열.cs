using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class _02배열
{
    private static void Main()
    {
        new _02배열().Entry();
    }
    private void Entry()
    {
        int[] myArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(myArray[i]);
        }

        float[] height = { 160.5f, 180.2f, 179.9f };

        foreach (float h in height)
            Console.WriteLine(h);
    }
}