using System;
public class Account
{
    public double Balance { get; set; }
    public Account(double balance)
    {
        Balance = balance;
    }
    public virtual void CalculateInterest()
    {
        double interest = Balance * 2 / 100;
        Console.WriteLine($"General account interest:{interest}");
    }
}
