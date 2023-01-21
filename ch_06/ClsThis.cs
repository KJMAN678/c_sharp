using System;

class ClassThis
{
    int num;

    public void SetNum(int num)
    {
        this.num = num;
    }

    public void PrintNum()
    {
        Console.WriteLine(this.num);
    }
}

class MainClass
{
    static void Main()
    {
        var ct = new ClassThis();
        ct.SetNum(10);
        ct.PrintNum();
    }
}