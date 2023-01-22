using System;

class Car
{
    public string name;
    public static int seats;

    public Car()
    {
        name = "マイカー";
        Console.WriteLine(name);
    }

    // 静的コンストラクター
    static public Car()
    {
        seats = 4;
        Console.WriteLine(seats);
    }

    // 静的メソッド
    public static void SetSeat(int n)
    {
        seats = n;
    }

    public void Display()
    {
        Console.WriteLine(seats);
    }
}

class MainClass
{
    static void Main()
    {
        var test = new Car();

        Car.SetSeat(5);

        var test2 = new Car();

        test2.Display();
    }
}