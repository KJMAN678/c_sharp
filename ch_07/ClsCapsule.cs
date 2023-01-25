using System;

// 基本クラス
class Music
{
    int type = 0;
    protected string name = "Music";

    // type フィールドに値を設定するpublicメソッド
    public void SetType(int type)
    {
        this.type = type;
    }

    // フィールドの値を出力する仮想メソッド
    public virtual void PrintName()
    {
        Console.WriteLine(type);
        Console.WriteLine(name);
    }
}

// 派生クラス
class Song : Music
{
    public override void PrintName()
    {
        // this.type = 1;
        this.name = "Song";
        base.PrintName(); // 基本クラスのメソッドを呼び出す
    }
}

class ClsCapsule
{
    static void Main()
    {
        var s = new Song();
        s.SetType(1);
        // s.name = "test";
        s.PrintName();
    }
}