using System;
public abstract class Animal
{
    public string Name { get; set; }
    public Animal(string name)
    {
        Name = name;
    }
    public abstract void MakeSound();
    public void DisplayInfo()
    {
        Console.WriteLine($"Animal: {Name} ");
    }
}
