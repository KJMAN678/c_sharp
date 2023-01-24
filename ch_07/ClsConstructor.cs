using System;

class Music
{
    public Music() // 基本クラスのコンストラクター実行
    {
        Console.WriteLine("基本クラスのコンストラクター");
    }
}

class Song : Music
{
    public string Key = "C#"; // フィールドの初期化

    public Song() // 派生クラス
    {
        Console.WriteLine("派生クラスのコンストラクター");
    }
}

class MainClass
{
    static void Main()
    {
        var s = new Song();
    }
}