using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// 프로퍼티
// 기존에 사용했던 Getter, Setter를 구성하는 방식의 번거로움을 덜어주는 기능
// 사용한다면 편의성, 은닉성을 지킬 수 있음

// 프로퍼티 선언 방법?
// 데이터 형식 필드 이름;
// 접근 제한자 데이터 형식 프로퍼티 이름{
// get {return 필드 이름}
// set {필드이름 = value}
// }

public class SampleClass
{
    private string MyString;

    // 프로퍼티 구성
    public string myString
    {
        get { return MyString; }
        // 필드로부터 받을 받아옴
        set { MyString = value; }
        // 필드의 값을 할당(수정)
        // value = set 접근자의 암묵적 매개 변수
    }
}

class _01프로퍼티
{
    private static void Main()
    {
        new _01프로퍼티().Entry();
    }
    private void Entry()
    {
        SampleClass sample = new SampleClass();
        sample.myString = "안녕하세요";
        Console.WriteLine(sample.myString);
    }
}