using static WebApplication6.Services.Billing.Ibilling;

namespace WebApplication6.Services.Billing
{
    public class BillingFactory
    {
        public static IBillingStrategy GetStrategy(string type)
        {
            return type switch
            {
                "Flat" => new FlatRateBilling(),
                "Usage" => new UsageBilling(),
                "Tiered" => new TieredBilling(),
                _ => throw new Exception("Invalid Billing Type")
            };
        }
    }
}
