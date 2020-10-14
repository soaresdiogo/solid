using System;
using solid_model_project.Enums;
using solid_model_project.Customer;
using solid_model_project.Interfaces;

namespace solid_model_project.Factories
{
    public class CalculatesAccountStatusDiscountFactory : ICalculatesAccountStatusDiscountFactory
    {
        public ICalculatesAccountStatusDiscount GetCalculatesAccountStatusDiscount(CustomerAccountStatus customerAccountStatus)
        {
            ICalculatesAccountStatusDiscount calculate;

            switch (customerAccountStatus)
            {
                case CustomerAccountStatus.NotRegistered:
                    calculate = new UnregisteredCustomer();
                    break;
                case CustomerAccountStatus.CommomCustomer:
                    calculate = new CommonCustomer();
                    break;
                case CustomerAccountStatus.SpecialCustomer:
                    calculate = new SpecialCustomer();
                    break;
                case CustomerAccountStatus.VipCustomer:
                    calculate = new VipCustomer();
                    break;
                default:
                    throw new NotImplementedException();
            }
            return calculate;
        }
    }
}