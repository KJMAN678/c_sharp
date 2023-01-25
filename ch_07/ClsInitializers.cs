using System;

class SampleClass
{
    // フィールド
    public int v1 = 10;
    private int v2;

    // 規定のコンストラクター
    public SampleClass()
    {
        Console.WriteLine(this.v1);
    }
}

class ClsInitializers
{
    static void Main()
    {
        var test = new SampleClass { v1 = 20 };
        Console.WriteLine(test.v1);

        // private のメンバーは設定できないのでコンパイルエラーとなる
        // var test2 = new SampleClass { v2 = 20 };
    }
}