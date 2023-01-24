using System;

class BaseClass
{
    public BaseClass(string s)
    {
        Console.WriteLine(s);
    }
}

class DerivedClass : BaseClass
{
    // base キーワードで、パラメーターを指定
    public DerivedClass(string s1, string s2) : base(s2)
    {
        Console.WriteLine(s1);
    }
}

class ClsBVase
{
    static void Main()
    {
        var c = new DerivedClass("Derived", "Base");
    }
}