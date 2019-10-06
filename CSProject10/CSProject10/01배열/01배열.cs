using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 배열
// 동일한 타입의 변수들을 모아 높은 데이터 집합
// 여러개의 동일한 타입의 변수가 필요한 경우 유용하게 사용

// C# : 데이터 타입 [] 변수이름 = new 데이터타입[용량]

class _01배열
{
    private static void Main()
    {
        new _01배열().Entry();
    }
    private void Entry()
    {
        int[] Arr = new int[5];
        Arr[0] = 10;
        Arr[1] = 20;
        Arr[2] = 30;
        Arr[3] = 40;
        Arr[4] = 50;

        Console.WriteLine("Arr[0] = " + Arr[0]);
        Console.WriteLine("Arr[1] = " + Arr[1]);
        Console.WriteLine("Arr[2] = " + Arr[2]);
        Console.WriteLine("Arr[3] = " + Arr[3]);
        Console.WriteLine("Arr[4] = " + Arr[4]);


        string[] arr2 = new string[2] { "초코", "화이트" };
        Console.WriteLine(arr2[0]);

        int[] arr3 = new int[3] { 1, 2, 3 };
        Console.WriteLine(arr3[0]);

        object[] arr4 = new object[4] { "초코", 1, 'c', 10 };
    }
}