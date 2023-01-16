using System;

class MainClass
{
    static void Main()
    {
        int x = 15;

        if (x < 10)
        {
            x *= 10;
        }
        else if (x == 15)
        {
            x *= 3;
        }
        else
        {
            x = -x;
        }
        Console.WriteLine(x);
    }
}