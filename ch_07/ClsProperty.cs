using System;

class Music
{
    int type = 0;
    protected string name = "Music";

    public int Type
    {
        set { this.type = value; }
        get { return this.type; }
    }
}

class ClsProperty
{
    static void Main()
    {
        var m = new Music();
        m.Type = 1; // setが呼ばれる
        Console.WriteLine(m.Type); // getが呼ばれる
    }
}