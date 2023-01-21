using System;

class Car
{
    // データメンバー
    public string name = "";
    public int seats;

    // コンストラクター。コンストラクターはクラス名と同じにする必要がある。
    public Car()
    {
        Console.WriteLine("コンストラクターの実行");
        seats = 4;
    }

    // string型のパラメーターを受け取るコンストラクター
    public Car(string str)
    {
        Console.WriteLine("string型のパラメーターを受け取るコンストラクターの実行");
        seats = 4;
        name = str;
    }
}

class MainClass
{
    static void Main()
    {
        var test = new Car();
        Console.WriteLine(test.name);

        var test2 = new Car("マイカー");
        Console.WriteLine(test2.name);
    }
}