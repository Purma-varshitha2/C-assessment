using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter total cart amount:");
        decimal totalAmount = Convert.ToDecimal(Console.ReadLine());

        ShoppingCart cart = new ShoppingCart(totalAmount);

        Console.WriteLine("Select Discount Type: ");
        Console.WriteLine("1. No Discount");
        Console.WriteLine("2. 10% Percentage Discount");
        Console.WriteLine("3. $20 Fixed Amount Discount");

        int choice = Convert.ToInt32(Console.ReadLine());

        switch (choice)
        {
            case 1:
                cart.SetDiscountStrategy(new NoDiscount());
                break;
            case 2:
                cart.SetDiscountStrategy(new PercentageDiscount(10)); 
                break;
            case 3:
                cart.SetDiscountStrategy(new FixedAmountDiscount(20));
                break;
            default:
                Console.WriteLine("Invalid choice. No discount applied.");
                cart.SetDiscountStrategy(new NoDiscount());
                break;
        }

        decimal finalAmount = cart.GetFinalAmount();
        Console.WriteLine($"Final price after discount: ${finalAmount}");
    }
}
