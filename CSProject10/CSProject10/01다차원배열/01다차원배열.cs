using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



class _01다차원배열
{
    private static void Main()
    {
        new _01다차원배열().Entry();
    }
    private void Entry()
    {
        // 2차원 배열
        // 각각의 엘리먼트가 1차원 배열을 하나씩 갖음
        // 배열 선언시 []가 아닌 [,]fh tjsdjs
        // 동적할당 시 new 자료형 [2차원 크기,1차원크기]로 메모리 할당

        int[,] myArray = new int[3, 4];
        // [ ㅁ ㅁ ㅁ ㅁ ]
        // [ ㅁ ㅁ ㅁ ㅁ ]
        // [ ㅁ ㅁ ㅁ ㅁ ]

        // 다차원 배열 길이 구하는법
        // .Length가 아닌 GetLength(dimension)을 사용
        // Length를 사용한다면 해당 배열 전체의 엘리먼트 수를 반환

        // 1차원 배열 길이
        int length1 = myArray.GetLength(1);
        // 2차원 배열 길이
        int length2 = myArray.GetLength(0);

        Console.WriteLine("1차원 배열 길이 : " + length1);
        Console.WriteLine("2차원 배열 길이 : " + length2);

        int count = 0;

        // 2차원 배열을 순회할 for문
        for (int i = 0; i < length2; i++)
        {
            for (int j = 0; i < length1; j++)
            {
                myArray[i, j] = count++;
                Console.WriteLine("myArray[] = " + myArray[i, j]);
            }
        }

        for (int i = 0; i < length2; i++)
        {
            for (int j = 0; i < length1; j++)
            {
                int elevlaue = myArray[i, j];
                Console.WriteLine("[" + (elevlaue < 10 ? " " : "") + elevlaue + "]");
            }
        }
    }
}