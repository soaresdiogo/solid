namespace solid_model_project.Interfaces
{
    public interface ICalculatesLoyaltyDiscount
    {
         decimal ApplyLoyaltyDiscounts(decimal price, int accountTimeInYears);
    }
}