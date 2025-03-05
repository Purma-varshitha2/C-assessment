using System;

public class Product
{
    public string Name { get; set; }
    public double Price { get; set; }

    public Product(string name, double price)
    {
        Name = name;
        Price = price;
    }

    public virtual double GetDiscountedPrice()
    {
        Console.WriteLine($"No specific discount for {Name}. Regular Price: ${Price}");
        return Price;  
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"📦 Product: {Name}, Price: ${Price}");
    }
}
