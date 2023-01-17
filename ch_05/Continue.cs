using System;

class MainClass
{
    static void Main()
    {
        for (int i = 0; true; i++)
        {
            if (i < 8)
            {
                continue;
            }
            else if (i == 10)
            {
                break;
            }
            Console.WriteLine(i);
        }
    }
}