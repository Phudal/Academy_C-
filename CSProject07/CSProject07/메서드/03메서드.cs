using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProject07
{
    class _03메서드
    {
        static void PrintAge(int BirthYear)
        {
            int CurYear = DateTime.Now.Year;
            //DateTime = 날짜와 시간 데이터를 제공하는 C# 구조체
            //Datetiem.Now = 현재 현지 날짜와 시간을 가져옴

            int MyAge = 1 + CurYear - BirthYear;
            Console.WriteLine("내 나이는 " + MyAge + "입니다.");
        }
        static void Main()
        {
            Console.WriteLine("태어난 연도를 적어주세요: ");
            int year = int.Parse(Console.ReadLine());

            PrintAge(year);
        }
    }
}
