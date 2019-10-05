using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Weapon
{
    public string weapon_name;
    public int enhanced;
    public int percent;

    public void Enhance()
    {
        Console.WriteLine("강화를 시도합니다.");
        percent = new Random().Next(1, 101);
        //if (percent <= )
    }
    Weapon(string weapon_name) {
        this.weapon_name = weapon_name;
        enhanced = 0;
    }
}

class Inventory
{
    public int enhance_stone;
    public int gold;
}

class _04난수
{
    private static void Main()
    {
        new _04난수().Entry();
    }
    private void Entry()
    {

    }
}