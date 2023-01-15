using System;

class MainClass
{

    enum Season
    {
        Spring, Summer, Fall, Winter
    }
    static void Main()
    {
        Console.WriteLine("3-2");
        int a = 123;
        float b = 1.23f;
        Console.WriteLine("a:{0}, b:{1}", a, b);

        Console.WriteLine("3-3");
        string c = "¥1000";
        string d = @"¥1000";
        int e = 1000;
        Console.WriteLine(c);
        Console.WriteLine(d);
        Console.WriteLine("¥{0}", e);

        Console.WriteLine("3-4");
        Console.WriteLine(Season.Spring);
        Console.WriteLine((int)Season.Spring);

        Console.WriteLine("3-5");
        var season = new[] { "春", "夏", "秋", "冬" };
        Console.WriteLine(season[(int)Season.Spring]);
    }
}