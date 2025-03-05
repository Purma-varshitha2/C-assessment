using System;
public class Person
{
    public string Name { get; set; }
    public Person(string name)
    {
        Name = name;
    }
    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Person name:{Name}");
    }
}