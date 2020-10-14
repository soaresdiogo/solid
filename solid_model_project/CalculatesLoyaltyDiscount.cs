using solid_model_project.Interfaces;
using solid_model_project.Constants;

namespace solid_model_project
{
    public class CalculatesLoyaltyDiscount : ICalculatesLoyaltyDiscount
    {
        public decimal ApplyLoyaltyDiscounts(decimal price, int accountTimeInYears)
        {
            decimal loyaltyDiscount = (accountTimeInYears > Constant.MAXIMUM_LOYALTY_DISCOUNT) ?
                   (decimal)Constant.MAXIMUM_LOYALTY_DISCOUNT / 100 : (decimal)accountTimeInYears / 100;

            return price - (loyaltyDiscount * price);
        }
    }
}