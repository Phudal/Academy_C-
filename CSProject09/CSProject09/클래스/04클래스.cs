using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Airconditioner
{
    private bool ON_OFF;
    private int Temperature;
    
    public void Print_Temperature()
    {
        Console.WriteLine("현재 전원이" + (Get_ONOFF() ? " 켜져있습니다." : " 꺼져있습니다."));
        Console.WriteLine("현재 온도: " + this.Temperature + "\n");
    }

    public void Set_Temperature(int value)
    {
        this.Temperature = value;
    }

    public void Set_ONOFF(bool value)
    {
        this.ON_OFF = value;
    }
    //----------------------Set함수
    public int Get_Temperature()
    {
        return this.Temperature;
    }

    public bool Get_ONOFF()
    {
        return this.ON_OFF;
    }
    //----------------------Get함수

    public void Up_Temperature()
    {
        Set_Temperature(Get_Temperature() + 1);
        Console.WriteLine("온도를 1도 올립니다. \n");
    }
    public void Down_Temperature()
    {
        Set_Temperature(Get_Temperature() - 1);
        Console.WriteLine("온도를 1도 내립니다. \n");
    }

    public Airconditioner()
    {
        Set_Temperature(22);
        Set_ONOFF(true);
        Console.WriteLine("전원이 켜졌습니다.");
        Console.WriteLine("현재 온도는 " + Get_Temperature() + " 입니다. \n");
    }
    ~Airconditioner()
    {
        Set_ONOFF(false);
        Console.WriteLine("전원이 꺼집니다.");
        Console.WriteLine("현재 온도는 " + Get_Temperature() + " 입니다.");
    }
}

class _04클래스
{
    static void Main() {
        Airconditioner Air = new Airconditioner();

        Air.Set_ONOFF(true);
        Air.Set_Temperature(19);
        Air.Print_Temperature();
        Air.Up_Temperature();
        Air.Print_Temperature();
        Air.Down_Temperature();
        Air.Print_Temperature();
        Air.Set_ONOFF(false);
    }
}
