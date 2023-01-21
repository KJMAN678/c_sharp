using System;

class TestClass
{
    public int CalcAdd2(int a, int b, int c)
    {
        return a + b + c;
    }
}

class ClsNameParam2
{
    static void Main()
    {
        var test = new TestClass();

        int p = 4;

        int a = test.CalcAdd2(3, c: 4, b: 2);

        // エラー
        int b = test.CalcAdd2(a: 3, 4, 1);

        // エラー
        int c = test.CalcAdd2(b: p, a: 3, 1);

        Console.WriteLine(a);
        Console.WriteLine(b);
    }
}