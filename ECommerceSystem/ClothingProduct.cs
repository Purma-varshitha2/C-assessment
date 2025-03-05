public class ClothingProduct : Product
{
    public ClothingProduct(string name, double price) : base(name, price) { }

    public override double GetDiscountedPrice()
    {
        double discountPrice = Price * 0.80; 
        Console.WriteLine($"Clothing Discount (20%) for {Name}. New Price: ${discountPrice}");
        return discountPrice;
    }
}
