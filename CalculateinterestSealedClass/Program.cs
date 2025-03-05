using System;
class Program
{
    static void Main()
    {
        Account account = new Account(20000);
        SavingsAccount savingacc = new SavingsAccount(25000, 3);
        Console.WriteLine("\nGeneral Account Interest is calculated as:");
        account.CalculateInterest();
        Console.WriteLine("\nSavings Account Interest is calculated as:");
        savingacc.CalculateInterest();
    }
}
