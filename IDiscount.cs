namespace WebApplication6.Services.Discount
{
    public interface IDiscountPolicy
    {
        decimal Apply(decimal amount);
    }
}
