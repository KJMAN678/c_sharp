using System;

class MainClass
{
    static void Main()
    {
        for (int i = 0; true; i++)
        {
            if (i == 3)
            {
                break;
            }
            Console.WriteLine(i);
        }
    }
}