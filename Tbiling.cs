using static WebApplication6.Services.Billing.Ibilling;

namespace WebApplication6.Services.Billing
{
        public class TieredBilling : IBillingStrategy
        {
            public decimal Calculate(decimal usage)
            {
                if (usage <= 100)
                    return usage * 5;

                return (100 * 5) + ((usage - 100) * 8);
            }
        }
}
