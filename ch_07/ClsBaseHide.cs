using System;

class BaseClass
{
    public int Type = 0;
}

class NewClass : BaseClass
{
    new public int Type = 1;

    public void Print()
    {
        Console.WriteLine(this.Type);
        Console.WriteLine(base.Type);
    }
}

class MainClass
{
    static void Main()
    {
        var n = new NewClass();

        n.Print();
    }
}