using System;
public class Employee
{
    public string Name { get; set; }
    public double Salary { get; set; }

    public Employee(string name,double salary)
    {
        Name = name;
        Salary = salary;
    }
    public void DisplayInfo()
    {
        Console.WriteLine($"Name:{Name},Salary:{Salary}");
    }
}