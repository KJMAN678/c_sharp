using System;

class MainClass
{
    static void Main()
    {
        int x = -5;

        Console.WriteLine(x >= 0 ? x : -x);
        Console.WriteLine(x < 0 ? '負' : '正');
    }
}