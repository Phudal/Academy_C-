using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Character
{
    private string Name;
    private int Level;
    private string Work;

    public string GetterName()
    {
        return this.Name;
    }
    public void SetterName(string Name)
    {
        if (Name == "핑크겅듀")
        {
            Console.WriteLine("히잌 고인물 꺼져어엇");
            this.Level = 99;
        }
        this.Name = Name;
    }
    public int GetterLevel()
    {
        return this.Level;
    }
    public void SetterLevel(int Level)
    {
        if (Level <= 0)
        {
            Console.WriteLine("레벨은 1이상입니다");
            Console.WriteLine("레벨을 1로 설정합니다");
            this.Level = 1;
            return;
        }
        if (this.Name == "핑크겅듀")
        {
            Console.WriteLine("더러운 고인물 보나마나 만렙이겠지");
            return;
        }
        this.Level = Level;
    }
    public string GetterWork()
    {
        return this.Work;
    }
    public void SetterWork(string Work)
    {
        if (Name == "핑크겅듀")
        {
            Console.WriteLine("더러운 고인물 보나마나 백수샛기겠지");
            this.Work = "백수";
            return;
        }
        this.Work = Work;
    }


    public void PrintInfo()
    {
        Console.WriteLine("\n캐릭터 닉네임: " + GetterName());
        Console.WriteLine(GetterName() + "의 레벨: " + GetterLevel());
        Console.WriteLine(GetterName() + "의 직업: " + GetterWork());
    }

    public Character()
    {
        Console.WriteLine("캐릭터 생성중... \n");
        

        Console.Write("캐릭터의 이름은? ");
        string tempName = Console.ReadLine();
        SetterName(tempName);

        if (Name != "핑크겅듀")
        int tempLevel;
        {
            Console.Write("캐릭터의 레벨은? ");
            tempLevel = int.Parse(Console.ReadLine());
        }       
        SetterLevel(tempLevel);

        if (Name != "핑크겅듀")
            Console.Write("캐릭터의 직업은? ");
        string tempWork = Console.ReadLine();
        SetterWork(tempWork);
    }
}


class _03접근한정자
{
    private static void Main()
    {
        new _03접근한정자().Entry();
    }
    private void Entry()
    {
        Character character = new Character();
        character.PrintInfo();
    }
}