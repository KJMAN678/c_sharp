using System;

class MainClass
{
    static void Main()
    {
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine(i); // コンパイルエラーとなる
    }
}