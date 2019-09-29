using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProject09
{
    
    class MyClass
    {
        // 복합 데이터 형식
        // 기본 데이터 형식을 조합해서 만든 새로운 타입

        // 객체 : 어떤 특정한 형태로 만들어진 결과 (인스턴스)
        // 인스턴스화 == 객체화

        // 클래스는 속성(필드)과 기능(메서드)로 이루어져 있음
        // 필드 = 클래스 내부에 선언된 멤버변수
        // 멤버 : 클래스 내부에 선언된 요소
        //        클필드, 메서드, 프로퍼티, 이벤트 등등

        // 클래스는 class라는 키워드를 사용하여 선언하고, 해당 클래스 형식의 변수를 선언
        // 할 때에는 사용될 이름을 바로 뒤에 작성

        // 이름만 선언된 클래스는 객체가 아니라 객체를 만들기위한 틀

        // 클래스 내부에 해당 클래스 형태로 만들어질 객체가 가질
        // 속성(필드)과 기능(메서드)을 정의합니다.

        // 필드를 정의합니다.
        public int Val;
        // public : 외부에서 해당 멤버 변수 직접 접근 가능

        public void PrintVal()
        {
            Console.WriteLine("Val = " + Val);
        }
    }

    class _01클래스
    {
        static void Main()
        {
            MyClass myClass = new MyClass();
            // myClass 형식의 객체를 힙(메모리 형식)에 동적 할당, 스택에 할당된
            // myClass 변수가 참조되도록 함

            // 동적할당: 프로그램이 실행 중일때 메모리 할당이 이루어지는 것을 의미
            // 동적할당으로 생성된 메모리는 힙에 할당

            // new MyClass()?
            // MyClass의 생성자를 호출하며, 생성된 객체를 반환
            // new연산자 : 참조 형식의 경우 힙 메모리에 객체 생성
            //             값 형식의 경우 해당 형식의 객체를 스택에 할당
            
            // myClass.value
            // 어떤 멤버에 접근 연산자 : '.'을 사용
            myClass.Val = 10;
            // myClass가 가지고 있는 MyClass 내부에 있는 멤버 변수 Val의 값을 10으로 설정
            Console.WriteLine("myClass Val = " + myClass.Val);

            // myClass내부에 있는 기능(메서드)를 호출
            myClass.PrintVal();
        }
    }
}
