using System;

// C# 7.2 でないとエラー？

class TestClass
{
    public void TestMethod(in int num, out string s)
    {
        // num = 48; // 値を変更するとエラーとなる

        if (num = 46)
        {
            s = "keyaki";
        }
        else
        {
            s = "abc";
        }
    }
}

class MainClass
{
    static void Main()
    {
        var n = 46;
        var str = "none";

        var test = TestClass();

        test.TestMethod(n, out str);

        Console.WriteLine(str);
    }
}