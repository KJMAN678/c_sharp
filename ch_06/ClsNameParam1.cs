using System;

class TestClass
{
    public int CalcAdd(int a, int b)
    {
        return a + b;
    }
}

class MainClass
{
    static void Main()
    {
        var test = new TestClass();

        int p = 4;

        int a = test.CalcAdd(a: 3, b: p);
        int b = test.CalcAdd(b: 3, a: p);

        Console.WriteLine(a);
        Console.WriteLine(b);
    }
}