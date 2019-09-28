using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProject04._01조건문
{
    class if_03
    {
        static void Main()
        {
            Console.WriteLine("일한 시간:");
            int work_time = int.Parse(Console.ReadLine());

            double gain = (work_time > 8) ? 1.5 * (8530 * (work_time - 8)) + (8530 * 8) :
                gain = 8530 * work_time; 



            //if (work_time > 8)
            //    gain = 1.5 * (8530 * (work_time - 8)) + (8530 * 8);
            //else
            //    gain = 8530 * work_time;

            Console.WriteLine("급여: " + gain);
        }
    }
}

