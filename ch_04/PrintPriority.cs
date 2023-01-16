using System;

class MainClass
{
    static void Main()
    {
        int a, b = 2;

        a = (b *= (5 + 10));

        Console.WriteLine(a);
    }
}