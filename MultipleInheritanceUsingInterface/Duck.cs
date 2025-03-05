using System;
public class Duck : ISwimmable, IFlyable
{
    public void Swim()
    {
        Console.WriteLine("Duck is swimming");
    }
    public void Fly()
    {
        Console.WriteLine("Duck is flying");
    }
}