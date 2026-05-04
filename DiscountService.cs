namespace WebApplication6.Services.Discount
{
    public class DiscountService
    {
        public decimal ApplyAll(decimal amount, List<IDiscountPolicy> discounts)
        {
            foreach (var d in discounts)
            {
                amount = d.Apply(amount);
            }
            return amount;
        }
    }
}
