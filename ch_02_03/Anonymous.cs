using System;

class MainClass
{
    static void Main()
    {
        var x = new { Name = "匿名", Age = 18 };
        Console.WriteLine(x.Name);
        // x.Age = 20; // エラーになる
        // Console.WriteLine(x.Age);
    }
}