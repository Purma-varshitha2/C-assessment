using System;
class Porgram
{
    static void Main()
    {
        Student student = new Student("varsh", 49);
        Person person = student;
        Console.WriteLine("⬆ Upcasting to Person:");
        person.DisplayInfo(); 
        
        Console.WriteLine("\n⬇ Downcasting back to Student:");

  
        if (person is Student studentObj)
        {
            Console.WriteLine($"Downcasting successful: {studentObj.Name} is a student.");
            studentObj.DisplayInfo();  
        }
        else
        {
            Console.WriteLine("Downcasting failed.");
        }

       
        Student studentAgain = person as Student;
        if (studentAgain != null)
        {
            Console.WriteLine("Downcasting succeeded.");
            studentAgain.DisplayInfo();
        }
        else
        {
            Console.WriteLine("Downcasting  failed.");
        }
    }
}