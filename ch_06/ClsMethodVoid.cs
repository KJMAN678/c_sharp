using System;

class ClsMethodVoid
{
    public void MyMethod3(int a)
    {
        if (a < 3)
        {
            return 2; // void なのに戻り値があるからエラーとなる
        }
    }

    public int MyMethod4(int a)
    {
        if (a < 3)
        {
            return; // int なのに返り値がないからエラーとなる
        }
    }
}

class MainClass
{
    static void Main()
    {
        ClsMethodVoid cmv = new ClsMethodVoid();

        Console.WriteLine(cmv.MyMethod3(2));
        Console.WriteLine(cmv.MyMethod4(2));
    }
}