using Internal;
using System;

class MainClass
{
    static void Main()
    {
        var x = new { Name = "匿名", Age = 18 };
        System.Console.WriteLine(x.Name);
        x.Age = 20;
        System.Console.WriteLine(x.Age);
    }
}