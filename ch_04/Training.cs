using System;

class MainClass
{
    static void Main()
    {
        int x = 2;
        int y = 3;
        Console.WriteLine((x + y) * (x + y));

        string answer = (x % 2 == 0 ? "even" : "odd");
        Console.WriteLine(answer);
    }
}