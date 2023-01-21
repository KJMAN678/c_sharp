using System;

class Car
{
    // データメンバー
    public string name = "";
    public int seats;

    // コンストラクター
    public Car()
    {
        Console.WriteLine("コンストラクターの実施");
    }

    // デストラクター
    ~Car()
    {
        Console.WriteLine("デストラクターの実施");
    }

}

class MainClass
{
    static void Main()
    {
        var car = new Car();
        Console.WriteLine("");
    }
}