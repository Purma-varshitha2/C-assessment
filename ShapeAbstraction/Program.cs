using System;
class Program
{
    static void Main()
    {
        Shape Circle = new Circle(10);
        Console.WriteLine("Circle:");
        Circle.DisplayArea();
        Shape Rectangle = new Rectangle(12, 6);
        Console.WriteLine("\nRectangle");
        Rectangle.DisplayArea();
    }
}