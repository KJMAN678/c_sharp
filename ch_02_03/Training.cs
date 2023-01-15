using Internal;
using System;

class MainClass
{

    enum Season
    {
        Spring, Summer, Fall, Winter
    }
    static void Main()
    {
        System.Console.WriteLine("3-2");
        int a = 123;
        float b = 1.23f;
        System.Console.WriteLine("a:{0}, b:{1}", a, b);

        System.Console.WriteLine("3-3");
        string c = "¥1000";
        string d = @"¥1000";
        int e = 1000;
        System.Console.WriteLine(c);
        System.Console.WriteLine(d);
        System.Console.WriteLine("¥{0}", e);

        System.Console.WriteLine("3-4");
        System.Console.WriteLine(Season.Spring);
        System.Console.WriteLine((int)Season.Spring);

        System.Console.WriteLine("3-5");
        var season = new[] { "春", "夏", "秋", "冬" };
        System.Console.WriteLine(season[(int)Season.Spring]);
    }
}