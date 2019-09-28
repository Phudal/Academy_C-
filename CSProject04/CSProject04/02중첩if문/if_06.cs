using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProject04._02중첩if문
{
    class if_06
    {
        static void Main()
        {
            Console.Write("소득: ");
            int gain = int.Parse(Console.ReadLine());
            double tax;
            if (gain <= 1000)
                tax = gain * 0.09;
            else if (gain <= 4000)
                tax = gain * 0.18;
            else if (gain <= 8000)
                tax = gain * 0.27;
            else 
                tax = gain * 0.36;
            Console.WriteLine("소득세: " + (int)tax);
        }
    }
}