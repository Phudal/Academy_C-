using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// 중첩 클래스?
// ㅡ 내부 클래스라고도 함
// ㅡ 자신이 속한 클래스의 멤버에 자유롭게 접근할 수 있음

partial class GameCharacter
{
    public class Info
    {
        private string Name;
        private uint Level;
        public Info(string name, uint level)
        {
            this.Name = name;
            this.Level = level;
        }
        // 필드에 대한 접근자 구성   
        public string GetName() { return Name; }
        public uint GetLevel() { return Level; }
    }
}

public partial class GameCharacter
{
    private Info PlayerCharacterInfo = null;

    public Info GetCharacterInfo() { return PlayerCharacterInfo; }

    public GameCharacter(Info InitialInfo)
    {
        PlayerCharacterInfo = InitialInfo;
    }
}

class _01중첩클래스
{
    private GameCharacter CharacterInstance = null;

    private static void Main() { new _01중첩클래스().Entry(); }

    private void Entry()
    {
        CharacterInstance = new GameCharacter(new GameCharacter.Info("정수짱", 400));

        Console.WriteLine("캐릭터 닉네임: " + CharacterInstance.GetCharacterInfo().GetName());
        Console.WriteLine(CharacterInstance.GetCharacterInfo().GetName() + "의 레벨: "
            + CharacterInstance.GetCharacterInfo().GetLevel());
    }
}