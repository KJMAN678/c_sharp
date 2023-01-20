using System;
using System.Collections.Generic;

class Car
{
    public string name = "";
    public int seats = 4;
}

class CarTargetType
{

    static void Main()
    {
        var cars = new Dictionary<int, Car>();

        Car mycar = new Car();
        mycar.name = "CX-30";

        cars.Add(1, mycar);
        cars.Add(2, new Car());

        cars[2].name = "GT-R";

        Console.WriteLine(cars[1].name);   // 出力値：CX-30
        Console.WriteLine(cars[2].name);   // 出力値：GT-R
    }
}