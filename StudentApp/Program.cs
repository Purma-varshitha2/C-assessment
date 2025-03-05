using System;
class Program
{
    static void Main()
    {
        try
        {
            Student student1 = new Student("Ram", 444);
            student1.DisplayInfo();
            Student student2 = new Student("Jay", 446);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error:{ex.Message}");
        }
        try
        {
            Student student3 = new Student("Sri", 356);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error:{ex.Message}");
        }
    }
}