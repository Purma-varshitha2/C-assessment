using System;

class Program
{
    static void Main()
    {
        SecuritySystem system = new SecuritySystem();

        Console.WriteLine("Testing Security System Authentication:");
        system.AuthenticateUser("purma20","varsh123"); 
        system.AuthenticateUser("user","wrongpass");  
    }
}

