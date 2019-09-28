using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProject07.선택적_매개변수
{
    class 선택적_매개변수
    {
        //선택적 매개변수: 기본값이 할당되어있고, 필요에 따라 데이터 할당 가능
        //메서드 호출할 시 데이터 할당 생략 가능

        enum CalculateType { Add, Sub, Mul, Div}

        static double Calculate(double A, double B,
            CalculateType type = CalculateType.Add, bool PrintResult = false)
        {
            string calculatetype = "";

            double result = 0.0;

            switch (type)
            {
                case CalculateType.Add:
                    result = (A + B);
                    break;
                case CalculateType.Sub:
                    result = (A - B);
                    break;
                case CalculateType.Mul:
                    result = (A * B);
                    break;
                case CalculateType.Div:
                    result = (A / B);
                    break;
            }
            if (PrintResult)
                Console.WriteLine(calculatetype + "결과: " + result);

            return result;
        }
        static void Main()
        {
            Console.WriteLine("연산할 첫번재 데이터 입력: ");
            double data1 = double.Parse(Console.ReadLine());
            Console.WriteLine("연산할 두번재 데이터 입력: ");
            double data2 = double.Parse(Console.ReadLine());

            double result = Calculate(data1, data2, CalculateType.Add, true);

            Console.WriteLine("연산 결과: " + result);
        }
    }
}
