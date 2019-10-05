using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Weapon
{
    private string weapon_name;     // 장비 이름 
    private int enhanced;           // 강화 수치
    private int percent;            // 확률

    public void Set_weapon_name(string weapon_name) { this.weapon_name = weapon_name; }
    public string Get_weapon_name() { return this.weapon_name; }
    public void Set_enhanced(int enhanced) { this.enhanced = enhanced; }
    public int Get_enhanced() { return this.enhanced; }
    public void Set_percent(int percent) { this.percent = percent; }
    public int Get_percent() { return this.percent; }

    public bool question()
    {
       
        Console.WriteLine("소비될 강화석: " + Spend_Enhance_stone());
        Console.WriteLine("소비될 골드: " + Spend_Enhance_gold());
        if (Inventory.Get_enhance_stone() == 0)
        {
            Console.WriteLine("강화석이" + (Spend_Enhance_stone()
                - Inventory.Get_enhance_stone()) + "개 부족합니다.");
            return false;
        }
        if (Inventory.Get_gold() == 0)
        {
            Console.WriteLine("골드가" + (Spend_Enhance_gold() 
                - Inventory.Get_gold()) + "만큼 부족합니다. ");
            return false;
        }
            
        if (Get_enhanced() <= 4)
        {          
            Console.WriteLine("강화를 시도하시겠습니까? " + " 현재 강화 수치: " + Get_enhanced());
            Console.WriteLine("true or false");
           
            bool input = bool.Parse(Console.ReadLine());
            return input;
        }
        else
        {
            Console.WriteLine("강화 최대치에 도달했습니다.");
            Console.WriteLine("더이상 강화를 할 수 없습니다.");
            return false;
        }
    }

    public void Enhance()
    {
        while (true)
        {
            if (question())
            {
                Console.Clear();
                Console.Write("         뿌?");
                System.Threading.Thread.Sleep(250);
                Console.Write("슝!");
                System.Threading.Thread.Sleep(250);
                Console.Write("빠?");
                System.Threading.Thread.Sleep(250);
                Console.WriteLine("슝!");

                Set_percent(new Random().Next(1, 101));
                if (Enhance_percent() >= Get_percent())
                {
                    Inventory.Set_enhance_stone(Inventory.Get_enhance_stone() - Spend_Enhance_stone());
                    Inventory.Set_gold(Inventory.Get_gold() - Spend_Enhance_gold());
                    Set_enhanced(Get_enhanced() + 1);
                    Console.WriteLine("강화에 성공했습니다. 현재 강화 수치 :" + Get_enhanced());
                }
                else
                {
                    Inventory.Set_enhance_stone(Inventory.Get_enhance_stone() - Spend_Enhance_stone());
                    Inventory.Set_gold(Inventory.Get_gold() - Spend_Enhance_gold());
                    if (Get_enhanced() != 0)  
                        Set_enhanced(Get_enhanced() - 1);
                    Console.WriteLine("강화에 실패했습니다. 현재 강화 수치 : " + Get_enhanced());
                }
                PrintInfo();
                Inventory.Print_Inventory();
            }
            else
            {
                Console.WriteLine("강화 시뮬레이터를 종료합니다.");
                return;
            }
        }
    }

    public int Enhance_percent()
    {
        int E_percent;
        if (Get_enhanced() == 0)
            E_percent = 90;
        else if (Get_enhanced() == 1)
            E_percent = 70;
        else if (Get_enhanced() == 2)
            E_percent = 50;
        else if (Get_enhanced() == 3)
            E_percent = 30;
        else 
            E_percent = 10;
        return E_percent;
    }

    public int Spend_Enhance_gold()
    {
        int E_gold;
        if (Get_enhanced() == 0)
            E_gold = 100;
        else if (Get_enhanced() == 1)
            E_gold = 200;
        else if (Get_enhanced() == 2)
            E_gold = 300;
        else if (Get_enhanced() == 3)
            E_gold = 400;
        else
            E_gold = 0;
        return E_gold;
    }

    public int Spend_Enhance_stone()
    {
        int E_stone;
        if (Get_enhanced() == 0)
            E_stone = 1;
        else if (Get_enhanced() == 1)
            E_stone = 2;
        else if (Get_enhanced() == 2)
            E_stone = 3;
        else if (Get_enhanced() == 3)
            E_stone = 4;
        else
            E_stone = 0;
        return E_stone;
    }

    public Weapon(string weapon_name) {
        Console.WriteLine("강화 시뮬레이터를 시작합니다. \n");
        this.weapon_name = weapon_name;
        enhanced = 0;
        Enhance();
    }
    public void PrintInfo()
    {
        Console.WriteLine("\n장비 이름: " + Get_weapon_name() +"\n");
        Console.WriteLine("장비 강화 수치: " + Get_enhanced());
        Console.WriteLine("현재 남은 강화석: " + Inventory.Get_enhance_stone());       
    }
}

static class Inventory
{ 
    private static int Gold = 3000;
    private static int Enhance_stone = 30;      // 강화석

    public static void Set_enhance_stone(int enhance_stone) { Enhance_stone = enhance_stone; }
    public static int Get_enhance_stone() { return Enhance_stone; }
    public static int Get_gold() { return Gold; }
    public static void Set_gold(int gold) { Gold = gold; }
    public static void Print_Inventory() 
    { 
        Console.WriteLine("현재 남은 강화석: " + Get_enhance_stone()); 
        Console.WriteLine("현재 남은 골드: " + Get_gold() + "\n"); 
    }
}

class _04난수
{
    private static void Main()
    {
        new _04난수().Entry();
    }
    private void Entry()
    {
        Console.WriteLine("장비 이름을 입력하세요...");
        string input = Console.ReadLine();
        Weapon weapon = new Weapon(input);
    }
}