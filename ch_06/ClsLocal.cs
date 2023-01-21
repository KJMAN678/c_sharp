using System;

class MainClass
{
    static int AddNums(int a, int b)
    {
        return a + b;
    }

    static void Main()
    {

        for (int i = 0; i < 3; i++)
        {
            int a = AddNums(i, 2);
            Console.Write(a);
        }
    }
}