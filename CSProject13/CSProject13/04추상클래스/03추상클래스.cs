using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public interface IMovement
{
    void Run();
    void Walk();

    void Idle();
}
// 인터페이스를 상속받을 추상 클래스
// 인터페이스의 메서드를 구현해도 되지만, 추상 메서드화 시켜도 됨

public abstract class Character : IMovement
{
    protected string CharacterName;
    // 암묵적 구현
    public void Idle()
    {
        Console.WriteLine(CharacterName + " 이(가) 기다립니다.");
    }
    void IMovement.Run()
    {
        Console.WriteLine(CharacterName + " 이(가) 달립니다.");
    }
    public abstract void Walk();
}

public class MyCharacter : Character
{
    public MyCharacter(string name)
    {
        CharacterName = name;
    }
    public override void Walk()
    {
        Console.WriteLine(CharacterName + " 이(가) 걷습니다.");
    }
    
}

class _03추상클래스
{
    private static void Main()
    {
        new _03추상클래스().Entry();
    }
    private void Entry()
    {
        MyCharacter player = new MyCharacter("백다방");
        player.Idle();
        player.Walk();
        (player as IMovement).Run();
    }
}