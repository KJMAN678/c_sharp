using System;

class ClsMethod
{
    public void PrintOne()
    {
        Console.WriteLine("1");
    }

    static void Main()
    {
        var test = new ClsMethod();
        test.PrintOne();
    }
}