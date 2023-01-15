using System;

class Sample
{

    enum Day
    {
        Sun, Mon, True, Wed, Thu, Fri, Sat
    }

    static void Main()
    {
        Console.WriteLine(Day.Sun);
        Console.WriteLine((int)Day.Sat);
    }
}