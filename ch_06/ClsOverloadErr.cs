using System;

class TestClass
{
    public int AddNums(int a, int b)
    {
        return a + b;
    }

    public long AddNums(int c, int d)
    {
        return c + d;
    }

    public long AddNums(out int a, int b)
    {
        a = b;
        return a;
    }

    public long AddNums(ref int a, int b)
    {
        return a + b;
    }
}

class MainClass
{
    static void Main()
    {
        var ts = new TestClass();
        var a = ts.AddNums(1, 2);

        Console.WriteLine(a);
    }
}