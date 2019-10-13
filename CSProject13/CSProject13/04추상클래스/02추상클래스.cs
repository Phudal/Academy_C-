using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// 추상클래스를 상속받는 추상클래스
// 자식 추상 클래스에서 추상 메서드를 구현
// 자식 추상 클래스에서 추상 메서드를 구현하지 않아도 됨

// 만약 구현하지 않는 추상 메서드가 있다면 추상클래스가 아닌, 파생 클래스에서
// 모든 추상 메서드를 구현해야함

public abstract class Machine
{
    public enum Power { On, Off }

    public abstract void PowerOnOff(Power power);
    public abstract void Repair();
}

public abstract class Computer : Machine
{
    public abstract void Coding();
    public override void Repair()
    {
        Console.WriteLine("컴퓨터를 수리하였습니다.");
    }
}

public class MyComputer : Computer
{
    public override void Coding()
    {
        Console.WriteLine("코딩을 합니다.");
    }
    public override void PowerOnOff(Power power)
    {
        switch (power)
        {
            case Power.On:
                Console.WriteLine("전원을 켭니다.");
                break;
            case Power.Off:
                Console.WriteLine("전원을 끕니다.");
                break;
        }
    }
}

class _02추상클래스
{
    private static void Main()
    {
        new _02추상클래스().Entry();
    }
    private void Entry()
    {
        MyComputer pc = new MyComputer();
        pc.PowerOnOff(Machine.Power.On);
        pc.Coding();
        pc.Repair();
        pc.PowerOnOff(Machine.Power.Off);
    }
}