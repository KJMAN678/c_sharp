using System;

class MainClass
{
    static void Main()
    {
        int month = DateTime.Now.Month;

        switch (month)
        {
            case 1:
                Console.WriteLine("睦月");
                break;
            case 2:
                Console.WriteLine("如月");
                break;
            case 3:
                Console.WriteLine("弥生");
                break;
            case 7:
            case 8:
                Console.WriteLine("夏休み");
                break;
            default:
                Console.WriteLine(month + "月");
                break;
        }
    }
}