using System;

// 基本クラス
class Music
{
    public virtual void BaseInfo()
    {
        Console.WriteLine("Music");
    }
}

// 派生クラス
class Song : Music
{
    public override void BaseInfo() // 基本クラスのメソッドをオーバーライド
    {
        Console.WriteLine("Song");
    }
}

// 派生クラス
class Music2 : Music
{
    new public void BaseInfo() // 基本クラスのメソッドを隠蔽
    {
        Console.WriteLine("Music2");
    }
}

class ClsOverride
{
    static void Main()
    {
        var s = new Song();
        s.BaseInfo();

        var m2 = new Music2();
        m2.BaseInfo();

        var m = new Music();
        m.BaseInfo();
    }
}