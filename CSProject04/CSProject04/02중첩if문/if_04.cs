using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProject04._02중첩if문
{
    class if_04
    {
        static void Main()
        {
            int candy = int.Parse(Console.ReadLine());
            Console.WriteLine("철수가 가지고 있는 사탕의 개수는 " + candy + "개 입니다.");

            if (candy >= 30)
                Console.WriteLine("철수는 사탕을 반 친구들과 나눠먹습니다.");
            else if (candy >= 20)
                Console.WriteLine("철수는 사탕을 친한 친구들과 나눠먹습니다.");
            else if (candy >= 10)
                Console.WriteLine("철수는 사탕을 가족과 나눠먹습니다.");
            else
                Console.WriteLine("철수는 사탕을 혼자서 먹습니다.");
        }
    }
}
