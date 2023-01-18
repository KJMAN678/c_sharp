using System;

class MainClass
{
    static void Main()
    {
        int total1 = 0;
        for (int i = 1; i <= 10; i++)
        {
            total1 += i;
        }
        Console.WriteLine(total1);

        int total2 = 0;
        int count1 = 1;
        while (count1 <= 10)
        {
            total2 += count1;
            count1++;
        }
        Console.WriteLine(total2);

        int count_num = 1;
        int count_output_times = 1;
        while (count_num <= 50)
        {
            if (count_num % 3 == 0 || Convert.ToString(count_num).Contains("3"))
            {
                if (count_output_times != 1)
                {
                    Console.Write(" ");
                }
                Console.Write(count_num);
                count_output_times++;
            }
            count_num++;
        }
        Console.WriteLine();

        string[] era_names = {"明治", "大正", "昭和", "平成", "令和"};

        foreach (string str in era_names)
        {
            Console.WriteLine(str);
        }
    }
}