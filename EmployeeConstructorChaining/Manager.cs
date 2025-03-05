public class Manager : Employee
{
    public double Bonus { get; set; }
    public Manager(string name, double salary, double bonus) : base(name, salary)
    {
        Bonus = bonus;
    }
    public void DisplayManagerInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Bonus:{Bonus}");
    }
}