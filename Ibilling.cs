namespace WebApplication6.Services.Billing
{
    public class Ibilling
    {
        public interface IBillingStrategy
        {
            decimal Calculate(decimal usage);
        }
    }
}
