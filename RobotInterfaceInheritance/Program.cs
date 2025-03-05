using System;
class Program
{
    static void Main()
    {
        Robot robot=new Robot("RoboCop");
        Console.WriteLine("\nRobot Details are:");
        robot.DisplayInfo();
        Console.WriteLine("\nActivating Robot");
        robot.Start();
        Console.WriteLine("\nRobot is moving");
        robot.Move();
    }
}