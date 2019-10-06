using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 배열 범위를 초과해서 사용할 경우
// - IndexOutOfRangeException 예외 발생

// 예외
// 프로그래머의 실수가 아닌, 외부 시스템이나 조건들에 의해
// 더이상 작업을 수행하지 못하는 것을 의미

// 예외 처리
// 이러한 예외가 프로그램의 오류나 다운으로 이어지지 않도록 적절하게 처리

class _03배열
{
    private static void Main()
    {
        new _03배열().Entry();
    }
    private void Entry()
    {
        int[] myArray = new int[3];

        int myArrayLength = myArray.Length;
        for (int i = 0; i < 10; i++) myArray[i] = (i * 10) + 10;

        for (int i = 0; true; i++)
        {
            if (i == myArrayLength) break;  // 예외 처리

            Console.WriteLine(myArray[i]);
        }
        for (int i = 0; true; i++)
        {
            try
            {
                Console.WriteLine(myArray[i]);
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine();
                Console.WriteLine("IndexOutOfRangeException 예외가 발생하였습니다. ");
                Console.WriteLine("내용 : " + e.Message);
                Console.WriteLine();
                break;
            }
        }
    }
    
}