using System;
class Program
{
    static void Main()
    {
        Car car = new Car("Toyoto", 180, 4);
        Bike bike = new Bike("Honda", 120, true);
        Console.WriteLine("\nCar Details:");
        car.DisplayInfo();
        Console.WriteLine("\nBike Details:");
        bike.DisplayInfo();
    }
}
