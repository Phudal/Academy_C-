using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProject04._02중첩if문
{
    class if_05
    {
        static void Main()
        {
            Console.Write("시험점수: ");
            int score = int.Parse(Console.ReadLine());
            string result;
            if (score >= 95)
                result = "A+";
            else if (score >= 90)
                result = "A";
            else if (score >= 85)
                result = "B+";
            else if (score >= 80)
                result = "B";
            else if (score >= 75)
                result = "C+";
            else if (score >= 70)
                result = "C";
            else if (score >= 65)
                result = "D+";
            else if (score >= 60)
                result = "D";
            else
                result = "F";
            Console.WriteLine("등급: " + result);

        }
    }
}
