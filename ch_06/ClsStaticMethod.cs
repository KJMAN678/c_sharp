using System;

class Car
{
    // メンバー変数
    public string name;
    public static int seats;

    public Car()
    {
        name = "マイカー";
    }

    // 静的メソッド
    public static void SetSeat(int n)
    {
        seats = n; // 静的メンバーのみアクセス可能
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
        Car.SetSeat(5);

        var test = new Car();
        test.Display();

        var test2 = new Car();
        test2.Display();
    }
}