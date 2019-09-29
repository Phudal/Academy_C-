using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Cat
{
    public string Name;
    public int Age;
    public string Cat_Sound;

    public void Sleeping_Cat_Sound()
    {
        Console.WriteLine("고양이 " + this.Name + "가 잠을 잡니다.");
        Console.WriteLine("Zzz..");
    }
    public void PrintInfo()
    {
        Console.WriteLine("고양이의 정보 출력");
        Console.WriteLine("고양이의 이름: " + this.Name);
        Console.WriteLine(this.Name + "의 나이: " + this.Age);
        Console.WriteLine(this.Name + "의 울음소리는 " + this.Cat_Sound);
        Console.WriteLine();
    }
}

class _02클래스
{
    static void Main()
    {
        Cat Kitten = new Cat();

        Cat Choco = new Cat();

        Kitten.Name = "Kitten";
        Kitten.Age = 4;
        Kitten.Cat_Sound = "냐옹";

        Choco.Name = "Choco";
        Choco.Age = 3;
        Choco.Cat_Sound = "초코";

        Kitten.PrintInfo();
        Choco.PrintInfo();
    }
}


