using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public interface IReceiveMessage
{
    // 메세지를 받는 메서드
    void ReceiveMessage(Phone phone, string text);
}

public interface ISendMessage : IReceiveMessage
{
    void SendMessage(ISendMessage phone);
}

public interface ICall
{
    void Call(string phonenumber);
}

class Phone : ICall, ISendMessage
{
    private string PhoneNumber;
    public Phone(string phonenumber)
    {
        PhoneNumber = phonenumber;
    }

    public void Call(string phonenumber)
    {
        Console.WriteLine(phonenumber + "로 전화를 겁니다.");
    }
    // 문자 메세지를 보냅니다.
    public void SendMessage(ISendMessage phone)
    {
        Console.WriteLine("어떤 메세지를 보낼까요?");
        phone.ReceiveMessage(this, Console.ReadLine());
    }

    public void ReceiveMessage(Phone phone, string text)
    {
        for (int i = 0; i < 3; i++)
        {
            System.Threading.Thread.Sleep(400);
            System.Media.SystemSounds.Beep.Play();
        }

        Console.WriteLine();
        Console.WriteLine(" = 메세지 도착 알림 = ");
        Console.WriteLine(phone.GetHashCode() + "로부터 메세지가 도착했습니다. ");
        Console.Write("내용 : ");

        for (int i = 0; i < text.Length; i++)
        {
            System.Threading.Thread.Sleep(100);
            Console.WriteLine(text[i]);
        }
    }
    public string GetPhoneNumber() { return PhoneNumber; }
}

class _02인터페이스
{
    private static void Main()
    {
        new _02인터페이스().Entry();
    }
    private void Entry()
    {
        Phone myPhone = new Phone("01012345678");
        Phone yourPhone = new Phone("01098765432");

        myPhone.Call(yourPhone.GetPhoneNumber());
        myPhone.SendMessage(yourPhone);
    }
}