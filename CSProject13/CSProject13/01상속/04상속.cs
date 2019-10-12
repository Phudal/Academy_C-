using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Job
{
    private string Name;
    private string Weapon;


    protected Job(string name, string weapon)
    {
        // 상속만을 써서 호출 가능
        Name = name;
        Weapon = weapon;
    }
    public void PrintInfo()
    {
        Console.WriteLine("이름 : " + Name);
        Console.WriteLine(Name + "이 사용하는 무기 : " + Weapon);

    }
}

// sealed : 상속을 봉인
public sealed class Warrior : Job
{
    private int Defensive;
    public Warrior(string name, string weapon, int def) : base(name, weapon)
    {
        Defensive = def;
    }
    public void PrintInfo()
    {
        base.PrintInfo();
        Console.WriteLine("방어력: " + Defensive);
    }   
}

public sealed class Magicion : Job
{
    private int Inteligency;
    public Magicion(string name, string weapon, int inteligency) : base(name, weapon)
    {
        Inteligency = inteligency;
    }
    public void PrintInfo()
    {
        base.PrintInfo();
        Console.WriteLine("지력 : " + Inteligency);
    }
}

class _04상속
{
    private static void Main()
    {
        new _04상속().Entry();
    }
    private void Entry()
    {
        Job warrior = new Warrior("전사", "대검", 10);
        Job magicion = new Magicion("마법사", "오브", 100);

        ((Warrior)warrior).PrintInfo();
        Console.WriteLine();

        ((Magicion)magicion).PrintInfo();

        // C# 에서 사용할 수 있는 is, as 연산자
        // is : 객체가 해당 형식에 해당하는 검사하고 그 결과를 bool 형으로 변환
        // as : 형식 변환 연산자와 같은 역할을 하지만 변환에 실패할 경우
        //      null 리턴

        Console.WriteLine("warrior가 magicion인가요?");
        Console.WriteLine(warrior is Magicion ? "네" : "아니요");

        // magicion이 참조중인 객ㅊ가 warrior인지 검사하고
        // 맞다면 magicion이 참조하는 객체를 아니라면 null을 ㄹ넡
        Warrior myJob = (magicion as Warrior);
        Console.WriteLine("my job as = " + ((myJob == null) ? "not warrior" : "not magicion"));
    }
}