using System;

static class Calc
{
    public static int Pow(int a)
    {
        int factorial = 1;

        for (int i = 2; i <= a; i++)
        {
            factorial *= i;
        }

        return factorial;
    }
}

class TestClass
{
    public void TestFunc(ref int a, out int b)
    {
        b = a * a;
        a = a * a * a;
    }
}

// public class Sample
// {
//     private int Code;
//     public string Name;

//     public Sample()
//     {
//         Name = "my name";
//     }
// }

public static class Sample
{
    private static int Code;
    public static string Name;

    static Sample()
    {
        Name = "my name";
    }
}


class MainClass
{
    static void Main()
    {
        int answer = Calc.Pow(10);
        Console.WriteLine(answer);

        // TestClass test = new();
        var test = new TestClass();
        int a = 3;
        // test.TestFunc(a, int b);
        test.TestFunc(ref a, out int b);

    }
}