using Internal;
using System;

class Sample
{
    static void Main()
    {
        string name = "c:\\user\\test\\sample.cs";
        string s = @"c:\user\test\sample.cs";
        string newLine = @"改行
しますた";
        string doubleQuotation = @"ダブルクォーテーションは""""と記述します";

        Console.WriteLine(name);
        Console.WriteLine(s);
        Console.WriteLine(newLine);
        Console.WriteLine(doubleQuotation);
    }
}