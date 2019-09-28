using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProject07.로컬함수
{
    class _01로컬함수
    {
        // 로컬함수 : 메서드 내부에서 선언되며, 선언된 메서드 안에서만 사용 가능한 함수
        static void Main()
        {
            const string EndLine = "\n";
            void PrintString(string print, bool ln = true)
            {
                Console.Write(print + (ln ? EndLine : " "));
            }
            PrintString("Hello", false);
            PrintString("World");
        }
    }
}
