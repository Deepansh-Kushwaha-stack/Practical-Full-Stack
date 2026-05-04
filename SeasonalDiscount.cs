namespace WebApplication6.Services.Discount
{
    public class SeasonalDiscount : IDiscountPolicy
    {
        public decimal Apply(decimal amount)
        {
            return amount - (amount * 0.1m);
        }
    }
}
