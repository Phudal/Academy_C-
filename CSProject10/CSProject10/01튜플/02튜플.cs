using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class _02튜플
{
    private static void Main()
    {
        new _02튜플().Entry();
    }

    private void Entry()
    {
        var tuple = (CatName: "화이트", Age: 3);

        var (cat1Name, cat1Age) = tuple;
        // tuple의 형식에 따라서 cat1Name, cat1Age의 자료형이 정해지고
        // 차례대로 같이 들어감

        Console.WriteLine("name1 = " + cat1Name);
        Console.WriteLine("age1 = " + cat1Age);
    }
}