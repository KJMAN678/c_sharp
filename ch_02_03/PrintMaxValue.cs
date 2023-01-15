using System;

class MainClass
{
    static void Main()
    {
        Console.WriteLine("{0}, {1}", short.MinValue, short.MaxValue);
        Console.WriteLine("{0}, {1}", int.MinValue, int.MaxValue);
        Console.WriteLine("{0}, {1}", long.MinValue, long.MaxValue);
        Console.WriteLine("{0}, {1}", double.MinValue, double.MaxValue);
        Console.WriteLine("{0}, {1}", decimal.MinValue, decimal.MaxValue);
    }
}