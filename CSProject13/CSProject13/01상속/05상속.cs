using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Flower
{
    protected string Name;
    protected int Cost;

    public void Printinfo()
    {
        Console.WriteLine("꽃의 이름: " + Name);
        Console.WriteLine("꽃의 가격: " + Cost);
    }
}

class Rose : Flower
{
    public Rose()
    {
        Name = "장미";
        Cost = 1000;
    }
}

class Tulip : Flower
{
    public Tulip()
    {
        Name = "튤립";
        Cost = 1500;
    }
}

class _05상속
{
    private static void Main()
    {
        new _05상속().Entry();
    }
    private void Entry()
    {
        Rose rose = new Rose();
        Tulip tulip = new Tulip();
        rose.Printinfo();
        Console.WriteLine();
        tulip.Printinfo();
    }
}