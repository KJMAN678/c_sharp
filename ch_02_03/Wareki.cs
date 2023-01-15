using System;
using System.Globalization;

class MainClass
{

    static void Main()
    {
        var ci = new CultureInfo("ja-JP");
        ci.DateTimeFormat.Calendar = new JapaneseCalendar();

        var dl = new DateTime(2019, 5, 1);

        Console.WriteLine(dl.ToString("yyyy年MM月dd日"));
        Console.WriteLine(dl.ToString("ggyy年MM月dd日", ci));
    }
}