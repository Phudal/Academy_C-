using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProject07
{
    class _05메서드
    {
        static void Score(int kor_s, int math_s, int eng_s)
        {
            Console.WriteLine("총점: " + (kor_s + math_s + eng_s));
            Console.WriteLine("평균: " + (kor_s + math_s + eng_s) / 3);

            int max = 0;
            if (kor_s >= math_s && kor_s >= eng_s)
                max = kor_s;
            if (math_s >= kor_s && math_s >= eng_s)
                max = math_s;
            else
                max = eng_s;

            Console.WriteLine("최고점: " + max);
        }
        static void Main()
        {
            Console.Write("국어점수:");
            int kor = int.Parse(Console.ReadLine());

            Console.Write("수학점수:");
            int mat = int.Parse(Console.ReadLine());

            Console.Write("영어점수:");
            int eng = int.Parse(Console.ReadLine());

            Score(kor, mat, eng);
        }
    }
}
