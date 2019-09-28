using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Student
{
    public string Name;
    public string Id;
    public int PassWord;

    public void PrintInfo()
    {
        Console.WriteLine("학생의 이름: " + this.Name);
        Console.WriteLine("Id: " + this.Id + " / PW: " + PassWord);
        Console.WriteLine();
    }
}

class _03클래스
{
    static void Main()
    {
        Student st1 = new Student();
        Student st2 = new Student();

        st1.Name = "철수";
        st1.Id = "ASCS04";
        st1.PassWord = 1004;

        st2.Name = "영희";
        st2.Id = "CSYH04";
        st2.PassWord = 2004;

        st1.PrintInfo();
    }
}
