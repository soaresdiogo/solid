using solid_model_project.Interfaces;

namespace solid_model_project.Customer
{
    public class UnregisteredCustomer : ICalculatesAccountStatusDiscount
    {
        public decimal ApplyAccountStatusDiscounts(decimal price)
        {
            return price;
        }
    }
}