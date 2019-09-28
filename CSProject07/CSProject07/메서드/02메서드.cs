using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProject07
{
    class _02메서드
    {
        static void Main()
        {
            int Mynumber = GetNumber();
            Console.WriteLine(GetNumber());

            InputName();
        }
            
        static int GetNumber()
        {
            int Number = 13;
            Console.WriteLine("세상에서 가장 완벽한 수는 " + Number + "입니다.");
            return Number;
        }
        static void InputName()
        {
            Console.WriteLine("\"이름\"을 입력해주세요: ");      // \" : 출력할때 "로 출력
            string name = Console.ReadLine();

            if (name == "이름")
            {
                Console.WriteLine("이름이 같습니다.");
            }
            else
            {
                Console.WriteLine("이름이 일치하지 않습니다. ");
                Console.WriteLine("입력을 종료합니다. ");

                return;
            }
            Console.WriteLine(name + "의 나이는 몇살입니가?");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine(name + "의 나이는" + age + "입니다.");

        }
    }
}
