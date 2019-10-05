using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



class _01난수
{
    private static void Main()
    {
        new _01난수().Entry();
    }
    private void Entry()
    {
        Random rand = new Random();

        for (int i = 0; i < 10; i++)
        {
            // Random.Next(min, max) : min 부터 max-1 까지의 난수를 반환
            Console.WriteLine("생성된 난수 :" + rand.Next(0, 6));
        }
    }

}