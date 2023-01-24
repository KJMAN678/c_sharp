using System;

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
class Music2 : Music
{
    new public int Type = 1;

    new public void BaseInfo()
    {
        Console.WriteLine("Music2");
    }
}

class ClsHide
{
    static void Main()
    {
        var m2 = new Music2();

        m2.BaseInfo();
        Console.WriteLine(m2.Type);
    }
}