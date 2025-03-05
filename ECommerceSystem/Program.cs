using System;

class Program
{
    static void Main()
    {
        Product genericProduct = new Product("General Item", 50);
        ElectronicProduct laptop = new ElectronicProduct("Laptop", 1000);
        ClothingProduct tshirt = new ClothingProduct("T-Shirt", 50);

       
        Console.WriteLine("\nProduct Prices Before Discounts:");
        genericProduct.DisplayInfo();
        laptop.DisplayInfo();
        tshirt.DisplayInfo();
        Console.WriteLine("\nDiscounted Prices:");
        genericProduct.GetDiscountedPrice();
        laptop.GetDiscountedPrice();
        tshirt.GetDiscountedPrice();
    }
}
