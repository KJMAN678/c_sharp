using System;

class Car
{
    public string name;
    public static int seats;

    public Car()
    {
        name = "マイカー";
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
        Car.seats = 5;

        var test = new Car();
        test.Display();

        var test2 = new Car();
        test2.Display();
    }
}