using System;

class ClsMethodRet
{
    public int MyMethod1()
    {
        return 10;
    }

    public void MyMethod2(int a)
    {
        if (a < 3)
        {
            return;
        }
        Console.WriteLine(a);
    }
}

class MainClass
{
    static void Main()
    {
        ClsMethodRet cmr = new ClsMethodRet();

        int num = cmr.MyMethod1();
        Console.WriteLine(num);

        cmr.MyMethod2(10);
        cmr.MyMethod2(2);
    }
}