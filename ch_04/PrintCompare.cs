using System;

class MainClass
{
    static void Main()
    {
        int a = 1;
        int b = 2;
        bool c;

        c = (a < b) && (a == b);
        Console.WriteLine(c);

        c = (a < b) || (a == b);
        Console.WriteLine(c);
    }
}