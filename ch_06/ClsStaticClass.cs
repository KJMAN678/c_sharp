using System;

static class TestClass
{
    // 静的メンバー
    public static int a;

    // 静的コンストラクター
    static TestClass()
    {
        a = 5;
    }

    // 静的メソッド
    public static void Display()
    {
        Console.WriteLine(a);
    }
}

class MainClass
{
    static void Main()
    {
        TestClass.Display();

        // var tc = new TestClass(); // 静的クラスなのでインスタンスを作成しようとするとエラーとなる
    }
}