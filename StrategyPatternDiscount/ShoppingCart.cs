using System;

public class ShoppingCart
{
    private IDiscountStrategy _discountStrategy;
    public decimal TotalAmount { get; set; }

    public ShoppingCart(decimal totalAmount)
    {
        TotalAmount = totalAmount;
        _discountStrategy = new NoDiscount(); 
    }

   
    public void SetDiscountStrategy(IDiscountStrategy discountStrategy)
    {
        _discountStrategy = discountStrategy;
    }

    
    public decimal GetFinalAmount()
    {
        return _discountStrategy.ApplyDiscount(TotalAmount);
    }
}
