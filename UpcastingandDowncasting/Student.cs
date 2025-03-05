public class Student:Person
{
    public int RollNo { get; set; }
    public Student(string name,int rollNo):base(name)
    {
        RollNo = rollNo;
    }
    public override void DisplayInfo()
    {
        Console.WriteLine($"Student name:{Name} and RollNo:{RollNo}");
    }
}
