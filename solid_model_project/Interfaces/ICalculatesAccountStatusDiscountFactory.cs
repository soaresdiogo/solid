using solid_model_project.Enums;
using solid_model_project.Interfaces;

namespace solid_model_project.Interfaces
{
    public interface ICalculatesAccountStatusDiscountFactory
    {
        ICalculatesAccountStatusDiscount GetCalculatesAccountStatusDiscount(CustomerAccountStatus customerAccountStatus);
    }
}