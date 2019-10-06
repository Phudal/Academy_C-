using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class _05배열
{
    private static void Main()
    {
        new _05배열().Entry();
    }
    private void Entry()
    {
        int[] arr = new int[100];
        for(int i = 0; i < arr.Length; i++)
        {
            arr[i] = i + 1;
            Console.WriteLine("arr[" + i + "] = " + arr[i]);
        }
    }

}