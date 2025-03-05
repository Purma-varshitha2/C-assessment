using System;

public sealed class SecuritySystem
{
    public void AuthenticateUser(string username,string password)
    {
        if (username == "purma20" && password == "varsh123")
        {
            Console.WriteLine("Access Granted!");
        }
        else
        {
            Console.WriteLine("Access Denied!");
        }
    }
}
