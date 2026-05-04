namespace WebApplication6.Services.Discount
{
    public class CouponDiscount : IDiscountPolicy
    {
        public decimal Apply(decimal amount)
        {
            return amount - 100;
        }
    }
}
