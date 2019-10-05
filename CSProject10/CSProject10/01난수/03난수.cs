using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class _03난수
{
    private static void Main()
    {
        new _03난수().Entry();
    }
    private void Entry()
    {
        int Random_number = new Random().Next(1, 101);
        int count = 0;
        int input_number;
        while (true)
        {
            count++;


            if (count > 5)
            {
                Console.WriteLine("실패 (정답: " + Random_number + ")");
                break;
            }


            Console.WriteLine("현재 시도횟수:" + count + "\n숫자?");
            input_number = int.Parse(Console.ReadLine());

            if (Random_number > input_number)
            {
                Console.WriteLine("UP!");
                continue;
            }
            else if (Random_number < input_number)
            {
                Console.WriteLine("DOWN!");
                continue;
            }
            else if (Random_number == input_number) 
            {
                Console.WriteLine("정답! (" + Random_number + ")");
                Console.WriteLine("시도한 횟수 : " + count);
                break;
            } 
        }
    }
}