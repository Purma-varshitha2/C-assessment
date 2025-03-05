public class SavingsAccount : Account
{
    public double InterestRate { get; set; }
    public SavingsAccount(double balance,double interestRate):base(balance)
    {
        InterestRate = interestRate;
    }
    public sealed override void CalculateInterest()
    {
        double interest = Balance * InterestRate / 100;
        Console.WriteLine($"Savings account interest:{interest}");
    }
}
