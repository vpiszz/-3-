using System;

public class Vehicle
{
    public virtual void Drive()
    {
        Console.WriteLine("Транспортное средство едет.");
    }
}

public class Car : Vehicle
{
    public override void Drive()
    {
        Console.WriteLine("Машина едет по дороге.");
    }
}

public class Bicycle : Vehicle
{
    public override void Drive()
    {
        Console.WriteLine("Велосипед едет по тротуару.");
    }
}

public class Boat : Vehicle
{
    public override void Drive()
    {
        Console.WriteLine("Лодка плывёт по воде.");
    }
}

public class Program
{
    public static void Main()
    {
        Vehicle[] vehicles = new Vehicle[]
        {
            new Car(),
            new Bicycle(),
            new Boat()
        };

        foreach (var vehicle in vehicles)
        {
            vehicle.Drive();
        }
    }
}
