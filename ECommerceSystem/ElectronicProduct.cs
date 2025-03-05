public class ElectronicProduct : Product
{
    public ElectronicProduct(string name, double price) : base(name, price) { }

    public override double GetDiscountedPrice()
    {
        double discountPrice = Price * 0.90; 
        Console.WriteLine($"Electronic Discount (10%) for {Name}. New Price: ${discountPrice}");
        return discountPrice;
    }
}
