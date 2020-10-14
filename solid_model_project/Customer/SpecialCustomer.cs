using solid_model_project.Interfaces;
using solid_model_project.Constants;

namespace solid_model_project.Customer
{
    public class SpecialCustomer : ICalculatesAccountStatusDiscount
    {
        public decimal ApplyAccountStatusDiscounts(decimal price)
        {
            return (price - (Constant.SPECIAL_CUSTOMER_DISCOUNT * price));
        }
    }
}