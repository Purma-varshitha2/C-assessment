using System;
public class Robot : Machine, IMovable
{
    public string Model { get; set; }
    public Robot(string model)
    {
        Model = model;
    }
    public void Move()
    {
        Console.WriteLine($"{Model} is moving forward.");
    }
    public void DisplayInfo()
    {
        Console.WriteLine($"Robot model:{Model}");
    }
}
