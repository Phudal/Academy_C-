using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Access Modifier 접근 한정자(접근 제한자)
// 접근 제한자는 외부로부터 멤버에 대한 접근을 제한할 때 사용하는 한정자


// 객체 지향 프로그래밍의 3대특성
// 은닉성(캡슐화)
//
// 값의 보호를 위해서 객체의 필드, 메서드를 필요해 의해 감추거나 공개
// 객체 지향 프로그래밍에서는 클래스 사용자에게 필요한 최소의 기능만 노출시키고
// 내부를 감추도록 요구 -> 접근 제한자 사용
//
// 상속성
//
// 부모가 가지고 있는 것들을 자식 클래스가 물려받아 같이 공유하며 나아가 확장하는 개념
// 기존의 코드를 재사용해서 보다 쉽게 코드를 작성하는 기법
// 비슷한 개념을 발견해서 공통화 시킨 후 개발 생산성을 향상 시킬 수 있음
//
// 다형성
// 
// 같은 타입이지만 실행 결과가 다양한 객체를 이용 할 수 있는 성질을 의미 
// 하나의 이름을 가지고 많은 상황에 대처


// 접근 한정자 종류
// public               : 내/외부 모든 곳에서 접근 가능
// protected            : 클래스 외부 접근 불가, 파생 클래스에서 접근 가능
//
// private              : 클래스 내부에서만 접근 가능 
//                        접근 제한자 기본값
//
// internal             : 같은 어셈블리 단위에서만 public으로 접근 가능
//                        다른 어셈블리 단위에서 접근할 경우 private 적용
//
//                        namespace에서 접근제한자 기본값
//
// protected internal   : 같은 어셈블리 코드에서는 protect로 접근 가능
//                        다른 어셈블리 코드에서는 private 적용
// private internal     : 같은 어셈블리 코드에서만 접근 가능

public class Student
{
    // 필드는 상수를 제외하고 무조건 감춰야함
    // 프로그래머의 실수를 줄이기 위해서

    private string Name;

    private int Age;

    public Student(string Name, int Age) {
        this.Name = Name;
        this.Age = Age;
    }

    public void PrintStudnet()
    {
        Console.WriteLine("학생의 이름 : " + Name);
        Console.WriteLine("학생의 나이 : " + Age);
    }
}



class _01접근한정자
{
    private Student student1 = null;
    private Student student2 = null;

    private static void Main()
    {
        new _01접근한정자().Entry();
    }
    private void Entry()
    {
        string tempName;
        int tempAge;

        student1 = new Student("홍길동", 20);

        for (int i = 0; i < 2; i++)
        {
            Console.WriteLine((i + 1)+"번째 학생의 이름");
            tempName = Console.ReadLine();

            Console.WriteLine(tempName + "의 나이는 몇살 인가요? ");
            tempAge = int.Parse(Console.ReadLine());

            switch (i)
            {
                case 0: student1 = new Student(tempName, tempAge); break;
                case 1: student2 = new Student(tempName, tempAge); break;
            }
        }

        student1.PrintStudnet();
        student2.PrintStudnet();
    }
}
