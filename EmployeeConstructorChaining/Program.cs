using System;
class Program
{
    static void Main()
    {
        Employee employee = new Employee("Mahi",20000);
        Manager manager = new Manager("Ravi", 50000,25000);
        Console.WriteLine("\nEmployee Details:");
        employee.DisplayInfo();
        Console.WriteLine("\nManager Details:");
        manager.DisplayManagerInfo();
    }
}