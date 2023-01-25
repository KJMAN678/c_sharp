using System;

public class TestClass
{
    public string GetProp { get; }
    public string InitProp { get; init; } // init アクセサー

    public TestClass()
    {
        this.GetProp = "";
        this.InitProp = "";
    }

    public TestClass(string gv, string iv)
    {
        this.GetProp = gv;
        this.InitProp = iv;
    }

    public void TestMethod(string gv, string iv)
    {
        this.GetProp = gv; // エラーになる
        this.InitProp = iv; // エラーになる
    }
}

class MainClass
{
    static void Main()
    {
        // コンストラクターはOK
        var t1 = new TestClass("p1", "p2");

        // 以下はエラーになる
        t1.GetProp = "";
        t1.InitProp = "";

        // オブジェクト初期化子
        var t2 = new TestClass
        {
            InitProp = "a",
            GetProp = "b", // エラーになる
        };
    }
}