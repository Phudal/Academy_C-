using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// private 필드 접근 방법
// 접근자와 설정자를 구성해서 간접 접근 가능

// 접근자
// 지정한 필드의 값을 반환하는 메서드
// Get을 이름 앞에 붙여서 사용
// 반환형식은 지정한 필드의 데이터 타입과 일치

// 설정자
// 지정한 필드의 값을 설정하는 메서드입니다
// Set을 이름 앞에 붙여 사용
// 반환 형식은 void, 값을 설정하려는 필드의 데이터형과 일치하는 매개변수 선언

public class Dog
{
    private string Name;
    private int Age;

    public string GetterName()
    {
        return this.Name;
    }
    public void SetterName(string Name)
    {
        this.Name = Name;
    }
    public int GetterAge()
    {
        return this.Age;
    }
    public void SetterAge(int Age)
    {
        if (Age <= 0)
        {
            Console.WriteLine("나이값을 잘못 설정했습니다.");
            Console.WriteLine("나이를 1로 설정합니다.");
            this.Age = 1;
            return;
        }
        else
            this.Age = Age;
    }
}

class _02접근한정자
{
    private static void Main()
    {
        new _02접근한정자().Entry();
    }
    private void Entry()
    {
        Dog dog = new Dog();
        dog.SetterName("초코");
        dog.SetterAge(3);

        Console.WriteLine("강아지 " + dog.GetterName() + "의 나이 : " + dog.GetterAge() + "살");
    }
}