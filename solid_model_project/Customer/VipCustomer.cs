using solid_model_project.Interfaces;
using solid_model_project.Constants;

namespace solid_model_project.Customer
{
    public class VipCustomer : ICalculatesAccountStatusDiscount
    {
        public decimal ApplyAccountStatusDiscounts(decimal price)
        {
            return (price - (Constant.VIP_CUSTOMER_DISCOUNT * price));
        }
    }
}