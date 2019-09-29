using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProject09.생성자_소멸자
{
    // 소멸자
    // 반환 지정 불가, overload 불가, 매개변수 추가 불가, 명시적 호출 불가

    class Hello_World
    {
        public int id;

        public Hello_World(int id) {
            this.id = id;
            Console.WriteLine("생성자가 호출되었습니다.");
        }
        ~Hello_World()
        {
            Console.WriteLine("소멸자가 호출되었습니다.");
        }

      
    }
   
    class 생성자_소멸자
    {
        static void Main()
        {

        }
    }
    public void Entry()
    {
        for (int i = 0; i < 10; i++) new Hello_World(i);
    }
}
