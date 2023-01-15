using Internal;
using System;

class MainClass
{
    static void Main()
    {
        System.Console.WriteLine("{0}, {1}", short.MinValue, short.MaxValue);
        System.Console.WriteLine("{0}, {1}", int.MinValue, int.MaxValue);
        System.Console.WriteLine("{0}, {1}", long.MinValue, long.MaxValue);
        System.Console.WriteLine("{0}, {1}", double.MinValue, double.MaxValue);
        System.Console.WriteLine("{0}, {1}", decimal.MinValue, decimal.MaxValue);
    }
}