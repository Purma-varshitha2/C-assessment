using System;
class Program
{
    static void Main()
    {
        Duck duck = new Duck();
        Console.WriteLine(duck.ToString());
        duck.Fly();
        duck.Swim();    
    }
}