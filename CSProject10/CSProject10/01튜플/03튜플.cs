using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class _03튜플
{
    private static void Main()
    {
        new _03튜플().Entry();
    }
    private void Entry()
    {
        var Human = ("철수", 30, "바보", "알파고");
        var (HumanName, HumanAge, _, HumanNickName) = Human;

        Console.WriteLine("이름: " + HumanName);
        Console.WriteLine("나이: " + HumanAge);
        Console.WriteLine("별명: " + HumanNickName);
    }

}