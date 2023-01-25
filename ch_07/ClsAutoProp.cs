using System;

class SampleClass
{
    // 自動で内部的なint型のフィールドが生成される
    public int Type { get; set; }
}

class ClsAutoProp
{
    static void Main()
    {
        var test = new SampleClass();

        test.Type = 1;
        Console.WriteLine(test.Type);
    }
}