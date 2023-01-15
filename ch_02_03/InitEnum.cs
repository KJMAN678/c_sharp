using System.Globalization;
using System.Reflection.Metadata;
using Internal;
using System;

class Sample
{
    enum Day
    {
        Sun, Mon, Tue = 10,
        Wed, Thu, Fri = Sun,
        Sat
    }
    static void Main()
    {
        Console.WriteLine((int)Day.Mon);
        Console.WriteLine((int)Day.Tue);
        Console.WriteLine((int)Day.Wed);
        Console.WriteLine((int)Day.Fri);
        Console.WriteLine((int)Day.Sat);
    }
}