public class Car : Vehicle
{
    public int NoOfDoors { get; set; }
    public Car(string brand, int speed, int numOfDoors) : base(brand, speed)
    {
        NoOfDoors = numOfDoors;
    }
    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Numberofdoors:{NoOfDoors}");
    }
}