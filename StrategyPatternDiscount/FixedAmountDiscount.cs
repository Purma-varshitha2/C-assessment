public class FixedAmountDiscount : IDiscountStrategy
{
    private readonly decimal _discountAmount;

    public FixedAmountDiscount(decimal discountAmount)
    {
        _discountAmount = discountAmount;
    }

    public decimal ApplyDiscount(decimal totalAmount)
    {
        return totalAmount > _discountAmount ? totalAmount - _discountAmount : 0;
    }
}
