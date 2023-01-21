using System;

class TestClass
{
    public long AddNums(int a, int b)
    {
        return a + b;
    }

    public long AddNums(int a, int b, int c)
    {
        return a + b + c;
    }

    public long AddNums(long a, long b)
    {
        return a + b;
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
        var tc = new TestClass();
        var a = tc.AddNums(1, 2, 3);

        Console.WriteLine(a);
    }
}