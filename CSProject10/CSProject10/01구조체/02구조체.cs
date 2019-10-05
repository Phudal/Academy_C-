using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Cat
{
    public struct CatInfo
    {
        public string name;
        public uint age;
    }
    private CatInfo catInfo;

    public Cat(string name, uint age)
    {
        catInfo.name = name;
        catInfo.age = age;
    }
    public void PrintCatInfo()
    {
        Console.WriteLine("고양이의 이름: " + catInfo.name);
        Console.WriteLine("고양이의 나이: " + catInfo.age);
    }
}

class _02구조체
{
    private static void Main() { new _02구조체().Entry(); }
    
    private void Entry()
    {
        Cat cat = new Cat("화이트", 3);
        cat.PrintCatInfo();
    }
}