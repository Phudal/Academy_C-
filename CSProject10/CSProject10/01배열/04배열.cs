using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class _04배열
{
    private void InitializeArray(int[] arr, int initializeNumber)
    {
        for (int i = 0; i < arr.Length; i++)
            arr[i] = initializeNumber;
    }

    private void PrintAllElems(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine("arr[" + i + "] = " + arr[i]);
        }
    }

    private static void Main()
    {
        new _04배열().Entry();
    }
    private void Entry()
    {
        int[] myArray1 = new int[20];

        int[] myArray2 = myArray1;

        InitializeArray(myArray2, 7);
        PrintAllElems(myArray1);

        Console.Clear();

        //myArray2 = new int[myArray1.Length];
        //for (int i = 0; i < myArray1.Length; i++)
        //    myArray2[i] = myArray1[i];    

        myArray2 = (int[])myArray1.Clone();

        InitializeArray(myArray2, 7);
        InitializeArray(myArray1, 10);
        PrintAllElems(myArray2);
        
    }
}