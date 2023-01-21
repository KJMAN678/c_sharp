using System;

class TestClass
{
    public void PrintName(int no, string name = "nanashi")
    {
        Console.WriteLine(no + "→" + name);
    }
}

class MainClass
{
    static void Main()
    {
        var test = new TestClass();

        test.PrintName(10, "nanashi");

        test.PrintName(10);
    }
}