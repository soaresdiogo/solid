using solid_model_project.Interfaces;
using solid_model_project.Enums;

namespace solid_model_project
{
    public class DiscountManager
    {
        private readonly ICalculatesLoyaltyDiscount _loyaltyDiscount;
        private readonly ICalculatesAccountStatusDiscountFactory _accountStatusDiscount;
        public DiscountManager(ICalculatesLoyaltyDiscount loyaltyDiscount,
           ICalculatesAccountStatusDiscountFactory accountStatusDiscount)
        {
            _loyaltyDiscount = loyaltyDiscount;
            _accountStatusDiscount = accountStatusDiscount;

        }
        public decimal ApplyDiscount(decimal price, CustomerAccountStatus customerAccountStatus,
           int accountTimeInYears)
        {
            decimal priceAfterDiscount = 0;

            priceAfterDiscount = _accountStatusDiscount.
                GetCalculatesAccountStatusDiscount(customerAccountStatus).ApplyAccountStatusDiscounts(price);

            priceAfterDiscount = _loyaltyDiscount.
                ApplyLoyaltyDiscounts(priceAfterDiscount, accountTimeInYears);

            return priceAfterDiscount;
        }
    }
}