using System;

// 基本クラス
class Music
{
    public int Type = 0;
    public string Name = "Music";

    public void BaseInfo()
    {
        Console.WriteLine("Music");
    }
}

// 派生クラス
class Song : Music
{
    public string Key = "C#";

    public void DrvInfo()
    {
        Console.WriteLine("Song");
    }
}

class MainClass
{
    static void Main()
    {
        var s = new Song(); // 派生クラスのインスタンス

        Console.WriteLine(s.Key); // 出力:C#
        s.DrvInfo(); // 出力:Song

        Console.WriteLine(s.Type); // 出力:0
        s.BaseInfo(); // 出力:Music

        var m = new Music(); // 基本クラスのインスタンス

        Console.WriteLine(m.Type); // 出力:0
        m.BaseInfo(); // 出力:Music
    }
}