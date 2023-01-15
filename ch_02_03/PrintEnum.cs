using Internal;
using System;

class Sample
{

    enum Day
    {
        Sun, Mon, True, Wed, Thu, Fri, Sat
    }

    static void Main()
    {
        System.Console.WriteLine(Day.Sun);
        System.Console.WriteLine((int)Day.Sat);
    }
}