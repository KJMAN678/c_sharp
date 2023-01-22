using System;
using System.Runtime.CompilerServices;

class Sample
{
    [ModuleInitializer]
    public static void InitMethod()
    {
        // 明示的に呼び出さなくても表示される
        Console.WriteLine("最初の1回だけ実行");
    }
}

class MainClass
{
    static void Main()
    {
        Console.WriteLine("実行");
    }
}