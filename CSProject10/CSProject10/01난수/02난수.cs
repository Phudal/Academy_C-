using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 난수를 이용해서 확률 구현
// 1~100까지 범위에 속하는 임의의 수를 뽑음
// 1~100까지의 범위에 속하는 확률 값을 지정
// 뽑은 임의의 수가 확률값 이하인지 검사
// 이하라면 성공

class _02난수
{
    private static void Main()
    {
        new _02난수().Entry();
    }
    private void Entry()
    {
        int Percent;

        while (true)
        {
            Console.WriteLine("1부터 100 사이의 값으로 확률을 설정하십시오. ");
            Percent = int.Parse(Console.ReadLine());

            // 올바르게 입력했을 경우
            if (Percent > 0 && Percent <= 100) break;
            else
            {
                Console.Clear();
                Console.WriteLine("잘못된 값을 입력하셨습니다.");
                Console.WriteLine("1부터 100 사이의 값을 입력해주세요.");
                System.Threading.Thread.Sleep(1000);
                Console.Clear();
            }
        }

        Console.WriteLine("확률: " + Percent + "%로 설정되었습니다.");
        System.Threading.Thread.Sleep(500);

        for (int i = 0; i < 3; i++)
        {
            Console.Write(". ");
            System.Threading.Thread.Sleep(100);
        }
        Console.WriteLine();

        // 1부터 100까지의 난수를 하나 뽑습니다.
        int Pick = new Random().Next(1, 101);

        Console.Clear();

        //확률값 이하라면
        if (Pick <= Percent) Console.WriteLine("성공");
        else Console.WriteLine("실패");
    }

}