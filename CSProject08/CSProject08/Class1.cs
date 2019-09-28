using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProject08
{
    class Class1
    {
        // internal 이는 접근 제한자중 하나로 같은 프로젝트 내에서만 접근이 가능한 제한자
        internal static void Print()
        {
            Console.WriteLine("Print");
        }
        public static void PrintHello()
        {
            Console.WriteLine("Hello");
        }
        static void Main()
        {
            PrintHello();
            Print();
        }
    }
}
