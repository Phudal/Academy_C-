using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Human
{
    // protected -> 선언된 멤버는 자신과 파생 클래스(자식 클래스)에서 접근 가능
    protected string Name;
    protected int Age;

    public void PrintInfo()
    {
        Console.WriteLine("사람 이름 :  " + Name);
        Console.WriteLine("나이 : " + Age);        
    }
}
public class student : Human
{
    public student(string name, int age)
    {
        Name = name;
        Age = age;
    }
    public void PrintInfo()
    {
        // 부모의 멤버를 사용하고 싶다면
        // 'base' 키워드를 사용
        base.PrintInfo();
        Console.WriteLine("학생의 이름 : " + Name);
        Console.WriteLine("학생의 나이 : " + Age);
    }
}
class _02상속
{
   private static void Main()
    {
        new _02상속().Entry();
    }
    private void Entry()
    {
        student student = new student("초코", 3);
        student.PrintInfo();
    }
}

